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
    // 028 RayDir                                   ModelEnumType float3 float3 float3 Int32
    // 034 LocalPointRadius                         ModelPrimitiveType float float float Single
    // 038 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 048 vertexToTriangles                        NativeArray`1<FixedList32Bytes`1<int>> IL2CPP_TYPE_GENERICINST
    // 058 hitList                                  ParallelWriter<VirtualMeshRaycastHit> IL2CPP_TYPE_GENERICINST
    public partial class Work_IntersectPointJob : DataModel
    {
        public float3                                   LocalRayPos                             { get; set; }
        public float3                                   LocalRayDir                             { get; set; }
        public float3                                   RayDir                                  { get; set; }
        public float                                    LocalPointRadius                        { get; set; }

        public static Work_IntersectPointJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Work_IntersectPointJob() { Pointer= p0 };

            value.LocalRayPos                               = (float3)GetInt32(new IntPtr(p + 0x010)); // 0x10 LocalRayPos                 ( ModelEnumType float3 float3 float3 Int32 )
            value.LocalRayDir                               = (float3)GetInt32(new IntPtr(p + 0x01C)); // 0x1C LocalRayDir                 ( ModelEnumType float3 float3 float3 Int32 )
            value.RayDir                                    = (float3)GetInt32(new IntPtr(p + 0x028)); // 0x28 RayDir                      ( ModelEnumType float3 float3 float3 Int32 )
            value.LocalPointRadius                          = GetSingle(new IntPtr(p + 0x034)); // 0x34 LocalPointRadius            ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
