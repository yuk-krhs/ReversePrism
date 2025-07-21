using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ToP                                      ModelEnumType float4x4 float4x4 float4x4 Int32
    // 050 Vcnt                                     ModelPrimitiveType int int int Int32
    // 054 MergeChunk                               ModelEnumType DataChunk DataChunk DataChunk Int32
    // 060 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 080 joinIndices                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 090 proxyAttributes                          NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 0A0 proxyLocalPositions                      NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0B0 mappingWorkData                          NativeArray`1<MappingWorkData> IL2CPP_TYPE_GENERICINST
    public partial class Mapping_DirectConnectionVertexDataJob : DataModel
    {
        public float4x4                                 ToP                                     { get; set; }
        public int                                      Vcnt                                    { get; set; }
        public DataChunk                                MergeChunk                              { get; set; }

        public static Mapping_DirectConnectionVertexDataJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Mapping_DirectConnectionVertexDataJob() { Pointer= p0 };

            value.ToP                                       = (float4x4)GetInt32(new IntPtr(p + 0x010)); // 0x10 ToP                         ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.Vcnt                                      = GetInt32(new IntPtr(p + 0x050)); // 0x50 Vcnt                        ( ModelPrimitiveType int int int Int32 )
            value.MergeChunk                                = (DataChunk)GetInt32(new IntPtr(p + 0x054)); // 0x54 MergeChunk                  ( ModelEnumType DataChunk DataChunk DataChunk Int32 )

            return value;
        }
    }
}
