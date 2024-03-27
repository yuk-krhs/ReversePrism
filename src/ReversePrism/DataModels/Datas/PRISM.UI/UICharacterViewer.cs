using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgTouchDetector                         0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 CharaView                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 SpeechBalloonView                        0001865A3FE0 ModelClassType CharacterSpeechBalloonView CharacterSpeechBalloonView CharacterSpeechBalloonView Pointer
    // 038 IsEnableManualCamera                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C CameraRotateSensitivity                  0001866656B0 ModelPrimitiveType float float float Single
    // 040 CameraMoveSensitivity                    0001866656B0 ModelPrimitiveType float float float Single
    // 044 CameraPinchZoomSensitivity               0001866656B0 ModelPrimitiveType float float float Single
    // 048 CameraMouseZoomSensitivity               0001866656B0 ModelPrimitiveType float float float Single
    // 04C CameraMaxFov                             0001866656B0 ModelPrimitiveType float float float Single
    // 050 CameraMinFov                             0001866656B0 ModelPrimitiveType float float float Single
    // 058 OnStopVoiceDisposable                    0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 060 AutoActionCts                            0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 068 isOverlayShowFunc                        Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 070 Viewer                                   0001866E0670 ModelClassType UI3DModelViewer UI3DModelViewer UI3DModelViewer Pointer
    // 078 loadedOther3DScene                       IEnumerable`1<SceneLoaderAddressable> IL2CPP_TYPE_GENERICINST
    // 080 LastPlayTime                             0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 088 DefaultRenderTexture                     00018664CFB0 ModelClassType Texture Texture Texture Pointer
    // 090 Info                                     0001866E3400 ModelClassType UICharacterVoiceInfo UICharacterVoiceInfo UICharacterVoiceInfo Pointer
    // 098 onSwipe                                  Subject`1<Vector2> IL2CPP_TYPE_GENERICINST
    // 0A0 onPinch                                  Subject`1<float> IL2CPP_TYPE_GENERICINST
    // 0A8 CurrentFov                               0001866656B0 ModelPrimitiveType float float float Single
    public partial class UICharacterViewer
    {
        public Image?                                   ImgTouchDetector                        { get; set; }
        public RawImage?                                CharaView                               { get; set; }
        public CharacterSpeechBalloonView?              SpeechBalloonView                       { get; set; }
        public bool                                     IsEnableManualCamera                    { get; set; }
        public float                                    CameraRotateSensitivity                 { get; set; }
        public float                                    CameraMoveSensitivity                   { get; set; }
        public float                                    CameraPinchZoomSensitivity              { get; set; }
        public float                                    CameraMouseZoomSensitivity              { get; set; }
        public float                                    CameraMaxFov                            { get; set; }
        public float                                    CameraMinFov                            { get; set; }
        public IDisposable?                             OnStopVoiceDisposable                   { get; set; }
        public CancellationTokenSource?                 AutoActionCts                           { get; set; }
        public UI3DModelViewer?                         Viewer                                  { get; set; }
        public DateTime                                 LastPlayTime                            { get; set; }
        public Texture?                                 DefaultRenderTexture                    { get; set; }
        public UICharacterVoiceInfo?                    Info                                    { get; set; }
        public float                                    CurrentFov                              { get; set; }

        public static UICharacterViewer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UICharacterViewer();

            value.ImgTouchDetector                          = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270D543B2D8 0x20 ImgTouchDetector            ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.CharaView                                 = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0270D543B2F8 0x28 CharaView                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.SpeechBalloonView                         = GetObject<CharacterSpeechBalloonView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CharacterSpeechBalloonView.FromPointer); // 0270D543B318 0x30 SpeechBalloonView           ( 0001865A3FE0 ModelClassType CharacterSpeechBalloonView CharacterSpeechBalloonView CharacterSpeechBalloonView Pointer )
            value.IsEnableManualCamera                      = GetBool(new IntPtr(p + 0x038)); // 0270D543B338 0x38 IsEnableManualCamera        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CameraRotateSensitivity                   = GetSingle(new IntPtr(p + 0x03C)); // 0270D543B358 0x3C CameraRotateSensitivity     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraMoveSensitivity                     = GetSingle(new IntPtr(p + 0x040)); // 0270D543B378 0x40 CameraMoveSensitivity       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraPinchZoomSensitivity                = GetSingle(new IntPtr(p + 0x044)); // 0270D543B398 0x44 CameraPinchZoomSensitivity  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraMouseZoomSensitivity                = GetSingle(new IntPtr(p + 0x048)); // 0270D543B3B8 0x48 CameraMouseZoomSensitivity  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraMaxFov                              = GetSingle(new IntPtr(p + 0x04C)); // 0270D543B3D8 0x4C CameraMaxFov                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraMinFov                              = GetSingle(new IntPtr(p + 0x050)); // 0270D543B3F8 0x50 CameraMinFov                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.OnStopVoiceDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D543B418 0x58 OnStopVoiceDisposable       ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.AutoActionCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x060), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D543B438 0x60 AutoActionCts               ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Viewer                                    = GetObject<UI3DModelViewer>(new IntPtr(p + 0x070), ReversePrism.DataModels.UI3DModelViewer.FromPointer); // 0270D543B478 0x70 Viewer                      ( 0001866E0670 ModelClassType UI3DModelViewer UI3DModelViewer UI3DModelViewer Pointer )
            value.LastPlayTime                              = GetDateTime(new IntPtr(p + 0x080)); // 0270D543B4B8 0x80 LastPlayTime                ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.DefaultRenderTexture                      = GetObject<Texture>(new IntPtr(p + 0x088), ReversePrism.DataModels.Texture.FromPointer); // 0270D543B4D8 0x88 DefaultRenderTexture        ( 00018664CFB0 ModelClassType Texture Texture Texture Pointer )
            value.Info                                      = GetObject<UICharacterVoiceInfo>(new IntPtr(p + 0x090), ReversePrism.DataModels.UICharacterVoiceInfo.FromPointer); // 0270D543B4F8 0x90 Info                        ( 0001866E3400 ModelClassType UICharacterVoiceInfo UICharacterVoiceInfo UICharacterVoiceInfo Pointer )
            value.CurrentFov                                = GetSingle(new IntPtr(p + 0x0A8)); // 0270D543B558 0xA8 CurrentFov                  ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
