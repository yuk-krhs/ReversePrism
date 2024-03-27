using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PurchaseExchangeProductReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BeforeExchangeProductFieldNumber         int IL2CPP_TYPE_I4
    // 018 BeforeExchangeProduct                    0001865140D0 ModelClassType ExchangeProductStatus ExchangeProductStatus ExchangeProductStatus Pointer
    // 000 AfterExchangeProductFieldNumber          int IL2CPP_TYPE_I4
    // 020 AfterExchangeProduct                     0001865140D0 ModelClassType ExchangeProductStatus ExchangeProductStatus ExchangeProductStatus Pointer
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Amount                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 030 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    // 000 RewardProductListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_rewardProductList_codec        FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 038 RewardProductList                        000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    public partial class PurchaseExchangeProductReply
    {
        public ExchangeProductStatus?                   BeforeExchangeProduct                   { get; set; }
        public ExchangeProductStatus?                   AfterExchangeProduct                    { get; set; }
        public int                                      Amount                                  { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }
        public List<RewardProductStatus>?               RewardProductList                       { get; set; }

        public static PurchaseExchangeProductReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseExchangeProductReply();

            value.BeforeExchangeProduct                     = GetObject<ExchangeProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExchangeProductStatus.FromPointer); // 0270D12249F8 0x18 BeforeExchangeProduct       ( 0001865140D0 ModelClassType ExchangeProductStatus ExchangeProductStatus ExchangeProductStatus Pointer )
            value.AfterExchangeProduct                      = GetObject<ExchangeProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExchangeProductStatus.FromPointer); // 0270D1224A38 0x20 AfterExchangeProduct        ( 0001865140D0 ModelClassType ExchangeProductStatus ExchangeProductStatus ExchangeProductStatus Pointer )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D1224A78 0x28 Amount                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0270D1224AB8 0x30 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )
            value.RewardProductList                         = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0270D1224B18 0x38 RewardProductList           ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )

            return value;
        }
    }
}
