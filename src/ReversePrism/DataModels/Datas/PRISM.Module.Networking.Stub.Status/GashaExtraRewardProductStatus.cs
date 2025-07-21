using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaExtraRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Product                                  ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 RewardTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 020 RewardType                               ModelEnumType GashaRewardType GashaRewardType GashaRewardType Int32
    public partial class GashaExtraRewardProductStatus : DataModel
    {
        public ProductWithAmountStatus?                 Product                                 { get; set; }
        public GashaRewardType                          RewardType                              { get; set; }

        public static GashaExtraRewardProductStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExtraRewardProductStatus() { Pointer= p0 };

            value.Product                                   = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x18 Product                     ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.RewardType                                = (GashaRewardType)GetInt32(new IntPtr(p + 0x020)); // 0x20 RewardType                  ( ModelEnumType GashaRewardType GashaRewardType GashaRewardType Int32 )

            return value;
        }
    }
}
