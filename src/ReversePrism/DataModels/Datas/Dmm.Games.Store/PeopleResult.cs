using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Items                                    ModelClassListType List`1<PeopleItem> List`1<PeopleItem> List<PeopleItem> Pointer
    // 018 TotalResults                             ModelPrimitiveType int int int Int32
    // 01C ItemsPerPage                             ModelPrimitiveType int int int Int32
    // 020 StartIndex                               ModelPrimitiveType int int int Int32
    public partial class PeopleResult : DataModel
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
            var value   = new PeopleResult() { Pointer= p0 };

            value.Items                                     = GetObjectList<PeopleItem>(new IntPtr(p + 0x010), ReversePrism.DataModels.PeopleItem.FromPointer); // 0x10 Items                       ( ModelClassListType List`1<PeopleItem> List`1<PeopleItem> List<PeopleItem> Pointer )
            value.TotalResults                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 TotalResults                ( ModelPrimitiveType int int int Int32 )
            value.ItemsPerPage                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ItemsPerPage                ( ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 StartIndex                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
