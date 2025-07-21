using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalizedPriceString                     ModelPrimitiveType string string string String
    // 018 LocalizedTitle                           ModelPrimitiveType string string string String
    // 020 LocalizedDescription                     ModelPrimitiveType string string string String
    // 028 IsoCurrencyCode                          ModelPrimitiveType string string string String
    // 030 LocalizedPrice                           ModelEnumType Decimal Decimal Decimal Int32
    public partial class ProductMetadata : DataModel
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
            var value   = new ProductMetadata() { Pointer= p0 };

            value.LocalizedPriceString                      = GetString(new IntPtr(p + 0x010)); // 0x10 LocalizedPriceString        ( ModelPrimitiveType string string string String )
            value.LocalizedTitle                            = GetString(new IntPtr(p + 0x018)); // 0x18 LocalizedTitle              ( ModelPrimitiveType string string string String )
            value.LocalizedDescription                      = GetString(new IntPtr(p + 0x020)); // 0x20 LocalizedDescription        ( ModelPrimitiveType string string string String )
            value.IsoCurrencyCode                           = GetString(new IntPtr(p + 0x028)); // 0x28 IsoCurrencyCode             ( ModelPrimitiveType string string string String )
            value.LocalizedPrice                            = (Decimal)GetInt32(new IntPtr(p + 0x030)); // 0x30 LocalizedPrice              ( ModelEnumType Decimal Decimal Decimal Int32 )

            return value;
        }
    }
}
