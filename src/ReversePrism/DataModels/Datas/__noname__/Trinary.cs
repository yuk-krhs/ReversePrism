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
    public partial class Trinary : DataModel
    {
        public int                                      DisposedCallCount                       { get; set; }
        public IDisposable?                             Disposable1                             { get; set; }
        public IDisposable?                             Disposable2                             { get; set; }
        public IDisposable?                             Disposable3                             { get; set; }

        public static Trinary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Trinary() { Pointer= p0 };

            value.DisposedCallCount                         = GetInt32(new IntPtr(p + 0x010)); // 0246695A9880 0x10 DisposedCallCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Disposable1                               = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0246695A98A0 0x18 Disposable1                 ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable2                               = GetObject<IDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDisposable.FromPointer); // 0246695A98C0 0x20 Disposable2                 ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable3                               = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0246695A98E0 0x28 Disposable3                 ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
