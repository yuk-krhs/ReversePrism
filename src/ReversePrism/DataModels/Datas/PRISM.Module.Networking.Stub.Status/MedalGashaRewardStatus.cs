using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MedalGashaRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsFeaturedFieldNumber                    int IL2CPP_TYPE_I4
    // 018 IsFeatured                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 CountFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Count                                    00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 RewardFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Reward                                   0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class MedalGashaRewardStatus
    {
        public bool                                     IsFeatured                              { get; set; }
        public LimitedValueStatus?                      Count                                   { get; set; }
        public ProductWithAmountStatus?                 Reward                                  { get; set; }

        public static MedalGashaRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardStatus();

            value.IsFeatured                                = GetBool(new IntPtr(p + 0x018)); // 0270D229AFB0 0x18 IsFeatured                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Count                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0270D229AFF0 0x20 Count                       ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.Reward                                    = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D229B030 0x28 Reward                      ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
