using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Canvas                                   00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 028 UnmaskImage                              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 UnmaskDefaultSprite                      00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 038 Unmask                                   000186735050 ModelClassType Unmask Unmask Unmask Pointer
    // 040 Arrow                                    000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 SpeechBubbleArrow                        000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 ArrowWidth                               0001866656B0 ModelPrimitiveType float float float Single
    // 058 AnnotationMessageText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 AnnotationArrowDistanceX                 0001866656B0 ModelPrimitiveType float float float Single
    // 064 AnnotationArrowDistanceY                 0001866656B0 ModelPrimitiveType float float float Single
    public partial class TutorialFocusView
    {
        public Canvas?                                  Canvas                                  { get; set; }
        public Image?                                   UnmaskImage                             { get; set; }
        public Sprite?                                  UnmaskDefaultSprite                     { get; set; }
        public Unmask?                                  Unmask                                  { get; set; }
        public RectTransform?                           Arrow                                   { get; set; }
        public RectTransform?                           SpeechBubbleArrow                       { get; set; }
        public float                                    ArrowWidth                              { get; set; }
        public UITextMeshProUGUI?                       AnnotationMessageText                   { get; set; }
        public float                                    AnnotationArrowDistanceX                { get; set; }
        public float                                    AnnotationArrowDistanceY                { get; set; }

        public static TutorialFocusView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialFocusView();

            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x020), ReversePrism.DataModels.Canvas.FromPointer); // 0270DBC12D10 0x20 Canvas                      ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.UnmaskImage                               = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270DBC12D30 0x28 UnmaskImage                 ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.UnmaskDefaultSprite                       = GetObject<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 0270DBC12D50 0x30 UnmaskDefaultSprite         ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.Unmask                                    = GetObject<Unmask>(new IntPtr(p + 0x038), ReversePrism.DataModels.Unmask.FromPointer); // 0270DBC12D70 0x38 Unmask                      ( 000186735050 ModelClassType Unmask Unmask Unmask Pointer )
            value.Arrow                                     = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DBC12D90 0x40 Arrow                       ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SpeechBubbleArrow                         = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DBC12DB0 0x48 SpeechBubbleArrow           ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ArrowWidth                                = GetSingle(new IntPtr(p + 0x050)); // 0270DBC12DD0 0x50 ArrowWidth                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AnnotationMessageText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBC12DF0 0x58 AnnotationMessageText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AnnotationArrowDistanceX                  = GetSingle(new IntPtr(p + 0x060)); // 0270DBC12E10 0x60 AnnotationArrowDistanceX    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AnnotationArrowDistanceY                  = GetSingle(new IntPtr(p + 0x064)); // 0270DBC12E30 0x64 AnnotationArrowDistanceY    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
