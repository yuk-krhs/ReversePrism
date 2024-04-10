using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceAdvRewardTypeList                 000185D189F8 ModelEnumListType IReadOnlyList`1<ProduceAdvRewardType> IReadOnlyList`1<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer
    // 000 _parser                                  MessageParser`1<StartProduceAdvReply> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 020 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 028 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 02C MstSupportCharacterId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceAdvRewardTypeListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_produceAdvRewardTypeList_codec FieldCodec`1<ProduceAdvRewardType> IL2CPP_TYPE_GENERICINST
    // 030 ProduceAdvRewardTypeList                 000185CEA388 ModelEnumListType RepeatedField`1<ProduceAdvRewardType> RepeatedField`1<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer
    // 000 ProduceIdolParameterVariationFieldNumber int IL2CPP_TYPE_I4
    // 038 ProduceIdolParameterVariation            00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 010 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 040 ProduceCardList                          000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    // 000 GettableProduceCardAmountFieldNumber     int IL2CPP_TYPE_I4
    // 048 GettableProduceCardAmount                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PotentialSupportSkillFieldNumber         int IL2CPP_TYPE_I4
    // 050 PotentialSupportSkill                    000186678D40 ModelClassType GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus Pointer
    // 000 VitalityVariationFieldNumber             int IL2CPP_TYPE_I4
    // 058 VitalityVariation                        00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer
    // 000 ScenarioIdFieldNumber                    int IL2CPP_TYPE_I4
    // 060 ScenarioId                               000186671910 ModelPrimitiveType string string string String
    // 000 AdvOptionListFieldNumber                 int IL2CPP_TYPE_I4
    // 018 _repeated_advOptionList_codec            FieldCodec`1<ProduceAdvOptionStatus> IL2CPP_TYPE_GENERICINST
    // 068 AdvOptionList                            000185CEA148 ModelClassListType RepeatedField`1<ProduceAdvOptionStatus> RepeatedField`1<ProduceAdvOptionStatus> List<ProduceAdvOptionStatus> Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 020 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 070 ExertSupportEffectList                   000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
    // 000 ProduceAdvStateFieldNumber               int IL2CPP_TYPE_I4
    // 078 ProduceAdvState                          000186528E20 ModelClassType ProduceAdvStateStatus ProduceAdvStateStatus ProduceAdvStateStatus Pointer
    public partial class StartProduceAdvReply : DataModel
    {
        public List<ProduceAdvRewardType>?              ProduceAdvRewardTypeList                { get; set; }
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public ParameterVariationStatus?                ProduceIdolParameterVariation           { get; set; }
        public List<ProduceCardStatus>?                 ProduceCardList                         { get; set; }
        public int                                      GettableProduceCardAmount               { get; set; }
        public GettablePotentialSupportSkillStatus?     PotentialSupportSkill                   { get; set; }
        public VitalityVariationStatus?                 VitalityVariation                       { get; set; }
        public string                                   ScenarioId                              { get; set; }
        public List<ProduceAdvOptionStatus>?            AdvOptionList                           { get; set; }
        public List<ExertSupportEffectStatus>?          ExertSupportEffectList                  { get; set; }
        public ProduceAdvStateStatus?                   ProduceAdvState                         { get; set; }

        public static StartProduceAdvReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartProduceAdvReply() { Pointer= p0 };

            value.ProduceAdvRewardTypeList                  = GetEnumList<ProduceAdvRewardType>(new IntPtr(p + 0x030)); // 0246625809D0 0x30 ProduceAdvRewardTypeList    ( 000185CEA388 ModelEnumListType RepeatedField`1<ProduceAdvRewardType> RepeatedField`1<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer )
            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0246625808F0 0x20 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x028)); // 024662580930 0x28 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x02C)); // 024662580970 0x2C MstSupportCharacterId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceIdolParameterVariation             = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 024662580A10 0x38 ProduceIdolParameterVariation ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 024662580A70 0x40 ProduceCardList             ( 000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x048)); // 024662580AB0 0x48 GettableProduceCardAmount   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PotentialSupportSkill                     = GetObject<GettablePotentialSupportSkillStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.GettablePotentialSupportSkillStatus.FromPointer); // 024662580AF0 0x50 PotentialSupportSkill       ( 000186678D40 ModelClassType GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus Pointer )
            value.VitalityVariation                         = GetObject<VitalityVariationStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.VitalityVariationStatus.FromPointer); // 024662580B30 0x58 VitalityVariation           ( 00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer )
            value.ScenarioId                                = GetString(new IntPtr(p + 0x060)); // 024662580B70 0x60 ScenarioId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.AdvOptionList                             = GetObjectList<ProduceAdvOptionStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProduceAdvOptionStatus.FromPointer); // 024662580BD0 0x68 AdvOptionList               ( 000185CEA148 ModelClassListType RepeatedField`1<ProduceAdvOptionStatus> RepeatedField`1<ProduceAdvOptionStatus> List<ProduceAdvOptionStatus> Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 024662580C30 0x70 ExertSupportEffectList      ( 000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )
            value.ProduceAdvState                           = GetObject<ProduceAdvStateStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProduceAdvStateStatus.FromPointer); // 024662580C70 0x78 ProduceAdvState             ( 000186528E20 ModelClassType ProduceAdvStateStatus ProduceAdvStateStatus ProduceAdvStateStatus Pointer )

            return value;
        }
    }
}
