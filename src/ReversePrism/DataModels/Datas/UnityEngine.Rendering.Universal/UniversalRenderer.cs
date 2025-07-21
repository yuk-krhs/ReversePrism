using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_DepthStencilFormat                     GraphicsFormat IL2CPP_TYPE_VALUETYPE
    // 000 k_DepthBufferBits                        int IL2CPP_TYPE_I4
    // 000 k_FinalBlitPassQueueOffset               int IL2CPP_TYPE_I4
    // 000 k_AfterFinalBlitPassQueueOffset          int IL2CPP_TYPE_I4
    // 000 k_DepthNormalsOnly                       List`1<ShaderTagId> IL2CPP_TYPE_GENERICINST
    // 1A8 M_Clustering                             ModelPrimitiveType bool bool bool Bool
    // 1B0 M_DepthPrepass                           ModelClassType DepthOnlyPass DepthOnlyPass DepthOnlyPass Pointer
    // 1B8 M_DepthNormalPrepass                     ModelClassType DepthNormalOnlyPass DepthNormalOnlyPass DepthNormalOnlyPass Pointer
    // 1C0 M_PrimedDepthCopyPass                    ModelClassType CopyDepthPass CopyDepthPass CopyDepthPass Pointer
    // 1C8 M_MotionVectorPass                       ModelClassType MotionVectorRenderPass MotionVectorRenderPass MotionVectorRenderPass Pointer
    // 1D0 M_MainLightShadowCasterPass              ModelClassType MainLightShadowCasterPass MainLightShadowCasterPass MainLightShadowCasterPass Pointer
    // 1D8 M_AdditionalLightsShadowCasterPass       ModelClassType AdditionalLightsShadowCasterPass AdditionalLightsShadowCasterPass AdditionalLightsShadowCasterPass Pointer
    // 1E0 M_GBufferPass                            ModelClassType GBufferPass GBufferPass GBufferPass Pointer
    // 1E8 M_GBufferCopyDepthPass                   ModelClassType CopyDepthPass CopyDepthPass CopyDepthPass Pointer
    // 1F0 M_DeferredPass                           ModelClassType DeferredPass DeferredPass DeferredPass Pointer
    // 1F8 M_RenderOpaqueForwardOnlyPass            ModelClassType DrawObjectsPass DrawObjectsPass DrawObjectsPass Pointer
    // 200 M_RenderOpaqueForwardPass                ModelClassType DrawObjectsPass DrawObjectsPass DrawObjectsPass Pointer
    // 208 M_RenderOpaqueForwardWithRenderingLayersPass ModelClassType DrawObjectsWithRenderingLayersPass DrawObjectsWithRenderingLayersPass DrawObjectsWithRenderingLayersPass Pointer
    // 210 M_DrawSkyboxPass                         ModelClassType DrawSkyboxPass DrawSkyboxPass DrawSkyboxPass Pointer
    // 218 M_CopyDepthPass                          ModelClassType CopyDepthPass CopyDepthPass CopyDepthPass Pointer
    // 220 M_CopyColorPass                          ModelClassType CopyColorPass CopyColorPass CopyColorPass Pointer
    // 228 M_TransparentSettingsPass                ModelClassType TransparentSettingsPass TransparentSettingsPass TransparentSettingsPass Pointer
    // 230 M_RenderTransparentForwardPass           ModelClassType DrawObjectsPass DrawObjectsPass DrawObjectsPass Pointer
    // 238 M_OnRenderObjectCallbackPass             ModelClassType InvokeOnRenderObjectCallbackPass InvokeOnRenderObjectCallbackPass InvokeOnRenderObjectCallbackPass Pointer
    // 240 M_FinalBlitPass                          ModelClassType FinalBlitPass FinalBlitPass FinalBlitPass Pointer
    // 248 M_CapturePass                            ModelClassType CapturePass CapturePass CapturePass Pointer
    // 250 M_DrawOffscreenUIPass                    ModelClassType DrawScreenSpaceUIPass DrawScreenSpaceUIPass DrawScreenSpaceUIPass Pointer
    // 258 M_DrawOverlayUIPass                      ModelClassType DrawScreenSpaceUIPass DrawScreenSpaceUIPass DrawScreenSpaceUIPass Pointer
    // 260 M_ColorBufferSystem                      ModelClassType RenderTargetBufferSystem RenderTargetBufferSystem RenderTargetBufferSystem Pointer
    // 268 M_ActiveCameraColorAttachment            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 270 M_ColorFrontBuffer                       ModelClassType RTHandle RTHandle RTHandle Pointer
    // 278 M_ActiveCameraDepthAttachment            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 280 M_CameraDepthAttachment                  ModelClassType RTHandle RTHandle RTHandle Pointer
    // 288 M_XRTargetHandleAlias                    ModelClassType RTHandle RTHandle RTHandle Pointer
    // 290 M_DepthTexture                           ModelClassType RTHandle RTHandle RTHandle Pointer
    // 298 M_NormalsTexture                         ModelClassType RTHandle RTHandle RTHandle Pointer
    // 2A0 M_DecalLayersTexture                     ModelClassType RTHandle RTHandle RTHandle Pointer
    // 2A8 M_OpaqueColor                            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 2B0 M_MotionVectorColor                      ModelClassType RTHandle RTHandle RTHandle Pointer
    // 2B8 M_MotionVectorDepth                      ModelClassType RTHandle RTHandle RTHandle Pointer
    // 2C0 M_ForwardLights                          ModelClassType ForwardLights ForwardLights ForwardLights Pointer
    // 2C8 M_DeferredLights                         ModelClassType DeferredLights DeferredLights DeferredLights Pointer
    // 2D0 M_RenderingMode                          ModelEnumType RenderingMode RenderingMode RenderingMode Int32
    // 2D4 M_DepthPrimingMode                       ModelEnumType DepthPrimingMode DepthPrimingMode DepthPrimingMode Int32
    // 2D8 M_CopyDepthMode                          ModelEnumType CopyDepthMode CopyDepthMode CopyDepthMode Int32
    // 2DC M_DepthPrimingRecommended                ModelPrimitiveType bool bool bool Bool
    // 2DD M_DefaultStencilState                    ModelEnumType StencilState StencilState StencilState Int32
    // 2F0 M_LightCookieManager                     ModelClassType LightCookieManager LightCookieManager LightCookieManager Pointer
    // 2F8 M_IntermediateTextureMode                ModelEnumType IntermediateTextureMode IntermediateTextureMode IntermediateTextureMode Int32
    // 300 M_BlitMaterial                           ModelClassType Material Material Material Pointer
    // 308 M_BlitHDRMaterial                        ModelClassType Material Material Material Pointer
    // 310 M_CopyDepthMaterial                      ModelClassType Material Material Material Pointer
    // 318 M_SamplingMaterial                       ModelClassType Material Material Material Pointer
    // 320 M_StencilDeferredMaterial                ModelClassType Material Material Material Pointer
    // 328 M_CameraMotionVecMaterial                ModelClassType Material Material Material Pointer
    // 330 M_ObjectMotionVecMaterial                ModelClassType Material Material Material Pointer
    // 338 M_PostProcessPasses                      ModelEnumType PostProcessPasses PostProcessPasses PostProcessPasses Int32
    // 008 m_RenderGraphCameraColorHandle           RTHandle IL2CPP_TYPE_CLASS
    // 010 M_RenderGraphCameraDepthHandle           ModelClassType RTHandle RTHandle RTHandle Pointer
    // 018 M_ActiveRenderGraphColor                 ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 020 M_ActiveRenderGraphDepth                 ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 378 M_TargetIsBackbuffer                     ModelPrimitiveType bool bool bool Bool
    // 380 FrameResources                           ModelClassType RenderGraphFrameResources RenderGraphFrameResources RenderGraphFrameResources Pointer
    // 028 M_UseIntermediateTexture                 ModelPrimitiveType bool bool bool Bool
    public partial class UniversalRenderer : DataModel
    {
        public bool                                     M_Clustering                            { get; set; }
        public DepthOnlyPass?                           M_DepthPrepass                          { get; set; }
        public DepthNormalOnlyPass?                     M_DepthNormalPrepass                    { get; set; }
        public CopyDepthPass?                           M_PrimedDepthCopyPass                   { get; set; }
        public MotionVectorRenderPass?                  M_MotionVectorPass                      { get; set; }
        public MainLightShadowCasterPass?               M_MainLightShadowCasterPass             { get; set; }
        public AdditionalLightsShadowCasterPass?        M_AdditionalLightsShadowCasterPass      { get; set; }
        public GBufferPass?                             M_GBufferPass                           { get; set; }
        public CopyDepthPass?                           M_GBufferCopyDepthPass                  { get; set; }
        public DeferredPass?                            M_DeferredPass                          { get; set; }
        public DrawObjectsPass?                         M_RenderOpaqueForwardOnlyPass           { get; set; }
        public DrawObjectsPass?                         M_RenderOpaqueForwardPass               { get; set; }
        public DrawObjectsWithRenderingLayersPass?      M_RenderOpaqueForwardWithRenderingLayersPass { get; set; }
        public DrawSkyboxPass?                          M_DrawSkyboxPass                        { get; set; }
        public CopyDepthPass?                           M_CopyDepthPass                         { get; set; }
        public CopyColorPass?                           M_CopyColorPass                         { get; set; }
        public TransparentSettingsPass?                 M_TransparentSettingsPass               { get; set; }
        public DrawObjectsPass?                         M_RenderTransparentForwardPass          { get; set; }
        public InvokeOnRenderObjectCallbackPass?        M_OnRenderObjectCallbackPass            { get; set; }
        public FinalBlitPass?                           M_FinalBlitPass                         { get; set; }
        public CapturePass?                             M_CapturePass                           { get; set; }
        public DrawScreenSpaceUIPass?                   M_DrawOffscreenUIPass                   { get; set; }
        public DrawScreenSpaceUIPass?                   M_DrawOverlayUIPass                     { get; set; }
        public RenderTargetBufferSystem?                M_ColorBufferSystem                     { get; set; }
        public RTHandle?                                M_ActiveCameraColorAttachment           { get; set; }
        public RTHandle?                                M_ColorFrontBuffer                      { get; set; }
        public RTHandle?                                M_ActiveCameraDepthAttachment           { get; set; }
        public RTHandle?                                M_CameraDepthAttachment                 { get; set; }
        public RTHandle?                                M_XRTargetHandleAlias                   { get; set; }
        public RTHandle?                                M_DepthTexture                          { get; set; }
        public RTHandle?                                M_NormalsTexture                        { get; set; }
        public RTHandle?                                M_DecalLayersTexture                    { get; set; }
        public RTHandle?                                M_OpaqueColor                           { get; set; }
        public RTHandle?                                M_MotionVectorColor                     { get; set; }
        public RTHandle?                                M_MotionVectorDepth                     { get; set; }
        public ForwardLights?                           M_ForwardLights                         { get; set; }
        public DeferredLights?                          M_DeferredLights                        { get; set; }
        public RenderingMode                            M_RenderingMode                         { get; set; }
        public DepthPrimingMode                         M_DepthPrimingMode                      { get; set; }
        public CopyDepthMode                            M_CopyDepthMode                         { get; set; }
        public bool                                     M_DepthPrimingRecommended               { get; set; }
        public StencilState                             M_DefaultStencilState                   { get; set; }
        public LightCookieManager?                      M_LightCookieManager                    { get; set; }
        public IntermediateTextureMode                  M_IntermediateTextureMode               { get; set; }
        public Material?                                M_BlitMaterial                          { get; set; }
        public Material?                                M_BlitHDRMaterial                       { get; set; }
        public Material?                                M_CopyDepthMaterial                     { get; set; }
        public Material?                                M_SamplingMaterial                      { get; set; }
        public Material?                                M_StencilDeferredMaterial               { get; set; }
        public Material?                                M_CameraMotionVecMaterial               { get; set; }
        public Material?                                M_ObjectMotionVecMaterial               { get; set; }
        public PostProcessPasses                        M_PostProcessPasses                     { get; set; }
        public RTHandle?                                M_RenderGraphCameraDepthHandle          { get; set; }
        public TextureHandle                            M_ActiveRenderGraphColor                { get; set; }
        public TextureHandle                            M_ActiveRenderGraphDepth                { get; set; }
        public bool                                     M_TargetIsBackbuffer                    { get; set; }
        public RenderGraphFrameResources?               FrameResources                          { get; set; }
        public bool                                     M_UseIntermediateTexture                { get; set; }

        public static UniversalRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniversalRenderer() { Pointer= p0 };

            value.M_Clustering                              = GetBool(new IntPtr(p + 0x1A8)); // 0x1A8 M_Clustering                ( ModelPrimitiveType bool bool bool Bool )
            value.M_DepthPrepass                            = GetObject<DepthOnlyPass>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.DepthOnlyPass.FromPointer); // 0x1B0 M_DepthPrepass              ( ModelClassType DepthOnlyPass DepthOnlyPass DepthOnlyPass Pointer )
            value.M_DepthNormalPrepass                      = GetObject<DepthNormalOnlyPass>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.DepthNormalOnlyPass.FromPointer); // 0x1B8 M_DepthNormalPrepass        ( ModelClassType DepthNormalOnlyPass DepthNormalOnlyPass DepthNormalOnlyPass Pointer )
            value.M_PrimedDepthCopyPass                     = GetObject<CopyDepthPass>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.CopyDepthPass.FromPointer); // 0x1C0 M_PrimedDepthCopyPass       ( ModelClassType CopyDepthPass CopyDepthPass CopyDepthPass Pointer )
            value.M_MotionVectorPass                        = GetObject<MotionVectorRenderPass>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.MotionVectorRenderPass.FromPointer); // 0x1C8 M_MotionVectorPass          ( ModelClassType MotionVectorRenderPass MotionVectorRenderPass MotionVectorRenderPass Pointer )
            value.M_MainLightShadowCasterPass               = GetObject<MainLightShadowCasterPass>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.MainLightShadowCasterPass.FromPointer); // 0x1D0 M_MainLightShadowCasterPass ( ModelClassType MainLightShadowCasterPass MainLightShadowCasterPass MainLightShadowCasterPass Pointer )
            value.M_AdditionalLightsShadowCasterPass        = GetObject<AdditionalLightsShadowCasterPass>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.AdditionalLightsShadowCasterPass.FromPointer); // 0x1D8 M_AdditionalLightsShadowCasterPass ( ModelClassType AdditionalLightsShadowCasterPass AdditionalLightsShadowCasterPass AdditionalLightsShadowCasterPass Pointer )
            value.M_GBufferPass                             = GetObject<GBufferPass>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.GBufferPass.FromPointer); // 0x1E0 M_GBufferPass               ( ModelClassType GBufferPass GBufferPass GBufferPass Pointer )
            value.M_GBufferCopyDepthPass                    = GetObject<CopyDepthPass>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.CopyDepthPass.FromPointer); // 0x1E8 M_GBufferCopyDepthPass      ( ModelClassType CopyDepthPass CopyDepthPass CopyDepthPass Pointer )
            value.M_DeferredPass                            = GetObject<DeferredPass>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.DeferredPass.FromPointer); // 0x1F0 M_DeferredPass              ( ModelClassType DeferredPass DeferredPass DeferredPass Pointer )
            value.M_RenderOpaqueForwardOnlyPass             = GetObject<DrawObjectsPass>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.DrawObjectsPass.FromPointer); // 0x1F8 M_RenderOpaqueForwardOnlyPass ( ModelClassType DrawObjectsPass DrawObjectsPass DrawObjectsPass Pointer )
            value.M_RenderOpaqueForwardPass                 = GetObject<DrawObjectsPass>(new IntPtr(p + 0x200), ReversePrism.DataModels.DrawObjectsPass.FromPointer); // 0x200 M_RenderOpaqueForwardPass   ( ModelClassType DrawObjectsPass DrawObjectsPass DrawObjectsPass Pointer )
            value.M_RenderOpaqueForwardWithRenderingLayersPass = GetObject<DrawObjectsWithRenderingLayersPass>(new IntPtr(p + 0x208), ReversePrism.DataModels.DrawObjectsWithRenderingLayersPass.FromPointer); // 0x208 M_RenderOpaqueForwardWithRenderingLayersPass ( ModelClassType DrawObjectsWithRenderingLayersPass DrawObjectsWithRenderingLayersPass DrawObjectsWithRenderingLayersPass Pointer )
            value.M_DrawSkyboxPass                          = GetObject<DrawSkyboxPass>(new IntPtr(p + 0x210), ReversePrism.DataModels.DrawSkyboxPass.FromPointer); // 0x210 M_DrawSkyboxPass            ( ModelClassType DrawSkyboxPass DrawSkyboxPass DrawSkyboxPass Pointer )
            value.M_CopyDepthPass                           = GetObject<CopyDepthPass>(new IntPtr(p + 0x218), ReversePrism.DataModels.CopyDepthPass.FromPointer); // 0x218 M_CopyDepthPass             ( ModelClassType CopyDepthPass CopyDepthPass CopyDepthPass Pointer )
            value.M_CopyColorPass                           = GetObject<CopyColorPass>(new IntPtr(p + 0x220), ReversePrism.DataModels.CopyColorPass.FromPointer); // 0x220 M_CopyColorPass             ( ModelClassType CopyColorPass CopyColorPass CopyColorPass Pointer )
            value.M_TransparentSettingsPass                 = GetObject<TransparentSettingsPass>(new IntPtr(p + 0x228), ReversePrism.DataModels.TransparentSettingsPass.FromPointer); // 0x228 M_TransparentSettingsPass   ( ModelClassType TransparentSettingsPass TransparentSettingsPass TransparentSettingsPass Pointer )
            value.M_RenderTransparentForwardPass            = GetObject<DrawObjectsPass>(new IntPtr(p + 0x230), ReversePrism.DataModels.DrawObjectsPass.FromPointer); // 0x230 M_RenderTransparentForwardPass ( ModelClassType DrawObjectsPass DrawObjectsPass DrawObjectsPass Pointer )
            value.M_OnRenderObjectCallbackPass              = GetObject<InvokeOnRenderObjectCallbackPass>(new IntPtr(p + 0x238), ReversePrism.DataModels.InvokeOnRenderObjectCallbackPass.FromPointer); // 0x238 M_OnRenderObjectCallbackPass ( ModelClassType InvokeOnRenderObjectCallbackPass InvokeOnRenderObjectCallbackPass InvokeOnRenderObjectCallbackPass Pointer )
            value.M_FinalBlitPass                           = GetObject<FinalBlitPass>(new IntPtr(p + 0x240), ReversePrism.DataModels.FinalBlitPass.FromPointer); // 0x240 M_FinalBlitPass             ( ModelClassType FinalBlitPass FinalBlitPass FinalBlitPass Pointer )
            value.M_CapturePass                             = GetObject<CapturePass>(new IntPtr(p + 0x248), ReversePrism.DataModels.CapturePass.FromPointer); // 0x248 M_CapturePass               ( ModelClassType CapturePass CapturePass CapturePass Pointer )
            value.M_DrawOffscreenUIPass                     = GetObject<DrawScreenSpaceUIPass>(new IntPtr(p + 0x250), ReversePrism.DataModels.DrawScreenSpaceUIPass.FromPointer); // 0x250 M_DrawOffscreenUIPass       ( ModelClassType DrawScreenSpaceUIPass DrawScreenSpaceUIPass DrawScreenSpaceUIPass Pointer )
            value.M_DrawOverlayUIPass                       = GetObject<DrawScreenSpaceUIPass>(new IntPtr(p + 0x258), ReversePrism.DataModels.DrawScreenSpaceUIPass.FromPointer); // 0x258 M_DrawOverlayUIPass         ( ModelClassType DrawScreenSpaceUIPass DrawScreenSpaceUIPass DrawScreenSpaceUIPass Pointer )
            value.M_ColorBufferSystem                       = GetObject<RenderTargetBufferSystem>(new IntPtr(p + 0x260), ReversePrism.DataModels.RenderTargetBufferSystem.FromPointer); // 0x260 M_ColorBufferSystem         ( ModelClassType RenderTargetBufferSystem RenderTargetBufferSystem RenderTargetBufferSystem Pointer )
            value.M_ActiveCameraColorAttachment             = GetObject<RTHandle>(new IntPtr(p + 0x268), ReversePrism.DataModels.RTHandle.FromPointer); // 0x268 M_ActiveCameraColorAttachment ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_ColorFrontBuffer                        = GetObject<RTHandle>(new IntPtr(p + 0x270), ReversePrism.DataModels.RTHandle.FromPointer); // 0x270 M_ColorFrontBuffer          ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_ActiveCameraDepthAttachment             = GetObject<RTHandle>(new IntPtr(p + 0x278), ReversePrism.DataModels.RTHandle.FromPointer); // 0x278 M_ActiveCameraDepthAttachment ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_CameraDepthAttachment                   = GetObject<RTHandle>(new IntPtr(p + 0x280), ReversePrism.DataModels.RTHandle.FromPointer); // 0x280 M_CameraDepthAttachment     ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_XRTargetHandleAlias                     = GetObject<RTHandle>(new IntPtr(p + 0x288), ReversePrism.DataModels.RTHandle.FromPointer); // 0x288 M_XRTargetHandleAlias       ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_DepthTexture                            = GetObject<RTHandle>(new IntPtr(p + 0x290), ReversePrism.DataModels.RTHandle.FromPointer); // 0x290 M_DepthTexture              ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_NormalsTexture                          = GetObject<RTHandle>(new IntPtr(p + 0x298), ReversePrism.DataModels.RTHandle.FromPointer); // 0x298 M_NormalsTexture            ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_DecalLayersTexture                      = GetObject<RTHandle>(new IntPtr(p + 0x2A0), ReversePrism.DataModels.RTHandle.FromPointer); // 0x2A0 M_DecalLayersTexture        ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_OpaqueColor                             = GetObject<RTHandle>(new IntPtr(p + 0x2A8), ReversePrism.DataModels.RTHandle.FromPointer); // 0x2A8 M_OpaqueColor               ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_MotionVectorColor                       = GetObject<RTHandle>(new IntPtr(p + 0x2B0), ReversePrism.DataModels.RTHandle.FromPointer); // 0x2B0 M_MotionVectorColor         ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_MotionVectorDepth                       = GetObject<RTHandle>(new IntPtr(p + 0x2B8), ReversePrism.DataModels.RTHandle.FromPointer); // 0x2B8 M_MotionVectorDepth         ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_ForwardLights                           = GetObject<ForwardLights>(new IntPtr(p + 0x2C0), ReversePrism.DataModels.ForwardLights.FromPointer); // 0x2C0 M_ForwardLights             ( ModelClassType ForwardLights ForwardLights ForwardLights Pointer )
            value.M_DeferredLights                          = GetObject<DeferredLights>(new IntPtr(p + 0x2C8), ReversePrism.DataModels.DeferredLights.FromPointer); // 0x2C8 M_DeferredLights            ( ModelClassType DeferredLights DeferredLights DeferredLights Pointer )
            value.M_RenderingMode                           = (RenderingMode)GetInt32(new IntPtr(p + 0x2D0)); // 0x2D0 M_RenderingMode             ( ModelEnumType RenderingMode RenderingMode RenderingMode Int32 )
            value.M_DepthPrimingMode                        = (DepthPrimingMode)GetInt32(new IntPtr(p + 0x2D4)); // 0x2D4 M_DepthPrimingMode          ( ModelEnumType DepthPrimingMode DepthPrimingMode DepthPrimingMode Int32 )
            value.M_CopyDepthMode                           = (CopyDepthMode)GetInt32(new IntPtr(p + 0x2D8)); // 0x2D8 M_CopyDepthMode             ( ModelEnumType CopyDepthMode CopyDepthMode CopyDepthMode Int32 )
            value.M_DepthPrimingRecommended                 = GetBool(new IntPtr(p + 0x2DC)); // 0x2DC M_DepthPrimingRecommended   ( ModelPrimitiveType bool bool bool Bool )
            value.M_DefaultStencilState                     = (StencilState)GetInt32(new IntPtr(p + 0x2DD)); // 0x2DD M_DefaultStencilState       ( ModelEnumType StencilState StencilState StencilState Int32 )
            value.M_LightCookieManager                      = GetObject<LightCookieManager>(new IntPtr(p + 0x2F0), ReversePrism.DataModels.LightCookieManager.FromPointer); // 0x2F0 M_LightCookieManager        ( ModelClassType LightCookieManager LightCookieManager LightCookieManager Pointer )
            value.M_IntermediateTextureMode                 = (IntermediateTextureMode)GetInt32(new IntPtr(p + 0x2F8)); // 0x2F8 M_IntermediateTextureMode   ( ModelEnumType IntermediateTextureMode IntermediateTextureMode IntermediateTextureMode Int32 )
            value.M_BlitMaterial                            = GetObject<Material>(new IntPtr(p + 0x300), ReversePrism.DataModels.Material.FromPointer); // 0x300 M_BlitMaterial              ( ModelClassType Material Material Material Pointer )
            value.M_BlitHDRMaterial                         = GetObject<Material>(new IntPtr(p + 0x308), ReversePrism.DataModels.Material.FromPointer); // 0x308 M_BlitHDRMaterial           ( ModelClassType Material Material Material Pointer )
            value.M_CopyDepthMaterial                       = GetObject<Material>(new IntPtr(p + 0x310), ReversePrism.DataModels.Material.FromPointer); // 0x310 M_CopyDepthMaterial         ( ModelClassType Material Material Material Pointer )
            value.M_SamplingMaterial                        = GetObject<Material>(new IntPtr(p + 0x318), ReversePrism.DataModels.Material.FromPointer); // 0x318 M_SamplingMaterial          ( ModelClassType Material Material Material Pointer )
            value.M_StencilDeferredMaterial                 = GetObject<Material>(new IntPtr(p + 0x320), ReversePrism.DataModels.Material.FromPointer); // 0x320 M_StencilDeferredMaterial   ( ModelClassType Material Material Material Pointer )
            value.M_CameraMotionVecMaterial                 = GetObject<Material>(new IntPtr(p + 0x328), ReversePrism.DataModels.Material.FromPointer); // 0x328 M_CameraMotionVecMaterial   ( ModelClassType Material Material Material Pointer )
            value.M_ObjectMotionVecMaterial                 = GetObject<Material>(new IntPtr(p + 0x330), ReversePrism.DataModels.Material.FromPointer); // 0x330 M_ObjectMotionVecMaterial   ( ModelClassType Material Material Material Pointer )
            value.M_PostProcessPasses                       = (PostProcessPasses)GetInt32(new IntPtr(p + 0x338)); // 0x338 M_PostProcessPasses         ( ModelEnumType PostProcessPasses PostProcessPasses PostProcessPasses Int32 )
            value.M_RenderGraphCameraDepthHandle            = GetObject<RTHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.RTHandle.FromPointer); // 0x10 M_RenderGraphCameraDepthHandle ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_ActiveRenderGraphColor                  = (TextureHandle)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_ActiveRenderGraphColor    ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.M_ActiveRenderGraphDepth                  = (TextureHandle)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_ActiveRenderGraphDepth    ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.M_TargetIsBackbuffer                      = GetBool(new IntPtr(p + 0x378)); // 0x378 M_TargetIsBackbuffer        ( ModelPrimitiveType bool bool bool Bool )
            value.FrameResources                            = GetObject<RenderGraphFrameResources>(new IntPtr(p + 0x380), ReversePrism.DataModels.RenderGraphFrameResources.FromPointer); // 0x380 FrameResources              ( ModelClassType RenderGraphFrameResources RenderGraphFrameResources RenderGraphFrameResources Pointer )
            value.M_UseIntermediateTexture                  = GetBool(new IntPtr(p + 0x028)); // 0x28 M_UseIntermediateTexture    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
