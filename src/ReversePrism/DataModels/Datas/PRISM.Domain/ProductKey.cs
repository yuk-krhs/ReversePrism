using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  ProductKey IL2CPP_TYPE_VALUETYPE
    // 010 ProductType                              ModelEnumType ProductType ProductType ProductType Int32
    // 014 ProductMstId                             ModelPrimitiveType int int int Int32
    public partial class ProductKey : DataModel
    {
        public ProductType                              ProductType                             { get; set; }
        public int                                      ProductMstId                            { get; set; }

        public static ProductKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductKey() { Pointer= p0 };

            value.ProductType                               = (ProductType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ProductType                 ( ModelEnumType ProductType ProductType ProductType Int32 )
            value.ProductMstId                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 ProductMstId                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
