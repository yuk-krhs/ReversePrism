using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SphereCenter                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C SphereRadius                             ModelPrimitiveType float float float Single
    // 020 CullingPlaneOffset                       ModelPrimitiveType int int int Int32
    // 024 CullingPlaneCount                        ModelPrimitiveType int int int Int32
    // 028 CascadeBlendCullingFactor                ModelPrimitiveType float float float Single
    // 02C NearPlane                                ModelPrimitiveType float float float Single
    // 030 CullingMatrix                            ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    public partial class CullingSplit : DataModel
    {
        public Vector3                                  SphereCenter                            { get; set; }
        public float                                    SphereRadius                            { get; set; }
        public int                                      CullingPlaneOffset                      { get; set; }
        public int                                      CullingPlaneCount                       { get; set; }
        public float                                    CascadeBlendCullingFactor               { get; set; }
        public float                                    NearPlane                               { get; set; }
        public Matrix4x4                                CullingMatrix                           { get; set; }

        public static CullingSplit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CullingSplit() { Pointer= p0 };

            value.SphereCenter                              = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 SphereCenter                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.SphereRadius                              = GetSingle(new IntPtr(p + 0x01C)); // 0x1C SphereRadius                ( ModelPrimitiveType float float float Single )
            value.CullingPlaneOffset                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 CullingPlaneOffset          ( ModelPrimitiveType int int int Int32 )
            value.CullingPlaneCount                         = GetInt32(new IntPtr(p + 0x024)); // 0x24 CullingPlaneCount           ( ModelPrimitiveType int int int Int32 )
            value.CascadeBlendCullingFactor                 = GetSingle(new IntPtr(p + 0x028)); // 0x28 CascadeBlendCullingFactor   ( ModelPrimitiveType float float float Single )
            value.NearPlane                                 = GetSingle(new IntPtr(p + 0x02C)); // 0x2C NearPlane                   ( ModelPrimitiveType float float float Single )
            value.CullingMatrix                             = (Matrix4x4)GetInt32(new IntPtr(p + 0x030)); // 0x30 CullingMatrix               ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )

            return value;
        }
    }
}
