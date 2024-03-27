using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 FadeTime                                 0001866656B0 ModelPrimitiveType float float float Single
    // 030 Tween                                    0001866BEFF0 ModelClassType Tween Tween Tween Pointer
    public partial class SuspendPauseView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public float                                    FadeTime                                { get; set; }
        public Tween?                                   Tween                                   { get; set; }

        public static SuspendPauseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SuspendPauseView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D5056488 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeTime                                  = GetSingle(new IntPtr(p + 0x028)); // 0270D50564A8 0x28 FadeTime                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Tween                                     = GetObject<Tween>(new IntPtr(p + 0x030), ReversePrism.DataModels.Tween.FromPointer); // 0270D50564C8 0x30 Tween                       ( 0001866BEFF0 ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
