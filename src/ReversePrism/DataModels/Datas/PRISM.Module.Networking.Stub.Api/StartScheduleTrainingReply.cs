using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartScheduleTrainingReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 IsTroubleFieldNumber                     int IL2CPP_TYPE_I4
    // 020 IsTrouble                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 028 UnitParameterVariation                   00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 030 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 MstCharacterInfoIdListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_mstCharacterInfoIdList_codec   FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 038 MstCharacterInfoIdList                   000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 IsSupportBonusFieldNumber                int IL2CPP_TYPE_I4
    // 040 IsSupportBonus                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ScheduleLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 044 ScheduleLevel                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VitalityVariationFieldNumber             int IL2CPP_TYPE_I4
    // 048 VitalityVariation                        00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 050 ExertSupportEffectList                   000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
    public partial class StartScheduleTrainingReply
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public bool                                     IsTrouble                               { get; set; }
        public ParameterVariationStatus?                UnitParameterVariation                  { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }
        public bool                                     IsSupportBonus                          { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public VitalityVariationStatus?                 VitalityVariation                       { get; set; }
        public List<ExertSupportEffectStatus>?          ExertSupportEffectList                  { get; set; }

        public static StartScheduleTrainingReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartScheduleTrainingReply();

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D25CDFE8 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.IsTrouble                                 = GetBool(new IntPtr(p + 0x020)); // 0270D25CE028 0x20 IsTrouble                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0270D25CE068 0x28 UnitParameterVariation      ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x030)); // 0270D25CE0A8 0x30 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x038)); // 0270D25CE108 0x38 MstCharacterInfoIdList      ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x040)); // 0270D25CE148 0x40 IsSupportBonus              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x044)); // 0270D25CE188 0x44 ScheduleLevel               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VitalityVariation                         = GetObject<VitalityVariationStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.VitalityVariationStatus.FromPointer); // 0270D25CE1C8 0x48 VitalityVariation           ( 00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 0270D25CE228 0x50 ExertSupportEffectList      ( 000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )

            return value;
        }
    }
}
