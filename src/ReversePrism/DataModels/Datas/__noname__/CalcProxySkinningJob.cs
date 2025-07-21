using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 020 mappingDataArray                         NativeArray`1<MappingData> IL2CPP_TYPE_GENERICINST
    // 030 mappingIdArray                           NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 040 mappingAttributes                        NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 050 mappingLocalPositions                    NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 mappingLocalNormals                      NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 mappingBoneWeights                       NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 080 mappingPositions                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 090 mappingNormals                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A0 proxyPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0B0 proxyRotations                           NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 0C0 proxyVertexBindPosePositions             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0D0 proxyVertexBindPoseRotations             NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class CalcProxySkinningJob : DataModel
    {

        public static CalcProxySkinningJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcProxySkinningJob() { Pointer= p0 };


            return value;
        }
    }
}
