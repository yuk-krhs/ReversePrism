using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 FadeTime                                 ModelPrimitiveType float float float Single
    // 030 Tween                                    ModelClassType Tween Tween Tween Pointer
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

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeTime                                  = GetSingle(new IntPtr(p + 0x028)); // 0x28 FadeTime                    ( ModelPrimitiveType float float float Single )
            value.Tween                                     = GetObject<Tween>(new IntPtr(p + 0x030), ReversePrism.DataModels.Tween.FromPointer); // 0x30 Tween                       ( ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
