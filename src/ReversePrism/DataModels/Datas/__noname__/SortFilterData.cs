using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortCategoryType                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 SortOrderType                            0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class SortFilterData
    {
        public int                                      SortCategoryType                        { get; set; }
        public int                                      SortOrderType                           { get; set; }

        public static SortFilterData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortFilterData();

            value.SortCategoryType                          = GetInt32(new IntPtr(p + 0x010)); // 0270DAE4E8A8 0x10 SortCategoryType            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SortOrderType                             = GetInt32(new IntPtr(p + 0x014)); // 0270DAE4E8C8 0x14 SortOrderType               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
