using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_MeshInstanceID                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_SubMeshIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_Transform                              00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 058 M_LightmapScaleOffset                    0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 068 M_RealtimeLightmapScaleOffset            0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class CombineInstance : DataModel
    {
        public int                                      M_MeshInstanceID                        { get; set; }
        public int                                      M_SubMeshIndex                          { get; set; }
        public Matrix4x4                                M_Transform                             { get; set; }
        public Vector4                                  M_LightmapScaleOffset                   { get; set; }
        public Vector4                                  M_RealtimeLightmapScaleOffset           { get; set; }

        public static CombineInstance? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CombineInstance() { Pointer= p0 };

            value.M_MeshInstanceID                          = GetInt32(new IntPtr(p + 0x010)); // 0245A3C65DD8 0x10 M_MeshInstanceID            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_SubMeshIndex                            = GetInt32(new IntPtr(p + 0x014)); // 0245A3C65DF8 0x14 M_SubMeshIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Transform                               = (Matrix4x4)GetInt32(new IntPtr(p + 0x018)); // 0245A3C65E18 0x18 M_Transform                 ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_LightmapScaleOffset                     = (Vector4)GetInt32(new IntPtr(p + 0x058)); // 0245A3C65E38 0x58 M_LightmapScaleOffset       ( 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.M_RealtimeLightmapScaleOffset             = (Vector4)GetInt32(new IntPtr(p + 0x068)); // 0245A3C65E58 0x68 M_RealtimeLightmapScaleOffset ( 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
