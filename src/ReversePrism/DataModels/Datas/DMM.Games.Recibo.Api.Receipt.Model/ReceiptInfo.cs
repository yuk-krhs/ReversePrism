using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchaseToken                            ModelPrimitiveType string string string String
    // 018 OrderId                                  ModelPrimitiveType string string string String
    // 020 ProductId                                ModelPrimitiveType string string string String
    // 028 Price                                    ModelPrimitiveType string string string String
    // 030 PriceAmountMicros                        ModelPrimitiveType long long long Int64
    // 038 PriceCurrencyCode                        ModelPrimitiveType string string string String
    // 040 Quantity                                 ModelPrimitiveType int int int Int32
    // 048 PurchaseTime                             ModelPrimitiveType long long long Int64
    // 050 DeveloperPayload                         ModelPrimitiveType string string string String
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

            value.PurchaseToken                             = GetString(new IntPtr(p + 0x010)); // 0x10 PurchaseToken               ( ModelPrimitiveType string string string String )
            value.OrderId                                   = GetString(new IntPtr(p + 0x018)); // 0x18 OrderId                     ( ModelPrimitiveType string string string String )
            value.ProductId                                 = GetString(new IntPtr(p + 0x020)); // 0x20 ProductId                   ( ModelPrimitiveType string string string String )
            value.Price                                     = GetString(new IntPtr(p + 0x028)); // 0x28 Price                       ( ModelPrimitiveType string string string String )
            value.PriceAmountMicros                         = GetInt64(new IntPtr(p + 0x030)); // 0x30 PriceAmountMicros           ( ModelPrimitiveType long long long Int64 )
            value.PriceCurrencyCode                         = GetString(new IntPtr(p + 0x038)); // 0x38 PriceCurrencyCode           ( ModelPrimitiveType string string string String )
            value.Quantity                                  = GetInt32(new IntPtr(p + 0x040)); // 0x40 Quantity                    ( ModelPrimitiveType int int int Int32 )
            value.PurchaseTime                              = GetInt64(new IntPtr(p + 0x048)); // 0x48 PurchaseTime                ( ModelPrimitiveType long long long Int64 )
            value.DeveloperPayload                          = GetString(new IntPtr(p + 0x050)); // 0x50 DeveloperPayload            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
