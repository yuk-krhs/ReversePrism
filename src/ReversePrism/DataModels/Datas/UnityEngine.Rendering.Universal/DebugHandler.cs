using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_DebugColorInvalidModePropertyId        int IL2CPP_TYPE_I4
    // 004 k_DebugColorPropertyId                   int IL2CPP_TYPE_I4
    // 008 k_DebugTexturePropertyId                 int IL2CPP_TYPE_I4
    // 00C k_DebugTextureNoStereoPropertyId         int IL2CPP_TYPE_I4
    // 010 K_DebugTextureDisplayRect                ModelPrimitiveType int int int Int32
    // 014 K_DebugRenderTargetSupportsStereo        ModelPrimitiveType int int int Int32
    // 018 K_DebugScreenTexturePropertyId           ModelPrimitiveType int int int Int32
    // 01C K_DebugMaterialModeId                    ModelPrimitiveType int int int Int32
    // 020 K_DebugVertexAttributeModeId             ModelPrimitiveType int int int Int32
    // 024 K_DebugMaterialValidationModeId          ModelPrimitiveType int int int Int32
    // 028 K_DebugMipInfoModeId                     ModelPrimitiveType int int int Int32
    // 02C K_DebugSceneOverrideModeId               ModelPrimitiveType int int int Int32
    // 030 K_DebugFullScreenModeId                  ModelPrimitiveType int int int Int32
    // 034 K_DebugValidationModeId                  ModelPrimitiveType int int int Int32
    // 038 K_DebugValidateBelowMinThresholdColorPropertyId ModelPrimitiveType int int int Int32
    // 03C K_DebugValidateAboveMaxThresholdColorPropertyId ModelPrimitiveType int int int Int32
    // 040 K_DebugMaxPixelCost                      ModelPrimitiveType int int int Int32
    // 044 K_DebugLightingModeId                    ModelPrimitiveType int int int Int32
    // 048 K_DebugLightingFeatureFlagsId            ModelPrimitiveType int int int Int32
    // 04C K_DebugValidateAlbedoMinLuminanceId      ModelPrimitiveType int int int Int32
    // 050 K_DebugValidateAlbedoMaxLuminanceId      ModelPrimitiveType int int int Int32
    // 054 K_DebugValidateAlbedoSaturationToleranceId ModelPrimitiveType int int int Int32
    // 058 K_DebugValidateAlbedoHueToleranceId      ModelPrimitiveType int int int Int32
    // 05C K_DebugValidateAlbedoCompareColorId      ModelPrimitiveType int int int Int32
    // 060 K_DebugValidateMetallicMinValueId        ModelPrimitiveType int int int Int32
    // 064 K_DebugValidateMetallicMaxValueId        ModelPrimitiveType int int int Int32
    // 068 K_ValidationChannelsId                   ModelPrimitiveType int int int Int32
    // 06C K_RangeMinimumId                         ModelPrimitiveType int int int Int32
    // 070 K_RangeMaximumId                         ModelPrimitiveType int int int Int32
    // 010 M_ReplacementMaterial                    ModelClassType Material Material Material Pointer
    // 018 M_HDRDebugViewMaterial                   ModelClassType Material Material Material Pointer
    // 020 M_HDRDebugViewPass                       ModelClassType HDRDebugViewPass HDRDebugViewPass HDRDebugViewPass Pointer
    // 028 M_DebugScreenColorHandle                 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 030 M_DebugScreenDepthHandle                 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 038 M_HasDebugRenderTarget                   ModelPrimitiveType bool bool bool Bool
    // 039 M_DebugRenderTargetSupportsStereo        ModelPrimitiveType bool bool bool Bool
    // 03C M_DebugRenderTargetPixelRect             ModelEnumType Vector4 Vector4 Vector4 Int32
    // 050 M_DebugRenderTargetIdentifier            ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 078 M_DebugDisplaySettings                   ModelClassType UniversalRenderPipelineDebugDisplaySettings UniversalRenderPipelineDebugDisplaySettings UniversalRenderPipelineDebugDisplaySettings Pointer
    public partial class DebugHandler : DataModel
    {
        public int                                      K_DebugTextureDisplayRect               { get; set; }
        public int                                      K_DebugRenderTargetSupportsStereo       { get; set; }
        public int                                      K_DebugScreenTexturePropertyId          { get; set; }
        public int                                      K_DebugMaterialModeId                   { get; set; }
        public int                                      K_DebugVertexAttributeModeId            { get; set; }
        public int                                      K_DebugMaterialValidationModeId         { get; set; }
        public int                                      K_DebugMipInfoModeId                    { get; set; }
        public int                                      K_DebugSceneOverrideModeId              { get; set; }
        public int                                      K_DebugFullScreenModeId                 { get; set; }
        public int                                      K_DebugValidationModeId                 { get; set; }
        public int                                      K_DebugValidateBelowMinThresholdColorPropertyId { get; set; }
        public int                                      K_DebugValidateAboveMaxThresholdColorPropertyId { get; set; }
        public int                                      K_DebugMaxPixelCost                     { get; set; }
        public int                                      K_DebugLightingModeId                   { get; set; }
        public int                                      K_DebugLightingFeatureFlagsId           { get; set; }
        public int                                      K_DebugValidateAlbedoMinLuminanceId     { get; set; }
        public int                                      K_DebugValidateAlbedoMaxLuminanceId     { get; set; }
        public int                                      K_DebugValidateAlbedoSaturationToleranceId { get; set; }
        public int                                      K_DebugValidateAlbedoHueToleranceId     { get; set; }
        public int                                      K_DebugValidateAlbedoCompareColorId     { get; set; }
        public int                                      K_DebugValidateMetallicMinValueId       { get; set; }
        public int                                      K_DebugValidateMetallicMaxValueId       { get; set; }
        public int                                      K_ValidationChannelsId                  { get; set; }
        public int                                      K_RangeMinimumId                        { get; set; }
        public int                                      K_RangeMaximumId                        { get; set; }
        public Material?                                M_ReplacementMaterial                   { get; set; }
        public Material?                                M_HDRDebugViewMaterial                  { get; set; }
        public HDRDebugViewPass?                        M_HDRDebugViewPass                      { get; set; }
        public RTHandle?                                M_DebugScreenColorHandle                { get; set; }
        public RTHandle?                                M_DebugScreenDepthHandle                { get; set; }
        public bool                                     M_HasDebugRenderTarget                  { get; set; }
        public bool                                     M_DebugRenderTargetSupportsStereo       { get; set; }
        public Vector4                                  M_DebugRenderTargetPixelRect            { get; set; }
        public RenderTargetIdentifier                   M_DebugRenderTargetIdentifier           { get; set; }
        public UniversalRenderPipelineDebugDisplaySettings? M_DebugDisplaySettings                  { get; set; }

        public static DebugHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugHandler() { Pointer= p0 };

            value.K_DebugTextureDisplayRect                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 K_DebugTextureDisplayRect   ( ModelPrimitiveType int int int Int32 )
            value.K_DebugRenderTargetSupportsStereo         = GetInt32(new IntPtr(p + 0x014)); // 0x14 K_DebugRenderTargetSupportsStereo ( ModelPrimitiveType int int int Int32 )
            value.K_DebugScreenTexturePropertyId            = GetInt32(new IntPtr(p + 0x018)); // 0x18 K_DebugScreenTexturePropertyId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugMaterialModeId                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C K_DebugMaterialModeId       ( ModelPrimitiveType int int int Int32 )
            value.K_DebugVertexAttributeModeId              = GetInt32(new IntPtr(p + 0x020)); // 0x20 K_DebugVertexAttributeModeId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugMaterialValidationModeId           = GetInt32(new IntPtr(p + 0x024)); // 0x24 K_DebugMaterialValidationModeId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugMipInfoModeId                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 K_DebugMipInfoModeId        ( ModelPrimitiveType int int int Int32 )
            value.K_DebugSceneOverrideModeId                = GetInt32(new IntPtr(p + 0x02C)); // 0x2C K_DebugSceneOverrideModeId  ( ModelPrimitiveType int int int Int32 )
            value.K_DebugFullScreenModeId                   = GetInt32(new IntPtr(p + 0x030)); // 0x30 K_DebugFullScreenModeId     ( ModelPrimitiveType int int int Int32 )
            value.K_DebugValidationModeId                   = GetInt32(new IntPtr(p + 0x034)); // 0x34 K_DebugValidationModeId     ( ModelPrimitiveType int int int Int32 )
            value.K_DebugValidateBelowMinThresholdColorPropertyId = GetInt32(new IntPtr(p + 0x038)); // 0x38 K_DebugValidateBelowMinThresholdColorPropertyId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugValidateAboveMaxThresholdColorPropertyId = GetInt32(new IntPtr(p + 0x03C)); // 0x3C K_DebugValidateAboveMaxThresholdColorPropertyId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugMaxPixelCost                       = GetInt32(new IntPtr(p + 0x040)); // 0x40 K_DebugMaxPixelCost         ( ModelPrimitiveType int int int Int32 )
            value.K_DebugLightingModeId                     = GetInt32(new IntPtr(p + 0x044)); // 0x44 K_DebugLightingModeId       ( ModelPrimitiveType int int int Int32 )
            value.K_DebugLightingFeatureFlagsId             = GetInt32(new IntPtr(p + 0x048)); // 0x48 K_DebugLightingFeatureFlagsId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugValidateAlbedoMinLuminanceId       = GetInt32(new IntPtr(p + 0x04C)); // 0x4C K_DebugValidateAlbedoMinLuminanceId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugValidateAlbedoMaxLuminanceId       = GetInt32(new IntPtr(p + 0x050)); // 0x50 K_DebugValidateAlbedoMaxLuminanceId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugValidateAlbedoSaturationToleranceId = GetInt32(new IntPtr(p + 0x054)); // 0x54 K_DebugValidateAlbedoSaturationToleranceId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugValidateAlbedoHueToleranceId       = GetInt32(new IntPtr(p + 0x058)); // 0x58 K_DebugValidateAlbedoHueToleranceId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugValidateAlbedoCompareColorId       = GetInt32(new IntPtr(p + 0x05C)); // 0x5C K_DebugValidateAlbedoCompareColorId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugValidateMetallicMinValueId         = GetInt32(new IntPtr(p + 0x060)); // 0x60 K_DebugValidateMetallicMinValueId ( ModelPrimitiveType int int int Int32 )
            value.K_DebugValidateMetallicMaxValueId         = GetInt32(new IntPtr(p + 0x064)); // 0x64 K_DebugValidateMetallicMaxValueId ( ModelPrimitiveType int int int Int32 )
            value.K_ValidationChannelsId                    = GetInt32(new IntPtr(p + 0x068)); // 0x68 K_ValidationChannelsId      ( ModelPrimitiveType int int int Int32 )
            value.K_RangeMinimumId                          = GetInt32(new IntPtr(p + 0x06C)); // 0x6C K_RangeMinimumId            ( ModelPrimitiveType int int int Int32 )
            value.K_RangeMaximumId                          = GetInt32(new IntPtr(p + 0x070)); // 0x70 K_RangeMaximumId            ( ModelPrimitiveType int int int Int32 )
            value.M_ReplacementMaterial                     = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0x10 M_ReplacementMaterial       ( ModelClassType Material Material Material Pointer )
            value.M_HDRDebugViewMaterial                    = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0x18 M_HDRDebugViewMaterial      ( ModelClassType Material Material Material Pointer )
            value.M_HDRDebugViewPass                        = GetObject<HDRDebugViewPass>(new IntPtr(p + 0x020), ReversePrism.DataModels.HDRDebugViewPass.FromPointer); // 0x20 M_HDRDebugViewPass          ( ModelClassType HDRDebugViewPass HDRDebugViewPass HDRDebugViewPass Pointer )
            value.M_DebugScreenColorHandle                  = GetObject<RTHandle>(new IntPtr(p + 0x028), ReversePrism.DataModels.RTHandle.FromPointer); // 0x28 M_DebugScreenColorHandle    ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_DebugScreenDepthHandle                  = GetObject<RTHandle>(new IntPtr(p + 0x030), ReversePrism.DataModels.RTHandle.FromPointer); // 0x30 M_DebugScreenDepthHandle    ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_HasDebugRenderTarget                    = GetBool(new IntPtr(p + 0x038)); // 0x38 M_HasDebugRenderTarget      ( ModelPrimitiveType bool bool bool Bool )
            value.M_DebugRenderTargetSupportsStereo         = GetBool(new IntPtr(p + 0x039)); // 0x39 M_DebugRenderTargetSupportsStereo ( ModelPrimitiveType bool bool bool Bool )
            value.M_DebugRenderTargetPixelRect              = (Vector4)GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_DebugRenderTargetPixelRect ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.M_DebugRenderTargetIdentifier             = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_DebugRenderTargetIdentifier ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.M_DebugDisplaySettings                    = GetObject<UniversalRenderPipelineDebugDisplaySettings>(new IntPtr(p + 0x078), ReversePrism.DataModels.UniversalRenderPipelineDebugDisplaySettings.FromPointer); // 0x78 M_DebugDisplaySettings      ( ModelClassType UniversalRenderPipelineDebugDisplaySettings UniversalRenderPipelineDebugDisplaySettings UniversalRenderPipelineDebugDisplaySettings Pointer )

            return value;
        }
    }
}
