using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Center                                   ModelEnumType float3 float3 float3 Int32
    // 020 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 vertexParentIndices                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 040 vertexChildIndexArray                    NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 050 vertexChildDataArray                     NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 060 localNormals                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 localTangents                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 080 normalAdjustmentRotations                NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class ProxyNormalRadiationAdjustmentJob : DataModel
    {
        public float3                                   Center                                  { get; set; }

        public static ProxyNormalRadiationAdjustmentJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProxyNormalRadiationAdjustmentJob() { Pointer= p0 };

            value.Center                                    = (float3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Center                      ( ModelEnumType float3 float3 float3 Int32 )

            return value;
        }
    }
}
