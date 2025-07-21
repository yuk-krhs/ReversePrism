using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposable1                              ModelClassType IDisposable IDisposable IDisposable Pointer
    // 018 Disposable2                              ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class CombinedDisposable2 : DataModel
    {
        public IDisposable?                             Disposable1                             { get; set; }
        public IDisposable?                             Disposable2                             { get; set; }

        public static CombinedDisposable2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CombinedDisposable2() { Pointer= p0 };

            value.Disposable1                               = GetObject<IDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDisposable.FromPointer); // 0x10 Disposable1                 ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable2                               = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0x18 Disposable2                 ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
