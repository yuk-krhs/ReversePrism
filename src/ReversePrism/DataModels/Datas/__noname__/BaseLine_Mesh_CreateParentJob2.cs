using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vcnt                                     ModelPrimitiveType int int int Int32
    // 014 AvgDist                                  ModelPrimitiveType float float float Single
    // 018 attribues                                NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 028 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 038 vertexToVertexIndexArray                 NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 048 vertexToVertexDataArray                  NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 058 vertexParentIndices                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 068 vertexChildMap                           NativeParallelMultiHashMap`2<int, ushort> IL2CPP_TYPE_GENERICINST
    // 078 fixedList                                NativeList`1<int> IL2CPP_TYPE_GENERICINST
    // 080 nextList                                 NativeList`1<BaseLineWork> IL2CPP_TYPE_GENERICINST
    // 088 markBuff                                 NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 098 vertexMap                                NativeParallelHashMap`2<int, BaseLineWork> IL2CPP_TYPE_GENERICINST
    public partial class BaseLine_Mesh_CreateParentJob2 : DataModel
    {
        public int                                      Vcnt                                    { get; set; }
        public float                                    AvgDist                                 { get; set; }

        public static BaseLine_Mesh_CreateParentJob2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseLine_Mesh_CreateParentJob2() { Pointer= p0 };

            value.Vcnt                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Vcnt                        ( ModelPrimitiveType int int int Int32 )
            value.AvgDist                                   = GetSingle(new IntPtr(p + 0x014)); // 0x14 AvgDist                     ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
