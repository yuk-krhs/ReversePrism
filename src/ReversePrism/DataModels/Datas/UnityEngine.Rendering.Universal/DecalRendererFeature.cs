using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <sharedDecalEntityManager>k__BackingField SharedDecalEntityManager IL2CPP_TYPE_CLASS
    // 020 M_Settings                               ModelClassType DecalSettings DecalSettings DecalSettings Pointer
    // 028 M_CopyDepthPS                            ModelClassType Shader Shader Shader Pointer
    // 030 M_DBufferClear                           ModelClassType Shader Shader Shader Pointer
    // 038 M_Technique                              ModelEnumType DecalTechnique DecalTechnique DecalTechnique Int32
    // 040 M_DBufferSettings                        ModelClassType DBufferSettings DBufferSettings DBufferSettings Pointer
    // 048 M_ScreenSpaceSettings                    ModelClassType DecalScreenSpaceSettings DecalScreenSpaceSettings DecalScreenSpaceSettings Pointer
    // 050 M_RecreateSystems                        ModelPrimitiveType bool bool bool Bool
    // 058 M_CopyDepthPass                          ModelClassType CopyDepthPass CopyDepthPass CopyDepthPass Pointer
    // 060 M_DecalPreviewPass                       ModelClassType DecalPreviewPass DecalPreviewPass DecalPreviewPass Pointer
    // 068 M_CopyDepthMaterial                      ModelClassType Material Material Material Pointer
    // 070 M_DecalEntityManager                     ModelClassType DecalEntityManager DecalEntityManager DecalEntityManager Pointer
    // 078 M_DecalUpdateCachedSystem                ModelClassType DecalUpdateCachedSystem DecalUpdateCachedSystem DecalUpdateCachedSystem Pointer
    // 080 M_DecalUpdateCullingGroupSystem          ModelClassType DecalUpdateCullingGroupSystem DecalUpdateCullingGroupSystem DecalUpdateCullingGroupSystem Pointer
    // 088 M_DecalUpdateCulledSystem                ModelClassType DecalUpdateCulledSystem DecalUpdateCulledSystem DecalUpdateCulledSystem Pointer
    // 090 M_DecalCreateDrawCallSystem              ModelClassType DecalCreateDrawCallSystem DecalCreateDrawCallSystem DecalCreateDrawCallSystem Pointer
    // 098 M_DrawErrorSystem                        ModelClassType DecalDrawErrorSystem DecalDrawErrorSystem DecalDrawErrorSystem Pointer
    // 0A0 M_DBufferRenderPass                      ModelClassType DBufferRenderPass DBufferRenderPass DBufferRenderPass Pointer
    // 0A8 M_ForwardEmissivePass                    ModelClassType DecalForwardEmissivePass DecalForwardEmissivePass DecalForwardEmissivePass Pointer
    // 0B0 M_DecalDrawDBufferSystem                 ModelClassType DecalDrawDBufferSystem DecalDrawDBufferSystem DecalDrawDBufferSystem Pointer
    // 0B8 M_DecalDrawForwardEmissiveSystem         ModelClassType DecalDrawFowardEmissiveSystem DecalDrawFowardEmissiveSystem DecalDrawFowardEmissiveSystem Pointer
    // 0C0 M_DBufferClearMaterial                   ModelClassType Material Material Material Pointer
    // 0C8 M_ScreenSpaceDecalRenderPass             ModelClassType DecalScreenSpaceRenderPass DecalScreenSpaceRenderPass DecalScreenSpaceRenderPass Pointer
    // 0D0 M_DecalDrawScreenSpaceSystem             ModelClassType DecalDrawScreenSpaceSystem DecalDrawScreenSpaceSystem DecalDrawScreenSpaceSystem Pointer
    // 0D8 M_DecalSkipCulledSystem                  ModelClassType DecalSkipCulledSystem DecalSkipCulledSystem DecalSkipCulledSystem Pointer
    // 0E0 M_GBufferRenderPass                      ModelClassType DecalGBufferRenderPass DecalGBufferRenderPass DecalGBufferRenderPass Pointer
    // 0E8 M_DrawGBufferSystem                      ModelClassType DecalDrawGBufferSystem DecalDrawGBufferSystem DecalDrawGBufferSystem Pointer
    // 0F0 M_DeferredLights                         ModelClassType DeferredLights DeferredLights DeferredLights Pointer
    public partial class DecalRendererFeature : DataModel
    {
        public DecalSettings?                           M_Settings                              { get; set; }
        public Shader?                                  M_CopyDepthPS                           { get; set; }
        public Shader?                                  M_DBufferClear                          { get; set; }
        public DecalTechnique                           M_Technique                             { get; set; }
        public DBufferSettings?                         M_DBufferSettings                       { get; set; }
        public DecalScreenSpaceSettings?                M_ScreenSpaceSettings                   { get; set; }
        public bool                                     M_RecreateSystems                       { get; set; }
        public CopyDepthPass?                           M_CopyDepthPass                         { get; set; }
        public DecalPreviewPass?                        M_DecalPreviewPass                      { get; set; }
        public Material?                                M_CopyDepthMaterial                     { get; set; }
        public DecalEntityManager?                      M_DecalEntityManager                    { get; set; }
        public DecalUpdateCachedSystem?                 M_DecalUpdateCachedSystem               { get; set; }
        public DecalUpdateCullingGroupSystem?           M_DecalUpdateCullingGroupSystem         { get; set; }
        public DecalUpdateCulledSystem?                 M_DecalUpdateCulledSystem               { get; set; }
        public DecalCreateDrawCallSystem?               M_DecalCreateDrawCallSystem             { get; set; }
        public DecalDrawErrorSystem?                    M_DrawErrorSystem                       { get; set; }
        public DBufferRenderPass?                       M_DBufferRenderPass                     { get; set; }
        public DecalForwardEmissivePass?                M_ForwardEmissivePass                   { get; set; }
        public DecalDrawDBufferSystem?                  M_DecalDrawDBufferSystem                { get; set; }
        public DecalDrawFowardEmissiveSystem?           M_DecalDrawForwardEmissiveSystem        { get; set; }
        public Material?                                M_DBufferClearMaterial                  { get; set; }
        public DecalScreenSpaceRenderPass?              M_ScreenSpaceDecalRenderPass            { get; set; }
        public DecalDrawScreenSpaceSystem?              M_DecalDrawScreenSpaceSystem            { get; set; }
        public DecalSkipCulledSystem?                   M_DecalSkipCulledSystem                 { get; set; }
        public DecalGBufferRenderPass?                  M_GBufferRenderPass                     { get; set; }
        public DecalDrawGBufferSystem?                  M_DrawGBufferSystem                     { get; set; }
        public DeferredLights?                          M_DeferredLights                        { get; set; }

        public static DecalRendererFeature? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalRendererFeature() { Pointer= p0 };

            value.M_Settings                                = GetObject<DecalSettings>(new IntPtr(p + 0x020), ReversePrism.DataModels.DecalSettings.FromPointer); // 0x20 M_Settings                  ( ModelClassType DecalSettings DecalSettings DecalSettings Pointer )
            value.M_CopyDepthPS                             = GetObject<Shader>(new IntPtr(p + 0x028), ReversePrism.DataModels.Shader.FromPointer); // 0x28 M_CopyDepthPS               ( ModelClassType Shader Shader Shader Pointer )
            value.M_DBufferClear                            = GetObject<Shader>(new IntPtr(p + 0x030), ReversePrism.DataModels.Shader.FromPointer); // 0x30 M_DBufferClear              ( ModelClassType Shader Shader Shader Pointer )
            value.M_Technique                               = (DecalTechnique)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_Technique                 ( ModelEnumType DecalTechnique DecalTechnique DecalTechnique Int32 )
            value.M_DBufferSettings                         = GetObject<DBufferSettings>(new IntPtr(p + 0x040), ReversePrism.DataModels.DBufferSettings.FromPointer); // 0x40 M_DBufferSettings           ( ModelClassType DBufferSettings DBufferSettings DBufferSettings Pointer )
            value.M_ScreenSpaceSettings                     = GetObject<DecalScreenSpaceSettings>(new IntPtr(p + 0x048), ReversePrism.DataModels.DecalScreenSpaceSettings.FromPointer); // 0x48 M_ScreenSpaceSettings       ( ModelClassType DecalScreenSpaceSettings DecalScreenSpaceSettings DecalScreenSpaceSettings Pointer )
            value.M_RecreateSystems                         = GetBool(new IntPtr(p + 0x050)); // 0x50 M_RecreateSystems           ( ModelPrimitiveType bool bool bool Bool )
            value.M_CopyDepthPass                           = GetObject<CopyDepthPass>(new IntPtr(p + 0x058), ReversePrism.DataModels.CopyDepthPass.FromPointer); // 0x58 M_CopyDepthPass             ( ModelClassType CopyDepthPass CopyDepthPass CopyDepthPass Pointer )
            value.M_DecalPreviewPass                        = GetObject<DecalPreviewPass>(new IntPtr(p + 0x060), ReversePrism.DataModels.DecalPreviewPass.FromPointer); // 0x60 M_DecalPreviewPass          ( ModelClassType DecalPreviewPass DecalPreviewPass DecalPreviewPass Pointer )
            value.M_CopyDepthMaterial                       = GetObject<Material>(new IntPtr(p + 0x068), ReversePrism.DataModels.Material.FromPointer); // 0x68 M_CopyDepthMaterial         ( ModelClassType Material Material Material Pointer )
            value.M_DecalEntityManager                      = GetObject<DecalEntityManager>(new IntPtr(p + 0x070), ReversePrism.DataModels.DecalEntityManager.FromPointer); // 0x70 M_DecalEntityManager        ( ModelClassType DecalEntityManager DecalEntityManager DecalEntityManager Pointer )
            value.M_DecalUpdateCachedSystem                 = GetObject<DecalUpdateCachedSystem>(new IntPtr(p + 0x078), ReversePrism.DataModels.DecalUpdateCachedSystem.FromPointer); // 0x78 M_DecalUpdateCachedSystem   ( ModelClassType DecalUpdateCachedSystem DecalUpdateCachedSystem DecalUpdateCachedSystem Pointer )
            value.M_DecalUpdateCullingGroupSystem           = GetObject<DecalUpdateCullingGroupSystem>(new IntPtr(p + 0x080), ReversePrism.DataModels.DecalUpdateCullingGroupSystem.FromPointer); // 0x80 M_DecalUpdateCullingGroupSystem ( ModelClassType DecalUpdateCullingGroupSystem DecalUpdateCullingGroupSystem DecalUpdateCullingGroupSystem Pointer )
            value.M_DecalUpdateCulledSystem                 = GetObject<DecalUpdateCulledSystem>(new IntPtr(p + 0x088), ReversePrism.DataModels.DecalUpdateCulledSystem.FromPointer); // 0x88 M_DecalUpdateCulledSystem   ( ModelClassType DecalUpdateCulledSystem DecalUpdateCulledSystem DecalUpdateCulledSystem Pointer )
            value.M_DecalCreateDrawCallSystem               = GetObject<DecalCreateDrawCallSystem>(new IntPtr(p + 0x090), ReversePrism.DataModels.DecalCreateDrawCallSystem.FromPointer); // 0x90 M_DecalCreateDrawCallSystem ( ModelClassType DecalCreateDrawCallSystem DecalCreateDrawCallSystem DecalCreateDrawCallSystem Pointer )
            value.M_DrawErrorSystem                         = GetObject<DecalDrawErrorSystem>(new IntPtr(p + 0x098), ReversePrism.DataModels.DecalDrawErrorSystem.FromPointer); // 0x98 M_DrawErrorSystem           ( ModelClassType DecalDrawErrorSystem DecalDrawErrorSystem DecalDrawErrorSystem Pointer )
            value.M_DBufferRenderPass                       = GetObject<DBufferRenderPass>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.DBufferRenderPass.FromPointer); // 0xA0 M_DBufferRenderPass         ( ModelClassType DBufferRenderPass DBufferRenderPass DBufferRenderPass Pointer )
            value.M_ForwardEmissivePass                     = GetObject<DecalForwardEmissivePass>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DecalForwardEmissivePass.FromPointer); // 0xA8 M_ForwardEmissivePass       ( ModelClassType DecalForwardEmissivePass DecalForwardEmissivePass DecalForwardEmissivePass Pointer )
            value.M_DecalDrawDBufferSystem                  = GetObject<DecalDrawDBufferSystem>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.DecalDrawDBufferSystem.FromPointer); // 0xB0 M_DecalDrawDBufferSystem    ( ModelClassType DecalDrawDBufferSystem DecalDrawDBufferSystem DecalDrawDBufferSystem Pointer )
            value.M_DecalDrawForwardEmissiveSystem          = GetObject<DecalDrawFowardEmissiveSystem>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.DecalDrawFowardEmissiveSystem.FromPointer); // 0xB8 M_DecalDrawForwardEmissiveSystem ( ModelClassType DecalDrawFowardEmissiveSystem DecalDrawFowardEmissiveSystem DecalDrawFowardEmissiveSystem Pointer )
            value.M_DBufferClearMaterial                    = GetObject<Material>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Material.FromPointer); // 0xC0 M_DBufferClearMaterial      ( ModelClassType Material Material Material Pointer )
            value.M_ScreenSpaceDecalRenderPass              = GetObject<DecalScreenSpaceRenderPass>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.DecalScreenSpaceRenderPass.FromPointer); // 0xC8 M_ScreenSpaceDecalRenderPass ( ModelClassType DecalScreenSpaceRenderPass DecalScreenSpaceRenderPass DecalScreenSpaceRenderPass Pointer )
            value.M_DecalDrawScreenSpaceSystem              = GetObject<DecalDrawScreenSpaceSystem>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.DecalDrawScreenSpaceSystem.FromPointer); // 0xD0 M_DecalDrawScreenSpaceSystem ( ModelClassType DecalDrawScreenSpaceSystem DecalDrawScreenSpaceSystem DecalDrawScreenSpaceSystem Pointer )
            value.M_DecalSkipCulledSystem                   = GetObject<DecalSkipCulledSystem>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.DecalSkipCulledSystem.FromPointer); // 0xD8 M_DecalSkipCulledSystem     ( ModelClassType DecalSkipCulledSystem DecalSkipCulledSystem DecalSkipCulledSystem Pointer )
            value.M_GBufferRenderPass                       = GetObject<DecalGBufferRenderPass>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.DecalGBufferRenderPass.FromPointer); // 0xE0 M_GBufferRenderPass         ( ModelClassType DecalGBufferRenderPass DecalGBufferRenderPass DecalGBufferRenderPass Pointer )
            value.M_DrawGBufferSystem                       = GetObject<DecalDrawGBufferSystem>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.DecalDrawGBufferSystem.FromPointer); // 0xE8 M_DrawGBufferSystem         ( ModelClassType DecalDrawGBufferSystem DecalDrawGBufferSystem DecalDrawGBufferSystem Pointer )
            value.M_DeferredLights                          = GetObject<DeferredLights>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.DeferredLights.FromPointer); // 0xF0 M_DeferredLights            ( ModelClassType DeferredLights DeferredLights DeferredLights Pointer )

            return value;
        }
    }
}
