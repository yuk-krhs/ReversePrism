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
    // 028 velocityPosArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 038 VelocityAttenuation                      ModelPrimitiveType float float float Single
    // 040 countArray                               NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 050 sumArray                                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class AggregateWithVelocityJob : DataModel
    {
        public float                                    VelocityAttenuation                     { get; set; }

        public static AggregateWithVelocityJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AggregateWithVelocityJob() { Pointer= p0 };

            value.VelocityAttenuation                       = GetSingle(new IntPtr(p + 0x038)); // 0x38 VelocityAttenuation         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
