using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RewardProductFieldNumber                 int IL2CPP_TYPE_I4
    // 018 RewardProduct                            000186680200 ModelClassType RewardProductStatus RewardProductStatus RewardProductStatus Pointer
    // 000 ExtraProductListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_extraProductList_codec         FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 ExtraProductList                         000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 ExtraListFieldNumber                     int IL2CPP_TYPE_I4
    // 010 _repeated_extraList_codec                FieldCodec`1<GashaExtraRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 028 ExtraList                                000185CDB8A8 ModelClassListType RepeatedField`1<GashaExtraRewardProductStatus> RepeatedField`1<GashaExtraRewardProductStatus> List<GashaExtraRewardProductStatus> Pointer
    public partial class GashaRewardProductStatus
    {
        public RewardProductStatus?                     RewardProduct                           { get; set; }
        public List<ProductWithAmountStatus>?           ExtraProductList                        { get; set; }
        public List<GashaExtraRewardProductStatus>?     ExtraList                               { get; set; }

        public static GashaRewardProductStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRewardProductStatus();

            value.RewardProduct                             = GetObject<RewardProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0270D15A1778 0x18 RewardProduct               ( 000186680200 ModelClassType RewardProductStatus RewardProductStatus RewardProductStatus Pointer )
            value.ExtraProductList                          = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D15A17D8 0x20 ExtraProductList            ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.ExtraList                                 = GetObjectList<GashaExtraRewardProductStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaExtraRewardProductStatus.FromPointer); // 0270D15A1838 0x28 ExtraList                   ( 000185CDB8A8 ModelClassListType RepeatedField`1<GashaExtraRewardProductStatus> RepeatedField`1<GashaExtraRewardProductStatus> List<GashaExtraRewardProductStatus> Pointer )

            return value;
        }
    }
}
