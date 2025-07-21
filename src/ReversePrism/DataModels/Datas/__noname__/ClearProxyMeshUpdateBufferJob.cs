using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 processingCounter0                       NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 020 processingCounter1                       NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 030 processingCounter2                       NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 040 processingCounter3                       NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ClearProxyMeshUpdateBufferJob : DataModel
    {

        public static ClearProxyMeshUpdateBufferJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClearProxyMeshUpdateBufferJob() { Pointer= p0 };


            return value;
        }
    }
}
