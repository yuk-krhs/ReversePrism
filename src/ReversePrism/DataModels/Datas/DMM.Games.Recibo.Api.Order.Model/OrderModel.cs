using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OrderId                                  ModelPrimitiveType string string string String
    // 018 PurchaseId                               ModelPrimitiveType string string string String
    // 020 Sku                                      ModelPrimitiveType string string string String
    // 028 Locale                                   ModelPrimitiveType string string string String
    // 030 Type                                     ModelPrimitiveType string string string String
    // 038 Title                                    ModelPrimitiveType string string string String
    // 040 Price                                    ModelPrimitiveType string string string String
    // 048 PriceAmountMicros                        ModelPrimitiveType long long long Int64
    // 050 PriceCurrencyCode                        ModelPrimitiveType string string string String
    // 058 Quantity                                 ModelPrimitiveType int int int Int32
    // 060 CreatedAt                                ModelPrimitiveType string string string String
    // 068 UpdatedAt                                ModelPrimitiveType string string string String
    // 070 DeveloperPayload                         ModelPrimitiveType string string string String
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

            value.OrderId                                   = GetString(new IntPtr(p + 0x010)); // 0x10 OrderId                     ( ModelPrimitiveType string string string String )
            value.PurchaseId                                = GetString(new IntPtr(p + 0x018)); // 0x18 PurchaseId                  ( ModelPrimitiveType string string string String )
            value.Sku                                       = GetString(new IntPtr(p + 0x020)); // 0x20 Sku                         ( ModelPrimitiveType string string string String )
            value.Locale                                    = GetString(new IntPtr(p + 0x028)); // 0x28 Locale                      ( ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x030)); // 0x30 Type                        ( ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x038)); // 0x38 Title                       ( ModelPrimitiveType string string string String )
            value.Price                                     = GetString(new IntPtr(p + 0x040)); // 0x40 Price                       ( ModelPrimitiveType string string string String )
            value.PriceAmountMicros                         = GetInt64(new IntPtr(p + 0x048)); // 0x48 PriceAmountMicros           ( ModelPrimitiveType long long long Int64 )
            value.PriceCurrencyCode                         = GetString(new IntPtr(p + 0x050)); // 0x50 PriceCurrencyCode           ( ModelPrimitiveType string string string String )
            value.Quantity                                  = GetInt32(new IntPtr(p + 0x058)); // 0x58 Quantity                    ( ModelPrimitiveType int int int Int32 )
            value.CreatedAt                                 = GetString(new IntPtr(p + 0x060)); // 0x60 CreatedAt                   ( ModelPrimitiveType string string string String )
            value.UpdatedAt                                 = GetString(new IntPtr(p + 0x068)); // 0x68 UpdatedAt                   ( ModelPrimitiveType string string string String )
            value.DeveloperPayload                          = GetString(new IntPtr(p + 0x070)); // 0x70 DeveloperPayload            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
