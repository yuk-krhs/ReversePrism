using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_TransparencySortMode                   ModelEnumType TransparencySortMode TransparencySortMode TransparencySortMode Int32
    // 044 M_TransparencySortAxis                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 M_HDREmulationScale                      ModelPrimitiveType float float float Single
    // 054 M_LightRenderTextureScale                ModelPrimitiveType float float float Single
    // 058 M_LightBlendStyles                       ModelEnumListType Light2DBlendStyle[] Light2DBlendStyle[] List<Light2DBlendStyle> Pointer
    // 060 M_UseDepthStencilBuffer                  ModelPrimitiveType bool bool bool Bool
    // 061 M_UseCameraSortingLayersTexture          ModelPrimitiveType bool bool bool Bool
    // 064 M_CameraSortingLayersTextureBound        ModelPrimitiveType int int int Int32
    // 068 M_CameraSortingLayerDownsamplingMethod   ModelEnumType Downsampling Downsampling Downsampling Int32
    // 06C M_MaxLightRenderTextureCount             ModelPrimitiveType uint uint uint UInt32
    // 070 M_MaxShadowRenderTextureCount            ModelPrimitiveType uint uint uint UInt32
    // 078 M_ShapeLightShader                       ModelClassType Shader Shader Shader Pointer
    // 080 M_ShapeLightVolumeShader                 ModelClassType Shader Shader Shader Pointer
    // 088 M_PointLightShader                       ModelClassType Shader Shader Shader Pointer
    // 090 M_PointLightVolumeShader                 ModelClassType Shader Shader Shader Pointer
    // 098 M_CoreBlitShader                         ModelClassType Shader Shader Shader Pointer
    // 0A0 M_BlitHDROverlay                         ModelClassType Shader Shader Shader Pointer
    // 0A8 M_CoreBlitColorAndDepthPS                ModelClassType Shader Shader Shader Pointer
    // 0B0 M_SamplingShader                         ModelClassType Shader Shader Shader Pointer
    // 0B8 M_ProjectedShadowShader                  ModelClassType Shader Shader Shader Pointer
    // 0C0 M_SpriteShadowShader                     ModelClassType Shader Shader Shader Pointer
    // 0C8 M_SpriteUnshadowShader                   ModelClassType Shader Shader Shader Pointer
    // 0D0 M_GeometryUnshadowShader                 ModelClassType Shader Shader Shader Pointer
    // 0D8 M_FallbackErrorShader                    ModelClassType Shader Shader Shader Pointer
    // 0E0 M_PostProcessData                        ModelClassType PostProcessData PostProcessData PostProcessData Pointer
    // 0E8 M_FallOffLookup                          ModelClassType Texture2D Texture2D Texture2D Pointer
    // 0F0 <lightMaterials>k__BackingField          Dictionary`2<uint, Material> IL2CPP_TYPE_GENERICINST
    // 0F8 SpriteSelfShadowMaterial                 ModelClassListType Material[] Material[] List<Material> Pointer
    // 100 SpriteUnshadowMaterial                   ModelClassListType Material[] Material[] List<Material> Pointer
    // 108 GeometryUnshadowMaterial                 ModelClassListType Material[] Material[] List<Material> Pointer
    // 110 ProjectedShadowMaterial                  ModelClassListType Material[] Material[] List<Material> Pointer
    // 118 StencilOnlyShadowMaterial                ModelClassListType Material[] Material[] List<Material> Pointer
    // 120 IsNormalsRenderTargetValid               ModelPrimitiveType bool bool bool Bool
    // 124 NormalsRenderTargetScale                 ModelPrimitiveType float float float Single
    // 128 NormalsRenderTarget                      ModelClassType RTHandle RTHandle RTHandle Pointer
    // 130 NormalsRenderTargetId                    ModelPrimitiveType int int int Int32
    // 138 ShadowsRenderTarget                      ModelClassType RTHandle RTHandle RTHandle Pointer
    // 140 ShadowsRenderTargetId                    ModelPrimitiveType int int int Int32
    // 148 CameraSortingLayerRenderTarget           ModelClassType RTHandle RTHandle RTHandle Pointer
    // 150 CameraSortingLayerRenderTargetId         ModelPrimitiveType int int int Int32
    // 158 LightCullResult                          ModelClassType ILight2DCullResult ILight2DCullResult ILight2DCullResult Pointer
    public partial class Renderer2DData : DataModel
    {
        public TransparencySortMode                     M_TransparencySortMode                  { get; set; }
        public Vector3                                  M_TransparencySortAxis                  { get; set; }
        public float                                    M_HDREmulationScale                     { get; set; }
        public float                                    M_LightRenderTextureScale               { get; set; }
        public List<Light2DBlendStyle>?                 M_LightBlendStyles                      { get; set; }
        public bool                                     M_UseDepthStencilBuffer                 { get; set; }
        public bool                                     M_UseCameraSortingLayersTexture         { get; set; }
        public int                                      M_CameraSortingLayersTextureBound       { get; set; }
        public Downsampling                             M_CameraSortingLayerDownsamplingMethod  { get; set; }
        public uint                                     M_MaxLightRenderTextureCount            { get; set; }
        public uint                                     M_MaxShadowRenderTextureCount           { get; set; }
        public Shader?                                  M_ShapeLightShader                      { get; set; }
        public Shader?                                  M_ShapeLightVolumeShader                { get; set; }
        public Shader?                                  M_PointLightShader                      { get; set; }
        public Shader?                                  M_PointLightVolumeShader                { get; set; }
        public Shader?                                  M_CoreBlitShader                        { get; set; }
        public Shader?                                  M_BlitHDROverlay                        { get; set; }
        public Shader?                                  M_CoreBlitColorAndDepthPS               { get; set; }
        public Shader?                                  M_SamplingShader                        { get; set; }
        public Shader?                                  M_ProjectedShadowShader                 { get; set; }
        public Shader?                                  M_SpriteShadowShader                    { get; set; }
        public Shader?                                  M_SpriteUnshadowShader                  { get; set; }
        public Shader?                                  M_GeometryUnshadowShader                { get; set; }
        public Shader?                                  M_FallbackErrorShader                   { get; set; }
        public PostProcessData?                         M_PostProcessData                       { get; set; }
        public Texture2D?                               M_FallOffLookup                         { get; set; }
        public List<Material>?                          SpriteSelfShadowMaterial                { get; set; }
        public List<Material>?                          SpriteUnshadowMaterial                  { get; set; }
        public List<Material>?                          GeometryUnshadowMaterial                { get; set; }
        public List<Material>?                          ProjectedShadowMaterial                 { get; set; }
        public List<Material>?                          StencilOnlyShadowMaterial               { get; set; }
        public bool                                     IsNormalsRenderTargetValid              { get; set; }
        public float                                    NormalsRenderTargetScale                { get; set; }
        public RTHandle?                                NormalsRenderTarget                     { get; set; }
        public int                                      NormalsRenderTargetId                   { get; set; }
        public RTHandle?                                ShadowsRenderTarget                     { get; set; }
        public int                                      ShadowsRenderTargetId                   { get; set; }
        public RTHandle?                                CameraSortingLayerRenderTarget          { get; set; }
        public int                                      CameraSortingLayerRenderTargetId        { get; set; }
        public ILight2DCullResult?                      LightCullResult                         { get; set; }

        public static Renderer2DData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Renderer2DData() { Pointer= p0 };

            value.M_TransparencySortMode                    = (TransparencySortMode)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_TransparencySortMode      ( ModelEnumType TransparencySortMode TransparencySortMode TransparencySortMode Int32 )
            value.M_TransparencySortAxis                    = (Vector3)GetInt32(new IntPtr(p + 0x044)); // 0x44 M_TransparencySortAxis      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_HDREmulationScale                       = GetSingle(new IntPtr(p + 0x050)); // 0x50 M_HDREmulationScale         ( ModelPrimitiveType float float float Single )
            value.M_LightRenderTextureScale                 = GetSingle(new IntPtr(p + 0x054)); // 0x54 M_LightRenderTextureScale   ( ModelPrimitiveType float float float Single )
            value.M_LightBlendStyles                        = GetEnumList<Light2DBlendStyle>(new IntPtr(p + 0x058)); // 0x58 M_LightBlendStyles          ( ModelEnumListType Light2DBlendStyle[] Light2DBlendStyle[] List<Light2DBlendStyle> Pointer )
            value.M_UseDepthStencilBuffer                   = GetBool(new IntPtr(p + 0x060)); // 0x60 M_UseDepthStencilBuffer     ( ModelPrimitiveType bool bool bool Bool )
            value.M_UseCameraSortingLayersTexture           = GetBool(new IntPtr(p + 0x061)); // 0x61 M_UseCameraSortingLayersTexture ( ModelPrimitiveType bool bool bool Bool )
            value.M_CameraSortingLayersTextureBound         = GetInt32(new IntPtr(p + 0x064)); // 0x64 M_CameraSortingLayersTextureBound ( ModelPrimitiveType int int int Int32 )
            value.M_CameraSortingLayerDownsamplingMethod    = (Downsampling)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_CameraSortingLayerDownsamplingMethod ( ModelEnumType Downsampling Downsampling Downsampling Int32 )
            value.M_MaxLightRenderTextureCount              = GetUInt32(new IntPtr(p + 0x06C)); // 0x6C M_MaxLightRenderTextureCount ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_MaxShadowRenderTextureCount             = GetUInt32(new IntPtr(p + 0x070)); // 0x70 M_MaxShadowRenderTextureCount ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_ShapeLightShader                        = GetObject<Shader>(new IntPtr(p + 0x078), ReversePrism.DataModels.Shader.FromPointer); // 0x78 M_ShapeLightShader          ( ModelClassType Shader Shader Shader Pointer )
            value.M_ShapeLightVolumeShader                  = GetObject<Shader>(new IntPtr(p + 0x080), ReversePrism.DataModels.Shader.FromPointer); // 0x80 M_ShapeLightVolumeShader    ( ModelClassType Shader Shader Shader Pointer )
            value.M_PointLightShader                        = GetObject<Shader>(new IntPtr(p + 0x088), ReversePrism.DataModels.Shader.FromPointer); // 0x88 M_PointLightShader          ( ModelClassType Shader Shader Shader Pointer )
            value.M_PointLightVolumeShader                  = GetObject<Shader>(new IntPtr(p + 0x090), ReversePrism.DataModels.Shader.FromPointer); // 0x90 M_PointLightVolumeShader    ( ModelClassType Shader Shader Shader Pointer )
            value.M_CoreBlitShader                          = GetObject<Shader>(new IntPtr(p + 0x098), ReversePrism.DataModels.Shader.FromPointer); // 0x98 M_CoreBlitShader            ( ModelClassType Shader Shader Shader Pointer )
            value.M_BlitHDROverlay                          = GetObject<Shader>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Shader.FromPointer); // 0xA0 M_BlitHDROverlay            ( ModelClassType Shader Shader Shader Pointer )
            value.M_CoreBlitColorAndDepthPS                 = GetObject<Shader>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Shader.FromPointer); // 0xA8 M_CoreBlitColorAndDepthPS   ( ModelClassType Shader Shader Shader Pointer )
            value.M_SamplingShader                          = GetObject<Shader>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Shader.FromPointer); // 0xB0 M_SamplingShader            ( ModelClassType Shader Shader Shader Pointer )
            value.M_ProjectedShadowShader                   = GetObject<Shader>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Shader.FromPointer); // 0xB8 M_ProjectedShadowShader     ( ModelClassType Shader Shader Shader Pointer )
            value.M_SpriteShadowShader                      = GetObject<Shader>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Shader.FromPointer); // 0xC0 M_SpriteShadowShader        ( ModelClassType Shader Shader Shader Pointer )
            value.M_SpriteUnshadowShader                    = GetObject<Shader>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Shader.FromPointer); // 0xC8 M_SpriteUnshadowShader      ( ModelClassType Shader Shader Shader Pointer )
            value.M_GeometryUnshadowShader                  = GetObject<Shader>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Shader.FromPointer); // 0xD0 M_GeometryUnshadowShader    ( ModelClassType Shader Shader Shader Pointer )
            value.M_FallbackErrorShader                     = GetObject<Shader>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Shader.FromPointer); // 0xD8 M_FallbackErrorShader       ( ModelClassType Shader Shader Shader Pointer )
            value.M_PostProcessData                         = GetObject<PostProcessData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.PostProcessData.FromPointer); // 0xE0 M_PostProcessData           ( ModelClassType PostProcessData PostProcessData PostProcessData Pointer )
            value.M_FallOffLookup                           = GetObject<Texture2D>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Texture2D.FromPointer); // 0xE8 M_FallOffLookup             ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.SpriteSelfShadowMaterial                  = GetObjectList<Material>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Material.FromPointer); // 0xF8 SpriteSelfShadowMaterial    ( ModelClassListType Material[] Material[] List<Material> Pointer )
            value.SpriteUnshadowMaterial                    = GetObjectList<Material>(new IntPtr(p + 0x100), ReversePrism.DataModels.Material.FromPointer); // 0x100 SpriteUnshadowMaterial      ( ModelClassListType Material[] Material[] List<Material> Pointer )
            value.GeometryUnshadowMaterial                  = GetObjectList<Material>(new IntPtr(p + 0x108), ReversePrism.DataModels.Material.FromPointer); // 0x108 GeometryUnshadowMaterial    ( ModelClassListType Material[] Material[] List<Material> Pointer )
            value.ProjectedShadowMaterial                   = GetObjectList<Material>(new IntPtr(p + 0x110), ReversePrism.DataModels.Material.FromPointer); // 0x110 ProjectedShadowMaterial     ( ModelClassListType Material[] Material[] List<Material> Pointer )
            value.StencilOnlyShadowMaterial                 = GetObjectList<Material>(new IntPtr(p + 0x118), ReversePrism.DataModels.Material.FromPointer); // 0x118 StencilOnlyShadowMaterial   ( ModelClassListType Material[] Material[] List<Material> Pointer )
            value.IsNormalsRenderTargetValid                = GetBool(new IntPtr(p + 0x120)); // 0x120 IsNormalsRenderTargetValid  ( ModelPrimitiveType bool bool bool Bool )
            value.NormalsRenderTargetScale                  = GetSingle(new IntPtr(p + 0x124)); // 0x124 NormalsRenderTargetScale    ( ModelPrimitiveType float float float Single )
            value.NormalsRenderTarget                       = GetObject<RTHandle>(new IntPtr(p + 0x128), ReversePrism.DataModels.RTHandle.FromPointer); // 0x128 NormalsRenderTarget         ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.NormalsRenderTargetId                     = GetInt32(new IntPtr(p + 0x130)); // 0x130 NormalsRenderTargetId       ( ModelPrimitiveType int int int Int32 )
            value.ShadowsRenderTarget                       = GetObject<RTHandle>(new IntPtr(p + 0x138), ReversePrism.DataModels.RTHandle.FromPointer); // 0x138 ShadowsRenderTarget         ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.ShadowsRenderTargetId                     = GetInt32(new IntPtr(p + 0x140)); // 0x140 ShadowsRenderTargetId       ( ModelPrimitiveType int int int Int32 )
            value.CameraSortingLayerRenderTarget            = GetObject<RTHandle>(new IntPtr(p + 0x148), ReversePrism.DataModels.RTHandle.FromPointer); // 0x148 CameraSortingLayerRenderTarget ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.CameraSortingLayerRenderTargetId          = GetInt32(new IntPtr(p + 0x150)); // 0x150 CameraSortingLayerRenderTargetId ( ModelPrimitiveType int int int Int32 )
            value.LightCullResult                           = GetObject<ILight2DCullResult>(new IntPtr(p + 0x158), ReversePrism.DataModels.ILight2DCullResult.FromPointer); // 0x158 LightCullResult             ( ModelClassType ILight2DCullResult ILight2DCullResult ILight2DCullResult Pointer )

            return value;
        }
    }
}
