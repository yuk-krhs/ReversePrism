using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum VoiceType
    {
        None,
        Greeting,
        DressCostumeChange,
        Default,
        Abandon,
        ShortMotion,
        CasualCostumeChange,
    }
}
