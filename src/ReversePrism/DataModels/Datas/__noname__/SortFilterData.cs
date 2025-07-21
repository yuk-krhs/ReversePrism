using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortCategoryType                         ModelPrimitiveType int int int Int32
    // 014 SortOrderType                            ModelPrimitiveType int int int Int32
    public partial class SortFilterData : DataModel
    {
        public int                                      SortCategoryType                        { get; set; }
        public int                                      SortOrderType                           { get; set; }

        public static SortFilterData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortFilterData() { Pointer= p0 };

            value.SortCategoryType                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 SortCategoryType            ( ModelPrimitiveType int int int Int32 )
            value.SortOrderType                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 SortOrderType               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
