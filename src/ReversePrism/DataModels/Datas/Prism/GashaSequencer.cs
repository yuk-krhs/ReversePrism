using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaScharaEffectsDirection              ModelClassType GashaScharaEffectsDirection GashaScharaEffectsDirection GashaScharaEffectsDirection Pointer
    // 028 GashaNamePlateP                          ModelClassType GashaNamePlateP GashaNamePlateP GashaNamePlateP Pointer
    // 030 GashaNamePlateS                          ModelClassType GashaNamePlateS GashaNamePlateS GashaNamePlateS Pointer
    // 038 Handup                                   ModelClassType GameObject GameObject GameObject Pointer
    // 040 GashaHandup                              ModelClassType GashaHandup GashaHandup GashaHandup Pointer
    // 048 ScharaEffect                             ModelClassType GameObject GameObject GameObject Pointer
    // 050 Phase1Area                               ModelClassType GameObject GameObject GameObject Pointer
    // 058 Phase2Area                               ModelClassType GameObject GameObject GameObject Pointer
    // 060 Phase3_S3Area                            ModelClassType GameObject GameObject GameObject Pointer
    // 068 Phase3_S9Area                            ModelClassType GameObject GameObject GameObject Pointer
    // 070 PGashaEffectArea                         ModelClassType Transform Transform Transform Pointer
    // 078 Btnskip                                  ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 080 BtnTouch                                 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 088 FadeDuration                             ModelPrimitiveType float float float Single
    // 000 conditionList                            Condition[] IL2CPP_TYPE_SZARRAY
    // 008 originalConditionList                    Dictionary`2<string, Condition[]> IL2CPP_TYPE_GENERICINST
    // 010 ListGashaScene                           ModelClassListType List`1<GashaSceneData> List`1<GashaSceneData> List<GashaSceneData> Pointer
    // 018 IsPreLoaded                              ModelPrimitiveType bool bool bool Bool
    // 000 baseCutSceneMargin                       int IL2CPP_TYPE_I4
    // 090 SkipToGameObjectName                     ModelPrimitiveType string string string String
    // 098 SkipToLoopStart                          ModelPrimitiveType bool bool bool Bool
    // 0A0 OnTapCallBack                            ModelClassType Action Action Action Pointer
    // 0A8 IsPlayFirstTime                          ModelPrimitiveType bool bool bool Bool
    // 0B0 BaseGashaInstance                        ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 BasePostProcess                          ModelClassType PostProcessVolume PostProcessVolume PostProcessVolume Pointer
    // 0C0 CharacterParents                         ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 characterTables                          Character[][] IL2CPP_TYPE_SZARRAY
    // 0D0 BaseScene                                ModelClassType CutScene CutScene CutScene Pointer
    // 0D8 BaseCameraObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 0E0 MainCamera                               ModelClassType GameObject GameObject GameObject Pointer
    // 0E8 EffectPlayer                             ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer
    // 0F0 CamEventBase                             ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 0F8 TimelineController                       ModelClassType TimelineController TimelineController TimelineController Pointer
    // 100 ScreenEffect                             ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 108 IsInitializeEnd                          ModelPrimitiveType bool bool bool Bool
    // 109 IsSequenceEnd                            ModelPrimitiveType bool bool bool Bool
    // 10A IsPause                                  ModelPrimitiveType bool bool bool Bool
    // 10B IsMovieStop                              ModelPrimitiveType bool bool bool Bool
    // 110 OnSequenceEnd                            ModelClassType Action Action Action Pointer
    // 118 SequenceFrame                            ModelPrimitiveType float float float Single
    // 11C CurrentSceneIndex                        ModelPrimitiveType int int int Int32
    // 120 SceneIndexOld                            ModelPrimitiveType int int int Int32
    // 124 CurrentStartFrame                        ModelPrimitiveType float float float Single
    // 128 LoopNextFlag                             ModelPrimitiveType bool bool bool Bool
    // 130 CutInstanceGameObjects                   ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 138 CamEvents                                ModelClassListType CameraWorkEvent[] CameraWorkEvent[] List<CameraWorkEvent> Pointer
    // 140 SceneTypes                               ModelEnumListType SceneType[] SceneType[] List<SceneType> Pointer
    // 148 CutScenes                                ModelClassListType CutScene[] CutScene[] List<CutScene> Pointer
    // 150 CutCharacterDirs                         ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 158 SoundResources                           ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 01C PlayGashaSequenceNo                      ModelEnumType Sequence Sequence Sequence Int32
    public partial class GashaSequencer : DataModel
    {
        public GashaScharaEffectsDirection?             GashaScharaEffectsDirection             { get; set; }
        public GashaNamePlateP?                         GashaNamePlateP                         { get; set; }
        public GashaNamePlateS?                         GashaNamePlateS                         { get; set; }
        public GameObject?                              Handup                                  { get; set; }
        public GashaHandup?                             GashaHandup                             { get; set; }
        public GameObject?                              ScharaEffect                            { get; set; }
        public GameObject?                              Phase1Area                              { get; set; }
        public GameObject?                              Phase2Area                              { get; set; }
        public GameObject?                              Phase3_S3Area                           { get; set; }
        public GameObject?                              Phase3_S9Area                           { get; set; }
        public Transform?                               PGashaEffectArea                        { get; set; }
        public ButtonBase?                              Btnskip                                 { get; set; }
        public ButtonBase?                              BtnTouch                                { get; set; }
        public float                                    FadeDuration                            { get; set; }
        public List<GashaSceneData>?                    ListGashaScene                          { get; set; }
        public bool                                     IsPreLoaded                             { get; set; }
        public string                                   SkipToGameObjectName                    { get; set; }
        public bool                                     SkipToLoopStart                         { get; set; }
        public Action?                                  OnTapCallBack                           { get; set; }
        public bool                                     IsPlayFirstTime                         { get; set; }
        public GameObject?                              BaseGashaInstance                       { get; set; }
        public PostProcessVolume?                       BasePostProcess                         { get; set; }
        public GameObject?                              CharacterParents                        { get; set; }
        public CutScene?                                BaseScene                               { get; set; }
        public GameObject?                              BaseCameraObject                        { get; set; }
        public GameObject?                              MainCamera                              { get; set; }
        public EffectPlayer?                            EffectPlayer                            { get; set; }
        public CameraWorkEvent?                         CamEventBase                            { get; set; }
        public TimelineController?                      TimelineController                      { get; set; }
        public ScreenEffectEx?                          ScreenEffect                            { get; set; }
        public bool                                     IsInitializeEnd                         { get; set; }
        public bool                                     IsSequenceEnd                           { get; set; }
        public bool                                     IsPause                                 { get; set; }
        public bool                                     IsMovieStop                             { get; set; }
        public Action?                                  OnSequenceEnd                           { get; set; }
        public float                                    SequenceFrame                           { get; set; }
        public int                                      CurrentSceneIndex                       { get; set; }
        public int                                      SceneIndexOld                           { get; set; }
        public float                                    CurrentStartFrame                       { get; set; }
        public bool                                     LoopNextFlag                            { get; set; }
        public List<GameObject>?                        CutInstanceGameObjects                  { get; set; }
        public List<CameraWorkEvent>?                   CamEvents                               { get; set; }
        public List<SceneType>?                         SceneTypes                              { get; set; }
        public List<CutScene>?                          CutScenes                               { get; set; }
        public List<Transform>?                         CutCharacterDirs                        { get; set; }
        public MvCutSceneSoundResources?                SoundResources                          { get; set; }
        public Sequence                                 PlayGashaSequenceNo                     { get; set; }

        public static GashaSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaSequencer() { Pointer= p0 };

            value.GashaScharaEffectsDirection               = GetObject<GashaScharaEffectsDirection>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaScharaEffectsDirection.FromPointer); // 0x20 GashaScharaEffectsDirection ( ModelClassType GashaScharaEffectsDirection GashaScharaEffectsDirection GashaScharaEffectsDirection Pointer )
            value.GashaNamePlateP                           = GetObject<GashaNamePlateP>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaNamePlateP.FromPointer); // 0x28 GashaNamePlateP             ( ModelClassType GashaNamePlateP GashaNamePlateP GashaNamePlateP Pointer )
            value.GashaNamePlateS                           = GetObject<GashaNamePlateS>(new IntPtr(p + 0x030), ReversePrism.DataModels.GashaNamePlateS.FromPointer); // 0x30 GashaNamePlateS             ( ModelClassType GashaNamePlateS GashaNamePlateS GashaNamePlateS Pointer )
            value.Handup                                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 Handup                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GashaHandup                               = GetObject<GashaHandup>(new IntPtr(p + 0x040), ReversePrism.DataModels.GashaHandup.FromPointer); // 0x40 GashaHandup                 ( ModelClassType GashaHandup GashaHandup GashaHandup Pointer )
            value.ScharaEffect                              = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 ScharaEffect                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Phase1Area                                = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 Phase1Area                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Phase2Area                                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 Phase2Area                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Phase3_S3Area                             = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 Phase3_S3Area               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Phase3_S9Area                             = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 Phase3_S9Area               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PGashaEffectArea                          = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 0x70 PGashaEffectArea            ( ModelClassType Transform Transform Transform Pointer )
            value.Btnskip                                   = GetObject<ButtonBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x78 Btnskip                     ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnTouch                                  = GetObject<ButtonBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x80 BtnTouch                    ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x088)); // 0x88 FadeDuration                ( ModelPrimitiveType float float float Single )
            value.ListGashaScene                            = GetObjectList<GashaSceneData>(new IntPtr(p + 0x010), ReversePrism.DataModels.GashaSceneData.FromPointer); // 0x10 ListGashaScene              ( ModelClassListType List`1<GashaSceneData> List`1<GashaSceneData> List<GashaSceneData> Pointer )
            value.IsPreLoaded                               = GetBool(new IntPtr(p + 0x018)); // 0x18 IsPreLoaded                 ( ModelPrimitiveType bool bool bool Bool )
            value.SkipToGameObjectName                      = GetString(new IntPtr(p + 0x090)); // 0x90 SkipToGameObjectName        ( ModelPrimitiveType string string string String )
            value.SkipToLoopStart                           = GetBool(new IntPtr(p + 0x098)); // 0x98 SkipToLoopStart             ( ModelPrimitiveType bool bool bool Bool )
            value.OnTapCallBack                             = GetObject<Action>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Action.FromPointer); // 0xA0 OnTapCallBack               ( ModelClassType Action Action Action Pointer )
            value.IsPlayFirstTime                           = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 IsPlayFirstTime             ( ModelPrimitiveType bool bool bool Bool )
            value.BaseGashaInstance                         = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0xB0 BaseGashaInstance           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BasePostProcess                           = GetObject<PostProcessVolume>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PostProcessVolume.FromPointer); // 0xB8 BasePostProcess             ( ModelClassType PostProcessVolume PostProcessVolume PostProcessVolume Pointer )
            value.CharacterParents                          = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0xC0 CharacterParents            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BaseScene                                 = GetObject<CutScene>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CutScene.FromPointer); // 0xD0 BaseScene                   ( ModelClassType CutScene CutScene CutScene Pointer )
            value.BaseCameraObject                          = GetObject<GameObject>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.GameObject.FromPointer); // 0xD8 BaseCameraObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MainCamera                                = GetObject<GameObject>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GameObject.FromPointer); // 0xE0 MainCamera                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EffectPlayer                              = GetObject<EffectPlayer>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.EffectPlayer.FromPointer); // 0xE8 EffectPlayer                ( ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer )
            value.CamEventBase                              = GetObject<CameraWorkEvent>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0xF0 CamEventBase                ( ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.TimelineController                        = GetObject<TimelineController>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.TimelineController.FromPointer); // 0xF8 TimelineController          ( ModelClassType TimelineController TimelineController TimelineController Pointer )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x100), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0x100 ScreenEffect                ( ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x108)); // 0x108 IsInitializeEnd             ( ModelPrimitiveType bool bool bool Bool )
            value.IsSequenceEnd                             = GetBool(new IntPtr(p + 0x109)); // 0x109 IsSequenceEnd               ( ModelPrimitiveType bool bool bool Bool )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x10A)); // 0x10A IsPause                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsMovieStop                               = GetBool(new IntPtr(p + 0x10B)); // 0x10B IsMovieStop                 ( ModelPrimitiveType bool bool bool Bool )
            value.OnSequenceEnd                             = GetObject<Action>(new IntPtr(p + 0x110), ReversePrism.DataModels.Action.FromPointer); // 0x110 OnSequenceEnd               ( ModelClassType Action Action Action Pointer )
            value.SequenceFrame                             = GetSingle(new IntPtr(p + 0x118)); // 0x118 SequenceFrame               ( ModelPrimitiveType float float float Single )
            value.CurrentSceneIndex                         = GetInt32(new IntPtr(p + 0x11C)); // 0x11C CurrentSceneIndex           ( ModelPrimitiveType int int int Int32 )
            value.SceneIndexOld                             = GetInt32(new IntPtr(p + 0x120)); // 0x120 SceneIndexOld               ( ModelPrimitiveType int int int Int32 )
            value.CurrentStartFrame                         = GetSingle(new IntPtr(p + 0x124)); // 0x124 CurrentStartFrame           ( ModelPrimitiveType float float float Single )
            value.LoopNextFlag                              = GetBool(new IntPtr(p + 0x128)); // 0x128 LoopNextFlag                ( ModelPrimitiveType bool bool bool Bool )
            value.CutInstanceGameObjects                    = GetObjectList<GameObject>(new IntPtr(p + 0x130), ReversePrism.DataModels.GameObject.FromPointer); // 0x130 CutInstanceGameObjects      ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CamEvents                                 = GetObjectList<CameraWorkEvent>(new IntPtr(p + 0x138), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0x138 CamEvents                   ( ModelClassListType CameraWorkEvent[] CameraWorkEvent[] List<CameraWorkEvent> Pointer )
            value.SceneTypes                                = GetEnumList<SceneType>(new IntPtr(p + 0x140)); // 0x140 SceneTypes                  ( ModelEnumListType SceneType[] SceneType[] List<SceneType> Pointer )
            value.CutScenes                                 = GetObjectList<CutScene>(new IntPtr(p + 0x148), ReversePrism.DataModels.CutScene.FromPointer); // 0x148 CutScenes                   ( ModelClassListType CutScene[] CutScene[] List<CutScene> Pointer )
            value.CutCharacterDirs                          = GetObjectList<Transform>(new IntPtr(p + 0x150), ReversePrism.DataModels.Transform.FromPointer); // 0x150 CutCharacterDirs            ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x158), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0x158 SoundResources              ( ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.PlayGashaSequenceNo                       = (Sequence)GetInt32(new IntPtr(p + 0x01C)); // 0x1C PlayGashaSequenceNo         ( ModelEnumType Sequence Sequence Sequence Int32 )

            return value;
        }
    }
}
