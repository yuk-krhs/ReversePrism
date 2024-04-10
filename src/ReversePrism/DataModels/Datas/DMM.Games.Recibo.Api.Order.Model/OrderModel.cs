using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OrderId                                  000186671910 ModelPrimitiveType string string string String
    // 018 PurchaseId                               000186671910 ModelPrimitiveType string string string String
    // 020 Sku                                      000186671910 ModelPrimitiveType string string string String
    // 028 Locale                                   000186671910 ModelPrimitiveType string string string String
    // 030 Type                                     000186671910 ModelPrimitiveType string string string String
    // 038 Title                                    000186671910 ModelPrimitiveType string string string String
    // 040 Price                                    000186671910 ModelPrimitiveType string string string String
    // 048 PriceAmountMicros                        0001865F7700 ModelPrimitiveType long long long Int64
    // 050 PriceCurrencyCode                        000186671910 ModelPrimitiveType string string string String
    // 058 Quantity                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 CreatedAt                                000186671910 ModelPrimitiveType string string string String
    // 068 UpdatedAt                                000186671910 ModelPrimitiveType string string string String
    // 070 DeveloperPayload                         000186671910 ModelPrimitiveType string string string String
    public partial class OrderModel : DataModel
    {
        public string                                   OrderId                                 { get; set; }
        public string                                   PurchaseId                              { get; set; }
        public string                                   Sku                                     { get; set; }
        public string                                   Locale                                  { get; set; }
        public string                                   Type                                    { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Price                                   { get; set; }
        public long                                     PriceAmountMicros                       { get; set; }
        public string                                   PriceCurrencyCode                       { get; set; }
        public int                                      Quantity                                { get; set; }
        public string                                   CreatedAt                               { get; set; }
        public string                                   UpdatedAt                               { get; set; }
        public string                                   DeveloperPayload                        { get; set; }

        public static OrderModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OrderModel() { Pointer= p0 };

            value.OrderId                                   = GetString(new IntPtr(p + 0x010)); // 02466B4E8268 0x10 OrderId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.PurchaseId                                = GetString(new IntPtr(p + 0x018)); // 02466B4E8288 0x18 PurchaseId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Sku                                       = GetString(new IntPtr(p + 0x020)); // 02466B4E82A8 0x20 Sku                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Locale                                    = GetString(new IntPtr(p + 0x028)); // 02466B4E82C8 0x28 Locale                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x030)); // 02466B4E82E8 0x30 Type                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x038)); // 02466B4E8308 0x38 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Price                                     = GetString(new IntPtr(p + 0x040)); // 02466B4E8328 0x40 Price                       ( 000186671910 ModelPrimitiveType string string string String )
            value.PriceAmountMicros                         = GetInt64(new IntPtr(p + 0x048)); // 02466B4E8348 0x48 PriceAmountMicros           ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.PriceCurrencyCode                         = GetString(new IntPtr(p + 0x050)); // 02466B4E8368 0x50 PriceCurrencyCode           ( 000186671910 ModelPrimitiveType string string string String )
            value.Quantity                                  = GetInt32(new IntPtr(p + 0x058)); // 02466B4E8388 0x58 Quantity                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CreatedAt                                 = GetString(new IntPtr(p + 0x060)); // 02466B4E83A8 0x60 CreatedAt                   ( 000186671910 ModelPrimitiveType string string string String )
            value.UpdatedAt                                 = GetString(new IntPtr(p + 0x068)); // 02466B4E83C8 0x68 UpdatedAt                   ( 000186671910 ModelPrimitiveType string string string String )
            value.DeveloperPayload                          = GetString(new IntPtr(p + 0x070)); // 02466B4E83E8 0x70 DeveloperPayload            ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
