using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ToM                                      ModelEnumType float4x4 float4x4 float4x4 Int32
    // 050 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class TransformPositionJob : DataModel
    {
        public float4x4                                 ToM                                     { get; set; }

        public static TransformPositionJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformPositionJob() { Pointer= p0 };

            value.ToM                                       = (float4x4)GetInt32(new IntPtr(p + 0x010)); // 0x10 ToM                         ( ModelEnumType float4x4 float4x4 float4x4 Int32 )

            return value;
        }
    }
}
