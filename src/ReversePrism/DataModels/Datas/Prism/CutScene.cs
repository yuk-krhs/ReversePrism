using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SceneCreateData                          ModelClassType Data Data Data Pointer
    // 028 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 030 EndFrame                                 ModelPrimitiveType int int int Int32
    // 034 MovieOnly                                ModelPrimitiveType bool bool bool Bool
    // 038 LoopFrameForADV                          ModelPrimitiveType int int int Int32
    // 03C CameraLoop                               ModelPrimitiveType bool bool bool Bool
    // 03D LoopWait                                 ModelPrimitiveType bool bool bool Bool
    // 040 LiveCharacterController                  ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 048 CameraController                         ModelClassType CameraController CameraController CameraController Pointer
    // 050 CamEvent                                 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 058 Timeline                                 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 060 SceneBgm                                 ModelClassType CriAtomSource CriAtomSource CriAtomSource Pointer
    // 068 CharacterTable                           ModelClassListType Character[] Character[] List<Character> Pointer
    // 070 IsInitializeEnd                          ModelPrimitiveType bool bool bool Bool
    // 071 IsEndLoop                                ModelPrimitiveType bool bool bool Bool
    // 078 MoviePlayer                              ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 080 IsBaseScene                              ModelPrimitiveType bool bool bool Bool
    // 081 IsNoSound                                ModelPrimitiveType bool bool bool Bool
    // 088 VoiceList                                ModelClassListType List`1<VoiceRequest> List`1<VoiceRequest> List<VoiceRequest> Pointer
    // 090 SoundResources                           ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 098 SwitchCahacter                           ModelClassType SwitchCharacter SwitchCharacter SwitchCharacter Pointer
    // 0A0 SwitchMovie                              ModelClassType SwitchMovie SwitchMovie SwitchMovie Pointer
    // 0A8 AnimationFrame                           ModelPrimitiveType float float float Single
    // 0B0 CurrentVoice                             ModelClassType VoiceRequest VoiceRequest VoiceRequest Pointer
    // 000 displaySceneName                         bool IL2CPP_TYPE_BOOLEAN
    public partial class CutScene : DataModel
    {
        public Data?                                    SceneCreateData                         { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public int                                      EndFrame                                { get; set; }
        public bool                                     MovieOnly                               { get; set; }
        public int                                      LoopFrameForADV                         { get; set; }
        public bool                                     CameraLoop                              { get; set; }
        public bool                                     LoopWait                                { get; set; }
        public LiveCharacterController?                 LiveCharacterController                 { get; set; }
        public CameraController?                        CameraController                        { get; set; }
        public CameraWorkEvent?                         CamEvent                                { get; set; }
        public PlayableDirector?                        Timeline                                { get; set; }
        public CriAtomSource?                           SceneBgm                                { get; set; }
        public List<Character>?                         CharacterTable                          { get; set; }
        public bool                                     IsInitializeEnd                         { get; set; }
        public bool                                     IsEndLoop                               { get; set; }
        public MoviePlayer?                             MoviePlayer                             { get; set; }
        public bool                                     IsBaseScene                             { get; set; }
        public bool                                     IsNoSound                               { get; set; }
        public List<VoiceRequest>?                      VoiceList                               { get; set; }
        public MvCutSceneSoundResources?                SoundResources                          { get; set; }
        public SwitchCharacter?                         SwitchCahacter                          { get; set; }
        public SwitchMovie?                             SwitchMovie                             { get; set; }
        public float                                    AnimationFrame                          { get; set; }
        public VoiceRequest?                            CurrentVoice                            { get; set; }

        public static CutScene? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CutScene() { Pointer= p0 };

            value.SceneCreateData                           = GetObject<Data>(new IntPtr(p + 0x020), ReversePrism.DataModels.Data.FromPointer); // 0x20 SceneCreateData             ( ModelClassType Data Data Data Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x28 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.EndFrame                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 EndFrame                    ( ModelPrimitiveType int int int Int32 )
            value.MovieOnly                                 = GetBool(new IntPtr(p + 0x034)); // 0x34 MovieOnly                   ( ModelPrimitiveType bool bool bool Bool )
            value.LoopFrameForADV                           = GetInt32(new IntPtr(p + 0x038)); // 0x38 LoopFrameForADV             ( ModelPrimitiveType int int int Int32 )
            value.CameraLoop                                = GetBool(new IntPtr(p + 0x03C)); // 0x3C CameraLoop                  ( ModelPrimitiveType bool bool bool Bool )
            value.LoopWait                                  = GetBool(new IntPtr(p + 0x03D)); // 0x3D LoopWait                    ( ModelPrimitiveType bool bool bool Bool )
            value.LiveCharacterController                   = GetObject<LiveCharacterController>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0x40 LiveCharacterController     ( ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.CameraController                          = GetObject<CameraController>(new IntPtr(p + 0x048), ReversePrism.DataModels.CameraController.FromPointer); // 0x48 CameraController            ( ModelClassType CameraController CameraController CameraController Pointer )
            value.CamEvent                                  = GetObject<CameraWorkEvent>(new IntPtr(p + 0x050), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0x50 CamEvent                    ( ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x058), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x58 Timeline                    ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.SceneBgm                                  = GetObject<CriAtomSource>(new IntPtr(p + 0x060), ReversePrism.DataModels.CriAtomSource.FromPointer); // 0x60 SceneBgm                    ( ModelClassType CriAtomSource CriAtomSource CriAtomSource Pointer )
            value.CharacterTable                            = GetObjectList<Character>(new IntPtr(p + 0x068), ReversePrism.DataModels.Character.FromPointer); // 0x68 CharacterTable              ( ModelClassListType Character[] Character[] List<Character> Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x070)); // 0x70 IsInitializeEnd             ( ModelPrimitiveType bool bool bool Bool )
            value.IsEndLoop                                 = GetBool(new IntPtr(p + 0x071)); // 0x71 IsEndLoop                   ( ModelPrimitiveType bool bool bool Bool )
            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x078), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0x78 MoviePlayer                 ( ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.IsBaseScene                               = GetBool(new IntPtr(p + 0x080)); // 0x80 IsBaseScene                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsNoSound                                 = GetBool(new IntPtr(p + 0x081)); // 0x81 IsNoSound                   ( ModelPrimitiveType bool bool bool Bool )
            value.VoiceList                                 = GetObjectList<VoiceRequest>(new IntPtr(p + 0x088), ReversePrism.DataModels.VoiceRequest.FromPointer); // 0x88 VoiceList                   ( ModelClassListType List`1<VoiceRequest> List`1<VoiceRequest> List<VoiceRequest> Pointer )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x090), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0x90 SoundResources              ( ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.SwitchCahacter                            = GetObject<SwitchCharacter>(new IntPtr(p + 0x098), ReversePrism.DataModels.SwitchCharacter.FromPointer); // 0x98 SwitchCahacter              ( ModelClassType SwitchCharacter SwitchCharacter SwitchCharacter Pointer )
            value.SwitchMovie                               = GetObject<SwitchMovie>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SwitchMovie.FromPointer); // 0xA0 SwitchMovie                 ( ModelClassType SwitchMovie SwitchMovie SwitchMovie Pointer )
            value.AnimationFrame                            = GetSingle(new IntPtr(p + 0x0A8)); // 0xA8 AnimationFrame              ( ModelPrimitiveType float float float Single )
            value.CurrentVoice                              = GetObject<VoiceRequest>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.VoiceRequest.FromPointer); // 0xB0 CurrentVoice                ( ModelClassType VoiceRequest VoiceRequest VoiceRequest Pointer )

            return value;
        }
    }
}
