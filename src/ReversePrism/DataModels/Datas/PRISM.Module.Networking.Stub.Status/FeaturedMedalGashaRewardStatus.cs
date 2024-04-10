using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FeaturedMedalGashaRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RewardFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Reward                                   0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Amount                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FeaturedMedalGashaRewardStatus : DataModel
    {
        public ProductWithAmountStatus?                 Reward                                  { get; set; }
        public int                                      Amount                                  { get; set; }

        public static FeaturedMedalGashaRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FeaturedMedalGashaRewardStatus() { Pointer= p0 };

            value.Reward                                    = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 024662207840 0x18 Reward                      ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x020)); // 024662207880 0x20 Amount                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
