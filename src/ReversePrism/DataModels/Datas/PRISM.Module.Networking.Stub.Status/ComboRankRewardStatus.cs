using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ComboRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Rank                                     0001865DE690 ModelEnumType ComboRank ComboRank ComboRank Int32
    // 000 RewardFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Reward                                   0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class ComboRankRewardStatus
    {
        public ComboRank                                Rank                                    { get; set; }
        public ProductWithAmountStatus?                 Reward                                  { get; set; }

        public static ComboRankRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComboRankRewardStatus();

            value.Rank                                      = (ComboRank)GetInt32(new IntPtr(p + 0x018)); // 0270D133A570 0x18 Rank                        ( 0001865DE690 ModelEnumType ComboRank ComboRank ComboRank Int32 )
            value.Reward                                    = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D133A5B0 0x20 Reward                      ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
