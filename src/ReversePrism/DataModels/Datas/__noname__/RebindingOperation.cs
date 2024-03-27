using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kDefaultMagnitudeThreshold               float IL2CPP_TYPE_R4
    // 010 M_ActionToRebind                         0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer
    // 018 m_BindingMask                            Nullable`1<InputBinding> IL2CPP_TYPE_GENERICINST
    // 078 M_ControlType                            000186692850 ModelClassType Type Type Type Pointer
    // 080 M_ExpectedLayout                         0001865FE140 ModelEnumType InternedString InternedString InternedString Int32
    // 090 M_IncludePathCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 098 M_IncludePaths                           000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A0 M_ExcludePathCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A8 M_ExcludePaths                           000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0B0 M_TargetBindingIndex                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B8 M_BindingGroupForNewBinding              000186671910 ModelPrimitiveType string string string String
    // 0C0 M_CancelBinding                          000186671910 ModelPrimitiveType string string string String
    // 0C8 M_MagnitudeThreshold                     0001866656B0 ModelPrimitiveType float float float Single
    // 0D0 M_Scores                                 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 0D8 M_Magnitudes                             000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 0E0 M_LastMatchTime                          0001865C2950 ModelPrimitiveType double double double Double
    // 0E8 M_StartTime                              0001865C2950 ModelPrimitiveType double double double Double
    // 0F0 M_Timeout                                0001866656B0 ModelPrimitiveType float float float Single
    // 0F4 M_WaitSecondsAfterMatch                  0001866656B0 ModelPrimitiveType float float float Single
    // 0F8 m_Candidates                             InputControlList`1<InputControl> IL2CPP_TYPE_GENERICINST
    // 118 m_OnComplete                             Action`1<RebindingOperation> IL2CPP_TYPE_GENERICINST
    // 120 m_OnCancel                               Action`1<RebindingOperation> IL2CPP_TYPE_GENERICINST
    // 128 m_OnPotentialMatch                       Action`1<RebindingOperation> IL2CPP_TYPE_GENERICINST
    // 130 m_OnGeneratePath                         Func`2<InputControl, string> IL2CPP_TYPE_GENERICINST
    // 138 m_OnComputeScore                         Func`3<InputControl, InputEventPtr, float> IL2CPP_TYPE_GENERICINST
    // 140 m_OnApplyBinding                         Action`2<RebindingOperation, string> IL2CPP_TYPE_GENERICINST
    // 148 m_OnEventDelegate                        Action`2<InputEventPtr, InputDevice> IL2CPP_TYPE_GENERICINST
    // 150 M_OnAfterUpdateDelegate                  0001866792B0 ModelClassType Action Action Action Pointer
    // 158 M_LayoutCache                            0001866F86E0 ModelEnumType Cache Cache Cache Int32
    // 160 M_PathBuilder                            000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 168 M_Flags                                  000186523480 ModelEnumType Flags Flags Flags Int32
    // 170 m_StartingActuations                     Dictionary`2<InputControl, float> IL2CPP_TYPE_GENERICINST
    public partial class RebindingOperation
    {
        public InputAction?                             M_ActionToRebind                        { get; set; }
        public Type?                                    M_ControlType                           { get; set; }
        public InternedString                           M_ExpectedLayout                        { get; set; }
        public int                                      M_IncludePathCount                      { get; set; }
        public List<string>?                            M_IncludePaths                          { get; set; }
        public int                                      M_ExcludePathCount                      { get; set; }
        public List<string>?                            M_ExcludePaths                          { get; set; }
        public int                                      M_TargetBindingIndex                    { get; set; }
        public string                                   M_BindingGroupForNewBinding             { get; set; }
        public string                                   M_CancelBinding                         { get; set; }
        public float                                    M_MagnitudeThreshold                    { get; set; }
        public List<float>?                             M_Scores                                { get; set; }
        public List<float>?                             M_Magnitudes                            { get; set; }
        public double                                   M_LastMatchTime                         { get; set; }
        public double                                   M_StartTime                             { get; set; }
        public float                                    M_Timeout                               { get; set; }
        public float                                    M_WaitSecondsAfterMatch                 { get; set; }
        public Action?                                  M_OnAfterUpdateDelegate                 { get; set; }
        public Cache                                    M_LayoutCache                           { get; set; }
        public StringBuilder?                           M_PathBuilder                           { get; set; }
        public Flags                                    M_Flags                                 { get; set; }

        public static RebindingOperation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RebindingOperation();

            value.M_ActionToRebind                          = GetObject<InputAction>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputAction.FromPointer); // 0270D7650F20 0x10 M_ActionToRebind            ( 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_ControlType                             = GetObject<Type>(new IntPtr(p + 0x078), ReversePrism.DataModels.Type.FromPointer); // 0270D7650F60 0x78 M_ControlType               ( 000186692850 ModelClassType Type Type Type Pointer )
            value.M_ExpectedLayout                          = (InternedString)GetInt32(new IntPtr(p + 0x080)); // 0270D7650F80 0x80 M_ExpectedLayout            ( 0001865FE140 ModelEnumType InternedString InternedString InternedString Int32 )
            value.M_IncludePathCount                        = GetInt32(new IntPtr(p + 0x090)); // 0270D7650FA0 0x90 M_IncludePathCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_IncludePaths                            = GetStringList(new IntPtr(p + 0x098)); // 0270D7650FC0 0x98 M_IncludePaths              ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_ExcludePathCount                        = GetInt32(new IntPtr(p + 0x0A0)); // 0270D7650FE0 0xA0 M_ExcludePathCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ExcludePaths                            = GetStringList(new IntPtr(p + 0x0A8)); // 0270D7651000 0xA8 M_ExcludePaths              ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_TargetBindingIndex                      = GetInt32(new IntPtr(p + 0x0B0)); // 0270D7651020 0xB0 M_TargetBindingIndex        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_BindingGroupForNewBinding               = GetString(new IntPtr(p + 0x0B8)); // 0270D7651040 0xB8 M_BindingGroupForNewBinding ( 000186671910 ModelPrimitiveType string string string String )
            value.M_CancelBinding                           = GetString(new IntPtr(p + 0x0C0)); // 0270D7651060 0xC0 M_CancelBinding             ( 000186671910 ModelPrimitiveType string string string String )
            value.M_MagnitudeThreshold                      = GetSingle(new IntPtr(p + 0x0C8)); // 0270D7651080 0xC8 M_MagnitudeThreshold        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Scores                                  = GetSingleList(new IntPtr(p + 0x0D0)); // 0270D76510A0 0xD0 M_Scores                    ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_Magnitudes                              = GetSingleList(new IntPtr(p + 0x0D8)); // 0270D76510C0 0xD8 M_Magnitudes                ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_LastMatchTime                           = GetDouble(new IntPtr(p + 0x0E0)); // 0270D76510E0 0xE0 M_LastMatchTime             ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_StartTime                               = GetDouble(new IntPtr(p + 0x0E8)); // 0270D7651100 0xE8 M_StartTime                 ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_Timeout                                 = GetSingle(new IntPtr(p + 0x0F0)); // 0270D7651120 0xF0 M_Timeout                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_WaitSecondsAfterMatch                   = GetSingle(new IntPtr(p + 0x0F4)); // 0270D7651140 0xF4 M_WaitSecondsAfterMatch     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_OnAfterUpdateDelegate                   = GetObject<Action>(new IntPtr(p + 0x150), ReversePrism.DataModels.Action.FromPointer); // 0270D7651260 0x150 M_OnAfterUpdateDelegate     ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_LayoutCache                             = (Cache)GetInt32(new IntPtr(p + 0x158)); // 0270D7651280 0x158 M_LayoutCache               ( 0001866F86E0 ModelEnumType Cache Cache Cache Int32 )
            value.M_PathBuilder                             = GetObject<StringBuilder>(new IntPtr(p + 0x160), ReversePrism.DataModels.StringBuilder.FromPointer); // 0270D76512A0 0x160 M_PathBuilder               ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.M_Flags                                   = (Flags)GetInt32(new IntPtr(p + 0x168)); // 0270D76512C0 0x168 M_Flags                     ( 000186523480 ModelEnumType Flags Flags Flags Int32 )

            return value;
        }
    }
}
