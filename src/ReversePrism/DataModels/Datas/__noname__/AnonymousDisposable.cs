using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDisposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Dispose                                  00018667A3C0 ModelClassType Action Action Action Pointer
    public partial class AnonymousDisposable
    {
        public bool                                     IsDisposed                              { get; set; }
        public Action?                                  Dispose                                 { get; set; }

        public static AnonymousDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnonymousDisposable();

            value.IsDisposed                                = GetBool(new IntPtr(p + 0x010)); // 0270D0E234A0 0x10 IsDisposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Dispose                                   = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0270D0E234C0 0x18 Dispose                     ( 00018667A3C0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
