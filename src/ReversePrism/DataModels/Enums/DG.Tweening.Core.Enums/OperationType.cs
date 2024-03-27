using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum OperationType
    {
        Complete,
        Despawn,
        Flip,
        Goto,
        Pause,
        Play,
        PlayForward,
        PlayBackwards,
        Rewind,
        SmoothRewind,
        Restart,
        TogglePause,
        IsTweening,
    }
}
