using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaScharaEffectsDirection              0001866195B0 ModelClassType GashaScharaEffectsDirection GashaScharaEffectsDirection GashaScharaEffectsDirection Pointer
    // 028 GashaNamePlateEx                         0001866089D0 ModelClassType GashaNamePlateEx GashaNamePlateEx GashaNamePlateEx Pointer
    // 030 GashaNamePlateS                          0001866090A0 ModelClassType GashaNamePlateS GashaNamePlateS GashaNamePlateS Pointer
    // 038 Handup                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 GashaHandup                              000186603E90 ModelClassType GashaHandup GashaHandup GashaHandup Pointer
    // 048 ScharaEffect                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 Phase1Area                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 Phase2Area                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 Phase3_S3Area                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 Phase3_S9Area                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 PGashaEffectArea                         0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 078 Btnskip                                  000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 080 BtnTouch                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 088 FadeDuration                             0001866656B0 ModelPrimitiveType float float float Single
    // 000 conditionList                            Condition[] IL2CPP_TYPE_SZARRAY
    // 008 originalConditionList                    Dictionary`2<string, Condition[]> IL2CPP_TYPE_GENERICINST
    // 010 ListGashaScene                           000185D24618 ModelClassListType List`1<GashaSceneData> List`1<GashaSceneData> List<GashaSceneData> Pointer
    // 018 IsPreLoaded                              000186595C30 ModelPrimitiveType bool bool bool Bool
    // 000 baseCutSceneMargin                       int IL2CPP_TYPE_I4
    // 090 SkipToGameObjectName                     000186671910 ModelPrimitiveType string string string String
    // 098 SkipToLoopStart                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A0 OnTapCallBack                            0001866792B0 ModelClassType Action Action Action Pointer
    // 0A8 BaseGashaInstance                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 BasePostProcess                          00018676E4B0 ModelClassType PostProcessVolume PostProcessVolume PostProcessVolume Pointer
    // 0B8 CharacterParents                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 characterTables                          Character[][] IL2CPP_TYPE_SZARRAY
    // 0C8 BaseScene                                00018666E600 ModelClassType CutScene CutScene CutScene Pointer
    // 0D0 BaseCameraObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0D8 MainCamera                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0E0 EffectPlayer                             0001867210F0 ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer
    // 0E8 CamEventBase                             0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 0F0 TimelineController                       00018666EA20 ModelClassType TimelineController TimelineController TimelineController Pointer
    // 0F8 ScreenEffect                             0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 100 IsInitializeEnd                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 101 IsSequenceEnd                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 102 IsPause                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 103 IsMovieStop                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 108 OnSequenceEnd                            0001866792B0 ModelClassType Action Action Action Pointer
    // 110 SequenceFrame                            0001866656B0 ModelPrimitiveType float float float Single
    // 114 CurrentSceneIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 118 SceneIndexOld                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 11C CurrentStartFrame                        0001866656B0 ModelPrimitiveType float float float Single
    // 120 LoopNextFlag                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 128 CutInstanceGameObjects                   000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 130 CamEvents                                000185B72FE0 ModelClassListType CameraWorkEvent[] CameraWorkEvent[] List<CameraWorkEvent> Pointer
    // 138 SceneTypes                               000185CC2718 ModelEnumListType SceneType[] SceneType[] List<SceneType> Pointer
    // 140 CutScenes                                000185B78690 ModelClassListType CutScene[] CutScene[] List<CutScene> Pointer
    // 148 CutCharacterDirs                         000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 150 SoundResources                           000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 01C PlayGashaSequenceNo                      0001867228B0 ModelEnumType Sequence Sequence Sequence Int32
    public partial class GashaSequencer
    {
        public GashaScharaEffectsDirection?             GashaScharaEffectsDirection             { get; set; }
        public GashaNamePlateEx?                        GashaNamePlateEx                        { get; set; }
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
            var value   = new GashaSequencer();

            value.GashaScharaEffectsDirection               = GetObject<GashaScharaEffectsDirection>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaScharaEffectsDirection.FromPointer); // 0270D4DC1260 0x20 GashaScharaEffectsDirection ( 0001866195B0 ModelClassType GashaScharaEffectsDirection GashaScharaEffectsDirection GashaScharaEffectsDirection Pointer )
            value.GashaNamePlateEx                          = GetObject<GashaNamePlateEx>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaNamePlateEx.FromPointer); // 0270D4DC1280 0x28 GashaNamePlateEx            ( 0001866089D0 ModelClassType GashaNamePlateEx GashaNamePlateEx GashaNamePlateEx Pointer )
            value.GashaNamePlateS                           = GetObject<GashaNamePlateS>(new IntPtr(p + 0x030), ReversePrism.DataModels.GashaNamePlateS.FromPointer); // 0270D4DC12A0 0x30 GashaNamePlateS             ( 0001866090A0 ModelClassType GashaNamePlateS GashaNamePlateS GashaNamePlateS Pointer )
            value.Handup                                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC12C0 0x38 Handup                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GashaHandup                               = GetObject<GashaHandup>(new IntPtr(p + 0x040), ReversePrism.DataModels.GashaHandup.FromPointer); // 0270D4DC12E0 0x40 GashaHandup                 ( 000186603E90 ModelClassType GashaHandup GashaHandup GashaHandup Pointer )
            value.ScharaEffect                              = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC1300 0x48 ScharaEffect                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Phase1Area                                = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC1320 0x50 Phase1Area                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Phase2Area                                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC1340 0x58 Phase2Area                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Phase3_S3Area                             = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC1360 0x60 Phase3_S3Area               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Phase3_S9Area                             = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC1380 0x68 Phase3_S9Area               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PGashaEffectArea                          = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 0270D4DC13A0 0x70 PGashaEffectArea            ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Btnskip                                   = GetObject<ButtonBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D4DC13C0 0x78 Btnskip                     ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnTouch                                  = GetObject<ButtonBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D4DC13E0 0x80 BtnTouch                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x088)); // 0270D4DC1400 0x88 FadeDuration                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ListGashaScene                            = GetObjectList<GashaSceneData>(new IntPtr(p + 0x010), ReversePrism.DataModels.GashaSceneData.FromPointer); // 0270D4DC1460 0x10 ListGashaScene              ( 000185D24618 ModelClassListType List`1<GashaSceneData> List`1<GashaSceneData> List<GashaSceneData> Pointer )
            value.IsPreLoaded                               = GetBool(new IntPtr(p + 0x018)); // 0270D4DC1480 0x18 IsPreLoaded                 ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.SkipToGameObjectName                      = GetString(new IntPtr(p + 0x090)); // 0270D4DC14C0 0x90 SkipToGameObjectName        ( 000186671910 ModelPrimitiveType string string string String )
            value.SkipToLoopStart                           = GetBool(new IntPtr(p + 0x098)); // 0270D4DC14E0 0x98 SkipToLoopStart             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OnTapCallBack                             = GetObject<Action>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Action.FromPointer); // 0270D4DC1500 0xA0 OnTapCallBack               ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.BaseGashaInstance                         = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC1520 0xA8 BaseGashaInstance           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BasePostProcess                           = GetObject<PostProcessVolume>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PostProcessVolume.FromPointer); // 0270D4DC1540 0xB0 BasePostProcess             ( 00018676E4B0 ModelClassType PostProcessVolume PostProcessVolume PostProcessVolume Pointer )
            value.CharacterParents                          = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC1560 0xB8 CharacterParents            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BaseScene                                 = GetObject<CutScene>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CutScene.FromPointer); // 0270D4DC15A0 0xC8 BaseScene                   ( 00018666E600 ModelClassType CutScene CutScene CutScene Pointer )
            value.BaseCameraObject                          = GetObject<GameObject>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC15C0 0xD0 BaseCameraObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MainCamera                                = GetObject<GameObject>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC15E0 0xD8 MainCamera                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EffectPlayer                              = GetObject<EffectPlayer>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.EffectPlayer.FromPointer); // 0270D4DC1600 0xE0 EffectPlayer                ( 0001867210F0 ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer )
            value.CamEventBase                              = GetObject<CameraWorkEvent>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0270D4DC1620 0xE8 CamEventBase                ( 0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.TimelineController                        = GetObject<TimelineController>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.TimelineController.FromPointer); // 0270D4DC1640 0xF0 TimelineController          ( 00018666EA20 ModelClassType TimelineController TimelineController TimelineController Pointer )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0270D4DC1660 0xF8 ScreenEffect                ( 0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x100)); // 0270D4DC1680 0x100 IsInitializeEnd             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSequenceEnd                             = GetBool(new IntPtr(p + 0x101)); // 0270D4DC16A0 0x101 IsSequenceEnd               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x102)); // 0270D4DC16C0 0x102 IsPause                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsMovieStop                               = GetBool(new IntPtr(p + 0x103)); // 0270D4DC16E0 0x103 IsMovieStop                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OnSequenceEnd                             = GetObject<Action>(new IntPtr(p + 0x108), ReversePrism.DataModels.Action.FromPointer); // 0270D4DC1700 0x108 OnSequenceEnd               ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.SequenceFrame                             = GetSingle(new IntPtr(p + 0x110)); // 0270D4DC1720 0x110 SequenceFrame               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentSceneIndex                         = GetInt32(new IntPtr(p + 0x114)); // 0270D4DC1740 0x114 CurrentSceneIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SceneIndexOld                             = GetInt32(new IntPtr(p + 0x118)); // 0270D4DC1760 0x118 SceneIndexOld               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentStartFrame                         = GetSingle(new IntPtr(p + 0x11C)); // 0270D4DC1780 0x11C CurrentStartFrame           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LoopNextFlag                              = GetBool(new IntPtr(p + 0x120)); // 0270D4DC17A0 0x120 LoopNextFlag                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CutInstanceGameObjects                    = GetObjectList<GameObject>(new IntPtr(p + 0x128), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC17C0 0x128 CutInstanceGameObjects      ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CamEvents                                 = GetObjectList<CameraWorkEvent>(new IntPtr(p + 0x130), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0270D4DC17E0 0x130 CamEvents                   ( 000185B72FE0 ModelClassListType CameraWorkEvent[] CameraWorkEvent[] List<CameraWorkEvent> Pointer )
            value.SceneTypes                                = GetEnumList<SceneType>(new IntPtr(p + 0x138)); // 0270D4DC1800 0x138 SceneTypes                  ( 000185CC2718 ModelEnumListType SceneType[] SceneType[] List<SceneType> Pointer )
            value.CutScenes                                 = GetObjectList<CutScene>(new IntPtr(p + 0x140), ReversePrism.DataModels.CutScene.FromPointer); // 0270D4DC1820 0x140 CutScenes                   ( 000185B78690 ModelClassListType CutScene[] CutScene[] List<CutScene> Pointer )
            value.CutCharacterDirs                          = GetObjectList<Transform>(new IntPtr(p + 0x148), ReversePrism.DataModels.Transform.FromPointer); // 0270D4DC1840 0x148 CutCharacterDirs            ( 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x150), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0270D4DC1860 0x150 SoundResources              ( 000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.PlayGashaSequenceNo                       = (Sequence)GetInt32(new IntPtr(p + 0x01C)); // 0270D4DC1880 0x1C PlayGashaSequenceNo         ( 0001867228B0 ModelEnumType Sequence Sequence Sequence Int32 )

            return value;
        }
    }
}
