using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vcnt                                     ModelPrimitiveType int int int Int32
    // 014 GridSize                                 ModelPrimitiveType float float float Single
    // 018 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 028 joinIndices                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 038 gridMap                                  NativeParallelMultiHashMap`2<int3, int> IL2CPP_TYPE_GENERICINST
    public partial class InitGridJob : DataModel
    {
        public int                                      Vcnt                                    { get; set; }
        public float                                    GridSize                                { get; set; }

        public static InitGridJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InitGridJob() { Pointer= p0 };

            value.Vcnt                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Vcnt                        ( ModelPrimitiveType int int int Int32 )
            value.GridSize                                  = GetSingle(new IntPtr(p + 0x014)); // 0x14 GridSize                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
