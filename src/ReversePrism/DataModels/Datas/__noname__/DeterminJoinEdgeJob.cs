using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StepIndex                                ModelPrimitiveType int int int Int32
    // 014 MergeLength                              ModelPrimitiveType float float float Single
    // 018 joinEdgeList                             NativeList`1<JoinEdge> IL2CPP_TYPE_GENERICINST
    // 020 completeVertexSet                        NativeParallelHashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 030 removePairList                           NativeList`1<int2> IL2CPP_TYPE_GENERICINST
    // 038 resultArray                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class DeterminJoinEdgeJob : DataModel
    {
        public int                                      StepIndex                               { get; set; }
        public float                                    MergeLength                             { get; set; }

        public static DeterminJoinEdgeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeterminJoinEdgeJob() { Pointer= p0 };

            value.StepIndex                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 StepIndex                   ( ModelPrimitiveType int int int Int32 )
            value.MergeLength                               = GetSingle(new IntPtr(p + 0x014)); // 0x14 MergeLength                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
