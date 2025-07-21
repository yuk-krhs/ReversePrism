using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisposedCallCount                        ModelPrimitiveType int int int Int32
    // 018 Disposable1                              ModelClassType IDisposable IDisposable IDisposable Pointer
    // 020 Disposable2                              ModelClassType IDisposable IDisposable IDisposable Pointer
    // 028 Disposable3                              ModelClassType IDisposable IDisposable IDisposable Pointer
    // 030 Disposable4                              ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class Quaternary : DataModel
    {
        public int                                      DisposedCallCount                       { get; set; }
        public IDisposable?                             Disposable1                             { get; set; }
        public IDisposable?                             Disposable2                             { get; set; }
        public IDisposable?                             Disposable3                             { get; set; }
        public IDisposable?                             Disposable4                             { get; set; }

        public static Quaternary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Quaternary() { Pointer= p0 };

            value.DisposedCallCount                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 DisposedCallCount           ( ModelPrimitiveType int int int Int32 )
            value.Disposable1                               = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0x18 Disposable1                 ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable2                               = GetObject<IDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDisposable.FromPointer); // 0x20 Disposable2                 ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable3                               = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0x28 Disposable3                 ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable4                               = GetObject<IDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDisposable.FromPointer); // 0x30 Disposable4                 ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
