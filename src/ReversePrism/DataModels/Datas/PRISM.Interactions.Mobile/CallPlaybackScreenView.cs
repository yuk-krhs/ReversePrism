using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 displayTextDurationRate                  float IL2CPP_TYPE_R4
    // 000 stopButtonFadeInSecond                   float IL2CPP_TYPE_R4
    // 000 fadedBgmVolume                           float IL2CPP_TYPE_R4
    // 000 fadeOutSecond                            float IL2CPP_TYPE_R4
    // 000 fadeInSecond                             float IL2CPP_TYPE_R4
    // 020 BackGround                               0001866331A0 ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer
    // 028 UserIconImage                            0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 UserName                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TouchArea                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 TextBoxBody                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 TextBoxImage                             0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 050 BodyText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ReplayButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 ReplayButtonText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 StopButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 StopButtonCanvasGroup                    000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 078 PageFeed                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 088 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 090 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 098 VoiceCueSheetName                        000186671910 ModelPrimitiveType string string string String
    // 0A0 IsClicked                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 CurrentVoiceStopper                      0001866792B0 ModelClassType Action Action Action Pointer
    public partial class CallPlaybackScreenView : DataModel
    {
        public MobileScreenBackground?                  BackGround                              { get; set; }
        public UIImage?                                 UserIconImage                           { get; set; }
        public UITextMeshProUGUI?                       UserName                                { get; set; }
        public UIButton?                                TouchArea                               { get; set; }
        public GameObject?                              TextBoxBody                             { get; set; }
        public UIImage?                                 TextBoxImage                            { get; set; }
        public UITextMeshProUGUI?                       BodyText                                { get; set; }
        public UIButton?                                ReplayButton                            { get; set; }
        public UITextMeshProUGUI?                       ReplayButtonText                        { get; set; }
        public UIButton?                                StopButton                              { get; set; }
        public CanvasGroup?                             StopButtonCanvasGroup                   { get; set; }
        public GameObject?                              PageFeed                                { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public string                                   VoiceCueSheetName                       { get; set; }
        public bool                                     IsClicked                               { get; set; }
        public Action?                                  CurrentVoiceStopper                     { get; set; }

        public static CallPlaybackScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallPlaybackScreenView() { Pointer= p0 };

            value.BackGround                                = GetObject<MobileScreenBackground>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenBackground.FromPointer); // 02466B14A4D8 0x20 BackGround                  ( 0001866331A0 ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer )
            value.UserIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 02466B14A4F8 0x28 UserIconImage               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.UserName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B14A518 0x30 UserName                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TouchArea                                 = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466B14A538 0x38 TouchArea                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TextBoxBody                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466B14A558 0x40 TextBoxBody                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TextBoxImage                              = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 02466B14A578 0x48 TextBoxImage                ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.BodyText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B14A598 0x50 BodyText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ReplayButton                              = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 02466B14A5B8 0x58 ReplayButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ReplayButtonText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B14A5D8 0x60 ReplayButtonText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StopButton                                = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 02466B14A5F8 0x68 StopButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.StopButtonCanvasGroup                     = GetObject<CanvasGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B14A618 0x70 StopButtonCanvasGroup       ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.PageFeed                                  = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 02466B14A638 0x78 PageFeed                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x080), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 02466B14A658 0x80 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x088), ReversePrism.DataModels.ResourceLoader.FromPointer); // 02466B14A678 0x88 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x090), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B14A698 0x90 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.VoiceCueSheetName                         = GetString(new IntPtr(p + 0x098)); // 02466B14A6B8 0x98 VoiceCueSheetName           ( 000186671910 ModelPrimitiveType string string string String )
            value.IsClicked                                 = GetBool(new IntPtr(p + 0x0A0)); // 02466B14A6D8 0xA0 IsClicked                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentVoiceStopper                       = GetObject<Action>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Action.FromPointer); // 02466B14A6F8 0xA8 CurrentVoiceStopper         ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
