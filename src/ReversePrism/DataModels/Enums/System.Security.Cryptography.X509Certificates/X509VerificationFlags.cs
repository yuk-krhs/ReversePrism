using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum X509VerificationFlags
    {
        NoFlag,
        IgnoreNotTimeValid,
        IgnoreCtlNotTimeValid,
        IgnoreNotTimeNested,
        IgnoreInvalidBasicConstraints,
        AllowUnknownCertificateAuthority,
        IgnoreWrongUsage,
        IgnoreInvalidName,
        IgnoreInvalidPolicy,
        IgnoreEndRevocationUnknown,
        IgnoreCtlSignerRevocationUnknown,
        IgnoreCertificateAuthorityRevocationUnknown,
        IgnoreRootRevocationUnknown,
        AllFlags,
    }
}
