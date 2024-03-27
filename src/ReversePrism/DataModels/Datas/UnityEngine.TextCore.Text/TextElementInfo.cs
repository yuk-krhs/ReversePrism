using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 character                                char IL2CPP_TYPE_CHAR
    // 014 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 ElementType                              00018663A1A0 ModelEnumType TextElementType TextElementType TextElementType Int32
    // 01C StringLength                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 TextElement                              000186638650 ModelClassType TextElement TextElement TextElement Pointer
    // 028 AlternativeGlyph                         0001865DA3C0 ModelClassType Glyph Glyph Glyph Pointer
    // 030 FontAsset                                0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer
    // 038 SpriteAsset                              00018666CC70 ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer
    // 040 SpriteIndex                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 048 Material                                 00018660C4B0 ModelClassType Material Material Material Pointer
    // 050 MaterialReferenceIndex                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 054 IsUsingAlternateTypeface                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 058 PointSize                                000186666050 ModelPrimitiveType float float float Single
    // 05C LineNumber                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 060 PageNumber                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 064 VertexIndex                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 068 VertexTopLeft                            00018664A980 ModelEnumType TextVertex TextVertex TextVertex Int32
    // 090 VertexBottomLeft                         00018664A980 ModelEnumType TextVertex TextVertex TextVertex Int32
    // 0B8 VertexTopRight                           00018664A980 ModelEnumType TextVertex TextVertex TextVertex Int32
    // 0E0 VertexBottomRight                        00018664A980 ModelEnumType TextVertex TextVertex TextVertex Int32
    // 108 TopLeft                                  0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 114 BottomLeft                               0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 120 TopRight                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 12C BottomRight                              0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 138 Origin                                   000186666050 ModelPrimitiveType float float float Single
    // 13C Ascender                                 000186666050 ModelPrimitiveType float float float Single
    // 140 BaseLine                                 000186666050 ModelPrimitiveType float float float Single
    // 144 Descender                                000186666050 ModelPrimitiveType float float float Single
    // 148 AdjustedAscender                         000186665900 ModelPrimitiveType float float float Single
    // 14C AdjustedDescender                        000186665900 ModelPrimitiveType float float float Single
    // 150 AdjustedHorizontalAdvance                000186665900 ModelPrimitiveType float float float Single
    // 154 XAdvance                                 000186666050 ModelPrimitiveType float float float Single
    // 158 AspectRatio                              000186666050 ModelPrimitiveType float float float Single
    // 15C Scale                                    000186666050 ModelPrimitiveType float float float Single
    // 160 Color                                    0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 164 UnderlineColor                           0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 168 UnderlineVertexIndex                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 16C StrikethroughColor                       0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 170 StrikethroughVertexIndex                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 174 HighlightColor                           0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 178 HighlightState                           0001866B7B60 ModelEnumType HighlightState HighlightState HighlightState Int32
    // 18C Style                                    0001865B2E00 ModelEnumType FontStyles FontStyles FontStyles Int32
    // 190 IsVisible                                000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class TextElementInfo
    {
        public int                                      Index                                   { get; set; }
        public TextElementType                          ElementType                             { get; set; }
        public int                                      StringLength                            { get; set; }
        public TextElement?                             TextElement                             { get; set; }
        public Glyph?                                   AlternativeGlyph                        { get; set; }
        public FontAsset?                               FontAsset                               { get; set; }
        public SpriteAsset?                             SpriteAsset                             { get; set; }
        public int                                      SpriteIndex                             { get; set; }
        public Material?                                Material                                { get; set; }
        public int                                      MaterialReferenceIndex                  { get; set; }
        public bool                                     IsUsingAlternateTypeface                { get; set; }
        public float                                    PointSize                               { get; set; }
        public int                                      LineNumber                              { get; set; }
        public int                                      PageNumber                              { get; set; }
        public int                                      VertexIndex                             { get; set; }
        public TextVertex                               VertexTopLeft                           { get; set; }
        public TextVertex                               VertexBottomLeft                        { get; set; }
        public TextVertex                               VertexTopRight                          { get; set; }
        public TextVertex                               VertexBottomRight                       { get; set; }
        public Vector3                                  TopLeft                                 { get; set; }
        public Vector3                                  BottomLeft                              { get; set; }
        public Vector3                                  TopRight                                { get; set; }
        public Vector3                                  BottomRight                             { get; set; }
        public float                                    Origin                                  { get; set; }
        public float                                    Ascender                                { get; set; }
        public float                                    BaseLine                                { get; set; }
        public float                                    Descender                               { get; set; }
        public float                                    AdjustedAscender                        { get; set; }
        public float                                    AdjustedDescender                       { get; set; }
        public float                                    AdjustedHorizontalAdvance               { get; set; }
        public float                                    XAdvance                                { get; set; }
        public float                                    AspectRatio                             { get; set; }
        public float                                    Scale                                   { get; set; }
        public Color32                                  Color                                   { get; set; }
        public Color32                                  UnderlineColor                          { get; set; }
        public int                                      UnderlineVertexIndex                    { get; set; }
        public Color32                                  StrikethroughColor                      { get; set; }
        public int                                      StrikethroughVertexIndex                { get; set; }
        public Color32                                  HighlightColor                          { get; set; }
        public HighlightState                           HighlightState                          { get; set; }
        public FontStyles                               Style                                   { get; set; }
        public bool                                     IsVisible                               { get; set; }

        public static TextElementInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextElementInfo();

            value.Index                                     = GetInt32(new IntPtr(p + 0x014)); // 0270068EADA8 0x14 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ElementType                               = (TextElementType)GetInt32(new IntPtr(p + 0x018)); // 0270068EADC8 0x18 ElementType                 ( 00018663A1A0 ModelEnumType TextElementType TextElementType TextElementType Int32 )
            value.StringLength                              = GetInt32(new IntPtr(p + 0x01C)); // 0270068EADE8 0x1C StringLength                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TextElement                               = GetObject<TextElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextElement.FromPointer); // 0270068EAE08 0x20 TextElement                 ( 000186638650 ModelClassType TextElement TextElement TextElement Pointer )
            value.AlternativeGlyph                          = GetObject<Glyph>(new IntPtr(p + 0x028), ReversePrism.DataModels.Glyph.FromPointer); // 0270068EAE28 0x28 AlternativeGlyph            ( 0001865DA3C0 ModelClassType Glyph Glyph Glyph Pointer )
            value.FontAsset                                 = GetObject<FontAsset>(new IntPtr(p + 0x030), ReversePrism.DataModels.FontAsset.FromPointer); // 0270068EAE48 0x30 FontAsset                   ( 0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer )
            value.SpriteAsset                               = GetObject<SpriteAsset>(new IntPtr(p + 0x038), ReversePrism.DataModels.SpriteAsset.FromPointer); // 0270068EAE68 0x38 SpriteAsset                 ( 00018666CC70 ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer )
            value.SpriteIndex                               = GetInt32(new IntPtr(p + 0x040)); // 0270068EAE88 0x40 SpriteIndex                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x048), ReversePrism.DataModels.Material.FromPointer); // 0270068EAEA8 0x48 Material                    ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.MaterialReferenceIndex                    = GetInt32(new IntPtr(p + 0x050)); // 0270068EAEC8 0x50 MaterialReferenceIndex      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsUsingAlternateTypeface                  = GetBool(new IntPtr(p + 0x054)); // 0270068EAEE8 0x54 IsUsingAlternateTypeface    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PointSize                                 = GetSingle(new IntPtr(p + 0x058)); // 0270068EAF08 0x58 PointSize                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x05C)); // 0270068EAF28 0x5C LineNumber                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PageNumber                                = GetInt32(new IntPtr(p + 0x060)); // 0270068EAF48 0x60 PageNumber                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VertexIndex                               = GetInt32(new IntPtr(p + 0x064)); // 0270068EAF68 0x64 VertexIndex                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VertexTopLeft                             = (TextVertex)GetInt32(new IntPtr(p + 0x068)); // 0270068EAF88 0x68 VertexTopLeft               ( 00018664A980 ModelEnumType TextVertex TextVertex TextVertex Int32 )
            value.VertexBottomLeft                          = (TextVertex)GetInt32(new IntPtr(p + 0x090)); // 0270068EAFA8 0x90 VertexBottomLeft            ( 00018664A980 ModelEnumType TextVertex TextVertex TextVertex Int32 )
            value.VertexTopRight                            = (TextVertex)GetInt32(new IntPtr(p + 0x0B8)); // 0270068EAFC8 0xB8 VertexTopRight              ( 00018664A980 ModelEnumType TextVertex TextVertex TextVertex Int32 )
            value.VertexBottomRight                         = (TextVertex)GetInt32(new IntPtr(p + 0x0E0)); // 0270068EAFE8 0xE0 VertexBottomRight           ( 00018664A980 ModelEnumType TextVertex TextVertex TextVertex Int32 )
            value.TopLeft                                   = (Vector3)GetInt32(new IntPtr(p + 0x108)); // 0270068EB008 0x108 TopLeft                     ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BottomLeft                                = (Vector3)GetInt32(new IntPtr(p + 0x114)); // 0270068EB028 0x114 BottomLeft                  ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TopRight                                  = (Vector3)GetInt32(new IntPtr(p + 0x120)); // 0270068EB048 0x120 TopRight                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BottomRight                               = (Vector3)GetInt32(new IntPtr(p + 0x12C)); // 0270068EB068 0x12C BottomRight                 ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Origin                                    = GetSingle(new IntPtr(p + 0x138)); // 0270068EB088 0x138 Origin                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x13C)); // 0270068EB0A8 0x13C Ascender                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.BaseLine                                  = GetSingle(new IntPtr(p + 0x140)); // 0270068EB0C8 0x140 BaseLine                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x144)); // 0270068EB0E8 0x144 Descender                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.AdjustedAscender                          = GetSingle(new IntPtr(p + 0x148)); // 0270068EB108 0x148 AdjustedAscender            ( 000186665900 ModelPrimitiveType float float float Single )
            value.AdjustedDescender                         = GetSingle(new IntPtr(p + 0x14C)); // 0270068EB128 0x14C AdjustedDescender           ( 000186665900 ModelPrimitiveType float float float Single )
            value.AdjustedHorizontalAdvance                 = GetSingle(new IntPtr(p + 0x150)); // 0270068EB148 0x150 AdjustedHorizontalAdvance   ( 000186665900 ModelPrimitiveType float float float Single )
            value.XAdvance                                  = GetSingle(new IntPtr(p + 0x154)); // 0270068EB168 0x154 XAdvance                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.AspectRatio                               = GetSingle(new IntPtr(p + 0x158)); // 0270068EB188 0x158 AspectRatio                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x15C)); // 0270068EB1A8 0x15C Scale                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Color                                     = (Color32)GetInt32(new IntPtr(p + 0x160)); // 0270068EB1C8 0x160 Color                       ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.UnderlineColor                            = (Color32)GetInt32(new IntPtr(p + 0x164)); // 0270068EB1E8 0x164 UnderlineColor              ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.UnderlineVertexIndex                      = GetInt32(new IntPtr(p + 0x168)); // 0270068EB208 0x168 UnderlineVertexIndex        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StrikethroughColor                        = (Color32)GetInt32(new IntPtr(p + 0x16C)); // 0270068EB228 0x16C StrikethroughColor          ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.StrikethroughVertexIndex                  = GetInt32(new IntPtr(p + 0x170)); // 0270068EB248 0x170 StrikethroughVertexIndex    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HighlightColor                            = (Color32)GetInt32(new IntPtr(p + 0x174)); // 0270068EB268 0x174 HighlightColor              ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.HighlightState                            = (HighlightState)GetInt32(new IntPtr(p + 0x178)); // 0270068EB288 0x178 HighlightState              ( 0001866B7B60 ModelEnumType HighlightState HighlightState HighlightState Int32 )
            value.Style                                     = (FontStyles)GetInt32(new IntPtr(p + 0x18C)); // 0270068EB2A8 0x18C Style                       ( 0001865B2E00 ModelEnumType FontStyles FontStyles FontStyles Int32 )
            value.IsVisible                                 = GetBool(new IntPtr(p + 0x190)); // 0270068EB2C8 0x190 IsVisible                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
