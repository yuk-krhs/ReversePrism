using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_prismRenderPipeline                    ModelClassType RenderPipelineAsset RenderPipelineAsset RenderPipelineAsset Pointer
    // 020 M_DefaultShader                          ModelClassType Shader Shader Shader Pointer
    // 028 M_Renderers                              ModelClassListType ScriptableRenderer[] ScriptableRenderer[] List<ScriptableRenderer> Pointer
    // 030 K_AssetVersion                           ModelPrimitiveType int int int Int32
    // 034 K_AssetPreviousVersion                   ModelPrimitiveType int int int Int32
    // 038 M_RendererType                           ModelEnumType RendererType RendererType RendererType Int32
    // 040 M_RendererData                           ModelClassType ScriptableRendererData ScriptableRendererData ScriptableRendererData Pointer
    // 048 M_RendererDataList                       ModelClassListType ScriptableRendererData[] ScriptableRendererData[] List<ScriptableRendererData> Pointer
    // 050 M_DefaultRendererIndex                   ModelPrimitiveType int int int Int32
    // 054 M_RequireDepthTexture                    ModelPrimitiveType bool bool bool Bool
    // 055 M_RequireOpaqueTexture                   ModelPrimitiveType bool bool bool Bool
    // 058 M_OpaqueDownsampling                     ModelEnumType Downsampling Downsampling Downsampling Int32
    // 05C M_SupportsTerrainHoles                   ModelPrimitiveType bool bool bool Bool
    // 05D M_SupportsHDR                            ModelPrimitiveType bool bool bool Bool
    // 060 M_HDRColorBufferPrecision                ModelEnumType HDRColorBufferPrecision HDRColorBufferPrecision HDRColorBufferPrecision Int32
    // 064 M_MSAA                                   ModelEnumType MsaaQuality MsaaQuality MsaaQuality Int32
    // 068 M_RenderScale                            ModelPrimitiveType float float float Single
    // 06C M_UpscalingFilter                        ModelEnumType UpscalingFilterSelection UpscalingFilterSelection UpscalingFilterSelection Int32
    // 070 M_FsrOverrideSharpness                   ModelPrimitiveType bool bool bool Bool
    // 074 M_FsrSharpness                           ModelPrimitiveType float float float Single
    // 078 M_EnableLODCrossFade                     ModelPrimitiveType bool bool bool Bool
    // 07C M_LODCrossFadeDitheringType              ModelEnumType LODCrossFadeDitheringType LODCrossFadeDitheringType LODCrossFadeDitheringType Int32
    // 080 M_ShEvalMode                             ModelEnumType ShEvalMode ShEvalMode ShEvalMode Int32
    // 084 M_MainLightRenderingMode                 ModelEnumType LightRenderingMode LightRenderingMode LightRenderingMode Int32
    // 088 M_MainLightShadowsSupported              ModelPrimitiveType bool bool bool Bool
    // 08C M_MainLightShadowmapResolution           ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32
    // 090 M_AdditionalLightsRenderingMode          ModelEnumType LightRenderingMode LightRenderingMode LightRenderingMode Int32
    // 094 M_AdditionalLightsPerObjectLimit         ModelPrimitiveType int int int Int32
    // 098 M_AdditionalLightShadowsSupported        ModelPrimitiveType bool bool bool Bool
    // 09C M_AdditionalLightsShadowmapResolution    ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32
    // 0A0 M_AdditionalLightsShadowResolutionTierLow ModelPrimitiveType int int int Int32
    // 0A4 M_AdditionalLightsShadowResolutionTierMedium ModelPrimitiveType int int int Int32
    // 0A8 M_AdditionalLightsShadowResolutionTierHigh ModelPrimitiveType int int int Int32
    // 0AC M_ReflectionProbeBlending                ModelPrimitiveType bool bool bool Bool
    // 0AD M_ReflectionProbeBoxProjection           ModelPrimitiveType bool bool bool Bool
    // 0B0 M_ShadowDistance                         ModelPrimitiveType float float float Single
    // 0B4 M_ShadowCascadeCount                     ModelPrimitiveType int int int Int32
    // 0B8 M_Cascade2Split                          ModelPrimitiveType float float float Single
    // 0BC M_Cascade3Split                          ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0C4 M_Cascade4Split                          ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0D0 M_CascadeBorder                          ModelPrimitiveType float float float Single
    // 0D4 M_ShadowDepthBias                        ModelPrimitiveType float float float Single
    // 0D8 M_ShadowNormalBias                       ModelPrimitiveType float float float Single
    // 0DC M_SoftShadowsSupported                   ModelPrimitiveType bool bool bool Bool
    // 0DD M_ConservativeEnclosingSphere            ModelPrimitiveType bool bool bool Bool
    // 0E0 M_NumIterationsEnclosingSphere           ModelPrimitiveType int int int Int32
    // 0E4 M_SoftShadowQuality                      ModelEnumType SoftShadowQuality SoftShadowQuality SoftShadowQuality Int32
    // 0E8 M_AdditionalLightsCookieResolution       ModelEnumType LightCookieResolution LightCookieResolution LightCookieResolution Int32
    // 0EC M_AdditionalLightsCookieFormat           ModelEnumType LightCookieFormat LightCookieFormat LightCookieFormat Int32
    // 0F0 M_UseSRPBatcher                          ModelPrimitiveType bool bool bool Bool
    // 0F1 M_SupportsDynamicBatching                ModelPrimitiveType bool bool bool Bool
    // 0F2 M_MixedLightingSupported                 ModelPrimitiveType bool bool bool Bool
    // 0F3 M_SupportsLightCookies                   ModelPrimitiveType bool bool bool Bool
    // 0F4 M_SupportsLightLayers                    ModelPrimitiveType bool bool bool Bool
    // 0F8 M_DebugLevel                             ModelEnumType PipelineDebugLevel PipelineDebugLevel PipelineDebugLevel Int32
    // 0FC M_StoreActionsOptimization               ModelEnumType StoreActionsOptimization StoreActionsOptimization StoreActionsOptimization Int32
    // 100 M_EnableRenderGraph                      ModelPrimitiveType bool bool bool Bool
    // 101 M_UseAdaptivePerformance                 ModelPrimitiveType bool bool bool Bool
    // 104 M_ColorGradingMode                       ModelEnumType ColorGradingMode ColorGradingMode ColorGradingMode Int32
    // 108 M_ColorGradingLutSize                    ModelPrimitiveType int int int Int32
    // 10C M_UseFastSRGBLinearConversion            ModelPrimitiveType bool bool bool Bool
    // 10D M_SupportDataDrivenLensFlare             ModelPrimitiveType bool bool bool Bool
    // 110 M_ShadowType                             ModelEnumType ShadowQuality ShadowQuality ShadowQuality Int32
    // 114 M_LocalShadowsSupported                  ModelPrimitiveType bool bool bool Bool
    // 118 M_LocalShadowsAtlasResolution            ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32
    // 11C M_MaxPixelLights                         ModelPrimitiveType int int int Int32
    // 120 M_ShadowAtlasResolution                  ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32
    // 124 M_VolumeFrameworkUpdateMode              ModelEnumType VolumeFrameworkUpdateMode VolumeFrameworkUpdateMode VolumeFrameworkUpdateMode Int32
    // 128 M_Textures                               ModelClassType TextureResources TextureResources TextureResources Pointer
    // 000 k_MinLutSize                             int IL2CPP_TYPE_I4
    // 000 k_MaxLutSize                             int IL2CPP_TYPE_I4
    // 000 k_ShadowCascadeMinCount                  int IL2CPP_TYPE_I4
    // 000 k_ShadowCascadeMaxCount                  int IL2CPP_TYPE_I4
    // 000 AdditionalLightsDefaultShadowResolutionTierLow int IL2CPP_TYPE_I4
    // 004 AdditionalLightsDefaultShadowResolutionTierMedium int IL2CPP_TYPE_I4
    // 008 AdditionalLightsDefaultShadowResolutionTierHigh int IL2CPP_TYPE_I4
    // 010 s_LightCookieFormatList                  GraphicsFormat[][] IL2CPP_TYPE_SZARRAY
    // 130 M_ShaderVariantLogLevel                  ModelPrimitiveType int int int Int32
    // 134 M_ShadowCascades                         ModelEnumType ShadowCascadesOption ShadowCascadesOption ShadowCascadesOption Int32
    public partial class UniversalRenderPipelineAsset : DataModel
    {
        public RenderPipelineAsset?                     M_prismRenderPipeline                   { get; set; }
        public Shader?                                  M_DefaultShader                         { get; set; }
        public List<ScriptableRenderer>?                M_Renderers                             { get; set; }
        public int                                      K_AssetVersion                          { get; set; }
        public int                                      K_AssetPreviousVersion                  { get; set; }
        public RendererType                             M_RendererType                          { get; set; }
        public ScriptableRendererData?                  M_RendererData                          { get; set; }
        public List<ScriptableRendererData>?            M_RendererDataList                      { get; set; }
        public int                                      M_DefaultRendererIndex                  { get; set; }
        public bool                                     M_RequireDepthTexture                   { get; set; }
        public bool                                     M_RequireOpaqueTexture                  { get; set; }
        public Downsampling                             M_OpaqueDownsampling                    { get; set; }
        public bool                                     M_SupportsTerrainHoles                  { get; set; }
        public bool                                     M_SupportsHDR                           { get; set; }
        public HDRColorBufferPrecision                  M_HDRColorBufferPrecision               { get; set; }
        public MsaaQuality                              M_MSAA                                  { get; set; }
        public float                                    M_RenderScale                           { get; set; }
        public UpscalingFilterSelection                 M_UpscalingFilter                       { get; set; }
        public bool                                     M_FsrOverrideSharpness                  { get; set; }
        public float                                    M_FsrSharpness                          { get; set; }
        public bool                                     M_EnableLODCrossFade                    { get; set; }
        public LODCrossFadeDitheringType                M_LODCrossFadeDitheringType             { get; set; }
        public ShEvalMode                               M_ShEvalMode                            { get; set; }
        public LightRenderingMode                       M_MainLightRenderingMode                { get; set; }
        public bool                                     M_MainLightShadowsSupported             { get; set; }
        public ShadowResolution                         M_MainLightShadowmapResolution          { get; set; }
        public LightRenderingMode                       M_AdditionalLightsRenderingMode         { get; set; }
        public int                                      M_AdditionalLightsPerObjectLimit        { get; set; }
        public bool                                     M_AdditionalLightShadowsSupported       { get; set; }
        public ShadowResolution                         M_AdditionalLightsShadowmapResolution   { get; set; }
        public int                                      M_AdditionalLightsShadowResolutionTierLow { get; set; }
        public int                                      M_AdditionalLightsShadowResolutionTierMedium { get; set; }
        public int                                      M_AdditionalLightsShadowResolutionTierHigh { get; set; }
        public bool                                     M_ReflectionProbeBlending               { get; set; }
        public bool                                     M_ReflectionProbeBoxProjection          { get; set; }
        public float                                    M_ShadowDistance                        { get; set; }
        public int                                      M_ShadowCascadeCount                    { get; set; }
        public float                                    M_Cascade2Split                         { get; set; }
        public Vector2                                  M_Cascade3Split                         { get; set; }
        public Vector3                                  M_Cascade4Split                         { get; set; }
        public float                                    M_CascadeBorder                         { get; set; }
        public float                                    M_ShadowDepthBias                       { get; set; }
        public float                                    M_ShadowNormalBias                      { get; set; }
        public bool                                     M_SoftShadowsSupported                  { get; set; }
        public bool                                     M_ConservativeEnclosingSphere           { get; set; }
        public int                                      M_NumIterationsEnclosingSphere          { get; set; }
        public SoftShadowQuality                        M_SoftShadowQuality                     { get; set; }
        public LightCookieResolution                    M_AdditionalLightsCookieResolution      { get; set; }
        public LightCookieFormat                        M_AdditionalLightsCookieFormat          { get; set; }
        public bool                                     M_UseSRPBatcher                         { get; set; }
        public bool                                     M_SupportsDynamicBatching               { get; set; }
        public bool                                     M_MixedLightingSupported                { get; set; }
        public bool                                     M_SupportsLightCookies                  { get; set; }
        public bool                                     M_SupportsLightLayers                   { get; set; }
        public PipelineDebugLevel                       M_DebugLevel                            { get; set; }
        public StoreActionsOptimization                 M_StoreActionsOptimization              { get; set; }
        public bool                                     M_EnableRenderGraph                     { get; set; }
        public bool                                     M_UseAdaptivePerformance                { get; set; }
        public ColorGradingMode                         M_ColorGradingMode                      { get; set; }
        public int                                      M_ColorGradingLutSize                   { get; set; }
        public bool                                     M_UseFastSRGBLinearConversion           { get; set; }
        public bool                                     M_SupportDataDrivenLensFlare            { get; set; }
        public ShadowQuality                            M_ShadowType                            { get; set; }
        public bool                                     M_LocalShadowsSupported                 { get; set; }
        public ShadowResolution                         M_LocalShadowsAtlasResolution           { get; set; }
        public int                                      M_MaxPixelLights                        { get; set; }
        public ShadowResolution                         M_ShadowAtlasResolution                 { get; set; }
        public VolumeFrameworkUpdateMode                M_VolumeFrameworkUpdateMode             { get; set; }
        public TextureResources?                        M_Textures                              { get; set; }
        public int                                      M_ShaderVariantLogLevel                 { get; set; }
        public ShadowCascadesOption                     M_ShadowCascades                        { get; set; }

        public static UniversalRenderPipelineAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniversalRenderPipelineAsset() { Pointer= p0 };

            value.M_prismRenderPipeline                     = GetObject<RenderPipelineAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderPipelineAsset.FromPointer); // 0x18 M_prismRenderPipeline       ( ModelClassType RenderPipelineAsset RenderPipelineAsset RenderPipelineAsset Pointer )
            value.M_DefaultShader                           = GetObject<Shader>(new IntPtr(p + 0x020), ReversePrism.DataModels.Shader.FromPointer); // 0x20 M_DefaultShader             ( ModelClassType Shader Shader Shader Pointer )
            value.M_Renderers                               = GetObjectList<ScriptableRenderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScriptableRenderer.FromPointer); // 0x28 M_Renderers                 ( ModelClassListType ScriptableRenderer[] ScriptableRenderer[] List<ScriptableRenderer> Pointer )
            value.K_AssetVersion                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 K_AssetVersion              ( ModelPrimitiveType int int int Int32 )
            value.K_AssetPreviousVersion                    = GetInt32(new IntPtr(p + 0x034)); // 0x34 K_AssetPreviousVersion      ( ModelPrimitiveType int int int Int32 )
            value.M_RendererType                            = (RendererType)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_RendererType              ( ModelEnumType RendererType RendererType RendererType Int32 )
            value.M_RendererData                            = GetObject<ScriptableRendererData>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScriptableRendererData.FromPointer); // 0x40 M_RendererData              ( ModelClassType ScriptableRendererData ScriptableRendererData ScriptableRendererData Pointer )
            value.M_RendererDataList                        = GetObjectList<ScriptableRendererData>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScriptableRendererData.FromPointer); // 0x48 M_RendererDataList          ( ModelClassListType ScriptableRendererData[] ScriptableRendererData[] List<ScriptableRendererData> Pointer )
            value.M_DefaultRendererIndex                    = GetInt32(new IntPtr(p + 0x050)); // 0x50 M_DefaultRendererIndex      ( ModelPrimitiveType int int int Int32 )
            value.M_RequireDepthTexture                     = GetBool(new IntPtr(p + 0x054)); // 0x54 M_RequireDepthTexture       ( ModelPrimitiveType bool bool bool Bool )
            value.M_RequireOpaqueTexture                    = GetBool(new IntPtr(p + 0x055)); // 0x55 M_RequireOpaqueTexture      ( ModelPrimitiveType bool bool bool Bool )
            value.M_OpaqueDownsampling                      = (Downsampling)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_OpaqueDownsampling        ( ModelEnumType Downsampling Downsampling Downsampling Int32 )
            value.M_SupportsTerrainHoles                    = GetBool(new IntPtr(p + 0x05C)); // 0x5C M_SupportsTerrainHoles      ( ModelPrimitiveType bool bool bool Bool )
            value.M_SupportsHDR                             = GetBool(new IntPtr(p + 0x05D)); // 0x5D M_SupportsHDR               ( ModelPrimitiveType bool bool bool Bool )
            value.M_HDRColorBufferPrecision                 = (HDRColorBufferPrecision)GetInt32(new IntPtr(p + 0x060)); // 0x60 M_HDRColorBufferPrecision   ( ModelEnumType HDRColorBufferPrecision HDRColorBufferPrecision HDRColorBufferPrecision Int32 )
            value.M_MSAA                                    = (MsaaQuality)GetInt32(new IntPtr(p + 0x064)); // 0x64 M_MSAA                      ( ModelEnumType MsaaQuality MsaaQuality MsaaQuality Int32 )
            value.M_RenderScale                             = GetSingle(new IntPtr(p + 0x068)); // 0x68 M_RenderScale               ( ModelPrimitiveType float float float Single )
            value.M_UpscalingFilter                         = (UpscalingFilterSelection)GetInt32(new IntPtr(p + 0x06C)); // 0x6C M_UpscalingFilter           ( ModelEnumType UpscalingFilterSelection UpscalingFilterSelection UpscalingFilterSelection Int32 )
            value.M_FsrOverrideSharpness                    = GetBool(new IntPtr(p + 0x070)); // 0x70 M_FsrOverrideSharpness      ( ModelPrimitiveType bool bool bool Bool )
            value.M_FsrSharpness                            = GetSingle(new IntPtr(p + 0x074)); // 0x74 M_FsrSharpness              ( ModelPrimitiveType float float float Single )
            value.M_EnableLODCrossFade                      = GetBool(new IntPtr(p + 0x078)); // 0x78 M_EnableLODCrossFade        ( ModelPrimitiveType bool bool bool Bool )
            value.M_LODCrossFadeDitheringType               = (LODCrossFadeDitheringType)GetInt32(new IntPtr(p + 0x07C)); // 0x7C M_LODCrossFadeDitheringType ( ModelEnumType LODCrossFadeDitheringType LODCrossFadeDitheringType LODCrossFadeDitheringType Int32 )
            value.M_ShEvalMode                              = (ShEvalMode)GetInt32(new IntPtr(p + 0x080)); // 0x80 M_ShEvalMode                ( ModelEnumType ShEvalMode ShEvalMode ShEvalMode Int32 )
            value.M_MainLightRenderingMode                  = (LightRenderingMode)GetInt32(new IntPtr(p + 0x084)); // 0x84 M_MainLightRenderingMode    ( ModelEnumType LightRenderingMode LightRenderingMode LightRenderingMode Int32 )
            value.M_MainLightShadowsSupported               = GetBool(new IntPtr(p + 0x088)); // 0x88 M_MainLightShadowsSupported ( ModelPrimitiveType bool bool bool Bool )
            value.M_MainLightShadowmapResolution            = (ShadowResolution)GetInt32(new IntPtr(p + 0x08C)); // 0x8C M_MainLightShadowmapResolution ( ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32 )
            value.M_AdditionalLightsRenderingMode           = (LightRenderingMode)GetInt32(new IntPtr(p + 0x090)); // 0x90 M_AdditionalLightsRenderingMode ( ModelEnumType LightRenderingMode LightRenderingMode LightRenderingMode Int32 )
            value.M_AdditionalLightsPerObjectLimit          = GetInt32(new IntPtr(p + 0x094)); // 0x94 M_AdditionalLightsPerObjectLimit ( ModelPrimitiveType int int int Int32 )
            value.M_AdditionalLightShadowsSupported         = GetBool(new IntPtr(p + 0x098)); // 0x98 M_AdditionalLightShadowsSupported ( ModelPrimitiveType bool bool bool Bool )
            value.M_AdditionalLightsShadowmapResolution     = (ShadowResolution)GetInt32(new IntPtr(p + 0x09C)); // 0x9C M_AdditionalLightsShadowmapResolution ( ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32 )
            value.M_AdditionalLightsShadowResolutionTierLow = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 M_AdditionalLightsShadowResolutionTierLow ( ModelPrimitiveType int int int Int32 )
            value.M_AdditionalLightsShadowResolutionTierMedium = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 M_AdditionalLightsShadowResolutionTierMedium ( ModelPrimitiveType int int int Int32 )
            value.M_AdditionalLightsShadowResolutionTierHigh = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 M_AdditionalLightsShadowResolutionTierHigh ( ModelPrimitiveType int int int Int32 )
            value.M_ReflectionProbeBlending                 = GetBool(new IntPtr(p + 0x0AC)); // 0xAC M_ReflectionProbeBlending   ( ModelPrimitiveType bool bool bool Bool )
            value.M_ReflectionProbeBoxProjection            = GetBool(new IntPtr(p + 0x0AD)); // 0xAD M_ReflectionProbeBoxProjection ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShadowDistance                          = GetSingle(new IntPtr(p + 0x0B0)); // 0xB0 M_ShadowDistance            ( ModelPrimitiveType float float float Single )
            value.M_ShadowCascadeCount                      = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 M_ShadowCascadeCount        ( ModelPrimitiveType int int int Int32 )
            value.M_Cascade2Split                           = GetSingle(new IntPtr(p + 0x0B8)); // 0xB8 M_Cascade2Split             ( ModelPrimitiveType float float float Single )
            value.M_Cascade3Split                           = (Vector2)GetInt32(new IntPtr(p + 0x0BC)); // 0xBC M_Cascade3Split             ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Cascade4Split                           = (Vector3)GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 M_Cascade4Split             ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_CascadeBorder                           = GetSingle(new IntPtr(p + 0x0D0)); // 0xD0 M_CascadeBorder             ( ModelPrimitiveType float float float Single )
            value.M_ShadowDepthBias                         = GetSingle(new IntPtr(p + 0x0D4)); // 0xD4 M_ShadowDepthBias           ( ModelPrimitiveType float float float Single )
            value.M_ShadowNormalBias                        = GetSingle(new IntPtr(p + 0x0D8)); // 0xD8 M_ShadowNormalBias          ( ModelPrimitiveType float float float Single )
            value.M_SoftShadowsSupported                    = GetBool(new IntPtr(p + 0x0DC)); // 0xDC M_SoftShadowsSupported      ( ModelPrimitiveType bool bool bool Bool )
            value.M_ConservativeEnclosingSphere             = GetBool(new IntPtr(p + 0x0DD)); // 0xDD M_ConservativeEnclosingSphere ( ModelPrimitiveType bool bool bool Bool )
            value.M_NumIterationsEnclosingSphere            = GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 M_NumIterationsEnclosingSphere ( ModelPrimitiveType int int int Int32 )
            value.M_SoftShadowQuality                       = (SoftShadowQuality)GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 M_SoftShadowQuality         ( ModelEnumType SoftShadowQuality SoftShadowQuality SoftShadowQuality Int32 )
            value.M_AdditionalLightsCookieResolution        = (LightCookieResolution)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 M_AdditionalLightsCookieResolution ( ModelEnumType LightCookieResolution LightCookieResolution LightCookieResolution Int32 )
            value.M_AdditionalLightsCookieFormat            = (LightCookieFormat)GetInt32(new IntPtr(p + 0x0EC)); // 0xEC M_AdditionalLightsCookieFormat ( ModelEnumType LightCookieFormat LightCookieFormat LightCookieFormat Int32 )
            value.M_UseSRPBatcher                           = GetBool(new IntPtr(p + 0x0F0)); // 0xF0 M_UseSRPBatcher             ( ModelPrimitiveType bool bool bool Bool )
            value.M_SupportsDynamicBatching                 = GetBool(new IntPtr(p + 0x0F1)); // 0xF1 M_SupportsDynamicBatching   ( ModelPrimitiveType bool bool bool Bool )
            value.M_MixedLightingSupported                  = GetBool(new IntPtr(p + 0x0F2)); // 0xF2 M_MixedLightingSupported    ( ModelPrimitiveType bool bool bool Bool )
            value.M_SupportsLightCookies                    = GetBool(new IntPtr(p + 0x0F3)); // 0xF3 M_SupportsLightCookies      ( ModelPrimitiveType bool bool bool Bool )
            value.M_SupportsLightLayers                     = GetBool(new IntPtr(p + 0x0F4)); // 0xF4 M_SupportsLightLayers       ( ModelPrimitiveType bool bool bool Bool )
            value.M_DebugLevel                              = (PipelineDebugLevel)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 M_DebugLevel                ( ModelEnumType PipelineDebugLevel PipelineDebugLevel PipelineDebugLevel Int32 )
            value.M_StoreActionsOptimization                = (StoreActionsOptimization)GetInt32(new IntPtr(p + 0x0FC)); // 0xFC M_StoreActionsOptimization  ( ModelEnumType StoreActionsOptimization StoreActionsOptimization StoreActionsOptimization Int32 )
            value.M_EnableRenderGraph                       = GetBool(new IntPtr(p + 0x100)); // 0x100 M_EnableRenderGraph         ( ModelPrimitiveType bool bool bool Bool )
            value.M_UseAdaptivePerformance                  = GetBool(new IntPtr(p + 0x101)); // 0x101 M_UseAdaptivePerformance    ( ModelPrimitiveType bool bool bool Bool )
            value.M_ColorGradingMode                        = (ColorGradingMode)GetInt32(new IntPtr(p + 0x104)); // 0x104 M_ColorGradingMode          ( ModelEnumType ColorGradingMode ColorGradingMode ColorGradingMode Int32 )
            value.M_ColorGradingLutSize                     = GetInt32(new IntPtr(p + 0x108)); // 0x108 M_ColorGradingLutSize       ( ModelPrimitiveType int int int Int32 )
            value.M_UseFastSRGBLinearConversion             = GetBool(new IntPtr(p + 0x10C)); // 0x10C M_UseFastSRGBLinearConversion ( ModelPrimitiveType bool bool bool Bool )
            value.M_SupportDataDrivenLensFlare              = GetBool(new IntPtr(p + 0x10D)); // 0x10D M_SupportDataDrivenLensFlare ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShadowType                              = (ShadowQuality)GetInt32(new IntPtr(p + 0x110)); // 0x110 M_ShadowType                ( ModelEnumType ShadowQuality ShadowQuality ShadowQuality Int32 )
            value.M_LocalShadowsSupported                   = GetBool(new IntPtr(p + 0x114)); // 0x114 M_LocalShadowsSupported     ( ModelPrimitiveType bool bool bool Bool )
            value.M_LocalShadowsAtlasResolution             = (ShadowResolution)GetInt32(new IntPtr(p + 0x118)); // 0x118 M_LocalShadowsAtlasResolution ( ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32 )
            value.M_MaxPixelLights                          = GetInt32(new IntPtr(p + 0x11C)); // 0x11C M_MaxPixelLights            ( ModelPrimitiveType int int int Int32 )
            value.M_ShadowAtlasResolution                   = (ShadowResolution)GetInt32(new IntPtr(p + 0x120)); // 0x120 M_ShadowAtlasResolution     ( ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32 )
            value.M_VolumeFrameworkUpdateMode               = (VolumeFrameworkUpdateMode)GetInt32(new IntPtr(p + 0x124)); // 0x124 M_VolumeFrameworkUpdateMode ( ModelEnumType VolumeFrameworkUpdateMode VolumeFrameworkUpdateMode VolumeFrameworkUpdateMode Int32 )
            value.M_Textures                                = GetObject<TextureResources>(new IntPtr(p + 0x128), ReversePrism.DataModels.TextureResources.FromPointer); // 0x128 M_Textures                  ( ModelClassType TextureResources TextureResources TextureResources Pointer )
            value.M_ShaderVariantLogLevel                   = GetInt32(new IntPtr(p + 0x130)); // 0x130 M_ShaderVariantLogLevel     ( ModelPrimitiveType int int int Int32 )
            value.M_ShadowCascades                          = (ShadowCascadesOption)GetInt32(new IntPtr(p + 0x134)); // 0x134 M_ShadowCascades            ( ModelEnumType ShadowCascadesOption ShadowCascadesOption ShadowCascadesOption Int32 )

            return value;
        }
    }
}
