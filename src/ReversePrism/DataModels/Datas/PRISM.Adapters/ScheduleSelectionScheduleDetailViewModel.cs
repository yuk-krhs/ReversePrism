using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheweekScheduleList                    ModelClassListType List`1<IWeekScheduleStatus> List`1<IWeekScheduleStatus> List<IWeekScheduleStatus> Pointer
    // 018 CacheProduceBaseInfo                     ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 020 CacheProduceTerm                         ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer
    public partial class ScheduleSelectionScheduleDetailViewModel : DataModel
    {
        public List<IWeekScheduleStatus>?               CacheweekScheduleList                   { get; set; }
        public IProduceBaseInfoStatus?                  CacheProduceBaseInfo                    { get; set; }
        public IProduceTermStatus?                      CacheProduceTerm                        { get; set; }

        public static ScheduleSelectionScheduleDetailViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionScheduleDetailViewModel() { Pointer= p0 };

            value.CacheweekScheduleList                     = GetObjectList<IWeekScheduleStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IWeekScheduleStatus.FromPointer); // 0x10 CacheweekScheduleList       ( ModelClassListType List`1<IWeekScheduleStatus> List`1<IWeekScheduleStatus> List<IWeekScheduleStatus> Pointer )
            value.CacheProduceBaseInfo                      = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x18 CacheProduceBaseInfo        ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.CacheProduceTerm                          = GetObject<IProduceTermStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceTermStatus.FromPointer); // 0x20 CacheProduceTerm            ( ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer )

            return value;
        }
    }
}
