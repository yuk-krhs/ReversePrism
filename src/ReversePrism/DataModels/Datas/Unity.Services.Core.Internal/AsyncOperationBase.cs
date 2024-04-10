using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_CompletedCallback                      Action`1<IAsyncOperation> IL2CPP_TYPE_GENERICINST
    public partial class AsyncOperationBase : DataModel
    {

        public static AsyncOperationBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncOperationBase() { Pointer= p0 };


            return value;
        }
    }
}
