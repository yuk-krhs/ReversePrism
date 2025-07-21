using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 scenario                                 GameObject IL2CPP_TYPE_CLASS
    // 020 TextArea                                 ModelClassType TextArea TextArea TextArea Pointer
    // 028 BgImage                                  ModelClassType RawImage RawImage RawImage Pointer
    // 030 ScreenEffectEx                           ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 038 DefaultLight                             ModelClassType Light Light Light Pointer
    // 040 PresidentSilhouette                      ModelClassType GameObject GameObject GameObject Pointer
    // 048 ShakeCamera                              ModelClassType GameObject GameObject GameObject Pointer
    // 050 LeftFrame                                ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 RightFrame                               ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 CenterFrame                              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 068 InterpolateCurve                         ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 070 AutoTapWaitSeconds                       ModelPrimitiveType float float float Single
    // 078 Silhouette                               ModelClassType ScenarioSilhouette ScenarioSilhouette ScenarioSilhouette Pointer
    // 080 LiveCharacter                            ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 088 CamEvent                                 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 090 CharacterAct                             ModelClassType CharacterAct CharacterAct CharacterAct Pointer
    // 098 CameraController                         ModelClassType CameraController CameraController CameraController Pointer
    // 0A0 WindController                           ModelClassType WindController WindController WindController Pointer
    // 0A8 TextLog                                  ModelClassType TextLog TextLog TextLog Pointer
    // 0B0 ScenarioSound                            ModelClassType Sound Sound Sound Pointer
    // 0B8 CommandQueue                             ModelClassListType List`1<CommandQueue> List`1<CommandQueue> List<CommandQueue> Pointer
    // 008 changeUnitDatas                          ChangeUnitDatas IL2CPP_TYPE_CLASS
    // 0C0 CurrentBG                                ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 CurrentBGName                            ModelPrimitiveType string string string String
    // 0D0 IsAdv                                    ModelPrimitiveType bool bool bool Bool
    // 0D1 IsNoBGM                                  ModelPrimitiveType bool bool bool Bool
    // 0D8 TerminatedCallBack                       ModelClassType Action Action Action Pointer
    // 0E0 <ChangeTextCallBack>k__BackingField      Action`1<string> IL2CPP_TYPE_GENERICINST
    // 010 tableDictionary                          Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 000 commonPreset                             string IL2CPP_TYPE_STRING
    // 000 maxCharacter                             int IL2CPP_TYPE_I4
    // 000 maxPosition                              int IL2CPP_TYPE_I4
    // 000 CameraStopMargin                         float IL2CPP_TYPE_R4
    // 018 IsSkippingSound                          ModelPrimitiveType bool bool bool Bool
    // 019 IsPreLoaded                              ModelPrimitiveType bool bool bool Bool
    // 020 PreLoadName                              ModelPrimitiveType string string string String
    // 028 IsPause                                  ModelPrimitiveType bool bool bool Bool
    // 029 NoVoice                                  ModelPrimitiveType bool bool bool Bool
    // 0E8 ExistsNoVoiceCharacter                   ModelPrimitiveType bool bool bool Bool
    // 0E9 TextAreaOff                              ModelPrimitiveType bool bool bool Bool
    // 0F0 SequenceData                             ModelClassType Data Data Data Pointer
    // 0F8 dicSequence                              Dictionary`2<string, SequenceData> IL2CPP_TYPE_GENERICINST
    // 100 AdvInstance                              ModelClassType GameObject GameObject GameObject Pointer
    // 108 dicCommonPrefab                          Dictionary`2<string, GameObject> IL2CPP_TYPE_GENERICINST
    // 110 CommonTimelineList                       ModelClassListType List`1<PlayableDirector> List`1<PlayableDirector> List<PlayableDirector> Pointer
    // 118 MovingList                               ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 120 dicCoroutine                             Dictionary`2<string, IEnumerator> IL2CPP_TYPE_GENERICINST
    // 128 Timeline                                 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 130 DeltaTime                                ModelPrimitiveType float float float Single
    // 030 HomeCutScene                             ModelPrimitiveType string string string String
    // 038 HomeAddPrefab                            ModelPrimitiveType string string string String
    // 134 SkipFlag                                 ModelPrimitiveType bool bool bool Bool
    // 135 AutoFlag                                 ModelPrimitiveType bool bool bool Bool
    // 136 InitFlag                                 ModelPrimitiveType bool bool bool Bool
    // 137 Is2dBGSet                                ModelPrimitiveType bool bool bool Bool
    // 138 IsAdjustZOn                              ModelPrimitiveType bool bool bool Bool
    // 139 IsDirectVoice                            ModelPrimitiveType bool bool bool Bool
    // 13C DirectSpeakerIndex                       ModelPrimitiveType int int int Int32
    // 140 UpdateFuncTable                          ModelClassListType List`1<Action> List`1<Action> List<Action> Pointer
    // 148 SpeakerTable                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 150 ChoicesTable                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 158 CurrentScript                            ModelPrimitiveType int int int Int32
    // 15C CurrentScene                             ModelPrimitiveType int int int Int32
    // 160 CurrentStartFrame                        ModelPrimitiveType int int int Int32
    // 164 CurrentBgScript                          ModelPrimitiveType int int int Int32
    // 168 CurrentCharaScript                       ModelPrimitiveListType int[] int[] List<int> Pointer
    // 170 CurrentTextKey                           ModelPrimitiveType string string string String
    // 178 CurrentSpeaker                           ModelPrimitiveType int int int Int32
    // 180 Text_key                                 ModelPrimitiveType string string string String
    // 188 Voice_key                                ModelPrimitiveType string string string String
    // 190 FlagWait                                 ModelPrimitiveType bool bool bool Bool
    // 040 WaitTime                                 ModelPrimitiveType float float float Single
    // 198 SceneData                                ModelEnumListType SceneData[] SceneData[] List<SceneData> Pointer
    // 1A0 CutSceneName                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1A8 SoundCueName                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1B0 ScriptData                               ModelEnumListType ScriptData[] ScriptData[] List<ScriptData> Pointer
    // 1B8 Scr                                      ModelEnumType ScriptData ScriptData ScriptData Int32
    // 1D0 ScenarioText                             ModelClassListType ScenarioTextList[] ScenarioTextList[] List<ScenarioTextList> Pointer
    // 1D8 StartFadePatch                           ModelPrimitiveType bool bool bool Bool
    // 1E0 PositionDatas                            ModelClassType PositionDatas PositionDatas PositionDatas Pointer
    // 1E8 positionDic                              Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 1F0 CurrentPosKey                            ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1F8 CurrentPosIdTransform                    ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 200 CurrentScriptName                        ModelPrimitiveType string string string String
    // 208 ClearCharacter                           ModelPrimitiveType bool bool bool Bool
    // 20C PlayMode                                 ModelPrimitiveType int int int Int32
    // 210 LastCameraScript                         ModelPrimitiveType int int int Int32
    // 214 EditMode                                 ModelPrimitiveType bool bool bool Bool
    // 215 FfMode                                   ModelPrimitiveType bool bool bool Bool
    // 216 WaitCancel                               ModelPrimitiveType bool bool bool Bool
    // 217 NotFastForward                           ModelPrimitiveType bool bool bool Bool
    // 000 CannotCancel                             int IL2CPP_TYPE_I4
    // 000 CancelNoFF                               int IL2CPP_TYPE_I4
    // 218 TerminateFlag                            ModelPrimitiveType bool bool bool Bool
    // 220 TempLight                                ModelClassType Light Light Light Pointer
    // 228 NoChangeBG                               ModelPrimitiveType bool bool bool Bool
    // 229 NoChangeChara                            ModelPrimitiveType bool bool bool Bool
    // 230 BgRenderTexture                          ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 238 BgTexture                                ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 240 KeepMaterial                             ModelClassType Material Material Material Pointer
    // 248 RenderLoop                               ModelPrimitiveType int int int Int32
    // 24C CutSceneSetUpEnd                         ModelPrimitiveType bool bool bool Bool
    // 250 CutInstance                              ModelClassType GameObject GameObject GameObject Pointer
    // 258 CutCharacterDir                          ModelClassType Transform Transform Transform Pointer
    // 260 CutScene                                 ModelClassType CutScene CutScene CutScene Pointer
    // 268 CutCamEvent                              ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 270 OffList                                  ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    // 278 CutTimeline                              ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 280 SoundResources                           ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 288 LastPM                                   ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 2C8 PreloadingChangeUnit                     ModelPrimitiveType bool bool bool Bool
    // 000 TrueValue                                int IL2CPP_TYPE_I4
    // 2CC VoiceFrame                               ModelPrimitiveType float float float Single
    // 2D0 SequenceKey                              ModelPrimitiveType string string string String
    // 2D8 FfWait                                   ModelPrimitiveType bool bool bool Bool
    // 2E0 ScriptStack                              ModelClassType ScriptStack ScriptStack ScriptStack Pointer
    // 2E8 ConvertList                              ModelPrimitiveListType int[] int[] List<int> Pointer
    // 2F0 LastScript                               ModelPrimitiveType int int int Int32
    // 2F8 onTapScreen                              Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 300 AutoTapWaiter                            ModelClassType AutoTapWaiter AutoTapWaiter AutoTapWaiter Pointer
    // 048 PreloadUnit                              ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 050 MotionSequenceName                       ModelPrimitiveType string string string String
    // 058 DisplayScenarioID                        ModelPrimitiveType bool bool bool Bool
    public partial class ScenarioManager : DataModel
    {
        public TextArea?                                TextArea                                { get; set; }
        public RawImage?                                BgImage                                 { get; set; }
        public ScreenEffectEx?                          ScreenEffectEx                          { get; set; }
        public Light?                                   DefaultLight                            { get; set; }
        public GameObject?                              PresidentSilhouette                     { get; set; }
        public GameObject?                              ShakeCamera                             { get; set; }
        public List<GameObject>?                        LeftFrame                               { get; set; }
        public List<GameObject>?                        RightFrame                              { get; set; }
        public List<GameObject>?                        CenterFrame                             { get; set; }
        public AnimationCurve?                          InterpolateCurve                        { get; set; }
        public float                                    AutoTapWaitSeconds                      { get; set; }
        public ScenarioSilhouette?                      Silhouette                              { get; set; }
        public LiveCharacterController?                 LiveCharacter                           { get; set; }
        public CameraWorkEvent?                         CamEvent                                { get; set; }
        public CharacterAct?                            CharacterAct                            { get; set; }
        public CameraController?                        CameraController                        { get; set; }
        public WindController?                          WindController                          { get; set; }
        public TextLog?                                 TextLog                                 { get; set; }
        public Sound?                                   ScenarioSound                           { get; set; }
        public List<CommandQueue>?                      CommandQueue                            { get; set; }
        public GameObject?                              CurrentBG                               { get; set; }
        public string                                   CurrentBGName                           { get; set; }
        public bool                                     IsAdv                                   { get; set; }
        public bool                                     IsNoBGM                                 { get; set; }
        public Action?                                  TerminatedCallBack                      { get; set; }
        public bool                                     IsSkippingSound                         { get; set; }
        public bool                                     IsPreLoaded                             { get; set; }
        public string                                   PreLoadName                             { get; set; }
        public bool                                     IsPause                                 { get; set; }
        public bool                                     NoVoice                                 { get; set; }
        public bool                                     ExistsNoVoiceCharacter                  { get; set; }
        public bool                                     TextAreaOff                             { get; set; }
        public Data?                                    SequenceData                            { get; set; }
        public GameObject?                              AdvInstance                             { get; set; }
        public List<PlayableDirector>?                  CommonTimelineList                      { get; set; }
        public List<string>?                            MovingList                              { get; set; }
        public PlayableDirector?                        Timeline                                { get; set; }
        public float                                    DeltaTime                               { get; set; }
        public string                                   HomeCutScene                            { get; set; }
        public string                                   HomeAddPrefab                           { get; set; }
        public bool                                     SkipFlag                                { get; set; }
        public bool                                     AutoFlag                                { get; set; }
        public bool                                     InitFlag                                { get; set; }
        public bool                                     Is2dBGSet                               { get; set; }
        public bool                                     IsAdjustZOn                             { get; set; }
        public bool                                     IsDirectVoice                           { get; set; }
        public int                                      DirectSpeakerIndex                      { get; set; }
        public List<Action>?                            UpdateFuncTable                         { get; set; }
        public List<string>?                            SpeakerTable                            { get; set; }
        public List<string>?                            ChoicesTable                            { get; set; }
        public int                                      CurrentScript                           { get; set; }
        public int                                      CurrentScene                            { get; set; }
        public int                                      CurrentStartFrame                       { get; set; }
        public int                                      CurrentBgScript                         { get; set; }
        public List<int>?                               CurrentCharaScript                      { get; set; }
        public string                                   CurrentTextKey                          { get; set; }
        public int                                      CurrentSpeaker                          { get; set; }
        public string                                   Text_key                                { get; set; }
        public string                                   Voice_key                               { get; set; }
        public bool                                     FlagWait                                { get; set; }
        public float                                    WaitTime                                { get; set; }
        public List<SceneData>?                         SceneData                               { get; set; }
        public List<string>?                            CutSceneName                            { get; set; }
        public List<string>?                            SoundCueName                            { get; set; }
        public List<ScriptData>?                        ScriptData                              { get; set; }
        public ScriptData                               Scr                                     { get; set; }
        public List<ScenarioTextList>?                  ScenarioText                            { get; set; }
        public bool                                     StartFadePatch                          { get; set; }
        public PositionDatas?                           PositionDatas                           { get; set; }
        public List<string>?                            CurrentPosKey                           { get; set; }
        public List<Transform>?                         CurrentPosIdTransform                   { get; set; }
        public string                                   CurrentScriptName                       { get; set; }
        public bool                                     ClearCharacter                          { get; set; }
        public int                                      PlayMode                                { get; set; }
        public int                                      LastCameraScript                        { get; set; }
        public bool                                     EditMode                                { get; set; }
        public bool                                     FfMode                                  { get; set; }
        public bool                                     WaitCancel                              { get; set; }
        public bool                                     NotFastForward                          { get; set; }
        public bool                                     TerminateFlag                           { get; set; }
        public Light?                                   TempLight                               { get; set; }
        public bool                                     NoChangeBG                              { get; set; }
        public bool                                     NoChangeChara                           { get; set; }
        public RenderTexture?                           BgRenderTexture                         { get; set; }
        public RenderTexture?                           BgTexture                               { get; set; }
        public Material?                                KeepMaterial                            { get; set; }
        public int                                      RenderLoop                              { get; set; }
        public bool                                     CutSceneSetUpEnd                        { get; set; }
        public GameObject?                              CutInstance                             { get; set; }
        public Transform?                               CutCharacterDir                         { get; set; }
        public CutScene?                                CutScene                                { get; set; }
        public CameraWorkEvent?                         CutCamEvent                             { get; set; }
        public List<Transform>?                         OffList                                 { get; set; }
        public PlayableDirector?                        CutTimeline                             { get; set; }
        public MvCutSceneSoundResources?                SoundResources                          { get; set; }
        public Matrix4x4                                LastPM                                  { get; set; }
        public bool                                     PreloadingChangeUnit                    { get; set; }
        public float                                    VoiceFrame                              { get; set; }
        public string                                   SequenceKey                             { get; set; }
        public bool                                     FfWait                                  { get; set; }
        public ScriptStack?                             ScriptStack                             { get; set; }
        public List<int>?                               ConvertList                             { get; set; }
        public int                                      LastScript                              { get; set; }
        public AutoTapWaiter?                           AutoTapWaiter                           { get; set; }
        public List<UnitIdol>?                          PreloadUnit                             { get; set; }
        public string                                   MotionSequenceName                      { get; set; }
        public bool                                     DisplayScenarioID                       { get; set; }

        public static ScenarioManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScenarioManager() { Pointer= p0 };

            value.TextArea                                  = GetObject<TextArea>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextArea.FromPointer); // 0x20 TextArea                    ( ModelClassType TextArea TextArea TextArea Pointer )
            value.BgImage                                   = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 BgImage                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ScreenEffectEx                            = GetObject<ScreenEffectEx>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0x30 ScreenEffectEx              ( ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.DefaultLight                              = GetObject<Light>(new IntPtr(p + 0x038), ReversePrism.DataModels.Light.FromPointer); // 0x38 DefaultLight                ( ModelClassType Light Light Light Pointer )
            value.PresidentSilhouette                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 PresidentSilhouette         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ShakeCamera                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 ShakeCamera                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LeftFrame                                 = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 LeftFrame                   ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.RightFrame                                = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 RightFrame                  ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CenterFrame                               = GetObjectList<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 CenterFrame                 ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.InterpolateCurve                          = GetObject<AnimationCurve>(new IntPtr(p + 0x068), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x68 InterpolateCurve            ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.AutoTapWaitSeconds                        = GetSingle(new IntPtr(p + 0x070)); // 0x70 AutoTapWaitSeconds          ( ModelPrimitiveType float float float Single )
            value.Silhouette                                = GetObject<ScenarioSilhouette>(new IntPtr(p + 0x078), ReversePrism.DataModels.ScenarioSilhouette.FromPointer); // 0x78 Silhouette                  ( ModelClassType ScenarioSilhouette ScenarioSilhouette ScenarioSilhouette Pointer )
            value.LiveCharacter                             = GetObject<LiveCharacterController>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0x80 LiveCharacter               ( ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.CamEvent                                  = GetObject<CameraWorkEvent>(new IntPtr(p + 0x088), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0x88 CamEvent                    ( ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.CharacterAct                              = GetObject<CharacterAct>(new IntPtr(p + 0x090), ReversePrism.DataModels.CharacterAct.FromPointer); // 0x90 CharacterAct                ( ModelClassType CharacterAct CharacterAct CharacterAct Pointer )
            value.CameraController                          = GetObject<CameraController>(new IntPtr(p + 0x098), ReversePrism.DataModels.CameraController.FromPointer); // 0x98 CameraController            ( ModelClassType CameraController CameraController CameraController Pointer )
            value.WindController                            = GetObject<WindController>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.WindController.FromPointer); // 0xA0 WindController              ( ModelClassType WindController WindController WindController Pointer )
            value.TextLog                                   = GetObject<TextLog>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.TextLog.FromPointer); // 0xA8 TextLog                     ( ModelClassType TextLog TextLog TextLog Pointer )
            value.ScenarioSound                             = GetObject<Sound>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Sound.FromPointer); // 0xB0 ScenarioSound               ( ModelClassType Sound Sound Sound Pointer )
            value.CommandQueue                              = GetObjectList<CommandQueue>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CommandQueue.FromPointer); // 0xB8 CommandQueue                ( ModelClassListType List`1<CommandQueue> List`1<CommandQueue> List<CommandQueue> Pointer )
            value.CurrentBG                                 = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0xC0 CurrentBG                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CurrentBGName                             = GetString(new IntPtr(p + 0x0C8)); // 0xC8 CurrentBGName               ( ModelPrimitiveType string string string String )
            value.IsAdv                                     = GetBool(new IntPtr(p + 0x0D0)); // 0xD0 IsAdv                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsNoBGM                                   = GetBool(new IntPtr(p + 0x0D1)); // 0xD1 IsNoBGM                     ( ModelPrimitiveType bool bool bool Bool )
            value.TerminatedCallBack                        = GetObject<Action>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Action.FromPointer); // 0xD8 TerminatedCallBack          ( ModelClassType Action Action Action Pointer )
            value.IsSkippingSound                           = GetBool(new IntPtr(p + 0x018)); // 0x18 IsSkippingSound             ( ModelPrimitiveType bool bool bool Bool )
            value.IsPreLoaded                               = GetBool(new IntPtr(p + 0x019)); // 0x19 IsPreLoaded                 ( ModelPrimitiveType bool bool bool Bool )
            value.PreLoadName                               = GetString(new IntPtr(p + 0x020)); // 0x20 PreLoadName                 ( ModelPrimitiveType string string string String )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x028)); // 0x28 IsPause                     ( ModelPrimitiveType bool bool bool Bool )
            value.NoVoice                                   = GetBool(new IntPtr(p + 0x029)); // 0x29 NoVoice                     ( ModelPrimitiveType bool bool bool Bool )
            value.ExistsNoVoiceCharacter                    = GetBool(new IntPtr(p + 0x0E8)); // 0xE8 ExistsNoVoiceCharacter      ( ModelPrimitiveType bool bool bool Bool )
            value.TextAreaOff                               = GetBool(new IntPtr(p + 0x0E9)); // 0xE9 TextAreaOff                 ( ModelPrimitiveType bool bool bool Bool )
            value.SequenceData                              = GetObject<Data>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Data.FromPointer); // 0xF0 SequenceData                ( ModelClassType Data Data Data Pointer )
            value.AdvInstance                               = GetObject<GameObject>(new IntPtr(p + 0x100), ReversePrism.DataModels.GameObject.FromPointer); // 0x100 AdvInstance                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CommonTimelineList                        = GetObjectList<PlayableDirector>(new IntPtr(p + 0x110), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x110 CommonTimelineList          ( ModelClassListType List`1<PlayableDirector> List`1<PlayableDirector> List<PlayableDirector> Pointer )
            value.MovingList                                = GetStringList(new IntPtr(p + 0x118)); // 0x118 MovingList                  ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x128), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x128 Timeline                    ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.DeltaTime                                 = GetSingle(new IntPtr(p + 0x130)); // 0x130 DeltaTime                   ( ModelPrimitiveType float float float Single )
            value.HomeCutScene                              = GetString(new IntPtr(p + 0x030)); // 0x30 HomeCutScene                ( ModelPrimitiveType string string string String )
            value.HomeAddPrefab                             = GetString(new IntPtr(p + 0x038)); // 0x38 HomeAddPrefab               ( ModelPrimitiveType string string string String )
            value.SkipFlag                                  = GetBool(new IntPtr(p + 0x134)); // 0x134 SkipFlag                    ( ModelPrimitiveType bool bool bool Bool )
            value.AutoFlag                                  = GetBool(new IntPtr(p + 0x135)); // 0x135 AutoFlag                    ( ModelPrimitiveType bool bool bool Bool )
            value.InitFlag                                  = GetBool(new IntPtr(p + 0x136)); // 0x136 InitFlag                    ( ModelPrimitiveType bool bool bool Bool )
            value.Is2dBGSet                                 = GetBool(new IntPtr(p + 0x137)); // 0x137 Is2dBGSet                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsAdjustZOn                               = GetBool(new IntPtr(p + 0x138)); // 0x138 IsAdjustZOn                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsDirectVoice                             = GetBool(new IntPtr(p + 0x139)); // 0x139 IsDirectVoice               ( ModelPrimitiveType bool bool bool Bool )
            value.DirectSpeakerIndex                        = GetInt32(new IntPtr(p + 0x13C)); // 0x13C DirectSpeakerIndex          ( ModelPrimitiveType int int int Int32 )
            value.UpdateFuncTable                           = GetObjectList<Action>(new IntPtr(p + 0x140), ReversePrism.DataModels.Action.FromPointer); // 0x140 UpdateFuncTable             ( ModelClassListType List`1<Action> List`1<Action> List<Action> Pointer )
            value.SpeakerTable                              = GetStringList(new IntPtr(p + 0x148)); // 0x148 SpeakerTable                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ChoicesTable                              = GetStringList(new IntPtr(p + 0x150)); // 0x150 ChoicesTable                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CurrentScript                             = GetInt32(new IntPtr(p + 0x158)); // 0x158 CurrentScript               ( ModelPrimitiveType int int int Int32 )
            value.CurrentScene                              = GetInt32(new IntPtr(p + 0x15C)); // 0x15C CurrentScene                ( ModelPrimitiveType int int int Int32 )
            value.CurrentStartFrame                         = GetInt32(new IntPtr(p + 0x160)); // 0x160 CurrentStartFrame           ( ModelPrimitiveType int int int Int32 )
            value.CurrentBgScript                           = GetInt32(new IntPtr(p + 0x164)); // 0x164 CurrentBgScript             ( ModelPrimitiveType int int int Int32 )
            value.CurrentCharaScript                        = GetInt32List(new IntPtr(p + 0x168)); // 0x168 CurrentCharaScript          ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CurrentTextKey                            = GetString(new IntPtr(p + 0x170)); // 0x170 CurrentTextKey              ( ModelPrimitiveType string string string String )
            value.CurrentSpeaker                            = GetInt32(new IntPtr(p + 0x178)); // 0x178 CurrentSpeaker              ( ModelPrimitiveType int int int Int32 )
            value.Text_key                                  = GetString(new IntPtr(p + 0x180)); // 0x180 Text_key                    ( ModelPrimitiveType string string string String )
            value.Voice_key                                 = GetString(new IntPtr(p + 0x188)); // 0x188 Voice_key                   ( ModelPrimitiveType string string string String )
            value.FlagWait                                  = GetBool(new IntPtr(p + 0x190)); // 0x190 FlagWait                    ( ModelPrimitiveType bool bool bool Bool )
            value.WaitTime                                  = GetSingle(new IntPtr(p + 0x040)); // 0x40 WaitTime                    ( ModelPrimitiveType float float float Single )
            value.SceneData                                 = GetEnumList<SceneData>(new IntPtr(p + 0x198)); // 0x198 SceneData                   ( ModelEnumListType SceneData[] SceneData[] List<SceneData> Pointer )
            value.CutSceneName                              = GetStringList(new IntPtr(p + 0x1A0)); // 0x1A0 CutSceneName                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SoundCueName                              = GetStringList(new IntPtr(p + 0x1A8)); // 0x1A8 SoundCueName                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ScriptData                                = GetEnumList<ScriptData>(new IntPtr(p + 0x1B0)); // 0x1B0 ScriptData                  ( ModelEnumListType ScriptData[] ScriptData[] List<ScriptData> Pointer )
            value.Scr                                       = (ScriptData)GetInt32(new IntPtr(p + 0x1B8)); // 0x1B8 Scr                         ( ModelEnumType ScriptData ScriptData ScriptData Int32 )
            value.ScenarioText                              = GetObjectList<ScenarioTextList>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.ScenarioTextList.FromPointer); // 0x1D0 ScenarioText                ( ModelClassListType ScenarioTextList[] ScenarioTextList[] List<ScenarioTextList> Pointer )
            value.StartFadePatch                            = GetBool(new IntPtr(p + 0x1D8)); // 0x1D8 StartFadePatch              ( ModelPrimitiveType bool bool bool Bool )
            value.PositionDatas                             = GetObject<PositionDatas>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.PositionDatas.FromPointer); // 0x1E0 PositionDatas               ( ModelClassType PositionDatas PositionDatas PositionDatas Pointer )
            value.CurrentPosKey                             = GetStringList(new IntPtr(p + 0x1F0)); // 0x1F0 CurrentPosKey               ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CurrentPosIdTransform                     = GetObjectList<Transform>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.Transform.FromPointer); // 0x1F8 CurrentPosIdTransform       ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.CurrentScriptName                         = GetString(new IntPtr(p + 0x200)); // 0x200 CurrentScriptName           ( ModelPrimitiveType string string string String )
            value.ClearCharacter                            = GetBool(new IntPtr(p + 0x208)); // 0x208 ClearCharacter              ( ModelPrimitiveType bool bool bool Bool )
            value.PlayMode                                  = GetInt32(new IntPtr(p + 0x20C)); // 0x20C PlayMode                    ( ModelPrimitiveType int int int Int32 )
            value.LastCameraScript                          = GetInt32(new IntPtr(p + 0x210)); // 0x210 LastCameraScript            ( ModelPrimitiveType int int int Int32 )
            value.EditMode                                  = GetBool(new IntPtr(p + 0x214)); // 0x214 EditMode                    ( ModelPrimitiveType bool bool bool Bool )
            value.FfMode                                    = GetBool(new IntPtr(p + 0x215)); // 0x215 FfMode                      ( ModelPrimitiveType bool bool bool Bool )
            value.WaitCancel                                = GetBool(new IntPtr(p + 0x216)); // 0x216 WaitCancel                  ( ModelPrimitiveType bool bool bool Bool )
            value.NotFastForward                            = GetBool(new IntPtr(p + 0x217)); // 0x217 NotFastForward              ( ModelPrimitiveType bool bool bool Bool )
            value.TerminateFlag                             = GetBool(new IntPtr(p + 0x218)); // 0x218 TerminateFlag               ( ModelPrimitiveType bool bool bool Bool )
            value.TempLight                                 = GetObject<Light>(new IntPtr(p + 0x220), ReversePrism.DataModels.Light.FromPointer); // 0x220 TempLight                   ( ModelClassType Light Light Light Pointer )
            value.NoChangeBG                                = GetBool(new IntPtr(p + 0x228)); // 0x228 NoChangeBG                  ( ModelPrimitiveType bool bool bool Bool )
            value.NoChangeChara                             = GetBool(new IntPtr(p + 0x229)); // 0x229 NoChangeChara               ( ModelPrimitiveType bool bool bool Bool )
            value.BgRenderTexture                           = GetObject<RenderTexture>(new IntPtr(p + 0x230), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x230 BgRenderTexture             ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.BgTexture                                 = GetObject<RenderTexture>(new IntPtr(p + 0x238), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x238 BgTexture                   ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.KeepMaterial                              = GetObject<Material>(new IntPtr(p + 0x240), ReversePrism.DataModels.Material.FromPointer); // 0x240 KeepMaterial                ( ModelClassType Material Material Material Pointer )
            value.RenderLoop                                = GetInt32(new IntPtr(p + 0x248)); // 0x248 RenderLoop                  ( ModelPrimitiveType int int int Int32 )
            value.CutSceneSetUpEnd                          = GetBool(new IntPtr(p + 0x24C)); // 0x24C CutSceneSetUpEnd            ( ModelPrimitiveType bool bool bool Bool )
            value.CutInstance                               = GetObject<GameObject>(new IntPtr(p + 0x250), ReversePrism.DataModels.GameObject.FromPointer); // 0x250 CutInstance                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CutCharacterDir                           = GetObject<Transform>(new IntPtr(p + 0x258), ReversePrism.DataModels.Transform.FromPointer); // 0x258 CutCharacterDir             ( ModelClassType Transform Transform Transform Pointer )
            value.CutScene                                  = GetObject<CutScene>(new IntPtr(p + 0x260), ReversePrism.DataModels.CutScene.FromPointer); // 0x260 CutScene                    ( ModelClassType CutScene CutScene CutScene Pointer )
            value.CutCamEvent                               = GetObject<CameraWorkEvent>(new IntPtr(p + 0x268), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0x268 CutCamEvent                 ( ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.OffList                                   = GetObjectList<Transform>(new IntPtr(p + 0x270), ReversePrism.DataModels.Transform.FromPointer); // 0x270 OffList                     ( ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )
            value.CutTimeline                               = GetObject<PlayableDirector>(new IntPtr(p + 0x278), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x278 CutTimeline                 ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x280), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0x280 SoundResources              ( ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.LastPM                                    = (Matrix4x4)GetInt32(new IntPtr(p + 0x288)); // 0x288 LastPM                      ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.PreloadingChangeUnit                      = GetBool(new IntPtr(p + 0x2C8)); // 0x2C8 PreloadingChangeUnit        ( ModelPrimitiveType bool bool bool Bool )
            value.VoiceFrame                                = GetSingle(new IntPtr(p + 0x2CC)); // 0x2CC VoiceFrame                  ( ModelPrimitiveType float float float Single )
            value.SequenceKey                               = GetString(new IntPtr(p + 0x2D0)); // 0x2D0 SequenceKey                 ( ModelPrimitiveType string string string String )
            value.FfWait                                    = GetBool(new IntPtr(p + 0x2D8)); // 0x2D8 FfWait                      ( ModelPrimitiveType bool bool bool Bool )
            value.ScriptStack                               = GetObject<ScriptStack>(new IntPtr(p + 0x2E0), ReversePrism.DataModels.ScriptStack.FromPointer); // 0x2E0 ScriptStack                 ( ModelClassType ScriptStack ScriptStack ScriptStack Pointer )
            value.ConvertList                               = GetInt32List(new IntPtr(p + 0x2E8)); // 0x2E8 ConvertList                 ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.LastScript                                = GetInt32(new IntPtr(p + 0x2F0)); // 0x2F0 LastScript                  ( ModelPrimitiveType int int int Int32 )
            value.AutoTapWaiter                             = GetObject<AutoTapWaiter>(new IntPtr(p + 0x300), ReversePrism.DataModels.AutoTapWaiter.FromPointer); // 0x300 AutoTapWaiter               ( ModelClassType AutoTapWaiter AutoTapWaiter AutoTapWaiter Pointer )
            value.PreloadUnit                               = GetObjectList<UnitIdol>(new IntPtr(p + 0x048), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x48 PreloadUnit                 ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.MotionSequenceName                        = GetString(new IntPtr(p + 0x050)); // 0x50 MotionSequenceName          ( ModelPrimitiveType string string string String )
            value.DisplayScenarioID                         = GetBool(new IntPtr(p + 0x058)); // 0x58 DisplayScenarioID           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
