using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheWeekScheduleList                    000185CEA198 ModelClassListType List`1<IWeekScheduleStatus> List`1<IWeekScheduleStatus> List<IWeekScheduleStatus> Pointer
    public partial class WeekScheduleListViewModel
    {
        public List<IWeekScheduleStatus>?               CacheWeekScheduleList                   { get; set; }

        public static WeekScheduleListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WeekScheduleListViewModel();

            value.CacheWeekScheduleList                     = GetObjectList<IWeekScheduleStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IWeekScheduleStatus.FromPointer); // 0270D65C3588 0x10 CacheWeekScheduleList       ( 000185CEA198 ModelClassListType List`1<IWeekScheduleStatus> List`1<IWeekScheduleStatus> List<IWeekScheduleStatus> Pointer )

            return value;
        }
    }
}
