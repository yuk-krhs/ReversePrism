using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EventIdolRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstIdolId                                ModelPrimitiveType int int int Int32
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<EventRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer
    public partial class EventIdolRankRewardStatus : DataModel
    {
        public int                                      MstIdolId                               { get; set; }
        public List<EventRankRewardStatus>?             RewardList                              { get; set; }

        public static EventIdolRankRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventIdolRankRewardStatus() { Pointer= p0 };

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.RewardList                                = GetObjectList<EventRankRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventRankRewardStatus.FromPointer); // 0x20 RewardList                  ( ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer )

            return value;
        }
    }
}
