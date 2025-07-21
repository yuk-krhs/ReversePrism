using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CloseAnimationName                       ModelPrimitiveType int int int Int32
    // 024 CloseIdleAnimationName                   ModelPrimitiveType int int int Int32
    // 028 OpenAnimationName                        ModelPrimitiveType int int int Int32
    // 02C OpenIdleAnimationName                    ModelPrimitiveType int int int Int32
    // 030 DelayBeforeFadeoutSecond                 ModelPrimitiveType float float float Single
    // 034 FadeoutEndSecond                         ModelPrimitiveType float float float Single
    // 038 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 040 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 OpenMenuAnimator                         ModelClassType Animator Animator Animator Pointer
    // 050 AutoCts                                  ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 058 IsOpen                                   ModelPrimitiveType bool bool bool Bool
    public partial class AdvMenuButton : DataModel
    {
        public int                                      CloseAnimationName                      { get; set; }
        public int                                      CloseIdleAnimationName                  { get; set; }
        public int                                      OpenAnimationName                       { get; set; }
        public int                                      OpenIdleAnimationName                   { get; set; }
        public float                                    DelayBeforeFadeoutSecond                { get; set; }
        public float                                    FadeoutEndSecond                        { get; set; }
        public UIButton?                                Button                                  { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public Animator?                                OpenMenuAnimator                        { get; set; }
        public AutoCancellationTokenSource              AutoCts                                 { get; set; }
        public bool                                     IsOpen                                  { get; set; }

        public static AdvMenuButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvMenuButton() { Pointer= p0 };

            value.CloseAnimationName                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 CloseAnimationName          ( ModelPrimitiveType int int int Int32 )
            value.CloseIdleAnimationName                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 CloseIdleAnimationName      ( ModelPrimitiveType int int int Int32 )
            value.OpenAnimationName                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 OpenAnimationName           ( ModelPrimitiveType int int int Int32 )
            value.OpenIdleAnimationName                     = GetInt32(new IntPtr(p + 0x02C)); // 0x2C OpenIdleAnimationName       ( ModelPrimitiveType int int int Int32 )
            value.DelayBeforeFadeoutSecond                  = GetSingle(new IntPtr(p + 0x030)); // 0x30 DelayBeforeFadeoutSecond    ( ModelPrimitiveType float float float Single )
            value.FadeoutEndSecond                          = GetSingle(new IntPtr(p + 0x034)); // 0x34 FadeoutEndSecond            ( ModelPrimitiveType float float float Single )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x40 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.OpenMenuAnimator                          = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0x48 OpenMenuAnimator            ( ModelClassType Animator Animator Animator Pointer )
            value.AutoCts                                   = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x050)); // 0x50 AutoCts                     ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x058)); // 0x58 IsOpen                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
