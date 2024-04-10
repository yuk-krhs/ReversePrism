using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceiveSpecialMissionRewardReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StepFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Step                                     000186549A30 ModelClassType SpecialMissionStepStatus SpecialMissionStepStatus SpecialMissionStepStatus Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 028 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class ReceiveSpecialMissionRewardReply : DataModel
    {
        public SpecialMissionStepStatus?                Step                                    { get; set; }
        public List<RewardProductStatus>?               RewardList                              { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static ReceiveSpecialMissionRewardReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveSpecialMissionRewardReply() { Pointer= p0 };

            value.Step                                      = GetObject<SpecialMissionStepStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SpecialMissionStepStatus.FromPointer); // 024662843598 0x18 Step                        ( 000186549A30 ModelClassType SpecialMissionStepStatus SpecialMissionStepStatus SpecialMissionStepStatus Pointer )
            value.RewardList                                = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0246628435F8 0x20 RewardList                  ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 024662843638 0x28 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
