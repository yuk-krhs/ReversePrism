using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MainCameraController                     ModelClassType CameraController CameraController CameraController Pointer
    // 028 MyDirector                               ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 030 CriAtomTrackTime                         ModelPrimitiveType long long long Int64
    // 038 Duration                                 ModelPrimitiveType double double double Double
    // 040 onLyric                                  Action`1<string> IL2CPP_TYPE_GENERICINST
    // 000 DanceTrackName                           string IL2CPP_TYPE_STRING
    // 000 EyeOpenCloseTrackName                    string IL2CPP_TYPE_STRING
    // 000 EyeScleraTrackName                       string IL2CPP_TYPE_STRING
    // 000 LipSyncTrackName                         string IL2CPP_TYPE_STRING
    // 000 ActivationTrackName                      string IL2CPP_TYPE_STRING
    // 000 PersonalLightTrackName                   string IL2CPP_TYPE_STRING
    // 000 SwitchModelTrackName                     string IL2CPP_TYPE_STRING
    // 000 HighlightShakeTrackName                  string IL2CPP_TYPE_STRING
    // 000 CriManaTrackName                         string IL2CPP_TYPE_STRING
    // 000 CriAtomTrack                             string IL2CPP_TYPE_STRING
    // 000 Center                                   string IL2CPP_TYPE_STRING
    // 000 CenterLeft                               string IL2CPP_TYPE_STRING
    // 000 CenterRight                              string IL2CPP_TYPE_STRING
    // 000 Left                                     string IL2CPP_TYPE_STRING
    // 000 Right                                    string IL2CPP_TYPE_STRING
    // 000 CharacterTrackMax                        int IL2CPP_TYPE_I4
    // 000 CharacterString                          string IL2CPP_TYPE_STRING
    // 000 preform                                  Utf8PreparedFormat`1<int> IL2CPP_TYPE_GENERICINST
    // 000 NotificationTrack                        string IL2CPP_TYPE_STRING
    // 000 EffectUnitTrack                          string IL2CPP_TYPE_STRING
    // 000 EffectLiveTrackSmallSwitch               string IL2CPP_TYPE_STRING
    // 000 EffectAlwaysTrack                        string IL2CPP_TYPE_STRING
    public partial class TimelineController : DataModel
    {
        public CameraController?                        MainCameraController                    { get; set; }
        public PlayableDirector?                        MyDirector                              { get; set; }
        public long                                     CriAtomTrackTime                        { get; set; }
        public double                                   Duration                                { get; set; }

        public static TimelineController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimelineController() { Pointer= p0 };

            value.MainCameraController                      = GetObject<CameraController>(new IntPtr(p + 0x020), ReversePrism.DataModels.CameraController.FromPointer); // 0x20 MainCameraController        ( ModelClassType CameraController CameraController CameraController Pointer )
            value.MyDirector                                = GetObject<PlayableDirector>(new IntPtr(p + 0x028), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x28 MyDirector                  ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.CriAtomTrackTime                          = GetInt64(new IntPtr(p + 0x030)); // 0x30 CriAtomTrackTime            ( ModelPrimitiveType long long long Int64 )
            value.Duration                                  = GetDouble(new IntPtr(p + 0x038)); // 0x38 Duration                    ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
