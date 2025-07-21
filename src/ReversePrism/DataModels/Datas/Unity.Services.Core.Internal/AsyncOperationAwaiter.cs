using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Operation                              ModelClassType IAsyncOperation IAsyncOperation IAsyncOperation Pointer
    public partial class AsyncOperationAwaiter : DataModel
    {
        public IAsyncOperation?                         M_Operation                             { get; set; }

        public static AsyncOperationAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncOperationAwaiter() { Pointer= p0 };

            value.M_Operation                               = GetObject<IAsyncOperation>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAsyncOperation.FromPointer); // 0x10 M_Operation                 ( ModelClassType IAsyncOperation IAsyncOperation IAsyncOperation Pointer )

            return value;
        }
    }
}
