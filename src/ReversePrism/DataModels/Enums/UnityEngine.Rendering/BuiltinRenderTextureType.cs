using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum BuiltinRenderTextureType
    {
        PropertyName,
        BufferPtr,
        RenderTexture,
        BindableTexture,
        None,
        CurrentActive,
        CameraTarget,
        Depth,
        DepthNormals,
        ResolvedDepth,
        PrepassNormalsSpec,
        PrepassLight,
        PrepassLightSpec,
        GBuffer0,
        GBuffer1,
        GBuffer2,
        GBuffer3,
        Reflections,
        MotionVectors,
        GBuffer4,
        GBuffer5,
        GBuffer6,
        GBuffer7,
    }
}
