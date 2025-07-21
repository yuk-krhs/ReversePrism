using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartIndex                               ModelPrimitiveType int int int Int32
    // 018 meshLocalPositions                       NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 028 meshLocalNormals                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 038 mappingReferenceIndices                  NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 048 mappingAttributes                        NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 058 mappingPositions                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 068 mappingNormals                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class UpdatePositionNormalJob2 : DataModel
    {
        public int                                      StartIndex                              { get; set; }

        public static UpdatePositionNormalJob2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdatePositionNormalJob2() { Pointer= p0 };

            value.StartIndex                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartIndex                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
