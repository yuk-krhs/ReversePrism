using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum PurchaseFailureReason
    {
        PurchasingUnavailable,
        ExistingPurchasePending,
        ProductUnavailable,
        SignatureInvalid,
        UserCancelled,
        PaymentDeclined,
        DuplicateTransaction,
        Unknown,
    }
}
