using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum CallError
    {
        OK,
        Error,
        NotOnServer,
        NotOnClient,
        AlreadyAccepted,
        AlreadyInvoked,
        NotInvoked,
        AlreadyFinished,
        TooManyOperations,
        InvalidFlags,
        InvalidMetadata,
        InvalidMessage,
        NotServerCompletionQueue,
        BatchTooBig,
        PayloadTypeMismatch,
        CompletionQueueShutdown,
    }
}
