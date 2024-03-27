using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 ScreenRect                               00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 028 Margins                                  0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 038 Scale                                    000186666050 ModelPrimitiveType float float float Single
    // 040 FontAsset                                0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer
    // 048 Material                                 00018660C4B0 ModelClassType Material Material Material Pointer
    // 050 SpriteAsset                              00018666CC70 ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer
    // 058 StyleSheet                               000186649590 ModelClassType TextStyleSheet TextStyleSheet TextStyleSheet Pointer
    // 060 FontStyle                                0001865B2E00 ModelEnumType FontStyles FontStyles FontStyles Int32
    // 068 TextSettings                             000186647CE0 ModelClassType TextSettings TextSettings TextSettings Pointer
    // 070 TextAlignment                            0001866327C0 ModelEnumType TextAlignment TextAlignment TextAlignment Int32
    // 074 OverflowMode                             000186642A00 ModelEnumType TextOverflowMode TextOverflowMode TextOverflowMode Int32
    // 078 WordWrap                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 07C WordWrappingRatio                        000186666050 ModelPrimitiveType float float float Single
    // 080 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 090 FontColorGradient                        0001866840D0 ModelClassType TextColorGradient TextColorGradient TextColorGradient Pointer
    // 098 FontColorGradientPreset                  0001866840D0 ModelClassType TextColorGradient TextColorGradient TextColorGradient Pointer
    // 0A0 TintSprites                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 0A1 OverrideRichTextColors                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 0A2 ShouldConvertToLinearSpace               000186595960 ModelPrimitiveType bool bool bool Bool
    // 0A4 FontSize                                 000186666050 ModelPrimitiveType float float float Single
    // 0A8 AutoSize                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 0AC FontSizeMin                              000186666050 ModelPrimitiveType float float float Single
    // 0B0 FontSizeMax                              000186666050 ModelPrimitiveType float float float Single
    // 0B4 EnableKerning                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B5 RichText                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B6 IsRightToLeft                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B8 ExtraPadding                             000186666050 ModelPrimitiveType float float float Single
    // 0BC ParseControlCharacters                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 0BD IsOrthographic                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 0BE TagNoParsing                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 0C0 CharacterSpacing                         000186666050 ModelPrimitiveType float float float Single
    // 0C4 WordSpacing                              000186666050 ModelPrimitiveType float float float Single
    // 0C8 LineSpacing                              000186666050 ModelPrimitiveType float float float Single
    // 0CC ParagraphSpacing                         000186666050 ModelPrimitiveType float float float Single
    // 0D0 LineSpacingMax                           000186666050 ModelPrimitiveType float float float Single
    // 0D4 TextWrappingMode                         00018664B330 ModelEnumType TextWrappingMode TextWrappingMode TextWrappingMode Int32
    // 0D8 MaxVisibleCharacters                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 0DC MaxVisibleWords                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 0E0 MaxVisibleLines                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 0E4 FirstVisibleCharacter                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 0E8 UseMaxVisibleDescender                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 0EC FontWeight                               00018663BD60 ModelEnumType TextFontWeight TextFontWeight TextFontWeight Int32
    // 0F0 PageToDisplay                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 0F4 HorizontalMapping                        000186653D90 ModelEnumType TextureMapping TextureMapping TextureMapping Int32
    // 0F8 VerticalMapping                          000186653D90 ModelEnumType TextureMapping TextureMapping TextureMapping Int32
    // 0FC UvLineOffset                             000186666050 ModelPrimitiveType float float float Single
    // 100 GeometrySortingOrder                     000186514C50 ModelEnumType VertexSortingOrder VertexSortingOrder VertexSortingOrder Int32
    // 104 InverseYAxis                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 108 CharWidthMaxAdj                          000186666050 ModelPrimitiveType float float float Single
    // 10C InputSource                              00018663F810 ModelEnumType TextInputSource TextInputSource TextInputSource Int32
    public partial class TextGenerationSettings
    {
        public string                                   Text                                    { get; set; }
        public Rect                                     ScreenRect                              { get; set; }
        public Vector4                                  Margins                                 { get; set; }
        public float                                    Scale                                   { get; set; }
        public FontAsset?                               FontAsset                               { get; set; }
        public Material?                                Material                                { get; set; }
        public SpriteAsset?                             SpriteAsset                             { get; set; }
        public TextStyleSheet?                          StyleSheet                              { get; set; }
        public FontStyles                               FontStyle                               { get; set; }
        public TextSettings?                            TextSettings                            { get; set; }
        public TextAlignment                            TextAlignment                           { get; set; }
        public TextOverflowMode                         OverflowMode                            { get; set; }
        public bool                                     WordWrap                                { get; set; }
        public float                                    WordWrappingRatio                       { get; set; }
        public Color                                    Color                                   { get; set; }
        public TextColorGradient?                       FontColorGradient                       { get; set; }
        public TextColorGradient?                       FontColorGradientPreset                 { get; set; }
        public bool                                     TintSprites                             { get; set; }
        public bool                                     OverrideRichTextColors                  { get; set; }
        public bool                                     ShouldConvertToLinearSpace              { get; set; }
        public float                                    FontSize                                { get; set; }
        public bool                                     AutoSize                                { get; set; }
        public float                                    FontSizeMin                             { get; set; }
        public float                                    FontSizeMax                             { get; set; }
        public bool                                     EnableKerning                           { get; set; }
        public bool                                     RichText                                { get; set; }
        public bool                                     IsRightToLeft                           { get; set; }
        public float                                    ExtraPadding                            { get; set; }
        public bool                                     ParseControlCharacters                  { get; set; }
        public bool                                     IsOrthographic                          { get; set; }
        public bool                                     TagNoParsing                            { get; set; }
        public float                                    CharacterSpacing                        { get; set; }
        public float                                    WordSpacing                             { get; set; }
        public float                                    LineSpacing                             { get; set; }
        public float                                    ParagraphSpacing                        { get; set; }
        public float                                    LineSpacingMax                          { get; set; }
        public TextWrappingMode                         TextWrappingMode                        { get; set; }
        public int                                      MaxVisibleCharacters                    { get; set; }
        public int                                      MaxVisibleWords                         { get; set; }
        public int                                      MaxVisibleLines                         { get; set; }
        public int                                      FirstVisibleCharacter                   { get; set; }
        public bool                                     UseMaxVisibleDescender                  { get; set; }
        public TextFontWeight                           FontWeight                              { get; set; }
        public int                                      PageToDisplay                           { get; set; }
        public TextureMapping                           HorizontalMapping                       { get; set; }
        public TextureMapping                           VerticalMapping                         { get; set; }
        public float                                    UvLineOffset                            { get; set; }
        public VertexSortingOrder                       GeometrySortingOrder                    { get; set; }
        public bool                                     InverseYAxis                            { get; set; }
        public float                                    CharWidthMaxAdj                         { get; set; }
        public TextInputSource                          InputSource                             { get; set; }

        public static TextGenerationSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextGenerationSettings();

            value.Text                                      = GetString(new IntPtr(p + 0x010)); // 0270068EBD80 0x10 Text                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ScreenRect                                = (Rect)GetInt32(new IntPtr(p + 0x018)); // 0270068EBDA0 0x18 ScreenRect                  ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.Margins                                   = (Vector4)GetInt32(new IntPtr(p + 0x028)); // 0270068EBDC0 0x28 Margins                     ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x038)); // 0270068EBDE0 0x38 Scale                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.FontAsset                                 = GetObject<FontAsset>(new IntPtr(p + 0x040), ReversePrism.DataModels.FontAsset.FromPointer); // 0270068EBE00 0x40 FontAsset                   ( 0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x048), ReversePrism.DataModels.Material.FromPointer); // 0270068EBE20 0x48 Material                    ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.SpriteAsset                               = GetObject<SpriteAsset>(new IntPtr(p + 0x050), ReversePrism.DataModels.SpriteAsset.FromPointer); // 0270068EBE40 0x50 SpriteAsset                 ( 00018666CC70 ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer )
            value.StyleSheet                                = GetObject<TextStyleSheet>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextStyleSheet.FromPointer); // 0270068EBE60 0x58 StyleSheet                  ( 000186649590 ModelClassType TextStyleSheet TextStyleSheet TextStyleSheet Pointer )
            value.FontStyle                                 = (FontStyles)GetInt32(new IntPtr(p + 0x060)); // 0270068EBE80 0x60 FontStyle                   ( 0001865B2E00 ModelEnumType FontStyles FontStyles FontStyles Int32 )
            value.TextSettings                              = GetObject<TextSettings>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextSettings.FromPointer); // 0270068EBEA0 0x68 TextSettings                ( 000186647CE0 ModelClassType TextSettings TextSettings TextSettings Pointer )
            value.TextAlignment                             = (TextAlignment)GetInt32(new IntPtr(p + 0x070)); // 0270068EBEC0 0x70 TextAlignment               ( 0001866327C0 ModelEnumType TextAlignment TextAlignment TextAlignment Int32 )
            value.OverflowMode                              = (TextOverflowMode)GetInt32(new IntPtr(p + 0x074)); // 0270068EBEE0 0x74 OverflowMode                ( 000186642A00 ModelEnumType TextOverflowMode TextOverflowMode TextOverflowMode Int32 )
            value.WordWrap                                  = GetBool(new IntPtr(p + 0x078)); // 0270068EBF00 0x78 WordWrap                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.WordWrappingRatio                         = GetSingle(new IntPtr(p + 0x07C)); // 0270068EBF20 0x7C WordWrappingRatio           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x080)); // 0270068EBF40 0x80 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.FontColorGradient                         = GetObject<TextColorGradient>(new IntPtr(p + 0x090), ReversePrism.DataModels.TextColorGradient.FromPointer); // 0270068EBF60 0x90 FontColorGradient           ( 0001866840D0 ModelClassType TextColorGradient TextColorGradient TextColorGradient Pointer )
            value.FontColorGradientPreset                   = GetObject<TextColorGradient>(new IntPtr(p + 0x098), ReversePrism.DataModels.TextColorGradient.FromPointer); // 0270068EBF80 0x98 FontColorGradientPreset     ( 0001866840D0 ModelClassType TextColorGradient TextColorGradient TextColorGradient Pointer )
            value.TintSprites                               = GetBool(new IntPtr(p + 0x0A0)); // 0270068EBFA0 0xA0 TintSprites                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OverrideRichTextColors                    = GetBool(new IntPtr(p + 0x0A1)); // 0270068EBFC0 0xA1 OverrideRichTextColors      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShouldConvertToLinearSpace                = GetBool(new IntPtr(p + 0x0A2)); // 0270068EBFE0 0xA2 ShouldConvertToLinearSpace  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FontSize                                  = GetSingle(new IntPtr(p + 0x0A4)); // 0270068EC000 0xA4 FontSize                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.AutoSize                                  = GetBool(new IntPtr(p + 0x0A8)); // 0270068EC020 0xA8 AutoSize                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FontSizeMin                               = GetSingle(new IntPtr(p + 0x0AC)); // 0270068EC040 0xAC FontSizeMin                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.FontSizeMax                               = GetSingle(new IntPtr(p + 0x0B0)); // 0270068EC060 0xB0 FontSizeMax                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.EnableKerning                             = GetBool(new IntPtr(p + 0x0B4)); // 0270068EC080 0xB4 EnableKerning               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.RichText                                  = GetBool(new IntPtr(p + 0x0B5)); // 0270068EC0A0 0xB5 RichText                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsRightToLeft                             = GetBool(new IntPtr(p + 0x0B6)); // 0270068EC0C0 0xB6 IsRightToLeft               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ExtraPadding                              = GetSingle(new IntPtr(p + 0x0B8)); // 0270068EC0E0 0xB8 ExtraPadding                ( 000186666050 ModelPrimitiveType float float float Single )
            value.ParseControlCharacters                    = GetBool(new IntPtr(p + 0x0BC)); // 0270068EC100 0xBC ParseControlCharacters      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsOrthographic                            = GetBool(new IntPtr(p + 0x0BD)); // 0270068EC120 0xBD IsOrthographic              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.TagNoParsing                              = GetBool(new IntPtr(p + 0x0BE)); // 0270068EC140 0xBE TagNoParsing                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CharacterSpacing                          = GetSingle(new IntPtr(p + 0x0C0)); // 0270068EC160 0xC0 CharacterSpacing            ( 000186666050 ModelPrimitiveType float float float Single )
            value.WordSpacing                               = GetSingle(new IntPtr(p + 0x0C4)); // 0270068EC180 0xC4 WordSpacing                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.LineSpacing                               = GetSingle(new IntPtr(p + 0x0C8)); // 0270068EC1A0 0xC8 LineSpacing                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.ParagraphSpacing                          = GetSingle(new IntPtr(p + 0x0CC)); // 0270068EC1C0 0xCC ParagraphSpacing            ( 000186666050 ModelPrimitiveType float float float Single )
            value.LineSpacingMax                            = GetSingle(new IntPtr(p + 0x0D0)); // 0270068EC1E0 0xD0 LineSpacingMax              ( 000186666050 ModelPrimitiveType float float float Single )
            value.TextWrappingMode                          = (TextWrappingMode)GetInt32(new IntPtr(p + 0x0D4)); // 0270068EC200 0xD4 TextWrappingMode            ( 00018664B330 ModelEnumType TextWrappingMode TextWrappingMode TextWrappingMode Int32 )
            value.MaxVisibleCharacters                      = GetInt32(new IntPtr(p + 0x0D8)); // 0270068EC220 0xD8 MaxVisibleCharacters        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxVisibleWords                           = GetInt32(new IntPtr(p + 0x0DC)); // 0270068EC240 0xDC MaxVisibleWords             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxVisibleLines                           = GetInt32(new IntPtr(p + 0x0E0)); // 0270068EC260 0xE0 MaxVisibleLines             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FirstVisibleCharacter                     = GetInt32(new IntPtr(p + 0x0E4)); // 0270068EC280 0xE4 FirstVisibleCharacter       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UseMaxVisibleDescender                    = GetBool(new IntPtr(p + 0x0E8)); // 0270068EC2A0 0xE8 UseMaxVisibleDescender      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FontWeight                                = (TextFontWeight)GetInt32(new IntPtr(p + 0x0EC)); // 0270068EC2C0 0xEC FontWeight                  ( 00018663BD60 ModelEnumType TextFontWeight TextFontWeight TextFontWeight Int32 )
            value.PageToDisplay                             = GetInt32(new IntPtr(p + 0x0F0)); // 0270068EC2E0 0xF0 PageToDisplay               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HorizontalMapping                         = (TextureMapping)GetInt32(new IntPtr(p + 0x0F4)); // 0270068EC300 0xF4 HorizontalMapping           ( 000186653D90 ModelEnumType TextureMapping TextureMapping TextureMapping Int32 )
            value.VerticalMapping                           = (TextureMapping)GetInt32(new IntPtr(p + 0x0F8)); // 0270068EC320 0xF8 VerticalMapping             ( 000186653D90 ModelEnumType TextureMapping TextureMapping TextureMapping Int32 )
            value.UvLineOffset                              = GetSingle(new IntPtr(p + 0x0FC)); // 0270068EC340 0xFC UvLineOffset                ( 000186666050 ModelPrimitiveType float float float Single )
            value.GeometrySortingOrder                      = (VertexSortingOrder)GetInt32(new IntPtr(p + 0x100)); // 0270068EC360 0x100 GeometrySortingOrder        ( 000186514C50 ModelEnumType VertexSortingOrder VertexSortingOrder VertexSortingOrder Int32 )
            value.InverseYAxis                              = GetBool(new IntPtr(p + 0x104)); // 0270068EC380 0x104 InverseYAxis                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CharWidthMaxAdj                           = GetSingle(new IntPtr(p + 0x108)); // 0270068EC3A0 0x108 CharWidthMaxAdj             ( 000186666050 ModelPrimitiveType float float float Single )
            value.InputSource                               = (TextInputSource)GetInt32(new IntPtr(p + 0x10C)); // 0270068EC3C0 0x10C InputSource                 ( 00018663F810 ModelEnumType TextInputSource TextInputSource TextInputSource Int32 )

            return value;
        }
    }
}
