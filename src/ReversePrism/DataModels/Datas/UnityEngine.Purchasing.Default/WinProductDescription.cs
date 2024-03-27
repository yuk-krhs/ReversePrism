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
    public partial class WinProductDescription
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
            var value   = new WinProductDescription();

            value.PlatformSpecificID                        = GetString(new IntPtr(p + 0x010)); // 02700697F810 0x10 PlatformSpecificID          ( 000186671910 ModelPrimitiveType string string string String )
            value.Price                                     = GetString(new IntPtr(p + 0x018)); // 02700697F830 0x18 Price                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x020)); // 02700697F850 0x20 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x028)); // 02700697F870 0x28 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.ISOCurrencyCode                           = GetString(new IntPtr(p + 0x030)); // 02700697F890 0x30 ISOCurrencyCode             ( 000186671910 ModelPrimitiveType string string string String )
            value.PriceDecimal                              = (Decimal)GetInt32(new IntPtr(p + 0x038)); // 02700697F8B0 0x38 PriceDecimal                ( 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32 )
            value.Receipt                                   = GetString(new IntPtr(p + 0x048)); // 02700697F8D0 0x48 Receipt                     ( 000186671910 ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x050)); // 02700697F8F0 0x50 TransactionID               ( 000186671910 ModelPrimitiveType string string string String )
            value.Consumable                                = GetBool(new IntPtr(p + 0x058)); // 02700697F910 0x58 Consumable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
