using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vcnt                                     ModelPrimitiveType int int int Int32
    // 018 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 028 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 038 vertexToVertexIndexArray                 NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 048 vertexToVertexDataArray                  NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 058 outAABB                                  NativeReference`1<AABB> IL2CPP_TYPE_GENERICINST
    // 068 fixedList                                NativeList`1<ushort> IL2CPP_TYPE_GENERICINST
    // 070 localCenterPosition                      NativeReference`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class ProxyCreateFixedListAndAABBJob : DataModel
    {
        public int                                      Vcnt                                    { get; set; }

        public static ProxyCreateFixedListAndAABBJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProxyCreateFixedListAndAABBJob() { Pointer= p0 };

            value.Vcnt                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Vcnt                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
