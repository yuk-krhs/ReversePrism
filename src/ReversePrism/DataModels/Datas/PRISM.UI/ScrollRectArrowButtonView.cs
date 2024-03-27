using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 028 LeftArrow                                000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 RightArrow                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 ArrowButtonScrollSensitivity             0001866656B0 ModelPrimitiveType float float float Single
    // 040 ScrollTween                              0001866BEFF0 ModelClassType Tween Tween Tween Pointer
    public partial class ScrollRectArrowButtonView
    {
        public ScrollRect?                              ScrollRect                              { get; set; }
        public ButtonBase?                              LeftArrow                               { get; set; }
        public ButtonBase?                              RightArrow                              { get; set; }
        public float                                    ArrowButtonScrollSensitivity            { get; set; }
        public Tween?                                   ScrollTween                             { get; set; }

        public static ScrollRectArrowButtonView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScrollRectArrowButtonView();

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270D5484C48 0x20 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.LeftArrow                                 = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5484C68 0x28 LeftArrow                   ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.RightArrow                                = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5484C88 0x30 RightArrow                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ArrowButtonScrollSensitivity              = GetSingle(new IntPtr(p + 0x038)); // 0270D5484CA8 0x38 ArrowButtonScrollSensitivity ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScrollTween                               = GetObject<Tween>(new IntPtr(p + 0x040), ReversePrism.DataModels.Tween.FromPointer); // 0270D5484CC8 0x40 ScrollTween                 ( 0001866BEFF0 ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
