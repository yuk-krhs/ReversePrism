using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum InjectPlayerLoopTimings
    {
        All,
        Standard,
        Minimum,
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
