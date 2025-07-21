using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AwakeCalled                              ModelPrimitiveType bool bool bool Bool
    // 021 Called                                   ModelPrimitiveType bool bool bool Bool
    // 028 CancellationTokenSource                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
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

            value.AwakeCalled                               = GetBool(new IntPtr(p + 0x020)); // 0x20 AwakeCalled                 ( ModelPrimitiveType bool bool bool Bool )
            value.Called                                    = GetBool(new IntPtr(p + 0x021)); // 0x21 Called                      ( ModelPrimitiveType bool bool bool Bool )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 CancellationTokenSource     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
