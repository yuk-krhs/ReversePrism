using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 ParentName                               ModelPrimitiveType string string string String
    // 020 Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C Rotation                                 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 03C Scale                                    ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class SkeletonBone : DataModel
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
            var value   = new SkeletonBone() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.ParentName                                = GetString(new IntPtr(p + 0x018)); // 0x18 ParentName                  ( ModelPrimitiveType string string string String )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Rotation                                  = (Quaternion)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Rotation                    ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Scale                                     = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 0x3C Scale                       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
