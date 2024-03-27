using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum X509ChainStatusFlags
    {
        NoError,
        NotTimeValid,
        NotTimeNested,
        Revoked,
        NotSignatureValid,
        NotValidForUsage,
        UntrustedRoot,
        RevocationStatusUnknown,
        Cyclic,
        InvalidExtension,
        InvalidPolicyConstraints,
        InvalidBasicConstraints,
        InvalidNameConstraints,
        HasNotSupportedNameConstraint,
        HasNotDefinedNameConstraint,
        HasNotPermittedNameConstraint,
        HasExcludedNameConstraint,
        PartialChain,
        CtlNotTimeValid,
        CtlNotSignatureValid,
        CtlNotValidForUsage,
        OfflineRevocation,
        NoIssuanceChainPolicy,
        ExplicitDistrust,
        HasNotSupportedCriticalExtension,
        HasWeakSignature,
    }
}
