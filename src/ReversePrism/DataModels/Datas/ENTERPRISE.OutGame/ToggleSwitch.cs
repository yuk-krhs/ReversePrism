using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1B0 _onToggleChange                          Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 1B8 ToggleAnimator                           0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 1C0 ToggleAnimationTriggers                  0001866B89A0 ModelClassType AnimationTriggers AnimationTriggers AnimationTriggers Pointer
    // 1C8 IsSelected                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ToggleSwitch
    {
        public Animator?                                ToggleAnimator                          { get; set; }
        public AnimationTriggers?                       ToggleAnimationTriggers                 { get; set; }
        public bool                                     IsSelected                              { get; set; }

        public static ToggleSwitch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToggleSwitch();

            value.ToggleAnimator                            = GetObject<Animator>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.Animator.FromPointer); // 0270D4C082E8 0x1B8 ToggleAnimator              ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ToggleAnimationTriggers                   = GetObject<AnimationTriggers>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.AnimationTriggers.FromPointer); // 0270D4C08308 0x1C0 ToggleAnimationTriggers     ( 0001866B89A0 ModelClassType AnimationTriggers AnimationTriggers AnimationTriggers Pointer )
            value.IsSelected                                = GetBool(new IntPtr(p + 0x1C8)); // 0270D4C08328 0x1C8 IsSelected                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
