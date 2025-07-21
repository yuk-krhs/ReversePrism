using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EffectRoot                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 030 Clip                                     ModelClassType AnimationClip AnimationClip AnimationClip Pointer
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

            value.EffectRoot                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 EffectRoot                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0x28 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.Clip                                      = GetObject<AnimationClip>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationClip.FromPointer); // 0x30 Clip                        ( ModelClassType AnimationClip AnimationClip AnimationClip Pointer )

            return value;
        }
    }
}
