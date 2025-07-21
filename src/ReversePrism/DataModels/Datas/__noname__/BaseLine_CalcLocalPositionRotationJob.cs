using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 parentIndices                            NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 localNormals                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 localTangents                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 baseLineIndices                          NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 060 vertexLocalPositions                     NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 vertexLocalRotations                     NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class BaseLine_CalcLocalPositionRotationJob : DataModel
    {

        public static BaseLine_CalcLocalPositionRotationJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseLine_CalcLocalPositionRotationJob() { Pointer= p0 };


            return value;
        }
    }
}
