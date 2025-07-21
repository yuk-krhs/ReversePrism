using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetLivePlayRewardListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<LivePlayRewardStatus> IL2CPP_TYPE_GENERICINST
    // 018 RewardList                               ModelClassListType RepeatedField`1<LivePlayRewardStatus> RepeatedField`1<LivePlayRewardStatus> List<LivePlayRewardStatus> Pointer
    public partial class GetLivePlayRewardListReply : DataModel
    {
        public List<LivePlayRewardStatus>?              RewardList                              { get; set; }

        public static GetLivePlayRewardListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLivePlayRewardListReply() { Pointer= p0 };

            value.RewardList                                = GetObjectList<LivePlayRewardStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LivePlayRewardStatus.FromPointer); // 0x18 RewardList                  ( ModelClassListType RepeatedField`1<LivePlayRewardStatus> RepeatedField`1<LivePlayRewardStatus> List<LivePlayRewardStatus> Pointer )

            return value;
        }
    }
}
