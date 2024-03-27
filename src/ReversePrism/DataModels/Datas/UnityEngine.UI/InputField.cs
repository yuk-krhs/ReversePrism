using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 M_Keyboard                               000186691D80 ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer
    // 000 kSeparators                              char[] IL2CPP_TYPE_SZARRAY
    // 008 s_IsQuestDevice                          bool IL2CPP_TYPE_BOOLEAN
    // 108 M_TextComponent                          000186631E10 ModelClassType Text Text Text Pointer
    // 110 M_Placeholder                            000186692340 ModelClassType Graphic Graphic Graphic Pointer
    // 118 M_ContentType                            00018662FAC0 ModelEnumType ContentType ContentType ContentType Int32
    // 11C M_InputType                              000186630BA0 ModelEnumType InputType InputType InputType Int32
    // 120 m_AsteriskChar                           char IL2CPP_TYPE_CHAR
    // 124 M_KeyboardType                           000186692500 ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32
    // 128 M_LineType                               0001866312E0 ModelEnumType LineType LineType LineType Int32
    // 12C M_HideMobileInput                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 130 M_CharacterValidation                    00018662F510 ModelEnumType CharacterValidation CharacterValidation CharacterValidation Int32
    // 134 M_CharacterLimit                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 138 M_OnSubmit                               000186632410 ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer
    // 140 M_OnDidEndEdit                           0001866306B0 ModelClassType EndEditEvent EndEditEvent EndEditEvent Pointer
    // 148 M_OnValueChanged                         000186631A20 ModelClassType OnChangeEvent OnChangeEvent OnChangeEvent Pointer
    // 150 M_OnValidateInput                        000186631F20 ModelClassType OnValidateInput OnValidateInput OnValidateInput Pointer
    // 158 M_CaretColor                             0001865AA8E0 ModelEnumType Color Color Color Int32
    // 168 M_CustomCaretColor                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 16C M_SelectionColor                         0001865AA8E0 ModelEnumType Color Color Color Int32
    // 180 M_Text                                   000186671E00 ModelPrimitiveType string string string String
    // 188 M_CaretBlinkRate                         0001866656B0 ModelPrimitiveType float float float Single
    // 18C M_CaretWidth                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 190 M_ReadOnly                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 191 M_ShouldActivateOnSelect                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 194 M_CaretPosition                          0001865F3220 ModelPrimitiveType int int int Int32
    // 198 M_CaretSelectPosition                    0001865F3220 ModelPrimitiveType int int int Int32
    // 1A0 CaretRectTrans                           000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 1A8 M_CursorVerts                            000185CAE838 ModelEnumListType UIVertex[] UIVertex[] List<UIVertex> Pointer
    // 1B0 M_InputTextCache                         00018663C980 ModelClassType TextGenerator TextGenerator TextGenerator Pointer
    // 1B8 M_CachedInputRenderer                    000186541E60 ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer
    // 1C0 M_PreventFontCallback                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1C8 M_Mesh                                   0001866112E0 ModelClassType Mesh Mesh Mesh Pointer
    // 1D0 M_AllowInput                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1D1 M_ShouldActivateNextUpdate               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1D2 M_UpdateDrag                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1D3 M_DragPositionOutOfBounds                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 kHScrollSpeed                            float IL2CPP_TYPE_R4
    // 000 kVScrollSpeed                            float IL2CPP_TYPE_R4
    // 1D4 M_CaretVisible                           000186595480 ModelPrimitiveType bool bool bool Bool
    // 1D8 M_BlinkCoroutine                         000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer
    // 1E0 M_BlinkStartTime                         0001866656B0 ModelPrimitiveType float float float Single
    // 1E4 M_DrawStart                              0001865F3220 ModelPrimitiveType int int int Int32
    // 1E8 M_DrawEnd                                0001865F3220 ModelPrimitiveType int int int Int32
    // 1F0 M_DragCoroutine                          000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer
    // 1F8 M_OriginalText                           000186671910 ModelPrimitiveType string string string String
    // 200 M_WasCanceled                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 201 M_HasDoneFocusTransition                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 208 M_WaitForSecondsRealtime                 0001865428F0 ModelClassType WaitForSecondsRealtime WaitForSecondsRealtime WaitForSecondsRealtime Pointer
    // 210 M_TouchKeyboardAllowsInPlaceEditing      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 211 M_IsCompositionActive                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 kEmailSpecialCharacters                  string IL2CPP_TYPE_STRING
    // 000 kOculusQuestDeviceModel                  string IL2CPP_TYPE_STRING
    // 218 M_ProcessingEvent                        00018674CC10 ModelClassType Event Event Event Pointer
    // 000 k_MaxTextLength                          int IL2CPP_TYPE_I4
    public partial class InputField
    {
        public TouchScreenKeyboard?                     M_Keyboard                              { get; set; }
        public Text?                                    M_TextComponent                         { get; set; }
        public Graphic?                                 M_Placeholder                           { get; set; }
        public ContentType                              M_ContentType                           { get; set; }
        public InputType                                M_InputType                             { get; set; }
        public TouchScreenKeyboardType                  M_KeyboardType                          { get; set; }
        public LineType                                 M_LineType                              { get; set; }
        public bool                                     M_HideMobileInput                       { get; set; }
        public CharacterValidation                      M_CharacterValidation                   { get; set; }
        public int                                      M_CharacterLimit                        { get; set; }
        public SubmitEvent?                             M_OnSubmit                              { get; set; }
        public EndEditEvent?                            M_OnDidEndEdit                          { get; set; }
        public OnChangeEvent?                           M_OnValueChanged                        { get; set; }
        public OnValidateInput?                         M_OnValidateInput                       { get; set; }
        public Color                                    M_CaretColor                            { get; set; }
        public bool                                     M_CustomCaretColor                      { get; set; }
        public Color                                    M_SelectionColor                        { get; set; }
        public string                                   M_Text                                  { get; set; }
        public float                                    M_CaretBlinkRate                        { get; set; }
        public int                                      M_CaretWidth                            { get; set; }
        public bool                                     M_ReadOnly                              { get; set; }
        public bool                                     M_ShouldActivateOnSelect                { get; set; }
        public int                                      M_CaretPosition                         { get; set; }
        public int                                      M_CaretSelectPosition                   { get; set; }
        public RectTransform?                           CaretRectTrans                          { get; set; }
        public List<UIVertex>?                          M_CursorVerts                           { get; set; }
        public TextGenerator?                           M_InputTextCache                        { get; set; }
        public CanvasRenderer?                          M_CachedInputRenderer                   { get; set; }
        public bool                                     M_PreventFontCallback                   { get; set; }
        public Mesh?                                    M_Mesh                                  { get; set; }
        public bool                                     M_AllowInput                            { get; set; }
        public bool                                     M_ShouldActivateNextUpdate              { get; set; }
        public bool                                     M_UpdateDrag                            { get; set; }
        public bool                                     M_DragPositionOutOfBounds               { get; set; }
        public bool                                     M_CaretVisible                          { get; set; }
        public Coroutine?                               M_BlinkCoroutine                        { get; set; }
        public float                                    M_BlinkStartTime                        { get; set; }
        public int                                      M_DrawStart                             { get; set; }
        public int                                      M_DrawEnd                               { get; set; }
        public Coroutine?                               M_DragCoroutine                         { get; set; }
        public string                                   M_OriginalText                          { get; set; }
        public bool                                     M_WasCanceled                           { get; set; }
        public bool                                     M_HasDoneFocusTransition                { get; set; }
        public WaitForSecondsRealtime?                  M_WaitForSecondsRealtime                { get; set; }
        public bool                                     M_TouchKeyboardAllowsInPlaceEditing     { get; set; }
        public bool                                     M_IsCompositionActive                   { get; set; }
        public Event?                                   M_ProcessingEvent                       { get; set; }

        public static InputField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputField();

            value.M_Keyboard                                = GetObject<TouchScreenKeyboard>(new IntPtr(p + 0x100), ReversePrism.DataModels.TouchScreenKeyboard.FromPointer); // 0270068DCCC8 0x100 M_Keyboard                  ( 000186691D80 ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer )
            value.M_TextComponent                           = GetObject<Text>(new IntPtr(p + 0x108), ReversePrism.DataModels.Text.FromPointer); // 0270068DCD28 0x108 M_TextComponent             ( 000186631E10 ModelClassType Text Text Text Pointer )
            value.M_Placeholder                             = GetObject<Graphic>(new IntPtr(p + 0x110), ReversePrism.DataModels.Graphic.FromPointer); // 0270068DCD48 0x110 M_Placeholder               ( 000186692340 ModelClassType Graphic Graphic Graphic Pointer )
            value.M_ContentType                             = (ContentType)GetInt32(new IntPtr(p + 0x118)); // 0270068DCD68 0x118 M_ContentType               ( 00018662FAC0 ModelEnumType ContentType ContentType ContentType Int32 )
            value.M_InputType                               = (InputType)GetInt32(new IntPtr(p + 0x11C)); // 0270068DCD88 0x11C M_InputType                 ( 000186630BA0 ModelEnumType InputType InputType InputType Int32 )
            value.M_KeyboardType                            = (TouchScreenKeyboardType)GetInt32(new IntPtr(p + 0x124)); // 0270068DCDC8 0x124 M_KeyboardType              ( 000186692500 ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32 )
            value.M_LineType                                = (LineType)GetInt32(new IntPtr(p + 0x128)); // 0270068DCDE8 0x128 M_LineType                  ( 0001866312E0 ModelEnumType LineType LineType LineType Int32 )
            value.M_HideMobileInput                         = GetBool(new IntPtr(p + 0x12C)); // 0270068DCE08 0x12C M_HideMobileInput           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CharacterValidation                     = (CharacterValidation)GetInt32(new IntPtr(p + 0x130)); // 0270068DCE28 0x130 M_CharacterValidation       ( 00018662F510 ModelEnumType CharacterValidation CharacterValidation CharacterValidation Int32 )
            value.M_CharacterLimit                          = GetInt32(new IntPtr(p + 0x134)); // 0270068DCE48 0x134 M_CharacterLimit            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OnSubmit                                = GetObject<SubmitEvent>(new IntPtr(p + 0x138), ReversePrism.DataModels.SubmitEvent.FromPointer); // 0270068DCE68 0x138 M_OnSubmit                  ( 000186632410 ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer )
            value.M_OnDidEndEdit                            = GetObject<EndEditEvent>(new IntPtr(p + 0x140), ReversePrism.DataModels.EndEditEvent.FromPointer); // 0270068DCE88 0x140 M_OnDidEndEdit              ( 0001866306B0 ModelClassType EndEditEvent EndEditEvent EndEditEvent Pointer )
            value.M_OnValueChanged                          = GetObject<OnChangeEvent>(new IntPtr(p + 0x148), ReversePrism.DataModels.OnChangeEvent.FromPointer); // 0270068DCEA8 0x148 M_OnValueChanged            ( 000186631A20 ModelClassType OnChangeEvent OnChangeEvent OnChangeEvent Pointer )
            value.M_OnValidateInput                         = GetObject<OnValidateInput>(new IntPtr(p + 0x150), ReversePrism.DataModels.OnValidateInput.FromPointer); // 0270068DCEC8 0x150 M_OnValidateInput           ( 000186631F20 ModelClassType OnValidateInput OnValidateInput OnValidateInput Pointer )
            value.M_CaretColor                              = (Color)GetInt32(new IntPtr(p + 0x158)); // 0270068DCEE8 0x158 M_CaretColor                ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_CustomCaretColor                        = GetBool(new IntPtr(p + 0x168)); // 0270068DCF08 0x168 M_CustomCaretColor          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SelectionColor                          = (Color)GetInt32(new IntPtr(p + 0x16C)); // 0270068DCF28 0x16C M_SelectionColor            ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_Text                                    = GetString(new IntPtr(p + 0x180)); // 0270068DCF48 0x180 M_Text                      ( 000186671E00 ModelPrimitiveType string string string String )
            value.M_CaretBlinkRate                          = GetSingle(new IntPtr(p + 0x188)); // 0270068DCF68 0x188 M_CaretBlinkRate            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_CaretWidth                              = GetInt32(new IntPtr(p + 0x18C)); // 0270068DCF88 0x18C M_CaretWidth                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ReadOnly                                = GetBool(new IntPtr(p + 0x190)); // 0270068DCFA8 0x190 M_ReadOnly                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ShouldActivateOnSelect                  = GetBool(new IntPtr(p + 0x191)); // 0270068DCFC8 0x191 M_ShouldActivateOnSelect    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CaretPosition                           = GetInt32(new IntPtr(p + 0x194)); // 0270068DCFE8 0x194 M_CaretPosition             ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_CaretSelectPosition                     = GetInt32(new IntPtr(p + 0x198)); // 0270068DD008 0x198 M_CaretSelectPosition       ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.CaretRectTrans                            = GetObject<RectTransform>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.RectTransform.FromPointer); // 0270068DD028 0x1A0 CaretRectTrans              ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_CursorVerts                             = GetEnumList<UIVertex>(new IntPtr(p + 0x1A8)); // 0270068DD048 0x1A8 M_CursorVerts               ( 000185CAE838 ModelEnumListType UIVertex[] UIVertex[] List<UIVertex> Pointer )
            value.M_InputTextCache                          = GetObject<TextGenerator>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.TextGenerator.FromPointer); // 0270068DD068 0x1B0 M_InputTextCache            ( 00018663C980 ModelClassType TextGenerator TextGenerator TextGenerator Pointer )
            value.M_CachedInputRenderer                     = GetObject<CanvasRenderer>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.CanvasRenderer.FromPointer); // 0270068DD088 0x1B8 M_CachedInputRenderer       ( 000186541E60 ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer )
            value.M_PreventFontCallback                     = GetBool(new IntPtr(p + 0x1C0)); // 0270068DD0A8 0x1C0 M_PreventFontCallback       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Mesh                                    = GetObject<Mesh>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.Mesh.FromPointer); // 0270068DD0C8 0x1C8 M_Mesh                      ( 0001866112E0 ModelClassType Mesh Mesh Mesh Pointer )
            value.M_AllowInput                              = GetBool(new IntPtr(p + 0x1D0)); // 0270068DD0E8 0x1D0 M_AllowInput                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ShouldActivateNextUpdate                = GetBool(new IntPtr(p + 0x1D1)); // 0270068DD108 0x1D1 M_ShouldActivateNextUpdate  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_UpdateDrag                              = GetBool(new IntPtr(p + 0x1D2)); // 0270068DD128 0x1D2 M_UpdateDrag                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DragPositionOutOfBounds                 = GetBool(new IntPtr(p + 0x1D3)); // 0270068DD148 0x1D3 M_DragPositionOutOfBounds   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CaretVisible                            = GetBool(new IntPtr(p + 0x1D4)); // 0270068DD1A8 0x1D4 M_CaretVisible              ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_BlinkCoroutine                          = GetObject<Coroutine>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.Coroutine.FromPointer); // 0270068DD1C8 0x1D8 M_BlinkCoroutine            ( 000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.M_BlinkStartTime                          = GetSingle(new IntPtr(p + 0x1E0)); // 0270068DD1E8 0x1E0 M_BlinkStartTime            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DrawStart                               = GetInt32(new IntPtr(p + 0x1E4)); // 0270068DD208 0x1E4 M_DrawStart                 ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_DrawEnd                                 = GetInt32(new IntPtr(p + 0x1E8)); // 0270068DD228 0x1E8 M_DrawEnd                   ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_DragCoroutine                           = GetObject<Coroutine>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.Coroutine.FromPointer); // 0270068DD248 0x1F0 M_DragCoroutine             ( 000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.M_OriginalText                            = GetString(new IntPtr(p + 0x1F8)); // 0270068DD268 0x1F8 M_OriginalText              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_WasCanceled                             = GetBool(new IntPtr(p + 0x200)); // 0270068DD288 0x200 M_WasCanceled               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_HasDoneFocusTransition                  = GetBool(new IntPtr(p + 0x201)); // 0270068DD2A8 0x201 M_HasDoneFocusTransition    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_WaitForSecondsRealtime                  = GetObject<WaitForSecondsRealtime>(new IntPtr(p + 0x208), ReversePrism.DataModels.WaitForSecondsRealtime.FromPointer); // 0270068DD2C8 0x208 M_WaitForSecondsRealtime    ( 0001865428F0 ModelClassType WaitForSecondsRealtime WaitForSecondsRealtime WaitForSecondsRealtime Pointer )
            value.M_TouchKeyboardAllowsInPlaceEditing       = GetBool(new IntPtr(p + 0x210)); // 0270068DD2E8 0x210 M_TouchKeyboardAllowsInPlaceEditing ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsCompositionActive                     = GetBool(new IntPtr(p + 0x211)); // 0270068DD308 0x211 M_IsCompositionActive       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ProcessingEvent                         = GetObject<Event>(new IntPtr(p + 0x218), ReversePrism.DataModels.Event.FromPointer); // 0270068DD368 0x218 M_ProcessingEvent           ( 00018674CC10 ModelClassType Event Event Event Pointer )

            return value;
        }
    }
}
