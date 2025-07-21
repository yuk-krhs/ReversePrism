using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 WebRequest                               ModelClassType UnityWebRequest UnityWebRequest UnityWebRequest Pointer
    public partial class UnityWebRequestAsyncOperation : DataModel
    {
        public UnityWebRequest?                         WebRequest                              { get; set; }

        public static UnityWebRequestAsyncOperation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityWebRequestAsyncOperation() { Pointer= p0 };

            value.WebRequest                                = GetObject<UnityWebRequest>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnityWebRequest.FromPointer); // 0x20 WebRequest                  ( ModelClassType UnityWebRequest UnityWebRequest UnityWebRequest Pointer )

            return value;
        }
    }
}
