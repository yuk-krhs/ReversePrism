using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 IsEditorRemoteConnected                  Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 010 M_Input                                  ModelClassType IInput IInput IInput Pointer
    // 018 M_HorizontalAxis                         ModelPrimitiveType string string string String
    // 020 M_VerticalAxis                           ModelPrimitiveType string string string String
    // 028 M_SubmitButton                           ModelPrimitiveType string string string String
    // 030 M_CancelButton                           ModelPrimitiveType string string string String
    // 038 M_InputActionsPerSecond                  ModelPrimitiveType float float float Single
    // 03C M_RepeatDelay                            ModelPrimitiveType float float float Single
    // 040 M_SendingTouchEvents                     ModelPrimitiveType bool bool bool Bool
    // 041 M_SendingPenEvent                        ModelPrimitiveType bool bool bool Bool
    // 048 M_Event                                  ModelClassType Event Event Event Pointer
    // 050 M_FocusedPanel                           ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer
    // 058 M_PreviousFocusedPanel                   ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer
    // 060 M_PreviousFocusedElement                 ModelClassType Focusable Focusable Focusable Pointer
    // 068 M_CurrentModifiers                       ModelEnumType EventModifiers EventModifiers EventModifiers Int32
    // 06C M_LastMousePressButton                   ModelPrimitiveType int int int Int32
    // 070 M_NextMousePressTime                     ModelPrimitiveType float float float Single
    // 074 M_LastMouseClickCount                    ModelPrimitiveType int int int Int32
    // 078 M_LastMousePosition                      ModelEnumType Vector2 Vector2 Vector2 Int32
    // 080 M_MouseProcessedAtLeastOnce              ModelPrimitiveType bool bool bool Bool
    // 084 M_ConsecutiveMoveCount                   ModelPrimitiveType int int int Int32
    // 088 M_LastMoveVector                         ModelEnumType Vector2 Vector2 Vector2 Int32
    // 090 M_PrevActionTime                         ModelPrimitiveType float float float Single
    // 094 M_IsMoveFromKeyboard                     ModelPrimitiveType bool bool bool Bool
    public partial class DefaultEventSystem : DataModel
    {
        public IInput?                                  M_Input                                 { get; set; }
        public string                                   M_HorizontalAxis                        { get; set; }
        public string                                   M_VerticalAxis                          { get; set; }
        public string                                   M_SubmitButton                          { get; set; }
        public string                                   M_CancelButton                          { get; set; }
        public float                                    M_InputActionsPerSecond                 { get; set; }
        public float                                    M_RepeatDelay                           { get; set; }
        public bool                                     M_SendingTouchEvents                    { get; set; }
        public bool                                     M_SendingPenEvent                       { get; set; }
        public Event?                                   M_Event                                 { get; set; }
        public BaseRuntimePanel?                        M_FocusedPanel                          { get; set; }
        public BaseRuntimePanel?                        M_PreviousFocusedPanel                  { get; set; }
        public Focusable?                               M_PreviousFocusedElement                { get; set; }
        public EventModifiers                           M_CurrentModifiers                      { get; set; }
        public int                                      M_LastMousePressButton                  { get; set; }
        public float                                    M_NextMousePressTime                    { get; set; }
        public int                                      M_LastMouseClickCount                   { get; set; }
        public Vector2                                  M_LastMousePosition                     { get; set; }
        public bool                                     M_MouseProcessedAtLeastOnce             { get; set; }
        public int                                      M_ConsecutiveMoveCount                  { get; set; }
        public Vector2                                  M_LastMoveVector                        { get; set; }
        public float                                    M_PrevActionTime                        { get; set; }
        public bool                                     M_IsMoveFromKeyboard                    { get; set; }

        public static DefaultEventSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultEventSystem() { Pointer= p0 };

            value.M_Input                                   = GetObject<IInput>(new IntPtr(p + 0x010), ReversePrism.DataModels.IInput.FromPointer); // 0x10 M_Input                     ( ModelClassType IInput IInput IInput Pointer )
            value.M_HorizontalAxis                          = GetString(new IntPtr(p + 0x018)); // 0x18 M_HorizontalAxis            ( ModelPrimitiveType string string string String )
            value.M_VerticalAxis                            = GetString(new IntPtr(p + 0x020)); // 0x20 M_VerticalAxis              ( ModelPrimitiveType string string string String )
            value.M_SubmitButton                            = GetString(new IntPtr(p + 0x028)); // 0x28 M_SubmitButton              ( ModelPrimitiveType string string string String )
            value.M_CancelButton                            = GetString(new IntPtr(p + 0x030)); // 0x30 M_CancelButton              ( ModelPrimitiveType string string string String )
            value.M_InputActionsPerSecond                   = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_InputActionsPerSecond     ( ModelPrimitiveType float float float Single )
            value.M_RepeatDelay                             = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_RepeatDelay               ( ModelPrimitiveType float float float Single )
            value.M_SendingTouchEvents                      = GetBool(new IntPtr(p + 0x040)); // 0x40 M_SendingTouchEvents        ( ModelPrimitiveType bool bool bool Bool )
            value.M_SendingPenEvent                         = GetBool(new IntPtr(p + 0x041)); // 0x41 M_SendingPenEvent           ( ModelPrimitiveType bool bool bool Bool )
            value.M_Event                                   = GetObject<Event>(new IntPtr(p + 0x048), ReversePrism.DataModels.Event.FromPointer); // 0x48 M_Event                     ( ModelClassType Event Event Event Pointer )
            value.M_FocusedPanel                            = GetObject<BaseRuntimePanel>(new IntPtr(p + 0x050), ReversePrism.DataModels.BaseRuntimePanel.FromPointer); // 0x50 M_FocusedPanel              ( ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer )
            value.M_PreviousFocusedPanel                    = GetObject<BaseRuntimePanel>(new IntPtr(p + 0x058), ReversePrism.DataModels.BaseRuntimePanel.FromPointer); // 0x58 M_PreviousFocusedPanel      ( ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer )
            value.M_PreviousFocusedElement                  = GetObject<Focusable>(new IntPtr(p + 0x060), ReversePrism.DataModels.Focusable.FromPointer); // 0x60 M_PreviousFocusedElement    ( ModelClassType Focusable Focusable Focusable Pointer )
            value.M_CurrentModifiers                        = (EventModifiers)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_CurrentModifiers          ( ModelEnumType EventModifiers EventModifiers EventModifiers Int32 )
            value.M_LastMousePressButton                    = GetInt32(new IntPtr(p + 0x06C)); // 0x6C M_LastMousePressButton      ( ModelPrimitiveType int int int Int32 )
            value.M_NextMousePressTime                      = GetSingle(new IntPtr(p + 0x070)); // 0x70 M_NextMousePressTime        ( ModelPrimitiveType float float float Single )
            value.M_LastMouseClickCount                     = GetInt32(new IntPtr(p + 0x074)); // 0x74 M_LastMouseClickCount       ( ModelPrimitiveType int int int Int32 )
            value.M_LastMousePosition                       = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 0x78 M_LastMousePosition         ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_MouseProcessedAtLeastOnce               = GetBool(new IntPtr(p + 0x080)); // 0x80 M_MouseProcessedAtLeastOnce ( ModelPrimitiveType bool bool bool Bool )
            value.M_ConsecutiveMoveCount                    = GetInt32(new IntPtr(p + 0x084)); // 0x84 M_ConsecutiveMoveCount      ( ModelPrimitiveType int int int Int32 )
            value.M_LastMoveVector                          = (Vector2)GetInt32(new IntPtr(p + 0x088)); // 0x88 M_LastMoveVector            ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_PrevActionTime                          = GetSingle(new IntPtr(p + 0x090)); // 0x90 M_PrevActionTime            ( ModelPrimitiveType float float float Single )
            value.M_IsMoveFromKeyboard                      = GetBool(new IntPtr(p + 0x094)); // 0x94 M_IsMoveFromKeyboard        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
