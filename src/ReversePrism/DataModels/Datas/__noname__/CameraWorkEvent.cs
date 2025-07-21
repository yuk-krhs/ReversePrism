using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Camera                                   ModelClassType GameObject GameObject GameObject Pointer
    // 028 CameraCache                              ModelClassType Camera Camera Camera Pointer
    // 030 PostProcessVolumes                       ModelClassListType PostProcessVolume[] PostProcessVolume[] List<PostProcessVolume> Pointer
    // 038 DepthOfField                             ModelClassListType DepthOfField[] DepthOfField[] List<DepthOfField> Pointer
    // 040 Objects                                  ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 048 ObjectScale                              ModelPrimitiveType float float float Single
    // 050 CamWorkData                              ModelClassListType List`1<CameraWorkData> List`1<CameraWorkData> List<CameraWorkData> Pointer
    // 058 CamMoveData                              ModelClassListType List`1<CameraMoveData> List`1<CameraMoveData> List<CameraMoveData> Pointer
    // 060 CommonCamMoveDataCount                   ModelPrimitiveType int int int Int32
    // 068 CurrentSceneName                         ModelPrimitiveType string string string String
    // 070 Timeline                                 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 078 TimeCount                                ModelPrimitiveType float float float Single
    // 080 CurrentCameraWorkData                    ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer
    // 088 NextCameraWorkData                       ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer
    // 090 LiveChara                                ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 098 FixCameraPosition                        ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 0A0 Audience                                 ModelClassType AudienceController AudienceController AudienceController Pointer
    // 0A8 Scenario                                 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 0B0 CutScene                                 ModelClassType CutScene CutScene CutScene Pointer
    // 0B8 CurrentCameraDir                         ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 0C0 CurrentCameraUp                          ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 0C8 SwayBoneManager                          ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer
    // 0D0 LiveScene                                ModelClassType LiveScene LiveScene LiveScene Pointer
    // 0D8 ScreenEffect                             ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 0E0 FadeCamera                               ModelClassType Camera Camera Camera Pointer
    // 000 ToIntMargin                              float IL2CPP_TYPE_R4
    // 000 ZeroFrameEpsilon                         float IL2CPP_TYPE_R4
    // 000 AllTimelineDoFs                          HashSet`1<DepthOfField> IL2CPP_TYPE_GENERICINST
    // 0E8 TimelineDoF                              ModelClassType DepthOfField DepthOfField DepthOfField Pointer
    // 0F0 CameraIndex                              ModelPrimitiveType int int int Int32
    // 0F4 CenterTarget                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 100 CharacterNum                             ModelPrimitiveType int int int Int32
    // 104 TargetPosition                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 110 TargetSpeed                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 11C TargetOffset                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 128 CameraLastPosition                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 134 CameraPosition                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 140 CameraOffset                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 14C CameraLastRotation                       ModelEnumType Quaternion Quaternion Quaternion Int32
    // 15C CameraRotation                           ModelEnumType Quaternion Quaternion Quaternion Int32
    // 16C CameraPlusRotation                       ModelEnumType Quaternion Quaternion Quaternion Int32
    // 17C CameraLastRotEuler                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 188 CameraLastFramePos                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 194 CameraLastFrameRot                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 1A0 CameraLastFieldOfView                    ModelPrimitiveType float float float Single
    // 1A4 CameraFieldOfView                        ModelPrimitiveType float float float Single
    // 1A8 CameraLastFocus                          ModelPrimitiveType float float float Single
    // 1AC CameraFocus                              ModelPrimitiveType float float float Single
    // 1B0 CameraFocusValue                         ModelPrimitiveType float float float Single
    // 1B4 CameraSpeedPos                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 1C0 CameraSpeedRot                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 1CC CameraSpeedFov                           ModelPrimitiveType float float float Single
    // 1D0 LastFrame                                ModelPrimitiveType float float float Single
    // 1D4 CameraPlusZ                              ModelPrimitiveType float float float Single
    // 1D8 CameraRangeRadius                        ModelPrimitiveType float float float Single
    // 000 maxTraceSpeed                            float IL2CPP_TYPE_R4
    // 000 minTraceSpeed                            float IL2CPP_TYPE_R4
    // 000 maxDumper                                float IL2CPP_TYPE_R4
    // 000 minDumper                                float IL2CPP_TYPE_R4
    // 000 baseAspect                               float IL2CPP_TYPE_R4
    // 000 maxOne                                   float IL2CPP_TYPE_R4
    // 1DC CameraEdit                               ModelPrimitiveType bool bool bool Bool
    // 1E0 LastFrameCount                           ModelPrimitiveType float float float Single
    // 1E4 InterRate                                ModelPrimitiveType float float float Single
    // 1E8 DefaultZ                                 ModelPrimitiveType float float float Single
    // 1F0 BoneNames                                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 000 RootBoneIndex                            int IL2CPP_TYPE_I4
    // 1F8 ShootingTypeTable                        ModelClassListType ShootingTypeTable[] ShootingTypeTable[] List<ShootingTypeTable> Pointer
    // 200 Characters                               ModelClassListType Character[] Character[] List<Character> Pointer
    // 208 boneObjects                              <Array> IL2CPP_TYPE_ARRAY
    // 210 Onoff                                    ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 218 IsPresetMode                             ModelPrimitiveType bool bool bool Bool
    // 000 CameraMoveLimitYAxis                     float IL2CPP_TYPE_R4
    // 21C CameraStartPosition                      ModelEnumType Vector3 Vector3 Vector3 Int32
    // 228 CommonCameraMoveFile                     ModelPrimitiveType string string string String
    // 230 moveIDTable                              Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    public partial class CameraWorkEvent : DataModel
    {
        public GameObject?                              Camera                                  { get; set; }
        public Camera?                                  CameraCache                             { get; set; }
        public List<PostProcessVolume>?                 PostProcessVolumes                      { get; set; }
        public List<DepthOfField>?                      DepthOfField                            { get; set; }
        public List<GameObject>?                        Objects                                 { get; set; }
        public float                                    ObjectScale                             { get; set; }
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
        public SwayBoneManager?                         SwayBoneManager                         { get; set; }
        public LiveScene?                               LiveScene                               { get; set; }
        public ScreenEffectEx?                          ScreenEffect                            { get; set; }
        public Camera?                                  FadeCamera                              { get; set; }
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
        public float                                    LastFrameCount                          { get; set; }
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

            value.Camera                                    = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 Camera                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CameraCache                               = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 0x28 CameraCache                 ( ModelClassType Camera Camera Camera Pointer )
            value.PostProcessVolumes                        = GetObjectList<PostProcessVolume>(new IntPtr(p + 0x030), ReversePrism.DataModels.PostProcessVolume.FromPointer); // 0x30 PostProcessVolumes          ( ModelClassListType PostProcessVolume[] PostProcessVolume[] List<PostProcessVolume> Pointer )
            value.DepthOfField                              = GetObjectList<DepthOfField>(new IntPtr(p + 0x038), ReversePrism.DataModels.DepthOfField.FromPointer); // 0x38 DepthOfField                ( ModelClassListType DepthOfField[] DepthOfField[] List<DepthOfField> Pointer )
            value.Objects                                   = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 Objects                     ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.ObjectScale                               = GetSingle(new IntPtr(p + 0x048)); // 0x48 ObjectScale                 ( ModelPrimitiveType float float float Single )
            value.CamWorkData                               = GetObjectList<CameraWorkData>(new IntPtr(p + 0x050), ReversePrism.DataModels.CameraWorkData.FromPointer); // 0x50 CamWorkData                 ( ModelClassListType List`1<CameraWorkData> List`1<CameraWorkData> List<CameraWorkData> Pointer )
            value.CamMoveData                               = GetObjectList<CameraMoveData>(new IntPtr(p + 0x058), ReversePrism.DataModels.CameraMoveData.FromPointer); // 0x58 CamMoveData                 ( ModelClassListType List`1<CameraMoveData> List`1<CameraMoveData> List<CameraMoveData> Pointer )
            value.CommonCamMoveDataCount                    = GetInt32(new IntPtr(p + 0x060)); // 0x60 CommonCamMoveDataCount      ( ModelPrimitiveType int int int Int32 )
            value.CurrentSceneName                          = GetString(new IntPtr(p + 0x068)); // 0x68 CurrentSceneName            ( ModelPrimitiveType string string string String )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x070), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x70 Timeline                    ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.TimeCount                                 = GetSingle(new IntPtr(p + 0x078)); // 0x78 TimeCount                   ( ModelPrimitiveType float float float Single )
            value.CurrentCameraWorkData                     = GetObject<CameraWorkData>(new IntPtr(p + 0x080), ReversePrism.DataModels.CameraWorkData.FromPointer); // 0x80 CurrentCameraWorkData       ( ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer )
            value.NextCameraWorkData                        = GetObject<CameraWorkData>(new IntPtr(p + 0x088), ReversePrism.DataModels.CameraWorkData.FromPointer); // 0x88 NextCameraWorkData          ( ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer )
            value.LiveChara                                 = GetObject<LiveCharacterController>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0x90 LiveChara                   ( ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.FixCameraPosition                         = GetEnumList<Vector3>(new IntPtr(p + 0x098)); // 0x98 FixCameraPosition           ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Audience                                  = GetObject<AudienceController>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.AudienceController.FromPointer); // 0xA0 Audience                    ( ModelClassType AudienceController AudienceController AudienceController Pointer )
            value.Scenario                                  = GetObject<ScenarioManager>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0xA8 Scenario                    ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.CutScene                                  = GetObject<CutScene>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CutScene.FromPointer); // 0xB0 CutScene                    ( ModelClassType CutScene CutScene CutScene Pointer )
            value.CurrentCameraDir                          = GetEnumList<Vector3>(new IntPtr(p + 0x0B8)); // 0xB8 CurrentCameraDir            ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.CurrentCameraUp                           = GetEnumList<Vector3>(new IntPtr(p + 0x0C0)); // 0xC0 CurrentCameraUp             ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.SwayBoneManager                           = GetObject<SwayBoneManager>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.SwayBoneManager.FromPointer); // 0xC8 SwayBoneManager             ( ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer )
            value.LiveScene                                 = GetObject<LiveScene>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.LiveScene.FromPointer); // 0xD0 LiveScene                   ( ModelClassType LiveScene LiveScene LiveScene Pointer )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0xD8 ScreenEffect                ( ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.FadeCamera                                = GetObject<Camera>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Camera.FromPointer); // 0xE0 FadeCamera                  ( ModelClassType Camera Camera Camera Pointer )
            value.TimelineDoF                               = GetObject<DepthOfField>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.DepthOfField.FromPointer); // 0xE8 TimelineDoF                 ( ModelClassType DepthOfField DepthOfField DepthOfField Pointer )
            value.CameraIndex                               = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 CameraIndex                 ( ModelPrimitiveType int int int Int32 )
            value.CenterTarget                              = (Vector3)GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 CenterTarget                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CharacterNum                              = GetInt32(new IntPtr(p + 0x100)); // 0x100 CharacterNum                ( ModelPrimitiveType int int int Int32 )
            value.TargetPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x104)); // 0x104 TargetPosition              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TargetSpeed                               = (Vector3)GetInt32(new IntPtr(p + 0x110)); // 0x110 TargetSpeed                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TargetOffset                              = (Vector3)GetInt32(new IntPtr(p + 0x11C)); // 0x11C TargetOffset                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraLastPosition                        = (Vector3)GetInt32(new IntPtr(p + 0x128)); // 0x128 CameraLastPosition          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x134)); // 0x134 CameraPosition              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraOffset                              = (Vector3)GetInt32(new IntPtr(p + 0x140)); // 0x140 CameraOffset                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraLastRotation                        = (Quaternion)GetInt32(new IntPtr(p + 0x14C)); // 0x14C CameraLastRotation          ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.CameraRotation                            = (Quaternion)GetInt32(new IntPtr(p + 0x15C)); // 0x15C CameraRotation              ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.CameraPlusRotation                        = (Quaternion)GetInt32(new IntPtr(p + 0x16C)); // 0x16C CameraPlusRotation          ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.CameraLastRotEuler                        = (Vector3)GetInt32(new IntPtr(p + 0x17C)); // 0x17C CameraLastRotEuler          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraLastFramePos                        = (Vector3)GetInt32(new IntPtr(p + 0x188)); // 0x188 CameraLastFramePos          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraLastFrameRot                        = (Vector3)GetInt32(new IntPtr(p + 0x194)); // 0x194 CameraLastFrameRot          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraLastFieldOfView                     = GetSingle(new IntPtr(p + 0x1A0)); // 0x1A0 CameraLastFieldOfView       ( ModelPrimitiveType float float float Single )
            value.CameraFieldOfView                         = GetSingle(new IntPtr(p + 0x1A4)); // 0x1A4 CameraFieldOfView           ( ModelPrimitiveType float float float Single )
            value.CameraLastFocus                           = GetSingle(new IntPtr(p + 0x1A8)); // 0x1A8 CameraLastFocus             ( ModelPrimitiveType float float float Single )
            value.CameraFocus                               = GetSingle(new IntPtr(p + 0x1AC)); // 0x1AC CameraFocus                 ( ModelPrimitiveType float float float Single )
            value.CameraFocusValue                          = GetSingle(new IntPtr(p + 0x1B0)); // 0x1B0 CameraFocusValue            ( ModelPrimitiveType float float float Single )
            value.CameraSpeedPos                            = (Vector3)GetInt32(new IntPtr(p + 0x1B4)); // 0x1B4 CameraSpeedPos              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraSpeedRot                            = (Vector3)GetInt32(new IntPtr(p + 0x1C0)); // 0x1C0 CameraSpeedRot              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CameraSpeedFov                            = GetSingle(new IntPtr(p + 0x1CC)); // 0x1CC CameraSpeedFov              ( ModelPrimitiveType float float float Single )
            value.LastFrame                                 = GetSingle(new IntPtr(p + 0x1D0)); // 0x1D0 LastFrame                   ( ModelPrimitiveType float float float Single )
            value.CameraPlusZ                               = GetSingle(new IntPtr(p + 0x1D4)); // 0x1D4 CameraPlusZ                 ( ModelPrimitiveType float float float Single )
            value.CameraRangeRadius                         = GetSingle(new IntPtr(p + 0x1D8)); // 0x1D8 CameraRangeRadius           ( ModelPrimitiveType float float float Single )
            value.CameraEdit                                = GetBool(new IntPtr(p + 0x1DC)); // 0x1DC CameraEdit                  ( ModelPrimitiveType bool bool bool Bool )
            value.LastFrameCount                            = GetSingle(new IntPtr(p + 0x1E0)); // 0x1E0 LastFrameCount              ( ModelPrimitiveType float float float Single )
            value.InterRate                                 = GetSingle(new IntPtr(p + 0x1E4)); // 0x1E4 InterRate                   ( ModelPrimitiveType float float float Single )
            value.DefaultZ                                  = GetSingle(new IntPtr(p + 0x1E8)); // 0x1E8 DefaultZ                    ( ModelPrimitiveType float float float Single )
            value.BoneNames                                 = GetStringList(new IntPtr(p + 0x1F0)); // 0x1F0 BoneNames                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ShootingTypeTable                         = GetObjectList<ShootingTypeTable>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.ShootingTypeTable.FromPointer); // 0x1F8 ShootingTypeTable           ( ModelClassListType ShootingTypeTable[] ShootingTypeTable[] List<ShootingTypeTable> Pointer )
            value.Characters                                = GetObjectList<Character>(new IntPtr(p + 0x200), ReversePrism.DataModels.Character.FromPointer); // 0x200 Characters                  ( ModelClassListType Character[] Character[] List<Character> Pointer )
            value.Onoff                                     = GetBoolList(new IntPtr(p + 0x210)); // 0x210 Onoff                       ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.IsPresetMode                              = GetBool(new IntPtr(p + 0x218)); // 0x218 IsPresetMode                ( ModelPrimitiveType bool bool bool Bool )
            value.CameraStartPosition                       = (Vector3)GetInt32(new IntPtr(p + 0x21C)); // 0x21C CameraStartPosition         ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CommonCameraMoveFile                      = GetString(new IntPtr(p + 0x228)); // 0x228 CommonCameraMoveFile        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
