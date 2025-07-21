using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceAdvRewardTypeList                 ModelEnumListType List<ProduceAdvRewardType> List<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer
    // 000 _parser                                  MessageParser`1<StartProduceAdvReply> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 020 ProduceBaseInfo                          ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 028 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 02C MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 000 ProduceAdvRewardTypeListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_produceAdvRewardTypeList_codec FieldCodec`1<ProduceAdvRewardType> IL2CPP_TYPE_GENERICINST
    // 030 ProduceAdvRewardTypeList                 ModelEnumListType RepeatedField`1<ProduceAdvRewardType> RepeatedField`1<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer
    // 000 ProduceIdolParameterVariationFieldNumber int IL2CPP_TYPE_I4
    // 038 ProduceIdolParameterVariation            ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 010 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 040 ProduceCardList                          ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    // 000 GettableProduceCardAmountFieldNumber     int IL2CPP_TYPE_I4
    // 048 GettableProduceCardAmount                ModelPrimitiveType int int int Int32
    // 000 PotentialSupportSkillFieldNumber         int IL2CPP_TYPE_I4
    // 050 PotentialSupportSkill                    ModelClassType GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus Pointer
    // 000 VitalityVariationFieldNumber             int IL2CPP_TYPE_I4
    // 058 VitalityVariation                        ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer
    // 000 ScenarioIdFieldNumber                    int IL2CPP_TYPE_I4
    // 060 ScenarioId                               ModelPrimitiveType string string string String
    // 000 AdvOptionListFieldNumber                 int IL2CPP_TYPE_I4
    // 018 _repeated_advOptionList_codec            FieldCodec`1<ProduceAdvOptionStatus> IL2CPP_TYPE_GENERICINST
    // 068 AdvOptionList                            ModelClassListType RepeatedField`1<ProduceAdvOptionStatus> RepeatedField`1<ProduceAdvOptionStatus> List<ProduceAdvOptionStatus> Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 020 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 070 ExertSupportEffectList                   ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
    // 000 ProduceAdvStateFieldNumber               int IL2CPP_TYPE_I4
    // 078 ProduceAdvState                          ModelClassType ProduceAdvStateStatus ProduceAdvStateStatus ProduceAdvStateStatus Pointer
    // 000 PotentialSupportSkillListFieldNumber     int IL2CPP_TYPE_I4
    // 028 _repeated_potentialSupportSkillList_codec FieldCodec`1<GettablePotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 080 PotentialSupportSkillList                ModelClassListType RepeatedField`1<GettablePotentialSupportSkillStatus> RepeatedField`1<GettablePotentialSupportSkillStatus> List<GettablePotentialSupportSkillStatus> Pointer
    // 000 SelectableSupportSkillCountFieldNumber   int IL2CPP_TYPE_I4
    // 088 SelectableSupportSkillCount              ModelPrimitiveType int int int Int32
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
        public List<GettablePotentialSupportSkillStatus>? PotentialSupportSkillList               { get; set; }
        public int                                      SelectableSupportSkillCount             { get; set; }

        public static StartProduceAdvReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartProduceAdvReply() { Pointer= p0 };

            value.ProduceAdvRewardTypeList                  = GetEnumList<ProduceAdvRewardType>(new IntPtr(p + 0x030)); // 0x30 ProduceAdvRewardTypeList    ( ModelEnumListType RepeatedField`1<ProduceAdvRewardType> RepeatedField`1<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer )
            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0x20 ProduceBaseInfo             ( ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.ProduceIdolParameterVariation             = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0x38 ProduceIdolParameterVariation ( ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 0x40 ProduceCardList             ( ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x048)); // 0x48 GettableProduceCardAmount   ( ModelPrimitiveType int int int Int32 )
            value.PotentialSupportSkill                     = GetObject<GettablePotentialSupportSkillStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.GettablePotentialSupportSkillStatus.FromPointer); // 0x50 PotentialSupportSkill       ( ModelClassType GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus Pointer )
            value.VitalityVariation                         = GetObject<VitalityVariationStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.VitalityVariationStatus.FromPointer); // 0x58 VitalityVariation           ( ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer )
            value.ScenarioId                                = GetString(new IntPtr(p + 0x060)); // 0x60 ScenarioId                  ( ModelPrimitiveType string string string String )
            value.AdvOptionList                             = GetObjectList<ProduceAdvOptionStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProduceAdvOptionStatus.FromPointer); // 0x68 AdvOptionList               ( ModelClassListType RepeatedField`1<ProduceAdvOptionStatus> RepeatedField`1<ProduceAdvOptionStatus> List<ProduceAdvOptionStatus> Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 0x70 ExertSupportEffectList      ( ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )
            value.ProduceAdvState                           = GetObject<ProduceAdvStateStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProduceAdvStateStatus.FromPointer); // 0x78 ProduceAdvState             ( ModelClassType ProduceAdvStateStatus ProduceAdvStateStatus ProduceAdvStateStatus Pointer )
            value.PotentialSupportSkillList                 = GetObjectList<GettablePotentialSupportSkillStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.GettablePotentialSupportSkillStatus.FromPointer); // 0x80 PotentialSupportSkillList   ( ModelClassListType RepeatedField`1<GettablePotentialSupportSkillStatus> RepeatedField`1<GettablePotentialSupportSkillStatus> List<GettablePotentialSupportSkillStatus> Pointer )
            value.SelectableSupportSkillCount               = GetInt32(new IntPtr(p + 0x088)); // 0x88 SelectableSupportSkillCount ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
