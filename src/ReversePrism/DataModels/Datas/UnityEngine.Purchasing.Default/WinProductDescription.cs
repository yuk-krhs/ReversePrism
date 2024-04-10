using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PlatformSpecificID                       000186671910 ModelPrimitiveType string string string String
    // 018 Price                                    000186671910 ModelPrimitiveType string string string String
    // 020 Title                                    000186671910 ModelPrimitiveType string string string String
    // 028 Description                              000186671910 ModelPrimitiveType string string string String
    // 030 ISOCurrencyCode                          000186671910 ModelPrimitiveType string string string String
    // 038 PriceDecimal                             0001865C0970 ModelEnumType Decimal Decimal Decimal Int32
    // 048 Receipt                                  000186671910 ModelPrimitiveType string string string String
    // 050 TransactionID                            000186671910 ModelPrimitiveType string string string String
    // 058 Consumable                               000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.PlatformSpecificID                        = GetString(new IntPtr(p + 0x010)); // 0245A6931FA8 0x10 PlatformSpecificID          ( 000186671910 ModelPrimitiveType string string string String )
            value.Price                                     = GetString(new IntPtr(p + 0x018)); // 0245A6931FC8 0x18 Price                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x020)); // 0245A6931FE8 0x20 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x028)); // 0245A6932008 0x28 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.ISOCurrencyCode                           = GetString(new IntPtr(p + 0x030)); // 0245A6932028 0x30 ISOCurrencyCode             ( 000186671910 ModelPrimitiveType string string string String )
            value.PriceDecimal                              = (Decimal)GetInt32(new IntPtr(p + 0x038)); // 0245A6932048 0x38 PriceDecimal                ( 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32 )
            value.Receipt                                   = GetString(new IntPtr(p + 0x048)); // 0245A6932068 0x48 Receipt                     ( 000186671910 ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x050)); // 0245A6932088 0x50 TransactionID               ( 000186671910 ModelPrimitiveType string string string String )
            value.Consumable                                = GetBool(new IntPtr(p + 0x058)); // 0245A69320A8 0x58 Consumable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
