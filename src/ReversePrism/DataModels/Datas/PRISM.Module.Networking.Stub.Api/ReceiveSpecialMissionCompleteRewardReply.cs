using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceiveSpecialMissionCompleteRewardReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SpecialMissionFieldNumber                int IL2CPP_TYPE_I4
    // 018 SpecialMission                           000186548D20 ModelClassType SpecialMissionStatus SpecialMissionStatus SpecialMissionStatus Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 028 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class ReceiveSpecialMissionCompleteRewardReply
    {
        public SpecialMissionStatus?                    SpecialMission                          { get; set; }
        public List<RewardProductStatus>?               RewardList                              { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static ReceiveSpecialMissionCompleteRewardReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveSpecialMissionCompleteRewardReply();

            value.SpecialMission                            = GetObject<SpecialMissionStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SpecialMissionStatus.FromPointer); // 0270D28B8688 0x18 SpecialMission              ( 000186548D20 ModelClassType SpecialMissionStatus SpecialMissionStatus SpecialMissionStatus Pointer )
            value.RewardList                                = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0270D28B86E8 0x20 RewardList                  ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0270D28B8728 0x28 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
