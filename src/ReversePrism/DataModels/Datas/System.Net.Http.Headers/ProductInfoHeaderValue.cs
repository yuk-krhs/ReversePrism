using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Comment                                  ModelPrimitiveType string string string String
    // 018 Product                                  ModelClassType ProductHeaderValue ProductHeaderValue ProductHeaderValue Pointer
    public partial class ProductInfoHeaderValue : DataModel
    {
        public string                                   Comment                                 { get; set; }
        public ProductHeaderValue?                      Product                                 { get; set; }

        public static ProductInfoHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductInfoHeaderValue() { Pointer= p0 };

            value.Comment                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Comment                     ( ModelPrimitiveType string string string String )
            value.Product                                   = GetObject<ProductHeaderValue>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductHeaderValue.FromPointer); // 0x18 Product                     ( ModelClassType ProductHeaderValue ProductHeaderValue ProductHeaderValue Pointer )

            return value;
        }
    }
}
