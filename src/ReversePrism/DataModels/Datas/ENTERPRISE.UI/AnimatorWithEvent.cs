using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 runEventSubject                          Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 028 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    public partial class AnimatorWithEvent
    {
        public Animator?                                Animator                                { get; set; }

        public static AnimatorWithEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimatorWithEvent();

            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0270D530AD40 0x28 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
