using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 character                                char IL2CPP_TYPE_CHAR
    // 014 Index                                    ModelPrimitiveType int int int Int32
    // 018 ElementType                              ModelEnumType TextElementType TextElementType TextElementType Int32
    // 01C StringLength                             ModelPrimitiveType int int int Int32
    // 020 TextElement                              ModelClassType TextElement TextElement TextElement Pointer
    // 028 AlternativeGlyph                         ModelClassType Glyph Glyph Glyph Pointer
    // 030 FontAsset                                ModelClassType FontAsset FontAsset FontAsset Pointer
    // 038 SpriteAsset                              ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer
    // 040 SpriteIndex                              ModelPrimitiveType int int int Int32
    // 048 Material                                 ModelClassType Material Material Material Pointer
    // 050 MaterialReferenceIndex                   ModelPrimitiveType int int int Int32
    // 054 IsUsingAlternateTypeface                 ModelPrimitiveType bool bool bool Bool
    // 058 PointSize                                ModelPrimitiveType float float float Single
    // 05C LineNumber                               ModelPrimitiveType int int int Int32
    // 060 PageNumber                               ModelPrimitiveType int int int Int32
    // 064 VertexIndex                              ModelPrimitiveType int int int Int32
    // 068 VertexTopLeft                            ModelEnumType TextVertex TextVertex TextVertex Int32
    // 090 VertexBottomLeft                         ModelEnumType TextVertex TextVertex TextVertex Int32
    // 0B8 VertexTopRight                           ModelEnumType TextVertex TextVertex TextVertex Int32
    // 0E0 VertexBottomRight                        ModelEnumType TextVertex TextVertex TextVertex Int32
    // 108 TopLeft                                  ModelEnumType Vector3 Vector3 Vector3 Int32
    // 114 BottomLeft                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 120 TopRight                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 12C BottomRight                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 138 Origin                                   ModelPrimitiveType float float float Single
    // 13C Ascender                                 ModelPrimitiveType float float float Single
    // 140 BaseLine                                 ModelPrimitiveType float float float Single
    // 144 Descender                                ModelPrimitiveType float float float Single
    // 148 AdjustedAscender                         ModelPrimitiveType float float float Single
    // 14C AdjustedDescender                        ModelPrimitiveType float float float Single
    // 150 AdjustedHorizontalAdvance                ModelPrimitiveType float float float Single
    // 154 XAdvance                                 ModelPrimitiveType float float float Single
    // 158 AspectRatio                              ModelPrimitiveType float float float Single
    // 15C Scale                                    ModelPrimitiveType float float float Single
    // 160 Color                                    ModelEnumType Color32 Color32 Color32 Int32
    // 164 UnderlineColor                           ModelEnumType Color32 Color32 Color32 Int32
    // 168 UnderlineVertexIndex                     ModelPrimitiveType int int int Int32
    // 16C StrikethroughColor                       ModelEnumType Color32 Color32 Color32 Int32
    // 170 StrikethroughVertexIndex                 ModelPrimitiveType int int int Int32
    // 174 HighlightColor                           ModelEnumType Color32 Color32 Color32 Int32
    // 178 HighlightState                           ModelEnumType HighlightState HighlightState HighlightState Int32
    // 18C Style                                    ModelEnumType FontStyles FontStyles FontStyles Int32
    // 190 IsVisible                                ModelPrimitiveType bool bool bool Bool
    public partial class TextElementInfo : DataModel
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
            var value   = new TextElementInfo() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Index                       ( ModelPrimitiveType int int int Int32 )
            value.ElementType                               = (TextElementType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ElementType                 ( ModelEnumType TextElementType TextElementType TextElementType Int32 )
            value.StringLength                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C StringLength                ( ModelPrimitiveType int int int Int32 )
            value.TextElement                               = GetObject<TextElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextElement.FromPointer); // 0x20 TextElement                 ( ModelClassType TextElement TextElement TextElement Pointer )
            value.AlternativeGlyph                          = GetObject<Glyph>(new IntPtr(p + 0x028), ReversePrism.DataModels.Glyph.FromPointer); // 0x28 AlternativeGlyph            ( ModelClassType Glyph Glyph Glyph Pointer )
            value.FontAsset                                 = GetObject<FontAsset>(new IntPtr(p + 0x030), ReversePrism.DataModels.FontAsset.FromPointer); // 0x30 FontAsset                   ( ModelClassType FontAsset FontAsset FontAsset Pointer )
            value.SpriteAsset                               = GetObject<SpriteAsset>(new IntPtr(p + 0x038), ReversePrism.DataModels.SpriteAsset.FromPointer); // 0x38 SpriteAsset                 ( ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer )
            value.SpriteIndex                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 SpriteIndex                 ( ModelPrimitiveType int int int Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x048), ReversePrism.DataModels.Material.FromPointer); // 0x48 Material                    ( ModelClassType Material Material Material Pointer )
            value.MaterialReferenceIndex                    = GetInt32(new IntPtr(p + 0x050)); // 0x50 MaterialReferenceIndex      ( ModelPrimitiveType int int int Int32 )
            value.IsUsingAlternateTypeface                  = GetBool(new IntPtr(p + 0x054)); // 0x54 IsUsingAlternateTypeface    ( ModelPrimitiveType bool bool bool Bool )
            value.PointSize                                 = GetSingle(new IntPtr(p + 0x058)); // 0x58 PointSize                   ( ModelPrimitiveType float float float Single )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x05C)); // 0x5C LineNumber                  ( ModelPrimitiveType int int int Int32 )
            value.PageNumber                                = GetInt32(new IntPtr(p + 0x060)); // 0x60 PageNumber                  ( ModelPrimitiveType int int int Int32 )
            value.VertexIndex                               = GetInt32(new IntPtr(p + 0x064)); // 0x64 VertexIndex                 ( ModelPrimitiveType int int int Int32 )
            value.VertexTopLeft                             = (TextVertex)GetInt32(new IntPtr(p + 0x068)); // 0x68 VertexTopLeft               ( ModelEnumType TextVertex TextVertex TextVertex Int32 )
            value.VertexBottomLeft                          = (TextVertex)GetInt32(new IntPtr(p + 0x090)); // 0x90 VertexBottomLeft            ( ModelEnumType TextVertex TextVertex TextVertex Int32 )
            value.VertexTopRight                            = (TextVertex)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 VertexTopRight              ( ModelEnumType TextVertex TextVertex TextVertex Int32 )
            value.VertexBottomRight                         = (TextVertex)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 VertexBottomRight           ( ModelEnumType TextVertex TextVertex TextVertex Int32 )
            value.TopLeft                                   = (Vector3)GetInt32(new IntPtr(p + 0x108)); // 0x108 TopLeft                     ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BottomLeft                                = (Vector3)GetInt32(new IntPtr(p + 0x114)); // 0x114 BottomLeft                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TopRight                                  = (Vector3)GetInt32(new IntPtr(p + 0x120)); // 0x120 TopRight                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BottomRight                               = (Vector3)GetInt32(new IntPtr(p + 0x12C)); // 0x12C BottomRight                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Origin                                    = GetSingle(new IntPtr(p + 0x138)); // 0x138 Origin                      ( ModelPrimitiveType float float float Single )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x13C)); // 0x13C Ascender                    ( ModelPrimitiveType float float float Single )
            value.BaseLine                                  = GetSingle(new IntPtr(p + 0x140)); // 0x140 BaseLine                    ( ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x144)); // 0x144 Descender                   ( ModelPrimitiveType float float float Single )
            value.AdjustedAscender                          = GetSingle(new IntPtr(p + 0x148)); // 0x148 AdjustedAscender            ( ModelPrimitiveType float float float Single )
            value.AdjustedDescender                         = GetSingle(new IntPtr(p + 0x14C)); // 0x14C AdjustedDescender           ( ModelPrimitiveType float float float Single )
            value.AdjustedHorizontalAdvance                 = GetSingle(new IntPtr(p + 0x150)); // 0x150 AdjustedHorizontalAdvance   ( ModelPrimitiveType float float float Single )
            value.XAdvance                                  = GetSingle(new IntPtr(p + 0x154)); // 0x154 XAdvance                    ( ModelPrimitiveType float float float Single )
            value.AspectRatio                               = GetSingle(new IntPtr(p + 0x158)); // 0x158 AspectRatio                 ( ModelPrimitiveType float float float Single )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x15C)); // 0x15C Scale                       ( ModelPrimitiveType float float float Single )
            value.Color                                     = (Color32)GetInt32(new IntPtr(p + 0x160)); // 0x160 Color                       ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.UnderlineColor                            = (Color32)GetInt32(new IntPtr(p + 0x164)); // 0x164 UnderlineColor              ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.UnderlineVertexIndex                      = GetInt32(new IntPtr(p + 0x168)); // 0x168 UnderlineVertexIndex        ( ModelPrimitiveType int int int Int32 )
            value.StrikethroughColor                        = (Color32)GetInt32(new IntPtr(p + 0x16C)); // 0x16C StrikethroughColor          ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.StrikethroughVertexIndex                  = GetInt32(new IntPtr(p + 0x170)); // 0x170 StrikethroughVertexIndex    ( ModelPrimitiveType int int int Int32 )
            value.HighlightColor                            = (Color32)GetInt32(new IntPtr(p + 0x174)); // 0x174 HighlightColor              ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.HighlightState                            = (HighlightState)GetInt32(new IntPtr(p + 0x178)); // 0x178 HighlightState              ( ModelEnumType HighlightState HighlightState HighlightState Int32 )
            value.Style                                     = (FontStyles)GetInt32(new IntPtr(p + 0x18C)); // 0x18C Style                       ( ModelEnumType FontStyles FontStyles FontStyles Int32 )
            value.IsVisible                                 = GetBool(new IntPtr(p + 0x190)); // 0x190 IsVisible                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
