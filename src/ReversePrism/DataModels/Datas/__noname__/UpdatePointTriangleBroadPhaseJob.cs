using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 020 oldPosArray                              NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 pointTriangleContactList                 NativeList`1<PointTriangleContact> IL2CPP_TYPE_GENERICINST
    public partial class UpdatePointTriangleBroadPhaseJob : DataModel
    {

        public static UpdatePointTriangleBroadPhaseJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdatePointTriangleBroadPhaseJob() { Pointer= p0 };


            return value;
        }
    }
}
