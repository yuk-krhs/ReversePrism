using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pos                                      ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Rot                                      ModelEnumType Quaternion Quaternion Quaternion Int32
    // 02C Fov                                      ModelPrimitiveType float float float Single
    public partial class CameraData : DataModel
    {
        public Vector3                                  Pos                                     { get; set; }
        public Quaternion                               Rot                                     { get; set; }
        public float                                    Fov                                     { get; set; }

        public static CameraData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraData() { Pointer= p0 };

            value.Pos                                       = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Pos                         ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Rot                                       = (Quaternion)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Rot                         ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Fov                                       = GetSingle(new IntPtr(p + 0x02C)); // 0x2C Fov                         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
