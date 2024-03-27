using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceAdvRewardTypeList                 000185D189F8 ModelEnumListType IReadOnlyList`1<ProduceAdvRewardType> IReadOnlyList`1<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer
    // 000 _parser                                  MessageParser`1<SelectProduceAdvOptionReply> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 020 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 ProduceAdvRewardTypeListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_produceAdvRewardTypeList_codec FieldCodec`1<ProduceAdvRewardType> IL2CPP_TYPE_GENERICINST
    // 028 ProduceAdvRewardTypeList                 000185CEA388 ModelEnumListType RepeatedField`1<ProduceAdvRewardType> RepeatedField`1<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer
    // 000 ProduceIdolParameterVariationFieldNumber int IL2CPP_TYPE_I4
    // 030 ProduceIdolParameterVariation            00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 010 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 038 ProduceCardList                          000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    // 000 GettableProduceCardAmountFieldNumber     int IL2CPP_TYPE_I4
    // 040 GettableProduceCardAmount                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PotentialSupportSkillFieldNumber         int IL2CPP_TYPE_I4
    // 048 PotentialSupportSkill                    000186678D40 ModelClassType GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus Pointer
    // 000 VitalityVariationFieldNumber             int IL2CPP_TYPE_I4
    // 050 VitalityVariation                        00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer
    public partial class SelectProduceAdvOptionReply
    {
        public List<ProduceAdvRewardType>?              ProduceAdvRewardTypeList                { get; set; }
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public ParameterVariationStatus?                ProduceIdolParameterVariation           { get; set; }
        public List<ProduceCardStatus>?                 ProduceCardList                         { get; set; }
        public int                                      GettableProduceCardAmount               { get; set; }
        public GettablePotentialSupportSkillStatus?     PotentialSupportSkill                   { get; set; }
        public VitalityVariationStatus?                 VitalityVariation                       { get; set; }

        public static SelectProduceAdvOptionReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectProduceAdvOptionReply();

            value.ProduceAdvRewardTypeList                  = GetEnumList<ProduceAdvRewardType>(new IntPtr(p + 0x028)); // 0270D259B140 0x28 ProduceAdvRewardTypeList    ( 000185CEA388 ModelEnumListType RepeatedField`1<ProduceAdvRewardType> RepeatedField`1<ProduceAdvRewardType> List<ProduceAdvRewardType> Pointer )
            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D259B0E0 0x20 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.ProduceIdolParameterVariation             = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0270D259B180 0x30 ProduceIdolParameterVariation ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 0270D259B1E0 0x38 ProduceCardList             ( 000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x040)); // 0270D259B220 0x40 GettableProduceCardAmount   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PotentialSupportSkill                     = GetObject<GettablePotentialSupportSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.GettablePotentialSupportSkillStatus.FromPointer); // 0270D259B260 0x48 PotentialSupportSkill       ( 000186678D40 ModelClassType GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus GettablePotentialSupportSkillStatus Pointer )
            value.VitalityVariation                         = GetObject<VitalityVariationStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.VitalityVariationStatus.FromPointer); // 0270D259B2A0 0x50 VitalityVariation           ( 00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer )

            return value;
        }
    }
}
