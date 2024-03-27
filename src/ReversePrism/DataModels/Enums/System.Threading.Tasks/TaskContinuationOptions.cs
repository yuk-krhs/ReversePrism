using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TaskContinuationOptions
    {
        None,
        PreferFairness,
        LongRunning,
        AttachedToParent,
        DenyChildAttach,
        HideScheduler,
        LazyCancellation,
        RunContinuationsAsynchronously,
        NotOnRanToCompletion,
        NotOnFaulted,
        NotOnCanceled,
        OnlyOnRanToCompletion,
        OnlyOnFaulted,
        OnlyOnCanceled,
        ExecuteSynchronously,
    }
}
