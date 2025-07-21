using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 jobTriangleList                          NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 030 triangleTeamIdArray                      NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 040 triangles                                NativeArray`1<int3> IL2CPP_TYPE_GENERICINST
    // 050 outTriangleNormals                       NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 outTriangleTangents                      NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 080 uv                                       NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    public partial class CalcTriangleNormalTangentJob : DataModel
    {

        public static CalcTriangleNormalTangentJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcTriangleNormalTangentJob() { Pointer= p0 };


            return value;
        }
    }
}
