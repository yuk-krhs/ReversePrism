using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 jobVertexIndexList                       NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 030 teamIds                                  NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 040 triangleNormals                          NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 triangleTangents                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 vertexToTriangles                        NativeArray`1<FixedList32Bytes`1<uint>> IL2CPP_TYPE_GENERICINST
    // 070 normalAdjustmentRotations                NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 080 outRotations                             NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class CalcVertexNormalTangentFromTriangleJob : DataModel
    {

        public static CalcVertexNormalTangentFromTriangleJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcVertexNormalTangentFromTriangleJob() { Pointer= p0 };


            return value;
        }
    }
}
