using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposable1                              000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 018 Disposable2                              000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 020 Disposable3                              000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class CombinedDisposable3 : DataModel
    {
        public IDisposable?                             Disposable1                             { get; set; }
        public IDisposable?                             Disposable2                             { get; set; }
        public IDisposable?                             Disposable3                             { get; set; }

        public static CombinedDisposable3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CombinedDisposable3() { Pointer= p0 };

            value.Disposable1                               = GetObject<IDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDisposable.FromPointer); // 02466AB0CF08 0x10 Disposable1                 ( 000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable2                               = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 02466AB0CF28 0x18 Disposable2                 ( 000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable3                               = GetObject<IDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDisposable.FromPointer); // 02466AB0CF48 0x20 Disposable3                 ( 000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
