using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ForwardTo                                00018668ABC0 ModelClassType IUnityCallback IUnityCallback IUnityCallback Pointer
    // 018 Util                                     0001866905E0 ModelClassType IUtil IUtil IUtil Pointer
    public partial class ScriptingUnityCallback
    {
        public IUnityCallback?                          ForwardTo                               { get; set; }
        public IUtil?                                   Util                                    { get; set; }

        public static ScriptingUnityCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScriptingUnityCallback();

            value.ForwardTo                                 = GetObject<IUnityCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.IUnityCallback.FromPointer); // 02700690F8B8 0x10 ForwardTo                   ( 00018668ABC0 ModelClassType IUnityCallback IUnityCallback IUnityCallback Pointer )
            value.Util                                      = GetObject<IUtil>(new IntPtr(p + 0x018), ReversePrism.DataModels.IUtil.FromPointer); // 02700690F8D8 0x18 Util                        ( 0001866905E0 ModelClassType IUtil IUtil IUtil Pointer )

            return value;
        }
    }
}
