using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Diamonds                                 000185B7A2A0 ModelClassListType DiamondView[] DiamondView[] List<DiamondView> Pointer
    // 028 ImgDiamond                               00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 030 ImgBlankDiamond                          00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 038 EffectAnimator                           0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 040 DiamondEffectBg                          0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 048 DiamondEffectFr                          0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    public partial class DiamondDisplay
    {
        public List<DiamondView>?                       Diamonds                                { get; set; }
        public Sprite?                                  ImgDiamond                              { get; set; }
        public Sprite?                                  ImgBlankDiamond                         { get; set; }
        public Animator?                                EffectAnimator                          { get; set; }
        public GameObject?                              DiamondEffectBg                         { get; set; }
        public GameObject?                              DiamondEffectFr                         { get; set; }

        public static DiamondDisplay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiamondDisplay();

            value.Diamonds                                  = GetObjectList<DiamondView>(new IntPtr(p + 0x020), ReversePrism.DataModels.DiamondView.FromPointer); // 027005B21D70 0x20 Diamonds                    ( 000185B7A2A0 ModelClassListType DiamondView[] DiamondView[] List<DiamondView> Pointer )
            value.ImgDiamond                                = GetObject<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 027005B21D90 0x28 ImgDiamond                  ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.ImgBlankDiamond                           = GetObject<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 027005B21DB0 0x30 ImgBlankDiamond             ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.EffectAnimator                            = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 027005B21DD0 0x38 EffectAnimator              ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.DiamondEffectBg                           = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 027005B21DF0 0x40 DiamondEffectBg             ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.DiamondEffectFr                           = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 027005B21E10 0x48 DiamondEffectFr             ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
