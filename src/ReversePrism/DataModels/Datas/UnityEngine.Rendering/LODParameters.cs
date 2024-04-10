using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_IsOrthographic                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_CameraPosition                         0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 020 M_FieldOfView                            0001866656B0 ModelPrimitiveType float float float Single
    // 024 M_OrthoSize                              0001866656B0 ModelPrimitiveType float float float Single
    // 028 M_CameraPixelHeight                      0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.M_IsOrthographic                          = GetInt32(new IntPtr(p + 0x010)); // 0245A2448D40 0x10 M_IsOrthographic            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CameraPosition                          = (Vector3)GetInt32(new IntPtr(p + 0x014)); // 0245A2448D60 0x14 M_CameraPosition            ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_FieldOfView                             = GetSingle(new IntPtr(p + 0x020)); // 0245A2448D80 0x20 M_FieldOfView               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_OrthoSize                               = GetSingle(new IntPtr(p + 0x024)); // 0245A2448DA0 0x24 M_OrthoSize                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_CameraPixelHeight                       = GetInt32(new IntPtr(p + 0x028)); // 0245A2448DC0 0x28 M_CameraPixelHeight         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
