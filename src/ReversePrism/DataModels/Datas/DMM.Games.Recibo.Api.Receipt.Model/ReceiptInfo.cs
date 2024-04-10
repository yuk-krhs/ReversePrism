using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchaseToken                            000186671910 ModelPrimitiveType string string string String
    // 018 OrderId                                  000186671910 ModelPrimitiveType string string string String
    // 020 ProductId                                000186671910 ModelPrimitiveType string string string String
    // 028 Price                                    000186671910 ModelPrimitiveType string string string String
    // 030 PriceAmountMicros                        0001865F7700 ModelPrimitiveType long long long Int64
    // 038 PriceCurrencyCode                        000186671910 ModelPrimitiveType string string string String
    // 040 Quantity                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 PurchaseTime                             0001865F7700 ModelPrimitiveType long long long Int64
    // 050 DeveloperPayload                         000186671910 ModelPrimitiveType string string string String
    public partial class ReceiptInfo : DataModel
    {
        public string                                   PurchaseToken                           { get; set; }
        public string                                   OrderId                                 { get; set; }
        public string                                   ProductId                               { get; set; }
        public string                                   Price                                   { get; set; }
        public long                                     PriceAmountMicros                       { get; set; }
        public string                                   PriceCurrencyCode                       { get; set; }
        public int                                      Quantity                                { get; set; }
        public long                                     PurchaseTime                            { get; set; }
        public string                                   DeveloperPayload                        { get; set; }

        public static ReceiptInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiptInfo() { Pointer= p0 };

            value.PurchaseToken                             = GetString(new IntPtr(p + 0x010)); // 0245A4BFF2B8 0x10 PurchaseToken               ( 000186671910 ModelPrimitiveType string string string String )
            value.OrderId                                   = GetString(new IntPtr(p + 0x018)); // 0245A4BFF2D8 0x18 OrderId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ProductId                                 = GetString(new IntPtr(p + 0x020)); // 0245A4BFF2F8 0x20 ProductId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Price                                     = GetString(new IntPtr(p + 0x028)); // 0245A4BFF318 0x28 Price                       ( 000186671910 ModelPrimitiveType string string string String )
            value.PriceAmountMicros                         = GetInt64(new IntPtr(p + 0x030)); // 0245A4BFF338 0x30 PriceAmountMicros           ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.PriceCurrencyCode                         = GetString(new IntPtr(p + 0x038)); // 0245A4BFF358 0x38 PriceCurrencyCode           ( 000186671910 ModelPrimitiveType string string string String )
            value.Quantity                                  = GetInt32(new IntPtr(p + 0x040)); // 0245A4BFF378 0x40 Quantity                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PurchaseTime                              = GetInt64(new IntPtr(p + 0x048)); // 0245A4BFF398 0x48 PurchaseTime                ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.DeveloperPayload                          = GetString(new IntPtr(p + 0x050)); // 0245A4BFF3B8 0x50 DeveloperPayload            ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
