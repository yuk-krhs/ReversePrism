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
    // 018 StringLength                             ModelPrimitiveType int int int Int32
    // 01C ElementType                              ModelEnumType TMP_TextElementType TMP_TextElementType TMP_TextElementType Int32
    // 020 TextElement                              ModelClassType TMP_TextElement TMP_TextElement TMP_TextElement Pointer
    // 028 FontAsset                                ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 030 SpriteAsset                              ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer
    // 038 SpriteIndex                              ModelPrimitiveType int int int Int32
    // 040 Material                                 ModelClassType Material Material Material Pointer
    // 048 MaterialReferenceIndex                   ModelPrimitiveType int int int Int32
    // 04C IsUsingAlternateTypeface                 ModelPrimitiveType bool bool bool Bool
    // 050 PointSize                                ModelPrimitiveType float float float Single
    // 054 LineNumber                               ModelPrimitiveType int int int Int32
    // 058 PageNumber                               ModelPrimitiveType int int int Int32
    // 05C VertexIndex                              ModelPrimitiveType int int int Int32
    // 060 Vertex_BL                                ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32
    // 088 Vertex_TL                                ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32
    // 0B0 Vertex_TR                                ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32
    // 0D8 Vertex_BR                                ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32
    // 100 TopLeft                                  ModelEnumType Vector3 Vector3 Vector3 Int32
    // 10C BottomLeft                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 118 TopRight                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 124 BottomRight                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 130 Origin                                   ModelPrimitiveType float float float Single
    // 134 XAdvance                                 ModelPrimitiveType float float float Single
    // 138 Ascender                                 ModelPrimitiveType float float float Single
    // 13C BaseLine                                 ModelPrimitiveType float float float Single
    // 140 Descender                                ModelPrimitiveType float float float Single
    // 144 AdjustedAscender                         ModelPrimitiveType float float float Single
    // 148 AdjustedDescender                        ModelPrimitiveType float float float Single
    // 14C AspectRatio                              ModelPrimitiveType float float float Single
    // 150 Scale                                    ModelPrimitiveType float float float Single
    // 154 Color                                    ModelEnumType Color32 Color32 Color32 Int32
    // 158 UnderlineColor                           ModelEnumType Color32 Color32 Color32 Int32
    // 15C UnderlineVertexIndex                     ModelPrimitiveType int int int Int32
    // 160 StrikethroughColor                       ModelEnumType Color32 Color32 Color32 Int32
    // 164 StrikethroughVertexIndex                 ModelPrimitiveType int int int Int32
    // 168 HighlightColor                           ModelEnumType Color32 Color32 Color32 Int32
    // 16C HighlightState                           ModelEnumType HighlightState HighlightState HighlightState Int32
    // 180 Style                                    ModelEnumType FontStyles FontStyles FontStyles Int32
    // 184 IsVisible                                ModelPrimitiveType bool bool bool Bool
    public partial class TMP_CharacterInfo : DataModel
    {
        public int                                      Index                                   { get; set; }
        public int                                      StringLength                            { get; set; }
        public TMP_TextElementType                      ElementType                             { get; set; }
        public TMP_TextElement?                         TextElement                             { get; set; }
        public TMP_FontAsset?                           FontAsset                               { get; set; }
        public TMP_SpriteAsset?                         SpriteAsset                             { get; set; }
        public int                                      SpriteIndex                             { get; set; }
        public Material?                                Material                                { get; set; }
        public int                                      MaterialReferenceIndex                  { get; set; }
        public bool                                     IsUsingAlternateTypeface                { get; set; }
        public float                                    PointSize                               { get; set; }
        public int                                      LineNumber                              { get; set; }
        public int                                      PageNumber                              { get; set; }
        public int                                      VertexIndex                             { get; set; }
        public TMP_Vertex                               Vertex_BL                               { get; set; }
        public TMP_Vertex                               Vertex_TL                               { get; set; }
        public TMP_Vertex                               Vertex_TR                               { get; set; }
        public TMP_Vertex                               Vertex_BR                               { get; set; }
        public Vector3                                  TopLeft                                 { get; set; }
        public Vector3                                  BottomLeft                              { get; set; }
        public Vector3                                  TopRight                                { get; set; }
        public Vector3                                  BottomRight                             { get; set; }
        public float                                    Origin                                  { get; set; }
        public float                                    XAdvance                                { get; set; }
        public float                                    Ascender                                { get; set; }
        public float                                    BaseLine                                { get; set; }
        public float                                    Descender                               { get; set; }
        public float                                    AdjustedAscender                        { get; set; }
        public float                                    AdjustedDescender                       { get; set; }
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

        public static TMP_CharacterInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_CharacterInfo() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Index                       ( ModelPrimitiveType int int int Int32 )
            value.StringLength                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 StringLength                ( ModelPrimitiveType int int int Int32 )
            value.ElementType                               = (TMP_TextElementType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ElementType                 ( ModelEnumType TMP_TextElementType TMP_TextElementType TMP_TextElementType Int32 )
            value.TextElement                               = GetObject<TMP_TextElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.TMP_TextElement.FromPointer); // 0x20 TextElement                 ( ModelClassType TMP_TextElement TMP_TextElement TMP_TextElement Pointer )
            value.FontAsset                                 = GetObject<TMP_FontAsset>(new IntPtr(p + 0x028), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0x28 FontAsset                   ( ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.SpriteAsset                               = GetObject<TMP_SpriteAsset>(new IntPtr(p + 0x030), ReversePrism.DataModels.TMP_SpriteAsset.FromPointer); // 0x30 SpriteAsset                 ( ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer )
            value.SpriteIndex                               = GetInt32(new IntPtr(p + 0x038)); // 0x38 SpriteIndex                 ( ModelPrimitiveType int int int Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x040), ReversePrism.DataModels.Material.FromPointer); // 0x40 Material                    ( ModelClassType Material Material Material Pointer )
            value.MaterialReferenceIndex                    = GetInt32(new IntPtr(p + 0x048)); // 0x48 MaterialReferenceIndex      ( ModelPrimitiveType int int int Int32 )
            value.IsUsingAlternateTypeface                  = GetBool(new IntPtr(p + 0x04C)); // 0x4C IsUsingAlternateTypeface    ( ModelPrimitiveType bool bool bool Bool )
            value.PointSize                                 = GetSingle(new IntPtr(p + 0x050)); // 0x50 PointSize                   ( ModelPrimitiveType float float float Single )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x054)); // 0x54 LineNumber                  ( ModelPrimitiveType int int int Int32 )
            value.PageNumber                                = GetInt32(new IntPtr(p + 0x058)); // 0x58 PageNumber                  ( ModelPrimitiveType int int int Int32 )
            value.VertexIndex                               = GetInt32(new IntPtr(p + 0x05C)); // 0x5C VertexIndex                 ( ModelPrimitiveType int int int Int32 )
            value.Vertex_BL                                 = (TMP_Vertex)GetInt32(new IntPtr(p + 0x060)); // 0x60 Vertex_BL                   ( ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32 )
            value.Vertex_TL                                 = (TMP_Vertex)GetInt32(new IntPtr(p + 0x088)); // 0x88 Vertex_TL                   ( ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32 )
            value.Vertex_TR                                 = (TMP_Vertex)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 Vertex_TR                   ( ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32 )
            value.Vertex_BR                                 = (TMP_Vertex)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 Vertex_BR                   ( ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32 )
            value.TopLeft                                   = (Vector3)GetInt32(new IntPtr(p + 0x100)); // 0x100 TopLeft                     ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BottomLeft                                = (Vector3)GetInt32(new IntPtr(p + 0x10C)); // 0x10C BottomLeft                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TopRight                                  = (Vector3)GetInt32(new IntPtr(p + 0x118)); // 0x118 TopRight                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BottomRight                               = (Vector3)GetInt32(new IntPtr(p + 0x124)); // 0x124 BottomRight                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Origin                                    = GetSingle(new IntPtr(p + 0x130)); // 0x130 Origin                      ( ModelPrimitiveType float float float Single )
            value.XAdvance                                  = GetSingle(new IntPtr(p + 0x134)); // 0x134 XAdvance                    ( ModelPrimitiveType float float float Single )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x138)); // 0x138 Ascender                    ( ModelPrimitiveType float float float Single )
            value.BaseLine                                  = GetSingle(new IntPtr(p + 0x13C)); // 0x13C BaseLine                    ( ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x140)); // 0x140 Descender                   ( ModelPrimitiveType float float float Single )
            value.AdjustedAscender                          = GetSingle(new IntPtr(p + 0x144)); // 0x144 AdjustedAscender            ( ModelPrimitiveType float float float Single )
            value.AdjustedDescender                         = GetSingle(new IntPtr(p + 0x148)); // 0x148 AdjustedDescender           ( ModelPrimitiveType float float float Single )
            value.AspectRatio                               = GetSingle(new IntPtr(p + 0x14C)); // 0x14C AspectRatio                 ( ModelPrimitiveType float float float Single )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x150)); // 0x150 Scale                       ( ModelPrimitiveType float float float Single )
            value.Color                                     = (Color32)GetInt32(new IntPtr(p + 0x154)); // 0x154 Color                       ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.UnderlineColor                            = (Color32)GetInt32(new IntPtr(p + 0x158)); // 0x158 UnderlineColor              ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.UnderlineVertexIndex                      = GetInt32(new IntPtr(p + 0x15C)); // 0x15C UnderlineVertexIndex        ( ModelPrimitiveType int int int Int32 )
            value.StrikethroughColor                        = (Color32)GetInt32(new IntPtr(p + 0x160)); // 0x160 StrikethroughColor          ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.StrikethroughVertexIndex                  = GetInt32(new IntPtr(p + 0x164)); // 0x164 StrikethroughVertexIndex    ( ModelPrimitiveType int int int Int32 )
            value.HighlightColor                            = (Color32)GetInt32(new IntPtr(p + 0x168)); // 0x168 HighlightColor              ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.HighlightState                            = (HighlightState)GetInt32(new IntPtr(p + 0x16C)); // 0x16C HighlightState              ( ModelEnumType HighlightState HighlightState HighlightState Int32 )
            value.Style                                     = (FontStyles)GetInt32(new IntPtr(p + 0x180)); // 0x180 Style                       ( ModelEnumType FontStyles FontStyles FontStyles Int32 )
            value.IsVisible                                 = GetBool(new IntPtr(p + 0x184)); // 0x184 IsVisible                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
