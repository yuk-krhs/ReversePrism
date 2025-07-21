using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GridSize                                 ModelPrimitiveType float float float Single
    // 014 Radius                                   ModelPrimitiveType float float float Single
    // 018 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 028 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 038 gridMap                                  NativeParallelMultiHashMap`2<int3, int> IL2CPP_TYPE_GENERICINST
    // 048 selectionPositions                       NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 058 selectionAttributes                      NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    public partial class Proxy_ApplySelectionJob : DataModel
    {
        public float                                    GridSize                                { get; set; }
        public float                                    Radius                                  { get; set; }

        public static Proxy_ApplySelectionJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Proxy_ApplySelectionJob() { Pointer= p0 };

            value.GridSize                                  = GetSingle(new IntPtr(p + 0x010)); // 0x10 GridSize                    ( ModelPrimitiveType float float float Single )
            value.Radius                                    = GetSingle(new IntPtr(p + 0x014)); // 0x14 Radius                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
