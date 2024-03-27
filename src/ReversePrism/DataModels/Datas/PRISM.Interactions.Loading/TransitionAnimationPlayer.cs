using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 028 animatorHashDic                          Dictionary`2<int, ValueTuple`3<int, int, int>> IL2CPP_TYPE_GENERICINST
    // 030 CurrentTransitionAnimationType           0001866ACD70 ModelEnumType TransitionAnimationType TransitionAnimationType TransitionAnimationType Int32
    public partial class TransitionAnimationPlayer
    {
        public Animator?                                Animator                                { get; set; }
        public TransitionAnimationType                  CurrentTransitionAnimationType          { get; set; }

        public static TransitionAnimationPlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransitionAnimationPlayer();

            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0270DBE15890 0x20 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.CurrentTransitionAnimationType            = (TransitionAnimationType)GetInt32(new IntPtr(p + 0x030)); // 0270DBE158D0 0x30 CurrentTransitionAnimationType ( 0001866ACD70 ModelEnumType TransitionAnimationType TransitionAnimationType TransitionAnimationType Int32 )

            return value;
        }
    }
}
