using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 jobParticleIndexList                     NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 frictionArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 040 collisionNormalArray                     NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 velocityPosArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 countArray                               NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 070 sumArray                                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 080 tempFrictionArray                        NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 090 tempNormalArray                          NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class SolveEdgeBufferAndClearJob : DataModel
    {

        public static SolveEdgeBufferAndClearJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SolveEdgeBufferAndClearJob() { Pointer= p0 };


            return value;
        }
    }
}
