using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_MinusYtoZRotation                      quaternion IL2CPP_TYPE_VALUETYPE
    // 010 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 020 rotations                                NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 030 scales                                   NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 dirty                                    NativeArray`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 scaleModes                               NativeArray`1<DecalScaleMode> IL2CPP_TYPE_GENERICINST
    // 060 sizeOffsets                              NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 070 decalToWorlds                            NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 080 normalToWorlds                           NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 090 boundingSpheres                          NativeArray`1<BoundingSphere> IL2CPP_TYPE_GENERICINST
    // 0A0 MinDistance                              ModelPrimitiveType float float float Single
    public partial class UpdateTransformsJob : DataModel
    {
        public float                                    MinDistance                             { get; set; }

        public static UpdateTransformsJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdateTransformsJob() { Pointer= p0 };

            value.MinDistance                               = GetSingle(new IntPtr(p + 0x0A0)); // 0xA0 MinDistance                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
