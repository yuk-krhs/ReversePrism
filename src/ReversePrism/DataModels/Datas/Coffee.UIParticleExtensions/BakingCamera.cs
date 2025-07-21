using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               BakingCamera IL2CPP_TYPE_CLASS
    // 008 s_OrthoPosition                          Vector3 IL2CPP_TYPE_VALUETYPE
    // 014 S_OrthoRotation                          ModelEnumType Quaternion Quaternion Quaternion Int32
    // 020 Camera                                   ModelClassType Camera Camera Camera Pointer
    public partial class BakingCamera : DataModel
    {
        public Quaternion                               S_OrthoRotation                         { get; set; }
        public Camera?                                  Camera                                  { get; set; }

        public static BakingCamera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BakingCamera() { Pointer= p0 };

            value.S_OrthoRotation                           = (Quaternion)GetInt32(new IntPtr(p + 0x014)); // 0x14 S_OrthoRotation             ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 Camera                      ( ModelClassType Camera Camera Camera Pointer )

            return value;
        }
    }
}
