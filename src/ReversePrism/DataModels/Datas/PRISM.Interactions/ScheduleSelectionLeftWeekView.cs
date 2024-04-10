using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScheduleSelectScheduleLabel              0001866D7DC0 ModelClassType ScheduleSelectScheduleLabel ScheduleSelectScheduleLabel ScheduleSelectScheduleLabel Pointer
    // 028 LeftWeekViewModel                        0001866DB5B0 ModelClassType ScheduleSelectionLeftWeekViewModel ScheduleSelectionLeftWeekViewModel ScheduleSelectionLeftWeekViewModel Pointer
    public partial class ScheduleSelectionLeftWeekView : DataModel
    {
        public ScheduleSelectScheduleLabel?             ScheduleSelectScheduleLabel             { get; set; }
        public ScheduleSelectionLeftWeekViewModel?      LeftWeekViewModel                       { get; set; }

        public static ScheduleSelectionLeftWeekView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionLeftWeekView() { Pointer= p0 };

            value.ScheduleSelectScheduleLabel               = GetObject<ScheduleSelectScheduleLabel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScheduleSelectScheduleLabel.FromPointer); // 02466A1E9050 0x20 ScheduleSelectScheduleLabel ( 0001866D7DC0 ModelClassType ScheduleSelectScheduleLabel ScheduleSelectScheduleLabel ScheduleSelectScheduleLabel Pointer )
            value.LeftWeekViewModel                         = GetObject<ScheduleSelectionLeftWeekViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScheduleSelectionLeftWeekViewModel.FromPointer); // 02466A1E9070 0x28 LeftWeekViewModel           ( 0001866DB5B0 ModelClassType ScheduleSelectionLeftWeekViewModel ScheduleSelectionLeftWeekViewModel ScheduleSelectionLeftWeekViewModel Pointer )

            return value;
        }
    }
}
