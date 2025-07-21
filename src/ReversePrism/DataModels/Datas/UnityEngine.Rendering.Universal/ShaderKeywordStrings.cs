using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MainLightShadows                         string IL2CPP_TYPE_STRING
    // 000 MainLightShadowCascades                  string IL2CPP_TYPE_STRING
    // 000 MainLightShadowScreen                    string IL2CPP_TYPE_STRING
    // 000 CastingPunctualLightShadow               string IL2CPP_TYPE_STRING
    // 000 AdditionalLightsVertex                   string IL2CPP_TYPE_STRING
    // 000 AdditionalLightsPixel                    string IL2CPP_TYPE_STRING
    // 000 ForwardPlus                              string IL2CPP_TYPE_STRING
    // 000 AdditionalLightShadows                   string IL2CPP_TYPE_STRING
    // 000 ReflectionProbeBoxProjection             string IL2CPP_TYPE_STRING
    // 000 ReflectionProbeBlending                  string IL2CPP_TYPE_STRING
    // 000 SoftShadows                              string IL2CPP_TYPE_STRING
    // 000 MixedLightingSubtractive                 string IL2CPP_TYPE_STRING
    // 000 LightmapShadowMixing                     string IL2CPP_TYPE_STRING
    // 000 ShadowsShadowMask                        string IL2CPP_TYPE_STRING
    // 000 LightLayers                              string IL2CPP_TYPE_STRING
    // 000 RenderPassEnabled                        string IL2CPP_TYPE_STRING
    // 000 BillboardFaceCameraPos                   string IL2CPP_TYPE_STRING
    // 000 LightCookies                             string IL2CPP_TYPE_STRING
    // 000 DepthNoMsaa                              string IL2CPP_TYPE_STRING
    // 000 DepthMsaa2                               string IL2CPP_TYPE_STRING
    // 000 DepthMsaa4                               string IL2CPP_TYPE_STRING
    // 000 DepthMsaa8                               string IL2CPP_TYPE_STRING
    // 000 LinearToSRGBConversion                   string IL2CPP_TYPE_STRING
    // 000 UseFastSRGBLinearConversion              string IL2CPP_TYPE_STRING
    // 000 DBufferMRT1                              string IL2CPP_TYPE_STRING
    // 000 DBufferMRT2                              string IL2CPP_TYPE_STRING
    // 000 DBufferMRT3                              string IL2CPP_TYPE_STRING
    // 000 DecalNormalBlendLow                      string IL2CPP_TYPE_STRING
    // 000 DecalNormalBlendMedium                   string IL2CPP_TYPE_STRING
    // 000 DecalNormalBlendHigh                     string IL2CPP_TYPE_STRING
    // 000 DecalLayers                              string IL2CPP_TYPE_STRING
    // 000 WriteRenderingLayers                     string IL2CPP_TYPE_STRING
    // 000 SmaaLow                                  string IL2CPP_TYPE_STRING
    // 000 SmaaMedium                               string IL2CPP_TYPE_STRING
    // 000 SmaaHigh                                 string IL2CPP_TYPE_STRING
    // 000 PaniniGeneric                            string IL2CPP_TYPE_STRING
    // 000 PaniniUnitDistance                       string IL2CPP_TYPE_STRING
    // 000 BloomLQ                                  string IL2CPP_TYPE_STRING
    // 000 BloomHQ                                  string IL2CPP_TYPE_STRING
    // 000 BloomLQDirt                              string IL2CPP_TYPE_STRING
    // 000 BloomHQDirt                              string IL2CPP_TYPE_STRING
    // 000 UseRGBM                                  string IL2CPP_TYPE_STRING
    // 000 Distortion                               string IL2CPP_TYPE_STRING
    // 000 ChromaticAberration                      string IL2CPP_TYPE_STRING
    // 000 HDRGrading                               string IL2CPP_TYPE_STRING
    // 000 TonemapACES                              string IL2CPP_TYPE_STRING
    // 000 TonemapNeutral                           string IL2CPP_TYPE_STRING
    // 000 FilmGrain                                string IL2CPP_TYPE_STRING
    // 000 Fxaa                                     string IL2CPP_TYPE_STRING
    // 000 Dithering                                string IL2CPP_TYPE_STRING
    // 000 ScreenSpaceOcclusion                     string IL2CPP_TYPE_STRING
    // 000 PointSampling                            string IL2CPP_TYPE_STRING
    // 000 Rcas                                     string IL2CPP_TYPE_STRING
    // 000 EasuRcasAndHDRInput                      string IL2CPP_TYPE_STRING
    // 000 Gamma20                                  string IL2CPP_TYPE_STRING
    // 000 Gamma20AndHDRInput                       string IL2CPP_TYPE_STRING
    // 000 HighQualitySampling                      string IL2CPP_TYPE_STRING
    // 000 _SPOT                                    string IL2CPP_TYPE_STRING
    // 000 _DIRECTIONAL                             string IL2CPP_TYPE_STRING
    // 000 _POINT                                   string IL2CPP_TYPE_STRING
    // 000 _DEFERRED_STENCIL                        string IL2CPP_TYPE_STRING
    // 000 _DEFERRED_FIRST_LIGHT                    string IL2CPP_TYPE_STRING
    // 000 _DEFERRED_MAIN_LIGHT                     string IL2CPP_TYPE_STRING
    // 000 _GBUFFER_NORMALS_OCT                     string IL2CPP_TYPE_STRING
    // 000 _DEFERRED_MIXED_LIGHTING                 string IL2CPP_TYPE_STRING
    // 000 LIGHTMAP_ON                              string IL2CPP_TYPE_STRING
    // 000 DYNAMICLIGHTMAP_ON                       string IL2CPP_TYPE_STRING
    // 000 _ALPHATEST_ON                            string IL2CPP_TYPE_STRING
    // 000 DIRLIGHTMAP_COMBINED                     string IL2CPP_TYPE_STRING
    // 000 _DETAIL_MULX2                            string IL2CPP_TYPE_STRING
    // 000 _DETAIL_SCALED                           string IL2CPP_TYPE_STRING
    // 000 _CLEARCOAT                               string IL2CPP_TYPE_STRING
    // 000 _CLEARCOATMAP                            string IL2CPP_TYPE_STRING
    // 000 DEBUG_DISPLAY                            string IL2CPP_TYPE_STRING
    // 000 LOD_FADE_CROSSFADE                       string IL2CPP_TYPE_STRING
    // 000 USE_UNITY_CROSSFADE                      string IL2CPP_TYPE_STRING
    // 000 _EMISSION                                string IL2CPP_TYPE_STRING
    // 000 _RECEIVE_SHADOWS_OFF                     string IL2CPP_TYPE_STRING
    // 000 _SURFACE_TYPE_TRANSPARENT                string IL2CPP_TYPE_STRING
    // 000 _ALPHAPREMULTIPLY_ON                     string IL2CPP_TYPE_STRING
    // 000 _ALPHAMODULATE_ON                        string IL2CPP_TYPE_STRING
    // 000 _NORMALMAP                               string IL2CPP_TYPE_STRING
    // 000 EDITOR_VISUALIZATION                     string IL2CPP_TYPE_STRING
    // 000 DisableTexture2DXArray                   string IL2CPP_TYPE_STRING
    // 000 BlitSingleSlice                          string IL2CPP_TYPE_STRING
    // 000 XROcclusionMeshCombined                  string IL2CPP_TYPE_STRING
    // 000 SCREEN_COORD_OVERRIDE                    string IL2CPP_TYPE_STRING
    // 000 DOWNSAMPLING_SIZE_2                      string IL2CPP_TYPE_STRING
    // 000 DOWNSAMPLING_SIZE_4                      string IL2CPP_TYPE_STRING
    // 000 DOWNSAMPLING_SIZE_8                      string IL2CPP_TYPE_STRING
    // 000 DOWNSAMPLING_SIZE_16                     string IL2CPP_TYPE_STRING
    // 000 FoveatedRenderingNonUniformRaster        string IL2CPP_TYPE_STRING
    // 000 EVALUATE_SH_MIXED                        string IL2CPP_TYPE_STRING
    // 000 EVALUATE_SH_VERTEX                       string IL2CPP_TYPE_STRING
    // 000 UseDrawProcedural                        string IL2CPP_TYPE_STRING
    public partial class ShaderKeywordStrings : DataModel
    {

        public static ShaderKeywordStrings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderKeywordStrings() { Pointer= p0 };


            return value;
        }
    }
}
