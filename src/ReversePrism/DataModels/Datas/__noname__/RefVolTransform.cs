using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PosWS                                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Rot                                      ModelEnumType Quaternion Quaternion Quaternion Int32
    // 02C Scale                                    ModelPrimitiveType float float float Single
    public partial class RefVolTransform : DataModel
    {
        public Vector3                                  PosWS                                   { get; set; }
        public Quaternion                               Rot                                     { get; set; }
        public float                                    Scale                                   { get; set; }

        public static RefVolTransform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RefVolTransform() { Pointer= p0 };

            value.PosWS                                     = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 PosWS                       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Rot                                       = (Quaternion)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Rot                         ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x02C)); // 0x2C Scale                       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
