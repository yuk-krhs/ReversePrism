using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_ShaderTagName                          string IL2CPP_TYPE_STRING
    // 000 k_MaxVisibleAdditionalLightsMobileShaderLevelLessThan45 int IL2CPP_TYPE_I4
    // 000 k_MaxVisibleAdditionalLightsMobile       int IL2CPP_TYPE_I4
    // 000 k_MaxVisibleAdditionalLightsNonMobile    int IL2CPP_TYPE_I4
    // 000 k_DefaultRenderingLayerMask              int IL2CPP_TYPE_I4
    // 018 M_DebugDisplaySettingsUI                 ModelClassType DebugDisplaySettingsUI DebugDisplaySettingsUI DebugDisplaySettingsUI Pointer
    // 020 M_GlobalSettings                         ModelClassType UniversalRenderPipelineGlobalSettings UniversalRenderPipelineGlobalSettings UniversalRenderPipelineGlobalSettings Pointer
    // 000 cameraStackRequiresDepthForPostprocessing bool IL2CPP_TYPE_BOOLEAN
    // 008 s_RenderGraph                            RenderGraph IL2CPP_TYPE_CLASS
    // 010 S_RTHandlePool                           ModelClassType RTHandleResourcePool RTHandleResourcePool RTHandleResourcePool Pointer
    // 018 UseRenderGraph                           ModelPrimitiveType bool bool bool Bool
    // 028 PipelineAsset                            ModelClassType UniversalRenderPipelineAsset UniversalRenderPipelineAsset UniversalRenderPipelineAsset Pointer
    // 020 renderDataDictionary                     Dictionary`2<Camera, PrismRenderData> IL2CPP_TYPE_GENERICINST
    // 030 EnableHDROnce                            ModelPrimitiveType bool bool bool Bool
    // 028 K_DefaultLightPosition                   ModelEnumType Vector4 Vector4 Vector4 Int32
    // 038 K_DefaultLightColor                      ModelEnumType Vector4 Vector4 Vector4 Int32
    // 048 K_DefaultLightAttenuation                ModelEnumType Vector4 Vector4 Vector4 Int32
    // 058 K_DefaultLightSpotDirection              ModelEnumType Vector4 Vector4 Vector4 Int32
    // 068 K_DefaultLightsProbeChannel              ModelEnumType Vector4 Vector4 Vector4 Int32
    // 078 M_ShadowBiasData                         ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer
    // 080 M_ShadowResolutionData                   ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 038 cameraComparison                         Comparison`1<Camera> IL2CPP_TYPE_GENERICINST
    // 088 LightsDelegate                           ModelClassType RequestLightsDelegate RequestLightsDelegate RequestLightsDelegate Pointer
    public partial class UniversalRenderPipeline : DataModel
    {
        public DebugDisplaySettingsUI?                  M_DebugDisplaySettingsUI                { get; set; }
        public UniversalRenderPipelineGlobalSettings?   M_GlobalSettings                        { get; set; }
        public RTHandleResourcePool?                    S_RTHandlePool                          { get; set; }
        public bool                                     UseRenderGraph                          { get; set; }
        public UniversalRenderPipelineAsset?            PipelineAsset                           { get; set; }
        public bool                                     EnableHDROnce                           { get; set; }
        public Vector4                                  K_DefaultLightPosition                  { get; set; }
        public Vector4                                  K_DefaultLightColor                     { get; set; }
        public Vector4                                  K_DefaultLightAttenuation               { get; set; }
        public Vector4                                  K_DefaultLightSpotDirection             { get; set; }
        public Vector4                                  K_DefaultLightsProbeChannel             { get; set; }
        public List<Vector4>?                           M_ShadowBiasData                        { get; set; }
        public List<int>?                               M_ShadowResolutionData                  { get; set; }
        public RequestLightsDelegate?                   LightsDelegate                          { get; set; }

        public static UniversalRenderPipeline? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniversalRenderPipeline() { Pointer= p0 };

            value.M_DebugDisplaySettingsUI                  = GetObject<DebugDisplaySettingsUI>(new IntPtr(p + 0x018), ReversePrism.DataModels.DebugDisplaySettingsUI.FromPointer); // 0x18 M_DebugDisplaySettingsUI    ( ModelClassType DebugDisplaySettingsUI DebugDisplaySettingsUI DebugDisplaySettingsUI Pointer )
            value.M_GlobalSettings                          = GetObject<UniversalRenderPipelineGlobalSettings>(new IntPtr(p + 0x020), ReversePrism.DataModels.UniversalRenderPipelineGlobalSettings.FromPointer); // 0x20 M_GlobalSettings            ( ModelClassType UniversalRenderPipelineGlobalSettings UniversalRenderPipelineGlobalSettings UniversalRenderPipelineGlobalSettings Pointer )
            value.S_RTHandlePool                            = GetObject<RTHandleResourcePool>(new IntPtr(p + 0x010), ReversePrism.DataModels.RTHandleResourcePool.FromPointer); // 0x10 S_RTHandlePool              ( ModelClassType RTHandleResourcePool RTHandleResourcePool RTHandleResourcePool Pointer )
            value.UseRenderGraph                            = GetBool(new IntPtr(p + 0x018)); // 0x18 UseRenderGraph              ( ModelPrimitiveType bool bool bool Bool )
            value.PipelineAsset                             = GetObject<UniversalRenderPipelineAsset>(new IntPtr(p + 0x028), ReversePrism.DataModels.UniversalRenderPipelineAsset.FromPointer); // 0x28 PipelineAsset               ( ModelClassType UniversalRenderPipelineAsset UniversalRenderPipelineAsset UniversalRenderPipelineAsset Pointer )
            value.EnableHDROnce                             = GetBool(new IntPtr(p + 0x030)); // 0x30 EnableHDROnce               ( ModelPrimitiveType bool bool bool Bool )
            value.K_DefaultLightPosition                    = (Vector4)GetInt32(new IntPtr(p + 0x028)); // 0x28 K_DefaultLightPosition      ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.K_DefaultLightColor                       = (Vector4)GetInt32(new IntPtr(p + 0x038)); // 0x38 K_DefaultLightColor         ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.K_DefaultLightAttenuation                 = (Vector4)GetInt32(new IntPtr(p + 0x048)); // 0x48 K_DefaultLightAttenuation   ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.K_DefaultLightSpotDirection               = (Vector4)GetInt32(new IntPtr(p + 0x058)); // 0x58 K_DefaultLightSpotDirection ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.K_DefaultLightsProbeChannel               = (Vector4)GetInt32(new IntPtr(p + 0x068)); // 0x68 K_DefaultLightsProbeChannel ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.M_ShadowBiasData                          = GetEnumList<Vector4>(new IntPtr(p + 0x078)); // 0x78 M_ShadowBiasData            ( ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer )
            value.M_ShadowResolutionData                    = GetInt32List(new IntPtr(p + 0x080)); // 0x80 M_ShadowResolutionData      ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.LightsDelegate                            = GetObject<RequestLightsDelegate>(new IntPtr(p + 0x088), ReversePrism.DataModels.RequestLightsDelegate.FromPointer); // 0x88 LightsDelegate              ( ModelClassType RequestLightsDelegate RequestLightsDelegate RequestLightsDelegate Pointer )

            return value;
        }
    }
}
