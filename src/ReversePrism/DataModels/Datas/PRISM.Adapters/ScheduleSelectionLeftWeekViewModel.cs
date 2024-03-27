using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheProduceTerm                         0001865F57A0 ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer
    // 018 CacheSubSeason                           000186664B40 ModelClassType ISubSeasonStatus ISubSeasonStatus ISubSeasonStatus Pointer
    public partial class ScheduleSelectionLeftWeekViewModel
    {
        public IProduceTermStatus?                      CacheProduceTerm                        { get; set; }
        public ISubSeasonStatus?                        CacheSubSeason                          { get; set; }

        public static ScheduleSelectionLeftWeekViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionLeftWeekViewModel();

            value.CacheProduceTerm                          = GetObject<IProduceTermStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceTermStatus.FromPointer); // 0270D5E42360 0x10 CacheProduceTerm            ( 0001865F57A0 ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer )
            value.CacheSubSeason                            = GetObject<ISubSeasonStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISubSeasonStatus.FromPointer); // 0270D5E42380 0x18 CacheSubSeason              ( 000186664B40 ModelClassType ISubSeasonStatus ISubSeasonStatus ISubSeasonStatus Pointer )

            return value;
        }
    }
}
