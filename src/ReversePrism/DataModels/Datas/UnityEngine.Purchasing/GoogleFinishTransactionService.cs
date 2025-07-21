using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BillingClient                          ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer
    // 018 M_GoogleQueryPurchasesService            ModelClassType IGoogleQueryPurchasesService IGoogleQueryPurchasesService IGoogleQueryPurchasesService Pointer
    public partial class GoogleFinishTransactionService : DataModel
    {
        public IGoogleBillingClient?                    M_BillingClient                         { get; set; }
        public IGoogleQueryPurchasesService?            M_GoogleQueryPurchasesService           { get; set; }

        public static GoogleFinishTransactionService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleFinishTransactionService() { Pointer= p0 };

            value.M_BillingClient                           = GetObject<IGoogleBillingClient>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGoogleBillingClient.FromPointer); // 0x10 M_BillingClient             ( ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer )
            value.M_GoogleQueryPurchasesService             = GetObject<IGoogleQueryPurchasesService>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGoogleQueryPurchasesService.FromPointer); // 0x18 M_GoogleQueryPurchasesService ( ModelClassType IGoogleQueryPurchasesService IGoogleQueryPurchasesService IGoogleQueryPurchasesService Pointer )

            return value;
        }
    }
}
