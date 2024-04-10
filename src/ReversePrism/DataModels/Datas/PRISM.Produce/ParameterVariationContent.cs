using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _assetPath                               string IL2CPP_TYPE_STRING
    // 020 ParameterDisplayAnimator                 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 028 ParameterContent                         00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer
    // 030 FanCountTextMeshPro                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 StatusSlideAnimator                      0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 048 UnitIcon                                 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 050 IdolIcon                                 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    public partial class ParameterVariationContent : DataModel
    {
        public AnimatorWithEvent?                       ParameterDisplayAnimator                { get; set; }
        public ParameterContent?                        ParameterContent                        { get; set; }
        public UITextMeshProUGUI?                       FanCountTextMeshPro                     { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public Animator?                                StatusSlideAnimator                     { get; set; }
        public UIImage?                                 UnitIcon                                { get; set; }
        public PFIdolIconRectView?                      IdolIcon                                { get; set; }

        public static ParameterVariationContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterVariationContent() { Pointer= p0 };

            value.ParameterDisplayAnimator                  = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 024665C3ECD0 0x20 ParameterDisplayAnimator    ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.ParameterContent                          = GetObject<ParameterContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParameterContent.FromPointer); // 024665C3ECF0 0x28 ParameterContent            ( 00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer )
            value.FanCountTextMeshPro                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C3ED10 0x30 FanCountTextMeshPro         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665C3ED30 0x38 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.StatusSlideAnimator                       = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 024665C3ED50 0x40 StatusSlideAnimator         ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.UnitIcon                                  = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 024665C3ED70 0x48 UnitIcon                    ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.IdolIcon                                  = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x050), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 024665C3ED90 0x50 IdolIcon                    ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )

            return value;
        }
    }
}
