using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgTouchDetector                         ModelClassType Image Image Image Pointer
    // 028 CharaView                                ModelClassType RawImage RawImage RawImage Pointer
    // 030 SpeechBalloonView                        ModelClassType CharacterSpeechBalloonView CharacterSpeechBalloonView CharacterSpeechBalloonView Pointer
    // 038 IsEnableManualCamera                     ModelPrimitiveType bool bool bool Bool
    // 03C CameraRotateSensitivity                  ModelPrimitiveType float float float Single
    // 040 CameraMoveSensitivity                    ModelPrimitiveType float float float Single
    // 044 CameraPinchZoomSensitivity               ModelPrimitiveType float float float Single
    // 048 CameraMouseZoomSensitivity               ModelPrimitiveType float float float Single
    // 04C CameraMaxFov                             ModelPrimitiveType float float float Single
    // 050 CameraMinFov                             ModelPrimitiveType float float float Single
    // 058 OnStopVoiceDisposable                    ModelClassType IDisposable IDisposable IDisposable Pointer
    // 060 SetupForCostumeChangeDisposable          ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 068 AutoActionCts                            ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 070 isOverlayShowFunc                        Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 Viewer                                   ModelClassType UI3DModelViewer UI3DModelViewer UI3DModelViewer Pointer
    // 080 loadedOther3DScene                       IEnumerable`1<SceneLoaderAddressable> IL2CPP_TYPE_GENERICINST
    // 088 LastPlayTime                             ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 090 DefaultRenderTexture                     ModelClassType Texture Texture Texture Pointer
    // 098 Info                                     ModelClassType UICharacterVoiceInfo UICharacterVoiceInfo UICharacterVoiceInfo Pointer
    // 0A0 onSwipe                                  Subject`1<Vector2> IL2CPP_TYPE_GENERICINST
    // 0A8 onPinch                                  Subject`1<float> IL2CPP_TYPE_GENERICINST
    // 0B0 CurrentFov                               ModelPrimitiveType float float float Single
    public partial class UICharacterViewer : DataModel
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
        public CompositeDisposable?                     SetupForCostumeChangeDisposable         { get; set; }
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
            var value   = new UICharacterViewer() { Pointer= p0 };

            value.ImgTouchDetector                          = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 ImgTouchDetector            ( ModelClassType Image Image Image Pointer )
            value.CharaView                                 = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 CharaView                   ( ModelClassType RawImage RawImage RawImage Pointer )
            value.SpeechBalloonView                         = GetObject<CharacterSpeechBalloonView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CharacterSpeechBalloonView.FromPointer); // 0x30 SpeechBalloonView           ( ModelClassType CharacterSpeechBalloonView CharacterSpeechBalloonView CharacterSpeechBalloonView Pointer )
            value.IsEnableManualCamera                      = GetBool(new IntPtr(p + 0x038)); // 0x38 IsEnableManualCamera        ( ModelPrimitiveType bool bool bool Bool )
            value.CameraRotateSensitivity                   = GetSingle(new IntPtr(p + 0x03C)); // 0x3C CameraRotateSensitivity     ( ModelPrimitiveType float float float Single )
            value.CameraMoveSensitivity                     = GetSingle(new IntPtr(p + 0x040)); // 0x40 CameraMoveSensitivity       ( ModelPrimitiveType float float float Single )
            value.CameraPinchZoomSensitivity                = GetSingle(new IntPtr(p + 0x044)); // 0x44 CameraPinchZoomSensitivity  ( ModelPrimitiveType float float float Single )
            value.CameraMouseZoomSensitivity                = GetSingle(new IntPtr(p + 0x048)); // 0x48 CameraMouseZoomSensitivity  ( ModelPrimitiveType float float float Single )
            value.CameraMaxFov                              = GetSingle(new IntPtr(p + 0x04C)); // 0x4C CameraMaxFov                ( ModelPrimitiveType float float float Single )
            value.CameraMinFov                              = GetSingle(new IntPtr(p + 0x050)); // 0x50 CameraMinFov                ( ModelPrimitiveType float float float Single )
            value.OnStopVoiceDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0x58 OnStopVoiceDisposable       ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.SetupForCostumeChangeDisposable           = GetObject<CompositeDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x60 SetupForCostumeChangeDisposable ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.AutoActionCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x68 AutoActionCts               ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Viewer                                    = GetObject<UI3DModelViewer>(new IntPtr(p + 0x078), ReversePrism.DataModels.UI3DModelViewer.FromPointer); // 0x78 Viewer                      ( ModelClassType UI3DModelViewer UI3DModelViewer UI3DModelViewer Pointer )
            value.LastPlayTime                              = GetDateTime(new IntPtr(p + 0x088)); // 0x88 LastPlayTime                ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.DefaultRenderTexture                      = GetObject<Texture>(new IntPtr(p + 0x090), ReversePrism.DataModels.Texture.FromPointer); // 0x90 DefaultRenderTexture        ( ModelClassType Texture Texture Texture Pointer )
            value.Info                                      = GetObject<UICharacterVoiceInfo>(new IntPtr(p + 0x098), ReversePrism.DataModels.UICharacterVoiceInfo.FromPointer); // 0x98 Info                        ( ModelClassType UICharacterVoiceInfo UICharacterVoiceInfo UICharacterVoiceInfo Pointer )
            value.CurrentFov                                = GetSingle(new IntPtr(p + 0x0B0)); // 0xB0 CurrentFov                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
