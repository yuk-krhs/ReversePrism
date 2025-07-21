using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GridSize                                 ModelPrimitiveType float float float Single
    // 014 SearchRadius                             ModelPrimitiveType float float float Single
    // 018 ToP                                      ModelEnumType float4x4 float4x4 float4x4 Int32
    // 058 Vcnt                                     ModelPrimitiveType int int int Int32
    // 060 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 boneWeights                              NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 080 transformIds                             NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 090 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 0A0 gridMap                                  NativeParallelMultiHashMap`2<int3, int> IL2CPP_TYPE_GENERICINST
    // 0B0 proxyAttributes                          NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 0C0 proxyLocalPositions                      NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0D0 proxyBoneWeights                         NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 0E0 proxyTransformIds                        NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 0F0 mappingWorkData                          NativeArray`1<MappingWorkData> IL2CPP_TYPE_GENERICINST
    public partial class Mapping_CalcConnectionVertexDataJob : DataModel
    {
        public float                                    GridSize                                { get; set; }
        public float                                    SearchRadius                            { get; set; }
        public float4x4                                 ToP                                     { get; set; }
        public int                                      Vcnt                                    { get; set; }

        public static Mapping_CalcConnectionVertexDataJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Mapping_CalcConnectionVertexDataJob() { Pointer= p0 };

            value.GridSize                                  = GetSingle(new IntPtr(p + 0x010)); // 0x10 GridSize                    ( ModelPrimitiveType float float float Single )
            value.SearchRadius                              = GetSingle(new IntPtr(p + 0x014)); // 0x14 SearchRadius                ( ModelPrimitiveType float float float Single )
            value.ToP                                       = (float4x4)GetInt32(new IntPtr(p + 0x018)); // 0x18 ToP                         ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.Vcnt                                      = GetInt32(new IntPtr(p + 0x058)); // 0x58 Vcnt                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
