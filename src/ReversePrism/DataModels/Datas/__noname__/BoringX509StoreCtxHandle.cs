using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DontFree                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BoringX509StoreCtxHandle
    {
        public bool                                     DontFree                                { get; set; }

        public static BoringX509StoreCtxHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoringX509StoreCtxHandle();

            value.DontFree                                  = GetBool(new IntPtr(p + 0x020)); // 0270D7963D30 0x20 DontFree                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
