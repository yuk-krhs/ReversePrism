using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StartScene                               ModelClassType TextAsset TextAsset TextAsset Pointer
    // 000 sequenceData                             SequenceData IL2CPP_TYPE_CLASS
    // 008 playCutSceneData                         List`1<PlayCutSceneData> IL2CPP_TYPE_GENERICINST
    // 010 SceneLoader                              ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer
    // 018 StartSceneName                           ModelPrimitiveType string string string String
    // 020 SequenceSelectFileName                   ModelPrimitiveType string string string String
    // 028 LiveCamera                               ModelClassType GameObject GameObject GameObject Pointer
    // 030 LiveTopObject                            ModelClassType GameObject GameObject GameObject Pointer
    // 038 EffectPlayerCanvasObject                 ModelClassType GameObject GameObject GameObject Pointer
    // 040 EffectPlayer                             ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer
    // 048 CamEventLive                             ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 050 TimelineController                       ModelClassType TimelineController TimelineController TimelineController Pointer
    // 028 SceneCreateData                          ModelClassType Data Data Data Pointer
    // 030 LiveInFade                               ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
    // 038 LiveOutFade                              ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
    // 058 lucsReturnBackLiveLights                 ValueTuple`2<Light, bool>[] IL2CPP_TYPE_SZARRAY
    // 060 IsKeepLightActives                       ModelPrimitiveType bool bool bool Bool
    // 068 PlayCutSceneContents                     ModelClassListType MvPlayCutSceneContent[] MvPlayCutSceneContent[] List<MvPlayCutSceneContent> Pointer
    // 070 ScreenEffect                             ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 078 PoolUnit                                 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 080 PoolCharacter                            ModelClassListType Character[] Character[] List<Character> Pointer
    // 088 SequenceFrame                            ModelPrimitiveType float float float Single
    // 08C CurrentCutSceneId                        ModelPrimitiveType int int int Int32
    // 090 CutSceneIdPrevFrame                      ModelPrimitiveType int int int Int32
    // 000 LiveSceneID                              int IL2CPP_TYPE_I4
    // 094 StartAudioVolume                         ModelPrimitiveType float float float Single
    // 098 IsFade                                   ModelPrimitiveType bool bool bool Bool
    // 09C EndFrame                                 ModelPrimitiveType float float float Single
    // 0A0 PoolParentObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 MainCamera                               ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 IsInitializeEnd                          ModelPrimitiveType bool bool bool Bool
    // 040 IsPreLoaded                              ModelPrimitiveType bool bool bool Bool
    // 0B1 IsEnd                                    ModelPrimitiveType bool bool bool Bool
    // 0B8 SoundResources                           ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 0C0 IsReleased                               ModelPrimitiveType bool bool bool Bool
    // 000 postName                                 string IL2CPP_TYPE_STRING
    // 000 savePostName                             string IL2CPP_TYPE_STRING
    // 0C4 SoundTimeOffset                          ModelPrimitiveType float float float Single
    // 0C8 IsPause                                  ModelPrimitiveType bool bool bool Bool
    // 0C9 IsPlayBgm                                ModelPrimitiveType bool bool bool Bool
    // 0D0 IdNameList                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 dicCutSceneSelect                        Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 050 dicCutSceneSelectDirect                  Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 0D8 NoDispID                                 ModelPrimitiveType bool bool bool Bool
    // 058 DressList                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 060 ClothList                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
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
        public bool                                     IsKeepLightActives                      { get; set; }
        public List<MvPlayCutSceneContent>?             PlayCutSceneContents                    { get; set; }
        public ScreenEffectEx?                          ScreenEffect                            { get; set; }
        public List<UnitIdol>?                          PoolUnit                                { get; set; }
        public List<Character>?                         PoolCharacter                           { get; set; }
        public float                                    SequenceFrame                           { get; set; }
        public int                                      CurrentCutSceneId                       { get; set; }
        public int                                      CutSceneIdPrevFrame                     { get; set; }
        public float                                    StartAudioVolume                        { get; set; }
        public bool                                     IsFade                                  { get; set; }
        public float                                    EndFrame                                { get; set; }
        public GameObject?                              PoolParentObject                        { get; set; }
        public GameObject?                              MainCamera                              { get; set; }
        public bool                                     IsInitializeEnd                         { get; set; }
        public bool                                     IsPreLoaded                             { get; set; }
        public bool                                     IsEnd                                   { get; set; }
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

            value.StartScene                                = GetObject<TextAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextAsset.FromPointer); // 0x20 StartScene                  ( ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.SceneLoader                               = GetObject<SceneLoaderAddressable>(new IntPtr(p + 0x010), ReversePrism.DataModels.SceneLoaderAddressable.FromPointer); // 0x10 SceneLoader                 ( ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer )
            value.StartSceneName                            = GetString(new IntPtr(p + 0x018)); // 0x18 StartSceneName              ( ModelPrimitiveType string string string String )
            value.SequenceSelectFileName                    = GetString(new IntPtr(p + 0x020)); // 0x20 SequenceSelectFileName      ( ModelPrimitiveType string string string String )
            value.LiveCamera                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 LiveCamera                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LiveTopObject                             = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 LiveTopObject               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EffectPlayerCanvasObject                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 EffectPlayerCanvasObject    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EffectPlayer                              = GetObject<EffectPlayer>(new IntPtr(p + 0x040), ReversePrism.DataModels.EffectPlayer.FromPointer); // 0x40 EffectPlayer                ( ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer )
            value.CamEventLive                              = GetObject<CameraWorkEvent>(new IntPtr(p + 0x048), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0x48 CamEventLive                ( ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.TimelineController                        = GetObject<TimelineController>(new IntPtr(p + 0x050), ReversePrism.DataModels.TimelineController.FromPointer); // 0x50 TimelineController          ( ModelClassType TimelineController TimelineController TimelineController Pointer )
            value.SceneCreateData                           = GetObject<Data>(new IntPtr(p + 0x028), ReversePrism.DataModels.Data.FromPointer); // 0x28 SceneCreateData             ( ModelClassType Data Data Data Pointer )
            value.LiveInFade                                = GetObject<PlayFadeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PlayFadeData.FromPointer); // 0x30 LiveInFade                  ( ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )
            value.LiveOutFade                               = GetObject<PlayFadeData>(new IntPtr(p + 0x038), ReversePrism.DataModels.PlayFadeData.FromPointer); // 0x38 LiveOutFade                 ( ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )
            value.IsKeepLightActives                        = GetBool(new IntPtr(p + 0x060)); // 0x60 IsKeepLightActives          ( ModelPrimitiveType bool bool bool Bool )
            value.PlayCutSceneContents                      = GetObjectList<MvPlayCutSceneContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.MvPlayCutSceneContent.FromPointer); // 0x68 PlayCutSceneContents        ( ModelClassListType MvPlayCutSceneContent[] MvPlayCutSceneContent[] List<MvPlayCutSceneContent> Pointer )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x070), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0x70 ScreenEffect                ( ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.PoolUnit                                  = GetObjectList<UnitIdol>(new IntPtr(p + 0x078), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x78 PoolUnit                    ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.PoolCharacter                             = GetObjectList<Character>(new IntPtr(p + 0x080), ReversePrism.DataModels.Character.FromPointer); // 0x80 PoolCharacter               ( ModelClassListType Character[] Character[] List<Character> Pointer )
            value.SequenceFrame                             = GetSingle(new IntPtr(p + 0x088)); // 0x88 SequenceFrame               ( ModelPrimitiveType float float float Single )
            value.CurrentCutSceneId                         = GetInt32(new IntPtr(p + 0x08C)); // 0x8C CurrentCutSceneId           ( ModelPrimitiveType int int int Int32 )
            value.CutSceneIdPrevFrame                       = GetInt32(new IntPtr(p + 0x090)); // 0x90 CutSceneIdPrevFrame         ( ModelPrimitiveType int int int Int32 )
            value.StartAudioVolume                          = GetSingle(new IntPtr(p + 0x094)); // 0x94 StartAudioVolume            ( ModelPrimitiveType float float float Single )
            value.IsFade                                    = GetBool(new IntPtr(p + 0x098)); // 0x98 IsFade                      ( ModelPrimitiveType bool bool bool Bool )
            value.EndFrame                                  = GetSingle(new IntPtr(p + 0x09C)); // 0x9C EndFrame                    ( ModelPrimitiveType float float float Single )
            value.PoolParentObject                          = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 PoolParentObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MainCamera                                = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 MainCamera                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 IsInitializeEnd             ( ModelPrimitiveType bool bool bool Bool )
            value.IsPreLoaded                               = GetBool(new IntPtr(p + 0x040)); // 0x40 IsPreLoaded                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsEnd                                     = GetBool(new IntPtr(p + 0x0B1)); // 0xB1 IsEnd                       ( ModelPrimitiveType bool bool bool Bool )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0xB8 SoundResources              ( ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.IsReleased                                = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 IsReleased                  ( ModelPrimitiveType bool bool bool Bool )
            value.SoundTimeOffset                           = GetSingle(new IntPtr(p + 0x0C4)); // 0xC4 SoundTimeOffset             ( ModelPrimitiveType float float float Single )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 IsPause                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsPlayBgm                                 = GetBool(new IntPtr(p + 0x0C9)); // 0xC9 IsPlayBgm                   ( ModelPrimitiveType bool bool bool Bool )
            value.IdNameList                                = GetStringList(new IntPtr(p + 0x0D0)); // 0xD0 IdNameList                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.NoDispID                                  = GetBool(new IntPtr(p + 0x0D8)); // 0xD8 NoDispID                    ( ModelPrimitiveType bool bool bool Bool )
            value.DressList                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x058), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x58 DressList                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.ClothList                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x060), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x60 ClothList                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
