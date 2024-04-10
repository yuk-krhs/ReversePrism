using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EffectRoot                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 030 Clip                                     0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    public partial class SpecialComboNumberEffect : DataModel
    {
        public GameObject?                              EffectRoot                              { get; set; }
        public Animator?                                Animator                                { get; set; }
        public AnimationClip?                           Clip                                    { get; set; }

        public static SpecialComboNumberEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialComboNumberEffect() { Pointer= p0 };

            value.EffectRoot                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466509B5A8 0x20 EffectRoot                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 02466509B5C8 0x28 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.Clip                                      = GetObject<AnimationClip>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationClip.FromPointer); // 02466509B5E8 0x30 Clip                        ( 0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer )

            return value;
        }
    }
}
