using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ScheduleDetailStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 018 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ScheduleLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 01C ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 000 TroubleFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Trouble                                  ModelPrimitiveType int int int Int32
    // 000 IsRecommendFieldNumber                   int IL2CPP_TYPE_I4
    // 024 IsRecommend                              ModelPrimitiveType bool bool bool Bool
    // 000 IsSupportBonusFieldNumber                int IL2CPP_TYPE_I4
    // 025 IsSupportBonus                           ModelPrimitiveType bool bool bool Bool
    // 000 SupportCharacterIconListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_supportCharacterIconList_codec FieldCodec`1<SupportCharacterIconStatus> IL2CPP_TYPE_GENERICINST
    // 028 SupportCharacterIconList                 ModelClassListType RepeatedField`1<SupportCharacterIconStatus> RepeatedField`1<SupportCharacterIconStatus> List<SupportCharacterIconStatus> Pointer
    // 000 VitalityCostFieldNumber                  int IL2CPP_TYPE_I4
    // 030 VitalityCost                             ModelPrimitiveType int int int Int32
    // 000 ScheduleRewardListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_scheduleRewardList_codec       FieldCodec`1<ScheduleRewardStatus> IL2CPP_TYPE_GENERICINST
    // 038 ScheduleRewardList                       ModelClassListType RepeatedField`1<ScheduleRewardStatus> RepeatedField`1<ScheduleRewardStatus> List<ScheduleRewardStatus> Pointer
    // 000 BuildUpParameterFieldNumber              int IL2CPP_TYPE_I4
    // 040 BuildUpParameter                         ModelClassType BuildUpParameterStatus BuildUpParameterStatus BuildUpParameterStatus Pointer
    // 000 RecoverVitalityFieldNumber               int IL2CPP_TYPE_I4
    // 048 RecoverVitality                          ModelPrimitiveType int int int Int32
    // 000 ChallengeMissionFieldNumber              int IL2CPP_TYPE_I4
    // 050 ChallengeMission                         ModelClassType ChallengeMissionStatus ChallengeMissionStatus ChallengeMissionStatus Pointer
    public partial class ScheduleDetailStatus : DataModel
    {
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public int                                      Trouble                                 { get; set; }
        public bool                                     IsRecommend                             { get; set; }
        public bool                                     IsSupportBonus                          { get; set; }
        public List<SupportCharacterIconStatus>?        SupportCharacterIconList                { get; set; }
        public int                                      VitalityCost                            { get; set; }
        public List<ScheduleRewardStatus>?              ScheduleRewardList                      { get; set; }
        public BuildUpParameterStatus?                  BuildUpParameter                        { get; set; }
        public int                                      RecoverVitality                         { get; set; }
        public ChallengeMissionStatus?                  ChallengeMission                        { get; set; }

        public static ScheduleDetailStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleDetailStatus() { Pointer= p0 };

            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.Trouble                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 Trouble                     ( ModelPrimitiveType int int int Int32 )
            value.IsRecommend                               = GetBool(new IntPtr(p + 0x024)); // 0x24 IsRecommend                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x025)); // 0x25 IsSupportBonus              ( ModelPrimitiveType bool bool bool Bool )
            value.SupportCharacterIconList                  = GetObjectList<SupportCharacterIconStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportCharacterIconStatus.FromPointer); // 0x28 SupportCharacterIconList    ( ModelClassListType RepeatedField`1<SupportCharacterIconStatus> RepeatedField`1<SupportCharacterIconStatus> List<SupportCharacterIconStatus> Pointer )
            value.VitalityCost                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 VitalityCost                ( ModelPrimitiveType int int int Int32 )
            value.ScheduleRewardList                        = GetObjectList<ScheduleRewardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleRewardStatus.FromPointer); // 0x38 ScheduleRewardList          ( ModelClassListType RepeatedField`1<ScheduleRewardStatus> RepeatedField`1<ScheduleRewardStatus> List<ScheduleRewardStatus> Pointer )
            value.BuildUpParameter                          = GetObject<BuildUpParameterStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.BuildUpParameterStatus.FromPointer); // 0x40 BuildUpParameter            ( ModelClassType BuildUpParameterStatus BuildUpParameterStatus BuildUpParameterStatus Pointer )
            value.RecoverVitality                           = GetInt32(new IntPtr(p + 0x048)); // 0x48 RecoverVitality             ( ModelPrimitiveType int int int Int32 )
            value.ChallengeMission                          = GetObject<ChallengeMissionStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ChallengeMissionStatus.FromPointer); // 0x50 ChallengeMission            ( ModelClassType ChallengeMissionStatus ChallengeMissionStatus ChallengeMissionStatus Pointer )

            return value;
        }
    }
}
