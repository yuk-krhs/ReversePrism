using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StartScene                               000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 000 sequenceData                             SequenceData IL2CPP_TYPE_CLASS
    // 008 playCutSceneData                         List`1<PlayCutSceneData> IL2CPP_TYPE_GENERICINST
    // 010 SceneLoader                              0001866CCB50 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer
    // 018 StartSceneName                           000186672530 ModelPrimitiveType string string string String
    // 020 SequenceSelectFileName                   000186672530 ModelPrimitiveType string string string String
    // 028 LiveCamera                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 LiveTopObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 EffectPlayerCanvasObject                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 EffectPlayer                             0001867210F0 ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer
    // 048 CamEventLive                             0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 050 TimelineController                       00018666EA20 ModelClassType TimelineController TimelineController TimelineController Pointer
    // 028 SceneCreateData                          0001867109B0 ModelClassType Data Data Data Pointer
    // 030 LiveInFade                               00018676D830 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
    // 038 LiveOutFade                              00018676D830 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
    // 058 CutInstance                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 CamEvent                                 000185B72FE0 ModelClassListType CameraWorkEvent[] CameraWorkEvent[] List<CameraWorkEvent> Pointer
    // 068 SceneType                                000185CC2718 ModelEnumListType SceneType[] SceneType[] List<SceneType> Pointer
    // 070 CutScene                                 000185B78690 ModelClassListType CutScene[] CutScene[] List<CutScene> Pointer
    // 078 CutCharacterDir                          000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 080 ScreenEffect                             0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 088 PoolUnit                                 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 090 PoolCharacter                            000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer
    // 098 characterTables                          Character[][] IL2CPP_TYPE_SZARRAY
    // 0A0 SequenceFrame                            0001866656B0 ModelPrimitiveType float float float Single
    // 0A4 CurrentCS                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A8 LastCS                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0AC StartAudioVolume                         0001866656B0 ModelPrimitiveType float float float Single
    // 0B0 IsFade                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B4 EndFrame                                 0001866656B0 ModelPrimitiveType float float float Single
    // 0B8 PoolParents                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 MainCamera                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 IsInitializeEnd                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 IsPreLoaded                              000186595C30 ModelPrimitiveType bool bool bool Bool
    // 0C9 IsEnd                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0CC ActivatedCS                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0D0 SoundResources                           000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 0D8 IsReleased                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 postName                                 string IL2CPP_TYPE_STRING
    // 000 savePostName                             string IL2CPP_TYPE_STRING
    // 000 LiveSceneID                              int IL2CPP_TYPE_I4
    // 0DC SoundTimeOffset                          0001866656B0 ModelPrimitiveType float float float Single
    // 0E0 IsPause                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E1 IsPlayBgm                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E8 IdNameList                               000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 dicCutSceneSelect                        Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 050 dicCutSceneSelectDirect                  Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 0F0 NoDispID                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 DressList                                000185CAF388 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 060 ClothList                                000185CAF388 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    public partial class MvSequencer : DataModel
    {
        public TextAsset?                               StartScene                              { get; set; }
        public SceneLoaderAddressable?                  SceneLoader                             { get; set; }
        public string                                   StartSceneName                          { get; set; }
        public string                                   SequenceSelectFileName                  { get; set; }
        public GameObject?                              LiveCamera                              { get; set; }
        public GameObject?                              LiveTopObject                           { get; set; }
        public GameObject?                              EffectPlayerCanvasObject                { get; set; }
        public EffectPlayer?                            EffectPlayer                            { get; set; }
        public CameraWorkEvent?                         CamEventLive                            { get; set; }
        public TimelineController?                      TimelineController                      { get; set; }
        public Data?                                    SceneCreateData                         { get; set; }
        public PlayFadeData?                            LiveInFade                              { get; set; }
        public PlayFadeData?                            LiveOutFade                             { get; set; }
        public List<GameObject>?                        CutInstance                             { get; set; }
        public List<CameraWorkEvent>?                   CamEvent                                { get; set; }
        public List<SceneType>?                         SceneType                               { get; set; }
        public List<CutScene>?                          CutScene                                { get; set; }
        public List<Transform>?                         CutCharacterDir                         { get; set; }
        public ScreenEffectEx?                          ScreenEffect                            { get; set; }
        public List<UnitIdol>?                          PoolUnit                                { get; set; }
        public List<Character>?                         PoolCharacter                           { get; set; }
        public float                                    SequenceFrame                           { get; set; }
        public int                                      CurrentCS                               { get; set; }
        public int                                      LastCS                                  { get; set; }
        public float                                    StartAudioVolume                        { get; set; }
        public bool                                     IsFade                                  { get; set; }
        public float                                    EndFrame                                { get; set; }
        public GameObject?                              PoolParents                             { get; set; }
        public GameObject?                              MainCamera                              { get; set; }
        public bool                                     IsInitializeEnd                         { get; set; }
        public bool                                     IsPreLoaded                             { get; set; }
        public bool                                     IsEnd                                   { get; set; }
        public int                                      ActivatedCS                             { get; set; }
        public MvCutSceneSoundResources?                SoundResources                          { get; set; }
        public bool                                     IsReleased                              { get; set; }
        public float                                    SoundTimeOffset                         { get; set; }
        public bool                                     IsPause                                 { get; set; }
        public bool                                     IsPlayBgm                               { get; set; }
        public List<string>?                            IdNameList                              { get; set; }
        public bool                                     NoDispID                                { get; set; }
        public List<UnitIdol>?                          DressList                               { get; set; }
        public List<UnitIdol>?                          ClothList                               { get; set; }

        public static MvSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MvSequencer() { Pointer= p0 };

            value.StartScene                                = GetObject<TextAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextAsset.FromPointer); // 024664E456A8 0x20 StartScene                  ( 000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.SceneLoader                               = GetObject<SceneLoaderAddressable>(new IntPtr(p + 0x010), ReversePrism.DataModels.SceneLoaderAddressable.FromPointer); // 024664E45708 0x10 SceneLoader                 ( 0001866CCB50 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer )
            value.StartSceneName                            = GetString(new IntPtr(p + 0x018)); // 024664E45728 0x18 StartSceneName              ( 000186672530 ModelPrimitiveType string string string String )
            value.SequenceSelectFileName                    = GetString(new IntPtr(p + 0x020)); // 024664E45748 0x20 SequenceSelectFileName      ( 000186672530 ModelPrimitiveType string string string String )
            value.LiveCamera                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024664E45768 0x28 LiveCamera                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LiveTopObject                             = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 024664E45788 0x30 LiveTopObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EffectPlayerCanvasObject                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 024664E457A8 0x38 EffectPlayerCanvasObject    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EffectPlayer                              = GetObject<EffectPlayer>(new IntPtr(p + 0x040), ReversePrism.DataModels.EffectPlayer.FromPointer); // 024664E457C8 0x40 EffectPlayer                ( 0001867210F0 ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer )
            value.CamEventLive                              = GetObject<CameraWorkEvent>(new IntPtr(p + 0x048), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 024664E457E8 0x48 CamEventLive                ( 0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.TimelineController                        = GetObject<TimelineController>(new IntPtr(p + 0x050), ReversePrism.DataModels.TimelineController.FromPointer); // 024664E45808 0x50 TimelineController          ( 00018666EA20 ModelClassType TimelineController TimelineController TimelineController Pointer )
            value.SceneCreateData                           = GetObject<Data>(new IntPtr(p + 0x028), ReversePrism.DataModels.Data.FromPointer); // 024664E45828 0x28 SceneCreateData             ( 0001867109B0 ModelClassType Data Data Data Pointer )
            value.LiveInFade                                = GetObject<PlayFadeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PlayFadeData.FromPointer); // 024664E45848 0x30 LiveInFade                  ( 00018676D830 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )
            value.LiveOutFade                               = GetObject<PlayFadeData>(new IntPtr(p + 0x038), ReversePrism.DataModels.PlayFadeData.FromPointer); // 024664E45868 0x38 LiveOutFade                 ( 00018676D830 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )
            value.CutInstance                               = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 024664E45888 0x58 CutInstance                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CamEvent                                  = GetObjectList<CameraWorkEvent>(new IntPtr(p + 0x060), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 024664E458A8 0x60 CamEvent                    ( 000185B72FE0 ModelClassListType CameraWorkEvent[] CameraWorkEvent[] List<CameraWorkEvent> Pointer )
            value.SceneType                                 = GetEnumList<SceneType>(new IntPtr(p + 0x068)); // 024664E458C8 0x68 SceneType                   ( 000185CC2718 ModelEnumListType SceneType[] SceneType[] List<SceneType> Pointer )
            value.CutScene                                  = GetObjectList<CutScene>(new IntPtr(p + 0x070), ReversePrism.DataModels.CutScene.FromPointer); // 024664E458E8 0x70 CutScene                    ( 000185B78690 ModelClassListType CutScene[] CutScene[] List<CutScene> Pointer )
            value.CutCharacterDir                           = GetObjectList<Transform>(new IntPtr(p + 0x078), ReversePrism.DataModels.Transform.FromPointer); // 024664E45908 0x78 CutCharacterDir             ( 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x080), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 024664E45928 0x80 ScreenEffect                ( 0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.PoolUnit                                  = GetObjectList<UnitIdol>(new IntPtr(p + 0x088), ReversePrism.DataModels.UnitIdol.FromPointer); // 024664E45948 0x88 PoolUnit                    ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.PoolCharacter                             = GetObjectList<Character>(new IntPtr(p + 0x090), ReversePrism.DataModels.Character.FromPointer); // 024664E45968 0x90 PoolCharacter               ( 000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer )
            value.SequenceFrame                             = GetSingle(new IntPtr(p + 0x0A0)); // 024664E459A8 0xA0 SequenceFrame               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentCS                                 = GetInt32(new IntPtr(p + 0x0A4)); // 024664E459C8 0xA4 CurrentCS                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastCS                                    = GetInt32(new IntPtr(p + 0x0A8)); // 024664E459E8 0xA8 LastCS                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StartAudioVolume                          = GetSingle(new IntPtr(p + 0x0AC)); // 024664E45A08 0xAC StartAudioVolume            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsFade                                    = GetBool(new IntPtr(p + 0x0B0)); // 024664E45A28 0xB0 IsFade                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EndFrame                                  = GetSingle(new IntPtr(p + 0x0B4)); // 024664E45A48 0xB4 EndFrame                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PoolParents                               = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 024664E45A68 0xB8 PoolParents                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MainCamera                                = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 024664E45A88 0xC0 MainCamera                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x0C8)); // 024664E45AA8 0xC8 IsInitializeEnd             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPreLoaded                               = GetBool(new IntPtr(p + 0x040)); // 024664E45AC8 0x40 IsPreLoaded                 ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.IsEnd                                     = GetBool(new IntPtr(p + 0x0C9)); // 024664E45AE8 0xC9 IsEnd                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ActivatedCS                               = GetInt32(new IntPtr(p + 0x0CC)); // 024664E45B08 0xCC ActivatedCS                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 024664E45B28 0xD0 SoundResources              ( 000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.IsReleased                                = GetBool(new IntPtr(p + 0x0D8)); // 024664E45B48 0xD8 IsReleased                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SoundTimeOffset                           = GetSingle(new IntPtr(p + 0x0DC)); // 024664E45BC8 0xDC SoundTimeOffset             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x0E0)); // 024664E45BE8 0xE0 IsPause                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPlayBgm                                 = GetBool(new IntPtr(p + 0x0E1)); // 024664E45C08 0xE1 IsPlayBgm                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IdNameList                                = GetStringList(new IntPtr(p + 0x0E8)); // 024664E45C28 0xE8 IdNameList                  ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.NoDispID                                  = GetBool(new IntPtr(p + 0x0F0)); // 024664E45C88 0xF0 NoDispID                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DressList                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x058), ReversePrism.DataModels.UnitIdol.FromPointer); // 024664E45CA8 0x58 DressList                   ( 000185CAF388 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.ClothList                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x060), ReversePrism.DataModels.UnitIdol.FromPointer); // 024664E45CC8 0x60 ClothList                   ( 000185CAF388 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
