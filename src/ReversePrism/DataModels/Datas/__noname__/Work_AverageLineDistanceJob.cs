using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vcnt                                     ModelPrimitiveType int int int Int32
    // 014 Lcnt                                     ModelPrimitiveType int int int Int32
    // 018 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 028 lines                                    NativeArray`1<int2> IL2CPP_TYPE_GENERICINST
    // 038 averageVertexDistance                    NativeReference`1<float> IL2CPP_TYPE_GENERICINST
    // 048 averageCount                             NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 058 maxVertexDistance                        NativeReference`1<float> IL2CPP_TYPE_GENERICINST
    public partial class Work_AverageLineDistanceJob : DataModel
    {
        public int                                      Vcnt                                    { get; set; }
        public int                                      Lcnt                                    { get; set; }

        public static Work_AverageLineDistanceJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Work_AverageLineDistanceJob() { Pointer= p0 };

            value.Vcnt                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Vcnt                        ( ModelPrimitiveType int int int Int32 )
            value.Lcnt                                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 Lcnt                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
