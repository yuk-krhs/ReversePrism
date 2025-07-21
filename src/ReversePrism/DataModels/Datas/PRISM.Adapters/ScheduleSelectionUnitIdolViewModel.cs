using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheProduceUnit                         ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer
    // 018 CacheSelectedEpisode                     ModelClassType ISelectedEpisodeStatus ISelectedEpisodeStatus ISelectedEpisodeStatus Pointer
    // 020 CacheProduceIdolList                     ModelClassListType IReadOnlyList`1<IProduceIdolStatus> IReadOnlyList`1<IProduceIdolStatus> List<IProduceIdolStatus> Pointer
    public partial class ScheduleSelectionUnitIdolViewModel : DataModel
    {
        public IProduceUnitStatus?                      CacheProduceUnit                        { get; set; }
        public ISelectedEpisodeStatus?                  CacheSelectedEpisode                    { get; set; }
        public List<IProduceIdolStatus>?                CacheProduceIdolList                    { get; set; }

        public static ScheduleSelectionUnitIdolViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionUnitIdolViewModel() { Pointer= p0 };

            value.CacheProduceUnit                          = GetObject<IProduceUnitStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceUnitStatus.FromPointer); // 0x10 CacheProduceUnit            ( ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer )
            value.CacheSelectedEpisode                      = GetObject<ISelectedEpisodeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISelectedEpisodeStatus.FromPointer); // 0x18 CacheSelectedEpisode        ( ModelClassType ISelectedEpisodeStatus ISelectedEpisodeStatus ISelectedEpisodeStatus Pointer )
            value.CacheProduceIdolList                      = GetObjectList<IProduceIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0x20 CacheProduceIdolList        ( ModelClassListType IReadOnlyList`1<IProduceIdolStatus> IReadOnlyList`1<IProduceIdolStatus> List<IProduceIdolStatus> Pointer )

            return value;
        }
    }
}
