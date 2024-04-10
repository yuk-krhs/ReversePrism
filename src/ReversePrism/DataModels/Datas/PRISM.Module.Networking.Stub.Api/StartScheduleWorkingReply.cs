using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartScheduleWorkingReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 IsTroubleFieldNumber                     int IL2CPP_TYPE_I4
    // 020 IsTrouble                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 028 UnitParameterVariation                   00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 030 ProduceCardList                          000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    // 000 GettableProduceCardAmountFieldNumber     int IL2CPP_TYPE_I4
    // 038 GettableProduceCardAmount                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FanVariationFieldNumber                  int IL2CPP_TYPE_I4
    // 040 FanVariation                             000186553750 ModelClassType FanVariationStatus FanVariationStatus FanVariationStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 048 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 MstCharacterInfoIdListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_mstCharacterInfoIdList_codec   FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 050 MstCharacterInfoIdList                   000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 IsSupportBonusFieldNumber                int IL2CPP_TYPE_I4
    // 058 IsSupportBonus                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ScheduleLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 05C ScheduleLevel                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VitalityVariationFieldNumber             int IL2CPP_TYPE_I4
    // 060 VitalityVariation                        00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 018 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 068 ExertSupportEffectList                   000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
    public partial class StartScheduleWorkingReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public bool                                     IsTrouble                               { get; set; }
        public ParameterVariationStatus?                UnitParameterVariation                  { get; set; }
        public List<ProduceCardStatus>?                 ProduceCardList                         { get; set; }
        public int                                      GettableProduceCardAmount               { get; set; }
        public FanVariationStatus?                      FanVariation                            { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }
        public bool                                     IsSupportBonus                          { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public VitalityVariationStatus?                 VitalityVariation                       { get; set; }
        public List<ExertSupportEffectStatus>?          ExertSupportEffectList                  { get; set; }

        public static StartScheduleWorkingReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartScheduleWorkingReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 02466259CDA8 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.IsTrouble                                 = GetBool(new IntPtr(p + 0x020)); // 02466259CDE8 0x20 IsTrouble                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 02466259CE28 0x28 UnitParameterVariation      ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 02466259CE88 0x30 ProduceCardList             ( 000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x038)); // 02466259CEC8 0x38 GettableProduceCardAmount   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FanVariation                              = GetObject<FanVariationStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.FanVariationStatus.FromPointer); // 02466259CF08 0x40 FanVariation                ( 000186553750 ModelClassType FanVariationStatus FanVariationStatus FanVariationStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x048)); // 02466259CF48 0x48 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x050)); // 02466259CFA8 0x50 MstCharacterInfoIdList      ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x058)); // 02466259CFE8 0x58 IsSupportBonus              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x05C)); // 02466259D028 0x5C ScheduleLevel               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VitalityVariation                         = GetObject<VitalityVariationStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.VitalityVariationStatus.FromPointer); // 02466259D068 0x60 VitalityVariation           ( 00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 02466259D0C8 0x68 ExertSupportEffectList      ( 000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )

            return value;
        }
    }
}
