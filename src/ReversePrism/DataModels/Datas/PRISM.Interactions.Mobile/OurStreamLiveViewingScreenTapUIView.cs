using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiCanvasGroup                            ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 ScreenTapButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 030 CameraSwitchingButton                    ModelClassType UIButton UIButton UIButton Pointer
    // 038 CameraSwitchingButtonText                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CameraLiveViewLogo                       ModelClassType UIImage UIImage UIImage Pointer
    // 048 ArchiveArea                              ModelClassType GameObject GameObject GameObject Pointer
    // 050 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 SeekBarSlider                            ModelClassType Slider Slider Slider Pointer
    // 060 TimeText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 StopButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 070 ResumeButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 078 RewindButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 080 FastForwardButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 088 DisplayTime                              ModelPrimitiveType float float float Single
    // 08C CloseTime                                ModelPrimitiveType float float float Single
    // 090 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 098 IsShowing                                ModelPrimitiveType bool bool bool Bool
    // 099 IsMoveSlider                             ModelPrimitiveType bool bool bool Bool
    // 0A0 onPointerUpDownSeekBarSliderSubject      Subject`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class OurStreamLiveViewingScreenTapUIView : DataModel
    {
        public CanvasGroup?                             UiCanvasGroup                           { get; set; }
        public UIButton?                                ScreenTapButton                         { get; set; }
        public UIButton?                                CameraSwitchingButton                   { get; set; }
        public UITextMeshProUGUI?                       CameraSwitchingButtonText               { get; set; }
        public UIImage?                                 CameraLiveViewLogo                      { get; set; }
        public GameObject?                              ArchiveArea                             { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public Slider?                                  SeekBarSlider                           { get; set; }
        public UITextMeshProUGUI?                       TimeText                                { get; set; }
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
            var value   = new OurStreamLiveViewingScreenTapUIView() { Pointer= p0 };

            value.UiCanvasGroup                             = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 UiCanvasGroup               ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ScreenTapButton                           = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 ScreenTapButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CameraSwitchingButton                     = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 CameraSwitchingButton       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CameraSwitchingButtonText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 CameraSwitchingButtonText   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CameraLiveViewLogo                        = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 0x40 CameraLiveViewLogo          ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ArchiveArea                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 ArchiveArea                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SeekBarSlider                             = GetObject<Slider>(new IntPtr(p + 0x058), ReversePrism.DataModels.Slider.FromPointer); // 0x58 SeekBarSlider               ( ModelClassType Slider Slider Slider Pointer )
            value.TimeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TimeText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StopButton                                = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 StopButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ResumeButton                              = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 ResumeButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RewindButton                              = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 RewindButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.FastForwardButton                         = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0x80 FastForwardButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DisplayTime                               = GetSingle(new IntPtr(p + 0x088)); // 0x88 DisplayTime                 ( ModelPrimitiveType float float float Single )
            value.CloseTime                                 = GetSingle(new IntPtr(p + 0x08C)); // 0x8C CloseTime                   ( ModelPrimitiveType float float float Single )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x090), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x90 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsShowing                                 = GetBool(new IntPtr(p + 0x098)); // 0x98 IsShowing                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsMoveSlider                              = GetBool(new IntPtr(p + 0x099)); // 0x99 IsMoveSlider                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
