using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 028 LeftArrow                                ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 RightArrow                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 ArrowButtonScrollSensitivity             ModelPrimitiveType float float float Single
    // 040 ScrollTween                              ModelClassType Tween Tween Tween Pointer
    public partial class ScrollRectArrowButtonView : DataModel
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
            var value   = new ScrollRectArrowButtonView() { Pointer= p0 };

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x20 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.LeftArrow                                 = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x28 LeftArrow                   ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.RightArrow                                = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 RightArrow                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ArrowButtonScrollSensitivity              = GetSingle(new IntPtr(p + 0x038)); // 0x38 ArrowButtonScrollSensitivity ( ModelPrimitiveType float float float Single )
            value.ScrollTween                               = GetObject<Tween>(new IntPtr(p + 0x040), ReversePrism.DataModels.Tween.FromPointer); // 0x40 ScrollTween                 ( ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
