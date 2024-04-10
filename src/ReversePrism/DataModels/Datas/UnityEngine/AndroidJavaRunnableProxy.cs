using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MRunnable                                0001866AE3F0 ModelClassType AndroidJavaRunnable AndroidJavaRunnable AndroidJavaRunnable Pointer
    public partial class AndroidJavaRunnableProxy : DataModel
    {
        public AndroidJavaRunnable?                     MRunnable                               { get; set; }

        public static AndroidJavaRunnableProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AndroidJavaRunnableProxy() { Pointer= p0 };

            value.MRunnable                                 = GetObject<AndroidJavaRunnable>(new IntPtr(p + 0x020), ReversePrism.DataModels.AndroidJavaRunnable.FromPointer); // 0245A68F7118 0x20 MRunnable                   ( 0001866AE3F0 ModelClassType AndroidJavaRunnable AndroidJavaRunnable AndroidJavaRunnable Pointer )

            return value;
        }
    }
}
