using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Comment                                  000186671910 ModelPrimitiveType string string string String
    // 018 Product                                  000186645350 ModelClassType ProductHeaderValue ProductHeaderValue ProductHeaderValue Pointer
    public partial class ProductInfoHeaderValue
    {
        public string                                   Comment                                 { get; set; }
        public ProductHeaderValue?                      Product                                 { get; set; }

        public static ProductInfoHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductInfoHeaderValue();

            value.Comment                                   = GetString(new IntPtr(p + 0x010)); // 0270DB8928F0 0x10 Comment                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Product                                   = GetObject<ProductHeaderValue>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductHeaderValue.FromPointer); // 0270DB892910 0x18 Product                     ( 000186645350 ModelClassType ProductHeaderValue ProductHeaderValue ProductHeaderValue Pointer )

            return value;
        }
    }
}
