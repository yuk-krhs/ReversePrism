using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiCanvasGroup                            000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 ScreenTapButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 CameraSwitchingButton                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 CameraSwitchingButtonText                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CameraLiveViewLogo                       0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 048 ArchiveArea                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 SeekBarSlider                            00018651CF50 ModelClassType Slider Slider Slider Pointer
    // 060 CurrentTimeText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 LeftTimeText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 StopButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 ResumeButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 RewindButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 088 FastForwardButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 090 DisplayTime                              0001866656B0 ModelPrimitiveType float float float Single
    // 094 CloseTime                                0001866656B0 ModelPrimitiveType float float float Single
    // 098 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 0A0 IsShowing                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A1 IsMoveSlider                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class OurStreamLiveViewingScreenTapUIView
    {
        public CanvasGroup?                             UiCanvasGroup                           { get; set; }
        public UIButton?                                ScreenTapButton                         { get; set; }
        public UIButton?                                CameraSwitchingButton                   { get; set; }
        public UITextMeshProUGUI?                       CameraSwitchingButtonText               { get; set; }
        public UIImage?                                 CameraLiveViewLogo                      { get; set; }
        public GameObject?                              ArchiveArea                             { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public Slider?                                  SeekBarSlider                           { get; set; }
        public UITextMeshProUGUI?                       CurrentTimeText                         { get; set; }
        public UITextMeshProUGUI?                       LeftTimeText                            { get; set; }
        public UIButton?                                StopButton                              { get; set; }
        public UIButton?                                ResumeButton                            { get; set; }
        public UIButton?                                RewindButton                            { get; set; }
        public UIButton?                                FastForwardButton                       { get; set; }
        public float                                    DisplayTime                             { get; set; }
        public float                                    CloseTime                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public bool                                     IsShowing                               { get; set; }
        public bool                                     IsMoveSlider                            { get; set; }

        public static OurStreamLiveViewingScreenTapUIView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveViewingScreenTapUIView();

            value.UiCanvasGroup                             = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DB14E498 0x20 UiCanvasGroup               ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ScreenTapButton                           = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB14E4B8 0x28 ScreenTapButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CameraSwitchingButton                     = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB14E4D8 0x30 CameraSwitchingButton       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CameraSwitchingButtonText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB14E4F8 0x38 CameraSwitchingButtonText   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CameraLiveViewLogo                        = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB14E518 0x40 CameraLiveViewLogo          ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ArchiveArea                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB14E538 0x48 ArchiveArea                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB14E558 0x50 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SeekBarSlider                             = GetObject<Slider>(new IntPtr(p + 0x058), ReversePrism.DataModels.Slider.FromPointer); // 0270DB14E578 0x58 SeekBarSlider               ( 00018651CF50 ModelClassType Slider Slider Slider Pointer )
            value.CurrentTimeText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB14E598 0x60 CurrentTimeText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LeftTimeText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB14E5B8 0x68 LeftTimeText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StopButton                                = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB14E5D8 0x70 StopButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ResumeButton                              = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB14E5F8 0x78 ResumeButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.RewindButton                              = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB14E618 0x80 RewindButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FastForwardButton                         = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB14E638 0x88 FastForwardButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.DisplayTime                               = GetSingle(new IntPtr(p + 0x090)); // 0270DB14E658 0x90 DisplayTime                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CloseTime                                 = GetSingle(new IntPtr(p + 0x094)); // 0270DB14E678 0x94 CloseTime                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x098), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270DB14E698 0x98 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsShowing                                 = GetBool(new IntPtr(p + 0x0A0)); // 0270DB14E6B8 0xA0 IsShowing                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsMoveSlider                              = GetBool(new IntPtr(p + 0x0A1)); // 0270DB14E6D8 0xA1 IsMoveSlider                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
