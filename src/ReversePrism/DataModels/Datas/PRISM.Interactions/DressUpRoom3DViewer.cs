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
    public partial class DressUpRoom3DViewer : DataModel
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
            var value   = new DressUpRoom3DViewer() { Pointer= p0 };

            value.CameraRotateSensitivity                   = GetSingle(new IntPtr(p + 0x020)); // 02466B6D1840 0x20 CameraRotateSensitivity     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraMoveSensitivity                     = GetSingle(new IntPtr(p + 0x024)); // 02466B6D1860 0x24 CameraMoveSensitivity       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SpeechBalloonView                         = GetObject<CharacterSpeechBalloonView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CharacterSpeechBalloonView.FromPointer); // 02466B6D1880 0x28 SpeechBalloonView           ( 0001865A3FE0 ModelClassType CharacterSpeechBalloonView CharacterSpeechBalloonView CharacterSpeechBalloonView Pointer )
            value.CameraPinchZoomSensitivity                = GetSingle(new IntPtr(p + 0x030)); // 02466B6D18A0 0x30 CameraPinchZoomSensitivity  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraMouseZoomSensitivity                = GetSingle(new IntPtr(p + 0x034)); // 02466B6D18C0 0x34 CameraMouseZoomSensitivity  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MaxCameraPositionY                        = GetSingle(new IntPtr(p + 0x038)); // 02466B6D18E0 0x38 MaxCameraPositionY          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MinCameraPositionY                        = GetSingle(new IntPtr(p + 0x03C)); // 02466B6D1900 0x3C MinCameraPositionY          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MaxFov                                    = GetSingle(new IntPtr(p + 0x040)); // 02466B6D1920 0x40 MaxFov                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MinFov                                    = GetSingle(new IntPtr(p + 0x044)); // 02466B6D1940 0x44 MinFov                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MaxLookDownAngle                          = GetSingle(new IntPtr(p + 0x048)); // 02466B6D1960 0x48 MaxLookDownAngle            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ViewerSafeArea                            = GetObject<UISafeArea>(new IntPtr(p + 0x050), ReversePrism.DataModels.UISafeArea.FromPointer); // 02466B6D1980 0x50 ViewerSafeArea              ( 0001866F2010 ModelClassType UISafeArea UISafeArea UISafeArea Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScenarioManager.FromPointer); // 02466B6D19A0 0x58 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.CharaName                                 = GetString(new IntPtr(p + 0x090)); // 02466B6D1A80 0x90 CharaName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.PlayingVoiceDisposable                    = GetObject<IDisposable>(new IntPtr(p + 0x098), ReversePrism.DataModels.IDisposable.FromPointer); // 02466B6D1AA0 0x98 PlayingVoiceDisposable      ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnClickFlag                               = GetBool(new IntPtr(p + 0x0A0)); // 02466B6D1AC0 0xA0 OnClickFlag                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ClickCount                                = GetInt32(new IntPtr(p + 0x0A4)); // 02466B6D1AE0 0xA4 ClickCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentFov                                = GetSingle(new IntPtr(p + 0x0A8)); // 02466B6D1B00 0xA8 CurrentFov                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentCameraPositionY                    = GetSingle(new IntPtr(p + 0x0AC)); // 02466B6D1B20 0xAC CurrentCameraPositionY      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentCameraDollyEndpointY               = GetSingle(new IntPtr(p + 0x0B0)); // 02466B6D1B40 0xB0 CurrentCameraDollyEndpointY ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.BaseDistanceOfCameraAndIdol               = GetSingle(new IntPtr(p + 0x0B4)); // 02466B6D1B60 0xB4 BaseDistanceOfCameraAndIdol ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.DollyOutMaxDistance                       = GetSingle(new IntPtr(p + 0x0B8)); // 02466B6D1B80 0xB8 DollyOutMaxDistance         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaMinX                               = GetSingle(new IntPtr(p + 0x0BC)); // 02466B6D1BA0 0xBC TapAreaMinX                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaMaxX                               = GetSingle(new IntPtr(p + 0x0C0)); // 02466B6D1BC0 0xC0 TapAreaMaxX                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaBaseMinX                           = GetSingle(new IntPtr(p + 0x0C4)); // 02466B6D1BE0 0xC4 TapAreaBaseMinX             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaBaseMaxX                           = GetSingle(new IntPtr(p + 0x0C8)); // 02466B6D1C00 0xC8 TapAreaBaseMaxX             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScreenWidthInSafeArea                     = GetSingle(new IntPtr(p + 0x0CC)); // 02466B6D1C20 0xCC ScreenWidthInSafeArea       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaCurrentMinX                        = GetSingle(new IntPtr(p + 0x0D0)); // 02466B6D1C40 0xD0 TapAreaCurrentMinX          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaCurrentMaxX                        = GetSingle(new IntPtr(p + 0x0D4)); // 02466B6D1C60 0xD4 TapAreaCurrentMaxX          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TapAreaMinY                               = GetSingle(new IntPtr(p + 0x0D8)); // 02466B6D1C80 0xD8 TapAreaMinY                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.WidthInSafeAreaOneTwelfth                 = GetSingle(new IntPtr(p + 0x0DC)); // 02466B6D1CA0 0xDC WidthInSafeAreaOneTwelfth   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScreenWidthHalf                           = GetSingle(new IntPtr(p + 0x0E0)); // 02466B6D1CC0 0xE0 ScreenWidthHalf             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.FovPosYCoefficient                        = GetSingle(new IntPtr(p + 0x0E4)); // 02466B6D1CE0 0xE4 FovPosYCoefficient          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x0E8)); // 02466B6D1D00 0xE8 IsActive                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
