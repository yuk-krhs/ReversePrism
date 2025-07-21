using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum BlendHintValue
    {
        Nothing,
        NoPosition,
        NoOrientation,
        NoTransform,
        SphericalPositionBlend,
        CylindricalPositionBlend,
        RadialAimBlend,
        IgnoreLookAtTarget,
        NoLens,
    }
}
