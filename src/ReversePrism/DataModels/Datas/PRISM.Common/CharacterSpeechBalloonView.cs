using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtName                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtMessage                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 Cg                                       000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 FadeInDuration                           0001866656B0 ModelPrimitiveType float float float Single
    // 03C FadeOutDuration                          0001866656B0 ModelPrimitiveType float float float Single
    public partial class CharacterSpeechBalloonView : DataModel
    {
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public UITextMeshProUGUI?                       TxtMessage                              { get; set; }
        public CanvasGroup?                             Cg                                      { get; set; }
        public float                                    FadeInDuration                          { get; set; }
        public float                                    FadeOutDuration                         { get; set; }

        public static CharacterSpeechBalloonView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSpeechBalloonView() { Pointer= p0 };

            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246654C0A10 0x20 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMessage                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246654C0A30 0x28 TxtMessage                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Cg                                        = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0246654C0A50 0x30 Cg                          ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeInDuration                            = GetSingle(new IntPtr(p + 0x038)); // 0246654C0A70 0x38 FadeInDuration              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.FadeOutDuration                           = GetSingle(new IntPtr(p + 0x03C)); // 0246654C0A90 0x3C FadeOutDuration             ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
