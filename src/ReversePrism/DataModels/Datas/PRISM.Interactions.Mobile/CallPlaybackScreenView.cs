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
    // 020 BackGround                               ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer
    // 028 UserIconImage                            ModelClassType UIImage UIImage UIImage Pointer
    // 030 UserName                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TouchArea                                ModelClassType UIButton UIButton UIButton Pointer
    // 040 TextBoxBody                              ModelClassType GameObject GameObject GameObject Pointer
    // 048 TextBoxImage                             ModelClassType UIImage UIImage UIImage Pointer
    // 050 BodyText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ReplayButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 060 ReplayButtonText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 StopButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 070 StopButtonCanvasGroup                    ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 078 PageFeed                                 ModelClassType GameObject GameObject GameObject Pointer
    // 080 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 088 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 090 VoiceCueSheetName                        ModelPrimitiveType string string string String
    // 098 IsClicked                                ModelPrimitiveType bool bool bool Bool
    // 0A0 CurrentVoiceStopper                      ModelClassType Action Action Action Pointer
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
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public string                                   VoiceCueSheetName                       { get; set; }
        public bool                                     IsClicked                               { get; set; }
        public Action?                                  CurrentVoiceStopper                     { get; set; }

        public static CallPlaybackScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallPlaybackScreenView() { Pointer= p0 };

            value.BackGround                                = GetObject<MobileScreenBackground>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenBackground.FromPointer); // 0x20 BackGround                  ( ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer )
            value.UserIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 UserIconImage               ( ModelClassType UIImage UIImage UIImage Pointer )
            value.UserName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 UserName                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TouchArea                                 = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 TouchArea                   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TextBoxBody                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 TextBoxBody                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TextBoxImage                              = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0x48 TextBoxImage                ( ModelClassType UIImage UIImage UIImage Pointer )
            value.BodyText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 BodyText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ReplayButton                              = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 ReplayButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ReplayButtonText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 ReplayButtonText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StopButton                                = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 StopButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.StopButtonCanvasGroup                     = GetObject<CanvasGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x70 StopButtonCanvasGroup       ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.PageFeed                                  = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 PageFeed                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x080), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x80 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x088), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x88 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.VoiceCueSheetName                         = GetString(new IntPtr(p + 0x090)); // 0x90 VoiceCueSheetName           ( ModelPrimitiveType string string string String )
            value.IsClicked                                 = GetBool(new IntPtr(p + 0x098)); // 0x98 IsClicked                   ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentVoiceStopper                       = GetObject<Action>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Action.FromPointer); // 0xA0 CurrentVoiceStopper         ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
