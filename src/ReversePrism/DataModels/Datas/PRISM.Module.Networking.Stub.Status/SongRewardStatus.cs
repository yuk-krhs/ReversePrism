using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SongRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SongRewardTypeFieldNumber                int IL2CPP_TYPE_I4
    // 018 SongRewardType                           00018652A940 ModelEnumType SongRewardType SongRewardType SongRewardType Int32
    // 000 RewardFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Reward                                   0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class SongRewardStatus
    {
        public SongRewardType                           SongRewardType                          { get; set; }
        public ProductWithAmountStatus?                 Reward                                  { get; set; }

        public static SongRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SongRewardStatus();

            value.SongRewardType                            = (SongRewardType)GetInt32(new IntPtr(p + 0x018)); // 0270D13724A0 0x18 SongRewardType              ( 00018652A940 ModelEnumType SongRewardType SongRewardType SongRewardType Int32 )
            value.Reward                                    = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D13724E0 0x20 Reward                      ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
