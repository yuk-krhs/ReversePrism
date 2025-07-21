using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Transform                                ModelClassType Transform Transform Transform Pointer
    // 018 Id                                       ModelPrimitiveType int int int Int32
    // 01C LocalPosition                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 028 LocalRotation                            ModelEnumType Quaternion Quaternion Quaternion Int32
    // 038 Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 Rotation                                 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 054 Scale                                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 060 LocalToWorldMatrix                       ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0A0 WorldToLocalMatrix                       ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0E0 Pid                                      ModelPrimitiveType int int int Int32
    public partial class TransformRecord : DataModel
    {
        public Transform?                               Transform                               { get; set; }
        public int                                      Id                                      { get; set; }
        public Vector3                                  LocalPosition                           { get; set; }
        public Quaternion                               LocalRotation                           { get; set; }
        public Vector3                                  Position                                { get; set; }
        public Quaternion                               Rotation                                { get; set; }
        public Vector3                                  Scale                                   { get; set; }
        public Matrix4x4                                LocalToWorldMatrix                      { get; set; }
        public Matrix4x4                                WorldToLocalMatrix                      { get; set; }
        public int                                      Pid                                     { get; set; }

        public static TransformRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformRecord() { Pointer= p0 };

            value.Transform                                 = GetObject<Transform>(new IntPtr(p + 0x010), ReversePrism.DataModels.Transform.FromPointer); // 0x10 Transform                   ( ModelClassType Transform Transform Transform Pointer )
            value.Id                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Id                          ( ModelPrimitiveType int int int Int32 )
            value.LocalPosition                             = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 0x1C LocalPosition               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LocalRotation                             = (Quaternion)GetInt32(new IntPtr(p + 0x028)); // 0x28 LocalRotation               ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0x38 Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Rotation                                  = (Quaternion)GetInt32(new IntPtr(p + 0x044)); // 0x44 Rotation                    ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Scale                                     = (Vector3)GetInt32(new IntPtr(p + 0x054)); // 0x54 Scale                       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LocalToWorldMatrix                        = (Matrix4x4)GetInt32(new IntPtr(p + 0x060)); // 0x60 LocalToWorldMatrix          ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.WorldToLocalMatrix                        = (Matrix4x4)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 WorldToLocalMatrix          ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Pid                                       = GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 Pid                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
