using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MatParent                                00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 050 Transform                                0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 058 ParentIdx                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 05C LenFromParent                            000186666050 ModelPrimitiveType float float float Single
    // 060 AllowRadius                              000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 068 Pos                                      0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 074 V                                        0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 Feedback                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 08C InitPos                                  0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 098 ZeroPos                                  0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0A4 InitRot                                  00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 0B4 BoneInitPos                              0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0C0 CollideOffset                            0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Point : DataModel
    {
        public Matrix4x4                                MatParent                               { get; set; }
        public Transform?                               Transform                               { get; set; }
        public int                                      ParentIdx                               { get; set; }
        public float                                    LenFromParent                           { get; set; }
        public List<float>?                             AllowRadius                             { get; set; }
        public Vector3                                  Pos                                     { get; set; }
        public Vector3                                  V                                       { get; set; }
        public Vector3                                  Feedback                                { get; set; }
        public Vector3                                  InitPos                                 { get; set; }
        public Vector3                                  ZeroPos                                 { get; set; }
        public Quaternion                               InitRot                                 { get; set; }
        public Vector3                                  BoneInitPos                             { get; set; }
        public int                                      CollideOffset                           { get; set; }

        public static Point? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Point() { Pointer= p0 };

            value.MatParent                                 = (Matrix4x4)GetInt32(new IntPtr(p + 0x010)); // 0245A69C35F8 0x10 MatParent                   ( 00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Transform                                 = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0245A69C3618 0x50 Transform                   ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.ParentIdx                                 = GetInt32(new IntPtr(p + 0x058)); // 0245A69C3638 0x58 ParentIdx                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LenFromParent                             = GetSingle(new IntPtr(p + 0x05C)); // 0245A69C3658 0x5C LenFromParent               ( 000186666050 ModelPrimitiveType float float float Single )
            value.AllowRadius                               = GetSingleList(new IntPtr(p + 0x060)); // 0245A69C3678 0x60 AllowRadius                 ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Pos                                       = (Vector3)GetInt32(new IntPtr(p + 0x068)); // 0245A69C3698 0x68 Pos                         ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.V                                         = (Vector3)GetInt32(new IntPtr(p + 0x074)); // 0245A69C36B8 0x74 V                           ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Feedback                                  = (Vector3)GetInt32(new IntPtr(p + 0x080)); // 0245A69C36D8 0x80 Feedback                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.InitPos                                   = (Vector3)GetInt32(new IntPtr(p + 0x08C)); // 0245A69C36F8 0x8C InitPos                     ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ZeroPos                                   = (Vector3)GetInt32(new IntPtr(p + 0x098)); // 0245A69C3718 0x98 ZeroPos                     ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.InitRot                                   = (Quaternion)GetInt32(new IntPtr(p + 0x0A4)); // 0245A69C3738 0xA4 InitRot                     ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.BoneInitPos                               = (Vector3)GetInt32(new IntPtr(p + 0x0B4)); // 0245A69C3758 0xB4 BoneInitPos                 ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CollideOffset                             = GetInt32(new IntPtr(p + 0x0C0)); // 0245A69C3778 0xC0 CollideOffset               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
