using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_DepthBufferBits                        int IL2CPP_TYPE_I4
    // 000 k_FinalBlitPassQueueOffset               int IL2CPP_TYPE_I4
    // 000 k_AfterFinalBlitPassQueueOffset          int IL2CPP_TYPE_I4
    // 1A8 M_Render2DLightingPass                   ModelClassType Render2DLightingPass Render2DLightingPass Render2DLightingPass Pointer
    // 1B0 M_PixelPerfectBackgroundPass             ModelClassType PixelPerfectBackgroundPass PixelPerfectBackgroundPass PixelPerfectBackgroundPass Pointer
    // 1B8 M_UpscalePass                            ModelClassType UpscalePass UpscalePass UpscalePass Pointer
    // 1C0 M_FinalBlitPass                          ModelClassType FinalBlitPass FinalBlitPass FinalBlitPass Pointer
    // 1C8 M_DrawOffscreenUIPass                    ModelClassType DrawScreenSpaceUIPass DrawScreenSpaceUIPass DrawScreenSpaceUIPass Pointer
    // 1D0 M_DrawOverlayUIPass                      ModelClassType DrawScreenSpaceUIPass DrawScreenSpaceUIPass DrawScreenSpaceUIPass Pointer
    // 1D8 M_LightCullResult                        ModelClassType Light2DCullResult Light2DCullResult Light2DCullResult Pointer
    // 000 m_ProfilingSampler                       ProfilingSampler IL2CPP_TYPE_CLASS
    // 1E0 M_UseDepthStencilBuffer                  ModelPrimitiveType bool bool bool Bool
    // 1E1 M_CreateColorTexture                     ModelPrimitiveType bool bool bool Bool
    // 1E2 M_CreateDepthTexture                     ModelPrimitiveType bool bool bool Bool
    // 1E8 M_ColorTextureHandle                     ModelClassType RTHandle RTHandle RTHandle Pointer
    // 1F0 M_DepthTextureHandle                     ModelClassType RTHandle RTHandle RTHandle Pointer
    // 1F8 M_BlitMaterial                           ModelClassType Material Material Material Pointer
    // 200 M_BlitHDRMaterial                        ModelClassType Material Material Material Pointer
    // 208 M_SamplingMaterial                       ModelClassType Material Material Material Pointer
    // 210 M_Renderer2DData                         ModelClassType Renderer2DData Renderer2DData Renderer2DData Pointer
    // 218 M_PostProcessPasses                      ModelEnumType PostProcessPasses PostProcessPasses PostProcessPasses Int32
    public partial class Renderer2D : DataModel
    {
        public Render2DLightingPass?                    M_Render2DLightingPass                  { get; set; }
        public PixelPerfectBackgroundPass?              M_PixelPerfectBackgroundPass            { get; set; }
        public UpscalePass?                             M_UpscalePass                           { get; set; }
        public FinalBlitPass?                           M_FinalBlitPass                         { get; set; }
        public DrawScreenSpaceUIPass?                   M_DrawOffscreenUIPass                   { get; set; }
        public DrawScreenSpaceUIPass?                   M_DrawOverlayUIPass                     { get; set; }
        public Light2DCullResult?                       M_LightCullResult                       { get; set; }
        public bool                                     M_UseDepthStencilBuffer                 { get; set; }
        public bool                                     M_CreateColorTexture                    { get; set; }
        public bool                                     M_CreateDepthTexture                    { get; set; }
        public RTHandle?                                M_ColorTextureHandle                    { get; set; }
        public RTHandle?                                M_DepthTextureHandle                    { get; set; }
        public Material?                                M_BlitMaterial                          { get; set; }
        public Material?                                M_BlitHDRMaterial                       { get; set; }
        public Material?                                M_SamplingMaterial                      { get; set; }
        public Renderer2DData?                          M_Renderer2DData                        { get; set; }
        public PostProcessPasses                        M_PostProcessPasses                     { get; set; }

        public static Renderer2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Renderer2D() { Pointer= p0 };

            value.M_Render2DLightingPass                    = GetObject<Render2DLightingPass>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.Render2DLightingPass.FromPointer); // 0x1A8 M_Render2DLightingPass      ( ModelClassType Render2DLightingPass Render2DLightingPass Render2DLightingPass Pointer )
            value.M_PixelPerfectBackgroundPass              = GetObject<PixelPerfectBackgroundPass>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.PixelPerfectBackgroundPass.FromPointer); // 0x1B0 M_PixelPerfectBackgroundPass ( ModelClassType PixelPerfectBackgroundPass PixelPerfectBackgroundPass PixelPerfectBackgroundPass Pointer )
            value.M_UpscalePass                             = GetObject<UpscalePass>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.UpscalePass.FromPointer); // 0x1B8 M_UpscalePass               ( ModelClassType UpscalePass UpscalePass UpscalePass Pointer )
            value.M_FinalBlitPass                           = GetObject<FinalBlitPass>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.FinalBlitPass.FromPointer); // 0x1C0 M_FinalBlitPass             ( ModelClassType FinalBlitPass FinalBlitPass FinalBlitPass Pointer )
            value.M_DrawOffscreenUIPass                     = GetObject<DrawScreenSpaceUIPass>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.DrawScreenSpaceUIPass.FromPointer); // 0x1C8 M_DrawOffscreenUIPass       ( ModelClassType DrawScreenSpaceUIPass DrawScreenSpaceUIPass DrawScreenSpaceUIPass Pointer )
            value.M_DrawOverlayUIPass                       = GetObject<DrawScreenSpaceUIPass>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.DrawScreenSpaceUIPass.FromPointer); // 0x1D0 M_DrawOverlayUIPass         ( ModelClassType DrawScreenSpaceUIPass DrawScreenSpaceUIPass DrawScreenSpaceUIPass Pointer )
            value.M_LightCullResult                         = GetObject<Light2DCullResult>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.Light2DCullResult.FromPointer); // 0x1D8 M_LightCullResult           ( ModelClassType Light2DCullResult Light2DCullResult Light2DCullResult Pointer )
            value.M_UseDepthStencilBuffer                   = GetBool(new IntPtr(p + 0x1E0)); // 0x1E0 M_UseDepthStencilBuffer     ( ModelPrimitiveType bool bool bool Bool )
            value.M_CreateColorTexture                      = GetBool(new IntPtr(p + 0x1E1)); // 0x1E1 M_CreateColorTexture        ( ModelPrimitiveType bool bool bool Bool )
            value.M_CreateDepthTexture                      = GetBool(new IntPtr(p + 0x1E2)); // 0x1E2 M_CreateDepthTexture        ( ModelPrimitiveType bool bool bool Bool )
            value.M_ColorTextureHandle                      = GetObject<RTHandle>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.RTHandle.FromPointer); // 0x1E8 M_ColorTextureHandle        ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_DepthTextureHandle                      = GetObject<RTHandle>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.RTHandle.FromPointer); // 0x1F0 M_DepthTextureHandle        ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_BlitMaterial                            = GetObject<Material>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.Material.FromPointer); // 0x1F8 M_BlitMaterial              ( ModelClassType Material Material Material Pointer )
            value.M_BlitHDRMaterial                         = GetObject<Material>(new IntPtr(p + 0x200), ReversePrism.DataModels.Material.FromPointer); // 0x200 M_BlitHDRMaterial           ( ModelClassType Material Material Material Pointer )
            value.M_SamplingMaterial                        = GetObject<Material>(new IntPtr(p + 0x208), ReversePrism.DataModels.Material.FromPointer); // 0x208 M_SamplingMaterial          ( ModelClassType Material Material Material Pointer )
            value.M_Renderer2DData                          = GetObject<Renderer2DData>(new IntPtr(p + 0x210), ReversePrism.DataModels.Renderer2DData.FromPointer); // 0x210 M_Renderer2DData            ( ModelClassType Renderer2DData Renderer2DData Renderer2DData Pointer )
            value.M_PostProcessPasses                       = (PostProcessPasses)GetInt32(new IntPtr(p + 0x218)); // 0x218 M_PostProcessPasses         ( ModelEnumType PostProcessPasses PostProcessPasses PostProcessPasses Int32 )

            return value;
        }
    }
}
