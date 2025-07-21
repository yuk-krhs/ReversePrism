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
    // 018 ProduceBaseInfo                          ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 IsTroubleFieldNumber                     int IL2CPP_TYPE_I4
    // 020 IsTrouble                                ModelPrimitiveType bool bool bool Bool
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 028 UnitParameterVariation                   ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 030 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 MstCharacterInfoIdListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_mstCharacterInfoIdList_codec   FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 038 MstCharacterInfoIdList                   ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 IsSupportBonusFieldNumber                int IL2CPP_TYPE_I4
    // 040 IsSupportBonus                           ModelPrimitiveType bool bool bool Bool
    // 000 ScheduleLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 044 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 000 VitalityVariationFieldNumber             int IL2CPP_TYPE_I4
    // 048 VitalityVariation                        ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 050 ExertSupportEffectList                   ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
    public partial class StartScheduleTrainingReply : DataModel
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
            var value   = new StartScheduleTrainingReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0x18 ProduceBaseInfo             ( ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.IsTrouble                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 IsTrouble                   ( ModelPrimitiveType bool bool bool Bool )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0x28 UnitParameterVariation      ( ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x030)); // 0x30 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x038)); // 0x38 MstCharacterInfoIdList      ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x040)); // 0x40 IsSupportBonus              ( ModelPrimitiveType bool bool bool Bool )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x044)); // 0x44 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.VitalityVariation                         = GetObject<VitalityVariationStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.VitalityVariationStatus.FromPointer); // 0x48 VitalityVariation           ( ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 0x50 ExertSupportEffectList      ( ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )

            return value;
        }
    }
}
