using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AndroidJavaObject                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class AndroidJavaObjectWrapper : DataModel
    {
        public IDisposable?                             AndroidJavaObject                       { get; set; }

        public static AndroidJavaObjectWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AndroidJavaObjectWrapper() { Pointer= p0 };

            value.AndroidJavaObject                         = GetObject<IDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDisposable.FromPointer); // 0x10 AndroidJavaObject           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
