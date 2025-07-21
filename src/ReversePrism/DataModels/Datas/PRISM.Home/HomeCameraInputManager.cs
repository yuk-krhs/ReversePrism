using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 RotationSpeed                            float IL2CPP_TYPE_R4
    // 020 DefaultRotation                          ModelEnumType Quaternion Quaternion Quaternion Int32
    // 030 LastDragPos                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C IsInputPossible                          ModelPrimitiveType bool bool bool Bool
    // 040 CameraTransform                          ModelClassType Transform Transform Transform Pointer
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

            value.DefaultRotation                           = (Quaternion)GetInt32(new IntPtr(p + 0x020)); // 0x20 DefaultRotation             ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.LastDragPos                               = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 0x30 LastDragPos                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.IsInputPossible                           = GetBool(new IntPtr(p + 0x03C)); // 0x3C IsInputPossible             ( ModelPrimitiveType bool bool bool Bool )
            value.CameraTransform                           = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0x40 CameraTransform             ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
