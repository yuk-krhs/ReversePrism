using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 028 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class AvoidEffectContent
    {
        public Animator?                                Animator                                { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }

        public static AvoidEffectContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AvoidEffectContent();

            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0270D5ACF958 0x20 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5ACF978 0x28 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
