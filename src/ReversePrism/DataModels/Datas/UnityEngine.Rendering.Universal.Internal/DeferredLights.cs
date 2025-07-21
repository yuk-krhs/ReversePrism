using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_GBufferNames                           string[] IL2CPP_TYPE_SZARRAY
    // 008 k_StencilDeferredPassNames               string[] IL2CPP_TYPE_SZARRAY
    // 010 K_InvalidLightOffset                     ModelPrimitiveType ushort ushort ushort UInt16
    // 018 K_SetupLights                            ModelPrimitiveType string string string String
    // 020 K_DeferredPass                           ModelPrimitiveType string string string String
    // 028 K_DeferredStencilPass                    ModelPrimitiveType string string string String
    // 030 K_DeferredFogPass                        ModelPrimitiveType string string string String
    // 038 K_ClearStencilPartial                    ModelPrimitiveType string string string String
    // 040 K_SetupLightConstants                    ModelPrimitiveType string string string String
    // 048 KStencilShapeGuard                       ModelPrimitiveType float float float Single
    // 050 M_ProfilingSetupLights                   ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 058 M_ProfilingDeferredPass                  ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 060 M_ProfilingSetupLightConstants           ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 010 RenderingLayerMaskSize                   ModelEnumType MaskSize MaskSize MaskSize Int32
    // 014 UseDecalLayers                           ModelPrimitiveType bool bool bool Bool
    // 015 UseRenderPass                            ModelPrimitiveType bool bool bool Bool
    // 016 HasDepthPrepass                          ModelPrimitiveType bool bool bool Bool
    // 017 HasNormalPrepass                         ModelPrimitiveType bool bool bool Bool
    // 018 HasRenderingLayerPrepass                 ModelPrimitiveType bool bool bool Bool
    // 019 IsOverlay                                ModelPrimitiveType bool bool bool Bool
    // 01A M_AccurateGbufferNormals                 ModelPrimitiveType bool bool bool Bool
    // 01C MixedLightingSetup                       ModelEnumType MixedLightingSetup MixedLightingSetup MixedLightingSetup Int32
    // 020 UseJobSystem                             ModelPrimitiveType bool bool bool Bool
    // 024 RenderWidth                              ModelPrimitiveType int int int Int32
    // 028 RenderHeight                             ModelPrimitiveType int int int Int32
    // 030 GbufferAttachments                       ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 038 GbufferRTHandles                         ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 040 GbufferTextureHandles                    ModelEnumListType TextureHandle[] TextureHandle[] List<TextureHandle> Pointer
    // 048 DeferredInputAttachments                 ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 050 DeferredInputIsTransient                 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 058 DepthAttachment                          ModelClassType RTHandle RTHandle RTHandle Pointer
    // 060 DepthCopyTexture                         ModelClassType RTHandle RTHandle RTHandle Pointer
    // 068 GbufferFormats                           ModelEnumListType GraphicsFormat[] GraphicsFormat[] List<GraphicsFormat> Pointer
    // 070 DepthAttachmentHandle                    ModelClassType RTHandle RTHandle RTHandle Pointer
    // 078 m_stencilVisLights                       NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 088 m_stencilVisLightOffsets                 NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 098 M_AdditionalLightsShadowCasterPass       ModelClassType AdditionalLightsShadowCasterPass AdditionalLightsShadowCasterPass AdditionalLightsShadowCasterPass Pointer
    // 0A0 M_SphereMesh                             ModelClassType Mesh Mesh Mesh Pointer
    // 0A8 M_HemisphereMesh                         ModelClassType Mesh Mesh Mesh Pointer
    // 0B0 M_FullscreenMesh                         ModelClassType Mesh Mesh Mesh Pointer
    // 0B8 M_StencilDeferredMaterial                ModelClassType Material Material Material Pointer
    // 0C0 M_StencilDeferredPasses                  ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0C8 M_ScreenToWorld                          ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 0D0 M_ProfilingSamplerDeferredStencilPass    ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 0D8 M_ProfilingSamplerDeferredFogPass        ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 0E0 M_ProfilingSamplerClearStencilPartialPass ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 0E8 M_LightCookieManager                     ModelClassType LightCookieManager LightCookieManager LightCookieManager Pointer
    public partial class DeferredLights : DataModel
    {
        public ushort                                   K_InvalidLightOffset                    { get; set; }
        public string                                   K_SetupLights                           { get; set; }
        public string                                   K_DeferredPass                          { get; set; }
        public string                                   K_DeferredStencilPass                   { get; set; }
        public string                                   K_DeferredFogPass                       { get; set; }
        public string                                   K_ClearStencilPartial                   { get; set; }
        public string                                   K_SetupLightConstants                   { get; set; }
        public float                                    KStencilShapeGuard                      { get; set; }
        public ProfilingSampler?                        M_ProfilingSetupLights                  { get; set; }
        public ProfilingSampler?                        M_ProfilingDeferredPass                 { get; set; }
        public ProfilingSampler?                        M_ProfilingSetupLightConstants          { get; set; }
        public MaskSize                                 RenderingLayerMaskSize                  { get; set; }
        public bool                                     UseDecalLayers                          { get; set; }
        public bool                                     UseRenderPass                           { get; set; }
        public bool                                     HasDepthPrepass                         { get; set; }
        public bool                                     HasNormalPrepass                        { get; set; }
        public bool                                     HasRenderingLayerPrepass                { get; set; }
        public bool                                     IsOverlay                               { get; set; }
        public bool                                     M_AccurateGbufferNormals                { get; set; }
        public MixedLightingSetup                       MixedLightingSetup                      { get; set; }
        public bool                                     UseJobSystem                            { get; set; }
        public int                                      RenderWidth                             { get; set; }
        public int                                      RenderHeight                            { get; set; }
        public List<RTHandle>?                          GbufferAttachments                      { get; set; }
        public List<RTHandle>?                          GbufferRTHandles                        { get; set; }
        public List<TextureHandle>?                     GbufferTextureHandles                   { get; set; }
        public List<RTHandle>?                          DeferredInputAttachments                { get; set; }
        public List<bool>?                              DeferredInputIsTransient                { get; set; }
        public RTHandle?                                DepthAttachment                         { get; set; }
        public RTHandle?                                DepthCopyTexture                        { get; set; }
        public List<GraphicsFormat>?                    GbufferFormats                          { get; set; }
        public RTHandle?                                DepthAttachmentHandle                   { get; set; }
        public AdditionalLightsShadowCasterPass?        M_AdditionalLightsShadowCasterPass      { get; set; }
        public Mesh?                                    M_SphereMesh                            { get; set; }
        public Mesh?                                    M_HemisphereMesh                        { get; set; }
        public Mesh?                                    M_FullscreenMesh                        { get; set; }
        public Material?                                M_StencilDeferredMaterial               { get; set; }
        public List<int>?                               M_StencilDeferredPasses                 { get; set; }
        public List<Matrix4x4>?                         M_ScreenToWorld                         { get; set; }
        public ProfilingSampler?                        M_ProfilingSamplerDeferredStencilPass   { get; set; }
        public ProfilingSampler?                        M_ProfilingSamplerDeferredFogPass       { get; set; }
        public ProfilingSampler?                        M_ProfilingSamplerClearStencilPartialPass { get; set; }
        public LightCookieManager?                      M_LightCookieManager                    { get; set; }

        public static DeferredLights? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeferredLights() { Pointer= p0 };

            value.K_InvalidLightOffset                      = GetUInt16(new IntPtr(p + 0x010)); // 0x10 K_InvalidLightOffset        ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.K_SetupLights                             = GetString(new IntPtr(p + 0x018)); // 0x18 K_SetupLights               ( ModelPrimitiveType string string string String )
            value.K_DeferredPass                            = GetString(new IntPtr(p + 0x020)); // 0x20 K_DeferredPass              ( ModelPrimitiveType string string string String )
            value.K_DeferredStencilPass                     = GetString(new IntPtr(p + 0x028)); // 0x28 K_DeferredStencilPass       ( ModelPrimitiveType string string string String )
            value.K_DeferredFogPass                         = GetString(new IntPtr(p + 0x030)); // 0x30 K_DeferredFogPass           ( ModelPrimitiveType string string string String )
            value.K_ClearStencilPartial                     = GetString(new IntPtr(p + 0x038)); // 0x38 K_ClearStencilPartial       ( ModelPrimitiveType string string string String )
            value.K_SetupLightConstants                     = GetString(new IntPtr(p + 0x040)); // 0x40 K_SetupLightConstants       ( ModelPrimitiveType string string string String )
            value.KStencilShapeGuard                        = GetSingle(new IntPtr(p + 0x048)); // 0x48 KStencilShapeGuard          ( ModelPrimitiveType float float float Single )
            value.M_ProfilingSetupLights                    = GetObject<ProfilingSampler>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x50 M_ProfilingSetupLights      ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingDeferredPass                   = GetObject<ProfilingSampler>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x58 M_ProfilingDeferredPass     ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingSetupLightConstants            = GetObject<ProfilingSampler>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x60 M_ProfilingSetupLightConstants ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.RenderingLayerMaskSize                    = (MaskSize)GetInt32(new IntPtr(p + 0x010)); // 0x10 RenderingLayerMaskSize      ( ModelEnumType MaskSize MaskSize MaskSize Int32 )
            value.UseDecalLayers                            = GetBool(new IntPtr(p + 0x014)); // 0x14 UseDecalLayers              ( ModelPrimitiveType bool bool bool Bool )
            value.UseRenderPass                             = GetBool(new IntPtr(p + 0x015)); // 0x15 UseRenderPass               ( ModelPrimitiveType bool bool bool Bool )
            value.HasDepthPrepass                           = GetBool(new IntPtr(p + 0x016)); // 0x16 HasDepthPrepass             ( ModelPrimitiveType bool bool bool Bool )
            value.HasNormalPrepass                          = GetBool(new IntPtr(p + 0x017)); // 0x17 HasNormalPrepass            ( ModelPrimitiveType bool bool bool Bool )
            value.HasRenderingLayerPrepass                  = GetBool(new IntPtr(p + 0x018)); // 0x18 HasRenderingLayerPrepass    ( ModelPrimitiveType bool bool bool Bool )
            value.IsOverlay                                 = GetBool(new IntPtr(p + 0x019)); // 0x19 IsOverlay                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_AccurateGbufferNormals                  = GetBool(new IntPtr(p + 0x01A)); // 0x1A M_AccurateGbufferNormals    ( ModelPrimitiveType bool bool bool Bool )
            value.MixedLightingSetup                        = (MixedLightingSetup)GetInt32(new IntPtr(p + 0x01C)); // 0x1C MixedLightingSetup          ( ModelEnumType MixedLightingSetup MixedLightingSetup MixedLightingSetup Int32 )
            value.UseJobSystem                              = GetBool(new IntPtr(p + 0x020)); // 0x20 UseJobSystem                ( ModelPrimitiveType bool bool bool Bool )
            value.RenderWidth                               = GetInt32(new IntPtr(p + 0x024)); // 0x24 RenderWidth                 ( ModelPrimitiveType int int int Int32 )
            value.RenderHeight                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 RenderHeight                ( ModelPrimitiveType int int int Int32 )
            value.GbufferAttachments                        = GetObjectList<RTHandle>(new IntPtr(p + 0x030), ReversePrism.DataModels.RTHandle.FromPointer); // 0x30 GbufferAttachments          ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.GbufferRTHandles                          = GetObjectList<RTHandle>(new IntPtr(p + 0x038), ReversePrism.DataModels.RTHandle.FromPointer); // 0x38 GbufferRTHandles            ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.GbufferTextureHandles                     = GetEnumList<TextureHandle>(new IntPtr(p + 0x040)); // 0x40 GbufferTextureHandles       ( ModelEnumListType TextureHandle[] TextureHandle[] List<TextureHandle> Pointer )
            value.DeferredInputAttachments                  = GetObjectList<RTHandle>(new IntPtr(p + 0x048), ReversePrism.DataModels.RTHandle.FromPointer); // 0x48 DeferredInputAttachments    ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.DeferredInputIsTransient                  = GetBoolList(new IntPtr(p + 0x050)); // 0x50 DeferredInputIsTransient    ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.DepthAttachment                           = GetObject<RTHandle>(new IntPtr(p + 0x058), ReversePrism.DataModels.RTHandle.FromPointer); // 0x58 DepthAttachment             ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.DepthCopyTexture                          = GetObject<RTHandle>(new IntPtr(p + 0x060), ReversePrism.DataModels.RTHandle.FromPointer); // 0x60 DepthCopyTexture            ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.GbufferFormats                            = GetEnumList<GraphicsFormat>(new IntPtr(p + 0x068)); // 0x68 GbufferFormats              ( ModelEnumListType GraphicsFormat[] GraphicsFormat[] List<GraphicsFormat> Pointer )
            value.DepthAttachmentHandle                     = GetObject<RTHandle>(new IntPtr(p + 0x070), ReversePrism.DataModels.RTHandle.FromPointer); // 0x70 DepthAttachmentHandle       ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_AdditionalLightsShadowCasterPass        = GetObject<AdditionalLightsShadowCasterPass>(new IntPtr(p + 0x098), ReversePrism.DataModels.AdditionalLightsShadowCasterPass.FromPointer); // 0x98 M_AdditionalLightsShadowCasterPass ( ModelClassType AdditionalLightsShadowCasterPass AdditionalLightsShadowCasterPass AdditionalLightsShadowCasterPass Pointer )
            value.M_SphereMesh                              = GetObject<Mesh>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Mesh.FromPointer); // 0xA0 M_SphereMesh                ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_HemisphereMesh                          = GetObject<Mesh>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Mesh.FromPointer); // 0xA8 M_HemisphereMesh            ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_FullscreenMesh                          = GetObject<Mesh>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Mesh.FromPointer); // 0xB0 M_FullscreenMesh            ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_StencilDeferredMaterial                 = GetObject<Material>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Material.FromPointer); // 0xB8 M_StencilDeferredMaterial   ( ModelClassType Material Material Material Pointer )
            value.M_StencilDeferredPasses                   = GetInt32List(new IntPtr(p + 0x0C0)); // 0xC0 M_StencilDeferredPasses     ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_ScreenToWorld                           = GetEnumList<Matrix4x4>(new IntPtr(p + 0x0C8)); // 0xC8 M_ScreenToWorld             ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.M_ProfilingSamplerDeferredStencilPass     = GetObject<ProfilingSampler>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0xD0 M_ProfilingSamplerDeferredStencilPass ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingSamplerDeferredFogPass         = GetObject<ProfilingSampler>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0xD8 M_ProfilingSamplerDeferredFogPass ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingSamplerClearStencilPartialPass = GetObject<ProfilingSampler>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0xE0 M_ProfilingSamplerClearStencilPartialPass ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_LightCookieManager                      = GetObject<LightCookieManager>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.LightCookieManager.FromPointer); // 0xE8 M_LightCookieManager        ( ModelClassType LightCookieManager LightCookieManager LightCookieManager Pointer )

            return value;
        }
    }
}
