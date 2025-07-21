using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SupportCharacterInfoID                   ModelPrimitiveType int int int Int32
    // 014 ProduceIdolBaseID                        ModelPrimitiveType int int int Int32
    // 018 SupportScenarioID                        ModelPrimitiveType string string string String
    // 020 SupportCooperationEventRewardType        ModelPrimitiveType int int int Int32
    // 028 ProduceIdolParameterVariation            ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 030 GettableProduceCards                     ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 038 GettableProduceCardAmount                ModelPrimitiveType int int int Int32
    // 040 DeckProduceCards                         ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 048 ProduceBaseInfo                          ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 050 SelectableSupportSkillCount              ModelPrimitiveType int int int Int32
    // 058 GettablePotentialSupportSkillList        ModelClassListType IReadOnlyList`1<IGettablePotentialSupportSkillStatus> IReadOnlyList`1<IGettablePotentialSupportSkillStatus> List<IGettablePotentialSupportSkillStatus> Pointer
    // 060 PotentialSupportSkills                   ModelClassListType IInProducePotentialSupportSkillStatus[] IInProducePotentialSupportSkillStatus[] List<IInProducePotentialSupportSkillStatus> Pointer
    // 068 SupportSkillSlotAmount                   ModelPrimitiveType int int int Int32
    // 070 ReadState                                ModelClassType IProduceAdvStateStatus IProduceAdvStateStatus IProduceAdvStateStatus Pointer
    // 078 ExertSupportEffects                      ModelClassListType IReadOnlyList`1<IExertSupportEffectStatus> IReadOnlyList`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer
    public partial class SupportCooperationEventModel : DataModel
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
        public int                                      SelectableSupportSkillCount             { get; set; }
        public List<IGettablePotentialSupportSkillStatus>? GettablePotentialSupportSkillList       { get; set; }
        public List<IInProducePotentialSupportSkillStatus>? PotentialSupportSkills                  { get; set; }
        public int                                      SupportSkillSlotAmount                  { get; set; }
        public IProduceAdvStateStatus?                  ReadState                               { get; set; }
        public List<IExertSupportEffectStatus>?         ExertSupportEffects                     { get; set; }

        public static SupportCooperationEventModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCooperationEventModel() { Pointer= p0 };

            value.SupportCharacterInfoID                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 SupportCharacterInfoID      ( ModelPrimitiveType int int int Int32 )
            value.ProduceIdolBaseID                         = GetInt32(new IntPtr(p + 0x014)); // 0x14 ProduceIdolBaseID           ( ModelPrimitiveType int int int Int32 )
            value.SupportScenarioID                         = GetString(new IntPtr(p + 0x018)); // 0x18 SupportScenarioID           ( ModelPrimitiveType string string string String )
            value.SupportCooperationEventRewardType         = GetInt32(new IntPtr(p + 0x020)); // 0x20 SupportCooperationEventRewardType ( ModelPrimitiveType int int int Int32 )
            value.ProduceIdolParameterVariation             = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0x28 ProduceIdolParameterVariation ( ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.GettableProduceCards                      = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x30 GettableProduceCards        ( ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x038)); // 0x38 GettableProduceCardAmount   ( ModelPrimitiveType int int int Int32 )
            value.DeckProduceCards                          = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x40 DeckProduceCards            ( ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x48 ProduceBaseInfo             ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.SelectableSupportSkillCount               = GetInt32(new IntPtr(p + 0x050)); // 0x50 SelectableSupportSkillCount ( ModelPrimitiveType int int int Int32 )
            value.GettablePotentialSupportSkillList         = GetObjectList<IGettablePotentialSupportSkillStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IGettablePotentialSupportSkillStatus.FromPointer); // 0x58 GettablePotentialSupportSkillList ( ModelClassListType IReadOnlyList`1<IGettablePotentialSupportSkillStatus> IReadOnlyList`1<IGettablePotentialSupportSkillStatus> List<IGettablePotentialSupportSkillStatus> Pointer )
            value.PotentialSupportSkills                    = GetObjectList<IInProducePotentialSupportSkillStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IInProducePotentialSupportSkillStatus.FromPointer); // 0x60 PotentialSupportSkills      ( ModelClassListType IInProducePotentialSupportSkillStatus[] IInProducePotentialSupportSkillStatus[] List<IInProducePotentialSupportSkillStatus> Pointer )
            value.SupportSkillSlotAmount                    = GetInt32(new IntPtr(p + 0x068)); // 0x68 SupportSkillSlotAmount      ( ModelPrimitiveType int int int Int32 )
            value.ReadState                                 = GetObject<IProduceAdvStateStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IProduceAdvStateStatus.FromPointer); // 0x70 ReadState                   ( ModelClassType IProduceAdvStateStatus IProduceAdvStateStatus IProduceAdvStateStatus Pointer )
            value.ExertSupportEffects                       = GetObjectList<IExertSupportEffectStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IExertSupportEffectStatus.FromPointer); // 0x78 ExertSupportEffects         ( ModelClassListType IReadOnlyList`1<IExertSupportEffectStatus> IReadOnlyList`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer )

            return value;
        }
    }
}
