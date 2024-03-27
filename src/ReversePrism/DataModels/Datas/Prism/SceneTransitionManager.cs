using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ResourceTag                              string IL2CPP_TYPE_STRING
    // 000 instance                                 SceneTransitionManager IL2CPP_TYPE_CLASS
    // 008 isInitialized                            bool IL2CPP_TYPE_BOOLEAN
    // 020 FadeImage                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 Canvas                                   00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 038 IsFading                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C FadeColor                                0001865AA8E0 ModelEnumType Color Color Color Int32
    // 050 Tweener                                  0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer
    // 058 BackKeyDisableScope                      0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 010 <OnBeginFadeOut>k__BackingField          Action`1<Canvas> IL2CPP_TYPE_GENERICINST
    // 018 <OnBeginFadeIn>k__BackingField           Action`1<Canvas> IL2CPP_TYPE_GENERICINST
    public partial class SceneTransitionManager
    {
        public UIImage?                                 FadeImage                               { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public Canvas?                                  Canvas                                  { get; set; }
        public bool                                     IsFading                                { get; set; }
        public Color                                    FadeColor                               { get; set; }
        public Tweener?                                 Tweener                                 { get; set; }
        public IDisposable?                             BackKeyDisableScope                     { get; set; }

        public static SceneTransitionManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneTransitionManager();

            value.FadeImage                                 = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 027003AFA240 0x20 FadeImage                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027003AFA260 0x28 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x030), ReversePrism.DataModels.Canvas.FromPointer); // 027003AFA280 0x30 Canvas                      ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.IsFading                                  = GetBool(new IntPtr(p + 0x038)); // 027003AFA2A0 0x38 IsFading                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FadeColor                                 = (Color)GetInt32(new IntPtr(p + 0x03C)); // 027003AFA2C0 0x3C FadeColor                   ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x050), ReversePrism.DataModels.Tweener.FromPointer); // 027003AFA2E0 0x50 Tweener                     ( 0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer )
            value.BackKeyDisableScope                       = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 027003AFA300 0x58 BackKeyDisableScope         ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
