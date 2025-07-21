using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 App                                      ModelClassType WeakReference WeakReference WeakReference Pointer
    public partial class FirebaseAppPlatform : DataModel
    {
        public WeakReference?                           App                                     { get; set; }

        public static FirebaseAppPlatform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FirebaseAppPlatform() { Pointer= p0 };

            value.App                                       = GetObject<WeakReference>(new IntPtr(p + 0x010), ReversePrism.DataModels.WeakReference.FromPointer); // 0x10 App                         ( ModelClassType WeakReference WeakReference WeakReference Pointer )

            return value;
        }
    }
}
