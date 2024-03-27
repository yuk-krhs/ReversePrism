using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum SocketError
    {
        Success,
        SocketError,
        Interrupted,
        AccessDenied,
        Fault,
        InvalidArgument,
        TooManyOpenSockets,
        WouldBlock,
        InProgress,
        AlreadyInProgress,
        NotSocket,
        DestinationAddressRequired,
        MessageSize,
        ProtocolType,
        ProtocolOption,
        ProtocolNotSupported,
        SocketNotSupported,
        OperationNotSupported,
        ProtocolFamilyNotSupported,
        AddressFamilyNotSupported,
        AddressAlreadyInUse,
        AddressNotAvailable,
        NetworkDown,
        NetworkUnreachable,
        NetworkReset,
        ConnectionAborted,
        ConnectionReset,
        NoBufferSpaceAvailable,
        IsConnected,
        NotConnected,
        Shutdown,
        TimedOut,
        ConnectionRefused,
        HostDown,
        HostUnreachable,
        ProcessLimit,
        SystemNotReady,
        VersionNotSupported,
        NotInitialized,
        Disconnecting,
        TypeNotFound,
        HostNotFound,
        TryAgain,
        NoRecovery,
        NoData,
        IOPending,
        OperationAborted,
    }
}
