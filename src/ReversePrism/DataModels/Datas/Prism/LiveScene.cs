using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 LiveCanvas                               00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 030 DebugCamera                              0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 038 DebugUI                                  000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 NameId                                   000186671910 ModelPrimitiveType string string string String
    // 048 Camera                                   000186536460 ModelClassType CameraController CameraController CameraController Pointer
    // 050 StageController                          000186562560 ModelClassType StageController StageController StageController Pointer
    // 058 Characters                               000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer
    // 060 TimelineController                       00018666EA20 ModelClassType TimelineController TimelineController TimelineController Pointer
    // 068 AudienceController                       000186715720 ModelClassType AudienceController AudienceController AudienceController Pointer
    // 070 LyricPanelCanvas                         00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 078 CamEvent                                 000186539DD0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 080 CameraWorkDataList                       000185D20578 ModelClassListType List`1<CameraWorkData> List`1<CameraWorkData> List<CameraWorkData> Pointer
    // 088 IsManagerSetupCompleted                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 089 IsControlBySequencer                     000186597BE0 ModelPrimitiveType bool bool bool Bool
    // 08A IsOldMv                                  000186597BE0 ModelPrimitiveType bool bool bool Bool
    // 090 SoundResources                           000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 098 SceneCreateData                          000186710490 ModelClassType Data Data Data Pointer
    // 0A0 UnitIdols                                000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 0A8 CameraIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0AC ReflectionForceOn                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0AD AvoidSwayBoneShake                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B0 AmbientLightColor                        0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0C0 LiveStartData                            000186581BE0 ModelClassType LiveStartData LiveStartData LiveStartData Pointer
    // 0C8 LiveMVStartData                          00018655CF60 ModelClassType LiveMVStartData LiveMVStartData LiveMVStartData Pointer
    // 0D0 TypeExtention                            000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0D8 IsInitializeEnd                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D9 IsReceivedParameter                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 isPreLoadEnd                             bool IL2CPP_TYPE_BOOLEAN
    // 0E0 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0E8 ProgressManager                          000186569620 ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer
    // 0F0 AudienceColors                           000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    // 0F8 PlaySeSubject                            Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 100 OptionLocalSave                          0001866E6E30 ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer
    // 108 LiveSubSequence                          000186584630 ModelClassType LiveSubSequence LiveSubSequence LiveSubSequence Pointer
    // 008 preloadUnitIdol                          UnitIdol[] IL2CPP_TYPE_SZARRAY
    // 110 LastFrame                                0001866656B0 ModelPrimitiveType float float float Single
    public partial class LiveScene
    {
        public Canvas?                                  LiveCanvas                              { get; set; }
        public Camera?                                  DebugCamera                             { get; set; }
        public RectTransform?                           DebugUI                                 { get; set; }
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
            var value   = new LiveScene();

            value.LiveCanvas                                = GetObject<Canvas>(new IntPtr(p + 0x028), ReversePrism.DataModels.Canvas.FromPointer); // 027006A73A30 0x28 LiveCanvas                  ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.DebugCamera                               = GetObject<Camera>(new IntPtr(p + 0x030), ReversePrism.DataModels.Camera.FromPointer); // 027006A73A50 0x30 DebugCamera                 ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.DebugUI                                   = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 027006A73A70 0x38 DebugUI                     ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.NameId                                    = GetString(new IntPtr(p + 0x040)); // 027006A73A90 0x40 NameId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Camera                                    = GetObject<CameraController>(new IntPtr(p + 0x048), ReversePrism.DataModels.CameraController.FromPointer); // 027006A73AB0 0x48 Camera                      ( 000186536460 ModelClassType CameraController CameraController CameraController Pointer )
            value.StageController                           = GetObject<StageController>(new IntPtr(p + 0x050), ReversePrism.DataModels.StageController.FromPointer); // 027006A73AD0 0x50 StageController             ( 000186562560 ModelClassType StageController StageController StageController Pointer )
            value.Characters                                = GetObjectList<Character>(new IntPtr(p + 0x058), ReversePrism.DataModels.Character.FromPointer); // 027006A73AF0 0x58 Characters                  ( 000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer )
            value.TimelineController                        = GetObject<TimelineController>(new IntPtr(p + 0x060), ReversePrism.DataModels.TimelineController.FromPointer); // 027006A73B10 0x60 TimelineController          ( 00018666EA20 ModelClassType TimelineController TimelineController TimelineController Pointer )
            value.AudienceController                        = GetObject<AudienceController>(new IntPtr(p + 0x068), ReversePrism.DataModels.AudienceController.FromPointer); // 027006A73B30 0x68 AudienceController          ( 000186715720 ModelClassType AudienceController AudienceController AudienceController Pointer )
            value.LyricPanelCanvas                          = GetObject<Canvas>(new IntPtr(p + 0x070), ReversePrism.DataModels.Canvas.FromPointer); // 027006A73B50 0x70 LyricPanelCanvas            ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.CamEvent                                  = GetObject<CameraWorkEvent>(new IntPtr(p + 0x078), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 027006A73B70 0x78 CamEvent                    ( 000186539DD0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.CameraWorkDataList                        = GetObjectList<CameraWorkData>(new IntPtr(p + 0x080), ReversePrism.DataModels.CameraWorkData.FromPointer); // 027006A73B90 0x80 CameraWorkDataList          ( 000185D20578 ModelClassListType List`1<CameraWorkData> List`1<CameraWorkData> List<CameraWorkData> Pointer )
            value.IsManagerSetupCompleted                   = GetBool(new IntPtr(p + 0x088)); // 027006A73BB0 0x88 IsManagerSetupCompleted     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsControlBySequencer                      = GetBool(new IntPtr(p + 0x089)); // 027006A73BD0 0x89 IsControlBySequencer        ( 000186597BE0 ModelPrimitiveType bool bool bool Bool )
            value.IsOldMv                                   = GetBool(new IntPtr(p + 0x08A)); // 027006A73BF0 0x8A IsOldMv                     ( 000186597BE0 ModelPrimitiveType bool bool bool Bool )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x090), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 027006A73C10 0x90 SoundResources              ( 000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.SceneCreateData                           = GetObject<Data>(new IntPtr(p + 0x098), ReversePrism.DataModels.Data.FromPointer); // 027006A73C30 0x98 SceneCreateData             ( 000186710490 ModelClassType Data Data Data Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UnitIdol.FromPointer); // 027006A73C50 0xA0 UnitIdols                   ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.CameraIndex                               = GetInt32(new IntPtr(p + 0x0A8)); // 027006A73C70 0xA8 CameraIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReflectionForceOn                         = GetBool(new IntPtr(p + 0x0AC)); // 027006A73C90 0xAC ReflectionForceOn           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AvoidSwayBoneShake                        = GetBool(new IntPtr(p + 0x0AD)); // 027006A73CB0 0xAD AvoidSwayBoneShake          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AmbientLightColor                         = (Color)GetInt32(new IntPtr(p + 0x0B0)); // 027006A73CD0 0xB0 AmbientLightColor           ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.LiveStartData                             = GetObject<LiveStartData>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.LiveStartData.FromPointer); // 027006A73CF0 0xC0 LiveStartData               ( 000186581BE0 ModelClassType LiveStartData LiveStartData LiveStartData Pointer )
            value.LiveMVStartData                           = GetObject<LiveMVStartData>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.LiveMVStartData.FromPointer); // 027006A73D10 0xC8 LiveMVStartData             ( 00018655CF60 ModelClassType LiveMVStartData LiveMVStartData LiveMVStartData Pointer )
            value.TypeExtention                             = GetStringList(new IntPtr(p + 0x0D0)); // 027006A73D30 0xD0 TypeExtention               ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x0D8)); // 027006A73D50 0xD8 IsInitializeEnd             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReceivedParameter                       = GetBool(new IntPtr(p + 0x0D9)); // 027006A73D70 0xD9 IsReceivedParameter         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 027006A73DB0 0xE0 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ProgressManager                           = GetObject<LiveProgressManager>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.LiveProgressManager.FromPointer); // 027006A73DD0 0xE8 ProgressManager             ( 000186569620 ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer )
            value.AudienceColors                            = GetEnumList<Color>(new IntPtr(p + 0x0F0)); // 027006A73DF0 0xF0 AudienceColors              ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.OptionLocalSave                           = GetObject<OptionLocalSave>(new IntPtr(p + 0x100), ReversePrism.DataModels.OptionLocalSave.FromPointer); // 027006A73E30 0x100 OptionLocalSave             ( 0001866E6E30 ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer )
            value.LiveSubSequence                           = GetObject<LiveSubSequence>(new IntPtr(p + 0x108), ReversePrism.DataModels.LiveSubSequence.FromPointer); // 027006A73E50 0x108 LiveSubSequence             ( 000186584630 ModelClassType LiveSubSequence LiveSubSequence LiveSubSequence Pointer )
            value.LastFrame                                 = GetSingle(new IntPtr(p + 0x110)); // 027006A73E90 0x110 LastFrame                   ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
