using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartScheduleTalkShowReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 IsTroubleFieldNumber                     int IL2CPP_TYPE_I4
    // 020 IsTrouble                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 024 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProduceCardList                          000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    // 000 GettableProduceCardAmountFieldNumber     int IL2CPP_TYPE_I4
    // 030 GettableProduceCardAmount                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DeletableProduceCardAmountFieldNumber    int IL2CPP_TYPE_I4
    // 034 DeletableProduceCardAmount               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FanVariationFieldNumber                  int IL2CPP_TYPE_I4
    // 038 FanVariation                             000186553750 ModelClassType FanVariationStatus FanVariationStatus FanVariationStatus Pointer
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 040 UnitParameterVariation                   00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 VitalityVariationFieldNumber             int IL2CPP_TYPE_I4
    // 048 VitalityVariation                        00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 050 ExertSupportEffectList                   000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
    // 000 MstCharacterInfoIdListFieldNumber        int IL2CPP_TYPE_I4
    // 018 _repeated_mstCharacterInfoIdList_codec   FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 058 MstCharacterInfoIdList                   000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class StartScheduleTalkShowReply
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public bool                                     IsTrouble                               { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public List<ProduceCardStatus>?                 ProduceCardList                         { get; set; }
        public int                                      GettableProduceCardAmount               { get; set; }
        public int                                      DeletableProduceCardAmount              { get; set; }
        public FanVariationStatus?                      FanVariation                            { get; set; }
        public ParameterVariationStatus?                UnitParameterVariation                  { get; set; }
        public VitalityVariationStatus?                 VitalityVariation                       { get; set; }
        public List<ExertSupportEffectStatus>?          ExertSupportEffectList                  { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }

        public static StartScheduleTalkShowReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartScheduleTalkShowReply();

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D25CA0B8 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.IsTrouble                                 = GetBool(new IntPtr(p + 0x020)); // 0270D25CA0F8 0x20 IsTrouble                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x024)); // 0270D25CA138 0x24 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 0270D25CA198 0x28 ProduceCardList             ( 000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x030)); // 0270D25CA1D8 0x30 GettableProduceCardAmount   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DeletableProduceCardAmount                = GetInt32(new IntPtr(p + 0x034)); // 0270D25CA218 0x34 DeletableProduceCardAmount  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FanVariation                              = GetObject<FanVariationStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.FanVariationStatus.FromPointer); // 0270D25CA258 0x38 FanVariation                ( 000186553750 ModelClassType FanVariationStatus FanVariationStatus FanVariationStatus Pointer )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0270D25CA298 0x40 UnitParameterVariation      ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.VitalityVariation                         = GetObject<VitalityVariationStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.VitalityVariationStatus.FromPointer); // 0270D25CA2D8 0x48 VitalityVariation           ( 00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 0270D25CA338 0x50 ExertSupportEffectList      ( 000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x058)); // 0270D25CA398 0x58 MstCharacterInfoIdList      ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
