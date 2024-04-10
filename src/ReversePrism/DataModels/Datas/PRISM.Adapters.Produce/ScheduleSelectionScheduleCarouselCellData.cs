using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScheduleSelectionSchedulePanelViewModel  0001866E0820 ModelClassType ScheduleSelectionSchedulePanelViewModel ScheduleSelectionSchedulePanelViewModel ScheduleSelectionSchedulePanelViewModel Pointer
    // 018 Week                                     0001865F4260 ModelPrimitiveType int int int Int32
    public partial class ScheduleSelectionScheduleCarouselCellData : DataModel
    {
        public ScheduleSelectionSchedulePanelViewModel? ScheduleSelectionSchedulePanelViewModel { get; set; }
        public int                                      Week                                    { get; set; }

        public static ScheduleSelectionScheduleCarouselCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionScheduleCarouselCellData() { Pointer= p0 };

            value.ScheduleSelectionSchedulePanelViewModel   = GetObject<ScheduleSelectionSchedulePanelViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScheduleSelectionSchedulePanelViewModel.FromPointer); // 02466689E038 0x10 ScheduleSelectionSchedulePanelViewModel ( 0001866E0820 ModelClassType ScheduleSelectionSchedulePanelViewModel ScheduleSelectionSchedulePanelViewModel ScheduleSelectionSchedulePanelViewModel Pointer )
            value.Week                                      = GetInt32(new IntPtr(p + 0x018)); // 02466689E058 0x18 Week                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
