using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ToggleButtonGroup                        ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 MainText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 WithVoiceText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NoVoiceText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 DownloadRecommendationText               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CheckToggle                              ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 050 CheckToggleText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 AnnotationText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ViewModel                                ModelClassType StoryPlayConfirmationPopupViewModel StoryPlayConfirmationPopupViewModel StoryPlayConfirmationPopupViewModel Pointer
    // 068 onCloseRequested                         Subject`1<StoryPlayConfirmationPopupResult> IL2CPP_TYPE_GENERICINST
    // 070 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class StoryPlayConfirmationPopupView : DataModel
    {
        public ToggleButtonGroup?                       ToggleButtonGroup                       { get; set; }
        public UITextMeshProUGUI?                       MainText                                { get; set; }
        public UITextMeshProUGUI?                       WithVoiceText                           { get; set; }
        public UITextMeshProUGUI?                       NoVoiceText                             { get; set; }
        public UITextMeshProUGUI?                       DownloadRecommendationText              { get; set; }
        public ToggleButton?                            CheckToggle                             { get; set; }
        public UITextMeshProUGUI?                       CheckToggleText                         { get; set; }
        public UITextMeshProUGUI?                       AnnotationText                          { get; set; }
        public StoryPlayConfirmationPopupViewModel?     ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static StoryPlayConfirmationPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryPlayConfirmationPopupView() { Pointer= p0 };

            value.ToggleButtonGroup                         = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x20 ToggleButtonGroup           ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.MainText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 MainText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.WithVoiceText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 WithVoiceText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoVoiceText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 NoVoiceText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DownloadRecommendationText                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 DownloadRecommendationText  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CheckToggle                               = GetObject<ToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x48 CheckToggle                 ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.CheckToggleText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 CheckToggleText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AnnotationText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 AnnotationText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<StoryPlayConfirmationPopupViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.StoryPlayConfirmationPopupViewModel.FromPointer); // 0x60 ViewModel                   ( ModelClassType StoryPlayConfirmationPopupViewModel StoryPlayConfirmationPopupViewModel StoryPlayConfirmationPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x70 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
