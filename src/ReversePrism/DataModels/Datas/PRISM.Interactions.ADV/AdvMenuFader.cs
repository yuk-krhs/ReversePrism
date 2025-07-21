using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DelayBeforeFadeoutSecond                 ModelPrimitiveType float float float Single
    // 024 FadeoutEndSecond                         ModelPrimitiveType float float float Single
    // 028 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 AutoCts                                  ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class AdvMenuFader : DataModel
    {
        public float                                    DelayBeforeFadeoutSecond                { get; set; }
        public float                                    FadeoutEndSecond                        { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public AutoCancellationTokenSource              AutoCts                                 { get; set; }

        public static AdvMenuFader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvMenuFader() { Pointer= p0 };

            value.DelayBeforeFadeoutSecond                  = GetSingle(new IntPtr(p + 0x020)); // 0x20 DelayBeforeFadeoutSecond    ( ModelPrimitiveType float float float Single )
            value.FadeoutEndSecond                          = GetSingle(new IntPtr(p + 0x024)); // 0x24 FadeoutEndSecond            ( ModelPrimitiveType float float float Single )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.AutoCts                                   = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x030)); // 0x30 AutoCts                     ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
