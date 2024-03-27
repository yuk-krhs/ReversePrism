using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum GoogleBillingResponseCode
    {
        ServiceTimeout,
        FeatureNotSupported,
        ServiceDisconnected,
        Ok,
        UserCanceled,
        ServiceUnavailable,
        BillingUnavailable,
        ItemUnavailable,
        DeveloperError,
        FatalError,
        ItemAlreadyOwned,
        ItemNotOwned,
    }
}
