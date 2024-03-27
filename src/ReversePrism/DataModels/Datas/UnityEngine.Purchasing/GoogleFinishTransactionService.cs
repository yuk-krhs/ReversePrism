using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BillingClient                          00018655AFC0 ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer
    // 018 M_GoogleQueryPurchasesService            0001865622D0 ModelClassType IGoogleQueryPurchasesService IGoogleQueryPurchasesService IGoogleQueryPurchasesService Pointer
    public partial class GoogleFinishTransactionService
    {
        public IGoogleBillingClient?                    M_BillingClient                         { get; set; }
        public IGoogleQueryPurchasesService?            M_GoogleQueryPurchasesService           { get; set; }

        public static GoogleFinishTransactionService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleFinishTransactionService();

            value.M_BillingClient                           = GetObject<IGoogleBillingClient>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGoogleBillingClient.FromPointer); // 0270068FE190 0x10 M_BillingClient             ( 00018655AFC0 ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer )
            value.M_GoogleQueryPurchasesService             = GetObject<IGoogleQueryPurchasesService>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGoogleQueryPurchasesService.FromPointer); // 0270068FE1B0 0x18 M_GoogleQueryPurchasesService ( 0001865622D0 ModelClassType IGoogleQueryPurchasesService IGoogleQueryPurchasesService IGoogleQueryPurchasesService Pointer )

            return value;
        }
    }
}
