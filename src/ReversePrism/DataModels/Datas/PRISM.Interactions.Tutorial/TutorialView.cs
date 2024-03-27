using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Canvas                                   00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 028 FocusView                                0001866BA050 ModelClassType TutorialFocusView TutorialFocusView TutorialFocusView Pointer
    // 030 TextWindowView                           0001866BE570 ModelClassType TutorialTextWindowView TutorialTextWindowView TutorialTextWindowView Pointer
    // 038 ScreenTapButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 TutorialEndTapButton                     0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 BeginSequences                           000185B8A160 ModelClassListType ITutorialSequence[] ITutorialSequence[] List<ITutorialSequence> Pointer
    // 050 UiCanvasManager                          0001866E1E10 ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer
    // 058 Target                                   000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class TutorialView
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
            var value   = new TutorialView();

            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x020), ReversePrism.DataModels.Canvas.FromPointer); // 0270DBC13798 0x20 Canvas                      ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.FocusView                                 = GetObject<TutorialFocusView>(new IntPtr(p + 0x028), ReversePrism.DataModels.TutorialFocusView.FromPointer); // 0270DBC137B8 0x28 FocusView                   ( 0001866BA050 ModelClassType TutorialFocusView TutorialFocusView TutorialFocusView Pointer )
            value.TextWindowView                            = GetObject<TutorialTextWindowView>(new IntPtr(p + 0x030), ReversePrism.DataModels.TutorialTextWindowView.FromPointer); // 0270DBC137D8 0x30 TextWindowView              ( 0001866BE570 ModelClassType TutorialTextWindowView TutorialTextWindowView TutorialTextWindowView Pointer )
            value.ScreenTapButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBC137F8 0x38 ScreenTapButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TutorialEndTapButton                      = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBC13818 0x40 TutorialEndTapButton        ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BeginSequences                            = GetObjectList<ITutorialSequence>(new IntPtr(p + 0x048), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0270DBC13838 0x48 BeginSequences              ( 000185B8A160 ModelClassListType ITutorialSequence[] ITutorialSequence[] List<ITutorialSequence> Pointer )
            value.UiCanvasManager                           = GetObject<UICanvasManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.UICanvasManager.FromPointer); // 0270DBC13858 0x50 UiCanvasManager             ( 0001866E1E10 ModelClassType UICanvasManager UICanvasManager UICanvasManager Pointer )
            value.Target                                    = GetObject<RectTransform>(new IntPtr(p + 0x058), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DBC13878 0x58 Target                      ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
