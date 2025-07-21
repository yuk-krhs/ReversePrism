using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OverrideCamera                           ModelPrimitiveType bool bool bool Bool
    // 011 RestoreCamera                            ModelPrimitiveType bool bool bool Bool
    // 014 Offset                                   ModelEnumType Vector4 Vector4 Vector4 Int32
    // 024 CameraFieldOfView                        ModelPrimitiveType float float float Single
    public partial class CustomCameraSettings : DataModel
    {
        public bool                                     OverrideCamera                          { get; set; }
        public bool                                     RestoreCamera                           { get; set; }
        public Vector4                                  Offset                                  { get; set; }
        public float                                    CameraFieldOfView                       { get; set; }

        public static CustomCameraSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomCameraSettings() { Pointer= p0 };

            value.OverrideCamera                            = GetBool(new IntPtr(p + 0x010)); // 0x10 OverrideCamera              ( ModelPrimitiveType bool bool bool Bool )
            value.RestoreCamera                             = GetBool(new IntPtr(p + 0x011)); // 0x11 RestoreCamera               ( ModelPrimitiveType bool bool bool Bool )
            value.Offset                                    = (Vector4)GetInt32(new IntPtr(p + 0x014)); // 0x14 Offset                      ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.CameraFieldOfView                         = GetSingle(new IntPtr(p + 0x024)); // 0x24 CameraFieldOfView           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
