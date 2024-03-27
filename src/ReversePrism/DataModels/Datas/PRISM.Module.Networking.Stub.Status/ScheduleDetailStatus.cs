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
    // 018 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ScheduleLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 01C ScheduleLevel                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TroubleFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Trouble                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsRecommendFieldNumber                   int IL2CPP_TYPE_I4
    // 024 IsRecommend                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 IsSupportBonusFieldNumber                int IL2CPP_TYPE_I4
    // 025 IsSupportBonus                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 SupportCharacterIconListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_supportCharacterIconList_codec FieldCodec`1<SupportCharacterIconStatus> IL2CPP_TYPE_GENERICINST
    // 028 SupportCharacterIconList                 000185CF4048 ModelClassListType RepeatedField`1<SupportCharacterIconStatus> RepeatedField`1<SupportCharacterIconStatus> List<SupportCharacterIconStatus> Pointer
    // 000 VitalityCostFieldNumber                  int IL2CPP_TYPE_I4
    // 030 VitalityCost                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ScheduleRewardListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_scheduleRewardList_codec       FieldCodec`1<ScheduleRewardStatus> IL2CPP_TYPE_GENERICINST
    // 038 ScheduleRewardList                       000185CEF588 ModelClassListType RepeatedField`1<ScheduleRewardStatus> RepeatedField`1<ScheduleRewardStatus> List<ScheduleRewardStatus> Pointer
    // 000 BuildUpParameterFieldNumber              int IL2CPP_TYPE_I4
    // 040 BuildUpParameter                         00018650F070 ModelClassType BuildUpParameterStatus BuildUpParameterStatus BuildUpParameterStatus Pointer
    // 000 RecoverVitalityFieldNumber               int IL2CPP_TYPE_I4
    // 048 RecoverVitality                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ChallengeMissionFieldNumber              int IL2CPP_TYPE_I4
    // 050 ChallengeMission                         00018656C2A0 ModelClassType ChallengeMissionStatus ChallengeMissionStatus ChallengeMissionStatus Pointer
    public partial class ScheduleDetailStatus
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
            var value   = new ScheduleDetailStatus();

            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x018)); // 0270D113CB60 0x18 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x01C)); // 0270D113CBA0 0x1C ScheduleLevel               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Trouble                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D113CBE0 0x20 Trouble                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsRecommend                               = GetBool(new IntPtr(p + 0x024)); // 0270D113CC20 0x24 IsRecommend                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x025)); // 0270D113CC60 0x25 IsSupportBonus              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SupportCharacterIconList                  = GetObjectList<SupportCharacterIconStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportCharacterIconStatus.FromPointer); // 0270D113CCC0 0x28 SupportCharacterIconList    ( 000185CF4048 ModelClassListType RepeatedField`1<SupportCharacterIconStatus> RepeatedField`1<SupportCharacterIconStatus> List<SupportCharacterIconStatus> Pointer )
            value.VitalityCost                              = GetInt32(new IntPtr(p + 0x030)); // 0270D113CD00 0x30 VitalityCost                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScheduleRewardList                        = GetObjectList<ScheduleRewardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleRewardStatus.FromPointer); // 0270D113CD60 0x38 ScheduleRewardList          ( 000185CEF588 ModelClassListType RepeatedField`1<ScheduleRewardStatus> RepeatedField`1<ScheduleRewardStatus> List<ScheduleRewardStatus> Pointer )
            value.BuildUpParameter                          = GetObject<BuildUpParameterStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.BuildUpParameterStatus.FromPointer); // 0270D113CDA0 0x40 BuildUpParameter            ( 00018650F070 ModelClassType BuildUpParameterStatus BuildUpParameterStatus BuildUpParameterStatus Pointer )
            value.RecoverVitality                           = GetInt32(new IntPtr(p + 0x048)); // 0270D113CDE0 0x48 RecoverVitality             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChallengeMission                          = GetObject<ChallengeMissionStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ChallengeMissionStatus.FromPointer); // 0270D113CE20 0x50 ChallengeMission            ( 00018656C2A0 ModelClassType ChallengeMissionStatus ChallengeMissionStatus ChallengeMissionStatus Pointer )

            return value;
        }
    }
}
