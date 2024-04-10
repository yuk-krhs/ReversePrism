using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LivePlayRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RewardTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 018 RewardType                               0001865675F0 ModelEnumType LivePlayDisplayLotteryRewardType LivePlayDisplayLotteryRewardType LivePlayDisplayLotteryRewardType Int32
    // 000 RewardFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Reward                                   0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class LivePlayRewardStatus : DataModel
    {
        public LivePlayDisplayLotteryRewardType         RewardType                              { get; set; }
        public ProductWithAmountStatus?                 Reward                                  { get; set; }

        public static LivePlayRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LivePlayRewardStatus() { Pointer= p0 };

            value.RewardType                                = (LivePlayDisplayLotteryRewardType)GetInt32(new IntPtr(p + 0x018)); // 0246612D1430 0x18 RewardType                  ( 0001865675F0 ModelEnumType LivePlayDisplayLotteryRewardType LivePlayDisplayLotteryRewardType LivePlayDisplayLotteryRewardType Int32 )
            value.Reward                                    = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0246612D1470 0x20 Reward                      ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
