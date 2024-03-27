using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ErrorReason
    {
        Unspecified,
        ServiceDisabled,
        BillingDisabled,
        ApiKeyInvalid,
        ApiKeyServiceBlocked,
        ApiKeyHttpReferrerBlocked,
        ApiKeyIpAddressBlocked,
        ApiKeyAndroidAppBlocked,
        ApiKeyIosAppBlocked,
        RateLimitExceeded,
        ResourceQuotaExceeded,
        LocationTaxPolicyViolated,
        UserProjectDenied,
        ConsumerSuspended,
        ConsumerInvalid,
        SecurityPolicyViolated,
        AccessTokenExpired,
    }
}
