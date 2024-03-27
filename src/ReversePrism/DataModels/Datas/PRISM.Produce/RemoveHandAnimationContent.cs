using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CardContent                              0001866D6110 ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer
    // 028 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    public partial class RemoveHandAnimationContent
    {
        public InGamePCardContent?                      CardContent                             { get; set; }
        public Animator?                                Animator                                { get; set; }

        public static RemoveHandAnimationContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoveHandAnimationContent();

            value.CardContent                               = GetObject<InGamePCardContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGamePCardContent.FromPointer); // 0270D5B13488 0x20 CardContent                 ( 0001866D6110 ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0270D5B134A8 0x28 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
