using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer
    // 018 <OnSelectSchedule>k__BackingField        Func`3<IWeekScheduleStatus, IProduceBaseInfoStatus, ScheduleDetailType> IL2CPP_TYPE_GENERICINST
    // 020 <OnSelectProduceCard>k__BackingField     Func`5<IReadOnlyList`1<IProduceCardStatus>, int, IReadOnlyList`1<IProduceCardStatus>, IReadOnlyList`1<IInProduceIdolSkillStatus>, IReadOnlyList`1<string>> IL2CPP_TYPE_GENERICINST
    // 028 <OnDeleteProduceCard>k__BackingField     Func`4<IReadOnlyList`1<IProduceCardStatus>, int, IReadOnlyList`1<IInProduceIdolSkillStatus>, IReadOnlyList`1<string>> IL2CPP_TYPE_GENERICINST
    // 030 <OnExecScenarioAsync>k__BackingField     Func`4<ProduceNextOrderType, IProduceBaseInfoStatus, CancellationToken, UniTask`1<ValueTuple`2<ProduceNextOrderType, IProduceBaseInfoStatus>>> IL2CPP_TYPE_GENERICINST
    // 038 <OnExecInGameAsync>k__BackingField       Func`3<ProduceNextOrderType, CancellationToken, UniTask`1<ValueTuple`3<ProduceNextOrderType, IProduceBaseInfoStatus, bool>>> IL2CPP_TYPE_GENERICINST
    // 040 <OnStartSeasonAsync>k__BackingField      Func`4<IProduceTermStatus, ISubSeasonStatus, CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 048 <OnPostExecScheduleAsync>k__BackingField Func`7<ScheduleType, IScheduleDetailStatus, IProduceTermStatus, ISubSeasonStatus, bool, CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 050 <OnPostSingleExecScheduleAsync>k__BackingField Func`5<IProduceTermStatus, ISubSeasonStatus, bool, CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    public partial class ProduceSelectScheduleAutoExecModel
    {
        public ProduceService?                          Service                                 { get; set; }

        public static ProduceSelectScheduleAutoExecModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSelectScheduleAutoExecModel();

            value.Service                                   = GetObject<ProduceService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceService.FromPointer); // 0270DAE10820 0x10 Service                     ( 00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer )

            return value;
        }
    }
}
