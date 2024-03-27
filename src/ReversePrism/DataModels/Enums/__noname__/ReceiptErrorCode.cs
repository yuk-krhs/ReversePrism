using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ReceiptErrorCode
    {
        None,
        Unknown,
        ReceiptNotFound,
        Duplicated,
        TaskQueueError,
        NotPrepared,
        Jsonerror,
        OwnerMissMatch,
        ProductIdmissMatch,
        SignatureFail,
        DeveloperPayloadMissMatch,
        ReceiptDataFormatError,
        ReceiptFail,
        ServerCurrentlyUnabable,
        EnvironmentMissMatch,
        PurchaseStateError,
        Num,
    }
}
