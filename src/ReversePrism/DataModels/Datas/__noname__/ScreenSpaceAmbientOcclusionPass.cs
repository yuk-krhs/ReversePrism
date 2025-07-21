using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 ProfilerTag                              ModelPrimitiveType string string string String
    // 0E8 M_SupportsR8RenderTextureFormat          ModelPrimitiveType bool bool bool Bool
    // 0EC M_BlueNoiseTextureIndex                  ModelPrimitiveType int int int Int32
    // 0F0 M_BlurRandomOffsetX                      ModelPrimitiveType float float float Single
    // 0F4 M_BlurRandomOffsetY                      ModelPrimitiveType float float float Single
    // 0F8 M_Material                               ModelClassType Material Material Material Pointer
    // 100 M_BlueNoiseTextures                      ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 108 M_CameraTopLeftCorner                    ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 110 M_CameraXExtent                          ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 118 M_CameraYExtent                          ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 120 M_CameraZExtent                          ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 128 M_SSAOTextures                           ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 130 M_BlurType                               ModelEnumType BlurTypes BlurTypes BlurTypes Int32
    // 138 M_CameraViewProjections                  ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 140 M_ProfilingSampler                       ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 148 M_Renderer                               ModelClassType ScriptableRenderer ScriptableRenderer ScriptableRenderer Pointer
    // 150 M_AOPassDescriptor                       ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 188 M_CurrentSettings                        ModelClassType ScreenSpaceAmbientOcclusionSettings ScreenSpaceAmbientOcclusionSettings ScreenSpaceAmbientOcclusionSettings Pointer
    // 000 k_FinalTexID                             int IL2CPP_TYPE_I4
    // 000 k_SSAOTextureName                        string IL2CPP_TYPE_STRING
    // 000 k_SSAOAmbientOcclusionParamName          string IL2CPP_TYPE_STRING
    // 000 s_SSAOParamsID                           int IL2CPP_TYPE_I4
    // 004 s_SSAOBlueNoiseParamsID                  int IL2CPP_TYPE_I4
    // 008 s_LastKawasePass                         int IL2CPP_TYPE_I4
    // 00C s_BlueNoiseTextureID                     int IL2CPP_TYPE_I4
    // 010 S_CameraViewXExtentID                    ModelPrimitiveType int int int Int32
    // 014 S_CameraViewYExtentID                    ModelPrimitiveType int int int Int32
    // 018 S_CameraViewZExtentID                    ModelPrimitiveType int int int Int32
    // 01C S_ProjectionParams2ID                    ModelPrimitiveType int int int Int32
    // 020 S_KawaseBlurIterationID                  ModelPrimitiveType int int int Int32
    // 024 S_CameraViewProjectionsID                ModelPrimitiveType int int int Int32
    // 028 S_CameraViewTopLeftCornerID              ModelPrimitiveType int int int Int32
    // 030 M_BilateralTexturesIndices               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 M_BilateralPasses                        ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer
    // 040 M_BilateralAfterOpaquePasses             ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer
    // 048 M_GaussianTexturesIndices                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 050 M_GaussianPasses                         ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer
    // 058 M_GaussianAfterOpaquePasses              ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer
    // 060 M_KawaseTexturesIndices                  ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 M_KawasePasses                           ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer
    // 070 M_KawaseAfterOpaquePasses                ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer
    public partial class ScreenSpaceAmbientOcclusionPass : DataModel
    {
        public string                                   ProfilerTag                             { get; set; }
        public bool                                     M_SupportsR8RenderTextureFormat         { get; set; }
        public int                                      M_BlueNoiseTextureIndex                 { get; set; }
        public float                                    M_BlurRandomOffsetX                     { get; set; }
        public float                                    M_BlurRandomOffsetY                     { get; set; }
        public Material?                                M_Material                              { get; set; }
        public List<Texture2D>?                         M_BlueNoiseTextures                     { get; set; }
        public List<Vector4>?                           M_CameraTopLeftCorner                   { get; set; }
        public List<Vector4>?                           M_CameraXExtent                         { get; set; }
        public List<Vector4>?                           M_CameraYExtent                         { get; set; }
        public List<Vector4>?                           M_CameraZExtent                         { get; set; }
        public List<RTHandle>?                          M_SSAOTextures                          { get; set; }
        public BlurTypes                                M_BlurType                              { get; set; }
        public List<Matrix4x4>?                         M_CameraViewProjections                 { get; set; }
        public ProfilingSampler?                        M_ProfilingSampler                      { get; set; }
        public ScriptableRenderer?                      M_Renderer                              { get; set; }
        public RenderTextureDescriptor                  M_AOPassDescriptor                      { get; set; }
        public ScreenSpaceAmbientOcclusionSettings?     M_CurrentSettings                       { get; set; }
        public int                                      S_CameraViewXExtentID                   { get; set; }
        public int                                      S_CameraViewYExtentID                   { get; set; }
        public int                                      S_CameraViewZExtentID                   { get; set; }
        public int                                      S_ProjectionParams2ID                   { get; set; }
        public int                                      S_KawaseBlurIterationID                 { get; set; }
        public int                                      S_CameraViewProjectionsID               { get; set; }
        public int                                      S_CameraViewTopLeftCornerID             { get; set; }
        public List<int>?                               M_BilateralTexturesIndices              { get; set; }
        public List<ShaderPasses>?                      M_BilateralPasses                       { get; set; }
        public List<ShaderPasses>?                      M_BilateralAfterOpaquePasses            { get; set; }
        public List<int>?                               M_GaussianTexturesIndices               { get; set; }
        public List<ShaderPasses>?                      M_GaussianPasses                        { get; set; }
        public List<ShaderPasses>?                      M_GaussianAfterOpaquePasses             { get; set; }
        public List<int>?                               M_KawaseTexturesIndices                 { get; set; }
        public List<ShaderPasses>?                      M_KawasePasses                          { get; set; }
        public List<ShaderPasses>?                      M_KawaseAfterOpaquePasses               { get; set; }

        public static ScreenSpaceAmbientOcclusionPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenSpaceAmbientOcclusionPass() { Pointer= p0 };

            value.ProfilerTag                               = GetString(new IntPtr(p + 0x0E0)); // 0xE0 ProfilerTag                 ( ModelPrimitiveType string string string String )
            value.M_SupportsR8RenderTextureFormat           = GetBool(new IntPtr(p + 0x0E8)); // 0xE8 M_SupportsR8RenderTextureFormat ( ModelPrimitiveType bool bool bool Bool )
            value.M_BlueNoiseTextureIndex                   = GetInt32(new IntPtr(p + 0x0EC)); // 0xEC M_BlueNoiseTextureIndex     ( ModelPrimitiveType int int int Int32 )
            value.M_BlurRandomOffsetX                       = GetSingle(new IntPtr(p + 0x0F0)); // 0xF0 M_BlurRandomOffsetX         ( ModelPrimitiveType float float float Single )
            value.M_BlurRandomOffsetY                       = GetSingle(new IntPtr(p + 0x0F4)); // 0xF4 M_BlurRandomOffsetY         ( ModelPrimitiveType float float float Single )
            value.M_Material                                = GetObject<Material>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Material.FromPointer); // 0xF8 M_Material                  ( ModelClassType Material Material Material Pointer )
            value.M_BlueNoiseTextures                       = GetObjectList<Texture2D>(new IntPtr(p + 0x100), ReversePrism.DataModels.Texture2D.FromPointer); // 0x100 M_BlueNoiseTextures         ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.M_CameraTopLeftCorner                     = GetEnumList<Vector4>(new IntPtr(p + 0x108)); // 0x108 M_CameraTopLeftCorner       ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_CameraXExtent                           = GetEnumList<Vector4>(new IntPtr(p + 0x110)); // 0x110 M_CameraXExtent             ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_CameraYExtent                           = GetEnumList<Vector4>(new IntPtr(p + 0x118)); // 0x118 M_CameraYExtent             ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_CameraZExtent                           = GetEnumList<Vector4>(new IntPtr(p + 0x120)); // 0x120 M_CameraZExtent             ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_SSAOTextures                            = GetObjectList<RTHandle>(new IntPtr(p + 0x128), ReversePrism.DataModels.RTHandle.FromPointer); // 0x128 M_SSAOTextures              ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.M_BlurType                                = (BlurTypes)GetInt32(new IntPtr(p + 0x130)); // 0x130 M_BlurType                  ( ModelEnumType BlurTypes BlurTypes BlurTypes Int32 )
            value.M_CameraViewProjections                   = GetEnumList<Matrix4x4>(new IntPtr(p + 0x138)); // 0x138 M_CameraViewProjections     ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.M_ProfilingSampler                        = GetObject<ProfilingSampler>(new IntPtr(p + 0x140), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x140 M_ProfilingSampler          ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_Renderer                                = GetObject<ScriptableRenderer>(new IntPtr(p + 0x148), ReversePrism.DataModels.ScriptableRenderer.FromPointer); // 0x148 M_Renderer                  ( ModelClassType ScriptableRenderer ScriptableRenderer ScriptableRenderer Pointer )
            value.M_AOPassDescriptor                        = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x150)); // 0x150 M_AOPassDescriptor          ( ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.M_CurrentSettings                         = GetObject<ScreenSpaceAmbientOcclusionSettings>(new IntPtr(p + 0x188), ReversePrism.DataModels.ScreenSpaceAmbientOcclusionSettings.FromPointer); // 0x188 M_CurrentSettings           ( ModelClassType ScreenSpaceAmbientOcclusionSettings ScreenSpaceAmbientOcclusionSettings ScreenSpaceAmbientOcclusionSettings Pointer )
            value.S_CameraViewXExtentID                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 S_CameraViewXExtentID       ( ModelPrimitiveType int int int Int32 )
            value.S_CameraViewYExtentID                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 S_CameraViewYExtentID       ( ModelPrimitiveType int int int Int32 )
            value.S_CameraViewZExtentID                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 S_CameraViewZExtentID       ( ModelPrimitiveType int int int Int32 )
            value.S_ProjectionParams2ID                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C S_ProjectionParams2ID       ( ModelPrimitiveType int int int Int32 )
            value.S_KawaseBlurIterationID                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 S_KawaseBlurIterationID     ( ModelPrimitiveType int int int Int32 )
            value.S_CameraViewProjectionsID                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 S_CameraViewProjectionsID   ( ModelPrimitiveType int int int Int32 )
            value.S_CameraViewTopLeftCornerID               = GetInt32(new IntPtr(p + 0x028)); // 0x28 S_CameraViewTopLeftCornerID ( ModelPrimitiveType int int int Int32 )
            value.M_BilateralTexturesIndices                = GetInt32List(new IntPtr(p + 0x030)); // 0x30 M_BilateralTexturesIndices  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_BilateralPasses                         = GetEnumList<ShaderPasses>(new IntPtr(p + 0x038)); // 0x38 M_BilateralPasses           ( ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer )
            value.M_BilateralAfterOpaquePasses              = GetEnumList<ShaderPasses>(new IntPtr(p + 0x040)); // 0x40 M_BilateralAfterOpaquePasses ( ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer )
            value.M_GaussianTexturesIndices                 = GetInt32List(new IntPtr(p + 0x048)); // 0x48 M_GaussianTexturesIndices   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_GaussianPasses                          = GetEnumList<ShaderPasses>(new IntPtr(p + 0x050)); // 0x50 M_GaussianPasses            ( ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer )
            value.M_GaussianAfterOpaquePasses               = GetEnumList<ShaderPasses>(new IntPtr(p + 0x058)); // 0x58 M_GaussianAfterOpaquePasses ( ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer )
            value.M_KawaseTexturesIndices                   = GetInt32List(new IntPtr(p + 0x060)); // 0x60 M_KawaseTexturesIndices     ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_KawasePasses                            = GetEnumList<ShaderPasses>(new IntPtr(p + 0x068)); // 0x68 M_KawasePasses              ( ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer )
            value.M_KawaseAfterOpaquePasses                 = GetEnumList<ShaderPasses>(new IntPtr(p + 0x070)); // 0x70 M_KawaseAfterOpaquePasses   ( ModelEnumListType ShaderPasses[] ShaderPasses[] List<ShaderPasses> Pointer )

            return value;
        }
    }
}
