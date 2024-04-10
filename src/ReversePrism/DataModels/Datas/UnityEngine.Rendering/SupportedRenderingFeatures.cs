using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Active                                 SupportedRenderingFeatures IL2CPP_TYPE_CLASS
    // 010 ReflectionProbeModes                     0001865D4B40 ModelEnumType ReflectionProbeModes ReflectionProbeModes ReflectionProbeModes Int32
    // 014 DefaultMixedLightingModes                0001865D4400 ModelEnumType LightmapMixedBakeModes LightmapMixedBakeModes LightmapMixedBakeModes Int32
    // 018 MixedLightingModes                       0001865D4400 ModelEnumType LightmapMixedBakeModes LightmapMixedBakeModes LightmapMixedBakeModes Int32
    // 01C LightmapBakeTypes                        000186529CC0 ModelEnumType LightmapBakeType LightmapBakeType LightmapBakeType Int32
    // 020 LightmapsModes                           00018652AE10 ModelEnumType LightmapsMode LightmapsMode LightmapsMode Int32
    // 024 EnlightenLightmapper                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 025 Enlighten                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 026 LightProbeProxyVolumes                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 027 MotionVectors                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 ReceiveShadows                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 ReflectionProbes                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02A ReflectionProbesBlendDistance            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02B RendererPriority                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C RendersUIOverlay                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02D OverridesEnvironmentLighting             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02E OverridesFog                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02F OverridesRealtimeReflectionProbes        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 OverridesOtherLightingSettings           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 EditableMaterialRenderQueue              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 OverridesLODBias                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 033 OverridesMaximumLODLevel                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 OverridesEnableLODCrossFade              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 035 RendererProbes                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 036 ParticleSystemInstancing                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 037 AutoAmbientProbeBaking                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 AutoDefaultReflectionProbeBaking         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 OverridesShadowmask                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03A OverridesLightProbeSystem                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03B SupportsHDR                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 OverridesLightProbeSystemWarningMessage  000186671910 ModelPrimitiveType string string string String
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

            value.ReflectionProbeModes                      = (ReflectionProbeModes)GetInt32(new IntPtr(p + 0x010)); // 0245A247BC60 0x10 ReflectionProbeModes        ( 0001865D4B40 ModelEnumType ReflectionProbeModes ReflectionProbeModes ReflectionProbeModes Int32 )
            value.DefaultMixedLightingModes                 = (LightmapMixedBakeModes)GetInt32(new IntPtr(p + 0x014)); // 0245A247BC80 0x14 DefaultMixedLightingModes   ( 0001865D4400 ModelEnumType LightmapMixedBakeModes LightmapMixedBakeModes LightmapMixedBakeModes Int32 )
            value.MixedLightingModes                        = (LightmapMixedBakeModes)GetInt32(new IntPtr(p + 0x018)); // 0245A247BCA0 0x18 MixedLightingModes          ( 0001865D4400 ModelEnumType LightmapMixedBakeModes LightmapMixedBakeModes LightmapMixedBakeModes Int32 )
            value.LightmapBakeTypes                         = (LightmapBakeType)GetInt32(new IntPtr(p + 0x01C)); // 0245A247BCC0 0x1C LightmapBakeTypes           ( 000186529CC0 ModelEnumType LightmapBakeType LightmapBakeType LightmapBakeType Int32 )
            value.LightmapsModes                            = (LightmapsMode)GetInt32(new IntPtr(p + 0x020)); // 0245A247BCE0 0x20 LightmapsModes              ( 00018652AE10 ModelEnumType LightmapsMode LightmapsMode LightmapsMode Int32 )
            value.EnlightenLightmapper                      = GetBool(new IntPtr(p + 0x024)); // 0245A247BD00 0x24 EnlightenLightmapper        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Enlighten                                 = GetBool(new IntPtr(p + 0x025)); // 0245A247BD20 0x25 Enlighten                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LightProbeProxyVolumes                    = GetBool(new IntPtr(p + 0x026)); // 0245A247BD40 0x26 LightProbeProxyVolumes      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MotionVectors                             = GetBool(new IntPtr(p + 0x027)); // 0245A247BD60 0x27 MotionVectors               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReceiveShadows                            = GetBool(new IntPtr(p + 0x028)); // 0245A247BD80 0x28 ReceiveShadows              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReflectionProbes                          = GetBool(new IntPtr(p + 0x029)); // 0245A247BDA0 0x29 ReflectionProbes            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReflectionProbesBlendDistance             = GetBool(new IntPtr(p + 0x02A)); // 0245A247BDC0 0x2A ReflectionProbesBlendDistance ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RendererPriority                          = GetBool(new IntPtr(p + 0x02B)); // 0245A247BDE0 0x2B RendererPriority            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RendersUIOverlay                          = GetBool(new IntPtr(p + 0x02C)); // 0245A247BE00 0x2C RendersUIOverlay            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverridesEnvironmentLighting              = GetBool(new IntPtr(p + 0x02D)); // 0245A247BE20 0x2D OverridesEnvironmentLighting ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverridesFog                              = GetBool(new IntPtr(p + 0x02E)); // 0245A247BE40 0x2E OverridesFog                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverridesRealtimeReflectionProbes         = GetBool(new IntPtr(p + 0x02F)); // 0245A247BE60 0x2F OverridesRealtimeReflectionProbes ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverridesOtherLightingSettings            = GetBool(new IntPtr(p + 0x030)); // 0245A247BE80 0x30 OverridesOtherLightingSettings ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EditableMaterialRenderQueue               = GetBool(new IntPtr(p + 0x031)); // 0245A247BEA0 0x31 EditableMaterialRenderQueue ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverridesLODBias                          = GetBool(new IntPtr(p + 0x032)); // 0245A247BEC0 0x32 OverridesLODBias            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverridesMaximumLODLevel                  = GetBool(new IntPtr(p + 0x033)); // 0245A247BEE0 0x33 OverridesMaximumLODLevel    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverridesEnableLODCrossFade               = GetBool(new IntPtr(p + 0x034)); // 0245A247BF00 0x34 OverridesEnableLODCrossFade ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RendererProbes                            = GetBool(new IntPtr(p + 0x035)); // 0245A247BF20 0x35 RendererProbes              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ParticleSystemInstancing                  = GetBool(new IntPtr(p + 0x036)); // 0245A247BF40 0x36 ParticleSystemInstancing    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AutoAmbientProbeBaking                    = GetBool(new IntPtr(p + 0x037)); // 0245A247BF60 0x37 AutoAmbientProbeBaking      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AutoDefaultReflectionProbeBaking          = GetBool(new IntPtr(p + 0x038)); // 0245A247BF80 0x38 AutoDefaultReflectionProbeBaking ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverridesShadowmask                       = GetBool(new IntPtr(p + 0x039)); // 0245A247BFA0 0x39 OverridesShadowmask         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverridesLightProbeSystem                 = GetBool(new IntPtr(p + 0x03A)); // 0245A247BFC0 0x3A OverridesLightProbeSystem   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SupportsHDR                               = GetBool(new IntPtr(p + 0x03B)); // 0245A247BFE0 0x3B SupportsHDR                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverridesLightProbeSystemWarningMessage   = GetString(new IntPtr(p + 0x040)); // 0245A247C000 0x40 OverridesLightProbeSystemWarningMessage ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
