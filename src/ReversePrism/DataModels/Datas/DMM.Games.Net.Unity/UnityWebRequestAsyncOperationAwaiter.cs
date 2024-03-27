using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AsyncOperation                           00018672EB90 ModelClassType UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation Pointer
    public partial class UnityWebRequestAsyncOperationAwaiter
    {
        public UnityWebRequestAsyncOperation?           AsyncOperation                          { get; set; }

        public static UnityWebRequestAsyncOperationAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityWebRequestAsyncOperationAwaiter();

            value.AsyncOperation                            = GetObject<UnityWebRequestAsyncOperation>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnityWebRequestAsyncOperation.FromPointer); // 027004C1DD58 0x10 AsyncOperation              ( 00018672EB90 ModelClassType UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation Pointer )

            return value;
        }
    }
}
