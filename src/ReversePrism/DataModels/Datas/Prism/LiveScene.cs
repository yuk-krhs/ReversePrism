using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 LiveCanvas                               ModelClassType Canvas Canvas Canvas Pointer
    // 030 NameId                                   ModelPrimitiveType string string string String
    // 038 Camera                                   ModelClassType CameraController CameraController CameraController Pointer
    // 040 StageController                          ModelClassType StageController StageController StageController Pointer
    // 048 Characters                               ModelClassListType Character[] Character[] List<Character> Pointer
    // 050 TimelineController                       ModelClassType TimelineController TimelineController TimelineController Pointer
    // 058 AudienceController                       ModelClassType AudienceController AudienceController AudienceController Pointer
    // 060 LyricPanelCanvas                         ModelClassType Canvas Canvas Canvas Pointer
    // 068 CamEvent                                 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 070 CameraWorkDataList                       ModelClassListType List`1<CameraWorkData> List`1<CameraWorkData> List<CameraWorkData> Pointer
    // 078 IsManagerSetupCompleted                  ModelPrimitiveType bool bool bool Bool
    // 079 IsControlBySequencer                     ModelPrimitiveType bool bool bool Bool
    // 07A IsOldMv                                  ModelPrimitiveType bool bool bool Bool
    // 080 SoundResources                           ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 088 SceneCreateData                          ModelClassType Data Data Data Pointer
    // 090 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 098 CameraIndex                              ModelPrimitiveType int int int Int32
    // 09C ReflectionForceOn                        ModelPrimitiveType bool bool bool Bool
    // 09D AvoidSwayBoneShake                       ModelPrimitiveType bool bool bool Bool
    // 0A0 AmbientLightColor                        ModelEnumType Color Color Color Int32
    // 0B0 LiveStartData                            ModelClassType LiveStartData LiveStartData LiveStartData Pointer
    // 0B8 LiveMVStartData                          ModelClassType LiveMVStartData LiveMVStartData LiveMVStartData Pointer
    // 0C0 TypeExtention                            ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0C8 IsInitializeEnd                          ModelPrimitiveType bool bool bool Bool
    // 0C9 IsReceivedParameter                      ModelPrimitiveType bool bool bool Bool
    // 000 isPreLoadEnd                             bool IL2CPP_TYPE_BOOLEAN
    // 0D0 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0D8 ProgressManager                          ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer
    // 0E0 AudienceColors                           ModelEnumListType Color[] Color[] List<Color> Pointer
    // 0E8 PlaySeSubject                            Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 0F0 OptionLocalSave                          ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer
    // 0F8 LiveSubSequence                          ModelClassType LiveSubSequence LiveSubSequence LiveSubSequence Pointer
    // 008 preloadUnitIdol                          UnitIdol[] IL2CPP_TYPE_SZARRAY
    // 100 LastFrame                                ModelPrimitiveType float float float Single
    public partial class LiveScene : DataModel
    {
        public Canvas?                                  LiveCanvas                              { get; set; }
        public string                                   NameId                                  { get; set; }
        public CameraController?                        Camera                                  { get; set; }
        public StageController?                         StageController                         { get; set; }
        public List<Character>?                         Characters                              { get; set; }
        public TimelineController?                      TimelineController                      { get; set; }
        public AudienceController?                      AudienceController                      { get; set; }
        public Canvas?                                  LyricPanelCanvas                        { get; set; }
        public CameraWorkEvent?                         CamEvent                                { get; set; }
        public List<CameraWorkData>?                    CameraWorkDataList                      { get; set; }
        public bool                                     IsManagerSetupCompleted                 { get; set; }
        public bool                                     IsControlBySequencer                    { get; set; }
        public bool                                     IsOldMv                                 { get; set; }
        public MvCutSceneSoundResources?                SoundResources                          { get; set; }
        public Data?                                    SceneCreateData                         { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public int                                      CameraIndex                             { get; set; }
        public bool                                     ReflectionForceOn                       { get; set; }
        public bool                                     AvoidSwayBoneShake                      { get; set; }
        public Color                                    AmbientLightColor                       { get; set; }
        public LiveStartData?                           LiveStartData                           { get; set; }
        public LiveMVStartData?                         LiveMVStartData                         { get; set; }
        public List<string>?                            TypeExtention                           { get; set; }
        public bool                                     IsInitializeEnd                         { get; set; }
        public bool                                     IsReceivedParameter                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public LiveProgressManager?                     ProgressManager                         { get; set; }
        public List<Color>?                             AudienceColors                          { get; set; }
        public OptionLocalSave?                         OptionLocalSave                         { get; set; }
        public LiveSubSequence?                         LiveSubSequence                         { get; set; }
        public float                                    LastFrame                               { get; set; }

        public static LiveScene? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveScene() { Pointer= p0 };

            value.LiveCanvas                                = GetObject<Canvas>(new IntPtr(p + 0x028), ReversePrism.DataModels.Canvas.FromPointer); // 0x28 LiveCanvas                  ( ModelClassType Canvas Canvas Canvas Pointer )
            value.NameId                                    = GetString(new IntPtr(p + 0x030)); // 0x30 NameId                      ( ModelPrimitiveType string string string String )
            value.Camera                                    = GetObject<CameraController>(new IntPtr(p + 0x038), ReversePrism.DataModels.CameraController.FromPointer); // 0x38 Camera                      ( ModelClassType CameraController CameraController CameraController Pointer )
            value.StageController                           = GetObject<StageController>(new IntPtr(p + 0x040), ReversePrism.DataModels.StageController.FromPointer); // 0x40 StageController             ( ModelClassType StageController StageController StageController Pointer )
            value.Characters                                = GetObjectList<Character>(new IntPtr(p + 0x048), ReversePrism.DataModels.Character.FromPointer); // 0x48 Characters                  ( ModelClassListType Character[] Character[] List<Character> Pointer )
            value.TimelineController                        = GetObject<TimelineController>(new IntPtr(p + 0x050), ReversePrism.DataModels.TimelineController.FromPointer); // 0x50 TimelineController          ( ModelClassType TimelineController TimelineController TimelineController Pointer )
            value.AudienceController                        = GetObject<AudienceController>(new IntPtr(p + 0x058), ReversePrism.DataModels.AudienceController.FromPointer); // 0x58 AudienceController          ( ModelClassType AudienceController AudienceController AudienceController Pointer )
            value.LyricPanelCanvas                          = GetObject<Canvas>(new IntPtr(p + 0x060), ReversePrism.DataModels.Canvas.FromPointer); // 0x60 LyricPanelCanvas            ( ModelClassType Canvas Canvas Canvas Pointer )
            value.CamEvent                                  = GetObject<CameraWorkEvent>(new IntPtr(p + 0x068), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0x68 CamEvent                    ( ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.CameraWorkDataList                        = GetObjectList<CameraWorkData>(new IntPtr(p + 0x070), ReversePrism.DataModels.CameraWorkData.FromPointer); // 0x70 CameraWorkDataList          ( ModelClassListType List`1<CameraWorkData> List`1<CameraWorkData> List<CameraWorkData> Pointer )
            value.IsManagerSetupCompleted                   = GetBool(new IntPtr(p + 0x078)); // 0x78 IsManagerSetupCompleted     ( ModelPrimitiveType bool bool bool Bool )
            value.IsControlBySequencer                      = GetBool(new IntPtr(p + 0x079)); // 0x79 IsControlBySequencer        ( ModelPrimitiveType bool bool bool Bool )
            value.IsOldMv                                   = GetBool(new IntPtr(p + 0x07A)); // 0x7A IsOldMv                     ( ModelPrimitiveType bool bool bool Bool )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x080), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0x80 SoundResources              ( ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.SceneCreateData                           = GetObject<Data>(new IntPtr(p + 0x088), ReversePrism.DataModels.Data.FromPointer); // 0x88 SceneCreateData             ( ModelClassType Data Data Data Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x090), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x90 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.CameraIndex                               = GetInt32(new IntPtr(p + 0x098)); // 0x98 CameraIndex                 ( ModelPrimitiveType int int int Int32 )
            value.ReflectionForceOn                         = GetBool(new IntPtr(p + 0x09C)); // 0x9C ReflectionForceOn           ( ModelPrimitiveType bool bool bool Bool )
            value.AvoidSwayBoneShake                        = GetBool(new IntPtr(p + 0x09D)); // 0x9D AvoidSwayBoneShake          ( ModelPrimitiveType bool bool bool Bool )
            value.AmbientLightColor                         = (Color)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 AmbientLightColor           ( ModelEnumType Color Color Color Int32 )
            value.LiveStartData                             = GetObject<LiveStartData>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LiveStartData.FromPointer); // 0xB0 LiveStartData               ( ModelClassType LiveStartData LiveStartData LiveStartData Pointer )
            value.LiveMVStartData                           = GetObject<LiveMVStartData>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.LiveMVStartData.FromPointer); // 0xB8 LiveMVStartData             ( ModelClassType LiveMVStartData LiveMVStartData LiveMVStartData Pointer )
            value.TypeExtention                             = GetStringList(new IntPtr(p + 0x0C0)); // 0xC0 TypeExtention               ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 IsInitializeEnd             ( ModelPrimitiveType bool bool bool Bool )
            value.IsReceivedParameter                       = GetBool(new IntPtr(p + 0x0C9)); // 0xC9 IsReceivedParameter         ( ModelPrimitiveType bool bool bool Bool )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0xD0 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ProgressManager                           = GetObject<LiveProgressManager>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.LiveProgressManager.FromPointer); // 0xD8 ProgressManager             ( ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer )
            value.AudienceColors                            = GetEnumList<Color>(new IntPtr(p + 0x0E0)); // 0xE0 AudienceColors              ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.OptionLocalSave                           = GetObject<OptionLocalSave>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.OptionLocalSave.FromPointer); // 0xF0 OptionLocalSave             ( ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer )
            value.LiveSubSequence                           = GetObject<LiveSubSequence>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.LiveSubSequence.FromPointer); // 0xF8 LiveSubSequence             ( ModelClassType LiveSubSequence LiveSubSequence LiveSubSequence Pointer )
            value.LastFrame                                 = GetSingle(new IntPtr(p + 0x100)); // 0x100 LastFrame                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
