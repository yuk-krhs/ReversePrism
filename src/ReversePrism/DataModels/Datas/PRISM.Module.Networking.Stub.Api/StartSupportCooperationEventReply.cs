using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartSupportCooperationEventReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 020 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 024 MstSupportCharacterId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SupportCooperationEventRewardTypeFieldNumber int IL2CPP_TYPE_I4
    // 028 SupportCooperationEventRewardType        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceIdolParameterVariationFieldNumber int IL2CPP_TYPE_I4
    // 030 ProduceIdolParameterVariation            00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 038 ProduceCardList                          000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    // 000 GettableProduceCardAmountFieldNumber     int IL2CPP_TYPE_I4
    // 040 GettableProduceCardAmount                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PotentialSupportSkillFieldNumber         int IL2CPP_TYPE_I4
    // 048 PotentialSupportSkill                    000186678D40 ModelClassType GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 050 ExertSupportEffectList                   000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
    // 000 ScenarioIdFieldNumber                    int IL2CPP_TYPE_I4
    // 058 ScenarioId                               000186671910 ModelPrimitiveType string string string String
    // 000 ProduceAdvStateFieldNumber               int IL2CPP_TYPE_I4
    // 060 ProduceAdvState                          000186528E20 ModelClassType ProduceAdvStateStatus ProduceAdvStateStatus ProduceAdvStateStatus Pointer
    public partial class StartSupportCooperationEventReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public int                                      SupportCooperationEventRewardType       { get; set; }
        public ParameterVariationStatus?                ProduceIdolParameterVariation           { get; set; }
        public List<ProduceCardStatus>?                 ProduceCardList                         { get; set; }
        public int                                      GettableProduceCardAmount               { get; set; }
        public GettablePotentialSupportSkillStatus?     PotentialSupportSkill                   { get; set; }
        public List<ExertSupportEffectStatus>?          ExertSupportEffectList                  { get; set; }
        public string                                   ScenarioId                              { get; set; }
        public ProduceAdvStateStatus?                   ProduceAdvState                         { get; set; }

        public static StartSupportCooperationEventReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartSupportCooperationEventReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0246625A43C8 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x020)); // 0246625A4408 0x20 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x024)); // 0246625A4448 0x24 MstSupportCharacterId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SupportCooperationEventRewardType         = GetInt32(new IntPtr(p + 0x028)); // 0246625A4488 0x28 SupportCooperationEventRewardType ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceIdolParameterVariation             = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0246625A44C8 0x30 ProduceIdolParameterVariation ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 0246625A4528 0x38 ProduceCardList             ( 000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x040)); // 0246625A4568 0x40 GettableProduceCardAmount   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PotentialSupportSkill                     = GetObject<GettablePotentialSupportSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.GettablePotentialSupportSkillStatus.FromPointer); // 0246625A45A8 0x48 PotentialSupportSkill       ( 000186678D40 ModelClassType GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 0246625A4608 0x50 ExertSupportEffectList      ( 000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )
            value.ScenarioId                                = GetString(new IntPtr(p + 0x058)); // 0246625A4648 0x58 ScenarioId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.ProduceAdvState                           = GetObject<ProduceAdvStateStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProduceAdvStateStatus.FromPointer); // 0246625A4688 0x60 ProduceAdvState             ( 000186528E20 ModelClassType ProduceAdvStateStatus ProduceAdvStateStatus ProduceAdvStateStatus Pointer )

            return value;
        }
    }
}
