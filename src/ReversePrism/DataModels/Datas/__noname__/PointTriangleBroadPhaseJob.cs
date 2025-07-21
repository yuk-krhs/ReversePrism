using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MainKind                                 ModelPrimitiveType uint uint uint UInt32
    // 018 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 028 triangles                                NativeArray`1<int3> IL2CPP_TYPE_GENERICINST
    // 038 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 048 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 058 oldPosArray                              NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 068 frictionArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 078 primitiveArray                           NativeArray`1<Primitive> IL2CPP_TYPE_GENERICINST
    // 088 sortAndSweepArray                        NativeArray`1<SortData> IL2CPP_TYPE_GENERICINST
    // 098 processingPointTriangleArray             NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 0A8 pointTriangleContactQueue                ParallelWriter<PointTriangleContact> IL2CPP_TYPE_GENERICINST
    // 0C0 intersectFlagArray                       NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    public partial class PointTriangleBroadPhaseJob : DataModel
    {
        public uint                                     MainKind                                { get; set; }

        public static PointTriangleBroadPhaseJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointTriangleBroadPhaseJob() { Pointer= p0 };

            value.MainKind                                  = GetUInt32(new IntPtr(p + 0x010)); // 0x10 MainKind                    ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
