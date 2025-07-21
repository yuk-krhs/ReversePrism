using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDisposed                               ModelPrimitiveType bool bool bool Bool
    public partial class BooleanDisposable : DataModel
    {
        public bool                                     IsDisposed                              { get; set; }

        public static BooleanDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BooleanDisposable() { Pointer= p0 };

            value.IsDisposed                                = GetBool(new IntPtr(p + 0x010)); // 0x10 IsDisposed                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
