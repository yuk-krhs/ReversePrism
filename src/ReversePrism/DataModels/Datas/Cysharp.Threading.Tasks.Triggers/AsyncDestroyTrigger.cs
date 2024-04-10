using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AwakeCalled                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 Called                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 CancellationTokenSource                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class AsyncDestroyTrigger : DataModel
    {
        public bool                                     AwakeCalled                             { get; set; }
        public bool                                     Called                                  { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }

        public static AsyncDestroyTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncDestroyTrigger() { Pointer= p0 };

            value.AwakeCalled                               = GetBool(new IntPtr(p + 0x020)); // 02466902A358 0x20 AwakeCalled                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Called                                    = GetBool(new IntPtr(p + 0x021)); // 02466902A378 0x21 Called                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466902A398 0x28 CancellationTokenSource     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
