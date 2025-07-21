using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScheduleSelectionView                    ModelClassType ScheduleSelectionView ScheduleSelectionView ScheduleSelectionView Pointer
    public partial class ScheduleSelectionBuilder : DataModel
    {
        public ScheduleSelectionView?                   ScheduleSelectionView                   { get; set; }

        public static ScheduleSelectionBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionBuilder() { Pointer= p0 };

            value.ScheduleSelectionView                     = GetObject<ScheduleSelectionView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScheduleSelectionView.FromPointer); // 0x20 ScheduleSelectionView       ( ModelClassType ScheduleSelectionView ScheduleSelectionView ScheduleSelectionView Pointer )

            return value;
        }
    }
}
