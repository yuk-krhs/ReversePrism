using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EventRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankRangeFieldNumber                     int IL2CPP_TYPE_I4
    // 018 RankRange                                00018660C9D0 ModelClassType RangeStatus RangeStatus RangeStatus Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class EventRankRewardStatus : DataModel
    {
        public RangeStatus?                             RankRange                               { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }

        public static EventRankRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventRankRewardStatus() { Pointer= p0 };

            value.RankRange                                 = GetObject<RangeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.RangeStatus.FromPointer); // 02466130BB80 0x18 RankRange                   ( 00018660C9D0 ModelClassType RangeStatus RangeStatus RangeStatus Pointer )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 02466130BBE0 0x20 RewardList                  ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
