using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 KeyboardOnScreen                         ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer
    // 018 ControlID                                ModelPrimitiveType int int int Int32
    // 020 Style                                    ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 028 Multiline                                ModelPrimitiveType bool bool bool Bool
    // 029 HasHorizontalCursorPos                   ModelPrimitiveType bool bool bool Bool
    // 02A IsPasswordField                          ModelPrimitiveType bool bool bool Bool
    // 02C ScrollOffset                             ModelEnumType Vector2 Vector2 Vector2 Int32
    // 038 M_Content                                ModelClassType GUIContent GUIContent GUIContent Pointer
    // 040 M_CursorIndex                            ModelPrimitiveType int int int Int32
    // 044 M_SelectIndex                            ModelPrimitiveType int int int Int32
    // 048 M_RevealCursor                           ModelPrimitiveType bool bool bool Bool
    // 049 M_MouseDragSelectsWholeWords             ModelPrimitiveType bool bool bool Bool
    // 04C M_DblClickInitPos                        ModelPrimitiveType int int int Int32
    // 050 M_DblClickSnap                           ModelEnumType DblClickSnapping DblClickSnapping DblClickSnapping Int32
    // 051 M_bJustSelected                          ModelPrimitiveType bool bool bool Bool
    // 054 M_iAltCursorPos                          ModelPrimitiveType int int int Int32
    public partial class TextEditor : DataModel
    {
        public TouchScreenKeyboard?                     KeyboardOnScreen                        { get; set; }
        public int                                      ControlID                               { get; set; }
        public GUIStyle?                                Style                                   { get; set; }
        public bool                                     Multiline                               { get; set; }
        public bool                                     HasHorizontalCursorPos                  { get; set; }
        public bool                                     IsPasswordField                         { get; set; }
        public Vector2                                  ScrollOffset                            { get; set; }
        public GUIContent?                              M_Content                               { get; set; }
        public int                                      M_CursorIndex                           { get; set; }
        public int                                      M_SelectIndex                           { get; set; }
        public bool                                     M_RevealCursor                          { get; set; }
        public bool                                     M_MouseDragSelectsWholeWords            { get; set; }
        public int                                      M_DblClickInitPos                       { get; set; }
        public DblClickSnapping                         M_DblClickSnap                          { get; set; }
        public bool                                     M_bJustSelected                         { get; set; }
        public int                                      M_iAltCursorPos                         { get; set; }

        public static TextEditor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextEditor() { Pointer= p0 };

            value.KeyboardOnScreen                          = GetObject<TouchScreenKeyboard>(new IntPtr(p + 0x010), ReversePrism.DataModels.TouchScreenKeyboard.FromPointer); // 0x10 KeyboardOnScreen            ( ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer )
            value.ControlID                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 ControlID                   ( ModelPrimitiveType int int int Int32 )
            value.Style                                     = GetObject<GUIStyle>(new IntPtr(p + 0x020), ReversePrism.DataModels.GUIStyle.FromPointer); // 0x20 Style                       ( ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.Multiline                                 = GetBool(new IntPtr(p + 0x028)); // 0x28 Multiline                   ( ModelPrimitiveType bool bool bool Bool )
            value.HasHorizontalCursorPos                    = GetBool(new IntPtr(p + 0x029)); // 0x29 HasHorizontalCursorPos      ( ModelPrimitiveType bool bool bool Bool )
            value.IsPasswordField                           = GetBool(new IntPtr(p + 0x02A)); // 0x2A IsPasswordField             ( ModelPrimitiveType bool bool bool Bool )
            value.ScrollOffset                              = (Vector2)GetInt32(new IntPtr(p + 0x02C)); // 0x2C ScrollOffset                ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Content                                 = GetObject<GUIContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.GUIContent.FromPointer); // 0x38 M_Content                   ( ModelClassType GUIContent GUIContent GUIContent Pointer )
            value.M_CursorIndex                             = GetInt32(new IntPtr(p + 0x040)); // 0x40 M_CursorIndex               ( ModelPrimitiveType int int int Int32 )
            value.M_SelectIndex                             = GetInt32(new IntPtr(p + 0x044)); // 0x44 M_SelectIndex               ( ModelPrimitiveType int int int Int32 )
            value.M_RevealCursor                            = GetBool(new IntPtr(p + 0x048)); // 0x48 M_RevealCursor              ( ModelPrimitiveType bool bool bool Bool )
            value.M_MouseDragSelectsWholeWords              = GetBool(new IntPtr(p + 0x049)); // 0x49 M_MouseDragSelectsWholeWords ( ModelPrimitiveType bool bool bool Bool )
            value.M_DblClickInitPos                         = GetInt32(new IntPtr(p + 0x04C)); // 0x4C M_DblClickInitPos           ( ModelPrimitiveType int int int Int32 )
            value.M_DblClickSnap                            = (DblClickSnapping)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_DblClickSnap              ( ModelEnumType DblClickSnapping DblClickSnapping DblClickSnapping Int32 )
            value.M_bJustSelected                           = GetBool(new IntPtr(p + 0x051)); // 0x51 M_bJustSelected             ( ModelPrimitiveType bool bool bool Bool )
            value.M_iAltCursorPos                           = GetInt32(new IntPtr(p + 0x054)); // 0x54 M_iAltCursorPos             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
