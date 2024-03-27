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
    // 030 LiveCharacterController                  000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 000 AuditionCueSuffix                        string IL2CPP_TYPE_STRING
    // 000 fadeOutTime                              float IL2CPP_TYPE_R4
    // 038 Playback                                 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 040 CharacterParent                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 Bg                                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 Character                                000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer
    // 058 MirrorChara                              000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer
    // 060 ScreenEffect                             0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 000 baseSceneData                            StartData IL2CPP_TYPE_CLASS
    // 068 IsInitializeEnd                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 008 preloadedList                            List`1<StartData> IL2CPP_TYPE_GENERICINST
    // 06C AnimationFrame                           0001866656B0 ModelPrimitiveType float float float Single
    // 070 FadeCountTime                            0001866656B0 ModelPrimitiveType float float float Single
    // 074 IsEnd                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 075 IsPause                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 CamEvent                                 0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 080 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 088 CueSheetLoaded                           000186671910 ModelPrimitiveType string string string String
    // 010 DressList                                000185CAF388 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    public partial class LessonAudition
    {
        public Data?                                    SceneCreateData                         { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public LiveCharacterController?                 LiveCharacterController                 { get; set; }
        public CriAtomExPlayback                        Playback                                { get; set; }
        public GameObject?                              CharacterParent                         { get; set; }
        public GameObject?                              Bg                                      { get; set; }
        public List<Character>?                         Character                               { get; set; }
        public List<Character>?                         MirrorChara                             { get; set; }
        public ScreenEffectEx?                          ScreenEffect                            { get; set; }
        public bool                                     IsInitializeEnd                         { get; set; }
        public float                                    AnimationFrame                          { get; set; }
        public float                                    FadeCountTime                           { get; set; }
        public bool                                     IsEnd                                   { get; set; }
        public bool                                     IsPause                                 { get; set; }
        public CameraWorkEvent?                         CamEvent                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public string                                   CueSheetLoaded                          { get; set; }
        public List<UnitIdol>?                          DressList                               { get; set; }

        public static LessonAudition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonAudition();

            value.SceneCreateData                           = GetObject<Data>(new IntPtr(p + 0x020), ReversePrism.DataModels.Data.FromPointer); // 0270D4D9B160 0x20 SceneCreateData             ( 000186710490 ModelClassType Data Data Data Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D4D9B180 0x28 UnitIdols                   ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.LiveCharacterController                   = GetObject<LiveCharacterController>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0270D4D9B1A0 0x30 LiveCharacterController     ( 000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.Playback                                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x038)); // 0270D4D9B200 0x38 Playback                    ( 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.CharacterParent                           = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D9B220 0x40 CharacterParent             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Bg                                        = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D9B240 0x48 Bg                          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Character                                 = GetObjectList<Character>(new IntPtr(p + 0x050), ReversePrism.DataModels.Character.FromPointer); // 0270D4D9B260 0x50 Character                   ( 000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer )
            value.MirrorChara                               = GetObjectList<Character>(new IntPtr(p + 0x058), ReversePrism.DataModels.Character.FromPointer); // 0270D4D9B280 0x58 MirrorChara                 ( 000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x060), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0270D4D9B2A0 0x60 ScreenEffect                ( 0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x068)); // 0270D4D9B2E0 0x68 IsInitializeEnd             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AnimationFrame                            = GetSingle(new IntPtr(p + 0x06C)); // 0270D4D9B320 0x6C AnimationFrame              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.FadeCountTime                             = GetSingle(new IntPtr(p + 0x070)); // 0270D4D9B340 0x70 FadeCountTime               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsEnd                                     = GetBool(new IntPtr(p + 0x074)); // 0270D4D9B360 0x74 IsEnd                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x075)); // 0270D4D9B380 0x75 IsPause                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CamEvent                                  = GetObject<CameraWorkEvent>(new IntPtr(p + 0x078), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0270D4D9B3A0 0x78 CamEvent                    ( 0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D4D9B3C0 0x80 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CueSheetLoaded                            = GetString(new IntPtr(p + 0x088)); // 0270D4D9B3E0 0x88 CueSheetLoaded              ( 000186671910 ModelPrimitiveType string string string String )
            value.DressList                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D4D9B400 0x10 DressList                   ( 000185CAF388 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
