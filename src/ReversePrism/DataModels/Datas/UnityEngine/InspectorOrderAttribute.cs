using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_inspectorSort                          00018670B590 ModelEnumType InspectorSort InspectorSort InspectorSort Int32
    // 014 M_sortDirection                          00018670BD40 ModelEnumType InspectorSortDirection InspectorSortDirection InspectorSortDirection Int32
    public partial class InspectorOrderAttribute : DataModel
    {
        public InspectorSort                            M_inspectorSort                         { get; set; }
        public InspectorSortDirection                   M_sortDirection                         { get; set; }

        public static InspectorOrderAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InspectorOrderAttribute() { Pointer= p0 };

            value.M_inspectorSort                           = (InspectorSort)GetInt32(new IntPtr(p + 0x010)); // 0245A687C1D0 0x10 M_inspectorSort             ( 00018670B590 ModelEnumType InspectorSort InspectorSort InspectorSort Int32 )
            value.M_sortDirection                           = (InspectorSortDirection)GetInt32(new IntPtr(p + 0x014)); // 0245A687C1F0 0x14 M_sortDirection             ( 00018670BD40 ModelEnumType InspectorSortDirection InspectorSortDirection InspectorSortDirection Int32 )

            return value;
        }
    }
}
