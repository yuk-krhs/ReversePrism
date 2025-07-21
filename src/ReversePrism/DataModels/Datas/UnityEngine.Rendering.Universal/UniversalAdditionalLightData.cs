using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Version                                ModelPrimitiveType int int int Int32
    // 024 M_UsePipelineSettings                    ModelPrimitiveType bool bool bool Bool
    // 000 AdditionalLightsShadowResolutionTierCustom int IL2CPP_TYPE_I4
    // 004 AdditionalLightsShadowResolutionTierLow  int IL2CPP_TYPE_I4
    // 008 AdditionalLightsShadowResolutionTierMedium int IL2CPP_TYPE_I4
    // 00C AdditionalLightsShadowResolutionTierHigh int IL2CPP_TYPE_I4
    // 010 AdditionalLightsShadowDefaultResolutionTier ModelPrimitiveType int int int Int32
    // 014 AdditionalLightsShadowDefaultCustomResolution ModelPrimitiveType int int int Int32
    // 018 AdditionalLightsShadowMinimumResolution  ModelPrimitiveType int int int Int32
    // 028 M_AdditionalLightsShadowResolutionTier   ModelPrimitiveType int int int Int32
    // 02C M_LightLayerMask                         ModelEnumType LightLayerEnum LightLayerEnum LightLayerEnum Int32
    // 030 M_RenderingLayers                        ModelPrimitiveType uint uint uint UInt32
    // 034 M_CustomShadowLayers                     ModelPrimitiveType bool bool bool Bool
    // 038 M_ShadowLayerMask                        ModelEnumType LightLayerEnum LightLayerEnum LightLayerEnum Int32
    // 03C M_ShadowRenderingLayers                  ModelPrimitiveType uint uint uint UInt32
    // 040 M_LightCookieSize                        ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 M_LightCookieOffset                      ModelEnumType Vector2 Vector2 Vector2 Int32
    // 050 M_SoftShadowQuality                      ModelEnumType SoftShadowQuality SoftShadowQuality SoftShadowQuality Int32
    public partial class UniversalAdditionalLightData : DataModel
    {
        public int                                      M_Version                               { get; set; }
        public bool                                     M_UsePipelineSettings                   { get; set; }
        public int                                      AdditionalLightsShadowDefaultResolutionTier { get; set; }
        public int                                      AdditionalLightsShadowDefaultCustomResolution { get; set; }
        public int                                      AdditionalLightsShadowMinimumResolution { get; set; }
        public int                                      M_AdditionalLightsShadowResolutionTier  { get; set; }
        public LightLayerEnum                           M_LightLayerMask                        { get; set; }
        public uint                                     M_RenderingLayers                       { get; set; }
        public bool                                     M_CustomShadowLayers                    { get; set; }
        public LightLayerEnum                           M_ShadowLayerMask                       { get; set; }
        public uint                                     M_ShadowRenderingLayers                 { get; set; }
        public Vector2                                  M_LightCookieSize                       { get; set; }
        public Vector2                                  M_LightCookieOffset                     { get; set; }
        public SoftShadowQuality                        M_SoftShadowQuality                     { get; set; }

        public static UniversalAdditionalLightData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniversalAdditionalLightData() { Pointer= p0 };

            value.M_Version                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Version                   ( ModelPrimitiveType int int int Int32 )
            value.M_UsePipelineSettings                     = GetBool(new IntPtr(p + 0x024)); // 0x24 M_UsePipelineSettings       ( ModelPrimitiveType bool bool bool Bool )
            value.AdditionalLightsShadowDefaultResolutionTier = GetInt32(new IntPtr(p + 0x010)); // 0x10 AdditionalLightsShadowDefaultResolutionTier ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsShadowDefaultCustomResolution = GetInt32(new IntPtr(p + 0x014)); // 0x14 AdditionalLightsShadowDefaultCustomResolution ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsShadowMinimumResolution   = GetInt32(new IntPtr(p + 0x018)); // 0x18 AdditionalLightsShadowMinimumResolution ( ModelPrimitiveType int int int Int32 )
            value.M_AdditionalLightsShadowResolutionTier    = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_AdditionalLightsShadowResolutionTier ( ModelPrimitiveType int int int Int32 )
            value.M_LightLayerMask                          = (LightLayerEnum)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_LightLayerMask            ( ModelEnumType LightLayerEnum LightLayerEnum LightLayerEnum Int32 )
            value.M_RenderingLayers                         = GetUInt32(new IntPtr(p + 0x030)); // 0x30 M_RenderingLayers           ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_CustomShadowLayers                      = GetBool(new IntPtr(p + 0x034)); // 0x34 M_CustomShadowLayers        ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShadowLayerMask                         = (LightLayerEnum)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_ShadowLayerMask           ( ModelEnumType LightLayerEnum LightLayerEnum LightLayerEnum Int32 )
            value.M_ShadowRenderingLayers                   = GetUInt32(new IntPtr(p + 0x03C)); // 0x3C M_ShadowRenderingLayers     ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_LightCookieSize                         = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_LightCookieSize           ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_LightCookieOffset                       = (Vector2)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_LightCookieOffset         ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_SoftShadowQuality                       = (SoftShadowQuality)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_SoftShadowQuality         ( ModelEnumType SoftShadowQuality SoftShadowQuality SoftShadowQuality Int32 )

            return value;
        }
    }
}
