using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 KeyboardOnScreen                         000186692000 ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer
    // 018 ControlID                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Style                                    0001865DF030 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 028 Multiline                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 029 HasHorizontalCursorPos                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 02A IsPasswordField                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 02C ScrollOffset                             0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 038 M_Content                                0001865DC130 ModelClassType GUIContent GUIContent GUIContent Pointer
    // 040 M_CursorIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 M_SelectIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 M_RevealCursor                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 M_MouseDragSelectsWholeWords             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04C M_DblClickInitPos                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 M_DblClickSnap                           0001865F7290 ModelEnumType DblClickSnapping DblClickSnapping DblClickSnapping Int32
    // 051 M_bJustSelected                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 M_iAltCursorPos                          0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.KeyboardOnScreen                          = GetObject<TouchScreenKeyboard>(new IntPtr(p + 0x010), ReversePrism.DataModels.TouchScreenKeyboard.FromPointer); // 0245A21E88C0 0x10 KeyboardOnScreen            ( 000186692000 ModelClassType TouchScreenKeyboard TouchScreenKeyboard TouchScreenKeyboard Pointer )
            value.ControlID                                 = GetInt32(new IntPtr(p + 0x018)); // 0245A21E88E0 0x18 ControlID                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Style                                     = GetObject<GUIStyle>(new IntPtr(p + 0x020), ReversePrism.DataModels.GUIStyle.FromPointer); // 0245A21E8900 0x20 Style                       ( 0001865DF030 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.Multiline                                 = GetBool(new IntPtr(p + 0x028)); // 0245A21E8920 0x28 Multiline                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HasHorizontalCursorPos                    = GetBool(new IntPtr(p + 0x029)); // 0245A21E8940 0x29 HasHorizontalCursorPos      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsPasswordField                           = GetBool(new IntPtr(p + 0x02A)); // 0245A21E8960 0x2A IsPasswordField             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ScrollOffset                              = (Vector2)GetInt32(new IntPtr(p + 0x02C)); // 0245A21E8980 0x2C ScrollOffset                ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Content                                 = GetObject<GUIContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.GUIContent.FromPointer); // 0245A21E89A0 0x38 M_Content                   ( 0001865DC130 ModelClassType GUIContent GUIContent GUIContent Pointer )
            value.M_CursorIndex                             = GetInt32(new IntPtr(p + 0x040)); // 0245A21E89C0 0x40 M_CursorIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_SelectIndex                             = GetInt32(new IntPtr(p + 0x044)); // 0245A21E89E0 0x44 M_SelectIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_RevealCursor                            = GetBool(new IntPtr(p + 0x048)); // 0245A21E8A00 0x48 M_RevealCursor              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MouseDragSelectsWholeWords              = GetBool(new IntPtr(p + 0x049)); // 0245A21E8A20 0x49 M_MouseDragSelectsWholeWords ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DblClickInitPos                         = GetInt32(new IntPtr(p + 0x04C)); // 0245A21E8A40 0x4C M_DblClickInitPos           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_DblClickSnap                            = (DblClickSnapping)GetInt32(new IntPtr(p + 0x050)); // 0245A21E8A60 0x50 M_DblClickSnap              ( 0001865F7290 ModelEnumType DblClickSnapping DblClickSnapping DblClickSnapping Int32 )
            value.M_bJustSelected                           = GetBool(new IntPtr(p + 0x051)); // 0245A21E8A80 0x51 M_bJustSelected             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_iAltCursorPos                           = GetInt32(new IntPtr(p + 0x054)); // 0245A21E8AA0 0x54 M_iAltCursorPos             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
