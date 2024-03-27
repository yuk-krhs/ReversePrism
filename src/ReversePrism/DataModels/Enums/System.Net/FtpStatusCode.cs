using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FtpStatusCode
    {
        Undefined,
        RestartMarker,
        ServiceTemporarilyNotAvailable,
        DataAlreadyOpen,
        OpeningData,
        CommandOK,
        CommandExtraneous,
        DirectoryStatus,
        FileStatus,
        SystemType,
        SendUserCommand,
        ClosingControl,
        ClosingData,
        EnteringPassive,
        LoggedInProceed,
        ServerWantsSecureSession,
        FileActionOK,
        PathnameCreated,
        SendPasswordCommand,
        NeedLoginAccount,
        FileCommandPending,
        ServiceNotAvailable,
        CantOpenData,
        ConnectionClosed,
        ActionNotTakenFileUnavailableOrBusy,
        ActionAbortedLocalProcessingError,
        ActionNotTakenInsufficientSpace,
        CommandSyntaxError,
        ArgumentSyntaxError,
        CommandNotImplemented,
        BadCommandSequence,
        NotLoggedIn,
        AccountNeeded,
        ActionNotTakenFileUnavailable,
        ActionAbortedUnknownPageType,
        FileActionAborted,
        ActionNotTakenFilenameNotAllowed,
    }
}
