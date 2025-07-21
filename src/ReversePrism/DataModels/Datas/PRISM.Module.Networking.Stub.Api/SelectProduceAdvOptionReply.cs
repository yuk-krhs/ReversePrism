using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceAdvRewardTypeList                 ModelEnumListType List<ProduceAdvRewardType> List<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer
    // 000 _parser                                  MessageParser`1<SelectProduceAdvOptionReply> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 020 ProduceBaseInfo                          ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 ProduceAdvRewardTypeListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_produceAdvRewardTypeList_codec FieldCodec`1<ProduceAdvRewardType> IL2CPP_TYPE_GENERICINST
    // 028 ProduceAdvRewardTypeList                 ModelEnumListType RepeatedField`1<ProduceAdvRewardType> RepeatedField`1<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer
    // 000 ProduceIdolParameterVariationFieldNumber int IL2CPP_TYPE_I4
    // 030 ProduceIdolParameterVariation            ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 010 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 038 ProduceCardList                          ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    // 000 GettableProduceCardAmountFieldNumber     int IL2CPP_TYPE_I4
    // 040 GettableProduceCardAmount                ModelPrimitiveType int int int Int32
    // 000 PotentialSupportSkillFieldNumber         int IL2CPP_TYPE_I4
    // 048 PotentialSupportSkill                    ModelClassType GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus Pointer
    // 000 VitalityVariationFieldNumber             int IL2CPP_TYPE_I4
    // 050 VitalityVariation                        ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer
    // 000 PotentialSupportSkillListFieldNumber     int IL2CPP_TYPE_I4
    // 018 _repeated_potentialSupportSkillList_codec FieldCodec`1<GettablePotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 058 PotentialSupportSkillList                ModelClassListType RepeatedField`1<GettablePotentialSupportSkillStatus> RepeatedField`1<GettablePotentialSupportSkillStatus> List<GettablePotentialSupportSkillStatus> Pointer
    // 000 SelectableSupportSkillCountFieldNumber   int IL2CPP_TYPE_I4
    // 060 SelectableSupportSkillCount              ModelPrimitiveType int int int Int32
    public partial class SelectProduceAdvOptionReply : DataModel
    {
        public List<ProduceAdvRewardType>?              ProduceAdvRewardTypeList                { get; set; }
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public ParameterVariationStatus?                ProduceIdolParameterVariation           { get; set; }
        public List<ProduceCardStatus>?                 ProduceCardList                         { get; set; }
        public int                                      GettableProduceCardAmount               { get; set; }
        public GettablePotentialSupportSkillStatus?     PotentialSupportSkill                   { get; set; }
        public VitalityVariationStatus?                 VitalityVariation                       { get; set; }
        public List<GettablePotentialSupportSkillStatus>? PotentialSupportSkillList               { get; set; }
        public int                                      SelectableSupportSkillCount             { get; set; }

        public static SelectProduceAdvOptionReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectProduceAdvOptionReply() { Pointer= p0 };

            value.ProduceAdvRewardTypeList                  = GetEnumList<ProduceAdvRewardType>(new IntPtr(p + 0x028)); // 0x28 ProduceAdvRewardTypeList    ( ModelEnumListType RepeatedField`1<ProduceAdvRewardType> RepeatedField`1<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer )
            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0x20 ProduceBaseInfo             ( ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.ProduceIdolParameterVariation             = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0x30 ProduceIdolParameterVariation ( ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 0x38 ProduceCardList             ( ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x040)); // 0x40 GettableProduceCardAmount   ( ModelPrimitiveType int int int Int32 )
            value.PotentialSupportSkill                     = GetObject<GettablePotentialSupportSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.GettablePotentialSupportSkillStatus.FromPointer); // 0x48 PotentialSupportSkill       ( ModelClassType GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus Pointer )
            value.VitalityVariation                         = GetObject<VitalityVariationStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.VitalityVariationStatus.FromPointer); // 0x50 VitalityVariation           ( ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer )
            value.PotentialSupportSkillList                 = GetObjectList<GettablePotentialSupportSkillStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.GettablePotentialSupportSkillStatus.FromPointer); // 0x58 PotentialSupportSkillList   ( ModelClassListType RepeatedField`1<GettablePotentialSupportSkillStatus> RepeatedField`1<GettablePotentialSupportSkillStatus> List<GettablePotentialSupportSkillStatus> Pointer )
            value.SelectableSupportSkillCount               = GetInt32(new IntPtr(p + 0x060)); // 0x60 SelectableSupportSkillCount ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
