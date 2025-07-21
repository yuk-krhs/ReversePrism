using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BillingClient                          ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer
    // 018 M_PurchaseBuilder                        ModelClassType IGooglePurchaseBuilder IGooglePurchaseBuilder IGooglePurchaseBuilder Pointer
    public partial class GoogleQueryPurchasesService : DataModel
    {
        public IGoogleBillingClient?                    M_BillingClient                         { get; set; }
        public IGooglePurchaseBuilder?                  M_PurchaseBuilder                       { get; set; }

        public static GoogleQueryPurchasesService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleQueryPurchasesService() { Pointer= p0 };

            value.M_BillingClient                           = GetObject<IGoogleBillingClient>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGoogleBillingClient.FromPointer); // 0x10 M_BillingClient             ( ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer )
            value.M_PurchaseBuilder                         = GetObject<IGooglePurchaseBuilder>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGooglePurchaseBuilder.FromPointer); // 0x18 M_PurchaseBuilder           ( ModelClassType IGooglePurchaseBuilder IGooglePurchaseBuilder IGooglePurchaseBuilder Pointer )

            return value;
        }
    }
}
