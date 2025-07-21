using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_MaxCascades                            int IL2CPP_TYPE_I4
    // 000 k_ShadowmapBufferBits                    int IL2CPP_TYPE_I4
    // 0E0 M_CascadeBorder                          ModelPrimitiveType float float float Single
    // 0E4 M_MaxShadowDistanceSq                    ModelPrimitiveType float float float Single
    // 0E8 M_ShadowCasterCascadesCount              ModelPrimitiveType int int int Int32
    // 0EC M_MainLightShadowmapID                   ModelPrimitiveType int int int Int32
    // 0F0 M_MainLightShadowmapTexture              ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0F8 M_EmptyLightShadowmapTexture             ModelClassType RTHandle RTHandle RTHandle Pointer
    // 100 M_MainLightShadowMatrices                ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 108 M_CascadeSlices                          ModelEnumListType ShadowSliceData[] ShadowSliceData[] List<ShadowSliceData> Pointer
    // 110 M_CascadeSplitDistances                  ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 118 M_CreateEmptyShadowmap                   ModelPrimitiveType bool bool bool Bool
    // 11C RenderTargetWidth                        ModelPrimitiveType int int int Int32
    // 120 RenderTargetHeight                       ModelPrimitiveType int int int Int32
    // 128 M_ProfilingSetupSampler                  ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    public partial class MainLightShadowCasterPass : DataModel
    {
        public float                                    M_CascadeBorder                         { get; set; }
        public float                                    M_MaxShadowDistanceSq                   { get; set; }
        public int                                      M_ShadowCasterCascadesCount             { get; set; }
        public int                                      M_MainLightShadowmapID                  { get; set; }
        public RTHandle?                                M_MainLightShadowmapTexture             { get; set; }
        public RTHandle?                                M_EmptyLightShadowmapTexture            { get; set; }
        public List<Matrix4x4>?                         M_MainLightShadowMatrices               { get; set; }
        public List<ShadowSliceData>?                   M_CascadeSlices                         { get; set; }
        public List<Vector4>?                           M_CascadeSplitDistances                 { get; set; }
        public bool                                     M_CreateEmptyShadowmap                  { get; set; }
        public int                                      RenderTargetWidth                       { get; set; }
        public int                                      RenderTargetHeight                      { get; set; }
        public ProfilingSampler?                        M_ProfilingSetupSampler                 { get; set; }

        public static MainLightShadowCasterPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainLightShadowCasterPass() { Pointer= p0 };

            value.M_CascadeBorder                           = GetSingle(new IntPtr(p + 0x0E0)); // 0xE0 M_CascadeBorder             ( ModelPrimitiveType float float float Single )
            value.M_MaxShadowDistanceSq                     = GetSingle(new IntPtr(p + 0x0E4)); // 0xE4 M_MaxShadowDistanceSq       ( ModelPrimitiveType float float float Single )
            value.M_ShadowCasterCascadesCount               = GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 M_ShadowCasterCascadesCount ( ModelPrimitiveType int int int Int32 )
            value.M_MainLightShadowmapID                    = GetInt32(new IntPtr(p + 0x0EC)); // 0xEC M_MainLightShadowmapID      ( ModelPrimitiveType int int int Int32 )
            value.M_MainLightShadowmapTexture               = GetObject<RTHandle>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.RTHandle.FromPointer); // 0xF0 M_MainLightShadowmapTexture ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_EmptyLightShadowmapTexture              = GetObject<RTHandle>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.RTHandle.FromPointer); // 0xF8 M_EmptyLightShadowmapTexture ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_MainLightShadowMatrices                 = GetEnumList<Matrix4x4>(new IntPtr(p + 0x100)); // 0x100 M_MainLightShadowMatrices   ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.M_CascadeSlices                           = GetEnumList<ShadowSliceData>(new IntPtr(p + 0x108)); // 0x108 M_CascadeSlices             ( ModelEnumListType ShadowSliceData[] ShadowSliceData[] List<ShadowSliceData> Pointer )
            value.M_CascadeSplitDistances                   = GetEnumList<Vector4>(new IntPtr(p + 0x110)); // 0x110 M_CascadeSplitDistances     ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_CreateEmptyShadowmap                    = GetBool(new IntPtr(p + 0x118)); // 0x118 M_CreateEmptyShadowmap      ( ModelPrimitiveType bool bool bool Bool )
            value.RenderTargetWidth                         = GetInt32(new IntPtr(p + 0x11C)); // 0x11C RenderTargetWidth           ( ModelPrimitiveType int int int Int32 )
            value.RenderTargetHeight                        = GetInt32(new IntPtr(p + 0x120)); // 0x120 RenderTargetHeight          ( ModelPrimitiveType int int int Int32 )
            value.M_ProfilingSetupSampler                   = GetObject<ProfilingSampler>(new IntPtr(p + 0x128), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x128 M_ProfilingSetupSampler     ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )

            return value;
        }
    }
}
