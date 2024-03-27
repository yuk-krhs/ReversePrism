using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 ParentName                               000186671BA0 ModelPrimitiveType string string string String
    // 020 Position                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C Rotation                                 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 03C Scale                                    0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class SkeletonBone
    {
        public string                                   Name                                    { get; set; }
        public string                                   ParentName                              { get; set; }
        public Vector3                                  Position                                { get; set; }
        public Quaternion                               Rotation                                { get; set; }
        public Vector3                                  Scale                                   { get; set; }

        public static SkeletonBone? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkeletonBone();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270022883F8 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ParentName                                = GetString(new IntPtr(p + 0x018)); // 027002288418 0x18 ParentName                  ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 027002288438 0x20 Position                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Rotation                                  = (Quaternion)GetInt32(new IntPtr(p + 0x02C)); // 027002288458 0x2C Rotation                    ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Scale                                     = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 027002288478 0x3C Scale                       ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
