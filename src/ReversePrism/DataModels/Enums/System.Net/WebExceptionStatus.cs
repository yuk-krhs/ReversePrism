using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum WebExceptionStatus
    {
        Success,
        NameResolutionFailure,
        ConnectFailure,
        ReceiveFailure,
        SendFailure,
        PipelineFailure,
        RequestCanceled,
        ProtocolError,
        ConnectionClosed,
        TrustFailure,
        SecureChannelFailure,
        ServerProtocolViolation,
        KeepAliveFailure,
        Pending,
        Timeout,
        ProxyNameResolutionFailure,
        UnknownError,
        MessageLengthLimitExceeded,
        CacheEntryNotFound,
        RequestProhibitedByCachePolicy,
        RequestProhibitedByProxy,
    }
}
