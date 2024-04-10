using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExchangeSelectionTicketReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductWithAmountFieldNumber             int IL2CPP_TYPE_I4
    // 018 ProductWithAmount                        0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 020 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    // 000 RewardProductListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_rewardProductList_codec        FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 028 RewardProductList                        000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    public partial class ExchangeSelectionTicketReply : DataModel
    {
        public ProductWithAmountStatus?                 ProductWithAmount                       { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }
        public List<RewardProductStatus>?               RewardProductList                       { get; set; }

        public static ExchangeSelectionTicketReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionTicketReply() { Pointer= p0 };

            value.ProductWithAmount                         = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 024661191090 0x18 ProductWithAmount           ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0246611910D0 0x20 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )
            value.RewardProductList                         = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 024661191130 0x28 RewardProductList           ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )

            return value;
        }
    }
}
