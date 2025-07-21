using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_MaximumCullingPlaneCount               int IL2CPP_TYPE_I4
    // 000 maximumCullingPlaneCount                 int IL2CPP_TYPE_I4
    // 010 M_CullingPlaneCount                      ModelPrimitiveType int int int Int32
    // 014 M_CullingPlanes                          ModelEnumType <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer Int32
    // 0B4 M_CullingSphere                          ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0C4 M_ShadowCascadeBlendCullingFactor        ModelPrimitiveType float float float Single
    // 0C8 M_CullingNearPlane                       ModelPrimitiveType float float float Single
    // 0CC M_CullingMatrix                          ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    public partial class ShadowSplitData : DataModel
    {
        public int                                      M_CullingPlaneCount                     { get; set; }
        public <m_CullingPlanes>e__FixedBuffer          M_CullingPlanes                         { get; set; }
        public Vector4                                  M_CullingSphere                         { get; set; }
        public float                                    M_ShadowCascadeBlendCullingFactor       { get; set; }
        public float                                    M_CullingNearPlane                      { get; set; }
        public Matrix4x4                                M_CullingMatrix                         { get; set; }

        public static ShadowSplitData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShadowSplitData() { Pointer= p0 };

            value.M_CullingPlaneCount                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_CullingPlaneCount         ( ModelPrimitiveType int int int Int32 )
            value.M_CullingPlanes                           = (<m_CullingPlanes>e__FixedBuffer)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_CullingPlanes             ( ModelEnumType <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer Int32 )
            value.M_CullingSphere                           = (Vector4)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 M_CullingSphere             ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.M_ShadowCascadeBlendCullingFactor         = GetSingle(new IntPtr(p + 0x0C4)); // 0xC4 M_ShadowCascadeBlendCullingFactor ( ModelPrimitiveType float float float Single )
            value.M_CullingNearPlane                        = GetSingle(new IntPtr(p + 0x0C8)); // 0xC8 M_CullingNearPlane          ( ModelPrimitiveType float float float Single )
            value.M_CullingMatrix                           = (Matrix4x4)GetInt32(new IntPtr(p + 0x0CC)); // 0xCC M_CullingMatrix             ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )

            return value;
        }
    }
}
