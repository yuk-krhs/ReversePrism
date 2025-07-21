using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 stepParticleIndexArray                   NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 030 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 040 teamIdArray                              NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 050 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 writeIndexArray                          NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 070 writeBuffer                              NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class SolveAggregateBufferJob : DataModel
    {

        public static SolveAggregateBufferJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SolveAggregateBufferJob() { Pointer= p0 };


            return value;
        }
    }
}
