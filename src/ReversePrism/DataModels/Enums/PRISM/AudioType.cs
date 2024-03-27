using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum AudioType
    {
        Bgm,
        FadeBgm,
        Se,
        FadeSe,
        Voice,
        FadeVoice,
        Environment,
        FadeEnvironment,
        Function,
    }
}
