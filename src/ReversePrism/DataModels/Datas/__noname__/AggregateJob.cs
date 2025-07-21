using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 jobParticleIndexList                     NativeList`1<int> IL2CPP_TYPE_GENERICINST
    // 018 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 028 countArray                               NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 038 sumArray                                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class AggregateJob : DataModel
    {

        public static AggregateJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AggregateJob() { Pointer= p0 };


            return value;
        }
    }
}
