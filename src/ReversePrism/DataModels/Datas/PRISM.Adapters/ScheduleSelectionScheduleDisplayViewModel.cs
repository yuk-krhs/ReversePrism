using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheWeekScheduleList                    000185CEA198 ModelClassListType List`1<IWeekScheduleStatus> List`1<IWeekScheduleStatus> List<IWeekScheduleStatus> Pointer
    // 018 CacheProduceTerm                         0001865F57A0 ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer
    // 020 CacheSubSeason                           000186664B40 ModelClassType ISubSeasonStatus ISubSeasonStatus ISubSeasonStatus Pointer
    public partial class ScheduleSelectionScheduleDisplayViewModel
    {
        public List<IWeekScheduleStatus>?               CacheWeekScheduleList                   { get; set; }
        public IProduceTermStatus?                      CacheProduceTerm                        { get; set; }
        public ISubSeasonStatus?                        CacheSubSeason                          { get; set; }

        public static ScheduleSelectionScheduleDisplayViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionScheduleDisplayViewModel();

            value.CacheWeekScheduleList                     = GetObjectList<IWeekScheduleStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IWeekScheduleStatus.FromPointer); // 0270D66462F0 0x10 CacheWeekScheduleList       ( 000185CEA198 ModelClassListType List`1<IWeekScheduleStatus> List`1<IWeekScheduleStatus> List<IWeekScheduleStatus> Pointer )
            value.CacheProduceTerm                          = GetObject<IProduceTermStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceTermStatus.FromPointer); // 0270D6646310 0x18 CacheProduceTerm            ( 0001865F57A0 ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer )
            value.CacheSubSeason                            = GetObject<ISubSeasonStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISubSeasonStatus.FromPointer); // 0270D6646330 0x20 CacheSubSeason              ( 000186664B40 ModelClassType ISubSeasonStatus ISubSeasonStatus ISubSeasonStatus Pointer )

            return value;
        }
    }
}
