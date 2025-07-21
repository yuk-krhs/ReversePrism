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
    // 018 UseSafeMode                              ModelPrimitiveType bool bool bool Bool
    // 020 SafeModeOptions                          ModelClassType SafeModeOptions SafeModeOptions SafeModeOptions Pointer
    // 028 TimeScale                                ModelPrimitiveType float float float Single
    // 02C UseSmoothDeltaTime                       ModelPrimitiveType bool bool bool Bool
    // 030 MaxSmoothUnscaledTime                    ModelPrimitiveType float float float Single
    // 034 RewindCallbackMode                       ModelEnumType RewindCallbackMode RewindCallbackMode RewindCallbackMode Int32
    // 038 ShowUnityEditorReport                    ModelPrimitiveType bool bool bool Bool
    // 03C LogBehaviour                             ModelEnumType LogBehaviour LogBehaviour LogBehaviour Int32
    // 040 DrawGizmos                               ModelPrimitiveType bool bool bool Bool
    // 041 DefaultRecyclable                        ModelPrimitiveType bool bool bool Bool
    // 044 DefaultAutoPlay                          ModelEnumType AutoPlay AutoPlay AutoPlay Int32
    // 048 DefaultUpdateType                        ModelEnumType UpdateType UpdateType UpdateType Int32
    // 04C DefaultTimeScaleIndependent              ModelPrimitiveType bool bool bool Bool
    // 050 DefaultEaseType                          ModelEnumType Ease Ease Ease Int32
    // 054 DefaultEaseOvershootOrAmplitude          ModelPrimitiveType float float float Single
    // 058 DefaultEasePeriod                        ModelPrimitiveType float float float Single
    // 05C DefaultAutoKill                          ModelPrimitiveType bool bool bool Bool
    // 060 DefaultLoopType                          ModelEnumType LoopType LoopType LoopType Int32
    // 064 DebugMode                                ModelPrimitiveType bool bool bool Bool
    // 065 DebugStoreTargetId                       ModelPrimitiveType bool bool bool Bool
    // 066 ShowPreviewPanel                         ModelPrimitiveType bool bool bool Bool
    // 068 StoreSettingsLocation                    ModelEnumType SettingsLocation SettingsLocation SettingsLocation Int32
    // 070 Modules                                  ModelClassType ModulesSetup ModulesSetup ModulesSetup Pointer
    // 078 ShowPlayingTweens                        ModelPrimitiveType bool bool bool Bool
    // 079 ShowPausedTweens                         ModelPrimitiveType bool bool bool Bool
    public partial class DOTweenSettings : DataModel
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
            var value   = new DOTweenSettings() { Pointer= p0 };

            value.UseSafeMode                               = GetBool(new IntPtr(p + 0x018)); // 0x18 UseSafeMode                 ( ModelPrimitiveType bool bool bool Bool )
            value.SafeModeOptions                           = GetObject<SafeModeOptions>(new IntPtr(p + 0x020), ReversePrism.DataModels.SafeModeOptions.FromPointer); // 0x20 SafeModeOptions             ( ModelClassType SafeModeOptions SafeModeOptions SafeModeOptions Pointer )
            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x028)); // 0x28 TimeScale                   ( ModelPrimitiveType float float float Single )
            value.UseSmoothDeltaTime                        = GetBool(new IntPtr(p + 0x02C)); // 0x2C UseSmoothDeltaTime          ( ModelPrimitiveType bool bool bool Bool )
            value.MaxSmoothUnscaledTime                     = GetSingle(new IntPtr(p + 0x030)); // 0x30 MaxSmoothUnscaledTime       ( ModelPrimitiveType float float float Single )
            value.RewindCallbackMode                        = (RewindCallbackMode)GetInt32(new IntPtr(p + 0x034)); // 0x34 RewindCallbackMode          ( ModelEnumType RewindCallbackMode RewindCallbackMode RewindCallbackMode Int32 )
            value.ShowUnityEditorReport                     = GetBool(new IntPtr(p + 0x038)); // 0x38 ShowUnityEditorReport       ( ModelPrimitiveType bool bool bool Bool )
            value.LogBehaviour                              = (LogBehaviour)GetInt32(new IntPtr(p + 0x03C)); // 0x3C LogBehaviour                ( ModelEnumType LogBehaviour LogBehaviour LogBehaviour Int32 )
            value.DrawGizmos                                = GetBool(new IntPtr(p + 0x040)); // 0x40 DrawGizmos                  ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultRecyclable                         = GetBool(new IntPtr(p + 0x041)); // 0x41 DefaultRecyclable           ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultAutoPlay                           = (AutoPlay)GetInt32(new IntPtr(p + 0x044)); // 0x44 DefaultAutoPlay             ( ModelEnumType AutoPlay AutoPlay AutoPlay Int32 )
            value.DefaultUpdateType                         = (UpdateType)GetInt32(new IntPtr(p + 0x048)); // 0x48 DefaultUpdateType           ( ModelEnumType UpdateType UpdateType UpdateType Int32 )
            value.DefaultTimeScaleIndependent               = GetBool(new IntPtr(p + 0x04C)); // 0x4C DefaultTimeScaleIndependent ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultEaseType                           = (Ease)GetInt32(new IntPtr(p + 0x050)); // 0x50 DefaultEaseType             ( ModelEnumType Ease Ease Ease Int32 )
            value.DefaultEaseOvershootOrAmplitude           = GetSingle(new IntPtr(p + 0x054)); // 0x54 DefaultEaseOvershootOrAmplitude ( ModelPrimitiveType float float float Single )
            value.DefaultEasePeriod                         = GetSingle(new IntPtr(p + 0x058)); // 0x58 DefaultEasePeriod           ( ModelPrimitiveType float float float Single )
            value.DefaultAutoKill                           = GetBool(new IntPtr(p + 0x05C)); // 0x5C DefaultAutoKill             ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultLoopType                           = (LoopType)GetInt32(new IntPtr(p + 0x060)); // 0x60 DefaultLoopType             ( ModelEnumType LoopType LoopType LoopType Int32 )
            value.DebugMode                                 = GetBool(new IntPtr(p + 0x064)); // 0x64 DebugMode                   ( ModelPrimitiveType bool bool bool Bool )
            value.DebugStoreTargetId                        = GetBool(new IntPtr(p + 0x065)); // 0x65 DebugStoreTargetId          ( ModelPrimitiveType bool bool bool Bool )
            value.ShowPreviewPanel                          = GetBool(new IntPtr(p + 0x066)); // 0x66 ShowPreviewPanel            ( ModelPrimitiveType bool bool bool Bool )
            value.StoreSettingsLocation                     = (SettingsLocation)GetInt32(new IntPtr(p + 0x068)); // 0x68 StoreSettingsLocation       ( ModelEnumType SettingsLocation SettingsLocation SettingsLocation Int32 )
            value.Modules                                   = GetObject<ModulesSetup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ModulesSetup.FromPointer); // 0x70 Modules                     ( ModelClassType ModulesSetup ModulesSetup ModulesSetup Pointer )
            value.ShowPlayingTweens                         = GetBool(new IntPtr(p + 0x078)); // 0x78 ShowPlayingTweens           ( ModelPrimitiveType bool bool bool Bool )
            value.ShowPausedTweens                          = GetBool(new IntPtr(p + 0x079)); // 0x79 ShowPausedTweens            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
