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
    public partial class SuspendPauseView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public float                                    FadeTime                                { get; set; }
        public Tween?                                   Tween                                   { get; set; }

        public static SuspendPauseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SuspendPauseView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0246650C13C0 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeTime                                  = GetSingle(new IntPtr(p + 0x028)); // 0246650C13E0 0x28 FadeTime                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Tween                                     = GetObject<Tween>(new IntPtr(p + 0x030), ReversePrism.DataModels.Tween.FromPointer); // 0246650C1400 0x30 Tween                       ( 0001866BEFF0 ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
