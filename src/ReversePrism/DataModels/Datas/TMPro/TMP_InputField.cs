using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 M_SoftKeyboard                           ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer
    // 000 kSeparators                              char[] IL2CPP_TYPE_SZARRAY
    // 108 M_RectTransform                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 110 M_TextViewport                           ModelClassType RectTransform RectTransform RectTransform Pointer
    // 118 M_TextComponentRectMask                  ModelClassType RectMask2D RectMask2D RectMask2D Pointer
    // 120 M_TextViewportRectMask                   ModelClassType RectMask2D RectMask2D RectMask2D Pointer
    // 128 M_CachedViewportRect                     ModelEnumType Rect Rect Rect Int32
    // 138 M_TextComponent                          ModelClassType TMP_Text TMP_Text TMP_Text Pointer
    // 140 M_TextComponentRectTransform             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 148 M_Placeholder                            ModelClassType Graphic Graphic Graphic Pointer
    // 150 M_VerticalScrollbar                      ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 158 M_VerticalScrollbarEventHandler          ModelClassType TMP_ScrollbarEventHandler TMP_ScrollbarEventHandler TMP_ScrollbarEventHandler Pointer
    // 160 M_IsDrivenByLayoutComponents             ModelPrimitiveType bool bool bool Bool
    // 168 M_LayoutGroup                            ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer
    // 170 M_IScrollHandlerParent                   ModelClassType IScrollHandler IScrollHandler IScrollHandler Pointer
    // 178 M_ScrollPosition                         ModelPrimitiveType float float float Single
    // 17C M_ScrollSensitivity                      ModelPrimitiveType float float float Single
    // 180 M_ContentType                            ModelEnumType ContentType ContentType ContentType Int32
    // 184 M_InputType                              ModelEnumType InputType InputType InputType Int32
    // 188 m_AsteriskChar                           char IL2CPP_TYPE_CHAR
    // 18C M_KeyboardType                           ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32
    // 190 M_LineType                               ModelEnumType LineType LineType LineType Int32
    // 194 M_HideMobileInput                        ModelPrimitiveType bool bool bool Bool
    // 195 M_HideSoftKeyboard                       ModelPrimitiveType bool bool bool Bool
    // 198 M_CharacterValidation                    ModelEnumType CharacterValidation CharacterValidation CharacterValidation Int32
    // 1A0 M_RegexValue                             ModelPrimitiveType string string string String
    // 1A8 M_GlobalPointSize                        ModelPrimitiveType float float float Single
    // 1AC M_CharacterLimit                         ModelPrimitiveType int int int Int32
    // 1B0 M_OnEndEdit                              ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer
    // 1B8 M_OnSubmit                               ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer
    // 1C0 M_OnSelect                               ModelClassType SelectionEvent SelectionEvent SelectionEvent Pointer
    // 1C8 M_OnDeselect                             ModelClassType SelectionEvent SelectionEvent SelectionEvent Pointer
    // 1D0 M_OnTextSelection                        ModelClassType TextSelectionEvent TextSelectionEvent TextSelectionEvent Pointer
    // 1D8 M_OnEndTextSelection                     ModelClassType TextSelectionEvent TextSelectionEvent TextSelectionEvent Pointer
    // 1E0 M_OnValueChanged                         ModelClassType OnChangeEvent OnChangeEvent OnChangeEvent Pointer
    // 1E8 M_OnTouchScreenKeyboardStatusChanged     ModelClassType TouchScreenKeyboardEvent TouchScreenKeyboardEvent TouchScreenKeyboardEvent Pointer
    // 1F0 M_OnValidateInput                        ModelClassType OnValidateInput OnValidateInput OnValidateInput Pointer
    // 1F8 M_CaretColor                             ModelEnumType Color Color Color Int32
    // 208 M_CustomCaretColor                       ModelPrimitiveType bool bool bool Bool
    // 20C M_SelectionColor                         ModelEnumType Color Color Color Int32
    // 220 M_Text                                   ModelPrimitiveType string string string String
    // 228 M_CaretBlinkRate                         ModelPrimitiveType float float float Single
    // 22C M_CaretWidth                             ModelPrimitiveType int int int Int32
    // 230 M_ReadOnly                               ModelPrimitiveType bool bool bool Bool
    // 231 M_RichText                               ModelPrimitiveType bool bool bool Bool
    // 234 M_StringPosition                         ModelPrimitiveType int int int Int32
    // 238 M_StringSelectPosition                   ModelPrimitiveType int int int Int32
    // 23C M_CaretPosition                          ModelPrimitiveType int int int Int32
    // 240 M_CaretSelectPosition                    ModelPrimitiveType int int int Int32
    // 248 CaretRectTrans                           ModelClassType RectTransform RectTransform RectTransform Pointer
    // 250 M_CursorVerts                            ModelEnumListType UIVertex[] UIVertex[] List<UIVertex> Pointer
    // 258 M_CachedInputRenderer                    ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer
    // 260 M_LastPosition                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 268 M_Mesh                                   ModelClassType Mesh Mesh Mesh Pointer
    // 270 M_AllowInput                             ModelPrimitiveType bool bool bool Bool
    // 271 M_ShouldActivateNextUpdate               ModelPrimitiveType bool bool bool Bool
    // 272 M_UpdateDrag                             ModelPrimitiveType bool bool bool Bool
    // 273 M_DragPositionOutOfBounds                ModelPrimitiveType bool bool bool Bool
    // 000 kHScrollSpeed                            float IL2CPP_TYPE_R4
    // 000 kVScrollSpeed                            float IL2CPP_TYPE_R4
    // 274 M_CaretVisible                           ModelPrimitiveType bool bool bool Bool
    // 278 M_BlinkCoroutine                         ModelClassType Coroutine Coroutine Coroutine Pointer
    // 280 M_BlinkStartTime                         ModelPrimitiveType float float float Single
    // 288 M_DragCoroutine                          ModelClassType Coroutine Coroutine Coroutine Pointer
    // 290 M_OriginalText                           ModelPrimitiveType string string string String
    // 298 M_WasCanceled                            ModelPrimitiveType bool bool bool Bool
    // 299 M_HasDoneFocusTransition                 ModelPrimitiveType bool bool bool Bool
    // 2A0 M_WaitForSecondsRealtime                 ModelClassType WaitForSecondsRealtime WaitForSecondsRealtime WaitForSecondsRealtime Pointer
    // 2A8 M_PreventCallback                        ModelPrimitiveType bool bool bool Bool
    // 2A9 M_TouchKeyboardAllowsInPlaceEditing      ModelPrimitiveType bool bool bool Bool
    // 2AA M_IsTextComponentUpdateRequired          ModelPrimitiveType bool bool bool Bool
    // 2AB M_isLastKeyBackspace                     ModelPrimitiveType bool bool bool Bool
    // 2AC M_PointerDownClickStartTime              ModelPrimitiveType float float float Single
    // 2B0 M_KeyDownStartTime                       ModelPrimitiveType float float float Single
    // 2B4 M_DoubleClickDelay                       ModelPrimitiveType float float float Single
    // 000 kEmailSpecialCharacters                  string IL2CPP_TYPE_STRING
    // 2B8 M_IsCompositionActive                    ModelPrimitiveType bool bool bool Bool
    // 2B9 M_ShouldUpdateIMEWindowPosition          ModelPrimitiveType bool bool bool Bool
    // 2BC M_PreviousIMEInsertionLine               ModelPrimitiveType int int int Int32
    // 2C0 M_GlobalFontAsset                        ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 2C8 M_OnFocusSelectAll                       ModelPrimitiveType bool bool bool Bool
    // 2C9 M_isSelectAll                            ModelPrimitiveType bool bool bool Bool
    // 2CA M_ResetOnDeActivation                    ModelPrimitiveType bool bool bool Bool
    // 2CB M_SelectionStillActive                   ModelPrimitiveType bool bool bool Bool
    // 2CC M_ReleaseSelection                       ModelPrimitiveType bool bool bool Bool
    // 2D0 M_PreviouslySelectedObject               ModelClassType GameObject GameObject GameObject Pointer
    // 2D8 M_RestoreOriginalTextOnEscape            ModelPrimitiveType bool bool bool Bool
    // 2D9 M_isRichTextEditingAllowed               ModelPrimitiveType bool bool bool Bool
    // 2DC M_LineLimit                              ModelPrimitiveType int int int Int32
    // 2E0 M_InputValidator                         ModelClassType TMP_InputValidator TMP_InputValidator TMP_InputValidator Pointer
    // 2E8 M_isSelected                             ModelPrimitiveType bool bool bool Bool
    // 2E9 M_IsStringPositionDirty                  ModelPrimitiveType bool bool bool Bool
    // 2EA M_IsCaretPositionDirty                   ModelPrimitiveType bool bool bool Bool
    // 2EB M_forceRectTransformAdjustment           ModelPrimitiveType bool bool bool Bool
    // 2F0 M_ProcessingEvent                        ModelClassType Event Event Event Pointer
    public partial class TMP_InputField : DataModel
    {
        public TouchScreenKeyboard?                     M_SoftKeyboard                          { get; set; }
        public RectTransform?                           M_RectTransform                         { get; set; }
        public RectTransform?                           M_TextViewport                          { get; set; }
        public RectMask2D?                              M_TextComponentRectMask                 { get; set; }
        public RectMask2D?                              M_TextViewportRectMask                  { get; set; }
        public Rect                                     M_CachedViewportRect                    { get; set; }
        public TMP_Text?                                M_TextComponent                         { get; set; }
        public RectTransform?                           M_TextComponentRectTransform            { get; set; }
        public Graphic?                                 M_Placeholder                           { get; set; }
        public Scrollbar?                               M_VerticalScrollbar                     { get; set; }
        public TMP_ScrollbarEventHandler?               M_VerticalScrollbarEventHandler         { get; set; }
        public bool                                     M_IsDrivenByLayoutComponents            { get; set; }
        public LayoutGroup?                             M_LayoutGroup                           { get; set; }
        public IScrollHandler?                          M_IScrollHandlerParent                  { get; set; }
        public float                                    M_ScrollPosition                        { get; set; }
        public float                                    M_ScrollSensitivity                     { get; set; }
        public ContentType                              M_ContentType                           { get; set; }
        public InputType                                M_InputType                             { get; set; }
        public TouchScreenKeyboardType                  M_KeyboardType                          { get; set; }
        public LineType                                 M_LineType                              { get; set; }
        public bool                                     M_HideMobileInput                       { get; set; }
        public bool                                     M_HideSoftKeyboard                      { get; set; }
        public CharacterValidation                      M_CharacterValidation                   { get; set; }
        public string                                   M_RegexValue                            { get; set; }
        public float                                    M_GlobalPointSize                       { get; set; }
        public int                                      M_CharacterLimit                        { get; set; }
        public SubmitEvent?                             M_OnEndEdit                             { get; set; }
        public SubmitEvent?                             M_OnSubmit                              { get; set; }
        public SelectionEvent?                          M_OnSelect                              { get; set; }
        public SelectionEvent?                          M_OnDeselect                            { get; set; }
        public TextSelectionEvent?                      M_OnTextSelection                       { get; set; }
        public TextSelectionEvent?                      M_OnEndTextSelection                    { get; set; }
        public OnChangeEvent?                           M_OnValueChanged                        { get; set; }
        public TouchScreenKeyboardEvent?                M_OnTouchScreenKeyboardStatusChanged    { get; set; }
        public OnValidateInput?                         M_OnValidateInput                       { get; set; }
        public Color                                    M_CaretColor                            { get; set; }
        public bool                                     M_CustomCaretColor                      { get; set; }
        public Color                                    M_SelectionColor                        { get; set; }
        public string                                   M_Text                                  { get; set; }
        public float                                    M_CaretBlinkRate                        { get; set; }
        public int                                      M_CaretWidth                            { get; set; }
        public bool                                     M_ReadOnly                              { get; set; }
        public bool                                     M_RichText                              { get; set; }
        public int                                      M_StringPosition                        { get; set; }
        public int                                      M_StringSelectPosition                  { get; set; }
        public int                                      M_CaretPosition                         { get; set; }
        public int                                      M_CaretSelectPosition                   { get; set; }
        public RectTransform?                           CaretRectTrans                          { get; set; }
        public List<UIVertex>?                          M_CursorVerts                           { get; set; }
        public CanvasRenderer?                          M_CachedInputRenderer                   { get; set; }
        public Vector2                                  M_LastPosition                          { get; set; }
        public Mesh?                                    M_Mesh                                  { get; set; }
        public bool                                     M_AllowInput                            { get; set; }
        public bool                                     M_ShouldActivateNextUpdate              { get; set; }
        public bool                                     M_UpdateDrag                            { get; set; }
        public bool                                     M_DragPositionOutOfBounds               { get; set; }
        public bool                                     M_CaretVisible                          { get; set; }
        public Coroutine?                               M_BlinkCoroutine                        { get; set; }
        public float                                    M_BlinkStartTime                        { get; set; }
        public Coroutine?                               M_DragCoroutine                         { get; set; }
        public string                                   M_OriginalText                          { get; set; }
        public bool                                     M_WasCanceled                           { get; set; }
        public bool                                     M_HasDoneFocusTransition                { get; set; }
        public WaitForSecondsRealtime?                  M_WaitForSecondsRealtime                { get; set; }
        public bool                                     M_PreventCallback                       { get; set; }
        public bool                                     M_TouchKeyboardAllowsInPlaceEditing     { get; set; }
        public bool                                     M_IsTextComponentUpdateRequired         { get; set; }
        public bool                                     M_isLastKeyBackspace                    { get; set; }
        public float                                    M_PointerDownClickStartTime             { get; set; }
        public float                                    M_KeyDownStartTime                      { get; set; }
        public float                                    M_DoubleClickDelay                      { get; set; }
        public bool                                     M_IsCompositionActive                   { get; set; }
        public bool                                     M_ShouldUpdateIMEWindowPosition         { get; set; }
        public int                                      M_PreviousIMEInsertionLine              { get; set; }
        public TMP_FontAsset?                           M_GlobalFontAsset                       { get; set; }
        public bool                                     M_OnFocusSelectAll                      { get; set; }
        public bool                                     M_isSelectAll                           { get; set; }
        public bool                                     M_ResetOnDeActivation                   { get; set; }
        public bool                                     M_SelectionStillActive                  { get; set; }
        public bool                                     M_ReleaseSelection                      { get; set; }
        public GameObject?                              M_PreviouslySelectedObject              { get; set; }
        public bool                                     M_RestoreOriginalTextOnEscape           { get; set; }
        public bool                                     M_isRichTextEditingAllowed              { get; set; }
        public int                                      M_LineLimit                             { get; set; }
        public TMP_InputValidator?                      M_InputValidator                        { get; set; }
        public bool                                     M_isSelected                            { get; set; }
        public bool                                     M_IsStringPositionDirty                 { get; set; }
        public bool                                     M_IsCaretPositionDirty                  { get; set; }
        public bool                                     M_forceRectTransformAdjustment          { get; set; }
        public Event?                                   M_ProcessingEvent                       { get; set; }

        public static TMP_InputField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_InputField() { Pointer= p0 };

            value.M_SoftKeyboard                            = GetObject<TouchScreenKeyboard>(new IntPtr(p + 0x100), ReversePrism.DataModels.TouchScreenKeyboard.FromPointer); // 0x100 M_SoftKeyboard              ( ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer )
            value.M_RectTransform                           = GetObject<RectTransform>(new IntPtr(p + 0x108), ReversePrism.DataModels.RectTransform.FromPointer); // 0x108 M_RectTransform             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_TextViewport                            = GetObject<RectTransform>(new IntPtr(p + 0x110), ReversePrism.DataModels.RectTransform.FromPointer); // 0x110 M_TextViewport              ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_TextComponentRectMask                   = GetObject<RectMask2D>(new IntPtr(p + 0x118), ReversePrism.DataModels.RectMask2D.FromPointer); // 0x118 M_TextComponentRectMask     ( ModelClassType RectMask2D RectMask2D RectMask2D Pointer )
            value.M_TextViewportRectMask                    = GetObject<RectMask2D>(new IntPtr(p + 0x120), ReversePrism.DataModels.RectMask2D.FromPointer); // 0x120 M_TextViewportRectMask      ( ModelClassType RectMask2D RectMask2D RectMask2D Pointer )
            value.M_CachedViewportRect                      = (Rect)GetInt32(new IntPtr(p + 0x128)); // 0x128 M_CachedViewportRect        ( ModelEnumType Rect Rect Rect Int32 )
            value.M_TextComponent                           = GetObject<TMP_Text>(new IntPtr(p + 0x138), ReversePrism.DataModels.TMP_Text.FromPointer); // 0x138 M_TextComponent             ( ModelClassType TMP_Text TMP_Text TMP_Text Pointer )
            value.M_TextComponentRectTransform              = GetObject<RectTransform>(new IntPtr(p + 0x140), ReversePrism.DataModels.RectTransform.FromPointer); // 0x140 M_TextComponentRectTransform ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Placeholder                             = GetObject<Graphic>(new IntPtr(p + 0x148), ReversePrism.DataModels.Graphic.FromPointer); // 0x148 M_Placeholder               ( ModelClassType Graphic Graphic Graphic Pointer )
            value.M_VerticalScrollbar                       = GetObject<Scrollbar>(new IntPtr(p + 0x150), ReversePrism.DataModels.Scrollbar.FromPointer); // 0x150 M_VerticalScrollbar         ( ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.M_VerticalScrollbarEventHandler           = GetObject<TMP_ScrollbarEventHandler>(new IntPtr(p + 0x158), ReversePrism.DataModels.TMP_ScrollbarEventHandler.FromPointer); // 0x158 M_VerticalScrollbarEventHandler ( ModelClassType TMP_ScrollbarEventHandler TMP_ScrollbarEventHandler TMP_ScrollbarEventHandler Pointer )
            value.M_IsDrivenByLayoutComponents              = GetBool(new IntPtr(p + 0x160)); // 0x160 M_IsDrivenByLayoutComponents ( ModelPrimitiveType bool bool bool Bool )
            value.M_LayoutGroup                             = GetObject<LayoutGroup>(new IntPtr(p + 0x168), ReversePrism.DataModels.LayoutGroup.FromPointer); // 0x168 M_LayoutGroup               ( ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer )
            value.M_IScrollHandlerParent                    = GetObject<IScrollHandler>(new IntPtr(p + 0x170), ReversePrism.DataModels.IScrollHandler.FromPointer); // 0x170 M_IScrollHandlerParent      ( ModelClassType IScrollHandler IScrollHandler IScrollHandler Pointer )
            value.M_ScrollPosition                          = GetSingle(new IntPtr(p + 0x178)); // 0x178 M_ScrollPosition            ( ModelPrimitiveType float float float Single )
            value.M_ScrollSensitivity                       = GetSingle(new IntPtr(p + 0x17C)); // 0x17C M_ScrollSensitivity         ( ModelPrimitiveType float float float Single )
            value.M_ContentType                             = (ContentType)GetInt32(new IntPtr(p + 0x180)); // 0x180 M_ContentType               ( ModelEnumType ContentType ContentType ContentType Int32 )
            value.M_InputType                               = (InputType)GetInt32(new IntPtr(p + 0x184)); // 0x184 M_InputType                 ( ModelEnumType InputType InputType InputType Int32 )
            value.M_KeyboardType                            = (TouchScreenKeyboardType)GetInt32(new IntPtr(p + 0x18C)); // 0x18C M_KeyboardType              ( ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32 )
            value.M_LineType                                = (LineType)GetInt32(new IntPtr(p + 0x190)); // 0x190 M_LineType                  ( ModelEnumType LineType LineType LineType Int32 )
            value.M_HideMobileInput                         = GetBool(new IntPtr(p + 0x194)); // 0x194 M_HideMobileInput           ( ModelPrimitiveType bool bool bool Bool )
            value.M_HideSoftKeyboard                        = GetBool(new IntPtr(p + 0x195)); // 0x195 M_HideSoftKeyboard          ( ModelPrimitiveType bool bool bool Bool )
            value.M_CharacterValidation                     = (CharacterValidation)GetInt32(new IntPtr(p + 0x198)); // 0x198 M_CharacterValidation       ( ModelEnumType CharacterValidation CharacterValidation CharacterValidation Int32 )
            value.M_RegexValue                              = GetString(new IntPtr(p + 0x1A0)); // 0x1A0 M_RegexValue                ( ModelPrimitiveType string string string String )
            value.M_GlobalPointSize                         = GetSingle(new IntPtr(p + 0x1A8)); // 0x1A8 M_GlobalPointSize           ( ModelPrimitiveType float float float Single )
            value.M_CharacterLimit                          = GetInt32(new IntPtr(p + 0x1AC)); // 0x1AC M_CharacterLimit            ( ModelPrimitiveType int int int Int32 )
            value.M_OnEndEdit                               = GetObject<SubmitEvent>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.SubmitEvent.FromPointer); // 0x1B0 M_OnEndEdit                 ( ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer )
            value.M_OnSubmit                                = GetObject<SubmitEvent>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.SubmitEvent.FromPointer); // 0x1B8 M_OnSubmit                  ( ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer )
            value.M_OnSelect                                = GetObject<SelectionEvent>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.SelectionEvent.FromPointer); // 0x1C0 M_OnSelect                  ( ModelClassType SelectionEvent SelectionEvent SelectionEvent Pointer )
            value.M_OnDeselect                              = GetObject<SelectionEvent>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.SelectionEvent.FromPointer); // 0x1C8 M_OnDeselect                ( ModelClassType SelectionEvent SelectionEvent SelectionEvent Pointer )
            value.M_OnTextSelection                         = GetObject<TextSelectionEvent>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.TextSelectionEvent.FromPointer); // 0x1D0 M_OnTextSelection           ( ModelClassType TextSelectionEvent TextSelectionEvent TextSelectionEvent Pointer )
            value.M_OnEndTextSelection                      = GetObject<TextSelectionEvent>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.TextSelectionEvent.FromPointer); // 0x1D8 M_OnEndTextSelection        ( ModelClassType TextSelectionEvent TextSelectionEvent TextSelectionEvent Pointer )
            value.M_OnValueChanged                          = GetObject<OnChangeEvent>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.OnChangeEvent.FromPointer); // 0x1E0 M_OnValueChanged            ( ModelClassType OnChangeEvent OnChangeEvent OnChangeEvent Pointer )
            value.M_OnTouchScreenKeyboardStatusChanged      = GetObject<TouchScreenKeyboardEvent>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.TouchScreenKeyboardEvent.FromPointer); // 0x1E8 M_OnTouchScreenKeyboardStatusChanged ( ModelClassType TouchScreenKeyboardEvent TouchScreenKeyboardEvent TouchScreenKeyboardEvent Pointer )
            value.M_OnValidateInput                         = GetObject<OnValidateInput>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.OnValidateInput.FromPointer); // 0x1F0 M_OnValidateInput           ( ModelClassType OnValidateInput OnValidateInput OnValidateInput Pointer )
            value.M_CaretColor                              = (Color)GetInt32(new IntPtr(p + 0x1F8)); // 0x1F8 M_CaretColor                ( ModelEnumType Color Color Color Int32 )
            value.M_CustomCaretColor                        = GetBool(new IntPtr(p + 0x208)); // 0x208 M_CustomCaretColor          ( ModelPrimitiveType bool bool bool Bool )
            value.M_SelectionColor                          = (Color)GetInt32(new IntPtr(p + 0x20C)); // 0x20C M_SelectionColor            ( ModelEnumType Color Color Color Int32 )
            value.M_Text                                    = GetString(new IntPtr(p + 0x220)); // 0x220 M_Text                      ( ModelPrimitiveType string string string String )
            value.M_CaretBlinkRate                          = GetSingle(new IntPtr(p + 0x228)); // 0x228 M_CaretBlinkRate            ( ModelPrimitiveType float float float Single )
            value.M_CaretWidth                              = GetInt32(new IntPtr(p + 0x22C)); // 0x22C M_CaretWidth                ( ModelPrimitiveType int int int Int32 )
            value.M_ReadOnly                                = GetBool(new IntPtr(p + 0x230)); // 0x230 M_ReadOnly                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_RichText                                = GetBool(new IntPtr(p + 0x231)); // 0x231 M_RichText                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_StringPosition                          = GetInt32(new IntPtr(p + 0x234)); // 0x234 M_StringPosition            ( ModelPrimitiveType int int int Int32 )
            value.M_StringSelectPosition                    = GetInt32(new IntPtr(p + 0x238)); // 0x238 M_StringSelectPosition      ( ModelPrimitiveType int int int Int32 )
            value.M_CaretPosition                           = GetInt32(new IntPtr(p + 0x23C)); // 0x23C M_CaretPosition             ( ModelPrimitiveType int int int Int32 )
            value.M_CaretSelectPosition                     = GetInt32(new IntPtr(p + 0x240)); // 0x240 M_CaretSelectPosition       ( ModelPrimitiveType int int int Int32 )
            value.CaretRectTrans                            = GetObject<RectTransform>(new IntPtr(p + 0x248), ReversePrism.DataModels.RectTransform.FromPointer); // 0x248 CaretRectTrans              ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_CursorVerts                             = GetEnumList<UIVertex>(new IntPtr(p + 0x250)); // 0x250 M_CursorVerts               ( ModelEnumListType UIVertex[] UIVertex[] List<UIVertex> Pointer )
            value.M_CachedInputRenderer                     = GetObject<CanvasRenderer>(new IntPtr(p + 0x258), ReversePrism.DataModels.CanvasRenderer.FromPointer); // 0x258 M_CachedInputRenderer       ( ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer )
            value.M_LastPosition                            = (Vector2)GetInt32(new IntPtr(p + 0x260)); // 0x260 M_LastPosition              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Mesh                                    = GetObject<Mesh>(new IntPtr(p + 0x268), ReversePrism.DataModels.Mesh.FromPointer); // 0x268 M_Mesh                      ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_AllowInput                              = GetBool(new IntPtr(p + 0x270)); // 0x270 M_AllowInput                ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShouldActivateNextUpdate                = GetBool(new IntPtr(p + 0x271)); // 0x271 M_ShouldActivateNextUpdate  ( ModelPrimitiveType bool bool bool Bool )
            value.M_UpdateDrag                              = GetBool(new IntPtr(p + 0x272)); // 0x272 M_UpdateDrag                ( ModelPrimitiveType bool bool bool Bool )
            value.M_DragPositionOutOfBounds                 = GetBool(new IntPtr(p + 0x273)); // 0x273 M_DragPositionOutOfBounds   ( ModelPrimitiveType bool bool bool Bool )
            value.M_CaretVisible                            = GetBool(new IntPtr(p + 0x274)); // 0x274 M_CaretVisible              ( ModelPrimitiveType bool bool bool Bool )
            value.M_BlinkCoroutine                          = GetObject<Coroutine>(new IntPtr(p + 0x278), ReversePrism.DataModels.Coroutine.FromPointer); // 0x278 M_BlinkCoroutine            ( ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.M_BlinkStartTime                          = GetSingle(new IntPtr(p + 0x280)); // 0x280 M_BlinkStartTime            ( ModelPrimitiveType float float float Single )
            value.M_DragCoroutine                           = GetObject<Coroutine>(new IntPtr(p + 0x288), ReversePrism.DataModels.Coroutine.FromPointer); // 0x288 M_DragCoroutine             ( ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.M_OriginalText                            = GetString(new IntPtr(p + 0x290)); // 0x290 M_OriginalText              ( ModelPrimitiveType string string string String )
            value.M_WasCanceled                             = GetBool(new IntPtr(p + 0x298)); // 0x298 M_WasCanceled               ( ModelPrimitiveType bool bool bool Bool )
            value.M_HasDoneFocusTransition                  = GetBool(new IntPtr(p + 0x299)); // 0x299 M_HasDoneFocusTransition    ( ModelPrimitiveType bool bool bool Bool )
            value.M_WaitForSecondsRealtime                  = GetObject<WaitForSecondsRealtime>(new IntPtr(p + 0x2A0), ReversePrism.DataModels.WaitForSecondsRealtime.FromPointer); // 0x2A0 M_WaitForSecondsRealtime    ( ModelClassType WaitForSecondsRealtime WaitForSecondsRealtime WaitForSecondsRealtime Pointer )
            value.M_PreventCallback                         = GetBool(new IntPtr(p + 0x2A8)); // 0x2A8 M_PreventCallback           ( ModelPrimitiveType bool bool bool Bool )
            value.M_TouchKeyboardAllowsInPlaceEditing       = GetBool(new IntPtr(p + 0x2A9)); // 0x2A9 M_TouchKeyboardAllowsInPlaceEditing ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsTextComponentUpdateRequired           = GetBool(new IntPtr(p + 0x2AA)); // 0x2AA M_IsTextComponentUpdateRequired ( ModelPrimitiveType bool bool bool Bool )
            value.M_isLastKeyBackspace                      = GetBool(new IntPtr(p + 0x2AB)); // 0x2AB M_isLastKeyBackspace        ( ModelPrimitiveType bool bool bool Bool )
            value.M_PointerDownClickStartTime               = GetSingle(new IntPtr(p + 0x2AC)); // 0x2AC M_PointerDownClickStartTime ( ModelPrimitiveType float float float Single )
            value.M_KeyDownStartTime                        = GetSingle(new IntPtr(p + 0x2B0)); // 0x2B0 M_KeyDownStartTime          ( ModelPrimitiveType float float float Single )
            value.M_DoubleClickDelay                        = GetSingle(new IntPtr(p + 0x2B4)); // 0x2B4 M_DoubleClickDelay          ( ModelPrimitiveType float float float Single )
            value.M_IsCompositionActive                     = GetBool(new IntPtr(p + 0x2B8)); // 0x2B8 M_IsCompositionActive       ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShouldUpdateIMEWindowPosition           = GetBool(new IntPtr(p + 0x2B9)); // 0x2B9 M_ShouldUpdateIMEWindowPosition ( ModelPrimitiveType bool bool bool Bool )
            value.M_PreviousIMEInsertionLine                = GetInt32(new IntPtr(p + 0x2BC)); // 0x2BC M_PreviousIMEInsertionLine  ( ModelPrimitiveType int int int Int32 )
            value.M_GlobalFontAsset                         = GetObject<TMP_FontAsset>(new IntPtr(p + 0x2C0), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0x2C0 M_GlobalFontAsset           ( ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.M_OnFocusSelectAll                        = GetBool(new IntPtr(p + 0x2C8)); // 0x2C8 M_OnFocusSelectAll          ( ModelPrimitiveType bool bool bool Bool )
            value.M_isSelectAll                             = GetBool(new IntPtr(p + 0x2C9)); // 0x2C9 M_isSelectAll               ( ModelPrimitiveType bool bool bool Bool )
            value.M_ResetOnDeActivation                     = GetBool(new IntPtr(p + 0x2CA)); // 0x2CA M_ResetOnDeActivation       ( ModelPrimitiveType bool bool bool Bool )
            value.M_SelectionStillActive                    = GetBool(new IntPtr(p + 0x2CB)); // 0x2CB M_SelectionStillActive      ( ModelPrimitiveType bool bool bool Bool )
            value.M_ReleaseSelection                        = GetBool(new IntPtr(p + 0x2CC)); // 0x2CC M_ReleaseSelection          ( ModelPrimitiveType bool bool bool Bool )
            value.M_PreviouslySelectedObject                = GetObject<GameObject>(new IntPtr(p + 0x2D0), ReversePrism.DataModels.GameObject.FromPointer); // 0x2D0 M_PreviouslySelectedObject  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.M_RestoreOriginalTextOnEscape             = GetBool(new IntPtr(p + 0x2D8)); // 0x2D8 M_RestoreOriginalTextOnEscape ( ModelPrimitiveType bool bool bool Bool )
            value.M_isRichTextEditingAllowed                = GetBool(new IntPtr(p + 0x2D9)); // 0x2D9 M_isRichTextEditingAllowed  ( ModelPrimitiveType bool bool bool Bool )
            value.M_LineLimit                               = GetInt32(new IntPtr(p + 0x2DC)); // 0x2DC M_LineLimit                 ( ModelPrimitiveType int int int Int32 )
            value.M_InputValidator                          = GetObject<TMP_InputValidator>(new IntPtr(p + 0x2E0), ReversePrism.DataModels.TMP_InputValidator.FromPointer); // 0x2E0 M_InputValidator            ( ModelClassType TMP_InputValidator TMP_InputValidator TMP_InputValidator Pointer )
            value.M_isSelected                              = GetBool(new IntPtr(p + 0x2E8)); // 0x2E8 M_isSelected                ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsStringPositionDirty                   = GetBool(new IntPtr(p + 0x2E9)); // 0x2E9 M_IsStringPositionDirty     ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsCaretPositionDirty                    = GetBool(new IntPtr(p + 0x2EA)); // 0x2EA M_IsCaretPositionDirty      ( ModelPrimitiveType bool bool bool Bool )
            value.M_forceRectTransformAdjustment            = GetBool(new IntPtr(p + 0x2EB)); // 0x2EB M_forceRectTransformAdjustment ( ModelPrimitiveType bool bool bool Bool )
            value.M_ProcessingEvent                         = GetObject<Event>(new IntPtr(p + 0x2F0), ReversePrism.DataModels.Event.FromPointer); // 0x2F0 M_ProcessingEvent           ( ModelClassType Event Event Event Pointer )

            return value;
        }
    }
}
