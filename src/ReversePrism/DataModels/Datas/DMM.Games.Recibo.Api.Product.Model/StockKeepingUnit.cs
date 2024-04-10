using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductId                                000186671910 ModelPrimitiveType string string string String
    // 018 Type                                     000186671910 ModelPrimitiveType string string string String
    // 020 Title                                    000186671910 ModelPrimitiveType string string string String
    // 028 Description                              000186671910 ModelPrimitiveType string string string String
    // 030 Price                                    000186671910 ModelPrimitiveType string string string String
    // 038 PriceAmountMicros                        0001865F7700 ModelPrimitiveType long long long Int64
    // 040 PriceCurrencyCode                        000186671910 ModelPrimitiveType string string string String
    public partial class StockKeepingUnit : DataModel
    {
        public string                                   ProductId                               { get; set; }
        public string                                   Type                                    { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }
        public string                                   Price                                   { get; set; }
        public long                                     PriceAmountMicros                       { get; set; }
        public string                                   PriceCurrencyCode                       { get; set; }

        public static StockKeepingUnit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StockKeepingUnit() { Pointer= p0 };

            value.ProductId                                 = GetString(new IntPtr(p + 0x010)); // 0245A4BFEDE8 0x10 ProductId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 0245A4BFEE08 0x18 Type                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x020)); // 0245A4BFEE28 0x20 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x028)); // 0245A4BFEE48 0x28 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Price                                     = GetString(new IntPtr(p + 0x030)); // 0245A4BFEE68 0x30 Price                       ( 000186671910 ModelPrimitiveType string string string String )
            value.PriceAmountMicros                         = GetInt64(new IntPtr(p + 0x038)); // 0245A4BFEE88 0x38 PriceAmountMicros           ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.PriceCurrencyCode                         = GetString(new IntPtr(p + 0x040)); // 0245A4BFEEA8 0x40 PriceCurrencyCode           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
