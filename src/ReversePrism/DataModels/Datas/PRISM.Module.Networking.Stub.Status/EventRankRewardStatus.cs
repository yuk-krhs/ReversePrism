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
    // 018 RankRange                                ModelClassType RangeStatus RangeStatus RangeStatus Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 RewardTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 028 RewardType                               ModelEnumType EventRankingRewardType EventRankingRewardType EventRankingRewardType Int32
    // 000 RankPercentFieldNumber                   int IL2CPP_TYPE_I4
    // 02C RankPercent                              ModelPrimitiveType int int int Int32
    // 000 RankGradeFieldNumber                     int IL2CPP_TYPE_I4
    // 030 RankGrade                                ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32
    public partial class EventRankRewardStatus : DataModel
    {
        public RangeStatus?                             RankRange                               { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }
        public EventRankingRewardType                   RewardType                              { get; set; }
        public int                                      RankPercent                             { get; set; }
        public EventRankGrade                           RankGrade                               { get; set; }

        public static EventRankRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventRankRewardStatus() { Pointer= p0 };

            value.RankRange                                 = GetObject<RangeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.RangeStatus.FromPointer); // 0x18 RankRange                   ( ModelClassType RangeStatus RangeStatus RangeStatus Pointer )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x20 RewardList                  ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.RewardType                                = (EventRankingRewardType)GetInt32(new IntPtr(p + 0x028)); // 0x28 RewardType                  ( ModelEnumType EventRankingRewardType EventRankingRewardType EventRankingRewardType Int32 )
            value.RankPercent                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C RankPercent                 ( ModelPrimitiveType int int int Int32 )
            value.RankGrade                                 = (EventRankGrade)GetInt32(new IntPtr(p + 0x030)); // 0x30 RankGrade                   ( ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32 )

            return value;
        }
    }
}
