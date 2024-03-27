using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Parameter
    {
        Volume,
        Pitch,
        Pan3dAngle,
        Pan3dDistance,
        Pan3dVolume,
        BusSendLevel0,
        BusSendLevel1,
        BusSendLevel2,
        BusSendLevel3,
        BusSendLevel4,
        BusSendLevel5,
        BusSendLevel6,
        BusSendLevel7,
        BandPassFilterCofLow,
        BandPassFilterCofHigh,
        BiquadFilterType,
        BiquadFilterFreq,
        BiquadFIlterQ,
        BiquadFilterGain,
        EnvelopeAttackTime,
        EnvelopeHoldTime,
        EnvelopeDecayTime,
        EnvelopeReleaseTime,
        EnvelopeSustainLevel,
        StartTime,
        Priority,
    }
}
