using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum UnityWebRequestError
    {
        OK,
        OKCached,
        Unknown,
        SDKError,
        UnsupportedProtocol,
        MalformattedUrl,
        CannotResolveProxy,
        CannotResolveHost,
        CannotConnectToHost,
        AccessDenied,
        GenericHttpError,
        WriteError,
        ReadError,
        OutOfMemory,
        Timeout,
        HTTPPostError,
        SSLCannotConnect,
        Aborted,
        TooManyRedirects,
        ReceivedNoData,
        SSLNotSupported,
        FailedToSendData,
        FailedToReceiveData,
        SSLCertificateError,
        SSLCipherNotAvailable,
        SSLCACertError,
        UnrecognizedContentEncoding,
        LoginFailed,
        SSLShutdownFailed,
        RedirectLimitInvalid,
        InvalidRedirect,
        CannotModifyRequest,
        HeaderNameContainsInvalidCharacters,
        HeaderValueContainsInvalidCharacters,
        CannotOverrideSystemHeaders,
        AlreadySent,
        InvalidMethod,
        NotImplemented,
        NoInternetConnection,
        DataProcessingError,
        InsecureConnectionNotAllowed,
    }
}
