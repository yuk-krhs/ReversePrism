using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Diamonds                                 ModelClassListType DiamondView[] DiamondView[] List<DiamondView> Pointer
    // 028 ImgDiamond                               ModelClassType Sprite Sprite Sprite Pointer
    // 030 ImgBlankDiamond                          ModelClassType Sprite Sprite Sprite Pointer
    // 038 EffectAnimator                           ModelClassType Animator Animator Animator Pointer
    // 040 DiamondEffectBg                          ModelClassType GameObject GameObject GameObject Pointer
    // 048 DiamondEffectFr                          ModelClassType GameObject GameObject GameObject Pointer
    public partial class DiamondDisplay : DataModel
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
            var value   = new DiamondDisplay() { Pointer= p0 };

            value.Diamonds                                  = GetObjectList<DiamondView>(new IntPtr(p + 0x020), ReversePrism.DataModels.DiamondView.FromPointer); // 0x20 Diamonds                    ( ModelClassListType DiamondView[] DiamondView[] List<DiamondView> Pointer )
            value.ImgDiamond                                = GetObject<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0x28 ImgDiamond                  ( ModelClassType Sprite Sprite Sprite Pointer )
            value.ImgBlankDiamond                           = GetObject<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 0x30 ImgBlankDiamond             ( ModelClassType Sprite Sprite Sprite Pointer )
            value.EffectAnimator                            = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0x38 EffectAnimator              ( ModelClassType Animator Animator Animator Pointer )
            value.DiamondEffectBg                           = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 DiamondEffectBg             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DiamondEffectFr                           = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 DiamondEffectFr             ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
