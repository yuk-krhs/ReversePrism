using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SceneCreateData                          000186710490 ModelClassType Data Data Data Pointer
    // 028 UnitIdols                                000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 030 EndFrame                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 MovieOnly                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 LoopFrameForADV                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C CameraLoop                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03D LoopWait                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 LiveCharacterController                  000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 048 CameraController                         000186536460 ModelClassType CameraController CameraController CameraController Pointer
    // 050 CamEvent                                 0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 058 Timeline                                 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 060 SceneBgm                                 00018664CD30 ModelClassType CriAtomSource CriAtomSource CriAtomSource Pointer
    // 068 CharacterTable                           000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer
    // 070 IsInitializeEnd                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 071 IsEndLoop                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 MoviePlayer                              000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 080 IsBaseScene                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 081 IsNoSound                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 VoiceList                                000185D21448 ModelClassListType List`1<VoiceRequest> List`1<VoiceRequest> List<VoiceRequest> Pointer
    // 090 SoundResources                           000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 098 SwitchCahacter                           00018656A0A0 ModelClassType SwitchCharacter SwitchCharacter SwitchCharacter Pointer
    // 0A0 SwitchMovie                              00018656AAD0 ModelClassType SwitchMovie SwitchMovie SwitchMovie Pointer
    // 0A8 AnimationFrame                           0001866656B0 ModelPrimitiveType float float float Single
    // 0B0 CurrentVoice                             00018656B4B0 ModelClassType VoiceRequest VoiceRequest VoiceRequest Pointer
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

            value.SceneCreateData                           = GetObject<Data>(new IntPtr(p + 0x020), ReversePrism.DataModels.Data.FromPointer); // 0245A5F96A58 0x20 SceneCreateData             ( 000186710490 ModelClassType Data Data Data Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitIdol.FromPointer); // 0245A5F96A78 0x28 UnitIdols                   ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.EndFrame                                  = GetInt32(new IntPtr(p + 0x030)); // 0245A5F96A98 0x30 EndFrame                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MovieOnly                                 = GetBool(new IntPtr(p + 0x034)); // 0245A5F96AB8 0x34 MovieOnly                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LoopFrameForADV                           = GetInt32(new IntPtr(p + 0x038)); // 0245A5F96AD8 0x38 LoopFrameForADV             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CameraLoop                                = GetBool(new IntPtr(p + 0x03C)); // 0245A5F96AF8 0x3C CameraLoop                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LoopWait                                  = GetBool(new IntPtr(p + 0x03D)); // 0245A5F96B18 0x3D LoopWait                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LiveCharacterController                   = GetObject<LiveCharacterController>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0245A5F96B38 0x40 LiveCharacterController     ( 000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.CameraController                          = GetObject<CameraController>(new IntPtr(p + 0x048), ReversePrism.DataModels.CameraController.FromPointer); // 0245A5F96B58 0x48 CameraController            ( 000186536460 ModelClassType CameraController CameraController CameraController Pointer )
            value.CamEvent                                  = GetObject<CameraWorkEvent>(new IntPtr(p + 0x050), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0245A5F96B78 0x50 CamEvent                    ( 0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x058), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0245A5F96B98 0x58 Timeline                    ( 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.SceneBgm                                  = GetObject<CriAtomSource>(new IntPtr(p + 0x060), ReversePrism.DataModels.CriAtomSource.FromPointer); // 0245A5F96BB8 0x60 SceneBgm                    ( 00018664CD30 ModelClassType CriAtomSource CriAtomSource CriAtomSource Pointer )
            value.CharacterTable                            = GetObjectList<Character>(new IntPtr(p + 0x068), ReversePrism.DataModels.Character.FromPointer); // 0245A5F96BD8 0x68 CharacterTable              ( 000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x070)); // 0245A5F96BF8 0x70 IsInitializeEnd             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsEndLoop                                 = GetBool(new IntPtr(p + 0x071)); // 0245A5F96C18 0x71 IsEndLoop                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x078), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0245A5F96C38 0x78 MoviePlayer                 ( 000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.IsBaseScene                               = GetBool(new IntPtr(p + 0x080)); // 0245A5F96C58 0x80 IsBaseScene                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNoSound                                 = GetBool(new IntPtr(p + 0x081)); // 0245A5F96C78 0x81 IsNoSound                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.VoiceList                                 = GetObjectList<VoiceRequest>(new IntPtr(p + 0x088), ReversePrism.DataModels.VoiceRequest.FromPointer); // 0245A5F96C98 0x88 VoiceList                   ( 000185D21448 ModelClassListType List`1<VoiceRequest> List`1<VoiceRequest> List<VoiceRequest> Pointer )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x090), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0245A5F96CB8 0x90 SoundResources              ( 000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.SwitchCahacter                            = GetObject<SwitchCharacter>(new IntPtr(p + 0x098), ReversePrism.DataModels.SwitchCharacter.FromPointer); // 0245A5F96CD8 0x98 SwitchCahacter              ( 00018656A0A0 ModelClassType SwitchCharacter SwitchCharacter SwitchCharacter Pointer )
            value.SwitchMovie                               = GetObject<SwitchMovie>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SwitchMovie.FromPointer); // 0245A5F96CF8 0xA0 SwitchMovie                 ( 00018656AAD0 ModelClassType SwitchMovie SwitchMovie SwitchMovie Pointer )
            value.AnimationFrame                            = GetSingle(new IntPtr(p + 0x0A8)); // 0245A5F96D18 0xA8 AnimationFrame              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentVoice                              = GetObject<VoiceRequest>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.VoiceRequest.FromPointer); // 0245A5F96D38 0xB0 CurrentVoice                ( 00018656B4B0 ModelClassType VoiceRequest VoiceRequest VoiceRequest Pointer )

            return value;
        }
    }
}
