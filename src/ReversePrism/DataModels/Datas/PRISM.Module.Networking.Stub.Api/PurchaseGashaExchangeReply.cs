using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PurchaseGashaExchangeReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ExchangeFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Exchange                                 000186602DE0 ModelClassType GashaExchangeStatus GashaExchangeStatus GashaExchangeStatus Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 020 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    // 000 RewardProductListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_rewardProductList_codec        FieldCodec`1<GashaRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 028 RewardProductList                        000185CDD198 ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer
    public partial class PurchaseGashaExchangeReply : DataModel
    {
        public GashaExchangeStatus?                     Exchange                                { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }
        public List<GashaRewardProductStatus>?          RewardProductList                       { get; set; }

        public static PurchaseGashaExchangeReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseGashaExchangeReply() { Pointer= p0 };

            value.Exchange                                  = GetObject<GashaExchangeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaExchangeStatus.FromPointer); // 0246619A77D0 0x18 Exchange                    ( 000186602DE0 ModelClassType GashaExchangeStatus GashaExchangeStatus GashaExchangeStatus Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0246619A7810 0x20 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )
            value.RewardProductList                         = GetObjectList<GashaRewardProductStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaRewardProductStatus.FromPointer); // 0246619A7870 0x28 RewardProductList           ( 000185CDD198 ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer )

            return value;
        }
    }
}
