using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalRayPos                              ModelEnumType float3 float3 float3 Int32
    // 01C LocalRayDir                              ModelEnumType float3 float3 float3 Int32
    // 028 LocalRayEndPos                           ModelEnumType float3 float3 float3 Int32
    // 034 DoubleSide                               ModelPrimitiveType bool bool bool Bool
    // 038 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 048 triangles                                NativeArray`1<int3> IL2CPP_TYPE_GENERICINST
    // 058 hitList                                  ParallelWriter<VirtualMeshRaycastHit> IL2CPP_TYPE_GENERICINST
    public partial class Work_IntersectTriangleJob : DataModel
    {
        public float3                                   LocalRayPos                             { get; set; }
        public float3                                   LocalRayDir                             { get; set; }
        public float3                                   LocalRayEndPos                          { get; set; }
        public bool                                     DoubleSide                              { get; set; }

        public static Work_IntersectTriangleJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Work_IntersectTriangleJob() { Pointer= p0 };

            value.LocalRayPos                               = (float3)GetInt32(new IntPtr(p + 0x010)); // 0x10 LocalRayPos                 ( ModelEnumType float3 float3 float3 Int32 )
            value.LocalRayDir                               = (float3)GetInt32(new IntPtr(p + 0x01C)); // 0x1C LocalRayDir                 ( ModelEnumType float3 float3 float3 Int32 )
            value.LocalRayEndPos                            = (float3)GetInt32(new IntPtr(p + 0x028)); // 0x28 LocalRayEndPos              ( ModelEnumType float3 float3 float3 Int32 )
            value.DoubleSide                                = GetBool(new IntPtr(p + 0x034)); // 0x34 DoubleSide                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
