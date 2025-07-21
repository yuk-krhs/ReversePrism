using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 stepBaseLineIndexArray                   NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 030 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 040 vertexParentIndices                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 050 vertexLocalPositions                     NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 vertexLocalRotations                     NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 070 baseLineStartDataIndices                 NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 080 baseLineDataCounts                       NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 090 baseLineData                             NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0A0 basePosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0B0 baseRotArray                             NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 0C0 stepBasicPositionArray                   NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0D0 stepBasicRotationArray                   NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class UpdateStepBasicPotureJob : DataModel
    {

        public static UpdateStepBasicPotureJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdateStepBasicPotureJob() { Pointer= p0 };


            return value;
        }
    }
}
