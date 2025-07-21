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
    // 018 IsFeatured                               ModelPrimitiveType bool bool bool Bool
    // 000 CountFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Count                                    ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 RewardFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Reward                                   ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class MedalGashaRewardStatus : DataModel
    {
        public bool                                     IsFeatured                              { get; set; }
        public LimitedValueStatus?                      Count                                   { get; set; }
        public ProductWithAmountStatus?                 Reward                                  { get; set; }

        public static MedalGashaRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardStatus() { Pointer= p0 };

            value.IsFeatured                                = GetBool(new IntPtr(p + 0x018)); // 0x18 IsFeatured                  ( ModelPrimitiveType bool bool bool Bool )
            value.Count                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x20 Count                       ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.Reward                                    = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x28 Reward                      ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
