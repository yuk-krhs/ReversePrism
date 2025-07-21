using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Active                                 SupportedRenderingFeatures IL2CPP_TYPE_CLASS
    // 010 ReflectionProbeModes                     ModelEnumType ReflectionProbeModes ReflectionProbeModes ReflectionProbeModes Int32
    // 014 DefaultMixedLightingModes                ModelEnumType LightmapMixedBakeModes LightmapMixedBakeModes LightmapMixedBakeModes Int32
    // 018 MixedLightingModes                       ModelEnumType LightmapMixedBakeModes LightmapMixedBakeModes LightmapMixedBakeModes Int32
    // 01C LightmapBakeTypes                        ModelEnumType LightmapBakeType LightmapBakeType LightmapBakeType Int32
    // 020 LightmapsModes                           ModelEnumType LightmapsMode LightmapsMode LightmapsMode Int32
    // 024 EnlightenLightmapper                     ModelPrimitiveType bool bool bool Bool
    // 025 Enlighten                                ModelPrimitiveType bool bool bool Bool
    // 026 LightProbeProxyVolumes                   ModelPrimitiveType bool bool bool Bool
    // 027 MotionVectors                            ModelPrimitiveType bool bool bool Bool
    // 028 ReceiveShadows                           ModelPrimitiveType bool bool bool Bool
    // 029 ReflectionProbes                         ModelPrimitiveType bool bool bool Bool
    // 02A ReflectionProbesBlendDistance            ModelPrimitiveType bool bool bool Bool
    // 02B RendererPriority                         ModelPrimitiveType bool bool bool Bool
    // 02C RendersUIOverlay                         ModelPrimitiveType bool bool bool Bool
    // 02D OverridesEnvironmentLighting             ModelPrimitiveType bool bool bool Bool
    // 02E OverridesFog                             ModelPrimitiveType bool bool bool Bool
    // 02F OverridesRealtimeReflectionProbes        ModelPrimitiveType bool bool bool Bool
    // 030 OverridesOtherLightingSettings           ModelPrimitiveType bool bool bool Bool
    // 031 EditableMaterialRenderQueue              ModelPrimitiveType bool bool bool Bool
    // 032 OverridesLODBias                         ModelPrimitiveType bool bool bool Bool
    // 033 OverridesMaximumLODLevel                 ModelPrimitiveType bool bool bool Bool
    // 034 OverridesEnableLODCrossFade              ModelPrimitiveType bool bool bool Bool
    // 035 RendererProbes                           ModelPrimitiveType bool bool bool Bool
    // 036 ParticleSystemInstancing                 ModelPrimitiveType bool bool bool Bool
    // 037 AutoAmbientProbeBaking                   ModelPrimitiveType bool bool bool Bool
    // 038 AutoDefaultReflectionProbeBaking         ModelPrimitiveType bool bool bool Bool
    // 039 OverridesShadowmask                      ModelPrimitiveType bool bool bool Bool
    // 03A OverridesLightProbeSystem                ModelPrimitiveType bool bool bool Bool
    // 03B SupportsHDR                              ModelPrimitiveType bool bool bool Bool
    // 040 OverridesLightProbeSystemWarningMessage  ModelPrimitiveType string string string String
    public partial class SupportedRenderingFeatures : DataModel
    {
        public ReflectionProbeModes                     ReflectionProbeModes                    { get; set; }
        public LightmapMixedBakeModes                   DefaultMixedLightingModes               { get; set; }
        public LightmapMixedBakeModes                   MixedLightingModes                      { get; set; }
        public LightmapBakeType                         LightmapBakeTypes                       { get; set; }
        public LightmapsMode                            LightmapsModes                          { get; set; }
        public bool                                     EnlightenLightmapper                    { get; set; }
        public bool                                     Enlighten                               { get; set; }
        public bool                                     LightProbeProxyVolumes                  { get; set; }
        public bool                                     MotionVectors                           { get; set; }
        public bool                                     ReceiveShadows                          { get; set; }
        public bool                                     ReflectionProbes                        { get; set; }
        public bool                                     ReflectionProbesBlendDistance           { get; set; }
        public bool                                     RendererPriority                        { get; set; }
        public bool                                     RendersUIOverlay                        { get; set; }
        public bool                                     OverridesEnvironmentLighting            { get; set; }
        public bool                                     OverridesFog                            { get; set; }
        public bool                                     OverridesRealtimeReflectionProbes       { get; set; }
        public bool                                     OverridesOtherLightingSettings          { get; set; }
        public bool                                     EditableMaterialRenderQueue             { get; set; }
        public bool                                     OverridesLODBias                        { get; set; }
        public bool                                     OverridesMaximumLODLevel                { get; set; }
        public bool                                     OverridesEnableLODCrossFade             { get; set; }
        public bool                                     RendererProbes                          { get; set; }
        public bool                                     ParticleSystemInstancing                { get; set; }
        public bool                                     AutoAmbientProbeBaking                  { get; set; }
        public bool                                     AutoDefaultReflectionProbeBaking        { get; set; }
        public bool                                     OverridesShadowmask                     { get; set; }
        public bool                                     OverridesLightProbeSystem               { get; set; }
        public bool                                     SupportsHDR                             { get; set; }
        public string                                   OverridesLightProbeSystemWarningMessage { get; set; }

        public static SupportedRenderingFeatures? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportedRenderingFeatures() { Pointer= p0 };

            value.ReflectionProbeModes                      = (ReflectionProbeModes)GetInt32(new IntPtr(p + 0x010)); // 0x10 ReflectionProbeModes        ( ModelEnumType ReflectionProbeModes ReflectionProbeModes ReflectionProbeModes Int32 )
            value.DefaultMixedLightingModes                 = (LightmapMixedBakeModes)GetInt32(new IntPtr(p + 0x014)); // 0x14 DefaultMixedLightingModes   ( ModelEnumType LightmapMixedBakeModes LightmapMixedBakeModes LightmapMixedBakeModes Int32 )
            value.MixedLightingModes                        = (LightmapMixedBakeModes)GetInt32(new IntPtr(p + 0x018)); // 0x18 MixedLightingModes          ( ModelEnumType LightmapMixedBakeModes LightmapMixedBakeModes LightmapMixedBakeModes Int32 )
            value.LightmapBakeTypes                         = (LightmapBakeType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C LightmapBakeTypes           ( ModelEnumType LightmapBakeType LightmapBakeType LightmapBakeType Int32 )
            value.LightmapsModes                            = (LightmapsMode)GetInt32(new IntPtr(p + 0x020)); // 0x20 LightmapsModes              ( ModelEnumType LightmapsMode LightmapsMode LightmapsMode Int32 )
            value.EnlightenLightmapper                      = GetBool(new IntPtr(p + 0x024)); // 0x24 EnlightenLightmapper        ( ModelPrimitiveType bool bool bool Bool )
            value.Enlighten                                 = GetBool(new IntPtr(p + 0x025)); // 0x25 Enlighten                   ( ModelPrimitiveType bool bool bool Bool )
            value.LightProbeProxyVolumes                    = GetBool(new IntPtr(p + 0x026)); // 0x26 LightProbeProxyVolumes      ( ModelPrimitiveType bool bool bool Bool )
            value.MotionVectors                             = GetBool(new IntPtr(p + 0x027)); // 0x27 MotionVectors               ( ModelPrimitiveType bool bool bool Bool )
            value.ReceiveShadows                            = GetBool(new IntPtr(p + 0x028)); // 0x28 ReceiveShadows              ( ModelPrimitiveType bool bool bool Bool )
            value.ReflectionProbes                          = GetBool(new IntPtr(p + 0x029)); // 0x29 ReflectionProbes            ( ModelPrimitiveType bool bool bool Bool )
            value.ReflectionProbesBlendDistance             = GetBool(new IntPtr(p + 0x02A)); // 0x2A ReflectionProbesBlendDistance ( ModelPrimitiveType bool bool bool Bool )
            value.RendererPriority                          = GetBool(new IntPtr(p + 0x02B)); // 0x2B RendererPriority            ( ModelPrimitiveType bool bool bool Bool )
            value.RendersUIOverlay                          = GetBool(new IntPtr(p + 0x02C)); // 0x2C RendersUIOverlay            ( ModelPrimitiveType bool bool bool Bool )
            value.OverridesEnvironmentLighting              = GetBool(new IntPtr(p + 0x02D)); // 0x2D OverridesEnvironmentLighting ( ModelPrimitiveType bool bool bool Bool )
            value.OverridesFog                              = GetBool(new IntPtr(p + 0x02E)); // 0x2E OverridesFog                ( ModelPrimitiveType bool bool bool Bool )
            value.OverridesRealtimeReflectionProbes         = GetBool(new IntPtr(p + 0x02F)); // 0x2F OverridesRealtimeReflectionProbes ( ModelPrimitiveType bool bool bool Bool )
            value.OverridesOtherLightingSettings            = GetBool(new IntPtr(p + 0x030)); // 0x30 OverridesOtherLightingSettings ( ModelPrimitiveType bool bool bool Bool )
            value.EditableMaterialRenderQueue               = GetBool(new IntPtr(p + 0x031)); // 0x31 EditableMaterialRenderQueue ( ModelPrimitiveType bool bool bool Bool )
            value.OverridesLODBias                          = GetBool(new IntPtr(p + 0x032)); // 0x32 OverridesLODBias            ( ModelPrimitiveType bool bool bool Bool )
            value.OverridesMaximumLODLevel                  = GetBool(new IntPtr(p + 0x033)); // 0x33 OverridesMaximumLODLevel    ( ModelPrimitiveType bool bool bool Bool )
            value.OverridesEnableLODCrossFade               = GetBool(new IntPtr(p + 0x034)); // 0x34 OverridesEnableLODCrossFade ( ModelPrimitiveType bool bool bool Bool )
            value.RendererProbes                            = GetBool(new IntPtr(p + 0x035)); // 0x35 RendererProbes              ( ModelPrimitiveType bool bool bool Bool )
            value.ParticleSystemInstancing                  = GetBool(new IntPtr(p + 0x036)); // 0x36 ParticleSystemInstancing    ( ModelPrimitiveType bool bool bool Bool )
            value.AutoAmbientProbeBaking                    = GetBool(new IntPtr(p + 0x037)); // 0x37 AutoAmbientProbeBaking      ( ModelPrimitiveType bool bool bool Bool )
            value.AutoDefaultReflectionProbeBaking          = GetBool(new IntPtr(p + 0x038)); // 0x38 AutoDefaultReflectionProbeBaking ( ModelPrimitiveType bool bool bool Bool )
            value.OverridesShadowmask                       = GetBool(new IntPtr(p + 0x039)); // 0x39 OverridesShadowmask         ( ModelPrimitiveType bool bool bool Bool )
            value.OverridesLightProbeSystem                 = GetBool(new IntPtr(p + 0x03A)); // 0x3A OverridesLightProbeSystem   ( ModelPrimitiveType bool bool bool Bool )
            value.SupportsHDR                               = GetBool(new IntPtr(p + 0x03B)); // 0x3B SupportsHDR                 ( ModelPrimitiveType bool bool bool Bool )
            value.OverridesLightProbeSystemWarningMessage   = GetString(new IntPtr(p + 0x040)); // 0x40 OverridesLightProbeSystemWarningMessage ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
