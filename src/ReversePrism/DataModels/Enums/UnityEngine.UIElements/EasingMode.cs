using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum EasingMode
    {
        Ease,
        EaseIn,
        EaseOut,
        EaseInOut,
        Linear,
        EaseInSine,
        EaseOutSine,
        EaseInOutSine,
        EaseInCubic,
        EaseOutCubic,
        EaseInOutCubic,
        EaseInCirc,
        EaseOutCirc,
        EaseInOutCirc,
        EaseInElastic,
        EaseOutElastic,
        EaseInOutElastic,
        EaseInBack,
        EaseOutBack,
        EaseInOutBack,
        EaseInBounce,
        EaseOutBounce,
        EaseInOutBounce,
    }
}
