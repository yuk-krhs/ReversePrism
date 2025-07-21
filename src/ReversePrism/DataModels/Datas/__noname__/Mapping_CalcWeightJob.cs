using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 mappingWorkData                          NativeArray`1<MappingWorkData> IL2CPP_TYPE_GENERICINST
    // 020 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 030 boneWeights                              NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 040 proxyAttributes                          NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 050 proxyLocalPositions                      NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 proxyLocalNormals                        NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 proxyVertexToVertexIndexArray            NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 080 proxyVertexToVertexDataArray             NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    public partial class Mapping_CalcWeightJob : DataModel
    {

        public static Mapping_CalcWeightJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Mapping_CalcWeightJob() { Pointer= p0 };


            return value;
        }
    }
}
