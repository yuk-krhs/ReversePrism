using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 3D8 UitkTextHandle                           ModelClassType UITKTextHandle UITKTextHandle UITKTextHandle Pointer
    // 3E0 M_Text                                   ModelPrimitiveType string string string String
    // 3E8 M_EnableRichText                         ModelPrimitiveType bool bool bool Bool
    // 3E9 M_ParseEscapeSequences                   ModelPrimitiveType bool bool bool Bool
    // 3EA M_DisplayTooltipWhenElided               ModelPrimitiveType bool bool bool Bool
    // 3EB IsElided                                 ModelPrimitiveType bool bool bool Bool
    // 008 k_EllipsisText                           string IL2CPP_TYPE_STRING
    // 3F0 ElidedText                               ModelPrimitiveType string string string String
    // 3F8 M_WasElided                              ModelPrimitiveType bool bool bool Bool
    // 400 EditingManipulator                       ModelClassType TextEditingManipulator TextEditingManipulator TextEditingManipulator Pointer
    // 408 M_Multiline                              ModelPrimitiveType bool bool bool Bool
    // 410 M_TouchScreenKeyboard                    ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer
    // 418 M_KeyboardType                           ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32
    // 41C M_HideMobileInput                        ModelPrimitiveType bool bool bool Bool
    // 41D M_IsReadOnly                             ModelPrimitiveType bool bool bool Bool
    // 420 M_MaxLength                              ModelPrimitiveType int int int Int32
    // 424 UnityEngine.UIElements.ITextEdition.isDelayed ModelPrimitiveType bool bool bool Bool
    // 428 <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField Func`2<char, bool> IL2CPP_TYPE_GENERICINST
    // 430 <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 438 UnityEngine.UIElements.ITextEdition.UpdateValueFromText ModelClassType Action Action Action Pointer
    // 440 UnityEngine.UIElements.ITextEdition.UpdateTextFromValue ModelClassType Action Action Action Pointer
    // 448 UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot ModelClassType Action Action Action Pointer
    // 450 M_RenderedText                           ModelPrimitiveType string string string String
    // 458 M_OriginalText                           ModelPrimitiveType string string string String
    // 460 m_MaskChar                               char IL2CPP_TYPE_CHAR
    // 462 M_IsPassword                             ModelPrimitiveType bool bool bool Bool
    // 463 M_AutoCorrection                         ModelPrimitiveType bool bool bool Bool
    // 468 M_SelectingManipulator                   ModelClassType TextSelectingManipulator TextSelectingManipulator TextSelectingManipulator Pointer
    // 470 M_IsSelectable                           ModelPrimitiveType bool bool bool Bool
    // 471 UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord ModelPrimitiveType bool bool bool Bool
    // 472 UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine ModelPrimitiveType bool bool bool Bool
    // 473 UnityEngine.UIElements.ITextSelection.selectAllOnFocus ModelPrimitiveType bool bool bool Bool
    // 474 UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp ModelPrimitiveType bool bool bool Bool
    // 478 M_SelectionColor                         ModelEnumType Color Color Color Int32
    // 488 M_CursorColor                            ModelEnumType Color Color Color Int32
    // 498 M_CursorWidth                            ModelPrimitiveType float float float Single
    public partial class TextElement : DataModel
    {
        public UITKTextHandle?                          UitkTextHandle                          { get; set; }
        public string                                   M_Text                                  { get; set; }
        public bool                                     M_EnableRichText                        { get; set; }
        public bool                                     M_ParseEscapeSequences                  { get; set; }
        public bool                                     M_DisplayTooltipWhenElided              { get; set; }
        public bool                                     IsElided                                { get; set; }
        public string                                   ElidedText                              { get; set; }
        public bool                                     M_WasElided                             { get; set; }
        public TextEditingManipulator?                  EditingManipulator                      { get; set; }
        public bool                                     M_Multiline                             { get; set; }
        public TouchScreenKeyboard?                     M_TouchScreenKeyboard                   { get; set; }
        public TouchScreenKeyboardType                  M_KeyboardType                          { get; set; }
        public bool                                     M_HideMobileInput                       { get; set; }
        public bool                                     M_IsReadOnly                            { get; set; }
        public int                                      M_MaxLength                             { get; set; }
        public bool                                     UnityEngine.UIElements.ITextEdition.isDelayed { get; set; }
        public Action?                                  UnityEngine.UIElements.ITextEdition.UpdateValueFromText { get; set; }
        public Action?                                  UnityEngine.UIElements.ITextEdition.UpdateTextFromValue { get; set; }
        public Action?                                  UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot { get; set; }
        public string                                   M_RenderedText                          { get; set; }
        public string                                   M_OriginalText                          { get; set; }
        public bool                                     M_IsPassword                            { get; set; }
        public bool                                     M_AutoCorrection                        { get; set; }
        public TextSelectingManipulator?                M_SelectingManipulator                  { get; set; }
        public bool                                     M_IsSelectable                          { get; set; }
        public bool                                     UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord { get; set; }
        public bool                                     UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine { get; set; }
        public bool                                     UnityEngine.UIElements.ITextSelection.selectAllOnFocus { get; set; }
        public bool                                     UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp { get; set; }
        public Color                                    M_SelectionColor                        { get; set; }
        public Color                                    M_CursorColor                           { get; set; }
        public float                                    M_CursorWidth                           { get; set; }

        public static TextElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextElement() { Pointer= p0 };

            value.UitkTextHandle                            = GetObject<UITKTextHandle>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.UITKTextHandle.FromPointer); // 0x3D8 UitkTextHandle              ( ModelClassType UITKTextHandle UITKTextHandle UITKTextHandle Pointer )
            value.M_Text                                    = GetString(new IntPtr(p + 0x3E0)); // 0x3E0 M_Text                      ( ModelPrimitiveType string string string String )
            value.M_EnableRichText                          = GetBool(new IntPtr(p + 0x3E8)); // 0x3E8 M_EnableRichText            ( ModelPrimitiveType bool bool bool Bool )
            value.M_ParseEscapeSequences                    = GetBool(new IntPtr(p + 0x3E9)); // 0x3E9 M_ParseEscapeSequences      ( ModelPrimitiveType bool bool bool Bool )
            value.M_DisplayTooltipWhenElided                = GetBool(new IntPtr(p + 0x3EA)); // 0x3EA M_DisplayTooltipWhenElided  ( ModelPrimitiveType bool bool bool Bool )
            value.IsElided                                  = GetBool(new IntPtr(p + 0x3EB)); // 0x3EB IsElided                    ( ModelPrimitiveType bool bool bool Bool )
            value.ElidedText                                = GetString(new IntPtr(p + 0x3F0)); // 0x3F0 ElidedText                  ( ModelPrimitiveType string string string String )
            value.M_WasElided                               = GetBool(new IntPtr(p + 0x3F8)); // 0x3F8 M_WasElided                 ( ModelPrimitiveType bool bool bool Bool )
            value.EditingManipulator                        = GetObject<TextEditingManipulator>(new IntPtr(p + 0x400), ReversePrism.DataModels.TextEditingManipulator.FromPointer); // 0x400 EditingManipulator          ( ModelClassType TextEditingManipulator TextEditingManipulator TextEditingManipulator Pointer )
            value.M_Multiline                               = GetBool(new IntPtr(p + 0x408)); // 0x408 M_Multiline                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_TouchScreenKeyboard                     = GetObject<TouchScreenKeyboard>(new IntPtr(p + 0x410), ReversePrism.DataModels.TouchScreenKeyboard.FromPointer); // 0x410 M_TouchScreenKeyboard       ( ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer )
            value.M_KeyboardType                            = (TouchScreenKeyboardType)GetInt32(new IntPtr(p + 0x418)); // 0x418 M_KeyboardType              ( ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32 )
            value.M_HideMobileInput                         = GetBool(new IntPtr(p + 0x41C)); // 0x41C M_HideMobileInput           ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsReadOnly                              = GetBool(new IntPtr(p + 0x41D)); // 0x41D M_IsReadOnly                ( ModelPrimitiveType bool bool bool Bool )
            value.M_MaxLength                               = GetInt32(new IntPtr(p + 0x420)); // 0x420 M_MaxLength                 ( ModelPrimitiveType int int int Int32 )
            value.UnityEngine.UIElements.ITextEdition.isDelayed = GetBool(new IntPtr(p + 0x424)); // 0x424 UnityEngine.UIElements.ITextEdition.isDelayed ( ModelPrimitiveType bool bool bool Bool )
            value.UnityEngine.UIElements.ITextEdition.UpdateValueFromText = GetObject<Action>(new IntPtr(p + 0x438), ReversePrism.DataModels.Action.FromPointer); // 0x438 UnityEngine.UIElements.ITextEdition.UpdateValueFromText ( ModelClassType Action Action Action Pointer )
            value.UnityEngine.UIElements.ITextEdition.UpdateTextFromValue = GetObject<Action>(new IntPtr(p + 0x440), ReversePrism.DataModels.Action.FromPointer); // 0x440 UnityEngine.UIElements.ITextEdition.UpdateTextFromValue ( ModelClassType Action Action Action Pointer )
            value.UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot = GetObject<Action>(new IntPtr(p + 0x448), ReversePrism.DataModels.Action.FromPointer); // 0x448 UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot ( ModelClassType Action Action Action Pointer )
            value.M_RenderedText                            = GetString(new IntPtr(p + 0x450)); // 0x450 M_RenderedText              ( ModelPrimitiveType string string string String )
            value.M_OriginalText                            = GetString(new IntPtr(p + 0x458)); // 0x458 M_OriginalText              ( ModelPrimitiveType string string string String )
            value.M_IsPassword                              = GetBool(new IntPtr(p + 0x462)); // 0x462 M_IsPassword                ( ModelPrimitiveType bool bool bool Bool )
            value.M_AutoCorrection                          = GetBool(new IntPtr(p + 0x463)); // 0x463 M_AutoCorrection            ( ModelPrimitiveType bool bool bool Bool )
            value.M_SelectingManipulator                    = GetObject<TextSelectingManipulator>(new IntPtr(p + 0x468), ReversePrism.DataModels.TextSelectingManipulator.FromPointer); // 0x468 M_SelectingManipulator      ( ModelClassType TextSelectingManipulator TextSelectingManipulator TextSelectingManipulator Pointer )
            value.M_IsSelectable                            = GetBool(new IntPtr(p + 0x470)); // 0x470 M_IsSelectable              ( ModelPrimitiveType bool bool bool Bool )
            value.UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord = GetBool(new IntPtr(p + 0x471)); // 0x471 UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord ( ModelPrimitiveType bool bool bool Bool )
            value.UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine = GetBool(new IntPtr(p + 0x472)); // 0x472 UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine ( ModelPrimitiveType bool bool bool Bool )
            value.UnityEngine.UIElements.ITextSelection.selectAllOnFocus = GetBool(new IntPtr(p + 0x473)); // 0x473 UnityEngine.UIElements.ITextSelection.selectAllOnFocus ( ModelPrimitiveType bool bool bool Bool )
            value.UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp = GetBool(new IntPtr(p + 0x474)); // 0x474 UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp ( ModelPrimitiveType bool bool bool Bool )
            value.M_SelectionColor                          = (Color)GetInt32(new IntPtr(p + 0x478)); // 0x478 M_SelectionColor            ( ModelEnumType Color Color Color Int32 )
            value.M_CursorColor                             = (Color)GetInt32(new IntPtr(p + 0x488)); // 0x488 M_CursorColor               ( ModelEnumType Color Color Color Int32 )
            value.M_CursorWidth                             = GetSingle(new IntPtr(p + 0x498)); // 0x498 M_CursorWidth               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
