using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum PurchaseState
    {
        None,
        InitSdk,
        CheckError,
        ShowErrorDialog,
        ShowRetryDialog,
        GetPurchasedReceiptList,
        CheckOderPurchased,
        CreateOder,
        GetBlance,
        CheckPointBlance,
        ShowOderDialog,
        ShowShortageDialog,
        ShowConfirmDialog,
        Cancel,
        UserValidateBeforePurchase,
        Purchasing,
        UserValidateAfterPurchase,
        Complete,
        Finish,
    }
}
