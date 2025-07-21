using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Product                                  ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    public partial class ProductModel : DataModel
    {
        public IProductStatus?                          Product                                 { get; set; }

        public static ProductModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductModel() { Pointer= p0 };

            value.Product                                   = GetObject<IProductStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x10 Product                     ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )

            return value;
        }
    }
}
