using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GridSize                                 ModelPrimitiveType float float float Single
    // 014 Vcnt                                     ModelPrimitiveType int int int Int32
    // 018 positins                                 NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 028 gridMap                                  NativeParallelMultiHashMap`2<int3, int> IL2CPP_TYPE_GENERICINST
    public partial class Work_AddVertexIndexGirdMapJob : DataModel
    {
        public float                                    GridSize                                { get; set; }
        public int                                      Vcnt                                    { get; set; }

        public static Work_AddVertexIndexGirdMapJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Work_AddVertexIndexGirdMapJob() { Pointer= p0 };

            value.GridSize                                  = GetSingle(new IntPtr(p + 0x010)); // 0x10 GridSize                    ( ModelPrimitiveType float float float Single )
            value.Vcnt                                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 Vcnt                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
