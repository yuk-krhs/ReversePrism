using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 staticLock                               <object> IL2CPP_TYPE_OBJECT
    // 008 writeCallback                            GprLogDelegate IL2CPP_TYPE_CLASS
    public partial class NativeLogRedirector : DataModel
    {

        public static NativeLogRedirector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeLogRedirector() { Pointer= p0 };


            return value;
        }
    }
}
