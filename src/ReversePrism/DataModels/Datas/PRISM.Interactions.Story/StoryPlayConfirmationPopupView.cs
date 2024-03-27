using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ToggleButtonGroup                        000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 MainText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 WithVoiceText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NoVoiceText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 DownloadRecommendationText               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CheckToggle                              000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 050 CheckToggleText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 AnnotationText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ViewModel                                00018659A380 ModelClassType StoryPlayConfirmationPopupViewModel StoryPlayConfirmationPopupViewModel StoryPlayConfirmationPopupViewModel Pointer
    // 068 onCloseRequested                         Subject`1<StoryPlayConfirmationPopupResult> IL2CPP_TYPE_GENERICINST
    // 070 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class StoryPlayConfirmationPopupView
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
            var value   = new StoryPlayConfirmationPopupView();

            value.ToggleButtonGroup                         = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270DB954A60 0x20 ToggleButtonGroup           ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.MainText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB954A80 0x28 MainText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.WithVoiceText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB954AA0 0x30 WithVoiceText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoVoiceText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB954AC0 0x38 NoVoiceText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DownloadRecommendationText                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB954AE0 0x40 DownloadRecommendationText  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CheckToggle                               = GetObject<ToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DB954B00 0x48 CheckToggle                 ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.CheckToggleText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB954B20 0x50 CheckToggleText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AnnotationText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB954B40 0x58 AnnotationText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<StoryPlayConfirmationPopupViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.StoryPlayConfirmationPopupViewModel.FromPointer); // 0270DB954B60 0x60 ViewModel                   ( 00018659A380 ModelClassType StoryPlayConfirmationPopupViewModel StoryPlayConfirmationPopupViewModel StoryPlayConfirmationPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB954BA0 0x70 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
