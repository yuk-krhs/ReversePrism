using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 3D8 UitkTextHandle                           0001866F4BB0 ModelClassType UITKTextHandle UITKTextHandle UITKTextHandle Pointer
    // 3E0 M_Text                                   000186671910 ModelPrimitiveType string string string String
    // 3E8 M_EnableRichText                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 3E9 M_ParseEscapeSequences                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 3EA M_DisplayTooltipWhenElided               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 3EB IsElided                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 008 k_EllipsisText                           string IL2CPP_TYPE_STRING
    // 3F0 ElidedText                               000186671BA0 ModelPrimitiveType string string string String
    // 3F8 M_WasElided                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 400 EditingManipulator                       000186637080 ModelClassType TextEditingManipulator TextEditingManipulator TextEditingManipulator Pointer
    // 408 M_Multiline                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 410 M_TouchScreenKeyboard                    000186691B30 ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer
    // 418 M_KeyboardType                           000186692740 ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32
    // 41C M_HideMobileInput                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 41D M_IsReadOnly                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 420 M_MaxLength                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 424 UnityEngine.UIElements.ITextEdition.isDelayed 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 428 <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField Func`2<char, bool> IL2CPP_TYPE_GENERICINST
    // 430 <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 438 UnityEngine.UIElements.ITextEdition.UpdateValueFromText 0001866792B0 ModelClassType Action Action Action Pointer
    // 440 UnityEngine.UIElements.ITextEdition.UpdateTextFromValue 0001866792B0 ModelClassType Action Action Action Pointer
    // 448 UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot 0001866792B0 ModelClassType Action Action Action Pointer
    // 450 M_RenderedText                           000186671910 ModelPrimitiveType string string string String
    // 458 M_OriginalText                           000186671910 ModelPrimitiveType string string string String
    // 460 m_MaskChar                               char IL2CPP_TYPE_CHAR
    // 462 M_IsPassword                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 463 M_AutoCorrection                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 468 M_SelectingManipulator                   000186646DA0 ModelClassType TextSelectingManipulator TextSelectingManipulator TextSelectingManipulator Pointer
    // 470 M_IsSelectable                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 471 UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 472 UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 473 UnityEngine.UIElements.ITextSelection.selectAllOnFocus 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 474 UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 478 M_SelectionColor                         0001865AA8E0 ModelEnumType Color Color Color Int32
    // 488 M_CursorColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 498 M_CursorWidth                            0001866656B0 ModelPrimitiveType float float float Single
    public partial class TextElement
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
            var value   = new TextElement();

            value.UitkTextHandle                            = GetObject<UITKTextHandle>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.UITKTextHandle.FromPointer); // 0270066F67F0 0x3D8 UitkTextHandle              ( 0001866F4BB0 ModelClassType UITKTextHandle UITKTextHandle UITKTextHandle Pointer )
            value.M_Text                                    = GetString(new IntPtr(p + 0x3E0)); // 0270066F6810 0x3E0 M_Text                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_EnableRichText                          = GetBool(new IntPtr(p + 0x3E8)); // 0270066F6830 0x3E8 M_EnableRichText            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ParseEscapeSequences                    = GetBool(new IntPtr(p + 0x3E9)); // 0270066F6850 0x3E9 M_ParseEscapeSequences      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DisplayTooltipWhenElided                = GetBool(new IntPtr(p + 0x3EA)); // 0270066F6870 0x3EA M_DisplayTooltipWhenElided  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsElided                                  = GetBool(new IntPtr(p + 0x3EB)); // 0270066F6890 0x3EB IsElided                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ElidedText                                = GetString(new IntPtr(p + 0x3F0)); // 0270066F68D0 0x3F0 ElidedText                  ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_WasElided                               = GetBool(new IntPtr(p + 0x3F8)); // 0270066F68F0 0x3F8 M_WasElided                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EditingManipulator                        = GetObject<TextEditingManipulator>(new IntPtr(p + 0x400), ReversePrism.DataModels.TextEditingManipulator.FromPointer); // 0270066F6910 0x400 EditingManipulator          ( 000186637080 ModelClassType TextEditingManipulator TextEditingManipulator TextEditingManipulator Pointer )
            value.M_Multiline                               = GetBool(new IntPtr(p + 0x408)); // 0270066F6930 0x408 M_Multiline                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_TouchScreenKeyboard                     = GetObject<TouchScreenKeyboard>(new IntPtr(p + 0x410), ReversePrism.DataModels.TouchScreenKeyboard.FromPointer); // 0270066F6950 0x410 M_TouchScreenKeyboard       ( 000186691B30 ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer )
            value.M_KeyboardType                            = (TouchScreenKeyboardType)GetInt32(new IntPtr(p + 0x418)); // 0270066F6970 0x418 M_KeyboardType              ( 000186692740 ModelEnumType TouchScreenKeyboardType TouchScreenKeyboardType TouchScreenKeyboardType Int32 )
            value.M_HideMobileInput                         = GetBool(new IntPtr(p + 0x41C)); // 0270066F6990 0x41C M_HideMobileInput           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsReadOnly                              = GetBool(new IntPtr(p + 0x41D)); // 0270066F69B0 0x41D M_IsReadOnly                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MaxLength                               = GetInt32(new IntPtr(p + 0x420)); // 0270066F69D0 0x420 M_MaxLength                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnityEngine.UIElements.ITextEdition.isDelayed = GetBool(new IntPtr(p + 0x424)); // 0270066F69F0 0x424 UnityEngine.UIElements.ITextEdition.isDelayed ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnityEngine.UIElements.ITextEdition.UpdateValueFromText = GetObject<Action>(new IntPtr(p + 0x438), ReversePrism.DataModels.Action.FromPointer); // 0270066F6A50 0x438 UnityEngine.UIElements.ITextEdition.UpdateValueFromText ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.UnityEngine.UIElements.ITextEdition.UpdateTextFromValue = GetObject<Action>(new IntPtr(p + 0x440), ReversePrism.DataModels.Action.FromPointer); // 0270066F6A70 0x440 UnityEngine.UIElements.ITextEdition.UpdateTextFromValue ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot = GetObject<Action>(new IntPtr(p + 0x448), ReversePrism.DataModels.Action.FromPointer); // 0270066F6A90 0x448 UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_RenderedText                            = GetString(new IntPtr(p + 0x450)); // 0270066F6AB0 0x450 M_RenderedText              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_OriginalText                            = GetString(new IntPtr(p + 0x458)); // 0270066F6AD0 0x458 M_OriginalText              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_IsPassword                              = GetBool(new IntPtr(p + 0x462)); // 0270066F6B10 0x462 M_IsPassword                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_AutoCorrection                          = GetBool(new IntPtr(p + 0x463)); // 0270066F6B30 0x463 M_AutoCorrection            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SelectingManipulator                    = GetObject<TextSelectingManipulator>(new IntPtr(p + 0x468), ReversePrism.DataModels.TextSelectingManipulator.FromPointer); // 0270066F6B50 0x468 M_SelectingManipulator      ( 000186646DA0 ModelClassType TextSelectingManipulator TextSelectingManipulator TextSelectingManipulator Pointer )
            value.M_IsSelectable                            = GetBool(new IntPtr(p + 0x470)); // 0270066F6B70 0x470 M_IsSelectable              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord = GetBool(new IntPtr(p + 0x471)); // 0270066F6B90 0x471 UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine = GetBool(new IntPtr(p + 0x472)); // 0270066F6BB0 0x472 UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnityEngine.UIElements.ITextSelection.selectAllOnFocus = GetBool(new IntPtr(p + 0x473)); // 0270066F6BD0 0x473 UnityEngine.UIElements.ITextSelection.selectAllOnFocus ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp = GetBool(new IntPtr(p + 0x474)); // 0270066F6BF0 0x474 UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SelectionColor                          = (Color)GetInt32(new IntPtr(p + 0x478)); // 0270066F6C10 0x478 M_SelectionColor            ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_CursorColor                             = (Color)GetInt32(new IntPtr(p + 0x488)); // 0270066F6C30 0x488 M_CursorColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_CursorWidth                             = GetSingle(new IntPtr(p + 0x498)); // 0270066F6C50 0x498 M_CursorWidth               ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
