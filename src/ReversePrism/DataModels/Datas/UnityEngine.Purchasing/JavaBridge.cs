using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ForwardTo                                00018668ABC0 ModelClassType IUnityCallback IUnityCallback IUnityCallback Pointer
    public partial class JavaBridge
    {
        public IUnityCallback?                          ForwardTo                               { get; set; }

        public static JavaBridge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JavaBridge();

            value.ForwardTo                                 = GetObject<IUnityCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.IUnityCallback.FromPointer); // 02700690E4B0 0x20 ForwardTo                   ( 00018668ABC0 ModelClassType IUnityCallback IUnityCallback IUnityCallback Pointer )

            return value;
        }
    }
}
