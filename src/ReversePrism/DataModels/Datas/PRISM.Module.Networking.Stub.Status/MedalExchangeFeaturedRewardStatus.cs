using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MedalExchangeFeaturedRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RewardFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Reward                                   ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 CountFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Count                                    ModelPrimitiveType int int int Int32
    public partial class MedalExchangeFeaturedRewardStatus : DataModel
    {
        public ProductWithAmountStatus?                 Reward                                  { get; set; }
        public int                                      Count                                   { get; set; }

        public static MedalExchangeFeaturedRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalExchangeFeaturedRewardStatus() { Pointer= p0 };

            value.Reward                                    = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x18 Reward                      ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
