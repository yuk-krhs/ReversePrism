using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastDisplayDate                          000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SpecialMissionStepStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSpecialMissionStepIdFieldNumber       int IL2CPP_TYPE_I4
    // 028 MstSpecialMissionStepId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LastDisplayDateFieldNumber               int IL2CPP_TYPE_I4
    // 030 _LastDisplayDate                         000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MissionListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_missionList_codec              FieldCodec`1<SpecialMissionMissionStatus> IL2CPP_TYPE_GENERICINST
    // 038 MissionList                              000185CF1F68 ModelClassListType RepeatedField`1<SpecialMissionMissionStatus> RepeatedField`1<SpecialMissionMissionStatus> List<SpecialMissionMissionStatus> Pointer
    // 000 StepNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 040 StepNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ReceivableCountFieldNumber               int IL2CPP_TYPE_I4
    // 044 ReceivableCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CompleteCountFieldNumber                 int IL2CPP_TYPE_I4
    // 048 CompleteCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 04C IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 010 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 050 RewardList                               000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 IsUnlockedFieldNumber                    int IL2CPP_TYPE_I4
    // 058 IsUnlocked                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 StateFieldNumber                         int IL2CPP_TYPE_I4
    // 05C State                                    000186629C10 ModelEnumType MissionState MissionState MissionState Int32
    public partial class SpecialMissionStepStatus
    {
        public DateTime                                 LastDisplayDate                         { get; set; }
        public int                                      MstSpecialMissionStepId                 { get; set; }
        public Timestamp?                               _LastDisplayDate                        { get; set; }
        public List<SpecialMissionMissionStatus>?       MissionList                             { get; set; }
        public int                                      StepNumber                              { get; set; }
        public int                                      ReceivableCount                         { get; set; }
        public int                                      CompleteCount                           { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }
        public bool                                     IsUnlocked                              { get; set; }
        public MissionState                             State                                   { get; set; }

        public static SpecialMissionStepStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionStepStatus();

            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x010)); // 0270D28C7148 0x10 LastDisplayDate             ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstSpecialMissionStepId                   = GetInt32(new IntPtr(p + 0x028)); // 0270D28C71C8 0x28 MstSpecialMissionStepId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._LastDisplayDate                          = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D28C7208 0x30 _LastDisplayDate            ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MissionList                               = GetObjectList<SpecialMissionMissionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.SpecialMissionMissionStatus.FromPointer); // 0270D28C7268 0x38 MissionList                 ( 000185CF1F68 ModelClassListType RepeatedField`1<SpecialMissionMissionStatus> RepeatedField`1<SpecialMissionMissionStatus> List<SpecialMissionMissionStatus> Pointer )
            value.StepNumber                                = GetInt32(new IntPtr(p + 0x040)); // 0270D28C72A8 0x40 StepNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x044)); // 0270D28C72E8 0x44 ReceivableCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CompleteCount                             = GetInt32(new IntPtr(p + 0x048)); // 0270D28C7328 0x48 CompleteCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x04C)); // 0270D28C7368 0x4C IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D28C73C8 0x50 RewardList                  ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x058)); // 0270D28C7408 0x58 IsUnlocked                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.State                                     = (MissionState)GetInt32(new IntPtr(p + 0x05C)); // 0270D28C7448 0x5C State                       ( 000186629C10 ModelEnumType MissionState MissionState MissionState Int32 )
            value.LastDisplayDate               = ToDateTime(value._LastDisplayDate);

            return value;
        }
    }
}
