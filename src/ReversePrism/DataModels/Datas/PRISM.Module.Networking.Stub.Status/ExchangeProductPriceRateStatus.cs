using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExchangeProductPriceRateStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PurchaseCountRangeFieldNumber            int IL2CPP_TYPE_I4
    // 018 PurchaseCountRange                       00018660C9D0 ModelClassType RangeStatus RangeStatus RangeStatus Pointer
    // 000 ProductWithAmountFieldNumber             int IL2CPP_TYPE_I4
    // 020 ProductWithAmount                        0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class ExchangeProductPriceRateStatus : DataModel
    {
        public RangeStatus?                             PurchaseCountRange                      { get; set; }
        public ProductWithAmountStatus?                 ProductWithAmount                       { get; set; }

        public static ExchangeProductPriceRateStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeProductPriceRateStatus() { Pointer= p0 };

            value.PurchaseCountRange                        = GetObject<RangeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.RangeStatus.FromPointer); // 02466119FE98 0x18 PurchaseCountRange          ( 00018660C9D0 ModelClassType RangeStatus RangeStatus RangeStatus Pointer )
            value.ProductWithAmount                         = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 02466119FED8 0x20 ProductWithAmount           ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
