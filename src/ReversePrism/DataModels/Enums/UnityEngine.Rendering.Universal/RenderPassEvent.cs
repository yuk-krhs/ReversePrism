using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum RenderPassEvent
    {
        BeforeRendering,
        BeforeRenderingShadows,
        AfterRenderingShadows,
        BeforeRenderingPrePasses,
        AfterRenderingPrePasses,
        BeforeRenderingGbuffer,
        AfterRenderingGbuffer,
        BeforeRenderingDeferredLights,
        AfterRenderingDeferredLights,
        BeforeRenderingOpaques,
        AfterRenderingOpaques,
        BeforeRenderingSkybox,
        AfterRenderingSkybox,
        BeforeRenderingTransparents,
        AfterRenderingTransparents,
        BeforeRenderingPostProcessing,
        AfterRenderingPostProcessing,
        AfterRendering,
    }
}
