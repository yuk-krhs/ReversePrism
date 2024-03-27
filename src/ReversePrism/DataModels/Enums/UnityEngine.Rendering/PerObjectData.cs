using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum PerObjectData
    {
        None,
        LightProbe,
        ReflectionProbes,
        LightProbeProxyVolume,
        Lightmaps,
        LightData,
        MotionVectors,
        LightIndices,
        ReflectionProbeData,
        OcclusionProbe,
        OcclusionProbeProxyVolume,
        ShadowMask,
    }
}
