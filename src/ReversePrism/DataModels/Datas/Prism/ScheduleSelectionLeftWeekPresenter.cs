using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186626510 ModelClassType IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView Pointer
    public partial class ScheduleSelectionLeftWeekPresenter : DataModel
    {
        public IScheduleSelectionLeftWeekView?          View                                    { get; set; }

        public static ScheduleSelectionLeftWeekPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionLeftWeekPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IScheduleSelectionLeftWeekView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScheduleSelectionLeftWeekView.FromPointer); // 024665EB2728 0x10 View                        ( 000186626510 ModelClassType IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView Pointer )

            return value;
        }
    }
}
