using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Match                                    0001865DC990 ModelClassType Match Match Match Pointer
    // 018 CaptureMap                               0001865DF1C0 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 Groups                                   000185B838B0 ModelClassListType Group[] Group[] List<Group> Pointer
    public partial class GroupCollection
    {
        public Match?                                   Match                                   { get; set; }
        public Hashtable?                               CaptureMap                              { get; set; }
        public List<Group>?                             Groups                                  { get; set; }

        public static GroupCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GroupCollection();

            value.Match                                     = GetObject<Match>(new IntPtr(p + 0x010), ReversePrism.DataModels.Match.FromPointer); // 027006F41570 0x10 Match                       ( 0001865DC990 ModelClassType Match Match Match Pointer )
            value.CaptureMap                                = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 027006F41590 0x18 CaptureMap                  ( 0001865DF1C0 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Groups                                    = GetObjectList<Group>(new IntPtr(p + 0x020), ReversePrism.DataModels.Group.FromPointer); // 027006F415B0 0x20 Groups                      ( 000185B838B0 ModelClassListType Group[] Group[] List<Group> Pointer )

            return value;
        }
    }
}
