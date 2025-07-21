using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheWeekScheduleList                    ModelClassListType List`1<IWeekScheduleStatus> List`1<IWeekScheduleStatus> List<IWeekScheduleStatus> Pointer
    // 018 CacheProduceTerm                         ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer
    // 020 CacheSubSeason                           ModelClassType ISubSeasonStatus ISubSeasonStatus ISubSeasonStatus Pointer
    public partial class ScheduleSelectionScheduleDisplayViewModel : DataModel
    {
        public List<IWeekScheduleStatus>?               CacheWeekScheduleList                   { get; set; }
        public IProduceTermStatus?                      CacheProduceTerm                        { get; set; }
        public ISubSeasonStatus?                        CacheSubSeason                          { get; set; }

        public static ScheduleSelectionScheduleDisplayViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionScheduleDisplayViewModel() { Pointer= p0 };

            value.CacheWeekScheduleList                     = GetObjectList<IWeekScheduleStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IWeekScheduleStatus.FromPointer); // 0x10 CacheWeekScheduleList       ( ModelClassListType List`1<IWeekScheduleStatus> List`1<IWeekScheduleStatus> List<IWeekScheduleStatus> Pointer )
            value.CacheProduceTerm                          = GetObject<IProduceTermStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceTermStatus.FromPointer); // 0x18 CacheProduceTerm            ( ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer )
            value.CacheSubSeason                            = GetObject<ISubSeasonStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISubSeasonStatus.FromPointer); // 0x20 CacheSubSeason              ( ModelClassType ISubSeasonStatus ISubSeasonStatus ISubSeasonStatus Pointer )

            return value;
        }
    }
}
