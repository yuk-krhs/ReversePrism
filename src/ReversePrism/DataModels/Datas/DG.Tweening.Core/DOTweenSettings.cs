using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetName                                string IL2CPP_TYPE_STRING
    // 000 AssetFullFilename                        string IL2CPP_TYPE_STRING
    // 018 UseSafeMode                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 020 SafeModeOptions                          000186576AE0 ModelClassType SafeModeOptions SafeModeOptions SafeModeOptions Pointer
    // 028 TimeScale                                000186666050 ModelPrimitiveType float float float Single
    // 02C UseSmoothDeltaTime                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 030 MaxSmoothUnscaledTime                    000186666050 ModelPrimitiveType float float float Single
    // 034 RewindCallbackMode                       000186681060 ModelEnumType RewindCallbackMode RewindCallbackMode RewindCallbackMode Int32
    // 038 ShowUnityEditorReport                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 03C LogBehaviour                             0001865ABE70 ModelEnumType LogBehaviour LogBehaviour LogBehaviour Int32
    // 040 DrawGizmos                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 041 DefaultRecyclable                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 044 DefaultAutoPlay                          0001867283F0 ModelEnumType AutoPlay AutoPlay AutoPlay Int32
    // 048 DefaultUpdateType                        000186742360 ModelEnumType UpdateType UpdateType UpdateType Int32
    // 04C DefaultTimeScaleIndependent              000186595960 ModelPrimitiveType bool bool bool Bool
    // 050 DefaultEaseType                          000186717150 ModelEnumType Ease Ease Ease Int32
    // 054 DefaultEaseOvershootOrAmplitude          000186666050 ModelPrimitiveType float float float Single
    // 058 DefaultEasePeriod                        000186666050 ModelPrimitiveType float float float Single
    // 05C DefaultAutoKill                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 060 DefaultLoopType                          0001865C0BF0 ModelEnumType LoopType LoopType LoopType Int32
    // 064 DebugMode                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 065 DebugStoreTargetId                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 066 ShowPreviewPanel                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 068 StoreSettingsLocation                    000186576FC0 ModelEnumType SettingsLocation SettingsLocation SettingsLocation Int32
    // 070 Modules                                  000186576600 ModelClassType ModulesSetup ModulesSetup ModulesSetup Pointer
    // 078 ShowPlayingTweens                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 079 ShowPausedTweens                         000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class DOTweenSettings
    {
        public bool                                     UseSafeMode                             { get; set; }
        public SafeModeOptions?                         SafeModeOptions                         { get; set; }
        public float                                    TimeScale                               { get; set; }
        public bool                                     UseSmoothDeltaTime                      { get; set; }
        public float                                    MaxSmoothUnscaledTime                   { get; set; }
        public RewindCallbackMode                       RewindCallbackMode                      { get; set; }
        public bool                                     ShowUnityEditorReport                   { get; set; }
        public LogBehaviour                             LogBehaviour                            { get; set; }
        public bool                                     DrawGizmos                              { get; set; }
        public bool                                     DefaultRecyclable                       { get; set; }
        public AutoPlay                                 DefaultAutoPlay                         { get; set; }
        public UpdateType                               DefaultUpdateType                       { get; set; }
        public bool                                     DefaultTimeScaleIndependent             { get; set; }
        public Ease                                     DefaultEaseType                         { get; set; }
        public float                                    DefaultEaseOvershootOrAmplitude         { get; set; }
        public float                                    DefaultEasePeriod                       { get; set; }
        public bool                                     DefaultAutoKill                         { get; set; }
        public LoopType                                 DefaultLoopType                         { get; set; }
        public bool                                     DebugMode                               { get; set; }
        public bool                                     DebugStoreTargetId                      { get; set; }
        public bool                                     ShowPreviewPanel                        { get; set; }
        public SettingsLocation                         StoreSettingsLocation                   { get; set; }
        public ModulesSetup?                            Modules                                 { get; set; }
        public bool                                     ShowPlayingTweens                       { get; set; }
        public bool                                     ShowPausedTweens                        { get; set; }

        public static DOTweenSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DOTweenSettings();

            value.UseSafeMode                               = GetBool(new IntPtr(p + 0x018)); // 027004348C50 0x18 UseSafeMode                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SafeModeOptions                           = GetObject<SafeModeOptions>(new IntPtr(p + 0x020), ReversePrism.DataModels.SafeModeOptions.FromPointer); // 027004348C70 0x20 SafeModeOptions             ( 000186576AE0 ModelClassType SafeModeOptions SafeModeOptions SafeModeOptions Pointer )
            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x028)); // 027004348C90 0x28 TimeScale                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.UseSmoothDeltaTime                        = GetBool(new IntPtr(p + 0x02C)); // 027004348CB0 0x2C UseSmoothDeltaTime          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.MaxSmoothUnscaledTime                     = GetSingle(new IntPtr(p + 0x030)); // 027004348CD0 0x30 MaxSmoothUnscaledTime       ( 000186666050 ModelPrimitiveType float float float Single )
            value.RewindCallbackMode                        = (RewindCallbackMode)GetInt32(new IntPtr(p + 0x034)); // 027004348CF0 0x34 RewindCallbackMode          ( 000186681060 ModelEnumType RewindCallbackMode RewindCallbackMode RewindCallbackMode Int32 )
            value.ShowUnityEditorReport                     = GetBool(new IntPtr(p + 0x038)); // 027004348D10 0x38 ShowUnityEditorReport       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LogBehaviour                              = (LogBehaviour)GetInt32(new IntPtr(p + 0x03C)); // 027004348D30 0x3C LogBehaviour                ( 0001865ABE70 ModelEnumType LogBehaviour LogBehaviour LogBehaviour Int32 )
            value.DrawGizmos                                = GetBool(new IntPtr(p + 0x040)); // 027004348D50 0x40 DrawGizmos                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DefaultRecyclable                         = GetBool(new IntPtr(p + 0x041)); // 027004348D70 0x41 DefaultRecyclable           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DefaultAutoPlay                           = (AutoPlay)GetInt32(new IntPtr(p + 0x044)); // 027004348D90 0x44 DefaultAutoPlay             ( 0001867283F0 ModelEnumType AutoPlay AutoPlay AutoPlay Int32 )
            value.DefaultUpdateType                         = (UpdateType)GetInt32(new IntPtr(p + 0x048)); // 027004348DB0 0x48 DefaultUpdateType           ( 000186742360 ModelEnumType UpdateType UpdateType UpdateType Int32 )
            value.DefaultTimeScaleIndependent               = GetBool(new IntPtr(p + 0x04C)); // 027004348DD0 0x4C DefaultTimeScaleIndependent ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DefaultEaseType                           = (Ease)GetInt32(new IntPtr(p + 0x050)); // 027004348DF0 0x50 DefaultEaseType             ( 000186717150 ModelEnumType Ease Ease Ease Int32 )
            value.DefaultEaseOvershootOrAmplitude           = GetSingle(new IntPtr(p + 0x054)); // 027004348E10 0x54 DefaultEaseOvershootOrAmplitude ( 000186666050 ModelPrimitiveType float float float Single )
            value.DefaultEasePeriod                         = GetSingle(new IntPtr(p + 0x058)); // 027004348E30 0x58 DefaultEasePeriod           ( 000186666050 ModelPrimitiveType float float float Single )
            value.DefaultAutoKill                           = GetBool(new IntPtr(p + 0x05C)); // 027004348E50 0x5C DefaultAutoKill             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DefaultLoopType                           = (LoopType)GetInt32(new IntPtr(p + 0x060)); // 027004348E70 0x60 DefaultLoopType             ( 0001865C0BF0 ModelEnumType LoopType LoopType LoopType Int32 )
            value.DebugMode                                 = GetBool(new IntPtr(p + 0x064)); // 027004348E90 0x64 DebugMode                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DebugStoreTargetId                        = GetBool(new IntPtr(p + 0x065)); // 027004348EB0 0x65 DebugStoreTargetId          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShowPreviewPanel                          = GetBool(new IntPtr(p + 0x066)); // 027004348ED0 0x66 ShowPreviewPanel            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.StoreSettingsLocation                     = (SettingsLocation)GetInt32(new IntPtr(p + 0x068)); // 027004348EF0 0x68 StoreSettingsLocation       ( 000186576FC0 ModelEnumType SettingsLocation SettingsLocation SettingsLocation Int32 )
            value.Modules                                   = GetObject<ModulesSetup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ModulesSetup.FromPointer); // 027004348F10 0x70 Modules                     ( 000186576600 ModelClassType ModulesSetup ModulesSetup ModulesSetup Pointer )
            value.ShowPlayingTweens                         = GetBool(new IntPtr(p + 0x078)); // 027004348F30 0x78 ShowPlayingTweens           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShowPausedTweens                          = GetBool(new IntPtr(p + 0x079)); // 027004348F50 0x79 ShowPausedTweens            ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
