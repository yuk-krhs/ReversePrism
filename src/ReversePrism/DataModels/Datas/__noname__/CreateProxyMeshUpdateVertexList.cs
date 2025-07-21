using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 020 processingCounter1                       NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 030 processingList1                          NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CreateProxyMeshUpdateVertexList : DataModel
    {

        public static CreateProxyMeshUpdateVertexList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateProxyMeshUpdateVertexList() { Pointer= p0 };


            return value;
        }
    }
}
