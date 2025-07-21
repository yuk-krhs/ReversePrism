using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ForwardTo                                ModelClassType IUnityCallback IUnityCallback IUnityCallback Pointer
    // 018 Util                                     ModelClassType IUtil IUtil IUtil Pointer
    public partial class ScriptingUnityCallback : DataModel
    {
        public IUnityCallback?                          ForwardTo                               { get; set; }
        public IUtil?                                   Util                                    { get; set; }

        public static ScriptingUnityCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScriptingUnityCallback() { Pointer= p0 };

            value.ForwardTo                                 = GetObject<IUnityCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.IUnityCallback.FromPointer); // 0x10 ForwardTo                   ( ModelClassType IUnityCallback IUnityCallback IUnityCallback Pointer )
            value.Util                                      = GetObject<IUtil>(new IntPtr(p + 0x018), ReversePrism.DataModels.IUtil.FromPointer); // 0x18 Util                        ( ModelClassType IUtil IUtil IUtil Pointer )

            return value;
        }
    }
}
