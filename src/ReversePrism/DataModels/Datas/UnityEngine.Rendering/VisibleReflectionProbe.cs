using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Bounds                                 0001865993A0 ModelEnumType Bounds Bounds Bounds Int32
    // 028 M_LocalToWorldMatrix                     00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 068 M_HdrData                                0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 078 M_Center                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 084 M_BlendDistance                          0001866656B0 ModelPrimitiveType float float float Single
    // 088 M_Importance                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 08C M_BoxProjection                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 090 M_InstanceId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 094 M_TextureId                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class VisibleReflectionProbe : DataModel
    {
        public Bounds                                   M_Bounds                                { get; set; }
        public Matrix4x4                                M_LocalToWorldMatrix                    { get; set; }
        public Vector4                                  M_HdrData                               { get; set; }
        public Vector3                                  M_Center                                { get; set; }
        public float                                    M_BlendDistance                         { get; set; }
        public int                                      M_Importance                            { get; set; }
        public int                                      M_BoxProjection                         { get; set; }
        public int                                      M_InstanceId                            { get; set; }
        public int                                      M_TextureId                             { get; set; }

        public static VisibleReflectionProbe? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisibleReflectionProbe() { Pointer= p0 };

            value.M_Bounds                                  = (Bounds)GetInt32(new IntPtr(p + 0x010)); // 0245A2481F10 0x10 M_Bounds                    ( 0001865993A0 ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_LocalToWorldMatrix                      = (Matrix4x4)GetInt32(new IntPtr(p + 0x028)); // 0245A2481F30 0x28 M_LocalToWorldMatrix        ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_HdrData                                 = (Vector4)GetInt32(new IntPtr(p + 0x068)); // 0245A2481F50 0x68 M_HdrData                   ( 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.M_Center                                  = (Vector3)GetInt32(new IntPtr(p + 0x078)); // 0245A2481F70 0x78 M_Center                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_BlendDistance                           = GetSingle(new IntPtr(p + 0x084)); // 0245A2481F90 0x84 M_BlendDistance             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Importance                              = GetInt32(new IntPtr(p + 0x088)); // 0245A2481FB0 0x88 M_Importance                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_BoxProjection                           = GetInt32(new IntPtr(p + 0x08C)); // 0245A2481FD0 0x8C M_BoxProjection             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_InstanceId                              = GetInt32(new IntPtr(p + 0x090)); // 0245A2481FF0 0x90 M_InstanceId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_TextureId                               = GetInt32(new IntPtr(p + 0x094)); // 0245A2482010 0x94 M_TextureId                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
