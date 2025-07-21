using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vcnt                                     ModelPrimitiveType int int int Int32
    // 014 WeightLength                             ModelPrimitiveType float float float Single
    // 018 mappingWorkData                          NativeArray`1<MappingWorkData> IL2CPP_TYPE_GENERICINST
    // 028 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 038 boneWeights                              NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 048 proxyLocalPositions                      NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 058 proxyVertexToVertexIndexArray            NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 068 proxyVertexToVertexDataArray             NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 078 useSet                                   NativeParallelHashSet`1<ushort> IL2CPP_TYPE_GENERICINST
    public partial class Mapping_CalcDirectWeightJob : DataModel
    {
        public int                                      Vcnt                                    { get; set; }
        public float                                    WeightLength                            { get; set; }

        public static Mapping_CalcDirectWeightJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Mapping_CalcDirectWeightJob() { Pointer= p0 };

            value.Vcnt                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Vcnt                        ( ModelPrimitiveType int int int Int32 )
            value.WeightLength                              = GetSingle(new IntPtr(p + 0x014)); // 0x14 WeightLength                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
