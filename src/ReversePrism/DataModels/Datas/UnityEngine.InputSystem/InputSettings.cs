using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_SupportedDevices                       ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 M_UpdateMode                             ModelEnumType UpdateMode UpdateMode UpdateMode Int32
    // 024 M_MaxEventBytesPerUpdate                 ModelPrimitiveType int int int Int32
    // 028 M_MaxQueuedEventsPerUpdate               ModelPrimitiveType int int int Int32
    // 02C M_CompensateForScreenOrientation         ModelPrimitiveType bool bool bool Bool
    // 030 M_BackgroundBehavior                     ModelEnumType BackgroundBehavior BackgroundBehavior BackgroundBehavior Int32
    // 034 M_EditorInputBehaviorInPlayMode          ModelEnumType EditorInputBehaviorInPlayMode EditorInputBehaviorInPlayMode EditorInputBehaviorInPlayMode Int32
    // 038 M_DefaultDeadzoneMin                     ModelPrimitiveType float float float Single
    // 03C M_DefaultDeadzoneMax                     ModelPrimitiveType float float float Single
    // 040 M_DefaultButtonPressPoint                ModelPrimitiveType float float float Single
    // 044 M_ButtonReleaseThreshold                 ModelPrimitiveType float float float Single
    // 048 M_DefaultTapTime                         ModelPrimitiveType float float float Single
    // 04C M_DefaultSlowTapTime                     ModelPrimitiveType float float float Single
    // 050 M_DefaultHoldTime                        ModelPrimitiveType float float float Single
    // 054 M_TapRadius                              ModelPrimitiveType float float float Single
    // 058 M_MultiTapDelayTime                      ModelPrimitiveType float float float Single
    // 05C M_DisableRedundantEventsMerging          ModelPrimitiveType bool bool bool Bool
    // 05D M_ShortcutKeysConsumeInputs              ModelPrimitiveType bool bool bool Bool
    // 060 m_FeatureFlags                           HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 000 optimizedControlsFeatureEnabled          bool IL2CPP_TYPE_BOOLEAN
    // 001 readValueCachingFeatureEnabled           bool IL2CPP_TYPE_BOOLEAN
    // 002 paranoidReadValueCachingChecksEnabled    bool IL2CPP_TYPE_BOOLEAN
    // 000 s_OldUnsupportedFixedAndDynamicUpdateSetting int IL2CPP_TYPE_I4
    public partial class InputSettings : DataModel
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
            var value   = new InputSettings() { Pointer= p0 };

            value.M_SupportedDevices                        = GetStringList(new IntPtr(p + 0x018)); // 0x18 M_SupportedDevices          ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_UpdateMode                              = (UpdateMode)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_UpdateMode                ( ModelEnumType UpdateMode UpdateMode UpdateMode Int32 )
            value.M_MaxEventBytesPerUpdate                  = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_MaxEventBytesPerUpdate    ( ModelPrimitiveType int int int Int32 )
            value.M_MaxQueuedEventsPerUpdate                = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_MaxQueuedEventsPerUpdate  ( ModelPrimitiveType int int int Int32 )
            value.M_CompensateForScreenOrientation          = GetBool(new IntPtr(p + 0x02C)); // 0x2C M_CompensateForScreenOrientation ( ModelPrimitiveType bool bool bool Bool )
            value.M_BackgroundBehavior                      = (BackgroundBehavior)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_BackgroundBehavior        ( ModelEnumType BackgroundBehavior BackgroundBehavior BackgroundBehavior Int32 )
            value.M_EditorInputBehaviorInPlayMode           = (EditorInputBehaviorInPlayMode)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_EditorInputBehaviorInPlayMode ( ModelEnumType EditorInputBehaviorInPlayMode EditorInputBehaviorInPlayMode EditorInputBehaviorInPlayMode Int32 )
            value.M_DefaultDeadzoneMin                      = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_DefaultDeadzoneMin        ( ModelPrimitiveType float float float Single )
            value.M_DefaultDeadzoneMax                      = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_DefaultDeadzoneMax        ( ModelPrimitiveType float float float Single )
            value.M_DefaultButtonPressPoint                 = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_DefaultButtonPressPoint   ( ModelPrimitiveType float float float Single )
            value.M_ButtonReleaseThreshold                  = GetSingle(new IntPtr(p + 0x044)); // 0x44 M_ButtonReleaseThreshold    ( ModelPrimitiveType float float float Single )
            value.M_DefaultTapTime                          = GetSingle(new IntPtr(p + 0x048)); // 0x48 M_DefaultTapTime            ( ModelPrimitiveType float float float Single )
            value.M_DefaultSlowTapTime                      = GetSingle(new IntPtr(p + 0x04C)); // 0x4C M_DefaultSlowTapTime        ( ModelPrimitiveType float float float Single )
            value.M_DefaultHoldTime                         = GetSingle(new IntPtr(p + 0x050)); // 0x50 M_DefaultHoldTime           ( ModelPrimitiveType float float float Single )
            value.M_TapRadius                               = GetSingle(new IntPtr(p + 0x054)); // 0x54 M_TapRadius                 ( ModelPrimitiveType float float float Single )
            value.M_MultiTapDelayTime                       = GetSingle(new IntPtr(p + 0x058)); // 0x58 M_MultiTapDelayTime         ( ModelPrimitiveType float float float Single )
            value.M_DisableRedundantEventsMerging           = GetBool(new IntPtr(p + 0x05C)); // 0x5C M_DisableRedundantEventsMerging ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShortcutKeysConsumeInputs               = GetBool(new IntPtr(p + 0x05D)); // 0x5D M_ShortcutKeysConsumeInputs ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
