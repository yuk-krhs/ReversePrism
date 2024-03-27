using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CancellationTokenSource                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 OnCancel                                 0001866792B0 ModelClassType Action Action Action Pointer
    public partial class DisappearCanceler
    {
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }
        public Action?                                  OnCancel                                { get; set; }

        public static DisappearCanceler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisappearCanceler();

            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5DD4FB8 0x10 CancellationTokenSource     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.OnCancel                                  = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0270D5DD4FD8 0x18 OnCancel                    ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
