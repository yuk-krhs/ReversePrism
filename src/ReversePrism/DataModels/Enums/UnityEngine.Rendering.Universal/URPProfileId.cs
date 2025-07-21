using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum URPProfileId
    {
        UniversalRenderTotal,
        UpdateVolumeFramework,
        RenderCameraStack,
        AdditionalLightsShadow,
        ColorGradingLUT,
        CopyColor,
        CopyDepth,
        DepthNormalPrepass,
        DepthPrepass,
        UpdateReflectionProbeAtlas,
        DrawOpaqueObjects,
        DrawTransparentObjects,
        DrawScreenSpaceUI,
        LightCookies,
        MainLightShadow,
        ResolveShadows,
        SSAO,
        StopNaNs,
        SMAA,
        GaussianDepthOfField,
        BokehDepthOfField,
        TemporalAA,
        MotionBlur,
        PaniniProjection,
        UberPostProcess,
        Bloom,
        LensFlareDataDrivenComputeOcclusion,
        LensFlareDataDriven,
        MotionVectors,
        DrawFullscreen,
        FinalBlit,
    }
}
