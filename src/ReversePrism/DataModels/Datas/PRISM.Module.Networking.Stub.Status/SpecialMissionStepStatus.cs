using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastDisplayDate                          ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SpecialMissionStepStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSpecialMissionStepIdFieldNumber       int IL2CPP_TYPE_I4
    // 028 MstSpecialMissionStepId                  ModelPrimitiveType int int int Int32
    // 000 LastDisplayDateFieldNumber               int IL2CPP_TYPE_I4
    // 030 _LastDisplayDate                         ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MissionListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_missionList_codec              FieldCodec`1<SpecialMissionMissionStatus> IL2CPP_TYPE_GENERICINST
    // 038 MissionList                              ModelClassListType RepeatedField`1<SpecialMissionMissionStatus> RepeatedField`1<SpecialMissionMissionStatus> List<SpecialMissionMissionStatus> Pointer
    // 000 StepNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 040 StepNumber                               ModelPrimitiveType int int int Int32
    // 000 ReceivableCountFieldNumber               int IL2CPP_TYPE_I4
    // 044 ReceivableCount                          ModelPrimitiveType int int int Int32
    // 000 CompleteCountFieldNumber                 int IL2CPP_TYPE_I4
    // 048 CompleteCount                            ModelPrimitiveType int int int Int32
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 04C IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 010 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 050 RewardList                               ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 IsUnlockedFieldNumber                    int IL2CPP_TYPE_I4
    // 058 IsUnlocked                               ModelPrimitiveType bool bool bool Bool
    // 000 StateFieldNumber                         int IL2CPP_TYPE_I4
    // 05C State                                    ModelEnumType MissionState MissionState MissionState Int32
    public partial class SpecialMissionStepStatus : DataModel
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
            var value   = new SpecialMissionStepStatus() { Pointer= p0 };

            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x010)); // 0x10 LastDisplayDate             ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstSpecialMissionStepId                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstSpecialMissionStepId     ( ModelPrimitiveType int int int Int32 )
            value._LastDisplayDate                          = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0x30 _LastDisplayDate            ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MissionList                               = GetObjectList<SpecialMissionMissionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.SpecialMissionMissionStatus.FromPointer); // 0x38 MissionList                 ( ModelClassListType RepeatedField`1<SpecialMissionMissionStatus> RepeatedField`1<SpecialMissionMissionStatus> List<SpecialMissionMissionStatus> Pointer )
            value.StepNumber                                = GetInt32(new IntPtr(p + 0x040)); // 0x40 StepNumber                  ( ModelPrimitiveType int int int Int32 )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x044)); // 0x44 ReceivableCount             ( ModelPrimitiveType int int int Int32 )
            value.CompleteCount                             = GetInt32(new IntPtr(p + 0x048)); // 0x48 CompleteCount               ( ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x04C)); // 0x4C IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x50 RewardList                  ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x058)); // 0x58 IsUnlocked                  ( ModelPrimitiveType bool bool bool Bool )
            value.State                                     = (MissionState)GetInt32(new IntPtr(p + 0x05C)); // 0x5C State                       ( ModelEnumType MissionState MissionState MissionState Int32 )
            value.LastDisplayDate               = ToDateTime(value._LastDisplayDate);

            return value;
        }
    }
}
