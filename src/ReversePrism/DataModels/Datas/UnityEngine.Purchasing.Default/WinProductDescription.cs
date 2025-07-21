using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PlatformSpecificID                       ModelPrimitiveType string string string String
    // 018 Price                                    ModelPrimitiveType string string string String
    // 020 Title                                    ModelPrimitiveType string string string String
    // 028 Description                              ModelPrimitiveType string string string String
    // 030 ISOCurrencyCode                          ModelPrimitiveType string string string String
    // 038 PriceDecimal                             ModelEnumType Decimal Decimal Decimal Int32
    // 048 Receipt                                  ModelPrimitiveType string string string String
    // 050 TransactionID                            ModelPrimitiveType string string string String
    // 058 Consumable                               ModelPrimitiveType bool bool bool Bool
    public partial class WinProductDescription : DataModel
    {
        public string                                   PlatformSpecificID                      { get; set; }
        public string                                   Price                                   { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }
        public string                                   ISOCurrencyCode                         { get; set; }
        public Decimal                                  PriceDecimal                            { get; set; }
        public string                                   Receipt                                 { get; set; }
        public string                                   TransactionID                           { get; set; }
        public bool                                     Consumable                              { get; set; }

        public static WinProductDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WinProductDescription() { Pointer= p0 };

            value.PlatformSpecificID                        = GetString(new IntPtr(p + 0x010)); // 0x10 PlatformSpecificID          ( ModelPrimitiveType string string string String )
            value.Price                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Price                       ( ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x020)); // 0x20 Title                       ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x028)); // 0x28 Description                 ( ModelPrimitiveType string string string String )
            value.ISOCurrencyCode                           = GetString(new IntPtr(p + 0x030)); // 0x30 ISOCurrencyCode             ( ModelPrimitiveType string string string String )
            value.PriceDecimal                              = (Decimal)GetInt32(new IntPtr(p + 0x038)); // 0x38 PriceDecimal                ( ModelEnumType Decimal Decimal Decimal Int32 )
            value.Receipt                                   = GetString(new IntPtr(p + 0x048)); // 0x48 Receipt                     ( ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x050)); // 0x50 TransactionID               ( ModelPrimitiveType string string string String )
            value.Consumable                                = GetBool(new IntPtr(p + 0x058)); // 0x58 Consumable                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
