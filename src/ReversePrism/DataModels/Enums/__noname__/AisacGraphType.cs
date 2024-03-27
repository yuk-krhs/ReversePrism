using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum AisacGraphType
    {
        none,
        volume,
        pitch,
        bandpassHigh,
        bandpassLow,
        biquadFreq,
        biquadQ,
        busSend0,
        busSend1,
        busSend2,
        busSend3,
        busSend4,
        busSend5,
        busSend6,
        busSend7,
        pan3dAngel,
        pan3dVolume,
        pan3dInteriorDistance,
        pan3dCenter,
        pan3dLfe,
        aisac0,
        aisac1,
        aisac2,
        aisac3,
        aisac4,
        aisac5,
        aisac6,
        aisac7,
        aisac8,
        aisac9,
        aisac10,
        aisac11,
        aisac12,
        aisac13,
        aisac14,
        aisac15,
        priority,
        preDelayTime,
        biquadGain,
        pan3dMixdownCenter,
        pan3dMixdownLfe,
        egAttack,
        egRelease,
        playbackRatio,
        drySendL,
        drySendR,
        drySendCenter,
        drySendLfe,
        drySendSl,
        drySendSr,
        drySendEx1,
        drySendEx2,
        panSpread,
    }
}
