using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum SpeakerMapping
    {
        Auto,
        Monaural,
        Stereo,
        Ch5_1,
        Ch7_1,
        Ch5_1_2,
        Ch7_1_4,
        Ambisonics1p,
        Ambisonics2p,
        Ambisonics3p,
    }
}
