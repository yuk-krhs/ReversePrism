using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_values                                 ModelClassListType FixupHolder[] FixupHolder[] List<FixupHolder> Pointer
    // 018 M_count                                  ModelPrimitiveType int int int Int32
    public partial class FixupHolderList : DataModel
    {
        public List<FixupHolder>?                       M_values                                { get; set; }
        public int                                      M_count                                 { get; set; }

        public static FixupHolderList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixupHolderList() { Pointer= p0 };

            value.M_values                                  = GetObjectList<FixupHolder>(new IntPtr(p + 0x010), ReversePrism.DataModels.FixupHolder.FromPointer); // 0x10 M_values                    ( ModelClassListType FixupHolder[] FixupHolder[] List<FixupHolder> Pointer )
            value.M_count                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_count                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
