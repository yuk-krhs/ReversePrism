using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 products                                 ReadOnlyCollection`1<ProductDefinition> IL2CPP_TYPE_GENERICINST
    // 018 onProductsReceived                       Action`1<List`1<ProductDescription>> IL2CPP_TYPE_GENERICINST
    // 020 onRetrieveProductsFailed                 Action`2<GoogleRetrieveProductsFailureReason, GoogleBillingResponseCode> IL2CPP_TYPE_GENERICINST
    public partial class ProductDescriptionQuery : DataModel
    {

        public static ProductDescriptionQuery? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductDescriptionQuery() { Pointer= p0 };


            return value;
        }
    }
}
