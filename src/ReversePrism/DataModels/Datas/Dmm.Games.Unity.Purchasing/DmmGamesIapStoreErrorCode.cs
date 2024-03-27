using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ApiFailed                                int IL2CPP_TYPE_I4
    // 000 ConnectionError                          int IL2CPP_TYPE_I4
    // 000 ConnectionMaxRetry                       int IL2CPP_TYPE_I4
    // 000 TransactionIdMismatch                    int IL2CPP_TYPE_I4
    // 000 Maintenance                              int IL2CPP_TYPE_I4
    // 000 GetPurchasedReceiptListFailure           int IL2CPP_TYPE_I4
    // 000 GetPurchasedReceiptListError             int IL2CPP_TYPE_I4
    // 000 CheckOrderPurchased                      int IL2CPP_TYPE_I4
    // 000 CreateOrderFailure                       int IL2CPP_TYPE_I4
    // 000 CreateOrderError                         int IL2CPP_TYPE_I4
    // 000 GetBlanceFailure                         int IL2CPP_TYPE_I4
    // 000 GetBlanceError                           int IL2CPP_TYPE_I4
    // 000 PurchasingFailure                        int IL2CPP_TYPE_I4
    // 000 PurchasingError                          int IL2CPP_TYPE_I4
    // 000 UserCancel                               int IL2CPP_TYPE_I4
    // 000 Uninitialized                            int IL2CPP_TYPE_I4
    // 000 ProductNotFound                          int IL2CPP_TYPE_I4
    // 000 UnableToGetUserId                        int IL2CPP_TYPE_I4
    // 000 AccessTokenUnspecified                   int IL2CPP_TYPE_I4
    // 000 InvalidApiAccessKeyFile                  int IL2CPP_TYPE_I4
    // 000 FailedToRetrieveInformation              int IL2CPP_TYPE_I4
    // 000 FailedToRetrieveUserInformation          int IL2CPP_TYPE_I4
    // 000 AccessTokenInvalid                       int IL2CPP_TYPE_I4
    // 000 AccessTokenExpired                       int IL2CPP_TYPE_I4
    // 000 AccessTokenNotSet                        int IL2CPP_TYPE_I4
    // 000 CombinationError                         int IL2CPP_TYPE_I4
    // 000 UnableToGetSKU                           int IL2CPP_TYPE_I4
    // 000 PurchaseNotExist                         int IL2CPP_TYPE_I4
    // 000 UnknownError                             int IL2CPP_TYPE_I4
    public partial class DmmGamesIapStoreErrorCode
    {

        public static DmmGamesIapStoreErrorCode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesIapStoreErrorCode();


            return value;
        }
    }
}
