using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 020 FontSize                                 0001866063F0 ModelEnumType Length Length Length Int32
    // 028 LetterSpacing                            0001866063F0 ModelEnumType Length Length Length Int32
    // 030 TextShadow                               000186648940 ModelEnumType TextShadow TextShadow TextShadow Int32
    // 050 UnityFont                                0001865AD2F0 ModelClassType Font Font Font Pointer
    // 058 UnityFontDefinition                      0001865AEE20 ModelEnumType FontDefinition FontDefinition FontDefinition Int32
    // 068 UnityFontStyleAndWeight                  0001865B1310 ModelEnumType FontStyle FontStyle FontStyle Int32
    // 06C UnityParagraphSpacing                    0001866063F0 ModelEnumType Length Length Length Int32
    // 074 UnityTextAlign                           000186633B90 ModelEnumType TextAnchor TextAnchor TextAnchor Int32
    // 078 UnityTextOutlineColor                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 088 UnityTextOutlineWidth                    000186666050 ModelPrimitiveType float float float Single
    // 08C Visibility                               000186527090 ModelEnumType Visibility Visibility Visibility Int32
    // 090 WhiteSpace                               000186558AA0 ModelEnumType WhiteSpace WhiteSpace WhiteSpace Int32
    // 094 WordSpacing                              0001866063F0 ModelEnumType Length Length Length Int32
    public partial class InheritedData : DataModel
    {
        public Color                                    Color                                   { get; set; }
        public Length                                   FontSize                                { get; set; }
        public Length                                   LetterSpacing                           { get; set; }
        public TextShadow                               TextShadow                              { get; set; }
        public Font?                                    UnityFont                               { get; set; }
        public FontDefinition                           UnityFontDefinition                     { get; set; }
        public FontStyle                                UnityFontStyleAndWeight                 { get; set; }
        public Length                                   UnityParagraphSpacing                   { get; set; }
        public TextAnchor                               UnityTextAlign                          { get; set; }
        public Color                                    UnityTextOutlineColor                   { get; set; }
        public float                                    UnityTextOutlineWidth                   { get; set; }
        public Visibility                               Visibility                              { get; set; }
        public WhiteSpace                               WhiteSpace                              { get; set; }
        public Length                                   WordSpacing                             { get; set; }

        public static InheritedData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritedData() { Pointer= p0 };

            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x010)); // 0245A3F1ADF8 0x10 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.FontSize                                  = (Length)GetInt32(new IntPtr(p + 0x020)); // 0245A3F1AE18 0x20 FontSize                    ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.LetterSpacing                             = (Length)GetInt32(new IntPtr(p + 0x028)); // 0245A3F1AE38 0x28 LetterSpacing               ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.TextShadow                                = (TextShadow)GetInt32(new IntPtr(p + 0x030)); // 0245A3F1AE58 0x30 TextShadow                  ( 000186648940 ModelEnumType TextShadow TextShadow TextShadow Int32 )
            value.UnityFont                                 = GetObject<Font>(new IntPtr(p + 0x050), ReversePrism.DataModels.Font.FromPointer); // 0245A3F1AE78 0x50 UnityFont                   ( 0001865AD2F0 ModelClassType Font Font Font Pointer )
            value.UnityFontDefinition                       = (FontDefinition)GetInt32(new IntPtr(p + 0x058)); // 0245A3F1AE98 0x58 UnityFontDefinition         ( 0001865AEE20 ModelEnumType FontDefinition FontDefinition FontDefinition Int32 )
            value.UnityFontStyleAndWeight                   = (FontStyle)GetInt32(new IntPtr(p + 0x068)); // 0245A3F1AEB8 0x68 UnityFontStyleAndWeight     ( 0001865B1310 ModelEnumType FontStyle FontStyle FontStyle Int32 )
            value.UnityParagraphSpacing                     = (Length)GetInt32(new IntPtr(p + 0x06C)); // 0245A3F1AED8 0x6C UnityParagraphSpacing       ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.UnityTextAlign                            = (TextAnchor)GetInt32(new IntPtr(p + 0x074)); // 0245A3F1AEF8 0x74 UnityTextAlign              ( 000186633B90 ModelEnumType TextAnchor TextAnchor TextAnchor Int32 )
            value.UnityTextOutlineColor                     = (Color)GetInt32(new IntPtr(p + 0x078)); // 0245A3F1AF18 0x78 UnityTextOutlineColor       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.UnityTextOutlineWidth                     = GetSingle(new IntPtr(p + 0x088)); // 0245A3F1AF38 0x88 UnityTextOutlineWidth       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Visibility                                = (Visibility)GetInt32(new IntPtr(p + 0x08C)); // 0245A3F1AF58 0x8C Visibility                  ( 000186527090 ModelEnumType Visibility Visibility Visibility Int32 )
            value.WhiteSpace                                = (WhiteSpace)GetInt32(new IntPtr(p + 0x090)); // 0245A3F1AF78 0x90 WhiteSpace                  ( 000186558AA0 ModelEnumType WhiteSpace WhiteSpace WhiteSpace Int32 )
            value.WordSpacing                               = (Length)GetInt32(new IntPtr(p + 0x094)); // 0245A3F1AF98 0x94 WordSpacing                 ( 0001866063F0 ModelEnumType Length Length Length Int32 )

            return value;
        }
    }
}
