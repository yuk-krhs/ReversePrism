using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Range                                    00018660C4E0 ModelClassType IRangeStatus IRangeStatus IRangeStatus Pointer
    // 018 ProductWithAmount                        0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    public partial class ExchangePriceRateClientModel : DataModel
    {
        public IRangeStatus?                            Range                                   { get; set; }
        public IProductWithAmountStatus?                ProductWithAmount                       { get; set; }

        public static ExchangePriceRateClientModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangePriceRateClientModel() { Pointer= p0 };

            value.Range                                     = GetObject<IRangeStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IRangeStatus.FromPointer); // 02466554EAD0 0x10 Range                       ( 00018660C4E0 ModelClassType IRangeStatus IRangeStatus IRangeStatus Pointer )
            value.ProductWithAmount                         = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 02466554EAF0 0x18 ProductWithAmount           ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )

            return value;
        }
    }
}
