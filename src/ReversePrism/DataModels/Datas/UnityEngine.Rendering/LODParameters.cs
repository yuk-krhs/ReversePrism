using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_IsOrthographic                         ModelPrimitiveType int int int Int32
    // 014 M_CameraPosition                         ModelEnumType Vector3 Vector3 Vector3 Int32
    // 020 M_FieldOfView                            ModelPrimitiveType float float float Single
    // 024 M_OrthoSize                              ModelPrimitiveType float float float Single
    // 028 M_CameraPixelHeight                      ModelPrimitiveType int int int Int32
    public partial class LODParameters : DataModel
    {
        public int                                      M_IsOrthographic                        { get; set; }
        public Vector3                                  M_CameraPosition                        { get; set; }
        public float                                    M_FieldOfView                           { get; set; }
        public float                                    M_OrthoSize                             { get; set; }
        public int                                      M_CameraPixelHeight                     { get; set; }

        public static LODParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LODParameters() { Pointer= p0 };

            value.M_IsOrthographic                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_IsOrthographic            ( ModelPrimitiveType int int int Int32 )
            value.M_CameraPosition                          = (Vector3)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_CameraPosition            ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_FieldOfView                             = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_FieldOfView               ( ModelPrimitiveType float float float Single )
            value.M_OrthoSize                               = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_OrthoSize                 ( ModelPrimitiveType float float float Single )
            value.M_CameraPixelHeight                       = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_CameraPixelHeight         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
