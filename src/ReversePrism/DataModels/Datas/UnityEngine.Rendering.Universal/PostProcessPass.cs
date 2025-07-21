using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_Descriptor                             ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 118 M_Source                                 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 120 M_Destination                            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 128 M_Depth                                  ModelClassType RTHandle RTHandle RTHandle Pointer
    // 130 M_InternalLut                            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 138 M_MotionVectors                          ModelClassType RTHandle RTHandle RTHandle Pointer
    // 140 M_FullCoCTexture                         ModelClassType RTHandle RTHandle RTHandle Pointer
    // 148 M_HalfCoCTexture                         ModelClassType RTHandle RTHandle RTHandle Pointer
    // 150 M_PingTexture                            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 158 M_PongTexture                            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 160 M_BloomMipDown                           ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 168 M_BloomMipUp                             ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 170 M_BlendTexture                           ModelClassType RTHandle RTHandle RTHandle Pointer
    // 178 M_EdgeColorTexture                       ModelClassType RTHandle RTHandle RTHandle Pointer
    // 180 M_EdgeStencilTexture                     ModelClassType RTHandle RTHandle RTHandle Pointer
    // 188 M_TempTarget                             ModelClassType RTHandle RTHandle RTHandle Pointer
    // 190 M_TempTarget2                            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 000 k_RenderPostProcessingTag                string IL2CPP_TYPE_STRING
    // 000 k_RenderFinalPostProcessingTag           string IL2CPP_TYPE_STRING
    // 000 m_ProfilingRenderPostProcessing          ProfilingSampler IL2CPP_TYPE_CLASS
    // 008 m_ProfilingRenderFinalPostProcessing     ProfilingSampler IL2CPP_TYPE_CLASS
    // 198 M_Materials                              ModelClassType MaterialLibrary MaterialLibrary MaterialLibrary Pointer
    // 1A0 M_Data                                   ModelClassType PostProcessData PostProcessData PostProcessData Pointer
    // 1A8 M_DepthOfField                           ModelClassType DepthOfField DepthOfField DepthOfField Pointer
    // 1B0 M_MotionBlur                             ModelClassType MotionBlur MotionBlur MotionBlur Pointer
    // 1B8 M_PaniniProjection                       ModelClassType PaniniProjection PaniniProjection PaniniProjection Pointer
    // 1C0 M_Bloom                                  ModelClassType Bloom Bloom Bloom Pointer
    // 1C8 M_LensDistortion                         ModelClassType LensDistortion LensDistortion LensDistortion Pointer
    // 1D0 M_ChromaticAberration                    ModelClassType ChromaticAberration ChromaticAberration ChromaticAberration Pointer
    // 1D8 M_Vignette                               ModelClassType Vignette Vignette Vignette Pointer
    // 1E0 M_ColorLookup                            ModelClassType ColorLookup ColorLookup ColorLookup Pointer
    // 1E8 M_ColorAdjustments                       ModelClassType ColorAdjustments ColorAdjustments ColorAdjustments Pointer
    // 1F0 M_Tonemapping                            ModelClassType Tonemapping Tonemapping Tonemapping Pointer
    // 1F8 M_FilmGrain                              ModelClassType FilmGrain FilmGrain FilmGrain Pointer
    // 000 k_MaxPyramidSize                         int IL2CPP_TYPE_I4
    // 200 M_DefaultHDRFormat                       ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 204 M_UseRGBM                                ModelPrimitiveType bool bool bool Bool
    // 208 M_SMAAEdgeFormat                         ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 20C M_GaussianCoCFormat                      ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 210 M_DitheringTextureIndex                  ModelPrimitiveType int int int Int32
    // 218 M_MRT2                                   ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer
    // 220 M_BokehKernel                            ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 228 M_BokehHash                              ModelPrimitiveType int int int Int32
    // 22C M_BokehMaxRadius                         ModelPrimitiveType float float float Single
    // 230 M_BokehRCPAspect                         ModelPrimitiveType float float float Single
    // 234 M_IsFinalPass                            ModelPrimitiveType bool bool bool Bool
    // 235 M_HasFinalPass                           ModelPrimitiveType bool bool bool Bool
    // 236 M_EnableColorEncodingIfNeeded            ModelPrimitiveType bool bool bool Bool
    // 237 M_UseFastSRGBLinearConversion            ModelPrimitiveType bool bool bool Bool
    // 238 M_SupportDataDrivenLensFlare             ModelPrimitiveType bool bool bool Bool
    // 239 M_ResolveToScreen                        ModelPrimitiveType bool bool bool Bool
    // 23A M_UseSwapBuffer                          ModelPrimitiveType bool bool bool Bool
    // 240 M_ScalingSetupTarget                     ModelClassType RTHandle RTHandle RTHandle Pointer
    // 248 M_UpscaledTarget                         ModelClassType RTHandle RTHandle RTHandle Pointer
    // 250 M_BlitMaterial                           ModelClassType Material Material Material Pointer
    // 010 K_ShaderPropertyId_ViewProjM             ModelPrimitiveType int int int Int32
    // 014 K_ShaderPropertyId_PrevViewProjM         ModelPrimitiveType int int int Int32
    // 018 K_ShaderPropertyId_ViewProjMStereo       ModelPrimitiveType int int int Int32
    // 01C K_ShaderPropertyId_PrevViewProjMStereo   ModelPrimitiveType int int int Int32
    public partial class PostProcessPass : DataModel
    {
        public RenderTextureDescriptor                  M_Descriptor                            { get; set; }
        public RTHandle?                                M_Source                                { get; set; }
        public RTHandle?                                M_Destination                           { get; set; }
        public RTHandle?                                M_Depth                                 { get; set; }
        public RTHandle?                                M_InternalLut                           { get; set; }
        public RTHandle?                                M_MotionVectors                         { get; set; }
        public RTHandle?                                M_FullCoCTexture                        { get; set; }
        public RTHandle?                                M_HalfCoCTexture                        { get; set; }
        public RTHandle?                                M_PingTexture                           { get; set; }
        public RTHandle?                                M_PongTexture                           { get; set; }
        public List<RTHandle>?                          M_BloomMipDown                          { get; set; }
        public List<RTHandle>?                          M_BloomMipUp                            { get; set; }
        public RTHandle?                                M_BlendTexture                          { get; set; }
        public RTHandle?                                M_EdgeColorTexture                      { get; set; }
        public RTHandle?                                M_EdgeStencilTexture                    { get; set; }
        public RTHandle?                                M_TempTarget                            { get; set; }
        public RTHandle?                                M_TempTarget2                           { get; set; }
        public MaterialLibrary?                         M_Materials                             { get; set; }
        public PostProcessData?                         M_Data                                  { get; set; }
        public DepthOfField?                            M_DepthOfField                          { get; set; }
        public MotionBlur?                              M_MotionBlur                            { get; set; }
        public PaniniProjection?                        M_PaniniProjection                      { get; set; }
        public Bloom?                                   M_Bloom                                 { get; set; }
        public LensDistortion?                          M_LensDistortion                        { get; set; }
        public ChromaticAberration?                     M_ChromaticAberration                   { get; set; }
        public Vignette?                                M_Vignette                              { get; set; }
        public ColorLookup?                             M_ColorLookup                           { get; set; }
        public ColorAdjustments?                        M_ColorAdjustments                      { get; set; }
        public Tonemapping?                             M_Tonemapping                           { get; set; }
        public FilmGrain?                               M_FilmGrain                             { get; set; }
        public GraphicsFormat                           M_DefaultHDRFormat                      { get; set; }
        public bool                                     M_UseRGBM                               { get; set; }
        public GraphicsFormat                           M_SMAAEdgeFormat                        { get; set; }
        public GraphicsFormat                           M_GaussianCoCFormat                     { get; set; }
        public int                                      M_DitheringTextureIndex                 { get; set; }
        public List<RenderTargetIdentifier>?            M_MRT2                                  { get; set; }
        public List<Vector4>?                           M_BokehKernel                           { get; set; }
        public int                                      M_BokehHash                             { get; set; }
        public float                                    M_BokehMaxRadius                        { get; set; }
        public float                                    M_BokehRCPAspect                        { get; set; }
        public bool                                     M_IsFinalPass                           { get; set; }
        public bool                                     M_HasFinalPass                          { get; set; }
        public bool                                     M_EnableColorEncodingIfNeeded           { get; set; }
        public bool                                     M_UseFastSRGBLinearConversion           { get; set; }
        public bool                                     M_SupportDataDrivenLensFlare            { get; set; }
        public bool                                     M_ResolveToScreen                       { get; set; }
        public bool                                     M_UseSwapBuffer                         { get; set; }
        public RTHandle?                                M_ScalingSetupTarget                    { get; set; }
        public RTHandle?                                M_UpscaledTarget                        { get; set; }
        public Material?                                M_BlitMaterial                          { get; set; }
        public int                                      K_ShaderPropertyId_ViewProjM            { get; set; }
        public int                                      K_ShaderPropertyId_PrevViewProjM        { get; set; }
        public int                                      K_ShaderPropertyId_ViewProjMStereo      { get; set; }
        public int                                      K_ShaderPropertyId_PrevViewProjMStereo  { get; set; }

        public static PostProcessPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessPass() { Pointer= p0 };

            value.M_Descriptor                              = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 M_Descriptor                ( ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.M_Source                                  = GetObject<RTHandle>(new IntPtr(p + 0x118), ReversePrism.DataModels.RTHandle.FromPointer); // 0x118 M_Source                    ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_Destination                             = GetObject<RTHandle>(new IntPtr(p + 0x120), ReversePrism.DataModels.RTHandle.FromPointer); // 0x120 M_Destination               ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_Depth                                   = GetObject<RTHandle>(new IntPtr(p + 0x128), ReversePrism.DataModels.RTHandle.FromPointer); // 0x128 M_Depth                     ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_InternalLut                             = GetObject<RTHandle>(new IntPtr(p + 0x130), ReversePrism.DataModels.RTHandle.FromPointer); // 0x130 M_InternalLut               ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_MotionVectors                           = GetObject<RTHandle>(new IntPtr(p + 0x138), ReversePrism.DataModels.RTHandle.FromPointer); // 0x138 M_MotionVectors             ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_FullCoCTexture                          = GetObject<RTHandle>(new IntPtr(p + 0x140), ReversePrism.DataModels.RTHandle.FromPointer); // 0x140 M_FullCoCTexture            ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_HalfCoCTexture                          = GetObject<RTHandle>(new IntPtr(p + 0x148), ReversePrism.DataModels.RTHandle.FromPointer); // 0x148 M_HalfCoCTexture            ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_PingTexture                             = GetObject<RTHandle>(new IntPtr(p + 0x150), ReversePrism.DataModels.RTHandle.FromPointer); // 0x150 M_PingTexture               ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_PongTexture                             = GetObject<RTHandle>(new IntPtr(p + 0x158), ReversePrism.DataModels.RTHandle.FromPointer); // 0x158 M_PongTexture               ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_BloomMipDown                            = GetObjectList<RTHandle>(new IntPtr(p + 0x160), ReversePrism.DataModels.RTHandle.FromPointer); // 0x160 M_BloomMipDown              ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.M_BloomMipUp                              = GetObjectList<RTHandle>(new IntPtr(p + 0x168), ReversePrism.DataModels.RTHandle.FromPointer); // 0x168 M_BloomMipUp                ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.M_BlendTexture                            = GetObject<RTHandle>(new IntPtr(p + 0x170), ReversePrism.DataModels.RTHandle.FromPointer); // 0x170 M_BlendTexture              ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_EdgeColorTexture                        = GetObject<RTHandle>(new IntPtr(p + 0x178), ReversePrism.DataModels.RTHandle.FromPointer); // 0x178 M_EdgeColorTexture          ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_EdgeStencilTexture                      = GetObject<RTHandle>(new IntPtr(p + 0x180), ReversePrism.DataModels.RTHandle.FromPointer); // 0x180 M_EdgeStencilTexture        ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_TempTarget                              = GetObject<RTHandle>(new IntPtr(p + 0x188), ReversePrism.DataModels.RTHandle.FromPointer); // 0x188 M_TempTarget                ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_TempTarget2                             = GetObject<RTHandle>(new IntPtr(p + 0x190), ReversePrism.DataModels.RTHandle.FromPointer); // 0x190 M_TempTarget2               ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_Materials                               = GetObject<MaterialLibrary>(new IntPtr(p + 0x198), ReversePrism.DataModels.MaterialLibrary.FromPointer); // 0x198 M_Materials                 ( ModelClassType MaterialLibrary MaterialLibrary MaterialLibrary Pointer )
            value.M_Data                                    = GetObject<PostProcessData>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.PostProcessData.FromPointer); // 0x1A0 M_Data                      ( ModelClassType PostProcessData PostProcessData PostProcessData Pointer )
            value.M_DepthOfField                            = GetObject<DepthOfField>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.DepthOfField.FromPointer); // 0x1A8 M_DepthOfField              ( ModelClassType DepthOfField DepthOfField DepthOfField Pointer )
            value.M_MotionBlur                              = GetObject<MotionBlur>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.MotionBlur.FromPointer); // 0x1B0 M_MotionBlur                ( ModelClassType MotionBlur MotionBlur MotionBlur Pointer )
            value.M_PaniniProjection                        = GetObject<PaniniProjection>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.PaniniProjection.FromPointer); // 0x1B8 M_PaniniProjection          ( ModelClassType PaniniProjection PaniniProjection PaniniProjection Pointer )
            value.M_Bloom                                   = GetObject<Bloom>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.Bloom.FromPointer); // 0x1C0 M_Bloom                     ( ModelClassType Bloom Bloom Bloom Pointer )
            value.M_LensDistortion                          = GetObject<LensDistortion>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.LensDistortion.FromPointer); // 0x1C8 M_LensDistortion            ( ModelClassType LensDistortion LensDistortion LensDistortion Pointer )
            value.M_ChromaticAberration                     = GetObject<ChromaticAberration>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.ChromaticAberration.FromPointer); // 0x1D0 M_ChromaticAberration       ( ModelClassType ChromaticAberration ChromaticAberration ChromaticAberration Pointer )
            value.M_Vignette                                = GetObject<Vignette>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.Vignette.FromPointer); // 0x1D8 M_Vignette                  ( ModelClassType Vignette Vignette Vignette Pointer )
            value.M_ColorLookup                             = GetObject<ColorLookup>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.ColorLookup.FromPointer); // 0x1E0 M_ColorLookup               ( ModelClassType ColorLookup ColorLookup ColorLookup Pointer )
            value.M_ColorAdjustments                        = GetObject<ColorAdjustments>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.ColorAdjustments.FromPointer); // 0x1E8 M_ColorAdjustments          ( ModelClassType ColorAdjustments ColorAdjustments ColorAdjustments Pointer )
            value.M_Tonemapping                             = GetObject<Tonemapping>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.Tonemapping.FromPointer); // 0x1F0 M_Tonemapping               ( ModelClassType Tonemapping Tonemapping Tonemapping Pointer )
            value.M_FilmGrain                               = GetObject<FilmGrain>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.FilmGrain.FromPointer); // 0x1F8 M_FilmGrain                 ( ModelClassType FilmGrain FilmGrain FilmGrain Pointer )
            value.M_DefaultHDRFormat                        = (GraphicsFormat)GetInt32(new IntPtr(p + 0x200)); // 0x200 M_DefaultHDRFormat          ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.M_UseRGBM                                 = GetBool(new IntPtr(p + 0x204)); // 0x204 M_UseRGBM                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_SMAAEdgeFormat                          = (GraphicsFormat)GetInt32(new IntPtr(p + 0x208)); // 0x208 M_SMAAEdgeFormat            ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.M_GaussianCoCFormat                       = (GraphicsFormat)GetInt32(new IntPtr(p + 0x20C)); // 0x20C M_GaussianCoCFormat         ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.M_DitheringTextureIndex                   = GetInt32(new IntPtr(p + 0x210)); // 0x210 M_DitheringTextureIndex     ( ModelPrimitiveType int int int Int32 )
            value.M_MRT2                                    = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x218)); // 0x218 M_MRT2                      ( ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer )
            value.M_BokehKernel                             = GetEnumList<Vector4>(new IntPtr(p + 0x220)); // 0x220 M_BokehKernel               ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_BokehHash                               = GetInt32(new IntPtr(p + 0x228)); // 0x228 M_BokehHash                 ( ModelPrimitiveType int int int Int32 )
            value.M_BokehMaxRadius                          = GetSingle(new IntPtr(p + 0x22C)); // 0x22C M_BokehMaxRadius            ( ModelPrimitiveType float float float Single )
            value.M_BokehRCPAspect                          = GetSingle(new IntPtr(p + 0x230)); // 0x230 M_BokehRCPAspect            ( ModelPrimitiveType float float float Single )
            value.M_IsFinalPass                             = GetBool(new IntPtr(p + 0x234)); // 0x234 M_IsFinalPass               ( ModelPrimitiveType bool bool bool Bool )
            value.M_HasFinalPass                            = GetBool(new IntPtr(p + 0x235)); // 0x235 M_HasFinalPass              ( ModelPrimitiveType bool bool bool Bool )
            value.M_EnableColorEncodingIfNeeded             = GetBool(new IntPtr(p + 0x236)); // 0x236 M_EnableColorEncodingIfNeeded ( ModelPrimitiveType bool bool bool Bool )
            value.M_UseFastSRGBLinearConversion             = GetBool(new IntPtr(p + 0x237)); // 0x237 M_UseFastSRGBLinearConversion ( ModelPrimitiveType bool bool bool Bool )
            value.M_SupportDataDrivenLensFlare              = GetBool(new IntPtr(p + 0x238)); // 0x238 M_SupportDataDrivenLensFlare ( ModelPrimitiveType bool bool bool Bool )
            value.M_ResolveToScreen                         = GetBool(new IntPtr(p + 0x239)); // 0x239 M_ResolveToScreen           ( ModelPrimitiveType bool bool bool Bool )
            value.M_UseSwapBuffer                           = GetBool(new IntPtr(p + 0x23A)); // 0x23A M_UseSwapBuffer             ( ModelPrimitiveType bool bool bool Bool )
            value.M_ScalingSetupTarget                      = GetObject<RTHandle>(new IntPtr(p + 0x240), ReversePrism.DataModels.RTHandle.FromPointer); // 0x240 M_ScalingSetupTarget        ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_UpscaledTarget                          = GetObject<RTHandle>(new IntPtr(p + 0x248), ReversePrism.DataModels.RTHandle.FromPointer); // 0x248 M_UpscaledTarget            ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_BlitMaterial                            = GetObject<Material>(new IntPtr(p + 0x250), ReversePrism.DataModels.Material.FromPointer); // 0x250 M_BlitMaterial              ( ModelClassType Material Material Material Pointer )
            value.K_ShaderPropertyId_ViewProjM              = GetInt32(new IntPtr(p + 0x010)); // 0x10 K_ShaderPropertyId_ViewProjM ( ModelPrimitiveType int int int Int32 )
            value.K_ShaderPropertyId_PrevViewProjM          = GetInt32(new IntPtr(p + 0x014)); // 0x14 K_ShaderPropertyId_PrevViewProjM ( ModelPrimitiveType int int int Int32 )
            value.K_ShaderPropertyId_ViewProjMStereo        = GetInt32(new IntPtr(p + 0x018)); // 0x18 K_ShaderPropertyId_ViewProjMStereo ( ModelPrimitiveType int int int Int32 )
            value.K_ShaderPropertyId_PrevViewProjMStereo    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C K_ShaderPropertyId_PrevViewProjMStereo ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
