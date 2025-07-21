using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 jobBaseLineList                          NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 030 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 040 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 050 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 rotations                                NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 070 vertexLocalPositions                     NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 080 vertexLocalRotations                     NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 090 parentIndices                            NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 0A0 childIndexArray                          NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 0B0 childDataArray                           NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0C0 baseLineFlags                            NativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    // 0D0 baseLineTeamIds                          NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 0E0 baseLineStartIndices                     NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0F0 baseLineCounts                           NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 100 baseLineIndices                          NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    public partial class CalcBaseLineNormalTangentJob : DataModel
    {

        public static CalcBaseLineNormalTangentJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcBaseLineNormalTangentJob() { Pointer= p0 };


            return value;
        }
    }
}
