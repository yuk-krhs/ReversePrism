using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1B0 _onToggleChange                          Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 1B8 ToggleAnimator                           ModelClassType Animator Animator Animator Pointer
    // 1C0 ToggleAnimationTriggers                  ModelClassType AnimationTriggers AnimationTriggers AnimationTriggers Pointer
    // 1C8 IsSelected                               ModelPrimitiveType bool bool bool Bool
    public partial class ToggleSwitch : DataModel
    {
        public Animator?                                ToggleAnimator                          { get; set; }
        public AnimationTriggers?                       ToggleAnimationTriggers                 { get; set; }
        public bool                                     IsSelected                              { get; set; }

        public static ToggleSwitch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToggleSwitch() { Pointer= p0 };

            value.ToggleAnimator                            = GetObject<Animator>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.Animator.FromPointer); // 0x1B8 ToggleAnimator              ( ModelClassType Animator Animator Animator Pointer )
            value.ToggleAnimationTriggers                   = GetObject<AnimationTriggers>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.AnimationTriggers.FromPointer); // 0x1C0 ToggleAnimationTriggers     ( ModelClassType AnimationTriggers AnimationTriggers AnimationTriggers Pointer )
            value.IsSelected                                = GetBool(new IntPtr(p + 0x1C8)); // 0x1C8 IsSelected                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
