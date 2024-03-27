using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum SoundRendererType
    {
        Default,
        Native,
        Asr,
        Extended,
        Spatial,
        Hw1,
        Hw2,
        Hw3,
        Hw4,
        Haptic,
        Pseudo,
        SpatialChannels,
        Ambisonics,
        Passtrough,
        Object,
    }
}
