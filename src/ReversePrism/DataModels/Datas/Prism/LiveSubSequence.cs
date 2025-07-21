using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LiveScene                                ModelClassType LiveScene LiveScene LiveScene Pointer
    // 018 PlayCutSceneData                         ModelClassListType IReadOnlyList`1<PlayCutSceneData> IReadOnlyList`1<PlayCutSceneData> List<PlayCutSceneData> Pointer
    // 000 LiveSceneID                              int IL2CPP_TYPE_I4
    // 020 EffectPlayer                             ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer
    // 028 TimelineController                       ModelClassType TimelineController TimelineController TimelineController Pointer
    // 030 CutInstance                              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 CamEvent                                 ModelClassListType CameraWorkEvent[] CameraWorkEvent[] List<CameraWorkEvent> Pointer
    // 040 CutScene                                 ModelClassListType CutScene[] CutScene[] List<CutScene> Pointer
    // 048 Characters                               ModelClassListType Character[] Character[] List<Character> Pointer
    // 050 ScreenEffect                             ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 058 SoundResources                           ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 060 CurrentCutSceneId                        ModelPrimitiveType int int int Int32
    // 064 PrevFrameCutSceneId                      ModelPrimitiveType int int int Int32
    // 068 IsFade                                   ModelPrimitiveType bool bool bool Bool
    // 06C SequenceFrame                            ModelPrimitiveType float float float Single
    // 070 CamEventLive                             ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 078 LiveCharacterController                  ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 080 SubSequenceNode                          ModelClassType GameObject GameObject GameObject Pointer
    // 088 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class LiveSubSequence : DataModel
    {
        public LiveScene?                               LiveScene                               { get; set; }
        public List<PlayCutSceneData>?                  PlayCutSceneData                        { get; set; }
        public EffectPlayer?                            EffectPlayer                            { get; set; }
        public TimelineController?                      TimelineController                      { get; set; }
        public List<GameObject>?                        CutInstance                             { get; set; }
        public List<CameraWorkEvent>?                   CamEvent                                { get; set; }
        public List<CutScene>?                          CutScene                                { get; set; }
        public List<Character>?                         Characters                              { get; set; }
        public ScreenEffectEx?                          ScreenEffect                            { get; set; }
        public MvCutSceneSoundResources?                SoundResources                          { get; set; }
        public int                                      CurrentCutSceneId                       { get; set; }
        public int                                      PrevFrameCutSceneId                     { get; set; }
        public bool                                     IsFade                                  { get; set; }
        public float                                    SequenceFrame                           { get; set; }
        public CameraWorkEvent?                         CamEventLive                            { get; set; }
        public LiveCharacterController?                 LiveCharacterController                 { get; set; }
        public GameObject?                              SubSequenceNode                         { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static LiveSubSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSubSequence() { Pointer= p0 };

            value.LiveScene                                 = GetObject<LiveScene>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveScene.FromPointer); // 0x10 LiveScene                   ( ModelClassType LiveScene LiveScene LiveScene Pointer )
            value.PlayCutSceneData                          = GetObjectList<PlayCutSceneData>(new IntPtr(p + 0x018), ReversePrism.DataModels.PlayCutSceneData.FromPointer); // 0x18 PlayCutSceneData            ( ModelClassListType IReadOnlyList`1<PlayCutSceneData> IReadOnlyList`1<PlayCutSceneData> List<PlayCutSceneData> Pointer )
            value.EffectPlayer                              = GetObject<EffectPlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.EffectPlayer.FromPointer); // 0x20 EffectPlayer                ( ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer )
            value.TimelineController                        = GetObject<TimelineController>(new IntPtr(p + 0x028), ReversePrism.DataModels.TimelineController.FromPointer); // 0x28 TimelineController          ( ModelClassType TimelineController TimelineController TimelineController Pointer )
            value.CutInstance                               = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 CutInstance                 ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CamEvent                                  = GetObjectList<CameraWorkEvent>(new IntPtr(p + 0x038), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0x38 CamEvent                    ( ModelClassListType CameraWorkEvent[] CameraWorkEvent[] List<CameraWorkEvent> Pointer )
            value.CutScene                                  = GetObjectList<CutScene>(new IntPtr(p + 0x040), ReversePrism.DataModels.CutScene.FromPointer); // 0x40 CutScene                    ( ModelClassListType CutScene[] CutScene[] List<CutScene> Pointer )
            value.Characters                                = GetObjectList<Character>(new IntPtr(p + 0x048), ReversePrism.DataModels.Character.FromPointer); // 0x48 Characters                  ( ModelClassListType Character[] Character[] List<Character> Pointer )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x050), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0x50 ScreenEffect                ( ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x058), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0x58 SoundResources              ( ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.CurrentCutSceneId                         = GetInt32(new IntPtr(p + 0x060)); // 0x60 CurrentCutSceneId           ( ModelPrimitiveType int int int Int32 )
            value.PrevFrameCutSceneId                       = GetInt32(new IntPtr(p + 0x064)); // 0x64 PrevFrameCutSceneId         ( ModelPrimitiveType int int int Int32 )
            value.IsFade                                    = GetBool(new IntPtr(p + 0x068)); // 0x68 IsFade                      ( ModelPrimitiveType bool bool bool Bool )
            value.SequenceFrame                             = GetSingle(new IntPtr(p + 0x06C)); // 0x6C SequenceFrame               ( ModelPrimitiveType float float float Single )
            value.CamEventLive                              = GetObject<CameraWorkEvent>(new IntPtr(p + 0x070), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0x70 CamEventLive                ( ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.LiveCharacterController                   = GetObject<LiveCharacterController>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0x78 LiveCharacterController     ( ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.SubSequenceNode                           = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 SubSequenceNode             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x88 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
