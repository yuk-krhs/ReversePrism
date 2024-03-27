using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  ProductKey IL2CPP_TYPE_VALUETYPE
    // 010 ProductType                              000186611300 ModelEnumType ProductType ProductType ProductType Int32
    // 014 ProductMstId                             0001865F4940 ModelPrimitiveType int int int Int32
    public partial class ProductKey
    {
        public ProductType                              ProductType                             { get; set; }
        public int                                      ProductMstId                            { get; set; }

        public static ProductKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductKey();

            value.ProductType                               = (ProductType)GetInt32(new IntPtr(p + 0x010)); // 027004A967F8 0x10 ProductType                 ( 000186611300 ModelEnumType ProductType ProductType ProductType Int32 )
            value.ProductMstId                              = GetInt32(new IntPtr(p + 0x014)); // 027004A96818 0x14 ProductMstId                ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
