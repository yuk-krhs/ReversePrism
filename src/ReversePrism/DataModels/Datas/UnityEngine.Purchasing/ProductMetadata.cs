using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalizedPriceString                     000186671910 ModelPrimitiveType string string string String
    // 018 LocalizedTitle                           000186671910 ModelPrimitiveType string string string String
    // 020 LocalizedDescription                     000186671910 ModelPrimitiveType string string string String
    // 028 IsoCurrencyCode                          000186671910 ModelPrimitiveType string string string String
    // 030 LocalizedPrice                           0001865C0970 ModelEnumType Decimal Decimal Decimal Int32
    public partial class ProductMetadata
    {
        public string                                   LocalizedPriceString                    { get; set; }
        public string                                   LocalizedTitle                          { get; set; }
        public string                                   LocalizedDescription                    { get; set; }
        public string                                   IsoCurrencyCode                         { get; set; }
        public Decimal                                  LocalizedPrice                          { get; set; }

        public static ProductMetadata? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductMetadata();

            value.LocalizedPriceString                      = GetString(new IntPtr(p + 0x010)); // 027004BFE108 0x10 LocalizedPriceString        ( 000186671910 ModelPrimitiveType string string string String )
            value.LocalizedTitle                            = GetString(new IntPtr(p + 0x018)); // 027004BFE128 0x18 LocalizedTitle              ( 000186671910 ModelPrimitiveType string string string String )
            value.LocalizedDescription                      = GetString(new IntPtr(p + 0x020)); // 027004BFE148 0x20 LocalizedDescription        ( 000186671910 ModelPrimitiveType string string string String )
            value.IsoCurrencyCode                           = GetString(new IntPtr(p + 0x028)); // 027004BFE168 0x28 IsoCurrencyCode             ( 000186671910 ModelPrimitiveType string string string String )
            value.LocalizedPrice                            = (Decimal)GetInt32(new IntPtr(p + 0x030)); // 027004BFE188 0x30 LocalizedPrice              ( 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32 )

            return value;
        }
    }
}
