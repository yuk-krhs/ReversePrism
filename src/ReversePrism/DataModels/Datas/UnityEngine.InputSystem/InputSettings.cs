using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_SupportedDevices                       000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 M_UpdateMode                             000186639810 ModelEnumType UpdateMode UpdateMode UpdateMode Int32
    // 024 M_MaxEventBytesPerUpdate                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_MaxQueuedEventsPerUpdate               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_CompensateForScreenOrientation         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 M_BackgroundBehavior                     0001866389F0 ModelEnumType BackgroundBehavior BackgroundBehavior BackgroundBehavior Int32
    // 034 M_EditorInputBehaviorInPlayMode          000186639100 ModelEnumType EditorInputBehaviorInPlayMode EditorInputBehaviorInPlayMode EditorInputBehaviorInPlayMode Int32
    // 038 M_DefaultDeadzoneMin                     0001866656B0 ModelPrimitiveType float float float Single
    // 03C M_DefaultDeadzoneMax                     0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_DefaultButtonPressPoint                0001866656B0 ModelPrimitiveType float float float Single
    // 044 M_ButtonReleaseThreshold                 0001866656B0 ModelPrimitiveType float float float Single
    // 048 M_DefaultTapTime                         0001866656B0 ModelPrimitiveType float float float Single
    // 04C M_DefaultSlowTapTime                     0001866656B0 ModelPrimitiveType float float float Single
    // 050 M_DefaultHoldTime                        0001866656B0 ModelPrimitiveType float float float Single
    // 054 M_TapRadius                              0001866656B0 ModelPrimitiveType float float float Single
    // 058 M_MultiTapDelayTime                      0001866656B0 ModelPrimitiveType float float float Single
    // 05C M_DisableRedundantEventsMerging          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05D M_ShortcutKeysConsumeInputs              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 m_FeatureFlags                           HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 000 optimizedControlsFeatureEnabled          bool IL2CPP_TYPE_BOOLEAN
    // 001 readValueCachingFeatureEnabled           bool IL2CPP_TYPE_BOOLEAN
    // 002 paranoidReadValueCachingChecksEnabled    bool IL2CPP_TYPE_BOOLEAN
    // 000 s_OldUnsupportedFixedAndDynamicUpdateSetting int IL2CPP_TYPE_I4
    public partial class InputSettings
    {
        public List<string>?                            M_SupportedDevices                      { get; set; }
        public UpdateMode                               M_UpdateMode                            { get; set; }
        public int                                      M_MaxEventBytesPerUpdate                { get; set; }
        public int                                      M_MaxQueuedEventsPerUpdate              { get; set; }
        public bool                                     M_CompensateForScreenOrientation        { get; set; }
        public BackgroundBehavior                       M_BackgroundBehavior                    { get; set; }
        public EditorInputBehaviorInPlayMode            M_EditorInputBehaviorInPlayMode         { get; set; }
        public float                                    M_DefaultDeadzoneMin                    { get; set; }
        public float                                    M_DefaultDeadzoneMax                    { get; set; }
        public float                                    M_DefaultButtonPressPoint               { get; set; }
        public float                                    M_ButtonReleaseThreshold                { get; set; }
        public float                                    M_DefaultTapTime                        { get; set; }
        public float                                    M_DefaultSlowTapTime                    { get; set; }
        public float                                    M_DefaultHoldTime                       { get; set; }
        public float                                    M_TapRadius                             { get; set; }
        public float                                    M_MultiTapDelayTime                     { get; set; }
        public bool                                     M_DisableRedundantEventsMerging         { get; set; }
        public bool                                     M_ShortcutKeysConsumeInputs             { get; set; }

        public static InputSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputSettings();

            value.M_SupportedDevices                        = GetStringList(new IntPtr(p + 0x018)); // 027002DD6508 0x18 M_SupportedDevices          ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_UpdateMode                              = (UpdateMode)GetInt32(new IntPtr(p + 0x020)); // 027002DD6528 0x20 M_UpdateMode                ( 000186639810 ModelEnumType UpdateMode UpdateMode UpdateMode Int32 )
            value.M_MaxEventBytesPerUpdate                  = GetInt32(new IntPtr(p + 0x024)); // 027002DD6548 0x24 M_MaxEventBytesPerUpdate    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MaxQueuedEventsPerUpdate                = GetInt32(new IntPtr(p + 0x028)); // 027002DD6568 0x28 M_MaxQueuedEventsPerUpdate  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CompensateForScreenOrientation          = GetBool(new IntPtr(p + 0x02C)); // 027002DD6588 0x2C M_CompensateForScreenOrientation ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_BackgroundBehavior                      = (BackgroundBehavior)GetInt32(new IntPtr(p + 0x030)); // 027002DD65A8 0x30 M_BackgroundBehavior        ( 0001866389F0 ModelEnumType BackgroundBehavior BackgroundBehavior BackgroundBehavior Int32 )
            value.M_EditorInputBehaviorInPlayMode           = (EditorInputBehaviorInPlayMode)GetInt32(new IntPtr(p + 0x034)); // 027002DD65C8 0x34 M_EditorInputBehaviorInPlayMode ( 000186639100 ModelEnumType EditorInputBehaviorInPlayMode EditorInputBehaviorInPlayMode EditorInputBehaviorInPlayMode Int32 )
            value.M_DefaultDeadzoneMin                      = GetSingle(new IntPtr(p + 0x038)); // 027002DD65E8 0x38 M_DefaultDeadzoneMin        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DefaultDeadzoneMax                      = GetSingle(new IntPtr(p + 0x03C)); // 027002DD6608 0x3C M_DefaultDeadzoneMax        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DefaultButtonPressPoint                 = GetSingle(new IntPtr(p + 0x040)); // 027002DD6628 0x40 M_DefaultButtonPressPoint   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ButtonReleaseThreshold                  = GetSingle(new IntPtr(p + 0x044)); // 027002DD6648 0x44 M_ButtonReleaseThreshold    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DefaultTapTime                          = GetSingle(new IntPtr(p + 0x048)); // 027002DD6668 0x48 M_DefaultTapTime            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DefaultSlowTapTime                      = GetSingle(new IntPtr(p + 0x04C)); // 027002DD6688 0x4C M_DefaultSlowTapTime        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DefaultHoldTime                         = GetSingle(new IntPtr(p + 0x050)); // 027002DD66A8 0x50 M_DefaultHoldTime           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_TapRadius                               = GetSingle(new IntPtr(p + 0x054)); // 027002DD66C8 0x54 M_TapRadius                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_MultiTapDelayTime                       = GetSingle(new IntPtr(p + 0x058)); // 027002DD66E8 0x58 M_MultiTapDelayTime         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DisableRedundantEventsMerging           = GetBool(new IntPtr(p + 0x05C)); // 027002DD6708 0x5C M_DisableRedundantEventsMerging ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ShortcutKeysConsumeInputs               = GetBool(new IntPtr(p + 0x05D)); // 027002DD6728 0x5D M_ShortcutKeysConsumeInputs ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
