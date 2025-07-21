using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 020 pointTriangleContactArray                NativeArray`1<PointTriangleContact> IL2CPP_TYPE_GENERICINST
    // 030 countArray                               NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 040 sumArray                                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class SolverPointTriangleJob : DataModel
    {

        public static SolverPointTriangleJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SolverPointTriangleJob() { Pointer= p0 };


            return value;
        }
    }
}
