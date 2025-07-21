using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 unity_StereoCameraProjection             int IL2CPP_TYPE_I4
    // 004 unity_StereoCameraInvProjection          int IL2CPP_TYPE_I4
    // 008 unity_StereoMatrixV                      int IL2CPP_TYPE_I4
    // 00C unity_StereoMatrixInvV                   int IL2CPP_TYPE_I4
    // 010 Unity_StereoMatrixP                      ModelPrimitiveType int int int Int32
    // 014 Unity_StereoMatrixInvP                   ModelPrimitiveType int int int Int32
    // 018 Unity_StereoMatrixVP                     ModelPrimitiveType int int int Int32
    // 01C Unity_StereoMatrixInvVP                  ModelPrimitiveType int int int Int32
    // 020 Unity_StereoWorldSpaceCameraPos          ModelPrimitiveType int int int Int32
    // 028 S_cameraProjMatrix                       ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 030 S_invCameraProjMatrix                    ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 038 S_viewMatrix                             ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 040 S_invViewMatrix                          ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 048 S_projMatrix                             ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 050 S_invProjMatrix                          ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 058 S_viewProjMatrix                         ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 060 S_invViewProjMatrix                      ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 068 S_worldSpaceCameraPos                    ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    public partial class XRBuiltinShaderConstants : DataModel
    {
        public int                                      Unity_StereoMatrixP                     { get; set; }
        public int                                      Unity_StereoMatrixInvP                  { get; set; }
        public int                                      Unity_StereoMatrixVP                    { get; set; }
        public int                                      Unity_StereoMatrixInvVP                 { get; set; }
        public int                                      Unity_StereoWorldSpaceCameraPos         { get; set; }
        public List<Matrix4x4>?                         S_cameraProjMatrix                      { get; set; }
        public List<Matrix4x4>?                         S_invCameraProjMatrix                   { get; set; }
        public List<Matrix4x4>?                         S_viewMatrix                            { get; set; }
        public List<Matrix4x4>?                         S_invViewMatrix                         { get; set; }
        public List<Matrix4x4>?                         S_projMatrix                            { get; set; }
        public List<Matrix4x4>?                         S_invProjMatrix                         { get; set; }
        public List<Matrix4x4>?                         S_viewProjMatrix                        { get; set; }
        public List<Matrix4x4>?                         S_invViewProjMatrix                     { get; set; }
        public List<Vector4>?                           S_worldSpaceCameraPos                   { get; set; }

        public static XRBuiltinShaderConstants? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRBuiltinShaderConstants() { Pointer= p0 };

            value.Unity_StereoMatrixP                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 Unity_StereoMatrixP         ( ModelPrimitiveType int int int Int32 )
            value.Unity_StereoMatrixInvP                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Unity_StereoMatrixInvP      ( ModelPrimitiveType int int int Int32 )
            value.Unity_StereoMatrixVP                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Unity_StereoMatrixVP        ( ModelPrimitiveType int int int Int32 )
            value.Unity_StereoMatrixInvVP                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Unity_StereoMatrixInvVP     ( ModelPrimitiveType int int int Int32 )
            value.Unity_StereoWorldSpaceCameraPos           = GetInt32(new IntPtr(p + 0x020)); // 0x20 Unity_StereoWorldSpaceCameraPos ( ModelPrimitiveType int int int Int32 )
            value.S_cameraProjMatrix                        = GetEnumList<Matrix4x4>(new IntPtr(p + 0x028)); // 0x28 S_cameraProjMatrix          ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.S_invCameraProjMatrix                     = GetEnumList<Matrix4x4>(new IntPtr(p + 0x030)); // 0x30 S_invCameraProjMatrix       ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.S_viewMatrix                              = GetEnumList<Matrix4x4>(new IntPtr(p + 0x038)); // 0x38 S_viewMatrix                ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.S_invViewMatrix                           = GetEnumList<Matrix4x4>(new IntPtr(p + 0x040)); // 0x40 S_invViewMatrix             ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.S_projMatrix                              = GetEnumList<Matrix4x4>(new IntPtr(p + 0x048)); // 0x48 S_projMatrix                ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.S_invProjMatrix                           = GetEnumList<Matrix4x4>(new IntPtr(p + 0x050)); // 0x50 S_invProjMatrix             ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.S_viewProjMatrix                          = GetEnumList<Matrix4x4>(new IntPtr(p + 0x058)); // 0x58 S_viewProjMatrix            ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.S_invViewProjMatrix                       = GetEnumList<Matrix4x4>(new IntPtr(p + 0x060)); // 0x60 S_invViewProjMatrix         ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.S_worldSpaceCameraPos                     = GetEnumList<Vector4>(new IntPtr(p + 0x068)); // 0x68 S_worldSpaceCameraPos       ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )

            return value;
        }
    }
}
