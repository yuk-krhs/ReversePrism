using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WeekSchedule                             00018669CA60 ModelClassType IWeekScheduleStatus IWeekScheduleStatus IWeekScheduleStatus Pointer
    // 018 ProduceTerm                              0001865F5C80 ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer
    // 020 WeekIndex                                0001865F4260 ModelPrimitiveType int int int Int32
    // 028 SubSeason                                000186665040 ModelClassType ISubSeasonStatus ISubSeasonStatus ISubSeasonStatus Pointer
    public partial class ScheduleSelectionSchedulePanelViewModel
    {
        public IWeekScheduleStatus?                     WeekSchedule                            { get; set; }
        public IProduceTermStatus?                      ProduceTerm                             { get; set; }
        public int                                      WeekIndex                               { get; set; }
        public ISubSeasonStatus?                        SubSeason                               { get; set; }

        public static ScheduleSelectionSchedulePanelViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionSchedulePanelViewModel();

            value.WeekSchedule                              = GetObject<IWeekScheduleStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IWeekScheduleStatus.FromPointer); // 0270D683E278 0x10 WeekSchedule                ( 00018669CA60 ModelClassType IWeekScheduleStatus IWeekScheduleStatus IWeekScheduleStatus Pointer )
            value.ProduceTerm                               = GetObject<IProduceTermStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceTermStatus.FromPointer); // 0270D683E298 0x18 ProduceTerm                 ( 0001865F5C80 ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer )
            value.WeekIndex                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D683E2B8 0x20 WeekIndex                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SubSeason                                 = GetObject<ISubSeasonStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISubSeasonStatus.FromPointer); // 0270D683E2D8 0x28 SubSeason                   ( 000186665040 ModelClassType ISubSeasonStatus ISubSeasonStatus ISubSeasonStatus Pointer )

            return value;
        }
    }
}
