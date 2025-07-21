using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartSchedulePublicRelationsReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 IsTroubleFieldNumber                     int IL2CPP_TYPE_I4
    // 020 IsTrouble                                ModelPrimitiveType bool bool bool Bool
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 024 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProduceCardList                          ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    // 000 GettableProduceCardAmountFieldNumber     int IL2CPP_TYPE_I4
    // 030 GettableProduceCardAmount                ModelPrimitiveType int int int Int32
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 038 UnitParameterVariation                   ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 FanVariationFieldNumber                  int IL2CPP_TYPE_I4
    // 040 FanVariation                             ModelClassType FanVariationStatus FanVariationStatus FanVariationStatus Pointer
    // 000 VitalityVariationFieldNumber             int IL2CPP_TYPE_I4
    // 048 VitalityVariation                        ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 050 ExertSupportEffectList                   ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
    // 000 MstCharacterInfoIdListFieldNumber        int IL2CPP_TYPE_I4
    // 018 _repeated_mstCharacterInfoIdList_codec   FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 058 MstCharacterInfoIdList                   ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class StartSchedulePublicRelationsReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public bool                                     IsTrouble                               { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public List<ProduceCardStatus>?                 ProduceCardList                         { get; set; }
        public int                                      GettableProduceCardAmount               { get; set; }
        public ParameterVariationStatus?                UnitParameterVariation                  { get; set; }
        public FanVariationStatus?                      FanVariation                            { get; set; }
        public VitalityVariationStatus?                 VitalityVariation                       { get; set; }
        public List<ExertSupportEffectStatus>?          ExertSupportEffectList                  { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }

        public static StartSchedulePublicRelationsReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartSchedulePublicRelationsReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0x18 ProduceBaseInfo             ( ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.IsTrouble                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 IsTrouble                   ( ModelPrimitiveType bool bool bool Bool )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x024)); // 0x24 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 0x28 ProduceCardList             ( ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 GettableProduceCardAmount   ( ModelPrimitiveType int int int Int32 )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0x38 UnitParameterVariation      ( ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.FanVariation                              = GetObject<FanVariationStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.FanVariationStatus.FromPointer); // 0x40 FanVariation                ( ModelClassType FanVariationStatus FanVariationStatus FanVariationStatus Pointer )
            value.VitalityVariation                         = GetObject<VitalityVariationStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.VitalityVariationStatus.FromPointer); // 0x48 VitalityVariation           ( ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 0x50 ExertSupportEffectList      ( ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x058)); // 0x58 MstCharacterInfoIdList      ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
