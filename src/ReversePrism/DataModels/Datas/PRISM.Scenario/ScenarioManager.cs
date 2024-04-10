using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 scenario                                 GameObject IL2CPP_TYPE_CLASS
    // 020 TextArea                                 000186634320 ModelClassType TextArea TextArea TextArea Pointer
    // 028 BgImage                                  000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 ScreenEffectEx                           0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 038 DefaultLight                             0001865243D0 ModelClassType Light Light Light Pointer
    // 040 PresidentSilhouette                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ShakeCamera                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 LeftFrame                                000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 RightFrame                               000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 CenterFrame                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 068 InterpolateCurve                         000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 070 AutoTapWaitSeconds                       0001866656B0 ModelPrimitiveType float float float Single
    // 078 Silhouette                               0001866CAE50 ModelClassType ScenarioSilhouette ScenarioSilhouette ScenarioSilhouette Pointer
    // 080 LiveCharacter                            000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 088 CamEvent                                 0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 090 CharacterAct                             0001865979A0 ModelClassType CharacterAct CharacterAct CharacterAct Pointer
    // 098 CameraController                         000186536460 ModelClassType CameraController CameraController CameraController Pointer
    // 0A0 WindController                           00018655BD90 ModelClassType WindController WindController WindController Pointer
    // 0A8 TextLog                                  00018663FF90 ModelClassType TextLog TextLog TextLog Pointer
    // 0B0 ScenarioSound                            0001865352B0 ModelClassType Sound Sound Sound Pointer
    // 0B8 CommandQueue                             000185D2B108 ModelClassListType List`1<CommandQueue> List`1<CommandQueue> List<CommandQueue> Pointer
    // 0C0 CurrentBG                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 CurrentBGName                            000186671910 ModelPrimitiveType string string string String
    // 0D0 IsAdv                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D1 IsNoBGM                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D8 TerminatedCallBack                       0001866792B0 ModelClassType Action Action Action Pointer
    // 0E0 <ChangeTextCallBack>k__BackingField      Action`1<string> IL2CPP_TYPE_GENERICINST
    // 008 tableDictionary                          Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 000 commonPreset                             string IL2CPP_TYPE_STRING
    // 000 maxCharacter                             int IL2CPP_TYPE_I4
    // 000 maxPosition                              int IL2CPP_TYPE_I4
    // 000 CameraStopMargin                         float IL2CPP_TYPE_R4
    // 010 IsSkippingSound                          000186596380 ModelPrimitiveType bool bool bool Bool
    // 011 IsPreLoaded                              000186595C30 ModelPrimitiveType bool bool bool Bool
    // 018 PreLoadName                              000186672530 ModelPrimitiveType string string string String
    // 020 IsPause                                  000186596380 ModelPrimitiveType bool bool bool Bool
    // 021 NoVoice                                  000186596380 ModelPrimitiveType bool bool bool Bool
    // 0E8 TextAreaOff                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 0F0 SequenceData                             000186744890 ModelClassType Data Data Data Pointer
    // 0F8 dicSequence                              Dictionary`2<string, SequenceData> IL2CPP_TYPE_GENERICINST
    // 100 AdvInstance                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 108 dicCommonPrefab                          Dictionary`2<string, GameObject> IL2CPP_TYPE_GENERICINST
    // 110 CommonTimelineList                       000185CF9B98 ModelClassListType List`1<PlayableDirector> List`1<PlayableDirector> List<PlayableDirector> Pointer
    // 118 MovingList                               000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 120 dicCoroutine                             Dictionary`2<string, IEnumerator> IL2CPP_TYPE_GENERICINST
    // 128 Timeline                                 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 130 DeltaTime                                0001866656B0 ModelPrimitiveType float float float Single
    // 028 HomeCutScene                             000186672530 ModelPrimitiveType string string string String
    // 030 HomeAddPrefab                            000186672530 ModelPrimitiveType string string string String
    // 134 SkipFlag                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 135 AutoFlag                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 136 InitFlag                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 137 Is2dBGSet                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 138 IsAdjustZOn                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 139 IsDirectVoice                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 13C DirectSpeakerIndex                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 140 UpdateFuncTable                          000185CCB2E8 ModelClassListType List`1<Action> List`1<Action> List<Action> Pointer
    // 148 SpeakerTable                             000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 150 ChoicesTable                             000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 158 CurrentScript                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 15C CurrentScene                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 160 CurrentStartFrame                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 164 CurrentBgScript                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 168 CurrentCharaScript                       000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 170 CurrentTextKey                           000186671910 ModelPrimitiveType string string string String
    // 178 CurrentSpeaker                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 180 Text_key                                 000186671910 ModelPrimitiveType string string string String
    // 188 Voice_key                                000186671910 ModelPrimitiveType string string string String
    // 190 FlagWait                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 WaitTime                                 000186666300 ModelPrimitiveType float float float Single
    // 198 SceneData                                000185CC2218 ModelEnumListType SceneData[] SceneData[] List<SceneData> Pointer
    // 1A0 CutSceneName                             000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1A8 SoundCueName                             000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1B0 ScriptData                               000185CC2448 ModelEnumListType ScriptData[] ScriptData[] List<ScriptData> Pointer
    // 1B8 Scr                                      00018670F720 ModelEnumType ScriptData ScriptData ScriptData Int32
    // 1D0 ScenarioText                             000185CC1D18 ModelClassListType ScenarioTextList[] ScenarioTextList[] List<ScenarioTextList> Pointer
    // 1D8 StartFadePatch                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1E0 PositionDatas                            00018670DEA0 ModelClassType PositionDatas PositionDatas PositionDatas Pointer
    // 1E8 positionDic                              Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 1F0 CurrentPosKey                            000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1F8 CurrentPosIdTransform                    000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 200 CurrentScriptName                        000186671910 ModelPrimitiveType string string string String
    // 208 ClearCharacter                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 20C PlayMode                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 210 LastCameraScript                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 214 EditMode                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 215 FfMode                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 216 WaitCancel                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 217 NotFastForward                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 CannotCancel                             int IL2CPP_TYPE_I4
    // 000 CancelNoFF                               int IL2CPP_TYPE_I4
    // 218 TerminateFlag                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 220 TempLight                                0001865243D0 ModelClassType Light Light Light Pointer
    // 228 NoChangeBG                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 229 NoChangeChara                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 230 BgRenderTexture                          000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 238 BgTexture                                000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 240 KeepMaterial                             00018660BDD0 ModelClassType Material Material Material Pointer
    // 248 RenderLoop                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 24C CutSceneSetUpEnd                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 250 CutInstance                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 258 CutCharacterDir                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 260 CutScene                                 00018666E600 ModelClassType CutScene CutScene CutScene Pointer
    // 268 CutCamEvent                              0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 270 OffList                                  000185D16058 ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    // 278 CutTimeline                              00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 280 SoundResources                           000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 288 LastPM                                   00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 2C8 VoiceFrame                               0001866656B0 ModelPrimitiveType float float float Single
    // 2D0 SequenceKey                              000186671910 ModelPrimitiveType string string string String
    // 2D8 FfWait                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2E0 ScriptStack                              00018670E4D0 ModelClassType ScriptStack ScriptStack ScriptStack Pointer
    // 2E8 ConvertList                              000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 2F0 LastScript                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 2F8 onTapScreen                              Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 300 AutoTapWaiter                            00018670CE70 ModelClassType AutoTapWaiter AutoTapWaiter AutoTapWaiter Pointer
    // 040 PreloadUnit                              000185CAF388 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 048 DisplayScenarioID                        000186596380 ModelPrimitiveType bool bool bool Bool
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
        public float                                    VoiceFrame                              { get; set; }
        public string                                   SequenceKey                             { get; set; }
        public bool                                     FfWait                                  { get; set; }
        public ScriptStack?                             ScriptStack                             { get; set; }
        public List<int>?                               ConvertList                             { get; set; }
        public int                                      LastScript                              { get; set; }
        public AutoTapWaiter?                           AutoTapWaiter                           { get; set; }
        public List<UnitIdol>?                          PreloadUnit                             { get; set; }
        public bool                                     DisplayScenarioID                       { get; set; }

        public static ScenarioManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScenarioManager() { Pointer= p0 };

            value.TextArea                                  = GetObject<TextArea>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextArea.FromPointer); // 0245A5F927F0 0x20 TextArea                    ( 000186634320 ModelClassType TextArea TextArea TextArea Pointer )
            value.BgImage                                   = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0245A5F92810 0x28 BgImage                     ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ScreenEffectEx                            = GetObject<ScreenEffectEx>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0245A5F92830 0x30 ScreenEffectEx              ( 0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.DefaultLight                              = GetObject<Light>(new IntPtr(p + 0x038), ReversePrism.DataModels.Light.FromPointer); // 0245A5F92850 0x38 DefaultLight                ( 0001865243D0 ModelClassType Light Light Light Pointer )
            value.PresidentSilhouette                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5F92870 0x40 PresidentSilhouette         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ShakeCamera                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5F92890 0x48 ShakeCamera                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LeftFrame                                 = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5F928B0 0x50 LeftFrame                   ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.RightFrame                                = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5F928D0 0x58 RightFrame                  ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CenterFrame                               = GetObjectList<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5F928F0 0x60 CenterFrame                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.InterpolateCurve                          = GetObject<AnimationCurve>(new IntPtr(p + 0x068), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A5F92910 0x68 InterpolateCurve            ( 000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.AutoTapWaitSeconds                        = GetSingle(new IntPtr(p + 0x070)); // 0245A5F92930 0x70 AutoTapWaitSeconds          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Silhouette                                = GetObject<ScenarioSilhouette>(new IntPtr(p + 0x078), ReversePrism.DataModels.ScenarioSilhouette.FromPointer); // 0245A5F92950 0x78 Silhouette                  ( 0001866CAE50 ModelClassType ScenarioSilhouette ScenarioSilhouette ScenarioSilhouette Pointer )
            value.LiveCharacter                             = GetObject<LiveCharacterController>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0245A5F92970 0x80 LiveCharacter               ( 000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.CamEvent                                  = GetObject<CameraWorkEvent>(new IntPtr(p + 0x088), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0245A5F92990 0x88 CamEvent                    ( 0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.CharacterAct                              = GetObject<CharacterAct>(new IntPtr(p + 0x090), ReversePrism.DataModels.CharacterAct.FromPointer); // 0245A5F929B0 0x90 CharacterAct                ( 0001865979A0 ModelClassType CharacterAct CharacterAct CharacterAct Pointer )
            value.CameraController                          = GetObject<CameraController>(new IntPtr(p + 0x098), ReversePrism.DataModels.CameraController.FromPointer); // 0245A5F929D0 0x98 CameraController            ( 000186536460 ModelClassType CameraController CameraController CameraController Pointer )
            value.WindController                            = GetObject<WindController>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.WindController.FromPointer); // 0245A5F929F0 0xA0 WindController              ( 00018655BD90 ModelClassType WindController WindController WindController Pointer )
            value.TextLog                                   = GetObject<TextLog>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.TextLog.FromPointer); // 0245A5F92A10 0xA8 TextLog                     ( 00018663FF90 ModelClassType TextLog TextLog TextLog Pointer )
            value.ScenarioSound                             = GetObject<Sound>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Sound.FromPointer); // 0245A5F92A30 0xB0 ScenarioSound               ( 0001865352B0 ModelClassType Sound Sound Sound Pointer )
            value.CommandQueue                              = GetObjectList<CommandQueue>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CommandQueue.FromPointer); // 0245A5F92A50 0xB8 CommandQueue                ( 000185D2B108 ModelClassListType List`1<CommandQueue> List`1<CommandQueue> List<CommandQueue> Pointer )
            value.CurrentBG                                 = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5F92A70 0xC0 CurrentBG                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CurrentBGName                             = GetString(new IntPtr(p + 0x0C8)); // 0245A5F92A90 0xC8 CurrentBGName               ( 000186671910 ModelPrimitiveType string string string String )
            value.IsAdv                                     = GetBool(new IntPtr(p + 0x0D0)); // 0245A5F92AB0 0xD0 IsAdv                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNoBGM                                   = GetBool(new IntPtr(p + 0x0D1)); // 0245A5F92AD0 0xD1 IsNoBGM                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TerminatedCallBack                        = GetObject<Action>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Action.FromPointer); // 0245A5F92AF0 0xD8 TerminatedCallBack          ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.IsSkippingSound                           = GetBool(new IntPtr(p + 0x010)); // 0245A5F92BD0 0x10 IsSkippingSound             ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.IsPreLoaded                               = GetBool(new IntPtr(p + 0x011)); // 0245A5F92BF0 0x11 IsPreLoaded                 ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.PreLoadName                               = GetString(new IntPtr(p + 0x018)); // 0245A5F92C10 0x18 PreLoadName                 ( 000186672530 ModelPrimitiveType string string string String )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x020)); // 0245A5F92C30 0x20 IsPause                     ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.NoVoice                                   = GetBool(new IntPtr(p + 0x021)); // 0245A5F92C50 0x21 NoVoice                     ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.TextAreaOff                               = GetBool(new IntPtr(p + 0x0E8)); // 0245A5F92C70 0xE8 TextAreaOff                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SequenceData                              = GetObject<Data>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Data.FromPointer); // 0245A5F92C90 0xF0 SequenceData                ( 000186744890 ModelClassType Data Data Data Pointer )
            value.AdvInstance                               = GetObject<GameObject>(new IntPtr(p + 0x100), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5F92CD0 0x100 AdvInstance                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CommonTimelineList                        = GetObjectList<PlayableDirector>(new IntPtr(p + 0x110), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0245A5F92D10 0x110 CommonTimelineList          ( 000185CF9B98 ModelClassListType List`1<PlayableDirector> List`1<PlayableDirector> List<PlayableDirector> Pointer )
            value.MovingList                                = GetStringList(new IntPtr(p + 0x118)); // 0245A5F92D30 0x118 MovingList                  ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x128), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0245A5F92D70 0x128 Timeline                    ( 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.DeltaTime                                 = GetSingle(new IntPtr(p + 0x130)); // 0245A5F92D90 0x130 DeltaTime                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.HomeCutScene                              = GetString(new IntPtr(p + 0x028)); // 0245A5F92DB0 0x28 HomeCutScene                ( 000186672530 ModelPrimitiveType string string string String )
            value.HomeAddPrefab                             = GetString(new IntPtr(p + 0x030)); // 0245A5F92DD0 0x30 HomeAddPrefab               ( 000186672530 ModelPrimitiveType string string string String )
            value.SkipFlag                                  = GetBool(new IntPtr(p + 0x134)); // 0245A5F92DF0 0x134 SkipFlag                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AutoFlag                                  = GetBool(new IntPtr(p + 0x135)); // 0245A5F92E10 0x135 AutoFlag                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InitFlag                                  = GetBool(new IntPtr(p + 0x136)); // 0245A5F92E30 0x136 InitFlag                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Is2dBGSet                                 = GetBool(new IntPtr(p + 0x137)); // 0245A5F92E50 0x137 Is2dBGSet                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAdjustZOn                               = GetBool(new IntPtr(p + 0x138)); // 0245A5F92E70 0x138 IsAdjustZOn                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDirectVoice                             = GetBool(new IntPtr(p + 0x139)); // 0245A5F92E90 0x139 IsDirectVoice               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DirectSpeakerIndex                        = GetInt32(new IntPtr(p + 0x13C)); // 0245A5F92EB0 0x13C DirectSpeakerIndex          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UpdateFuncTable                           = GetObjectList<Action>(new IntPtr(p + 0x140), ReversePrism.DataModels.Action.FromPointer); // 0245A5F92ED0 0x140 UpdateFuncTable             ( 000185CCB2E8 ModelClassListType List`1<Action> List`1<Action> List<Action> Pointer )
            value.SpeakerTable                              = GetStringList(new IntPtr(p + 0x148)); // 0245A5F92EF0 0x148 SpeakerTable                ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ChoicesTable                              = GetStringList(new IntPtr(p + 0x150)); // 0245A5F92F10 0x150 ChoicesTable                ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CurrentScript                             = GetInt32(new IntPtr(p + 0x158)); // 0245A5F92F30 0x158 CurrentScript               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentScene                              = GetInt32(new IntPtr(p + 0x15C)); // 0245A5F92F50 0x15C CurrentScene                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentStartFrame                         = GetInt32(new IntPtr(p + 0x160)); // 0245A5F92F70 0x160 CurrentStartFrame           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentBgScript                           = GetInt32(new IntPtr(p + 0x164)); // 0245A5F92F90 0x164 CurrentBgScript             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentCharaScript                        = GetInt32List(new IntPtr(p + 0x168)); // 0245A5F92FB0 0x168 CurrentCharaScript          ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CurrentTextKey                            = GetString(new IntPtr(p + 0x170)); // 0245A5F92FD0 0x170 CurrentTextKey              ( 000186671910 ModelPrimitiveType string string string String )
            value.CurrentSpeaker                            = GetInt32(new IntPtr(p + 0x178)); // 0245A5F92FF0 0x178 CurrentSpeaker              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Text_key                                  = GetString(new IntPtr(p + 0x180)); // 0245A5F93010 0x180 Text_key                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Voice_key                                 = GetString(new IntPtr(p + 0x188)); // 0245A5F93030 0x188 Voice_key                   ( 000186671910 ModelPrimitiveType string string string String )
            value.FlagWait                                  = GetBool(new IntPtr(p + 0x190)); // 0245A5F93050 0x190 FlagWait                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WaitTime                                  = GetSingle(new IntPtr(p + 0x038)); // 0245A5F93070 0x38 WaitTime                    ( 000186666300 ModelPrimitiveType float float float Single )
            value.SceneData                                 = GetEnumList<SceneData>(new IntPtr(p + 0x198)); // 0245A5F93090 0x198 SceneData                   ( 000185CC2218 ModelEnumListType SceneData[] SceneData[] List<SceneData> Pointer )
            value.CutSceneName                              = GetStringList(new IntPtr(p + 0x1A0)); // 0245A5F930B0 0x1A0 CutSceneName                ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SoundCueName                              = GetStringList(new IntPtr(p + 0x1A8)); // 0245A5F930D0 0x1A8 SoundCueName                ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ScriptData                                = GetEnumList<ScriptData>(new IntPtr(p + 0x1B0)); // 0245A5F930F0 0x1B0 ScriptData                  ( 000185CC2448 ModelEnumListType ScriptData[] ScriptData[] List<ScriptData> Pointer )
            value.Scr                                       = (ScriptData)GetInt32(new IntPtr(p + 0x1B8)); // 0245A5F93110 0x1B8 Scr                         ( 00018670F720 ModelEnumType ScriptData ScriptData ScriptData Int32 )
            value.ScenarioText                              = GetObjectList<ScenarioTextList>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.ScenarioTextList.FromPointer); // 0245A5F93130 0x1D0 ScenarioText                ( 000185CC1D18 ModelClassListType ScenarioTextList[] ScenarioTextList[] List<ScenarioTextList> Pointer )
            value.StartFadePatch                            = GetBool(new IntPtr(p + 0x1D8)); // 0245A5F93150 0x1D8 StartFadePatch              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PositionDatas                             = GetObject<PositionDatas>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.PositionDatas.FromPointer); // 0245A5F93170 0x1E0 PositionDatas               ( 00018670DEA0 ModelClassType PositionDatas PositionDatas PositionDatas Pointer )
            value.CurrentPosKey                             = GetStringList(new IntPtr(p + 0x1F0)); // 0245A5F931B0 0x1F0 CurrentPosKey               ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CurrentPosIdTransform                     = GetObjectList<Transform>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.Transform.FromPointer); // 0245A5F931D0 0x1F8 CurrentPosIdTransform       ( 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.CurrentScriptName                         = GetString(new IntPtr(p + 0x200)); // 0245A5F931F0 0x200 CurrentScriptName           ( 000186671910 ModelPrimitiveType string string string String )
            value.ClearCharacter                            = GetBool(new IntPtr(p + 0x208)); // 0245A5F93210 0x208 ClearCharacter              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PlayMode                                  = GetInt32(new IntPtr(p + 0x20C)); // 0245A5F93230 0x20C PlayMode                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastCameraScript                          = GetInt32(new IntPtr(p + 0x210)); // 0245A5F93250 0x210 LastCameraScript            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EditMode                                  = GetBool(new IntPtr(p + 0x214)); // 0245A5F93270 0x214 EditMode                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FfMode                                    = GetBool(new IntPtr(p + 0x215)); // 0245A5F93290 0x215 FfMode                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.WaitCancel                                = GetBool(new IntPtr(p + 0x216)); // 0245A5F932B0 0x216 WaitCancel                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NotFastForward                            = GetBool(new IntPtr(p + 0x217)); // 0245A5F932D0 0x217 NotFastForward              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TerminateFlag                             = GetBool(new IntPtr(p + 0x218)); // 0245A5F93330 0x218 TerminateFlag               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TempLight                                 = GetObject<Light>(new IntPtr(p + 0x220), ReversePrism.DataModels.Light.FromPointer); // 0245A5F93350 0x220 TempLight                   ( 0001865243D0 ModelClassType Light Light Light Pointer )
            value.NoChangeBG                                = GetBool(new IntPtr(p + 0x228)); // 0245A5F93370 0x228 NoChangeBG                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NoChangeChara                             = GetBool(new IntPtr(p + 0x229)); // 0245A5F93390 0x229 NoChangeChara               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BgRenderTexture                           = GetObject<RenderTexture>(new IntPtr(p + 0x230), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A5F933B0 0x230 BgRenderTexture             ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.BgTexture                                 = GetObject<RenderTexture>(new IntPtr(p + 0x238), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A5F933D0 0x238 BgTexture                   ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.KeepMaterial                              = GetObject<Material>(new IntPtr(p + 0x240), ReversePrism.DataModels.Material.FromPointer); // 0245A5F933F0 0x240 KeepMaterial                ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.RenderLoop                                = GetInt32(new IntPtr(p + 0x248)); // 0245A5F93410 0x248 RenderLoop                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CutSceneSetUpEnd                          = GetBool(new IntPtr(p + 0x24C)); // 0245A5F93430 0x24C CutSceneSetUpEnd            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CutInstance                               = GetObject<GameObject>(new IntPtr(p + 0x250), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5F93450 0x250 CutInstance                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CutCharacterDir                           = GetObject<Transform>(new IntPtr(p + 0x258), ReversePrism.DataModels.Transform.FromPointer); // 0245A5F93470 0x258 CutCharacterDir             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.CutScene                                  = GetObject<CutScene>(new IntPtr(p + 0x260), ReversePrism.DataModels.CutScene.FromPointer); // 0245A5F93490 0x260 CutScene                    ( 00018666E600 ModelClassType CutScene CutScene CutScene Pointer )
            value.CutCamEvent                               = GetObject<CameraWorkEvent>(new IntPtr(p + 0x268), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0245A5F934B0 0x268 CutCamEvent                 ( 0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.OffList                                   = GetObjectList<Transform>(new IntPtr(p + 0x270), ReversePrism.DataModels.Transform.FromPointer); // 0245A5F934D0 0x270 OffList                     ( 000185D16058 ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )
            value.CutTimeline                               = GetObject<PlayableDirector>(new IntPtr(p + 0x278), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0245A5F934F0 0x278 CutTimeline                 ( 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x280), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0245A5F93510 0x280 SoundResources              ( 000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.LastPM                                    = (Matrix4x4)GetInt32(new IntPtr(p + 0x288)); // 0245A5F93530 0x288 LastPM                      ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.VoiceFrame                                = GetSingle(new IntPtr(p + 0x2C8)); // 0245A5F93550 0x2C8 VoiceFrame                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SequenceKey                               = GetString(new IntPtr(p + 0x2D0)); // 0245A5F93570 0x2D0 SequenceKey                 ( 000186671910 ModelPrimitiveType string string string String )
            value.FfWait                                    = GetBool(new IntPtr(p + 0x2D8)); // 0245A5F93590 0x2D8 FfWait                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScriptStack                               = GetObject<ScriptStack>(new IntPtr(p + 0x2E0), ReversePrism.DataModels.ScriptStack.FromPointer); // 0245A5F935B0 0x2E0 ScriptStack                 ( 00018670E4D0 ModelClassType ScriptStack ScriptStack ScriptStack Pointer )
            value.ConvertList                               = GetInt32List(new IntPtr(p + 0x2E8)); // 0245A5F935D0 0x2E8 ConvertList                 ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.LastScript                                = GetInt32(new IntPtr(p + 0x2F0)); // 0245A5F935F0 0x2F0 LastScript                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AutoTapWaiter                             = GetObject<AutoTapWaiter>(new IntPtr(p + 0x300), ReversePrism.DataModels.AutoTapWaiter.FromPointer); // 0245A5F93630 0x300 AutoTapWaiter               ( 00018670CE70 ModelClassType AutoTapWaiter AutoTapWaiter AutoTapWaiter Pointer )
            value.PreloadUnit                               = GetObjectList<UnitIdol>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitIdol.FromPointer); // 0245A5F93650 0x40 PreloadUnit                 ( 000185CAF388 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.DisplayScenarioID                         = GetBool(new IntPtr(p + 0x048)); // 0245A5F93670 0x48 DisplayScenarioID           ( 000186596380 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
