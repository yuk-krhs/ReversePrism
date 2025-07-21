using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AsyncOp                                ModelClassType UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation Pointer
    public partial class WebRequestTaskWrapper : DataModel
    {
        public UnityWebRequestAsyncOperation?           M_AsyncOp                               { get; set; }

        public static WebRequestTaskWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebRequestTaskWrapper() { Pointer= p0 };

            value.M_AsyncOp                                 = GetObject<UnityWebRequestAsyncOperation>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnityWebRequestAsyncOperation.FromPointer); // 0x10 M_AsyncOp                   ( ModelClassType UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation UnityWebRequestAsyncOperation Pointer )

            return value;
        }
    }
}
