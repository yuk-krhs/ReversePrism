using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum LifeCycleStatus
    {
        None,
        PropagationStopped,
        ImmediatePropagationStopped,
        DefaultPrevented,
        Dispatching,
        Pooled,
        IMGUIEventIsValid,
        StopDispatch,
        PropagateToIMGUI,
        Dispatched,
        Processed,
        ProcessedByFocusController,
    }
}
