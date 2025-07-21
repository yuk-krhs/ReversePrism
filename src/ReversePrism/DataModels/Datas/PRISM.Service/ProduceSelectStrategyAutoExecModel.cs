using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  ModelClassType ProduceService ProduceService ProduceService Pointer
    // 018 <OnSelectStrategy>k__BackingField        Func`2<IReadOnlyList`1<IProduceStrategyStatus>, int> IL2CPP_TYPE_GENERICINST
    // 020 <OnSelectSupportSkill>k__BackingField    Func`5<IReadOnlyList`1<IGettablePotentialSupportSkillStatus>, IReadOnlyList`1<IInProducePotentialSupportSkillStatus>, int, int, IReadOnlyList`1<ISelectionSupportSkillStatus>> IL2CPP_TYPE_GENERICINST
    // 028 <OnExecScenarioAsync>k__BackingField     Func`4<ProduceNextOrderType, IProduceBaseInfoStatus, CancellationToken, UniTask`1<ValueTuple`2<ProduceNextOrderType, IProduceBaseInfoStatus>>> IL2CPP_TYPE_GENERICINST
    public partial class ProduceSelectStrategyAutoExecModel : DataModel
    {
        public ProduceService?                          Service                                 { get; set; }

        public static ProduceSelectStrategyAutoExecModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSelectStrategyAutoExecModel() { Pointer= p0 };

            value.Service                                   = GetObject<ProduceService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceService.FromPointer); // 0x10 Service                     ( ModelClassType ProduceService ProduceService ProduceService Pointer )

            return value;
        }
    }
}
