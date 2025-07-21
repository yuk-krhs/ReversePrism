using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VertexCount                              ModelPrimitiveType int int int Int32
    // 018 joinPairMap                              NativeParallelMultiHashMap`2<ushort, ushort> IL2CPP_TYPE_GENERICINST
    // 028 joinIndices                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 038 vertexToVertexMap                        NativeParallelMultiHashMap`2<ushort, ushort> IL2CPP_TYPE_GENERICINST
    // 048 boneWeights                              NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 058 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 068 result                                   NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 078 tempList                                 NativeList`1<ushort> IL2CPP_TYPE_GENERICINST
    public partial class JoinJob2 : DataModel
    {
        public int                                      VertexCount                             { get; set; }

        public static JoinJob2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JoinJob2() { Pointer= p0 };

            value.VertexCount                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 VertexCount                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
