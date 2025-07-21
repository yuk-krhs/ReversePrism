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
    // 030 LiveCharacterController                  ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 000 AuditionCueSuffix                        string IL2CPP_TYPE_STRING
    // 000 fadeOutTime                              float IL2CPP_TYPE_R4
    // 038 Playback                                 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 040 CharacterParent                          ModelClassType GameObject GameObject GameObject Pointer
    // 048 Bg                                       ModelClassType GameObject GameObject GameObject Pointer
    // 050 Timeline                                 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 058 IsExistTimeline                          ModelPrimitiveType bool bool bool Bool
    // 060 Character                                ModelClassListType Character[] Character[] List<Character> Pointer
    // 068 MirrorChara                              ModelClassListType Character[] Character[] List<Character> Pointer
    // 070 ScreenEffect                             ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 000 baseSceneData                            StartData IL2CPP_TYPE_CLASS
    // 078 IsInitializeEnd                          ModelPrimitiveType bool bool bool Bool
    // 008 preloadedList                            List`1<StartData> IL2CPP_TYPE_GENERICINST
    // 07C AnimationFrame                           ModelPrimitiveType float float float Single
    // 080 FadeCountTime                            ModelPrimitiveType float float float Single
    // 084 IsEnd                                    ModelPrimitiveType bool bool bool Bool
    // 085 IsPause                                  ModelPrimitiveType bool bool bool Bool
    // 088 CamEvent                                 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 090 IsExistCamEvent                          ModelPrimitiveType bool bool bool Bool
    // 091 IsClearClothListOnDestroy                ModelPrimitiveType bool bool bool Bool
    // 098 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0A0 CueSheetLoaded                           ModelPrimitiveType string string string String
    // 010 DressList                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    public partial class LessonAudition : DataModel
    {
        public Data?                                    SceneCreateData                         { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public LiveCharacterController?                 LiveCharacterController                 { get; set; }
        public CriAtomExPlayback                        Playback                                { get; set; }
        public GameObject?                              CharacterParent                         { get; set; }
        public GameObject?                              Bg                                      { get; set; }
        public PlayableDirector?                        Timeline                                { get; set; }
        public bool                                     IsExistTimeline                         { get; set; }
        public List<Character>?                         Character                               { get; set; }
        public List<Character>?                         MirrorChara                             { get; set; }
        public ScreenEffectEx?                          ScreenEffect                            { get; set; }
        public bool                                     IsInitializeEnd                         { get; set; }
        public float                                    AnimationFrame                          { get; set; }
        public float                                    FadeCountTime                           { get; set; }
        public bool                                     IsEnd                                   { get; set; }
        public bool                                     IsPause                                 { get; set; }
        public CameraWorkEvent?                         CamEvent                                { get; set; }
        public bool                                     IsExistCamEvent                         { get; set; }
        public bool                                     IsClearClothListOnDestroy               { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public string                                   CueSheetLoaded                          { get; set; }
        public List<UnitIdol>?                          DressList                               { get; set; }

        public static LessonAudition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonAudition() { Pointer= p0 };

            value.SceneCreateData                           = GetObject<Data>(new IntPtr(p + 0x020), ReversePrism.DataModels.Data.FromPointer); // 0x20 SceneCreateData             ( ModelClassType Data Data Data Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x28 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.LiveCharacterController                   = GetObject<LiveCharacterController>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0x30 LiveCharacterController     ( ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.Playback                                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x038)); // 0x38 Playback                    ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.CharacterParent                           = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 CharacterParent             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Bg                                        = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 Bg                          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x050), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x50 Timeline                    ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.IsExistTimeline                           = GetBool(new IntPtr(p + 0x058)); // 0x58 IsExistTimeline             ( ModelPrimitiveType bool bool bool Bool )
            value.Character                                 = GetObjectList<Character>(new IntPtr(p + 0x060), ReversePrism.DataModels.Character.FromPointer); // 0x60 Character                   ( ModelClassListType Character[] Character[] List<Character> Pointer )
            value.MirrorChara                               = GetObjectList<Character>(new IntPtr(p + 0x068), ReversePrism.DataModels.Character.FromPointer); // 0x68 MirrorChara                 ( ModelClassListType Character[] Character[] List<Character> Pointer )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x070), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0x70 ScreenEffect                ( ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x078)); // 0x78 IsInitializeEnd             ( ModelPrimitiveType bool bool bool Bool )
            value.AnimationFrame                            = GetSingle(new IntPtr(p + 0x07C)); // 0x7C AnimationFrame              ( ModelPrimitiveType float float float Single )
            value.FadeCountTime                             = GetSingle(new IntPtr(p + 0x080)); // 0x80 FadeCountTime               ( ModelPrimitiveType float float float Single )
            value.IsEnd                                     = GetBool(new IntPtr(p + 0x084)); // 0x84 IsEnd                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x085)); // 0x85 IsPause                     ( ModelPrimitiveType bool bool bool Bool )
            value.CamEvent                                  = GetObject<CameraWorkEvent>(new IntPtr(p + 0x088), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0x88 CamEvent                    ( ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.IsExistCamEvent                           = GetBool(new IntPtr(p + 0x090)); // 0x90 IsExistCamEvent             ( ModelPrimitiveType bool bool bool Bool )
            value.IsClearClothListOnDestroy                 = GetBool(new IntPtr(p + 0x091)); // 0x91 IsClearClothListOnDestroy   ( ModelPrimitiveType bool bool bool Bool )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x098), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x98 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CueSheetLoaded                            = GetString(new IntPtr(p + 0x0A0)); // 0xA0 CueSheetLoaded              ( ModelPrimitiveType string string string String )
            value.DressList                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x10 DressList                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
