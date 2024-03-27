using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Items                                    000185CF8BA8 ModelClassListType List`1<PeopleItem> List`1<PeopleItem> List<PeopleItem> Pointer
    // 018 TotalResults                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C ItemsPerPage                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 StartIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class PeopleResult
    {
        public List<PeopleItem>?                        Items                                   { get; set; }
        public int                                      TotalResults                            { get; set; }
        public int                                      ItemsPerPage                            { get; set; }
        public int                                      StartIndex                              { get; set; }

        public static PeopleResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PeopleResult();

            value.Items                                     = GetObjectList<PeopleItem>(new IntPtr(p + 0x010), ReversePrism.DataModels.PeopleItem.FromPointer); // 0270DB4C19A8 0x10 Items                       ( 000185CF8BA8 ModelClassListType List`1<PeopleItem> List`1<PeopleItem> List<PeopleItem> Pointer )
            value.TotalResults                              = GetInt32(new IntPtr(p + 0x018)); // 0270DB4C19C8 0x18 TotalResults                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ItemsPerPage                              = GetInt32(new IntPtr(p + 0x01C)); // 0270DB4C19E8 0x1C ItemsPerPage                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x020)); // 0270DB4C1A08 0x20 StartIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
