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
    // 018 StringLength                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C ElementType                              000186614BB0 ModelEnumType TMP_TextElementType TMP_TextElementType TMP_TextElementType Int32
    // 020 TextElement                              0001866144C0 ModelClassType TMP_TextElement TMP_TextElement TMP_TextElement Pointer
    // 028 FontAsset                                00018667FCE0 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 030 SpriteAsset                              0001866808F0 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer
    // 038 SpriteIndex                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 Material                                 00018660C4B0 ModelClassType Material Material Material Pointer
    // 048 MaterialReferenceIndex                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 04C IsUsingAlternateTypeface                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 050 PointSize                                000186666050 ModelPrimitiveType float float float Single
    // 054 LineNumber                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 058 PageNumber                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 05C VertexIndex                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 060 Vertex_BL                                000186616F00 ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32
    // 088 Vertex_TL                                000186616F00 ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32
    // 0B0 Vertex_TR                                000186616F00 ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32
    // 0D8 Vertex_BR                                000186616F00 ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32
    // 100 TopLeft                                  0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 10C BottomLeft                               0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 118 TopRight                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 124 BottomRight                              0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 130 Origin                                   000186666050 ModelPrimitiveType float float float Single
    // 134 XAdvance                                 000186666050 ModelPrimitiveType float float float Single
    // 138 Ascender                                 000186666050 ModelPrimitiveType float float float Single
    // 13C BaseLine                                 000186666050 ModelPrimitiveType float float float Single
    // 140 Descender                                000186666050 ModelPrimitiveType float float float Single
    // 144 AdjustedAscender                         000186665900 ModelPrimitiveType float float float Single
    // 148 AdjustedDescender                        000186665900 ModelPrimitiveType float float float Single
    // 14C AspectRatio                              000186666050 ModelPrimitiveType float float float Single
    // 150 Scale                                    000186666050 ModelPrimitiveType float float float Single
    // 154 Color                                    0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 158 UnderlineColor                           0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 15C UnderlineVertexIndex                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 160 StrikethroughColor                       0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 164 StrikethroughVertexIndex                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 168 HighlightColor                           0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 16C HighlightState                           0001866B7560 ModelEnumType HighlightState HighlightState HighlightState Int32
    // 180 Style                                    0001865B2450 ModelEnumType FontStyles FontStyles FontStyles Int32
    // 184 IsVisible                                000186595960 ModelPrimitiveType bool bool bool Bool
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

            value.Index                                     = GetInt32(new IntPtr(p + 0x014)); // 024660977F28 0x14 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StringLength                              = GetInt32(new IntPtr(p + 0x018)); // 024660977F48 0x18 StringLength                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ElementType                               = (TMP_TextElementType)GetInt32(new IntPtr(p + 0x01C)); // 024660977F68 0x1C ElementType                 ( 000186614BB0 ModelEnumType TMP_TextElementType TMP_TextElementType TMP_TextElementType Int32 )
            value.TextElement                               = GetObject<TMP_TextElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.TMP_TextElement.FromPointer); // 024660977F88 0x20 TextElement                 ( 0001866144C0 ModelClassType TMP_TextElement TMP_TextElement TMP_TextElement Pointer )
            value.FontAsset                                 = GetObject<TMP_FontAsset>(new IntPtr(p + 0x028), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 024660977FA8 0x28 FontAsset                   ( 00018667FCE0 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.SpriteAsset                               = GetObject<TMP_SpriteAsset>(new IntPtr(p + 0x030), ReversePrism.DataModels.TMP_SpriteAsset.FromPointer); // 024660977FC8 0x30 SpriteAsset                 ( 0001866808F0 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer )
            value.SpriteIndex                               = GetInt32(new IntPtr(p + 0x038)); // 024660977FE8 0x38 SpriteIndex                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x040), ReversePrism.DataModels.Material.FromPointer); // 024660978008 0x40 Material                    ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.MaterialReferenceIndex                    = GetInt32(new IntPtr(p + 0x048)); // 024660978028 0x48 MaterialReferenceIndex      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsUsingAlternateTypeface                  = GetBool(new IntPtr(p + 0x04C)); // 024660978048 0x4C IsUsingAlternateTypeface    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PointSize                                 = GetSingle(new IntPtr(p + 0x050)); // 024660978068 0x50 PointSize                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x054)); // 024660978088 0x54 LineNumber                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PageNumber                                = GetInt32(new IntPtr(p + 0x058)); // 0246609780A8 0x58 PageNumber                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VertexIndex                               = GetInt32(new IntPtr(p + 0x05C)); // 0246609780C8 0x5C VertexIndex                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Vertex_BL                                 = (TMP_Vertex)GetInt32(new IntPtr(p + 0x060)); // 0246609780E8 0x60 Vertex_BL                   ( 000186616F00 ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32 )
            value.Vertex_TL                                 = (TMP_Vertex)GetInt32(new IntPtr(p + 0x088)); // 024660978108 0x88 Vertex_TL                   ( 000186616F00 ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32 )
            value.Vertex_TR                                 = (TMP_Vertex)GetInt32(new IntPtr(p + 0x0B0)); // 024660978128 0xB0 Vertex_TR                   ( 000186616F00 ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32 )
            value.Vertex_BR                                 = (TMP_Vertex)GetInt32(new IntPtr(p + 0x0D8)); // 024660978148 0xD8 Vertex_BR                   ( 000186616F00 ModelEnumType TMP_Vertex TMP_Vertex TMP_Vertex Int32 )
            value.TopLeft                                   = (Vector3)GetInt32(new IntPtr(p + 0x100)); // 024660978168 0x100 TopLeft                     ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BottomLeft                                = (Vector3)GetInt32(new IntPtr(p + 0x10C)); // 024660978188 0x10C BottomLeft                  ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TopRight                                  = (Vector3)GetInt32(new IntPtr(p + 0x118)); // 0246609781A8 0x118 TopRight                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BottomRight                               = (Vector3)GetInt32(new IntPtr(p + 0x124)); // 0246609781C8 0x124 BottomRight                 ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Origin                                    = GetSingle(new IntPtr(p + 0x130)); // 0246609781E8 0x130 Origin                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.XAdvance                                  = GetSingle(new IntPtr(p + 0x134)); // 024660978208 0x134 XAdvance                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x138)); // 024660978228 0x138 Ascender                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.BaseLine                                  = GetSingle(new IntPtr(p + 0x13C)); // 024660978248 0x13C BaseLine                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x140)); // 024660978268 0x140 Descender                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.AdjustedAscender                          = GetSingle(new IntPtr(p + 0x144)); // 024660978288 0x144 AdjustedAscender            ( 000186665900 ModelPrimitiveType float float float Single )
            value.AdjustedDescender                         = GetSingle(new IntPtr(p + 0x148)); // 0246609782A8 0x148 AdjustedDescender           ( 000186665900 ModelPrimitiveType float float float Single )
            value.AspectRatio                               = GetSingle(new IntPtr(p + 0x14C)); // 0246609782C8 0x14C AspectRatio                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x150)); // 0246609782E8 0x150 Scale                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Color                                     = (Color32)GetInt32(new IntPtr(p + 0x154)); // 024660978308 0x154 Color                       ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.UnderlineColor                            = (Color32)GetInt32(new IntPtr(p + 0x158)); // 024660978328 0x158 UnderlineColor              ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.UnderlineVertexIndex                      = GetInt32(new IntPtr(p + 0x15C)); // 024660978348 0x15C UnderlineVertexIndex        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StrikethroughColor                        = (Color32)GetInt32(new IntPtr(p + 0x160)); // 024660978368 0x160 StrikethroughColor          ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.StrikethroughVertexIndex                  = GetInt32(new IntPtr(p + 0x164)); // 024660978388 0x164 StrikethroughVertexIndex    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HighlightColor                            = (Color32)GetInt32(new IntPtr(p + 0x168)); // 0246609783A8 0x168 HighlightColor              ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.HighlightState                            = (HighlightState)GetInt32(new IntPtr(p + 0x16C)); // 0246609783C8 0x16C HighlightState              ( 0001866B7560 ModelEnumType HighlightState HighlightState HighlightState Int32 )
            value.Style                                     = (FontStyles)GetInt32(new IntPtr(p + 0x180)); // 0246609783E8 0x180 Style                       ( 0001865B2450 ModelEnumType FontStyles FontStyles FontStyles Int32 )
            value.IsVisible                                 = GetBool(new IntPtr(p + 0x184)); // 024660978408 0x184 IsVisible                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
