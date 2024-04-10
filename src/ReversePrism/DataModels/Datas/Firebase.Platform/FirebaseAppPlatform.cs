using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 App                                      0001866B4810 ModelClassType WeakReference WeakReference WeakReference Pointer
    public partial class FirebaseAppPlatform : DataModel
    {
        public WeakReference?                           App                                     { get; set; }

        public static FirebaseAppPlatform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FirebaseAppPlatform() { Pointer= p0 };

            value.App                                       = GetObject<WeakReference>(new IntPtr(p + 0x010), ReversePrism.DataModels.WeakReference.FromPointer); // 02466B810888 0x10 App                         ( 0001866B4810 ModelClassType WeakReference WeakReference WeakReference Pointer )

            return value;
        }
    }
}
