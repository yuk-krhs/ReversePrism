using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 IsEditorRemoteConnected                  Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 010 M_Input                                  000186595380 ModelClassType IInput IInput IInput Pointer
    // 018 M_HorizontalAxis                         000186672F10 ModelPrimitiveType string string string String
    // 020 M_VerticalAxis                           000186672F10 ModelPrimitiveType string string string String
    // 028 M_SubmitButton                           000186672F10 ModelPrimitiveType string string string String
    // 030 M_CancelButton                           000186672F10 ModelPrimitiveType string string string String
    // 038 M_InputActionsPerSecond                  000186666CB0 ModelPrimitiveType float float float Single
    // 03C M_RepeatDelay                            000186666CB0 ModelPrimitiveType float float float Single
    // 040 M_SendingTouchEvents                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 M_SendingPenEvent                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 M_Event                                  00018674CC10 ModelClassType Event Event Event Pointer
    // 050 M_FocusedPanel                           000186742070 ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer
    // 058 M_PreviousFocusedPanel                   000186742070 ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer
    // 060 M_PreviousFocusedElement                 0001865D3CE0 ModelClassType Focusable Focusable Focusable Pointer
    // 068 M_CurrentModifiers                       00018675F1A0 ModelEnumType EventModifiers EventModifiers EventModifiers Int32
    // 06C M_LastMousePressButton                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 M_NextMousePressTime                     0001866656B0 ModelPrimitiveType float float float Single
    // 074 M_LastMouseClickCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 M_LastMousePosition                      0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 080 M_MouseProcessedAtLeastOnce              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 084 M_ConsecutiveMoveCount                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 M_LastMoveVector                         0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 090 M_PrevActionTime                         0001866656B0 ModelPrimitiveType float float float Single
    public partial class DefaultEventSystem
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

        public static DefaultEventSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultEventSystem();

            value.M_Input                                   = GetObject<IInput>(new IntPtr(p + 0x010), ReversePrism.DataModels.IInput.FromPointer); // 027006750B30 0x10 M_Input                     ( 000186595380 ModelClassType IInput IInput IInput Pointer )
            value.M_HorizontalAxis                          = GetString(new IntPtr(p + 0x018)); // 027006750B50 0x18 M_HorizontalAxis            ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_VerticalAxis                            = GetString(new IntPtr(p + 0x020)); // 027006750B70 0x20 M_VerticalAxis              ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_SubmitButton                            = GetString(new IntPtr(p + 0x028)); // 027006750B90 0x28 M_SubmitButton              ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_CancelButton                            = GetString(new IntPtr(p + 0x030)); // 027006750BB0 0x30 M_CancelButton              ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_InputActionsPerSecond                   = GetSingle(new IntPtr(p + 0x038)); // 027006750BD0 0x38 M_InputActionsPerSecond     ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.M_RepeatDelay                             = GetSingle(new IntPtr(p + 0x03C)); // 027006750BF0 0x3C M_RepeatDelay               ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.M_SendingTouchEvents                      = GetBool(new IntPtr(p + 0x040)); // 027006750C10 0x40 M_SendingTouchEvents        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SendingPenEvent                         = GetBool(new IntPtr(p + 0x041)); // 027006750C30 0x41 M_SendingPenEvent           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Event                                   = GetObject<Event>(new IntPtr(p + 0x048), ReversePrism.DataModels.Event.FromPointer); // 027006750C50 0x48 M_Event                     ( 00018674CC10 ModelClassType Event Event Event Pointer )
            value.M_FocusedPanel                            = GetObject<BaseRuntimePanel>(new IntPtr(p + 0x050), ReversePrism.DataModels.BaseRuntimePanel.FromPointer); // 027006750C70 0x50 M_FocusedPanel              ( 000186742070 ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer )
            value.M_PreviousFocusedPanel                    = GetObject<BaseRuntimePanel>(new IntPtr(p + 0x058), ReversePrism.DataModels.BaseRuntimePanel.FromPointer); // 027006750C90 0x58 M_PreviousFocusedPanel      ( 000186742070 ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer )
            value.M_PreviousFocusedElement                  = GetObject<Focusable>(new IntPtr(p + 0x060), ReversePrism.DataModels.Focusable.FromPointer); // 027006750CB0 0x60 M_PreviousFocusedElement    ( 0001865D3CE0 ModelClassType Focusable Focusable Focusable Pointer )
            value.M_CurrentModifiers                        = (EventModifiers)GetInt32(new IntPtr(p + 0x068)); // 027006750CD0 0x68 M_CurrentModifiers          ( 00018675F1A0 ModelEnumType EventModifiers EventModifiers EventModifiers Int32 )
            value.M_LastMousePressButton                    = GetInt32(new IntPtr(p + 0x06C)); // 027006750CF0 0x6C M_LastMousePressButton      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_NextMousePressTime                      = GetSingle(new IntPtr(p + 0x070)); // 027006750D10 0x70 M_NextMousePressTime        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_LastMouseClickCount                     = GetInt32(new IntPtr(p + 0x074)); // 027006750D30 0x74 M_LastMouseClickCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_LastMousePosition                       = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 027006750D50 0x78 M_LastMousePosition         ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_MouseProcessedAtLeastOnce               = GetBool(new IntPtr(p + 0x080)); // 027006750D70 0x80 M_MouseProcessedAtLeastOnce ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ConsecutiveMoveCount                    = GetInt32(new IntPtr(p + 0x084)); // 027006750D90 0x84 M_ConsecutiveMoveCount      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_LastMoveVector                          = (Vector2)GetInt32(new IntPtr(p + 0x088)); // 027006750DB0 0x88 M_LastMoveVector            ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_PrevActionTime                          = GetSingle(new IntPtr(p + 0x090)); // 027006750DD0 0x90 M_PrevActionTime            ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
