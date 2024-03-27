using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchasedProduct                         00018659E6D0 ModelClassType Product Product Product Pointer
    public partial class PurchaseEventArgs
    {
        public Product?                                 PurchasedProduct                        { get; set; }

        public static PurchaseEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseEventArgs();

            value.PurchasedProduct                          = GetObject<Product>(new IntPtr(p + 0x010), ReversePrism.DataModels.Product.FromPointer); // 02700692EC68 0x10 PurchasedProduct            ( 00018659E6D0 ModelClassType Product Product Product Pointer )

            return value;
        }
    }
}
