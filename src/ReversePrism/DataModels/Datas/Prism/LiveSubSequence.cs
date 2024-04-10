using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LiveScene                                0001865771C0 ModelClassType LiveScene LiveScene LiveScene Pointer
    // 018 SequenceData                             00018676DD70 ModelClassType SequenceData SequenceData SequenceData Pointer
    // 020 PlayCutSceneData                         000185D19478 ModelClassListType IReadOnlyList`1<PlayCutSceneData> IReadOnlyList`1<PlayCutSceneData> List<PlayCutSceneData> Pointer
    // 000 postName                                 string IL2CPP_TYPE_STRING
    // 000 PrismSwimWearClothIDStart                int IL2CPP_TYPE_I4
    // 000 PrismSwimWearClothIDEnd                  int IL2CPP_TYPE_I4
    // 000 LiveSceneID                              int IL2CPP_TYPE_I4
    // 028 EffectPlayer                             0001867210F0 ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer
    // 030 TimelineController                       00018666EA20 ModelClassType TimelineController TimelineController TimelineController Pointer
    // 038 CutInstance                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 CamEvent                                 000185B72FE0 ModelClassListType CameraWorkEvent[] CameraWorkEvent[] List<CameraWorkEvent> Pointer
    // 048 CutScene                                 000185B78690 ModelClassListType CutScene[] CutScene[] List<CutScene> Pointer
    // 050 Characters                               000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer
    // 058 ScreenEffect                             0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 060 SoundResources                           000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 068 CurrentCS                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 06C LastCS                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 IsFade                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 074 SequenceFrame                            0001866656B0 ModelPrimitiveType float float float Single
    // 078 CamEventLive                             0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 080 LiveCharacterController                  000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 088 SubSequenceNode                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class LiveSubSequence : DataModel
    {
        public LiveScene?                               LiveScene                               { get; set; }
        public SequenceData?                            SequenceData                            { get; set; }
        public List<PlayCutSceneData>?                  PlayCutSceneData                        { get; set; }
        public EffectPlayer?                            EffectPlayer                            { get; set; }
        public TimelineController?                      TimelineController                      { get; set; }
        public List<GameObject>?                        CutInstance                             { get; set; }
        public List<CameraWorkEvent>?                   CamEvent                                { get; set; }
        public List<CutScene>?                          CutScene                                { get; set; }
        public List<Character>?                         Characters                              { get; set; }
        public ScreenEffectEx?                          ScreenEffect                            { get; set; }
        public MvCutSceneSoundResources?                SoundResources                          { get; set; }
        public int                                      CurrentCS                               { get; set; }
        public int                                      LastCS                                  { get; set; }
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

            value.LiveScene                                 = GetObject<LiveScene>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveScene.FromPointer); // 024664EA4FD0 0x10 LiveScene                   ( 0001865771C0 ModelClassType LiveScene LiveScene LiveScene Pointer )
            value.SequenceData                              = GetObject<SequenceData>(new IntPtr(p + 0x018), ReversePrism.DataModels.SequenceData.FromPointer); // 024664EA4FF0 0x18 SequenceData                ( 00018676DD70 ModelClassType SequenceData SequenceData SequenceData Pointer )
            value.PlayCutSceneData                          = GetObjectList<PlayCutSceneData>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlayCutSceneData.FromPointer); // 024664EA5010 0x20 PlayCutSceneData            ( 000185D19478 ModelClassListType IReadOnlyList`1<PlayCutSceneData> IReadOnlyList`1<PlayCutSceneData> List<PlayCutSceneData> Pointer )
            value.EffectPlayer                              = GetObject<EffectPlayer>(new IntPtr(p + 0x028), ReversePrism.DataModels.EffectPlayer.FromPointer); // 024664EA50B0 0x28 EffectPlayer                ( 0001867210F0 ModelClassType EffectPlayer EffectPlayer EffectPlayer Pointer )
            value.TimelineController                        = GetObject<TimelineController>(new IntPtr(p + 0x030), ReversePrism.DataModels.TimelineController.FromPointer); // 024664EA50D0 0x30 TimelineController          ( 00018666EA20 ModelClassType TimelineController TimelineController TimelineController Pointer )
            value.CutInstance                               = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 024664EA50F0 0x38 CutInstance                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CamEvent                                  = GetObjectList<CameraWorkEvent>(new IntPtr(p + 0x040), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 024664EA5110 0x40 CamEvent                    ( 000185B72FE0 ModelClassListType CameraWorkEvent[] CameraWorkEvent[] List<CameraWorkEvent> Pointer )
            value.CutScene                                  = GetObjectList<CutScene>(new IntPtr(p + 0x048), ReversePrism.DataModels.CutScene.FromPointer); // 024664EA5130 0x48 CutScene                    ( 000185B78690 ModelClassListType CutScene[] CutScene[] List<CutScene> Pointer )
            value.Characters                                = GetObjectList<Character>(new IntPtr(p + 0x050), ReversePrism.DataModels.Character.FromPointer); // 024664EA5150 0x50 Characters                  ( 000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 024664EA5170 0x58 ScreenEffect                ( 0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x060), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 024664EA5190 0x60 SoundResources              ( 000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.CurrentCS                                 = GetInt32(new IntPtr(p + 0x068)); // 024664EA51B0 0x68 CurrentCS                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastCS                                    = GetInt32(new IntPtr(p + 0x06C)); // 024664EA51D0 0x6C LastCS                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsFade                                    = GetBool(new IntPtr(p + 0x070)); // 024664EA51F0 0x70 IsFade                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SequenceFrame                             = GetSingle(new IntPtr(p + 0x074)); // 024664EA5210 0x74 SequenceFrame               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CamEventLive                              = GetObject<CameraWorkEvent>(new IntPtr(p + 0x078), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 024664EA5230 0x78 CamEventLive                ( 0001865398B0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.LiveCharacterController                   = GetObject<LiveCharacterController>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 024664EA5250 0x80 LiveCharacterController     ( 000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.SubSequenceNode                           = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 024664EA5270 0x88 SubSequenceNode             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x090), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024664EA5290 0x90 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
