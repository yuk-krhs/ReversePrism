using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CameraRotateSensitivity                  0001866656B0 ModelPrimitiveType float float float Single
    // 024 CameraMoveSensitivity                    0001866656B0 ModelPrimitiveType float float float Single
    // 028 SpeechBalloonView                        0001865A3FE0 ModelClassType CharacterSpeechBalloonView CharacterSpeechBalloonView CharacterSpeechBalloonView Pointer
    // 030 CameraPinchZoomSensitivity               0001866656B0 ModelPrimitiveType float float float Single
    // 034 CameraMouseZoomSensitivity               0001866656B0 ModelPrimitiveType float float float Single
    // 038 MaxCameraPositionY                       0001866656B0 ModelPrimitiveType float float float Single
    // 03C MinCameraPositionY                       0001866656B0 ModelPrimitiveType float float float Single
    // 040 MaxFov                                   0001866656B0 ModelPrimitiveType float float float Single
    // 044 MinFov                                   0001866656B0 ModelPrimitiveType float float float Single
    // 048 MaxLookDownAngle                         0001866656B0 ModelPrimitiveType float float float Single
    // 050 ViewerSafeArea                           0001866F2010 ModelClassType UISafeArea UISafeArea UISafeArea Pointer
    // 058 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 060 onEndPlayingVoice                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 on3DModelClick                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 onPinch                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 078 onSwipe                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 onScroll                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 showUI                                   Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 090 CharaName                                000186671910 ModelPrimitiveType string string string String
    // 098 PlayingVoiceDisposable                   0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0A0 OnClickFlag                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A4 ClickCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A8 CurrentFov                               0001866656B0 ModelPrimitiveType float float float Single
    // 0AC CurrentCameraPositionY                   0001866656B0 ModelPrimitiveType float float float Single
    // 0B0 CurrentCameraDollyEndpointY              0001866656B0 ModelPrimitiveType float float float Single
    // 0B4 BaseDistanceOfCameraAndIdol              0001866656B0 ModelPrimitiveType float float float Single
    // 0B8 DollyOutMaxDistance                      0001866656B0 ModelPrimitiveType float float float Single
    // 0BC TapAreaMinX                              0001866656B0 ModelPrimitiveType float float float Single
    // 0C0 TapAreaMaxX                              0001866656B0 ModelPrimitiveType float float float Single
    // 0C4 TapAreaBaseMinX                          0001866656B0 ModelPrimitiveType float float float Single
    // 0C8 TapAreaBaseMaxX                          0001866656B0 ModelPrimitiveType float float float Single
    // 0CC ScreenWidthInSafeArea                    0001866656B0 ModelPrimitiveType float float float Single
    // 0D0 TapAreaCurrentMinX                       0001866656B0 ModelPrimitiveType float float float Single
    // 0D4 TapAreaCurrentMaxX                       0001866656B0 ModelPrimitiveType float float float Single
    // 0D8 TapAreaMinY                              0001866656B0 ModelPrimitiveType float float float Single
    // 0DC WidthInSafeAreaOneTwelfth                0001866656B0 ModelPrimitiveType float float float Single
    // 0E0 ScreenWidthHalf                          0001866656B0 ModelPrimitiveType float float float Single
    // 0E4 FovPosYCoefficient                       0001866656B0 ModelPrimitiveType float float float Single
    // 0E8 IsActive                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DressUpRoom3DViewer
    {
        public float                                    CameraRotateSensitivity                 { get; set; }
        public float                                    CameraMoveSensitivity                   { get; set; }
        public CharacterSpeechBalloonView?              SpeechBalloonView                       { get; set; }
        public float                                    CameraPinchZoomSensitivity              { get; set; }
        public float                                    CameraMouseZoomSensitivity              { get; set; }
        public float                                    MaxCameraPositionY                      { get; set; }
        public float                                    MinCameraPositionY                      { get; set; }
        public float                                    MaxFov                                  { get; set; }
        public float                                    MinFov                                  { get; set; }
        public float                                    MaxLookDownAngle                        { get; set; }
        public UISafeArea?                              ViewerSafeArea                          { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public string                                   CharaName                               { get; set; }
        public IDisposable?                             PlayingVoiceDisposable                  { get; set; }
        public bool                                     OnClickFlag                             { get; set; }
        public int                                      ClickCount                              { get; set; }
        public float                                    CurrentFov                              { get; set; }
        public float                                    CurrentCameraPositionY                  { get; set; }
        public float                                    CurrentCameraDollyEndpointY             { get; set; }
        public float                                    BaseDistanceOfCameraAndIdol             { get; set; }
        public float                                    DollyOutMaxDistance                     { get; set; }
        public float                                    TapAreaMinX                             { get; set; }
        public float                                    TapAreaMaxX                             { get; set; }
        public float                                    TapAreaBaseMinX                         { get; set; }
        public float                                    TapAreaBaseMaxX                         { get; set; }
        public float                                    ScreenWidthInSafeArea                   { get; set; }
        public float                                    TapAreaCurrentMinX                      { get; set; }
        public float                                    TapAreaCurrentMaxX                      { get; set; }
        public float                                    TapAreaMinY                             { get; set; }
        public float                                    WidthInSafeAreaOneTwelfth               { get; set; }
        public float                                    ScreenWidthHalf                         { get; set; }
        public float                                    FovPosYCoefficient                      { get; set; }
        public bool                                     IsActive                                { get; set; }

        public static DressUpRoom3DViewer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoom3DViewer();

            value.CameraRotateSensitivity                   = GetSingle(new IntPtr(p + 0x020)); // 0270DB6456E0 0x20 CameraRotateSensitivity     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraMoveSensitivity                     = GetSingle(new IntPtr(p + 0x024)); // 0270DB645700 0x24 CameraMoveSensitivity       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SpeechBalloonView                         = GetObject<CharacterSpeechBalloonView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CharacterSpeechBalloonView.FromPointer); // 0270DB645720 0x28 SpeechBalloonView           ( 0001865A3FE0 ModelClassType CharacterSpeechBalloonView CharacterSpeechBalloonView CharacterSpeechBalloonView Pointer )
            value.CameraPinchZoomSensitivity                = GetSingle(new IntPtr(p + 0x030)); // 0270DB645740 0x30 CameraPinchZoomSensitivity  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraMouseZoomSensitivity                = GetSingle(new IntPtr(p + 0x034)); // 0270DB645760 0x34 CameraMouseZoomSensitivity  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MaxCameraPositionY                        = GetSingle(new IntPtr(p + 0x038)); // 0270DB645780 0x38 MaxCameraPositionY          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MinCameraPositionY                        = GetSingle(new IntPtr(p + 0x03C)); // 0270DB6457A0 0x3C MinCameraPositionY          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MaxFov                                    = GetSingle(new IntPtr(p + 0x040)); // 0270DB6457C0 0x40 MaxFov                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MinFov                                    = GetSingle(new IntPtr(p + 0x044)); // 0270DB6457E0 0x44 MinFov                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MaxLookDownAngle                          = GetSingle(new IntPtr(p + 0x048)); // 0270DB645800 0x48 MaxLookDownAngle            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ViewerSafeArea                            = GetObject<UISafeArea>(new IntPtr(p + 0x050), ReversePrism.DataModels.UISafeArea.FromPointer); // 0270DB645820 0x50 ViewerSafeArea              ( 0001866F2010 ModelClassType UISafeArea UISafeArea UISafeArea Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0270DB645840 0x58 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.CharaName                                 = GetString(new IntPtr(p + 0x090)); // 0270DB645920 0x90 CharaName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.PlayingVoiceDisposable                    = GetObject<IDisposable>(new IntPtr(p + 0x098), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB645940 0x98 PlayingVoiceDisposable      ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnClickFlag                               = GetBool(new IntPtr(p + 0x0A0)); // 0270DB645960 0xA0 OnClickFlag                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ClickCount                                = GetInt32(new IntPtr(p + 0x0A4)); // 0270DB645980 0xA4 ClickCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentFov                                = GetSingle(new IntPtr(p + 0x0A8)); // 0270DB6459A0 0xA8 CurrentFov                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentCameraPositionY                    = GetSingle(new IntPtr(p + 0x0AC)); // 0270DB6459C0 0xAC CurrentCameraPositionY      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentCameraDollyEndpointY               = GetSingle(new IntPtr(p + 0x0B0)); // 0270DB6459E0 0xB0 CurrentCameraDollyEndpointY ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.BaseDistanceOfCameraAndIdol               = GetSingle(new IntPtr(p + 0x0B4)); // 0270DB645A00 0xB4 BaseDistanceOfCameraAndIdol ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.DollyOutMaxDistance                       = GetSingle(new IntPtr(p + 0x0B8)); // 0270DB645A20 0xB8 DollyOutMaxDistance         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaMinX                               = GetSingle(new IntPtr(p + 0x0BC)); // 0270DB645A40 0xBC TapAreaMinX                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaMaxX                               = GetSingle(new IntPtr(p + 0x0C0)); // 0270DB645A60 0xC0 TapAreaMaxX                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaBaseMinX                           = GetSingle(new IntPtr(p + 0x0C4)); // 0270DB645A80 0xC4 TapAreaBaseMinX             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaBaseMaxX                           = GetSingle(new IntPtr(p + 0x0C8)); // 0270DB645AA0 0xC8 TapAreaBaseMaxX             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScreenWidthInSafeArea                     = GetSingle(new IntPtr(p + 0x0CC)); // 0270DB645AC0 0xCC ScreenWidthInSafeArea       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaCurrentMinX                        = GetSingle(new IntPtr(p + 0x0D0)); // 0270DB645AE0 0xD0 TapAreaCurrentMinX          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaCurrentMaxX                        = GetSingle(new IntPtr(p + 0x0D4)); // 0270DB645B00 0xD4 TapAreaCurrentMaxX          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaMinY                               = GetSingle(new IntPtr(p + 0x0D8)); // 0270DB645B20 0xD8 TapAreaMinY                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.WidthInSafeAreaOneTwelfth                 = GetSingle(new IntPtr(p + 0x0DC)); // 0270DB645B40 0xDC WidthInSafeAreaOneTwelfth   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScreenWidthHalf                           = GetSingle(new IntPtr(p + 0x0E0)); // 0270DB645B60 0xE0 ScreenWidthHalf             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.FovPosYCoefficient                        = GetSingle(new IntPtr(p + 0x0E4)); // 0270DB645B80 0xE4 FovPosYCoefficient          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x0E8)); // 0270DB645BA0 0xE8 IsActive                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
