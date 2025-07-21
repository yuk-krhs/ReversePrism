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
    // 020 FadeImage                                ModelClassType UIImage UIImage UIImage Pointer
    // 028 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 Canvas                                   ModelClassType Canvas Canvas Canvas Pointer
    // 038 IsFading                                 ModelPrimitiveType bool bool bool Bool
    // 03C FadeColor                                ModelEnumType Color Color Color Int32
    // 050 Tweener                                  ModelClassType Tweener Tweener Tweener Pointer
    // 058 BackKeyDisableScope                      ModelClassType IDisposable IDisposable IDisposable Pointer
    // 010 <OnBeginFadeOut>k__BackingField          Action`1<Canvas> IL2CPP_TYPE_GENERICINST
    // 018 <OnBeginFadeIn>k__BackingField           Action`1<Canvas> IL2CPP_TYPE_GENERICINST
    public partial class SceneTransitionManager : DataModel
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
            var value   = new SceneTransitionManager() { Pointer= p0 };

            value.FadeImage                                 = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 FadeImage                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x030), ReversePrism.DataModels.Canvas.FromPointer); // 0x30 Canvas                      ( ModelClassType Canvas Canvas Canvas Pointer )
            value.IsFading                                  = GetBool(new IntPtr(p + 0x038)); // 0x38 IsFading                    ( ModelPrimitiveType bool bool bool Bool )
            value.FadeColor                                 = (Color)GetInt32(new IntPtr(p + 0x03C)); // 0x3C FadeColor                   ( ModelEnumType Color Color Color Int32 )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x050), ReversePrism.DataModels.Tweener.FromPointer); // 0x50 Tweener                     ( ModelClassType Tweener Tweener Tweener Pointer )
            value.BackKeyDisableScope                       = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0x58 BackKeyDisableScope         ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
