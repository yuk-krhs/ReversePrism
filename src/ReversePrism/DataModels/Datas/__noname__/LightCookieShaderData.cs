using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Size                                   ModelPrimitiveType int int int Int32
    // 014 M_UseStructuredBuffer                    ModelPrimitiveType bool bool bool Bool
    // 018 M_WorldToLightCpuData                    ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 020 M_AtlasUVRectCpuData                     ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 028 M_LightTypeCpuData                       ModelPrimitiveListType float[] float[] List<float> Pointer
    // 030 M_CookieEnableBitsCpuData                ModelEnumType ShaderBitArray ShaderBitArray ShaderBitArray Int32
    // 038 M_WorldToLightBuffer                     ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer
    // 040 M_AtlasUVRectBuffer                      ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer
    // 048 M_LightTypeBuffer                        ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer
    // 050 IsUploaded                               ModelPrimitiveType bool bool bool Bool
    public partial class LightCookieShaderData : DataModel
    {
        public int                                      M_Size                                  { get; set; }
        public bool                                     M_UseStructuredBuffer                   { get; set; }
        public List<Matrix4x4>?                         M_WorldToLightCpuData                   { get; set; }
        public List<Vector4>?                           M_AtlasUVRectCpuData                    { get; set; }
        public List<float>?                             M_LightTypeCpuData                      { get; set; }
        public ShaderBitArray                           M_CookieEnableBitsCpuData               { get; set; }
        public ComputeBuffer?                           M_WorldToLightBuffer                    { get; set; }
        public ComputeBuffer?                           M_AtlasUVRectBuffer                     { get; set; }
        public ComputeBuffer?                           M_LightTypeBuffer                       { get; set; }
        public bool                                     IsUploaded                              { get; set; }

        public static LightCookieShaderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightCookieShaderData() { Pointer= p0 };

            value.M_Size                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Size                      ( ModelPrimitiveType int int int Int32 )
            value.M_UseStructuredBuffer                     = GetBool(new IntPtr(p + 0x014)); // 0x14 M_UseStructuredBuffer       ( ModelPrimitiveType bool bool bool Bool )
            value.M_WorldToLightCpuData                     = GetEnumList<Matrix4x4>(new IntPtr(p + 0x018)); // 0x18 M_WorldToLightCpuData       ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.M_AtlasUVRectCpuData                      = GetEnumList<Vector4>(new IntPtr(p + 0x020)); // 0x20 M_AtlasUVRectCpuData        ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_LightTypeCpuData                        = GetSingleList(new IntPtr(p + 0x028)); // 0x28 M_LightTypeCpuData          ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_CookieEnableBitsCpuData                 = (ShaderBitArray)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_CookieEnableBitsCpuData   ( ModelEnumType ShaderBitArray ShaderBitArray ShaderBitArray Int32 )
            value.M_WorldToLightBuffer                      = GetObject<ComputeBuffer>(new IntPtr(p + 0x038), ReversePrism.DataModels.ComputeBuffer.FromPointer); // 0x38 M_WorldToLightBuffer        ( ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer )
            value.M_AtlasUVRectBuffer                       = GetObject<ComputeBuffer>(new IntPtr(p + 0x040), ReversePrism.DataModels.ComputeBuffer.FromPointer); // 0x40 M_AtlasUVRectBuffer         ( ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer )
            value.M_LightTypeBuffer                         = GetObject<ComputeBuffer>(new IntPtr(p + 0x048), ReversePrism.DataModels.ComputeBuffer.FromPointer); // 0x48 M_LightTypeBuffer           ( ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer )
            value.IsUploaded                                = GetBool(new IntPtr(p + 0x050)); // 0x50 IsUploaded                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
