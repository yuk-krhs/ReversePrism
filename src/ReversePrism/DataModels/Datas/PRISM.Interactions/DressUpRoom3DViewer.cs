using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CameraRotateSensitivity                  ModelPrimitiveType float float float Single
    // 024 CameraMoveSensitivity                    ModelPrimitiveType float float float Single
    // 028 SpeechBalloonView                        ModelClassType CharacterSpeechBalloonView CharacterSpeechBalloonView CharacterSpeechBalloonView Pointer
    // 030 CameraPinchZoomSensitivity               ModelPrimitiveType float float float Single
    // 034 CameraMouseZoomSensitivity               ModelPrimitiveType float float float Single
    // 038 MaxCameraPositionY                       ModelPrimitiveType float float float Single
    // 03C MinCameraPositionY                       ModelPrimitiveType float float float Single
    // 040 MaxFov                                   ModelPrimitiveType float float float Single
    // 044 MinFov                                   ModelPrimitiveType float float float Single
    // 048 MaxLookDownAngle                         ModelPrimitiveType float float float Single
    // 050 ViewerSafeArea                           ModelClassType UISafeArea UISafeArea UISafeArea Pointer
    // 058 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 060 Model3dLoader                            ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer
    // 068 onEndPlayingVoice                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 on3DModelClick                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 078 onPinch                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 onSwipe                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 onScroll                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 showUI                                   Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 098 CharaName                                ModelPrimitiveType string string string String
    // 0A0 PlayingVoiceDisposable                   ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0A8 OnClickFlag                              ModelPrimitiveType bool bool bool Bool
    // 0AC ClickCount                               ModelPrimitiveType int int int Int32
    // 0B0 CurrentFov                               ModelPrimitiveType float float float Single
    // 0B4 CurrentCameraPositionY                   ModelPrimitiveType float float float Single
    // 0B8 CurrentCameraDollyEndpointY              ModelPrimitiveType float float float Single
    // 0BC BaseDistanceOfCameraAndIdol              ModelPrimitiveType float float float Single
    // 0C0 DollyOutMaxDistance                      ModelPrimitiveType float float float Single
    // 0C4 TapAreaMinX                              ModelPrimitiveType float float float Single
    // 0C8 TapAreaMaxX                              ModelPrimitiveType float float float Single
    // 0CC TapAreaBaseMinX                          ModelPrimitiveType float float float Single
    // 0D0 TapAreaBaseMaxX                          ModelPrimitiveType float float float Single
    // 0D4 ScreenWidthInSafeArea                    ModelPrimitiveType float float float Single
    // 0D8 TapAreaCurrentMinX                       ModelPrimitiveType float float float Single
    // 0DC TapAreaCurrentMaxX                       ModelPrimitiveType float float float Single
    // 0E0 TapAreaMinY                              ModelPrimitiveType float float float Single
    // 0E4 WidthInSafeAreaOneTwelfth                ModelPrimitiveType float float float Single
    // 0E8 ScreenWidthHalf                          ModelPrimitiveType float float float Single
    // 0EC FovPosYCoefficient                       ModelPrimitiveType float float float Single
    // 0F0 IsActive                                 ModelPrimitiveType bool bool bool Bool
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
        public SimpleModel3dLoader?                     Model3dLoader                           { get; set; }
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

            value.CameraRotateSensitivity                   = GetSingle(new IntPtr(p + 0x020)); // 0x20 CameraRotateSensitivity     ( ModelPrimitiveType float float float Single )
            value.CameraMoveSensitivity                     = GetSingle(new IntPtr(p + 0x024)); // 0x24 CameraMoveSensitivity       ( ModelPrimitiveType float float float Single )
            value.SpeechBalloonView                         = GetObject<CharacterSpeechBalloonView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CharacterSpeechBalloonView.FromPointer); // 0x28 SpeechBalloonView           ( ModelClassType CharacterSpeechBalloonView CharacterSpeechBalloonView CharacterSpeechBalloonView Pointer )
            value.CameraPinchZoomSensitivity                = GetSingle(new IntPtr(p + 0x030)); // 0x30 CameraPinchZoomSensitivity  ( ModelPrimitiveType float float float Single )
            value.CameraMouseZoomSensitivity                = GetSingle(new IntPtr(p + 0x034)); // 0x34 CameraMouseZoomSensitivity  ( ModelPrimitiveType float float float Single )
            value.MaxCameraPositionY                        = GetSingle(new IntPtr(p + 0x038)); // 0x38 MaxCameraPositionY          ( ModelPrimitiveType float float float Single )
            value.MinCameraPositionY                        = GetSingle(new IntPtr(p + 0x03C)); // 0x3C MinCameraPositionY          ( ModelPrimitiveType float float float Single )
            value.MaxFov                                    = GetSingle(new IntPtr(p + 0x040)); // 0x40 MaxFov                      ( ModelPrimitiveType float float float Single )
            value.MinFov                                    = GetSingle(new IntPtr(p + 0x044)); // 0x44 MinFov                      ( ModelPrimitiveType float float float Single )
            value.MaxLookDownAngle                          = GetSingle(new IntPtr(p + 0x048)); // 0x48 MaxLookDownAngle            ( ModelPrimitiveType float float float Single )
            value.ViewerSafeArea                            = GetObject<UISafeArea>(new IntPtr(p + 0x050), ReversePrism.DataModels.UISafeArea.FromPointer); // 0x50 ViewerSafeArea              ( ModelClassType UISafeArea UISafeArea UISafeArea Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x58 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.Model3dLoader                             = GetObject<SimpleModel3dLoader>(new IntPtr(p + 0x060), ReversePrism.DataModels.SimpleModel3dLoader.FromPointer); // 0x60 Model3dLoader               ( ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer )
            value.CharaName                                 = GetString(new IntPtr(p + 0x098)); // 0x98 CharaName                   ( ModelPrimitiveType string string string String )
            value.PlayingVoiceDisposable                    = GetObject<IDisposable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xA0 PlayingVoiceDisposable      ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnClickFlag                               = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 OnClickFlag                 ( ModelPrimitiveType bool bool bool Bool )
            value.ClickCount                                = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC ClickCount                  ( ModelPrimitiveType int int int Int32 )
            value.CurrentFov                                = GetSingle(new IntPtr(p + 0x0B0)); // 0xB0 CurrentFov                  ( ModelPrimitiveType float float float Single )
            value.CurrentCameraPositionY                    = GetSingle(new IntPtr(p + 0x0B4)); // 0xB4 CurrentCameraPositionY      ( ModelPrimitiveType float float float Single )
            value.CurrentCameraDollyEndpointY               = GetSingle(new IntPtr(p + 0x0B8)); // 0xB8 CurrentCameraDollyEndpointY ( ModelPrimitiveType float float float Single )
            value.BaseDistanceOfCameraAndIdol               = GetSingle(new IntPtr(p + 0x0BC)); // 0xBC BaseDistanceOfCameraAndIdol ( ModelPrimitiveType float float float Single )
            value.DollyOutMaxDistance                       = GetSingle(new IntPtr(p + 0x0C0)); // 0xC0 DollyOutMaxDistance         ( ModelPrimitiveType float float float Single )
            value.TapAreaMinX                               = GetSingle(new IntPtr(p + 0x0C4)); // 0xC4 TapAreaMinX                 ( ModelPrimitiveType float float float Single )
            value.TapAreaMaxX                               = GetSingle(new IntPtr(p + 0x0C8)); // 0xC8 TapAreaMaxX                 ( ModelPrimitiveType float float float Single )
            value.TapAreaBaseMinX                           = GetSingle(new IntPtr(p + 0x0CC)); // 0xCC TapAreaBaseMinX             ( ModelPrimitiveType float float float Single )
            value.TapAreaBaseMaxX                           = GetSingle(new IntPtr(p + 0x0D0)); // 0xD0 TapAreaBaseMaxX             ( ModelPrimitiveType float float float Single )
            value.ScreenWidthInSafeArea                     = GetSingle(new IntPtr(p + 0x0D4)); // 0xD4 ScreenWidthInSafeArea       ( ModelPrimitiveType float float float Single )
            value.TapAreaCurrentMinX                        = GetSingle(new IntPtr(p + 0x0D8)); // 0xD8 TapAreaCurrentMinX          ( ModelPrimitiveType float float float Single )
            value.TapAreaCurrentMaxX                        = GetSingle(new IntPtr(p + 0x0DC)); // 0xDC TapAreaCurrentMaxX          ( ModelPrimitiveType float float float Single )
            value.TapAreaMinY                               = GetSingle(new IntPtr(p + 0x0E0)); // 0xE0 TapAreaMinY                 ( ModelPrimitiveType float float float Single )
            value.WidthInSafeAreaOneTwelfth                 = GetSingle(new IntPtr(p + 0x0E4)); // 0xE4 WidthInSafeAreaOneTwelfth   ( ModelPrimitiveType float float float Single )
            value.ScreenWidthHalf                           = GetSingle(new IntPtr(p + 0x0E8)); // 0xE8 ScreenWidthHalf             ( ModelPrimitiveType float float float Single )
            value.FovPosYCoefficient                        = GetSingle(new IntPtr(p + 0x0EC)); // 0xEC FovPosYCoefficient          ( ModelPrimitiveType float float float Single )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x0F0)); // 0xF0 IsActive                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
