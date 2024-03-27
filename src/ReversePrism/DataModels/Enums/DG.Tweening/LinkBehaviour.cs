using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum LinkBehaviour
    {
        PauseOnDisable,
        PauseOnDisablePlayOnEnable,
        PauseOnDisableRestartOnEnable,
        PlayOnEnable,
        RestartOnEnable,
        KillOnDisable,
        KillOnDestroy,
        CompleteOnDisable,
        CompleteAndKillOnDisable,
        RewindOnDisable,
        RewindAndKillOnDisable,
    }
}
