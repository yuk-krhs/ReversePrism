using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Format
    {
        ADX,
        HCA,
        HCA_MX,
        WAVE,
        RAW_PCM,
        AUDIO_BUFFER,
    }
}
