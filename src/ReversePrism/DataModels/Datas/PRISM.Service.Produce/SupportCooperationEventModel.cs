using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SupportCharacterInfoID                   0001865F4940 ModelPrimitiveType int int int Int32
    // 014 ProduceIdolBaseID                        0001865F4940 ModelPrimitiveType int int int Int32
    // 018 SupportScenarioID                        0001866736C0 ModelPrimitiveType string string string String
    // 020 SupportCooperationEventRewardType        0001865F4940 ModelPrimitiveType int int int Int32
    // 028 ProduceIdolParameterVariation            0001865D2650 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 030 GettableProduceCards                     000185D06128 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 038 GettableProduceCardAmount                0001865F4940 ModelPrimitiveType int int int Int32
    // 040 DeckProduceCards                         000185D06128 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 048 ProduceBaseInfo                          0001865E3840 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 050 GettablePotentialSupportSkill            000186559E00 ModelClassType IGettablePotentialSupportSkillStatus IGettablePotentialSupportSkillStatus IGettablePotentialSupportSkillStatus Pointer
    // 058 PotentialSupportSkills                   000185B876C0 ModelClassListType IInProducePotentialSupportSkillStatus[] IInProducePotentialSupportSkillStatus[] List<IInProducePotentialSupportSkillStatus> Pointer
    // 060 SupportSkillSlotAmount                   0001865F4940 ModelPrimitiveType int int int Int32
    // 068 ReadState                                0001865E04F0 ModelClassType IProduceAdvStateStatus IProduceAdvStateStatus IProduceAdvStateStatus Pointer
    // 070 ExertSupportEffects                      000185CF6758 ModelClassListType IReadOnlyList`1<IExertSupportEffectStatus> IReadOnlyList`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer
    public partial class SupportCooperationEventModel
    {
        public int                                      SupportCharacterInfoID                  { get; set; }
        public int                                      ProduceIdolBaseID                       { get; set; }
        public string                                   SupportScenarioID                       { get; set; }
        public int                                      SupportCooperationEventRewardType       { get; set; }
        public IParameterVariationStatus?               ProduceIdolParameterVariation           { get; set; }
        public List<IProduceCardStatus>?                GettableProduceCards                    { get; set; }
        public int                                      GettableProduceCardAmount               { get; set; }
        public List<IProduceCardStatus>?                DeckProduceCards                        { get; set; }
        public IProduceBaseInfoStatus?                  ProduceBaseInfo                         { get; set; }
        public IGettablePotentialSupportSkillStatus?    GettablePotentialSupportSkill           { get; set; }
        public List<IInProducePotentialSupportSkillStatus>? PotentialSupportSkills                  { get; set; }
        public int                                      SupportSkillSlotAmount                  { get; set; }
        public IProduceAdvStateStatus?                  ReadState                               { get; set; }
        public List<IExertSupportEffectStatus>?         ExertSupportEffects                     { get; set; }

        public static SupportCooperationEventModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCooperationEventModel();

            value.SupportCharacterInfoID                    = GetInt32(new IntPtr(p + 0x010)); // 0270D55E38B0 0x10 SupportCharacterInfoID      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ProduceIdolBaseID                         = GetInt32(new IntPtr(p + 0x014)); // 0270D55E38D0 0x14 ProduceIdolBaseID           ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.SupportScenarioID                         = GetString(new IntPtr(p + 0x018)); // 0270D55E38F0 0x18 SupportScenarioID           ( 0001866736C0 ModelPrimitiveType string string string String )
            value.SupportCooperationEventRewardType         = GetInt32(new IntPtr(p + 0x020)); // 0270D55E3910 0x20 SupportCooperationEventRewardType ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ProduceIdolParameterVariation             = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0270D55E3930 0x28 ProduceIdolParameterVariation ( 0001865D2650 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.GettableProduceCards                      = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D55E3950 0x30 GettableProduceCards        ( 000185D06128 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x038)); // 0270D55E3970 0x38 GettableProduceCardAmount   ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.DeckProduceCards                          = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D55E3990 0x40 DeckProduceCards            ( 000185D06128 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0270D55E39B0 0x48 ProduceBaseInfo             ( 0001865E3840 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.GettablePotentialSupportSkill             = GetObject<IGettablePotentialSupportSkillStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IGettablePotentialSupportSkillStatus.FromPointer); // 0270D55E39D0 0x50 GettablePotentialSupportSkill ( 000186559E00 ModelClassType IGettablePotentialSupportSkillStatus IGettablePotentialSupportSkillStatus IGettablePotentialSupportSkillStatus Pointer )
            value.PotentialSupportSkills                    = GetObjectList<IInProducePotentialSupportSkillStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IInProducePotentialSupportSkillStatus.FromPointer); // 0270D55E39F0 0x58 PotentialSupportSkills      ( 000185B876C0 ModelClassListType IInProducePotentialSupportSkillStatus[] IInProducePotentialSupportSkillStatus[] List<IInProducePotentialSupportSkillStatus> Pointer )
            value.SupportSkillSlotAmount                    = GetInt32(new IntPtr(p + 0x060)); // 0270D55E3A10 0x60 SupportSkillSlotAmount      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ReadState                                 = GetObject<IProduceAdvStateStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IProduceAdvStateStatus.FromPointer); // 0270D55E3A30 0x68 ReadState                   ( 0001865E04F0 ModelClassType IProduceAdvStateStatus IProduceAdvStateStatus IProduceAdvStateStatus Pointer )
            value.ExertSupportEffects                       = GetObjectList<IExertSupportEffectStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IExertSupportEffectStatus.FromPointer); // 0270D55E3A50 0x70 ExertSupportEffects         ( 000185CF6758 ModelClassListType IReadOnlyList`1<IExertSupportEffectStatus> IReadOnlyList`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer )

            return value;
        }
    }
}
