using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisposedCallCount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Disposable1                              0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 020 Disposable2                              0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 028 Disposable3                              0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 030 Disposable4                              0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class Quaternary
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
            var value   = new Quaternary();

            value.DisposedCallCount                         = GetInt32(new IntPtr(p + 0x010)); // 0270D953BAD8 0x10 DisposedCallCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Disposable1                               = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D953BAF8 0x18 Disposable1                 ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable2                               = GetObject<IDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D953BB18 0x20 Disposable2                 ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable3                               = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D953BB38 0x28 Disposable3                 ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable4                               = GetObject<IDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D953BB58 0x30 Disposable4                 ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
