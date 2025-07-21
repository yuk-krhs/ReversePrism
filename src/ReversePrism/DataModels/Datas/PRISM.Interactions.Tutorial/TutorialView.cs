using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Canvas                                   ModelClassType Canvas Canvas Canvas Pointer
    // 028 FocusView                                ModelClassType TutorialFocusView TutorialFocusView TutorialFocusView Pointer
    // 030 TextWindowView                           ModelClassType TutorialTextWindowView TutorialTextWindowView TutorialTextWindowView Pointer
    // 038 ScreenTapButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 040 TutorialEndTapButton                     ModelClassType UIButton UIButton UIButton Pointer
    // 048 BeginSequences                           ModelClassListType ITutorialSequence[] ITutorialSequence[] List<ITutorialSequence> Pointer
    // 050 UiCanvasManager                          ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer
    // 058 Target                                   ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class TutorialView : DataModel
    {
        public Canvas?                                  Canvas                                  { get; set; }
        public TutorialFocusView?                       FocusView                               { get; set; }
        public TutorialTextWindowView?                  TextWindowView                          { get; set; }
        public UIButton?                                ScreenTapButton                         { get; set; }
        public UIButton?                                TutorialEndTapButton                    { get; set; }
        public List<ITutorialSequence>?                 BeginSequences                          { get; set; }
        public UICanvasManager?                         UiCanvasManager                         { get; set; }
        public RectTransform?                           Target                                  { get; set; }

        public static TutorialView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialView() { Pointer= p0 };

            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x020), ReversePrism.DataModels.Canvas.FromPointer); // 0x20 Canvas                      ( ModelClassType Canvas Canvas Canvas Pointer )
            value.FocusView                                 = GetObject<TutorialFocusView>(new IntPtr(p + 0x028), ReversePrism.DataModels.TutorialFocusView.FromPointer); // 0x28 FocusView                   ( ModelClassType TutorialFocusView TutorialFocusView TutorialFocusView Pointer )
            value.TextWindowView                            = GetObject<TutorialTextWindowView>(new IntPtr(p + 0x030), ReversePrism.DataModels.TutorialTextWindowView.FromPointer); // 0x30 TextWindowView              ( ModelClassType TutorialTextWindowView TutorialTextWindowView TutorialTextWindowView Pointer )
            value.ScreenTapButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 ScreenTapButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TutorialEndTapButton                      = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 TutorialEndTapButton        ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BeginSequences                            = GetObjectList<ITutorialSequence>(new IntPtr(p + 0x048), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0x48 BeginSequences              ( ModelClassListType ITutorialSequence[] ITutorialSequence[] List<ITutorialSequence> Pointer )
            value.UiCanvasManager                           = GetObject<UICanvasManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.UICanvasManager.FromPointer); // 0x50 UiCanvasManager             ( ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer )
            value.Target                                    = GetObject<RectTransform>(new IntPtr(p + 0x058), ReversePrism.DataModels.RectTransform.FromPointer); // 0x58 Target                      ( ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
