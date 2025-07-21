using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDisposed                               ModelPrimitiveType bool bool bool Bool
    // 018 Dispose                                  ModelClassType Action Action Action Pointer
    public partial class AnonymousDisposable : DataModel
    {
        public bool                                     IsDisposed                              { get; set; }
        public Action?                                  Dispose                                 { get; set; }

        public static AnonymousDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnonymousDisposable() { Pointer= p0 };

            value.IsDisposed                                = GetBool(new IntPtr(p + 0x010)); // 0x10 IsDisposed                  ( ModelPrimitiveType bool bool bool Bool )
            value.Dispose                                   = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0x18 Dispose                     ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
