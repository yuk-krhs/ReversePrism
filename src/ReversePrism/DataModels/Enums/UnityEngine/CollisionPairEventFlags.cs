using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum CollisionPairEventFlags
    {
        SolveContacts,
        ModifyContacts,
        NotifyTouchFound,
        NotifyTouchPersists,
        NotifyTouchLost,
        NotifyTouchCCD,
        NotifyThresholdForceFound,
        NotifyThresholdForcePersists,
        NotifyThresholdForceLost,
        NotifyContactPoint,
        DetectDiscreteContact,
        DetectCCDContact,
        PreSolverVelocity,
        PostSolverVelocity,
        ContactEventPose,
        NextFree,
        ContactDefault,
        TriggerDefault,
    }
}
