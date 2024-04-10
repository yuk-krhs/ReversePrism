using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 RotationSpeed                            float IL2CPP_TYPE_R4
    // 020 DefaultRotation                          000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 030 LastDragPos                              0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C IsInputPossible                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 CameraTransform                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class HomeCameraInputManager : DataModel
    {
        public Quaternion                               DefaultRotation                         { get; set; }
        public Vector3                                  LastDragPos                             { get; set; }
        public bool                                     IsInputPossible                         { get; set; }
        public Transform?                               CameraTransform                         { get; set; }

        public static HomeCameraInputManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeCameraInputManager() { Pointer= p0 };

            value.DefaultRotation                           = (Quaternion)GetInt32(new IntPtr(p + 0x020)); // 02466535AE88 0x20 DefaultRotation             ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.LastDragPos                               = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 02466535AEA8 0x30 LastDragPos                 ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.IsInputPossible                           = GetBool(new IntPtr(p + 0x03C)); // 02466535AEC8 0x3C IsInputPossible             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CameraTransform                           = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 02466535AEE8 0x40 CameraTransform             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
