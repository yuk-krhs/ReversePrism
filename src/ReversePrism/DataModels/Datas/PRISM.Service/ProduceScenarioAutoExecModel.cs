using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer
    // 018 <OnSelectProduceCard>k__BackingField     Func`5<IReadOnlyList`1<IProduceCardStatus>, int, IReadOnlyList`1<IProduceCardStatus>, IReadOnlyList`1<IInProduceIdolSkillStatus>, IReadOnlyList`1<string>> IL2CPP_TYPE_GENERICINST
    // 020 <OnSelectSupportSkill>k__BackingField    Func`4<IGettablePotentialSupportSkillStatus, IReadOnlyList`1<IInProducePotentialSupportSkillStatus>, int, ISelectionSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 028 <OnSelectADVOption>k__BackingField       Func`2<IReadOnlyList`1<IProduceAdvOptionStatus>, int> IL2CPP_TYPE_GENERICINST
    // 030 <OnInheritanceSkill>k__BackingField      Func`4<IReadOnlyList`1<IGettablePotentialSupportSkillStatus>, IReadOnlyList`1<IInProducePotentialSupportSkillStatus>, int, ISelectionSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 038 <OnSelectSubSeason>k__BackingField       Func`2<IReadOnlyList`1<int>, int> IL2CPP_TYPE_GENERICINST
    // 040 <OnSelectSubSeasonIdol>k__BackingField   Func`2<IReadOnlyList`1<int>, int> IL2CPP_TYPE_GENERICINST
    public partial class ProduceScenarioAutoExecModel
    {
        public ProduceService?                          Service                                 { get; set; }

        public static ProduceScenarioAutoExecModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceScenarioAutoExecModel();

            value.Service                                   = GetObject<ProduceService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceService.FromPointer); // 0270DAE11460 0x10 Service                     ( 00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer )

            return value;
        }
    }
}
