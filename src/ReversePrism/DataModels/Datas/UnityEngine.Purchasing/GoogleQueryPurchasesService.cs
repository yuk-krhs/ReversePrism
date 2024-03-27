using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BillingClient                          00018655AFC0 ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer
    // 018 M_PurchaseBuilder                        0001865609D0 ModelClassType IGooglePurchaseBuilder IGooglePurchaseBuilder IGooglePurchaseBuilder Pointer
    public partial class GoogleQueryPurchasesService
    {
        public IGoogleBillingClient?                    M_BillingClient                         { get; set; }
        public IGooglePurchaseBuilder?                  M_PurchaseBuilder                       { get; set; }

        public static GoogleQueryPurchasesService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleQueryPurchasesService();

            value.M_BillingClient                           = GetObject<IGoogleBillingClient>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGoogleBillingClient.FromPointer); // 027006903260 0x10 M_BillingClient             ( 00018655AFC0 ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer )
            value.M_PurchaseBuilder                         = GetObject<IGooglePurchaseBuilder>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGooglePurchaseBuilder.FromPointer); // 027006903280 0x18 M_PurchaseBuilder           ( 0001865609D0 ModelClassType IGooglePurchaseBuilder IGooglePurchaseBuilder IGooglePurchaseBuilder Pointer )

            return value;
        }
    }
}
