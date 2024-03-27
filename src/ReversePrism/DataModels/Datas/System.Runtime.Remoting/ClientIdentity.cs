using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 ProxyReference                           0001866B4810 ModelClassType WeakReference WeakReference WeakReference Pointer
    public partial class ClientIdentity
    {
        public WeakReference?                           ProxyReference                          { get; set; }

        public static ClientIdentity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientIdentity();

            value.ProxyReference                            = GetObject<WeakReference>(new IntPtr(p + 0x048), ReversePrism.DataModels.WeakReference.FromPointer); // 0270D6BB32D8 0x48 ProxyReference              ( 0001866B4810 ModelClassType WeakReference WeakReference WeakReference Pointer )

            return value;
        }
    }
}
