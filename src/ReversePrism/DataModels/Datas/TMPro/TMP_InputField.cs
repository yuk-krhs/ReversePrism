using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 M_SoftKeyboard                           000186691D80 ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer
    // 000 kSeparators                              char[] IL2CPP_TYPE_SZARRAY
    // 108 M_RectTransform                          000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 110 M_TextViewport                           000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 118 M_TextComponentRectMask                  00018662EB70 ModelClassType RectMask2D RectMask2D RectMask2D Pointer
    // 120 M_TextViewportRectMask                   00018662EB70 ModelClassType RectMask2D RectMask2D RectMask2D Pointer
    // 128 M_CachedViewportRect                     00018664F620 ModelEnumType Rect Rect Rect Int32
    // 138 M_TextComponent                          000186613AD0 ModelClassType TMP_Text TMP_Text TMP_Text Pointer
    // 140 M_TextComponentRectTransform             000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 148 M_Placeholder                            000186692340 ModelClassType Graphic Graphic Graphic Pointer
    // 150 M_VerticalScrollbar                      0001866FA6F0 ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 158 M_VerticalScrollbarEventHandler          0001866109B0 ModelClassType TMP_ScrollbarEventHandler TMP_ScrollbarEventHandler TMP_ScrollbarEventHandler Pointer
    // 160 M_IsDrivenByLayoutComponents             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 168 M_LayoutGroup                            00018650CD20 ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer
    // 170 M_IScrollHandlerParent                   00018662B870 ModelClassType IScrollHandler IScrollHandler IScrollHandler Pointer
    // 178 M_ScrollPosition                         0001866656B0 ModelPrimitiveType float float float Single
    // 17C M_ScrollSensitivity                      000186665B50 ModelPrimitiveType float float float Single
    // 180 M_ContentType                            0001865E2C20 ModelEnumType ContentType ContentType ContentType Int32
    // 184 M_InputType                              0001865E37B0 ModelEnumType InputType InputType InputType Int32
    // 188 m_AsteriskChar                           char IL2CPP_TYPE_CHAR
    // 18C M_KeyboardType                           000186692500 ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32
    // 190 M_LineType                               0001865E3E70 ModelEnumType LineType LineType LineType Int32
    // 194 M_HideMobileInput                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 195 M_HideSoftKeyboard                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 198 M_CharacterValidation                    0001865E2650 ModelEnumType CharacterValidation CharacterValidation CharacterValidation Int32
    // 1A0 M_RegexValue                             000186671910 ModelPrimitiveType string string string String
    // 1A8 M_GlobalPointSize                        0001866656B0 ModelPrimitiveType float float float Single
    // 1AC M_CharacterLimit                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 1B0 M_OnEndEdit                              0001865E5350 ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer
    // 1B8 M_OnSubmit                               0001865E5350 ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer
    // 1C0 M_OnSelect                               0001865E4EA0 ModelClassType SelectionEvent SelectionEvent SelectionEvent Pointer
    // 1C8 M_OnDeselect                             0001865E4EA0 ModelClassType SelectionEvent SelectionEvent SelectionEvent Pointer
    // 1D0 M_OnTextSelection                        0001865E5810 ModelClassType TextSelectionEvent TextSelectionEvent TextSelectionEvent Pointer
    // 1D8 M_OnEndTextSelection                     0001865E5810 ModelClassType TextSelectionEvent TextSelectionEvent TextSelectionEvent Pointer
    // 1E0 M_OnValueChanged                         0001865E4570 ModelClassType OnChangeEvent OnChangeEvent OnChangeEvent Pointer
    // 1E8 M_OnTouchScreenKeyboardStatusChanged     0001865E5CB0 ModelClassType TouchScreenKeyboardEvent TouchScreenKeyboardEvent TouchScreenKeyboardEvent Pointer
    // 1F0 M_OnValidateInput                        0001865E49C0 ModelClassType OnValidateInput OnValidateInput OnValidateInput Pointer
    // 1F8 M_CaretColor                             0001865AA8E0 ModelEnumType Color Color Color Int32
    // 208 M_CustomCaretColor                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 20C M_SelectionColor                         0001865AA8E0 ModelEnumType Color Color Color Int32
    // 220 M_Text                                   000186671E00 ModelPrimitiveType string string string String
    // 228 M_CaretBlinkRate                         0001866656B0 ModelPrimitiveType float float float Single
    // 22C M_CaretWidth                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 230 M_ReadOnly                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 231 M_RichText                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 234 M_StringPosition                         0001865F3220 ModelPrimitiveType int int int Int32
    // 238 M_StringSelectPosition                   0001865F3220 ModelPrimitiveType int int int Int32
    // 23C M_CaretPosition                          0001865F3220 ModelPrimitiveType int int int Int32
    // 240 M_CaretSelectPosition                    0001865F3220 ModelPrimitiveType int int int Int32
    // 248 CaretRectTrans                           000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 250 M_CursorVerts                            000185CAE838 ModelEnumListType UIVertex[] UIVertex[] List<UIVertex> Pointer
    // 258 M_CachedInputRenderer                    000186541E60 ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer
    // 260 M_LastPosition                           0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 268 M_Mesh                                   0001866112E0 ModelClassType Mesh Mesh Mesh Pointer
    // 270 M_AllowInput                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 271 M_ShouldActivateNextUpdate               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 272 M_UpdateDrag                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 273 M_DragPositionOutOfBounds                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 kHScrollSpeed                            float IL2CPP_TYPE_R4
    // 000 kVScrollSpeed                            float IL2CPP_TYPE_R4
    // 274 M_CaretVisible                           000186595480 ModelPrimitiveType bool bool bool Bool
    // 278 M_BlinkCoroutine                         000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer
    // 280 M_BlinkStartTime                         0001866656B0 ModelPrimitiveType float float float Single
    // 288 M_DragCoroutine                          000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer
    // 290 M_OriginalText                           000186671910 ModelPrimitiveType string string string String
    // 298 M_WasCanceled                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 299 M_HasDoneFocusTransition                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2A0 M_WaitForSecondsRealtime                 0001865428F0 ModelClassType WaitForSecondsRealtime WaitForSecondsRealtime WaitForSecondsRealtime Pointer
    // 2A8 M_PreventCallback                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2A9 M_TouchKeyboardAllowsInPlaceEditing      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2AA M_IsTextComponentUpdateRequired          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2AB M_isLastKeyBackspace                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2AC M_PointerDownClickStartTime              0001866656B0 ModelPrimitiveType float float float Single
    // 2B0 M_KeyDownStartTime                       0001866656B0 ModelPrimitiveType float float float Single
    // 2B4 M_DoubleClickDelay                       0001866656B0 ModelPrimitiveType float float float Single
    // 000 kEmailSpecialCharacters                  string IL2CPP_TYPE_STRING
    // 2B8 M_IsCompositionActive                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2B9 M_ShouldUpdateIMEWindowPosition          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2BC M_PreviousIMEInsertionLine               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 2C0 M_GlobalFontAsset                        00018667FA70 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 2C8 M_OnFocusSelectAll                       000186595480 ModelPrimitiveType bool bool bool Bool
    // 2C9 M_isSelectAll                            000186595480 ModelPrimitiveType bool bool bool Bool
    // 2CA M_ResetOnDeActivation                    000186595480 ModelPrimitiveType bool bool bool Bool
    // 2CB M_SelectionStillActive                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2CC M_ReleaseSelection                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2D0 M_PreviouslySelectedObject               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 2D8 M_RestoreOriginalTextOnEscape            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2D9 M_isRichTextEditingAllowed               000186595480 ModelPrimitiveType bool bool bool Bool
    // 2DC M_LineLimit                              0001865F3220 ModelPrimitiveType int int int Int32
    // 2E0 M_InputValidator                         00018660E3F0 ModelClassType TMP_InputValidator TMP_InputValidator TMP_InputValidator Pointer
    // 2E8 M_isSelected                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2E9 M_IsStringPositionDirty                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2EA M_IsCaretPositionDirty                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2EB M_forceRectTransformAdjustment           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 2F0 M_ProcessingEvent                        00018674CC10 ModelClassType Event Event Event Pointer
    public partial class TMP_InputField
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
            var value   = new TMP_InputField();

            value.M_SoftKeyboard                            = GetObject<TouchScreenKeyboard>(new IntPtr(p + 0x100), ReversePrism.DataModels.TouchScreenKeyboard.FromPointer); // 027004397BA0 0x100 M_SoftKeyboard              ( 000186691D80 ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer )
            value.M_RectTransform                           = GetObject<RectTransform>(new IntPtr(p + 0x108), ReversePrism.DataModels.RectTransform.FromPointer); // 027004397BE0 0x108 M_RectTransform             ( 000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_TextViewport                            = GetObject<RectTransform>(new IntPtr(p + 0x110), ReversePrism.DataModels.RectTransform.FromPointer); // 027004397C00 0x110 M_TextViewport              ( 000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_TextComponentRectMask                   = GetObject<RectMask2D>(new IntPtr(p + 0x118), ReversePrism.DataModels.RectMask2D.FromPointer); // 027004397C20 0x118 M_TextComponentRectMask     ( 00018662EB70 ModelClassType RectMask2D RectMask2D RectMask2D Pointer )
            value.M_TextViewportRectMask                    = GetObject<RectMask2D>(new IntPtr(p + 0x120), ReversePrism.DataModels.RectMask2D.FromPointer); // 027004397C40 0x120 M_TextViewportRectMask      ( 00018662EB70 ModelClassType RectMask2D RectMask2D RectMask2D Pointer )
            value.M_CachedViewportRect                      = (Rect)GetInt32(new IntPtr(p + 0x128)); // 027004397C60 0x128 M_CachedViewportRect        ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )
            value.M_TextComponent                           = GetObject<TMP_Text>(new IntPtr(p + 0x138), ReversePrism.DataModels.TMP_Text.FromPointer); // 027004397C80 0x138 M_TextComponent             ( 000186613AD0 ModelClassType TMP_Text TMP_Text TMP_Text Pointer )
            value.M_TextComponentRectTransform              = GetObject<RectTransform>(new IntPtr(p + 0x140), ReversePrism.DataModels.RectTransform.FromPointer); // 027004397CA0 0x140 M_TextComponentRectTransform ( 000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Placeholder                             = GetObject<Graphic>(new IntPtr(p + 0x148), ReversePrism.DataModels.Graphic.FromPointer); // 027004397CC0 0x148 M_Placeholder               ( 000186692340 ModelClassType Graphic Graphic Graphic Pointer )
            value.M_VerticalScrollbar                       = GetObject<Scrollbar>(new IntPtr(p + 0x150), ReversePrism.DataModels.Scrollbar.FromPointer); // 027004397CE0 0x150 M_VerticalScrollbar         ( 0001866FA6F0 ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.M_VerticalScrollbarEventHandler           = GetObject<TMP_ScrollbarEventHandler>(new IntPtr(p + 0x158), ReversePrism.DataModels.TMP_ScrollbarEventHandler.FromPointer); // 027004397D00 0x158 M_VerticalScrollbarEventHandler ( 0001866109B0 ModelClassType TMP_ScrollbarEventHandler TMP_ScrollbarEventHandler TMP_ScrollbarEventHandler Pointer )
            value.M_IsDrivenByLayoutComponents              = GetBool(new IntPtr(p + 0x160)); // 027004397D20 0x160 M_IsDrivenByLayoutComponents ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_LayoutGroup                             = GetObject<LayoutGroup>(new IntPtr(p + 0x168), ReversePrism.DataModels.LayoutGroup.FromPointer); // 027004397D40 0x168 M_LayoutGroup               ( 00018650CD20 ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer )
            value.M_IScrollHandlerParent                    = GetObject<IScrollHandler>(new IntPtr(p + 0x170), ReversePrism.DataModels.IScrollHandler.FromPointer); // 027004397D60 0x170 M_IScrollHandlerParent      ( 00018662B870 ModelClassType IScrollHandler IScrollHandler IScrollHandler Pointer )
            value.M_ScrollPosition                          = GetSingle(new IntPtr(p + 0x178)); // 027004397D80 0x178 M_ScrollPosition            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ScrollSensitivity                       = GetSingle(new IntPtr(p + 0x17C)); // 027004397DA0 0x17C M_ScrollSensitivity         ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_ContentType                             = (ContentType)GetInt32(new IntPtr(p + 0x180)); // 027004397DC0 0x180 M_ContentType               ( 0001865E2C20 ModelEnumType ContentType ContentType ContentType Int32 )
            value.M_InputType                               = (InputType)GetInt32(new IntPtr(p + 0x184)); // 027004397DE0 0x184 M_InputType                 ( 0001865E37B0 ModelEnumType InputType InputType InputType Int32 )
            value.M_KeyboardType                            = (TouchScreenKeyboardType)GetInt32(new IntPtr(p + 0x18C)); // 027004397E20 0x18C M_KeyboardType              ( 000186692500 ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32 )
            value.M_LineType                                = (LineType)GetInt32(new IntPtr(p + 0x190)); // 027004397E40 0x190 M_LineType                  ( 0001865E3E70 ModelEnumType LineType LineType LineType Int32 )
            value.M_HideMobileInput                         = GetBool(new IntPtr(p + 0x194)); // 027004397E60 0x194 M_HideMobileInput           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_HideSoftKeyboard                        = GetBool(new IntPtr(p + 0x195)); // 027004397E80 0x195 M_HideSoftKeyboard          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CharacterValidation                     = (CharacterValidation)GetInt32(new IntPtr(p + 0x198)); // 027004397EA0 0x198 M_CharacterValidation       ( 0001865E2650 ModelEnumType CharacterValidation CharacterValidation CharacterValidation Int32 )
            value.M_RegexValue                              = GetString(new IntPtr(p + 0x1A0)); // 027004397EC0 0x1A0 M_RegexValue                ( 000186671910 ModelPrimitiveType string string string String )
            value.M_GlobalPointSize                         = GetSingle(new IntPtr(p + 0x1A8)); // 027004397EE0 0x1A8 M_GlobalPointSize           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_CharacterLimit                          = GetInt32(new IntPtr(p + 0x1AC)); // 027004397F00 0x1AC M_CharacterLimit            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OnEndEdit                               = GetObject<SubmitEvent>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.SubmitEvent.FromPointer); // 027004397F20 0x1B0 M_OnEndEdit                 ( 0001865E5350 ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer )
            value.M_OnSubmit                                = GetObject<SubmitEvent>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.SubmitEvent.FromPointer); // 027004397F40 0x1B8 M_OnSubmit                  ( 0001865E5350 ModelClassType SubmitEvent SubmitEvent SubmitEvent Pointer )
            value.M_OnSelect                                = GetObject<SelectionEvent>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.SelectionEvent.FromPointer); // 027004397F60 0x1C0 M_OnSelect                  ( 0001865E4EA0 ModelClassType SelectionEvent SelectionEvent SelectionEvent Pointer )
            value.M_OnDeselect                              = GetObject<SelectionEvent>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.SelectionEvent.FromPointer); // 027004397F80 0x1C8 M_OnDeselect                ( 0001865E4EA0 ModelClassType SelectionEvent SelectionEvent SelectionEvent Pointer )
            value.M_OnTextSelection                         = GetObject<TextSelectionEvent>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.TextSelectionEvent.FromPointer); // 027004397FA0 0x1D0 M_OnTextSelection           ( 0001865E5810 ModelClassType TextSelectionEvent TextSelectionEvent TextSelectionEvent Pointer )
            value.M_OnEndTextSelection                      = GetObject<TextSelectionEvent>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.TextSelectionEvent.FromPointer); // 027004397FC0 0x1D8 M_OnEndTextSelection        ( 0001865E5810 ModelClassType TextSelectionEvent TextSelectionEvent TextSelectionEvent Pointer )
            value.M_OnValueChanged                          = GetObject<OnChangeEvent>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.OnChangeEvent.FromPointer); // 027004397FE0 0x1E0 M_OnValueChanged            ( 0001865E4570 ModelClassType OnChangeEvent OnChangeEvent OnChangeEvent Pointer )
            value.M_OnTouchScreenKeyboardStatusChanged      = GetObject<TouchScreenKeyboardEvent>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.TouchScreenKeyboardEvent.FromPointer); // 027004398000 0x1E8 M_OnTouchScreenKeyboardStatusChanged ( 0001865E5CB0 ModelClassType TouchScreenKeyboardEvent TouchScreenKeyboardEvent TouchScreenKeyboardEvent Pointer )
            value.M_OnValidateInput                         = GetObject<OnValidateInput>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.OnValidateInput.FromPointer); // 027004398020 0x1F0 M_OnValidateInput           ( 0001865E49C0 ModelClassType OnValidateInput OnValidateInput OnValidateInput Pointer )
            value.M_CaretColor                              = (Color)GetInt32(new IntPtr(p + 0x1F8)); // 027004398040 0x1F8 M_CaretColor                ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_CustomCaretColor                        = GetBool(new IntPtr(p + 0x208)); // 027004398060 0x208 M_CustomCaretColor          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SelectionColor                          = (Color)GetInt32(new IntPtr(p + 0x20C)); // 027004398080 0x20C M_SelectionColor            ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_Text                                    = GetString(new IntPtr(p + 0x220)); // 0270043980A0 0x220 M_Text                      ( 000186671E00 ModelPrimitiveType string string string String )
            value.M_CaretBlinkRate                          = GetSingle(new IntPtr(p + 0x228)); // 0270043980C0 0x228 M_CaretBlinkRate            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_CaretWidth                              = GetInt32(new IntPtr(p + 0x22C)); // 0270043980E0 0x22C M_CaretWidth                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ReadOnly                                = GetBool(new IntPtr(p + 0x230)); // 027004398100 0x230 M_ReadOnly                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_RichText                                = GetBool(new IntPtr(p + 0x231)); // 027004398120 0x231 M_RichText                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_StringPosition                          = GetInt32(new IntPtr(p + 0x234)); // 027004398140 0x234 M_StringPosition            ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_StringSelectPosition                    = GetInt32(new IntPtr(p + 0x238)); // 027004398160 0x238 M_StringSelectPosition      ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_CaretPosition                           = GetInt32(new IntPtr(p + 0x23C)); // 027004398180 0x23C M_CaretPosition             ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_CaretSelectPosition                     = GetInt32(new IntPtr(p + 0x240)); // 0270043981A0 0x240 M_CaretSelectPosition       ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.CaretRectTrans                            = GetObject<RectTransform>(new IntPtr(p + 0x248), ReversePrism.DataModels.RectTransform.FromPointer); // 0270043981C0 0x248 CaretRectTrans              ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_CursorVerts                             = GetEnumList<UIVertex>(new IntPtr(p + 0x250)); // 0270043981E0 0x250 M_CursorVerts               ( 000185CAE838 ModelEnumListType UIVertex[] UIVertex[] List<UIVertex> Pointer )
            value.M_CachedInputRenderer                     = GetObject<CanvasRenderer>(new IntPtr(p + 0x258), ReversePrism.DataModels.CanvasRenderer.FromPointer); // 027004398200 0x258 M_CachedInputRenderer       ( 000186541E60 ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer )
            value.M_LastPosition                            = (Vector2)GetInt32(new IntPtr(p + 0x260)); // 027004398220 0x260 M_LastPosition              ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Mesh                                    = GetObject<Mesh>(new IntPtr(p + 0x268), ReversePrism.DataModels.Mesh.FromPointer); // 027004398240 0x268 M_Mesh                      ( 0001866112E0 ModelClassType Mesh Mesh Mesh Pointer )
            value.M_AllowInput                              = GetBool(new IntPtr(p + 0x270)); // 027004398260 0x270 M_AllowInput                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ShouldActivateNextUpdate                = GetBool(new IntPtr(p + 0x271)); // 027004398280 0x271 M_ShouldActivateNextUpdate  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_UpdateDrag                              = GetBool(new IntPtr(p + 0x272)); // 0270043982A0 0x272 M_UpdateDrag                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DragPositionOutOfBounds                 = GetBool(new IntPtr(p + 0x273)); // 0270043982C0 0x273 M_DragPositionOutOfBounds   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CaretVisible                            = GetBool(new IntPtr(p + 0x274)); // 027004398320 0x274 M_CaretVisible              ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_BlinkCoroutine                          = GetObject<Coroutine>(new IntPtr(p + 0x278), ReversePrism.DataModels.Coroutine.FromPointer); // 027004398340 0x278 M_BlinkCoroutine            ( 000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.M_BlinkStartTime                          = GetSingle(new IntPtr(p + 0x280)); // 027004398360 0x280 M_BlinkStartTime            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DragCoroutine                           = GetObject<Coroutine>(new IntPtr(p + 0x288), ReversePrism.DataModels.Coroutine.FromPointer); // 027004398380 0x288 M_DragCoroutine             ( 000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.M_OriginalText                            = GetString(new IntPtr(p + 0x290)); // 0270043983A0 0x290 M_OriginalText              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_WasCanceled                             = GetBool(new IntPtr(p + 0x298)); // 0270043983C0 0x298 M_WasCanceled               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_HasDoneFocusTransition                  = GetBool(new IntPtr(p + 0x299)); // 0270043983E0 0x299 M_HasDoneFocusTransition    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_WaitForSecondsRealtime                  = GetObject<WaitForSecondsRealtime>(new IntPtr(p + 0x2A0), ReversePrism.DataModels.WaitForSecondsRealtime.FromPointer); // 027004398400 0x2A0 M_WaitForSecondsRealtime    ( 0001865428F0 ModelClassType WaitForSecondsRealtime WaitForSecondsRealtime WaitForSecondsRealtime Pointer )
            value.M_PreventCallback                         = GetBool(new IntPtr(p + 0x2A8)); // 027004398420 0x2A8 M_PreventCallback           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_TouchKeyboardAllowsInPlaceEditing       = GetBool(new IntPtr(p + 0x2A9)); // 027004398440 0x2A9 M_TouchKeyboardAllowsInPlaceEditing ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsTextComponentUpdateRequired           = GetBool(new IntPtr(p + 0x2AA)); // 027004398460 0x2AA M_IsTextComponentUpdateRequired ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_isLastKeyBackspace                      = GetBool(new IntPtr(p + 0x2AB)); // 027004398480 0x2AB M_isLastKeyBackspace        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PointerDownClickStartTime               = GetSingle(new IntPtr(p + 0x2AC)); // 0270043984A0 0x2AC M_PointerDownClickStartTime ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_KeyDownStartTime                        = GetSingle(new IntPtr(p + 0x2B0)); // 0270043984C0 0x2B0 M_KeyDownStartTime          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DoubleClickDelay                        = GetSingle(new IntPtr(p + 0x2B4)); // 0270043984E0 0x2B4 M_DoubleClickDelay          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_IsCompositionActive                     = GetBool(new IntPtr(p + 0x2B8)); // 027004398520 0x2B8 M_IsCompositionActive       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ShouldUpdateIMEWindowPosition           = GetBool(new IntPtr(p + 0x2B9)); // 027004398540 0x2B9 M_ShouldUpdateIMEWindowPosition ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PreviousIMEInsertionLine                = GetInt32(new IntPtr(p + 0x2BC)); // 027004398560 0x2BC M_PreviousIMEInsertionLine  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_GlobalFontAsset                         = GetObject<TMP_FontAsset>(new IntPtr(p + 0x2C0), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 027004398580 0x2C0 M_GlobalFontAsset           ( 00018667FA70 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.M_OnFocusSelectAll                        = GetBool(new IntPtr(p + 0x2C8)); // 0270043985A0 0x2C8 M_OnFocusSelectAll          ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_isSelectAll                             = GetBool(new IntPtr(p + 0x2C9)); // 0270043985C0 0x2C9 M_isSelectAll               ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_ResetOnDeActivation                     = GetBool(new IntPtr(p + 0x2CA)); // 0270043985E0 0x2CA M_ResetOnDeActivation       ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_SelectionStillActive                    = GetBool(new IntPtr(p + 0x2CB)); // 027004398600 0x2CB M_SelectionStillActive      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ReleaseSelection                        = GetBool(new IntPtr(p + 0x2CC)); // 027004398620 0x2CC M_ReleaseSelection          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PreviouslySelectedObject                = GetObject<GameObject>(new IntPtr(p + 0x2D0), ReversePrism.DataModels.GameObject.FromPointer); // 027004398640 0x2D0 M_PreviouslySelectedObject  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.M_RestoreOriginalTextOnEscape             = GetBool(new IntPtr(p + 0x2D8)); // 027004398660 0x2D8 M_RestoreOriginalTextOnEscape ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_isRichTextEditingAllowed                = GetBool(new IntPtr(p + 0x2D9)); // 027004398680 0x2D9 M_isRichTextEditingAllowed  ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_LineLimit                               = GetInt32(new IntPtr(p + 0x2DC)); // 0270043986A0 0x2DC M_LineLimit                 ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_InputValidator                          = GetObject<TMP_InputValidator>(new IntPtr(p + 0x2E0), ReversePrism.DataModels.TMP_InputValidator.FromPointer); // 0270043986C0 0x2E0 M_InputValidator            ( 00018660E3F0 ModelClassType TMP_InputValidator TMP_InputValidator TMP_InputValidator Pointer )
            value.M_isSelected                              = GetBool(new IntPtr(p + 0x2E8)); // 0270043986E0 0x2E8 M_isSelected                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsStringPositionDirty                   = GetBool(new IntPtr(p + 0x2E9)); // 027004398700 0x2E9 M_IsStringPositionDirty     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsCaretPositionDirty                    = GetBool(new IntPtr(p + 0x2EA)); // 027004398720 0x2EA M_IsCaretPositionDirty      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_forceRectTransformAdjustment            = GetBool(new IntPtr(p + 0x2EB)); // 027004398740 0x2EB M_forceRectTransformAdjustment ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ProcessingEvent                         = GetObject<Event>(new IntPtr(p + 0x2F0), ReversePrism.DataModels.Event.FromPointer); // 027004398760 0x2F0 M_ProcessingEvent           ( 00018674CC10 ModelClassType Event Event Event Pointer )

            return value;
        }
    }
}
