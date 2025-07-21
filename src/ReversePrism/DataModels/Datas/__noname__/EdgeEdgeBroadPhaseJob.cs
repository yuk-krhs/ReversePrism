using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 020 primitiveArray                           NativeArray`1<Primitive> IL2CPP_TYPE_GENERICINST
    // 030 sortAndSweepArray                        NativeArray`1<SortData> IL2CPP_TYPE_GENERICINST
    // 040 processingEdgeEdgeArray                  NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 050 edgeEdgeContactQueue                     ParallelWriter<EdgeEdgeContact> IL2CPP_TYPE_GENERICINST
    // 068 intersectFlagArray                       NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    public partial class EdgeEdgeBroadPhaseJob : DataModel
    {

        public static EdgeEdgeBroadPhaseJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EdgeEdgeBroadPhaseJob() { Pointer= p0 };


            return value;
        }
    }
}
