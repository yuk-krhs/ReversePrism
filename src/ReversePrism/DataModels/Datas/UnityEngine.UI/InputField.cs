using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 M_Keyboard                               ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer
    // 000 kSeparators                              char[] IL2CPP_TYPE_SZARRAY
    // 008 s_IsQuestDevice                          bool IL2CPP_TYPE_BOOLEAN
    // 108 M_TextComponent                          ModelClassType Text Text Text Pointer
    // 110 M_Placeholder                            ModelClassType Graphic Graphic Graphic Pointer
    // 118 M_ContentType                            ModelEnumType ContentType ContentType ContentType Int32
    // 11C M_InputType                              ModelEnumType InputType InputType InputType Int32
    // 120 m_AsteriskChar                           char IL2CPP_TYPE_CHAR
    // 124 M_KeyboardType                           ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32
    // 128 M_LineType                               ModelEnumType LineType LineType LineType Int32
    // 12C M_HideMobileInput                        ModelPrimitiveType bool bool bool Bool
    // 130 M_CharacterValidation                    ModelEnumType CharacterValidation CharacterValidation CharacterValidation Int32
    // 134 M_CharacterLimit                         ModelPrimitiveType int int int Int32
    // 138 M_OnSubmit                               ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer
    // 140 M_OnDidEndEdit                           ModelClassType EndEditEvent EndEditEvent EndEditEvent Pointer
    // 148 M_OnValueChanged                         ModelClassType OnChangeEvent OnChangeEvent OnChangeEvent Pointer
    // 150 M_OnValidateInput                        ModelClassType OnValidateInput OnValidateInput OnValidateInput Pointer
    // 158 M_CaretColor                             ModelEnumType Color Color Color Int32
    // 168 M_CustomCaretColor                       ModelPrimitiveType bool bool bool Bool
    // 16C M_SelectionColor                         ModelEnumType Color Color Color Int32
    // 180 M_Text                                   ModelPrimitiveType string string string String
    // 188 M_CaretBlinkRate                         ModelPrimitiveType float float float Single
    // 18C M_CaretWidth                             ModelPrimitiveType int int int Int32
    // 190 M_ReadOnly                               ModelPrimitiveType bool bool bool Bool
    // 191 M_ShouldActivateOnSelect                 ModelPrimitiveType bool bool bool Bool
    // 194 M_CaretPosition                          ModelPrimitiveType int int int Int32
    // 198 M_CaretSelectPosition                    ModelPrimitiveType int int int Int32
    // 1A0 CaretRectTrans                           ModelClassType RectTransform RectTransform RectTransform Pointer
    // 1A8 M_CursorVerts                            ModelEnumListType UIVertex[] UIVertex[] List<UIVertex> Pointer
    // 1B0 M_InputTextCache                         ModelClassType TextGenerator TextGenerator TextGenerator Pointer
    // 1B8 M_CachedInputRenderer                    ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer
    // 1C0 M_PreventFontCallback                    ModelPrimitiveType bool bool bool Bool
    // 1C8 M_Mesh                                   ModelClassType Mesh Mesh Mesh Pointer
    // 1D0 M_AllowInput                             ModelPrimitiveType bool bool bool Bool
    // 1D1 M_ShouldActivateNextUpdate               ModelPrimitiveType bool bool bool Bool
    // 1D2 M_UpdateDrag                             ModelPrimitiveType bool bool bool Bool
    // 1D3 M_DragPositionOutOfBounds                ModelPrimitiveType bool bool bool Bool
    // 000 kHScrollSpeed                            float IL2CPP_TYPE_R4
    // 000 kVScrollSpeed                            float IL2CPP_TYPE_R4
    // 1D4 M_CaretVisible                           ModelPrimitiveType bool bool bool Bool
    // 1D8 M_BlinkCoroutine                         ModelClassType Coroutine Coroutine Coroutine Pointer
    // 1E0 M_BlinkStartTime                         ModelPrimitiveType float float float Single
    // 1E4 M_DrawStart                              ModelPrimitiveType int int int Int32
    // 1E8 M_DrawEnd                                ModelPrimitiveType int int int Int32
    // 1F0 M_DragCoroutine                          ModelClassType Coroutine Coroutine Coroutine Pointer
    // 1F8 M_OriginalText                           ModelPrimitiveType string string string String
    // 200 M_WasCanceled                            ModelPrimitiveType bool bool bool Bool
    // 201 M_HasDoneFocusTransition                 ModelPrimitiveType bool bool bool Bool
    // 208 M_WaitForSecondsRealtime                 ModelClassType WaitForSecondsRealtime WaitForSecondsRealtime WaitForSecondsRealtime Pointer
    // 210 M_TouchKeyboardAllowsInPlaceEditing      ModelPrimitiveType bool bool bool Bool
    // 211 M_IsCompositionActive                    ModelPrimitiveType bool bool bool Bool
    // 000 kEmailSpecialCharacters                  string IL2CPP_TYPE_STRING
    // 000 kOculusQuestDeviceModel                  string IL2CPP_TYPE_STRING
    // 218 M_ProcessingEvent                        ModelClassType Event Event Event Pointer
    // 000 k_MaxTextLength                          int IL2CPP_TYPE_I4
    public partial class InputField : DataModel
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
            var value   = new InputField() { Pointer= p0 };

            value.M_Keyboard                                = GetObject<TouchScreenKeyboard>(new IntPtr(p + 0x100), ReversePrism.DataModels.TouchScreenKeyboard.FromPointer); // 0x100 M_Keyboard                  ( ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer )
            value.M_TextComponent                           = GetObject<Text>(new IntPtr(p + 0x108), ReversePrism.DataModels.Text.FromPointer); // 0x108 M_TextComponent             ( ModelClassType Text Text Text Pointer )
            value.M_Placeholder                             = GetObject<Graphic>(new IntPtr(p + 0x110), ReversePrism.DataModels.Graphic.FromPointer); // 0x110 M_Placeholder               ( ModelClassType Graphic Graphic Graphic Pointer )
            value.M_ContentType                             = (ContentType)GetInt32(new IntPtr(p + 0x118)); // 0x118 M_ContentType               ( ModelEnumType ContentType ContentType ContentType Int32 )
            value.M_InputType                               = (InputType)GetInt32(new IntPtr(p + 0x11C)); // 0x11C M_InputType                 ( ModelEnumType InputType InputType InputType Int32 )
            value.M_KeyboardType                            = (TouchScreenKeyboardType)GetInt32(new IntPtr(p + 0x124)); // 0x124 M_KeyboardType              ( ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32 )
            value.M_LineType                                = (LineType)GetInt32(new IntPtr(p + 0x128)); // 0x128 M_LineType                  ( ModelEnumType LineType LineType LineType Int32 )
            value.M_HideMobileInput                         = GetBool(new IntPtr(p + 0x12C)); // 0x12C M_HideMobileInput           ( ModelPrimitiveType bool bool bool Bool )
            value.M_CharacterValidation                     = (CharacterValidation)GetInt32(new IntPtr(p + 0x130)); // 0x130 M_CharacterValidation       ( ModelEnumType CharacterValidation CharacterValidation CharacterValidation Int32 )
            value.M_CharacterLimit                          = GetInt32(new IntPtr(p + 0x134)); // 0x134 M_CharacterLimit            ( ModelPrimitiveType int int int Int32 )
            value.M_OnSubmit                                = GetObject<SubmitEvent>(new IntPtr(p + 0x138), ReversePrism.DataModels.SubmitEvent.FromPointer); // 0x138 M_OnSubmit                  ( ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer )
            value.M_OnDidEndEdit                            = GetObject<EndEditEvent>(new IntPtr(p + 0x140), ReversePrism.DataModels.EndEditEvent.FromPointer); // 0x140 M_OnDidEndEdit              ( ModelClassType EndEditEvent EndEditEvent EndEditEvent Pointer )
            value.M_OnValueChanged                          = GetObject<OnChangeEvent>(new IntPtr(p + 0x148), ReversePrism.DataModels.OnChangeEvent.FromPointer); // 0x148 M_OnValueChanged            ( ModelClassType OnChangeEvent OnChangeEvent OnChangeEvent Pointer )
            value.M_OnValidateInput                         = GetObject<OnValidateInput>(new IntPtr(p + 0x150), ReversePrism.DataModels.OnValidateInput.FromPointer); // 0x150 M_OnValidateInput           ( ModelClassType OnValidateInput OnValidateInput OnValidateInput Pointer )
            value.M_CaretColor                              = (Color)GetInt32(new IntPtr(p + 0x158)); // 0x158 M_CaretColor                ( ModelEnumType Color Color Color Int32 )
            value.M_CustomCaretColor                        = GetBool(new IntPtr(p + 0x168)); // 0x168 M_CustomCaretColor          ( ModelPrimitiveType bool bool bool Bool )
            value.M_SelectionColor                          = (Color)GetInt32(new IntPtr(p + 0x16C)); // 0x16C M_SelectionColor            ( ModelEnumType Color Color Color Int32 )
            value.M_Text                                    = GetString(new IntPtr(p + 0x180)); // 0x180 M_Text                      ( ModelPrimitiveType string string string String )
            value.M_CaretBlinkRate                          = GetSingle(new IntPtr(p + 0x188)); // 0x188 M_CaretBlinkRate            ( ModelPrimitiveType float float float Single )
            value.M_CaretWidth                              = GetInt32(new IntPtr(p + 0x18C)); // 0x18C M_CaretWidth                ( ModelPrimitiveType int int int Int32 )
            value.M_ReadOnly                                = GetBool(new IntPtr(p + 0x190)); // 0x190 M_ReadOnly                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShouldActivateOnSelect                  = GetBool(new IntPtr(p + 0x191)); // 0x191 M_ShouldActivateOnSelect    ( ModelPrimitiveType bool bool bool Bool )
            value.M_CaretPosition                           = GetInt32(new IntPtr(p + 0x194)); // 0x194 M_CaretPosition             ( ModelPrimitiveType int int int Int32 )
            value.M_CaretSelectPosition                     = GetInt32(new IntPtr(p + 0x198)); // 0x198 M_CaretSelectPosition       ( ModelPrimitiveType int int int Int32 )
            value.CaretRectTrans                            = GetObject<RectTransform>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.RectTransform.FromPointer); // 0x1A0 CaretRectTrans              ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_CursorVerts                             = GetEnumList<UIVertex>(new IntPtr(p + 0x1A8)); // 0x1A8 M_CursorVerts               ( ModelEnumListType UIVertex[] UIVertex[] List<UIVertex> Pointer )
            value.M_InputTextCache                          = GetObject<TextGenerator>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.TextGenerator.FromPointer); // 0x1B0 M_InputTextCache            ( ModelClassType TextGenerator TextGenerator TextGenerator Pointer )
            value.M_CachedInputRenderer                     = GetObject<CanvasRenderer>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.CanvasRenderer.FromPointer); // 0x1B8 M_CachedInputRenderer       ( ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer )
            value.M_PreventFontCallback                     = GetBool(new IntPtr(p + 0x1C0)); // 0x1C0 M_PreventFontCallback       ( ModelPrimitiveType bool bool bool Bool )
            value.M_Mesh                                    = GetObject<Mesh>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.Mesh.FromPointer); // 0x1C8 M_Mesh                      ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_AllowInput                              = GetBool(new IntPtr(p + 0x1D0)); // 0x1D0 M_AllowInput                ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShouldActivateNextUpdate                = GetBool(new IntPtr(p + 0x1D1)); // 0x1D1 M_ShouldActivateNextUpdate  ( ModelPrimitiveType bool bool bool Bool )
            value.M_UpdateDrag                              = GetBool(new IntPtr(p + 0x1D2)); // 0x1D2 M_UpdateDrag                ( ModelPrimitiveType bool bool bool Bool )
            value.M_DragPositionOutOfBounds                 = GetBool(new IntPtr(p + 0x1D3)); // 0x1D3 M_DragPositionOutOfBounds   ( ModelPrimitiveType bool bool bool Bool )
            value.M_CaretVisible                            = GetBool(new IntPtr(p + 0x1D4)); // 0x1D4 M_CaretVisible              ( ModelPrimitiveType bool bool bool Bool )
            value.M_BlinkCoroutine                          = GetObject<Coroutine>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.Coroutine.FromPointer); // 0x1D8 M_BlinkCoroutine            ( ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.M_BlinkStartTime                          = GetSingle(new IntPtr(p + 0x1E0)); // 0x1E0 M_BlinkStartTime            ( ModelPrimitiveType float float float Single )
            value.M_DrawStart                               = GetInt32(new IntPtr(p + 0x1E4)); // 0x1E4 M_DrawStart                 ( ModelPrimitiveType int int int Int32 )
            value.M_DrawEnd                                 = GetInt32(new IntPtr(p + 0x1E8)); // 0x1E8 M_DrawEnd                   ( ModelPrimitiveType int int int Int32 )
            value.M_DragCoroutine                           = GetObject<Coroutine>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.Coroutine.FromPointer); // 0x1F0 M_DragCoroutine             ( ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.M_OriginalText                            = GetString(new IntPtr(p + 0x1F8)); // 0x1F8 M_OriginalText              ( ModelPrimitiveType string string string String )
            value.M_WasCanceled                             = GetBool(new IntPtr(p + 0x200)); // 0x200 M_WasCanceled               ( ModelPrimitiveType bool bool bool Bool )
            value.M_HasDoneFocusTransition                  = GetBool(new IntPtr(p + 0x201)); // 0x201 M_HasDoneFocusTransition    ( ModelPrimitiveType bool bool bool Bool )
            value.M_WaitForSecondsRealtime                  = GetObject<WaitForSecondsRealtime>(new IntPtr(p + 0x208), ReversePrism.DataModels.WaitForSecondsRealtime.FromPointer); // 0x208 M_WaitForSecondsRealtime    ( ModelClassType WaitForSecondsRealtime WaitForSecondsRealtime WaitForSecondsRealtime Pointer )
            value.M_TouchKeyboardAllowsInPlaceEditing       = GetBool(new IntPtr(p + 0x210)); // 0x210 M_TouchKeyboardAllowsInPlaceEditing ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsCompositionActive                     = GetBool(new IntPtr(p + 0x211)); // 0x211 M_IsCompositionActive       ( ModelPrimitiveType bool bool bool Bool )
            value.M_ProcessingEvent                         = GetObject<Event>(new IntPtr(p + 0x218), ReversePrism.DataModels.Event.FromPointer); // 0x218 M_ProcessingEvent           ( ModelClassType Event Event Event Pointer )

            return value;
        }
    }
}
