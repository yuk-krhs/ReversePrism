using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MatBone0                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 050 MatBone1                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 090 MatBone2                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0D0 MatBone3                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 110 MatBone4                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 150 MatBone5                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 190 MatBone6                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 1D0 MatBone7                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 210 MatBone8                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 250 InvBone0                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 290 InvBone1                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 2D0 InvBone2                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 310 InvBone3                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 350 InvBone4                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 390 InvBone5                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 3D0 InvBone6                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 410 InvBone7                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 450 InvBone8                                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 490 HitPlane                                 ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class BoneColliderParam : DataModel
    {
        public Matrix4x4                                MatBone0                                { get; set; }
        public Matrix4x4                                MatBone1                                { get; set; }
        public Matrix4x4                                MatBone2                                { get; set; }
        public Matrix4x4                                MatBone3                                { get; set; }
        public Matrix4x4                                MatBone4                                { get; set; }
        public Matrix4x4                                MatBone5                                { get; set; }
        public Matrix4x4                                MatBone6                                { get; set; }
        public Matrix4x4                                MatBone7                                { get; set; }
        public Matrix4x4                                MatBone8                                { get; set; }
        public Matrix4x4                                InvBone0                                { get; set; }
        public Matrix4x4                                InvBone1                                { get; set; }
        public Matrix4x4                                InvBone2                                { get; set; }
        public Matrix4x4                                InvBone3                                { get; set; }
        public Matrix4x4                                InvBone4                                { get; set; }
        public Matrix4x4                                InvBone5                                { get; set; }
        public Matrix4x4                                InvBone6                                { get; set; }
        public Matrix4x4                                InvBone7                                { get; set; }
        public Matrix4x4                                InvBone8                                { get; set; }
        public Vector4                                  HitPlane                                { get; set; }

        public static BoneColliderParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoneColliderParam() { Pointer= p0 };

            value.MatBone0                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x010)); // 0x10 MatBone0                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.MatBone1                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x050)); // 0x50 MatBone1                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.MatBone2                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x090)); // 0x90 MatBone2                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.MatBone3                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 MatBone3                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.MatBone4                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x110)); // 0x110 MatBone4                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.MatBone5                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x150)); // 0x150 MatBone5                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.MatBone6                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x190)); // 0x190 MatBone6                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.MatBone7                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x1D0)); // 0x1D0 MatBone7                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.MatBone8                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x210)); // 0x210 MatBone8                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.InvBone0                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x250)); // 0x250 InvBone0                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.InvBone1                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x290)); // 0x290 InvBone1                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.InvBone2                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x2D0)); // 0x2D0 InvBone2                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.InvBone3                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x310)); // 0x310 InvBone3                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.InvBone4                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x350)); // 0x350 InvBone4                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.InvBone5                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x390)); // 0x390 InvBone5                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.InvBone6                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x3D0)); // 0x3D0 InvBone6                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.InvBone7                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x410)); // 0x410 InvBone7                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.InvBone8                                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x450)); // 0x450 InvBone8                    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.HitPlane                                  = (Vector4)GetInt32(new IntPtr(p + 0x490)); // 0x490 HitPlane                    ( ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
