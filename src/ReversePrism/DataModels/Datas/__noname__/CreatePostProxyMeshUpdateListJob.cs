using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 020 processingCounter0                       NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 030 processingList0                          NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 040 processingCounter1                       NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 050 processingList1                          NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 060 processingCounter2                       NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 070 processingList2                          NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 080 processingCounter3                       NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 090 processingList3                          NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CreatePostProxyMeshUpdateListJob : DataModel
    {

        public static CreatePostProxyMeshUpdateListJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreatePostProxyMeshUpdateListJob() { Pointer= p0 };


            return value;
        }
    }
}
