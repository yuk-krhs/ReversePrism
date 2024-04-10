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

            value.UseSafeMode                               = GetBool(new IntPtr(p + 0x018)); // 0245A43A9090 0x18 UseSafeMode                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SafeModeOptions                           = GetObject<SafeModeOptions>(new IntPtr(p + 0x020), ReversePrism.DataModels.SafeModeOptions.FromPointer); // 0245A43A90B0 0x20 SafeModeOptions             ( 000186576AE0 ModelClassType SafeModeOptions SafeModeOptions SafeModeOptions Pointer )
            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x028)); // 0245A43A90D0 0x28 TimeScale                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.UseSmoothDeltaTime                        = GetBool(new IntPtr(p + 0x02C)); // 0245A43A90F0 0x2C UseSmoothDeltaTime          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.MaxSmoothUnscaledTime                     = GetSingle(new IntPtr(p + 0x030)); // 0245A43A9110 0x30 MaxSmoothUnscaledTime       ( 000186666050 ModelPrimitiveType float float float Single )
            value.RewindCallbackMode                        = (RewindCallbackMode)GetInt32(new IntPtr(p + 0x034)); // 0245A43A9130 0x34 RewindCallbackMode          ( 000186681060 ModelEnumType RewindCallbackMode RewindCallbackMode RewindCallbackMode Int32 )
            value.ShowUnityEditorReport                     = GetBool(new IntPtr(p + 0x038)); // 0245A43A9150 0x38 ShowUnityEditorReport       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LogBehaviour                              = (LogBehaviour)GetInt32(new IntPtr(p + 0x03C)); // 0245A43A9170 0x3C LogBehaviour                ( 0001865ABE70 ModelEnumType LogBehaviour LogBehaviour LogBehaviour Int32 )
            value.DrawGizmos                                = GetBool(new IntPtr(p + 0x040)); // 0245A43A9190 0x40 DrawGizmos                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DefaultRecyclable                         = GetBool(new IntPtr(p + 0x041)); // 0245A43A91B0 0x41 DefaultRecyclable           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DefaultAutoPlay                           = (AutoPlay)GetInt32(new IntPtr(p + 0x044)); // 0245A43A91D0 0x44 DefaultAutoPlay             ( 0001867283F0 ModelEnumType AutoPlay AutoPlay AutoPlay Int32 )
            value.DefaultUpdateType                         = (UpdateType)GetInt32(new IntPtr(p + 0x048)); // 0245A43A91F0 0x48 DefaultUpdateType           ( 000186742360 ModelEnumType UpdateType UpdateType UpdateType Int32 )
            value.DefaultTimeScaleIndependent               = GetBool(new IntPtr(p + 0x04C)); // 0245A43A9210 0x4C DefaultTimeScaleIndependent ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DefaultEaseType                           = (Ease)GetInt32(new IntPtr(p + 0x050)); // 0245A43A9230 0x50 DefaultEaseType             ( 000186717150 ModelEnumType Ease Ease Ease Int32 )
            value.DefaultEaseOvershootOrAmplitude           = GetSingle(new IntPtr(p + 0x054)); // 0245A43A9250 0x54 DefaultEaseOvershootOrAmplitude ( 000186666050 ModelPrimitiveType float float float Single )
            value.DefaultEasePeriod                         = GetSingle(new IntPtr(p + 0x058)); // 0245A43A9270 0x58 DefaultEasePeriod           ( 000186666050 ModelPrimitiveType float float float Single )
            value.DefaultAutoKill                           = GetBool(new IntPtr(p + 0x05C)); // 0245A43A9290 0x5C DefaultAutoKill             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DefaultLoopType                           = (LoopType)GetInt32(new IntPtr(p + 0x060)); // 0245A43A92B0 0x60 DefaultLoopType             ( 0001865C0BF0 ModelEnumType LoopType LoopType LoopType Int32 )
            value.DebugMode                                 = GetBool(new IntPtr(p + 0x064)); // 0245A43A92D0 0x64 DebugMode                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DebugStoreTargetId                        = GetBool(new IntPtr(p + 0x065)); // 0245A43A92F0 0x65 DebugStoreTargetId          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShowPreviewPanel                          = GetBool(new IntPtr(p + 0x066)); // 0245A43A9310 0x66 ShowPreviewPanel            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.StoreSettingsLocation                     = (SettingsLocation)GetInt32(new IntPtr(p + 0x068)); // 0245A43A9330 0x68 StoreSettingsLocation       ( 000186576FC0 ModelEnumType SettingsLocation SettingsLocation SettingsLocation Int32 )
            value.Modules                                   = GetObject<ModulesSetup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ModulesSetup.FromPointer); // 0245A43A9350 0x70 Modules                     ( 000186576600 ModelClassType ModulesSetup ModulesSetup ModulesSetup Pointer )
            value.ShowPlayingTweens                         = GetBool(new IntPtr(p + 0x078)); // 0245A43A9370 0x78 ShowPlayingTweens           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShowPausedTweens                          = GetBool(new IntPtr(p + 0x079)); // 0245A43A9390 0x79 ShowPausedTweens            ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
