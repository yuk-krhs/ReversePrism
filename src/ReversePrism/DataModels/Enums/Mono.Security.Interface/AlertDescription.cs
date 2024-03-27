using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum AlertDescription
    {
        CloseNotify,
        UnexpectedMessage,
        BadRecordMAC,
        DecryptionFailed_RESERVED,
        RecordOverflow,
        DecompressionFailure,
        HandshakeFailure,
        NoCertificate_RESERVED,
        BadCertificate,
        UnsupportedCertificate,
        CertificateRevoked,
        CertificateExpired,
        CertificateUnknown,
        IlegalParameter,
        UnknownCA,
        AccessDenied,
        DecodeError,
        DecryptError,
        ExportRestriction,
        ProtocolVersion,
        InsuficientSecurity,
        InternalError,
        UserCancelled,
        NoRenegotiation,
        UnsupportedExtension,
    }
}
