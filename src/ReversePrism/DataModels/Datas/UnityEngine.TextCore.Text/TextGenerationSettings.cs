using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     ModelPrimitiveType string string string String
    // 018 ScreenRect                               ModelEnumType Rect Rect Rect Int32
    // 028 Margins                                  ModelEnumType Vector4 Vector4 Vector4 Int32
    // 038 Scale                                    ModelPrimitiveType float float float Single
    // 040 FontAsset                                ModelClassType FontAsset FontAsset FontAsset Pointer
    // 048 Material                                 ModelClassType Material Material Material Pointer
    // 050 SpriteAsset                              ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer
    // 058 StyleSheet                               ModelClassType TextStyleSheet TextStyleSheet TextStyleSheet Pointer
    // 060 FontStyle                                ModelEnumType FontStyles FontStyles FontStyles Int32
    // 068 TextSettings                             ModelClassType TextSettings TextSettings TextSettings Pointer
    // 070 TextAlignment                            ModelEnumType TextAlignment TextAlignment TextAlignment Int32
    // 074 OverflowMode                             ModelEnumType TextOverflowMode TextOverflowMode TextOverflowMode Int32
    // 078 WordWrap                                 ModelPrimitiveType bool bool bool Bool
    // 07C WordWrappingRatio                        ModelPrimitiveType float float float Single
    // 080 Color                                    ModelEnumType Color Color Color Int32
    // 090 FontColorGradient                        ModelClassType TextColorGradient TextColorGradient TextColorGradient Pointer
    // 098 FontColorGradientPreset                  ModelClassType TextColorGradient TextColorGradient TextColorGradient Pointer
    // 0A0 TintSprites                              ModelPrimitiveType bool bool bool Bool
    // 0A1 OverrideRichTextColors                   ModelPrimitiveType bool bool bool Bool
    // 0A2 ShouldConvertToLinearSpace               ModelPrimitiveType bool bool bool Bool
    // 0A4 FontSize                                 ModelPrimitiveType float float float Single
    // 0A8 AutoSize                                 ModelPrimitiveType bool bool bool Bool
    // 0AC FontSizeMin                              ModelPrimitiveType float float float Single
    // 0B0 FontSizeMax                              ModelPrimitiveType float float float Single
    // 0B4 EnableKerning                            ModelPrimitiveType bool bool bool Bool
    // 0B5 RichText                                 ModelPrimitiveType bool bool bool Bool
    // 0B6 IsRightToLeft                            ModelPrimitiveType bool bool bool Bool
    // 0B8 ExtraPadding                             ModelPrimitiveType float float float Single
    // 0BC ParseControlCharacters                   ModelPrimitiveType bool bool bool Bool
    // 0BD IsOrthographic                           ModelPrimitiveType bool bool bool Bool
    // 0BE TagNoParsing                             ModelPrimitiveType bool bool bool Bool
    // 0C0 CharacterSpacing                         ModelPrimitiveType float float float Single
    // 0C4 WordSpacing                              ModelPrimitiveType float float float Single
    // 0C8 LineSpacing                              ModelPrimitiveType float float float Single
    // 0CC ParagraphSpacing                         ModelPrimitiveType float float float Single
    // 0D0 LineSpacingMax                           ModelPrimitiveType float float float Single
    // 0D4 TextWrappingMode                         ModelEnumType TextWrappingMode TextWrappingMode TextWrappingMode Int32
    // 0D8 MaxVisibleCharacters                     ModelPrimitiveType int int int Int32
    // 0DC MaxVisibleWords                          ModelPrimitiveType int int int Int32
    // 0E0 MaxVisibleLines                          ModelPrimitiveType int int int Int32
    // 0E4 FirstVisibleCharacter                    ModelPrimitiveType int int int Int32
    // 0E8 UseMaxVisibleDescender                   ModelPrimitiveType bool bool bool Bool
    // 0EC FontWeight                               ModelEnumType TextFontWeight TextFontWeight TextFontWeight Int32
    // 0F0 PageToDisplay                            ModelPrimitiveType int int int Int32
    // 0F4 HorizontalMapping                        ModelEnumType TextureMapping TextureMapping TextureMapping Int32
    // 0F8 VerticalMapping                          ModelEnumType TextureMapping TextureMapping TextureMapping Int32
    // 0FC UvLineOffset                             ModelPrimitiveType float float float Single
    // 100 GeometrySortingOrder                     ModelEnumType VertexSortingOrder VertexSortingOrder VertexSortingOrder Int32
    // 104 InverseYAxis                             ModelPrimitiveType bool bool bool Bool
    // 108 CharWidthMaxAdj                          ModelPrimitiveType float float float Single
    // 10C InputSource                              ModelEnumType TextInputSource TextInputSource TextInputSource Int32
    public partial class TextGenerationSettings : DataModel
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
            var value   = new TextGenerationSettings() { Pointer= p0 };

            value.Text                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Text                        ( ModelPrimitiveType string string string String )
            value.ScreenRect                                = (Rect)GetInt32(new IntPtr(p + 0x018)); // 0x18 ScreenRect                  ( ModelEnumType Rect Rect Rect Int32 )
            value.Margins                                   = (Vector4)GetInt32(new IntPtr(p + 0x028)); // 0x28 Margins                     ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x038)); // 0x38 Scale                       ( ModelPrimitiveType float float float Single )
            value.FontAsset                                 = GetObject<FontAsset>(new IntPtr(p + 0x040), ReversePrism.DataModels.FontAsset.FromPointer); // 0x40 FontAsset                   ( ModelClassType FontAsset FontAsset FontAsset Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x048), ReversePrism.DataModels.Material.FromPointer); // 0x48 Material                    ( ModelClassType Material Material Material Pointer )
            value.SpriteAsset                               = GetObject<SpriteAsset>(new IntPtr(p + 0x050), ReversePrism.DataModels.SpriteAsset.FromPointer); // 0x50 SpriteAsset                 ( ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer )
            value.StyleSheet                                = GetObject<TextStyleSheet>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextStyleSheet.FromPointer); // 0x58 StyleSheet                  ( ModelClassType TextStyleSheet TextStyleSheet TextStyleSheet Pointer )
            value.FontStyle                                 = (FontStyles)GetInt32(new IntPtr(p + 0x060)); // 0x60 FontStyle                   ( ModelEnumType FontStyles FontStyles FontStyles Int32 )
            value.TextSettings                              = GetObject<TextSettings>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextSettings.FromPointer); // 0x68 TextSettings                ( ModelClassType TextSettings TextSettings TextSettings Pointer )
            value.TextAlignment                             = (TextAlignment)GetInt32(new IntPtr(p + 0x070)); // 0x70 TextAlignment               ( ModelEnumType TextAlignment TextAlignment TextAlignment Int32 )
            value.OverflowMode                              = (TextOverflowMode)GetInt32(new IntPtr(p + 0x074)); // 0x74 OverflowMode                ( ModelEnumType TextOverflowMode TextOverflowMode TextOverflowMode Int32 )
            value.WordWrap                                  = GetBool(new IntPtr(p + 0x078)); // 0x78 WordWrap                    ( ModelPrimitiveType bool bool bool Bool )
            value.WordWrappingRatio                         = GetSingle(new IntPtr(p + 0x07C)); // 0x7C WordWrappingRatio           ( ModelPrimitiveType float float float Single )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x080)); // 0x80 Color                       ( ModelEnumType Color Color Color Int32 )
            value.FontColorGradient                         = GetObject<TextColorGradient>(new IntPtr(p + 0x090), ReversePrism.DataModels.TextColorGradient.FromPointer); // 0x90 FontColorGradient           ( ModelClassType TextColorGradient TextColorGradient TextColorGradient Pointer )
            value.FontColorGradientPreset                   = GetObject<TextColorGradient>(new IntPtr(p + 0x098), ReversePrism.DataModels.TextColorGradient.FromPointer); // 0x98 FontColorGradientPreset     ( ModelClassType TextColorGradient TextColorGradient TextColorGradient Pointer )
            value.TintSprites                               = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 TintSprites                 ( ModelPrimitiveType bool bool bool Bool )
            value.OverrideRichTextColors                    = GetBool(new IntPtr(p + 0x0A1)); // 0xA1 OverrideRichTextColors      ( ModelPrimitiveType bool bool bool Bool )
            value.ShouldConvertToLinearSpace                = GetBool(new IntPtr(p + 0x0A2)); // 0xA2 ShouldConvertToLinearSpace  ( ModelPrimitiveType bool bool bool Bool )
            value.FontSize                                  = GetSingle(new IntPtr(p + 0x0A4)); // 0xA4 FontSize                    ( ModelPrimitiveType float float float Single )
            value.AutoSize                                  = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 AutoSize                    ( ModelPrimitiveType bool bool bool Bool )
            value.FontSizeMin                               = GetSingle(new IntPtr(p + 0x0AC)); // 0xAC FontSizeMin                 ( ModelPrimitiveType float float float Single )
            value.FontSizeMax                               = GetSingle(new IntPtr(p + 0x0B0)); // 0xB0 FontSizeMax                 ( ModelPrimitiveType float float float Single )
            value.EnableKerning                             = GetBool(new IntPtr(p + 0x0B4)); // 0xB4 EnableKerning               ( ModelPrimitiveType bool bool bool Bool )
            value.RichText                                  = GetBool(new IntPtr(p + 0x0B5)); // 0xB5 RichText                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsRightToLeft                             = GetBool(new IntPtr(p + 0x0B6)); // 0xB6 IsRightToLeft               ( ModelPrimitiveType bool bool bool Bool )
            value.ExtraPadding                              = GetSingle(new IntPtr(p + 0x0B8)); // 0xB8 ExtraPadding                ( ModelPrimitiveType float float float Single )
            value.ParseControlCharacters                    = GetBool(new IntPtr(p + 0x0BC)); // 0xBC ParseControlCharacters      ( ModelPrimitiveType bool bool bool Bool )
            value.IsOrthographic                            = GetBool(new IntPtr(p + 0x0BD)); // 0xBD IsOrthographic              ( ModelPrimitiveType bool bool bool Bool )
            value.TagNoParsing                              = GetBool(new IntPtr(p + 0x0BE)); // 0xBE TagNoParsing                ( ModelPrimitiveType bool bool bool Bool )
            value.CharacterSpacing                          = GetSingle(new IntPtr(p + 0x0C0)); // 0xC0 CharacterSpacing            ( ModelPrimitiveType float float float Single )
            value.WordSpacing                               = GetSingle(new IntPtr(p + 0x0C4)); // 0xC4 WordSpacing                 ( ModelPrimitiveType float float float Single )
            value.LineSpacing                               = GetSingle(new IntPtr(p + 0x0C8)); // 0xC8 LineSpacing                 ( ModelPrimitiveType float float float Single )
            value.ParagraphSpacing                          = GetSingle(new IntPtr(p + 0x0CC)); // 0xCC ParagraphSpacing            ( ModelPrimitiveType float float float Single )
            value.LineSpacingMax                            = GetSingle(new IntPtr(p + 0x0D0)); // 0xD0 LineSpacingMax              ( ModelPrimitiveType float float float Single )
            value.TextWrappingMode                          = (TextWrappingMode)GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 TextWrappingMode            ( ModelEnumType TextWrappingMode TextWrappingMode TextWrappingMode Int32 )
            value.MaxVisibleCharacters                      = GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 MaxVisibleCharacters        ( ModelPrimitiveType int int int Int32 )
            value.MaxVisibleWords                           = GetInt32(new IntPtr(p + 0x0DC)); // 0xDC MaxVisibleWords             ( ModelPrimitiveType int int int Int32 )
            value.MaxVisibleLines                           = GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 MaxVisibleLines             ( ModelPrimitiveType int int int Int32 )
            value.FirstVisibleCharacter                     = GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 FirstVisibleCharacter       ( ModelPrimitiveType int int int Int32 )
            value.UseMaxVisibleDescender                    = GetBool(new IntPtr(p + 0x0E8)); // 0xE8 UseMaxVisibleDescender      ( ModelPrimitiveType bool bool bool Bool )
            value.FontWeight                                = (TextFontWeight)GetInt32(new IntPtr(p + 0x0EC)); // 0xEC FontWeight                  ( ModelEnumType TextFontWeight TextFontWeight TextFontWeight Int32 )
            value.PageToDisplay                             = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 PageToDisplay               ( ModelPrimitiveType int int int Int32 )
            value.HorizontalMapping                         = (TextureMapping)GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 HorizontalMapping           ( ModelEnumType TextureMapping TextureMapping TextureMapping Int32 )
            value.VerticalMapping                           = (TextureMapping)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 VerticalMapping             ( ModelEnumType TextureMapping TextureMapping TextureMapping Int32 )
            value.UvLineOffset                              = GetSingle(new IntPtr(p + 0x0FC)); // 0xFC UvLineOffset                ( ModelPrimitiveType float float float Single )
            value.GeometrySortingOrder                      = (VertexSortingOrder)GetInt32(new IntPtr(p + 0x100)); // 0x100 GeometrySortingOrder        ( ModelEnumType VertexSortingOrder VertexSortingOrder VertexSortingOrder Int32 )
            value.InverseYAxis                              = GetBool(new IntPtr(p + 0x104)); // 0x104 InverseYAxis                ( ModelPrimitiveType bool bool bool Bool )
            value.CharWidthMaxAdj                           = GetSingle(new IntPtr(p + 0x108)); // 0x108 CharWidthMaxAdj             ( ModelPrimitiveType float float float Single )
            value.InputSource                               = (TextInputSource)GetInt32(new IntPtr(p + 0x10C)); // 0x10C InputSource                 ( ModelEnumType TextInputSource TextInputSource TextInputSource Int32 )

            return value;
        }
    }
}
