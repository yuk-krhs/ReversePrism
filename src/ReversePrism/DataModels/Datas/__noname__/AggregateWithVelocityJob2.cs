using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 particleIndexArray                       NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 velocityPosArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 VelocityAttenuation                      ModelPrimitiveType float float float Single
    // 048 countArray                               NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 058 sumArray                                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class AggregateWithVelocityJob2 : DataModel
    {
        public float                                    VelocityAttenuation                     { get; set; }

        public static AggregateWithVelocityJob2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AggregateWithVelocityJob2() { Pointer= p0 };

            value.VelocityAttenuation                       = GetSingle(new IntPtr(p + 0x040)); // 0x40 VelocityAttenuation         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
