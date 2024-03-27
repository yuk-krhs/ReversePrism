using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TweenCancelBehaviour
    {
        Kill,
        KillWithCompleteCallback,
        Complete,
        CompleteWithSequenceCallback,
        CancelAwait,
        KillAndCancelAwait,
        KillWithCompleteCallbackAndCancelAwait,
        CompleteAndCancelAwait,
        CompleteWithSequenceCallbackAndCancelAwait,
    }
}
