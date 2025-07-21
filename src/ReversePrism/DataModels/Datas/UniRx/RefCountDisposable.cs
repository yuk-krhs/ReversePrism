using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _gate                                    <object> IL2CPP_TYPE_OBJECT
    // 018 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 020 IsPrimaryDisposed                        ModelPrimitiveType bool bool bool Bool
    // 024 Count                                    ModelPrimitiveType int int int Int32
    public partial class RefCountDisposable : DataModel
    {
        public IDisposable?                             Disposable                              { get; set; }
        public bool                                     IsPrimaryDisposed                       { get; set; }
        public int                                      Count                                   { get; set; }

        public static RefCountDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RefCountDisposable() { Pointer= p0 };

            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0x18 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.IsPrimaryDisposed                         = GetBool(new IntPtr(p + 0x020)); // 0x20 IsPrimaryDisposed           ( ModelPrimitiveType bool bool bool Bool )
            value.Count                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
