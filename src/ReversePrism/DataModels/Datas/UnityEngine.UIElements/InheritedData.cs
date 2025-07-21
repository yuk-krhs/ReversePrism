using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Color                                    ModelEnumType Color Color Color Int32
    // 020 FontSize                                 ModelEnumType Length Length Length Int32
    // 028 LetterSpacing                            ModelEnumType Length Length Length Int32
    // 030 TextShadow                               ModelEnumType TextShadow TextShadow TextShadow Int32
    // 050 UnityFont                                ModelClassType Font Font Font Pointer
    // 058 UnityFontDefinition                      ModelEnumType FontDefinition FontDefinition FontDefinition Int32
    // 068 UnityFontStyleAndWeight                  ModelEnumType FontStyle FontStyle FontStyle Int32
    // 06C UnityParagraphSpacing                    ModelEnumType Length Length Length Int32
    // 074 UnityTextAlign                           ModelEnumType TextAnchor TextAnchor TextAnchor Int32
    // 078 UnityTextOutlineColor                    ModelEnumType Color Color Color Int32
    // 088 UnityTextOutlineWidth                    ModelPrimitiveType float float float Single
    // 08C Visibility                               ModelEnumType Visibility Visibility Visibility Int32
    // 090 WhiteSpace                               ModelEnumType WhiteSpace WhiteSpace WhiteSpace Int32
    // 094 WordSpacing                              ModelEnumType Length Length Length Int32
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

            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 Color                       ( ModelEnumType Color Color Color Int32 )
            value.FontSize                                  = (Length)GetInt32(new IntPtr(p + 0x020)); // 0x20 FontSize                    ( ModelEnumType Length Length Length Int32 )
            value.LetterSpacing                             = (Length)GetInt32(new IntPtr(p + 0x028)); // 0x28 LetterSpacing               ( ModelEnumType Length Length Length Int32 )
            value.TextShadow                                = (TextShadow)GetInt32(new IntPtr(p + 0x030)); // 0x30 TextShadow                  ( ModelEnumType TextShadow TextShadow TextShadow Int32 )
            value.UnityFont                                 = GetObject<Font>(new IntPtr(p + 0x050), ReversePrism.DataModels.Font.FromPointer); // 0x50 UnityFont                   ( ModelClassType Font Font Font Pointer )
            value.UnityFontDefinition                       = (FontDefinition)GetInt32(new IntPtr(p + 0x058)); // 0x58 UnityFontDefinition         ( ModelEnumType FontDefinition FontDefinition FontDefinition Int32 )
            value.UnityFontStyleAndWeight                   = (FontStyle)GetInt32(new IntPtr(p + 0x068)); // 0x68 UnityFontStyleAndWeight     ( ModelEnumType FontStyle FontStyle FontStyle Int32 )
            value.UnityParagraphSpacing                     = (Length)GetInt32(new IntPtr(p + 0x06C)); // 0x6C UnityParagraphSpacing       ( ModelEnumType Length Length Length Int32 )
            value.UnityTextAlign                            = (TextAnchor)GetInt32(new IntPtr(p + 0x074)); // 0x74 UnityTextAlign              ( ModelEnumType TextAnchor TextAnchor TextAnchor Int32 )
            value.UnityTextOutlineColor                     = (Color)GetInt32(new IntPtr(p + 0x078)); // 0x78 UnityTextOutlineColor       ( ModelEnumType Color Color Color Int32 )
            value.UnityTextOutlineWidth                     = GetSingle(new IntPtr(p + 0x088)); // 0x88 UnityTextOutlineWidth       ( ModelPrimitiveType float float float Single )
            value.Visibility                                = (Visibility)GetInt32(new IntPtr(p + 0x08C)); // 0x8C Visibility                  ( ModelEnumType Visibility Visibility Visibility Int32 )
            value.WhiteSpace                                = (WhiteSpace)GetInt32(new IntPtr(p + 0x090)); // 0x90 WhiteSpace                  ( ModelEnumType WhiteSpace WhiteSpace WhiteSpace Int32 )
            value.WordSpacing                               = (Length)GetInt32(new IntPtr(p + 0x094)); // 0x94 WordSpacing                 ( ModelEnumType Length Length Length Int32 )

            return value;
        }
    }
}
