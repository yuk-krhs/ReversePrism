using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 FilterValue                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PIdolIconSortFilterItem : DataModel
    {
        public int                                      FilterValue                             { get; set; }

        public static PIdolIconSortFilterItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolIconSortFilterItem() { Pointer= p0 };

            value.FilterValue                               = GetInt32(new IntPtr(p + 0x018)); // 024664CEEDB0 0x18 FilterValue                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
