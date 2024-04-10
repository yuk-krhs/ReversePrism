using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Camera                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 CameraCache                              0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 030 PostProcess                              000185B9BE40 ModelClassListType PostProcessVolume[] PostProcessVolume[] List<PostProcessVolume> Pointer
    // 038 DepthOfField                             000185B7A1B0 ModelClassListType DepthOfField[] DepthOfField[] List<DepthOfField> Pointer
    // 040 Objects                                  000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 048 CamWorkData                              000185D20578 ModelClassListType List`1<CameraWorkData> List`1<CameraWorkData> List<CameraWorkData> Pointer
    // 050 CamMoveData                              000185D20338 ModelClassListType List`1<CameraMoveData> List`1<CameraMoveData> List<CameraMoveData> Pointer
    // 058 CommonCamMoveDataCount                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 CurrentSceneName                         0001866722E0 ModelPrimitiveType string string string String
    // 068 Timeline                                 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 070 TimeCount                                000186666050 ModelPrimitiveType float float float Single
    // 078 CurrentCameraWorkData                    000186725720 ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer
    // 080 NextCameraWorkData                       000186725720 ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer
    // 088 LiveChara                                000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 090 FixCameraPosition                        000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 098 Audience                                 000186715720 ModelClassType AudienceController AudienceController AudienceController Pointer
    // 0A0 Scenario                                 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 0A8 CutScene                                 00018666E600 ModelClassType CutScene CutScene CutScene Pointer
    // 0B0 CurrentCameraDir                         000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 0B8 CurrentCameraUp                          000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 0C0 ScreenEffect                             0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 0C8 SwayBoneManager                          0001865FA8D0 ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer
    // 0D0 FadeCamera                               0001865A2380 ModelClassType Camera Camera Camera Pointer
    // 0D8 LiveScene                                000186576D00 ModelClassType LiveScene LiveScene LiveScene Pointer
    // 000 ToIntMargin                              float IL2CPP_TYPE_R4
    // 000 AllTimelineDoFs                          HashSet`1<DepthOfField> IL2CPP_TYPE_GENERICINST
    // 0E0 TimelineDoF                              0001866C21C0 ModelClassType DepthOfField DepthOfField DepthOfField Pointer
    // 0E8 CameraIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0EC CenterTarget                             0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0F8 CharacterNum                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 0FC TargetPosition                           0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 108 TargetSpeed                              0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 114 TargetOffset                             0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 120 CameraLastPosition                       0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 12C CameraPosition                           0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 138 CameraOffset                             0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 144 CameraLastRotation                       000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 154 CameraRotation                           00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 164 CameraPlusRotation                       000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 174 CameraLastRotEuler                       0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 180 CameraLastFramePos                       0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 18C CameraLastFrameRot                       0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 198 CameraLastFieldOfView                    0001866656B0 ModelPrimitiveType float float float Single
    // 19C CameraFieldOfView                        0001866656B0 ModelPrimitiveType float float float Single
    // 1A0 CameraLastFocus                          0001866656B0 ModelPrimitiveType float float float Single
    // 1A4 CameraFocus                              0001866656B0 ModelPrimitiveType float float float Single
    // 1A8 CameraFocusValue                         0001866656B0 ModelPrimitiveType float float float Single
    // 1AC CameraSpeedPos                           0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 1B8 CameraSpeedRot                           0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 1C4 CameraSpeedFov                           0001866656B0 ModelPrimitiveType float float float Single
    // 1C8 LastFrame                                0001866656B0 ModelPrimitiveType float float float Single
    // 1CC CameraPlusZ                              000186666050 ModelPrimitiveType float float float Single
    // 1D0 CameraRangeRadius                        000186666050 ModelPrimitiveType float float float Single
    // 000 maxTraceSpeed                            float IL2CPP_TYPE_R4
    // 000 minTraceSpeed                            float IL2CPP_TYPE_R4
    // 000 maxDumper                                float IL2CPP_TYPE_R4
    // 000 minDumper                                float IL2CPP_TYPE_R4
    // 000 baseAspect                               float IL2CPP_TYPE_R4
    // 000 maxOne                                   float IL2CPP_TYPE_R4
    // 1D4 CameraEdit                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 1D8 InterRate                                000186666050 ModelPrimitiveType float float float Single
    // 1DC DefaultZ                                 000186666050 ModelPrimitiveType float float float Single
    // 1E0 BoneNames                                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1E8 ShootingTypeTable                        000185CB7068 ModelClassListType ShootingTypeTable[] ShootingTypeTable[] List<ShootingTypeTable> Pointer
    // 1F0 Characters                               000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer
    // 1F8 boneObjects                              <Array> IL2CPP_TYPE_ARRAY
    // 200 Onoff                                    000185B78DC0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 208 IsPresetMode                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 CameraMoveLimitYAxis                     float IL2CPP_TYPE_R4
    // 20C CameraStartPosition                      0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 218 CommonCameraMoveFile                     000186671910 ModelPrimitiveType string string string String
    // 220 moveIDTable                              Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    public partial class CameraWorkEvent : DataModel
    {
        public GameObject?                              Camera                                  { get; set; }
        public Camera?                                  CameraCache                             { get; set; }
        public List<PostProcessVolume>?                 PostProcess                             { get; set; }
        public List<DepthOfField>?                      DepthOfField                            { get; set; }
        public List<GameObject>?                        Objects                                 { get; set; }
        public List<CameraWorkData>?                    CamWorkData                             { get; set; }
        public List<CameraMoveData>?                    CamMoveData                             { get; set; }
        public int                                      CommonCamMoveDataCount                  { get; set; }
        public string                                   CurrentSceneName                        { get; set; }
        public PlayableDirector?                        Timeline                                { get; set; }
        public float                                    TimeCount                               { get; set; }
        public CameraWorkData?                          CurrentCameraWorkData                   { get; set; }
        public CameraWorkData?                          NextCameraWorkData                      { get; set; }
        public LiveCharacterController?                 LiveChara                               { get; set; }
        public List<Vector3>?                           FixCameraPosition                       { get; set; }
        public AudienceController?                      Audience                                { get; set; }
        public ScenarioManager?                         Scenario                                { get; set; }
        public CutScene?                                CutScene                                { get; set; }
        public List<Vector3>?                           CurrentCameraDir                        { get; set; }
        public List<Vector3>?                           CurrentCameraUp                         { get; set; }
        public ScreenEffectEx?                          ScreenEffect                            { get; set; }
        public SwayBoneManager?                         SwayBoneManager                         { get; set; }
        public Camera?                                  FadeCamera                              { get; set; }
        public LiveScene?                               LiveScene                               { get; set; }
        public DepthOfField?                            TimelineDoF                             { get; set; }
        public int                                      CameraIndex                             { get; set; }
        public Vector3                                  CenterTarget                            { get; set; }
        public int                                      CharacterNum                            { get; set; }
        public Vector3                                  TargetPosition                          { get; set; }
        public Vector3                                  TargetSpeed                             { get; set; }
        public Vector3                                  TargetOffset                            { get; set; }
        public Vector3                                  CameraLastPosition                      { get; set; }
        public Vector3                                  CameraPosition                          { get; set; }
        public Vector3                                  CameraOffset                            { get; set; }
        public Quaternion                               CameraLastRotation                      { get; set; }
        public Quaternion                               CameraRotation                          { get; set; }
        public Quaternion                               CameraPlusRotation                      { get; set; }
        public Vector3                                  CameraLastRotEuler                      { get; set; }
        public Vector3                                  CameraLastFramePos                      { get; set; }
        public Vector3                                  CameraLastFrameRot                      { get; set; }
        public float                                    CameraLastFieldOfView                   { get; set; }
        public float                                    CameraFieldOfView                       { get; set; }
        public float                                    CameraLastFocus                         { get; set; }
        public float                                    CameraFocus                             { get; set; }
        public float                                    CameraFocusValue                        { get; set; }
        public Vector3                                  CameraSpeedPos                          { get; set; }
        public Vector3                                  CameraSpeedRot                          { get; set; }
        public float                                    CameraSpeedFov                          { get; set; }
        public float                                    LastFrame                               { get; set; }
        public float                                    CameraPlusZ                             { get; set; }
        public float                                    CameraRangeRadius                       { get; set; }
        public bool                                     CameraEdit                              { get; set; }
        public float                                    InterRate                               { get; set; }
        public float                                    DefaultZ                                { get; set; }
        public List<string>?                            BoneNames                               { get; set; }
        public List<ShootingTypeTable>?                 ShootingTypeTable                       { get; set; }
        public List<Character>?                         Characters                              { get; set; }
        public List<bool>?                              Onoff                                   { get; set; }
        public bool                                     IsPresetMode                            { get; set; }
        public Vector3                                  CameraStartPosition                     { get; set; }
        public string                                   CommonCameraMoveFile                    { get; set; }

        public static CameraWorkEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraWorkEvent() { Pointer= p0 };

            value.Camera                                    = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0245A6AB5B20 0x20 Camera                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CameraCache                               = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 0245A6AB5B40 0x28 CameraCache                 ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.PostProcess                               = GetObjectList<PostProcessVolume>(new IntPtr(p + 0x030), ReversePrism.DataModels.PostProcessVolume.FromPointer); // 0245A6AB5B60 0x30 PostProcess                 ( 000185B9BE40 ModelClassListType PostProcessVolume[] PostProcessVolume[] List<PostProcessVolume> Pointer )
            value.DepthOfField                              = GetObjectList<DepthOfField>(new IntPtr(p + 0x038), ReversePrism.DataModels.DepthOfField.FromPointer); // 0245A6AB5B80 0x38 DepthOfField                ( 000185B7A1B0 ModelClassListType DepthOfField[] DepthOfField[] List<DepthOfField> Pointer )
            value.Objects                                   = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0245A6AB5BA0 0x40 Objects                     ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.CamWorkData                               = GetObjectList<CameraWorkData>(new IntPtr(p + 0x048), ReversePrism.DataModels.CameraWorkData.FromPointer); // 0245A6AB5BC0 0x48 CamWorkData                 ( 000185D20578 ModelClassListType List`1<CameraWorkData> List`1<CameraWorkData> List<CameraWorkData> Pointer )
            value.CamMoveData                               = GetObjectList<CameraMoveData>(new IntPtr(p + 0x050), ReversePrism.DataModels.CameraMoveData.FromPointer); // 0245A6AB5BE0 0x50 CamMoveData                 ( 000185D20338 ModelClassListType List`1<CameraMoveData> List`1<CameraMoveData> List<CameraMoveData> Pointer )
            value.CommonCamMoveDataCount                    = GetInt32(new IntPtr(p + 0x058)); // 0245A6AB5C00 0x58 CommonCamMoveDataCount      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentSceneName                          = GetString(new IntPtr(p + 0x060)); // 0245A6AB5C20 0x60 CurrentSceneName            ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x068), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0245A6AB5C40 0x68 Timeline                    ( 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.TimeCount                                 = GetSingle(new IntPtr(p + 0x070)); // 0245A6AB5C60 0x70 TimeCount                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.CurrentCameraWorkData                     = GetObject<CameraWorkData>(new IntPtr(p + 0x078), ReversePrism.DataModels.CameraWorkData.FromPointer); // 0245A6AB5C80 0x78 CurrentCameraWorkData       ( 000186725720 ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer )
            value.NextCameraWorkData                        = GetObject<CameraWorkData>(new IntPtr(p + 0x080), ReversePrism.DataModels.CameraWorkData.FromPointer); // 0245A6AB5CA0 0x80 NextCameraWorkData          ( 000186725720 ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer )
            value.LiveChara                                 = GetObject<LiveCharacterController>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0245A6AB5CC0 0x88 LiveChara                   ( 000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.FixCameraPosition                         = GetEnumList<Vector3>(new IntPtr(p + 0x090)); // 0245A6AB5CE0 0x90 FixCameraPosition           ( 000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Audience                                  = GetObject<AudienceController>(new IntPtr(p + 0x098), ReversePrism.DataModels.AudienceController.FromPointer); // 0245A6AB5D00 0x98 Audience                    ( 000186715720 ModelClassType AudienceController AudienceController AudienceController Pointer )
            value.Scenario                                  = GetObject<ScenarioManager>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0245A6AB5D20 0xA0 Scenario                    ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.CutScene                                  = GetObject<CutScene>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CutScene.FromPointer); // 0245A6AB5D40 0xA8 CutScene                    ( 00018666E600 ModelClassType CutScene CutScene CutScene Pointer )
            value.CurrentCameraDir                          = GetEnumList<Vector3>(new IntPtr(p + 0x0B0)); // 0245A6AB5D60 0xB0 CurrentCameraDir            ( 000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.CurrentCameraUp                           = GetEnumList<Vector3>(new IntPtr(p + 0x0B8)); // 0245A6AB5D80 0xB8 CurrentCameraUp             ( 000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0245A6AB5DA0 0xC0 ScreenEffect                ( 0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.SwayBoneManager                           = GetObject<SwayBoneManager>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.SwayBoneManager.FromPointer); // 0245A6AB5DC0 0xC8 SwayBoneManager             ( 0001865FA8D0 ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer )
            value.FadeCamera                                = GetObject<Camera>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Camera.FromPointer); // 0245A6AB5DE0 0xD0 FadeCamera                  ( 0001865A2380 ModelClassType Camera Camera Camera Pointer )
            value.LiveScene                                 = GetObject<LiveScene>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.LiveScene.FromPointer); // 0245A6AB5E00 0xD8 LiveScene                   ( 000186576D00 ModelClassType LiveScene LiveScene LiveScene Pointer )
            value.TimelineDoF                               = GetObject<DepthOfField>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.DepthOfField.FromPointer); // 0245A6AB5E60 0xE0 TimelineDoF                 ( 0001866C21C0 ModelClassType DepthOfField DepthOfField DepthOfField Pointer )
            value.CameraIndex                               = GetInt32(new IntPtr(p + 0x0E8)); // 0245A6AB5E80 0xE8 CameraIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CenterTarget                              = (Vector3)GetInt32(new IntPtr(p + 0x0EC)); // 0245A6AB5EA0 0xEC CenterTarget                ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CharacterNum                              = GetInt32(new IntPtr(p + 0x0F8)); // 0245A6AB5EC0 0xF8 CharacterNum                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TargetPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x0FC)); // 0245A6AB5EE0 0xFC TargetPosition              ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TargetSpeed                               = (Vector3)GetInt32(new IntPtr(p + 0x108)); // 0245A6AB5F00 0x108 TargetSpeed                 ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TargetOffset                              = (Vector3)GetInt32(new IntPtr(p + 0x114)); // 0245A6AB5F20 0x114 TargetOffset                ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraLastPosition                        = (Vector3)GetInt32(new IntPtr(p + 0x120)); // 0245A6AB5F40 0x120 CameraLastPosition          ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x12C)); // 0245A6AB5F60 0x12C CameraPosition              ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraOffset                              = (Vector3)GetInt32(new IntPtr(p + 0x138)); // 0245A6AB5F80 0x138 CameraOffset                ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraLastRotation                        = (Quaternion)GetInt32(new IntPtr(p + 0x144)); // 0245A6AB5FA0 0x144 CameraLastRotation          ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.CameraRotation                            = (Quaternion)GetInt32(new IntPtr(p + 0x154)); // 0245A6AB5FC0 0x154 CameraRotation              ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.CameraPlusRotation                        = (Quaternion)GetInt32(new IntPtr(p + 0x164)); // 0245A6AB5FE0 0x164 CameraPlusRotation          ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.CameraLastRotEuler                        = (Vector3)GetInt32(new IntPtr(p + 0x174)); // 0245A6AB6000 0x174 CameraLastRotEuler          ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraLastFramePos                        = (Vector3)GetInt32(new IntPtr(p + 0x180)); // 0245A6AB6020 0x180 CameraLastFramePos          ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraLastFrameRot                        = (Vector3)GetInt32(new IntPtr(p + 0x18C)); // 0245A6AB6040 0x18C CameraLastFrameRot          ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraLastFieldOfView                     = GetSingle(new IntPtr(p + 0x198)); // 0245A6AB6060 0x198 CameraLastFieldOfView       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraFieldOfView                         = GetSingle(new IntPtr(p + 0x19C)); // 0245A6AB6080 0x19C CameraFieldOfView           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraLastFocus                           = GetSingle(new IntPtr(p + 0x1A0)); // 0245A6AB60A0 0x1A0 CameraLastFocus             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraFocus                               = GetSingle(new IntPtr(p + 0x1A4)); // 0245A6AB60C0 0x1A4 CameraFocus                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraFocusValue                          = GetSingle(new IntPtr(p + 0x1A8)); // 0245A6AB60E0 0x1A8 CameraFocusValue            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraSpeedPos                            = (Vector3)GetInt32(new IntPtr(p + 0x1AC)); // 0245A6AB6100 0x1AC CameraSpeedPos              ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraSpeedRot                            = (Vector3)GetInt32(new IntPtr(p + 0x1B8)); // 0245A6AB6120 0x1B8 CameraSpeedRot              ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraSpeedFov                            = GetSingle(new IntPtr(p + 0x1C4)); // 0245A6AB6140 0x1C4 CameraSpeedFov              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LastFrame                                 = GetSingle(new IntPtr(p + 0x1C8)); // 0245A6AB6160 0x1C8 LastFrame                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CameraPlusZ                               = GetSingle(new IntPtr(p + 0x1CC)); // 0245A6AB6180 0x1CC CameraPlusZ                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.CameraRangeRadius                         = GetSingle(new IntPtr(p + 0x1D0)); // 0245A6AB61A0 0x1D0 CameraRangeRadius           ( 000186666050 ModelPrimitiveType float float float Single )
            value.CameraEdit                                = GetBool(new IntPtr(p + 0x1D4)); // 0245A6AB6280 0x1D4 CameraEdit                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.InterRate                                 = GetSingle(new IntPtr(p + 0x1D8)); // 0245A6AB62A0 0x1D8 InterRate                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.DefaultZ                                  = GetSingle(new IntPtr(p + 0x1DC)); // 0245A6AB62C0 0x1DC DefaultZ                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.BoneNames                                 = GetStringList(new IntPtr(p + 0x1E0)); // 0245A6AB62E0 0x1E0 BoneNames                   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ShootingTypeTable                         = GetObjectList<ShootingTypeTable>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.ShootingTypeTable.FromPointer); // 0245A6AB6300 0x1E8 ShootingTypeTable           ( 000185CB7068 ModelClassListType ShootingTypeTable[] ShootingTypeTable[] List<ShootingTypeTable> Pointer )
            value.Characters                                = GetObjectList<Character>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.Character.FromPointer); // 0245A6AB6320 0x1F0 Characters                  ( 000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer )
            value.Onoff                                     = GetBoolList(new IntPtr(p + 0x200)); // 0245A6AB6360 0x200 Onoff                       ( 000185B78DC0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.IsPresetMode                              = GetBool(new IntPtr(p + 0x208)); // 0245A6AB6380 0x208 IsPresetMode                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CameraStartPosition                       = (Vector3)GetInt32(new IntPtr(p + 0x20C)); // 0245A6AB63C0 0x20C CameraStartPosition         ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CommonCameraMoveFile                      = GetString(new IntPtr(p + 0x218)); // 0245A6AB63E0 0x218 CommonCameraMoveFile        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
