using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ErrorCode
    {
        None,
        PurchasingUnavailable,
        NoProductsAvailable,
        AppNotKnown,
        InitializeConnectionOff,
        InitializeTimeout,
        InitializeUnknown,
        PurchasingUnavailable2,
        ExistingPurchasePending,
        ProductUnavailable,
        SignatureInvalid,
        UserCancelled,
        PaymentDeclined,
        DuplicateTransaction,
        PurchaseUnknown,
        FailedRefreshReceipt,
        UnavailablePurchase,
        NotRegisterBirthday,
        ReserveStoreItemFailed,
        ConnectionFailed,
        PurchaseInitializeFaild,
        PurchaseUnknownOther,
        VerifyReceiptOffset,
        VerifyReceiptDuplicated,
        VerifyReceiptSkip,
        VerifyReceiptUnknown,
        Timeout,
        TitleJump,
        RefreshReceiptErrorOffset,
    }
}
