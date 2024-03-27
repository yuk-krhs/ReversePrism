using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum PlayerLoopTiming
    {
        Initialization,
        LastInitialization,
        EarlyUpdate,
        LastEarlyUpdate,
        FixedUpdate,
        LastFixedUpdate,
        PreUpdate,
        LastPreUpdate,
        Update,
        LastUpdate,
        PreLateUpdate,
        LastPreLateUpdate,
        PostLateUpdate,
        LastPostLateUpdate,
        TimeUpdate,
        LastTimeUpdate,
    }
}
