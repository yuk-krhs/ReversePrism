using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Previous_WordBreak                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Total_CharacterCount                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Visible_CharacterCount                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Visible_SpriteCount                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Visible_LinkCount                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 FirstCharacterIndex                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 FirstVisibleCharacterIndex               0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C LastCharacterIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 LastVisibleCharIndex                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 LineNumber                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 MaxCapHeight                             000186666050 ModelPrimitiveType float float float Single
    // 03C MaxAscender                              000186666050 ModelPrimitiveType float float float Single
    // 040 MaxDescender                             000186666050 ModelPrimitiveType float float float Single
    // 044 StartOfLineAscender                      000186666050 ModelPrimitiveType float float float Single
    // 048 MaxLineAscender                          000186666050 ModelPrimitiveType float float float Single
    // 04C MaxLineDescender                         000186666050 ModelPrimitiveType float float float Single
    // 050 PageAscender                             000186666050 ModelPrimitiveType float float float Single
    // 054 HorizontalAlignment                      0001866D54B0 ModelEnumType HorizontalAlignmentOptions HorizontalAlignmentOptions HorizontalAlignmentOptions Int32
    // 058 MarginLeft                               000186666050 ModelPrimitiveType float float float Single
    // 05C MarginRight                              000186666050 ModelPrimitiveType float float float Single
    // 060 XAdvance                                 000186666050 ModelPrimitiveType float float float Single
    // 064 PreferredWidth                           000186666050 ModelPrimitiveType float float float Single
    // 068 PreferredHeight                          000186666050 ModelPrimitiveType float float float Single
    // 06C PreviousLineScale                        000186666050 ModelPrimitiveType float float float Single
    // 070 WordCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 074 FontStyle                                0001865B2450 ModelEnumType FontStyles FontStyles FontStyles Int32
    // 078 ItalicAngle                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 07C FontScaleMultiplier                      000186666050 ModelPrimitiveType float float float Single
    // 080 CurrentFontSize                          000186666050 ModelPrimitiveType float float float Single
    // 084 BaselineOffset                           000186666050 ModelPrimitiveType float float float Single
    // 088 LineOffset                               000186666050 ModelPrimitiveType float float float Single
    // 08C IsDrivenLineSpacing                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 090 GlyphHorizontalAdvanceAdjustment         000186666050 ModelPrimitiveType float float float Single
    // 094 CSpace                                   000186666050 ModelPrimitiveType float float float Single
    // 098 MSpace                                   000186666050 ModelPrimitiveType float float float Single
    // 0A0 TextInfo                                 000186615790 ModelClassType TMP_TextInfo TMP_TextInfo TMP_TextInfo Pointer
    // 0A8 LineInfo                                 00018660E740 ModelEnumType TMP_LineInfo TMP_LineInfo TMP_LineInfo Int32
    // 104 VertexColor                              0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 108 UnderlineColor                           0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 10C StrikethroughColor                       0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 110 HighlightColor                           0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 114 BasicStyleStack                          00018660C5E0 ModelEnumType TMP_FontStyleStack TMP_FontStyleStack TMP_FontStyleStack Int32
    // 120 italicAngleStack                         TMP_TextProcessingStack`1<int> IL2CPP_TYPE_GENERICINST
    // 140 colorStack                               TMP_TextProcessingStack`1<Color32> IL2CPP_TYPE_GENERICINST
    // 160 underlineColorStack                      TMP_TextProcessingStack`1<Color32> IL2CPP_TYPE_GENERICINST
    // 180 strikethroughColorStack                  TMP_TextProcessingStack`1<Color32> IL2CPP_TYPE_GENERICINST
    // 1A0 highlightColorStack                      TMP_TextProcessingStack`1<Color32> IL2CPP_TYPE_GENERICINST
    // 1C0 highlightStateStack                      TMP_TextProcessingStack`1<HighlightState> IL2CPP_TYPE_GENERICINST
    // 1F0 colorGradientStack                       TMP_TextProcessingStack`1<TMP_ColorGradient> IL2CPP_TYPE_GENERICINST
    // 218 sizeStack                                TMP_TextProcessingStack`1<float> IL2CPP_TYPE_GENERICINST
    // 238 indentStack                              TMP_TextProcessingStack`1<float> IL2CPP_TYPE_GENERICINST
    // 258 fontWeightStack                          TMP_TextProcessingStack`1<FontWeight> IL2CPP_TYPE_GENERICINST
    // 278 styleStack                               TMP_TextProcessingStack`1<int> IL2CPP_TYPE_GENERICINST
    // 298 baselineStack                            TMP_TextProcessingStack`1<float> IL2CPP_TYPE_GENERICINST
    // 2B8 actionStack                              TMP_TextProcessingStack`1<int> IL2CPP_TYPE_GENERICINST
    // 2D8 materialReferenceStack                   TMP_TextProcessingStack`1<MaterialReference> IL2CPP_TYPE_GENERICINST
    // 330 lineJustificationStack                   TMP_TextProcessingStack`1<HorizontalAlignmentOptions> IL2CPP_TYPE_GENERICINST
    // 350 SpriteAnimationID                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 358 CurrentFontAsset                         00018667FCE0 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 360 CurrentSpriteAsset                       0001866808F0 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer
    // 368 CurrentMaterial                          00018660C4B0 ModelClassType Material Material Material Pointer
    // 370 CurrentMaterialIndex                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 374 MeshExtents                              000186535DE0 ModelEnumType Extents Extents Extents Int32
    // 384 TagNoParsing                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 385 IsNonBreakingSpace                       000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class WordWrapState : DataModel
    {
        public int                                      Previous_WordBreak                      { get; set; }
        public int                                      Total_CharacterCount                    { get; set; }
        public int                                      Visible_CharacterCount                  { get; set; }
        public int                                      Visible_SpriteCount                     { get; set; }
        public int                                      Visible_LinkCount                       { get; set; }
        public int                                      FirstCharacterIndex                     { get; set; }
        public int                                      FirstVisibleCharacterIndex              { get; set; }
        public int                                      LastCharacterIndex                      { get; set; }
        public int                                      LastVisibleCharIndex                    { get; set; }
        public int                                      LineNumber                              { get; set; }
        public float                                    MaxCapHeight                            { get; set; }
        public float                                    MaxAscender                             { get; set; }
        public float                                    MaxDescender                            { get; set; }
        public float                                    StartOfLineAscender                     { get; set; }
        public float                                    MaxLineAscender                         { get; set; }
        public float                                    MaxLineDescender                        { get; set; }
        public float                                    PageAscender                            { get; set; }
        public HorizontalAlignmentOptions               HorizontalAlignment                     { get; set; }
        public float                                    MarginLeft                              { get; set; }
        public float                                    MarginRight                             { get; set; }
        public float                                    XAdvance                                { get; set; }
        public float                                    PreferredWidth                          { get; set; }
        public float                                    PreferredHeight                         { get; set; }
        public float                                    PreviousLineScale                       { get; set; }
        public int                                      WordCount                               { get; set; }
        public FontStyles                               FontStyle                               { get; set; }
        public int                                      ItalicAngle                             { get; set; }
        public float                                    FontScaleMultiplier                     { get; set; }
        public float                                    CurrentFontSize                         { get; set; }
        public float                                    BaselineOffset                          { get; set; }
        public float                                    LineOffset                              { get; set; }
        public bool                                     IsDrivenLineSpacing                     { get; set; }
        public float                                    GlyphHorizontalAdvanceAdjustment        { get; set; }
        public float                                    CSpace                                  { get; set; }
        public float                                    MSpace                                  { get; set; }
        public TMP_TextInfo?                            TextInfo                                { get; set; }
        public TMP_LineInfo                             LineInfo                                { get; set; }
        public Color32                                  VertexColor                             { get; set; }
        public Color32                                  UnderlineColor                          { get; set; }
        public Color32                                  StrikethroughColor                      { get; set; }
        public Color32                                  HighlightColor                          { get; set; }
        public TMP_FontStyleStack                       BasicStyleStack                         { get; set; }
        public int                                      SpriteAnimationID                       { get; set; }
        public TMP_FontAsset?                           CurrentFontAsset                        { get; set; }
        public TMP_SpriteAsset?                         CurrentSpriteAsset                      { get; set; }
        public Material?                                CurrentMaterial                         { get; set; }
        public int                                      CurrentMaterialIndex                    { get; set; }
        public Extents                                  MeshExtents                             { get; set; }
        public bool                                     TagNoParsing                            { get; set; }
        public bool                                     IsNonBreakingSpace                      { get; set; }

        public static WordWrapState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WordWrapState() { Pointer= p0 };

            value.Previous_WordBreak                        = GetInt32(new IntPtr(p + 0x010)); // 024660943898 0x10 Previous_WordBreak          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Total_CharacterCount                      = GetInt32(new IntPtr(p + 0x014)); // 0246609438B8 0x14 Total_CharacterCount        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Visible_CharacterCount                    = GetInt32(new IntPtr(p + 0x018)); // 0246609438D8 0x18 Visible_CharacterCount      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Visible_SpriteCount                       = GetInt32(new IntPtr(p + 0x01C)); // 0246609438F8 0x1C Visible_SpriteCount         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Visible_LinkCount                         = GetInt32(new IntPtr(p + 0x020)); // 024660943918 0x20 Visible_LinkCount           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FirstCharacterIndex                       = GetInt32(new IntPtr(p + 0x024)); // 024660943938 0x24 FirstCharacterIndex         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FirstVisibleCharacterIndex                = GetInt32(new IntPtr(p + 0x028)); // 024660943958 0x28 FirstVisibleCharacterIndex  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastCharacterIndex                        = GetInt32(new IntPtr(p + 0x02C)); // 024660943978 0x2C LastCharacterIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastVisibleCharIndex                      = GetInt32(new IntPtr(p + 0x030)); // 024660943998 0x30 LastVisibleCharIndex        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x034)); // 0246609439B8 0x34 LineNumber                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxCapHeight                              = GetSingle(new IntPtr(p + 0x038)); // 0246609439D8 0x38 MaxCapHeight                ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxAscender                               = GetSingle(new IntPtr(p + 0x03C)); // 0246609439F8 0x3C MaxAscender                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxDescender                              = GetSingle(new IntPtr(p + 0x040)); // 024660943A18 0x40 MaxDescender                ( 000186666050 ModelPrimitiveType float float float Single )
            value.StartOfLineAscender                       = GetSingle(new IntPtr(p + 0x044)); // 024660943A38 0x44 StartOfLineAscender         ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxLineAscender                           = GetSingle(new IntPtr(p + 0x048)); // 024660943A58 0x48 MaxLineAscender             ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxLineDescender                          = GetSingle(new IntPtr(p + 0x04C)); // 024660943A78 0x4C MaxLineDescender            ( 000186666050 ModelPrimitiveType float float float Single )
            value.PageAscender                              = GetSingle(new IntPtr(p + 0x050)); // 024660943A98 0x50 PageAscender                ( 000186666050 ModelPrimitiveType float float float Single )
            value.HorizontalAlignment                       = (HorizontalAlignmentOptions)GetInt32(new IntPtr(p + 0x054)); // 024660943AB8 0x54 HorizontalAlignment         ( 0001866D54B0 ModelEnumType HorizontalAlignmentOptions HorizontalAlignmentOptions HorizontalAlignmentOptions Int32 )
            value.MarginLeft                                = GetSingle(new IntPtr(p + 0x058)); // 024660943AD8 0x58 MarginLeft                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.MarginRight                               = GetSingle(new IntPtr(p + 0x05C)); // 024660943AF8 0x5C MarginRight                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.XAdvance                                  = GetSingle(new IntPtr(p + 0x060)); // 024660943B18 0x60 XAdvance                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.PreferredWidth                            = GetSingle(new IntPtr(p + 0x064)); // 024660943B38 0x64 PreferredWidth              ( 000186666050 ModelPrimitiveType float float float Single )
            value.PreferredHeight                           = GetSingle(new IntPtr(p + 0x068)); // 024660943B58 0x68 PreferredHeight             ( 000186666050 ModelPrimitiveType float float float Single )
            value.PreviousLineScale                         = GetSingle(new IntPtr(p + 0x06C)); // 024660943B78 0x6C PreviousLineScale           ( 000186666050 ModelPrimitiveType float float float Single )
            value.WordCount                                 = GetInt32(new IntPtr(p + 0x070)); // 024660943B98 0x70 WordCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FontStyle                                 = (FontStyles)GetInt32(new IntPtr(p + 0x074)); // 024660943BB8 0x74 FontStyle                   ( 0001865B2450 ModelEnumType FontStyles FontStyles FontStyles Int32 )
            value.ItalicAngle                               = GetInt32(new IntPtr(p + 0x078)); // 024660943BD8 0x78 ItalicAngle                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FontScaleMultiplier                       = GetSingle(new IntPtr(p + 0x07C)); // 024660943BF8 0x7C FontScaleMultiplier         ( 000186666050 ModelPrimitiveType float float float Single )
            value.CurrentFontSize                           = GetSingle(new IntPtr(p + 0x080)); // 024660943C18 0x80 CurrentFontSize             ( 000186666050 ModelPrimitiveType float float float Single )
            value.BaselineOffset                            = GetSingle(new IntPtr(p + 0x084)); // 024660943C38 0x84 BaselineOffset              ( 000186666050 ModelPrimitiveType float float float Single )
            value.LineOffset                                = GetSingle(new IntPtr(p + 0x088)); // 024660943C58 0x88 LineOffset                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.IsDrivenLineSpacing                       = GetBool(new IntPtr(p + 0x08C)); // 024660943C78 0x8C IsDrivenLineSpacing         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.GlyphHorizontalAdvanceAdjustment          = GetSingle(new IntPtr(p + 0x090)); // 024660943C98 0x90 GlyphHorizontalAdvanceAdjustment ( 000186666050 ModelPrimitiveType float float float Single )
            value.CSpace                                    = GetSingle(new IntPtr(p + 0x094)); // 024660943CB8 0x94 CSpace                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.MSpace                                    = GetSingle(new IntPtr(p + 0x098)); // 024660943CD8 0x98 MSpace                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.TextInfo                                  = GetObject<TMP_TextInfo>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.TMP_TextInfo.FromPointer); // 024660943CF8 0xA0 TextInfo                    ( 000186615790 ModelClassType TMP_TextInfo TMP_TextInfo TMP_TextInfo Pointer )
            value.LineInfo                                  = (TMP_LineInfo)GetInt32(new IntPtr(p + 0x0A8)); // 024660943D18 0xA8 LineInfo                    ( 00018660E740 ModelEnumType TMP_LineInfo TMP_LineInfo TMP_LineInfo Int32 )
            value.VertexColor                               = (Color32)GetInt32(new IntPtr(p + 0x104)); // 024660943D38 0x104 VertexColor                 ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.UnderlineColor                            = (Color32)GetInt32(new IntPtr(p + 0x108)); // 024660943D58 0x108 UnderlineColor              ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.StrikethroughColor                        = (Color32)GetInt32(new IntPtr(p + 0x10C)); // 024660943D78 0x10C StrikethroughColor          ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.HighlightColor                            = (Color32)GetInt32(new IntPtr(p + 0x110)); // 024660943D98 0x110 HighlightColor              ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.BasicStyleStack                           = (TMP_FontStyleStack)GetInt32(new IntPtr(p + 0x114)); // 024660943DB8 0x114 BasicStyleStack             ( 00018660C5E0 ModelEnumType TMP_FontStyleStack TMP_FontStyleStack TMP_FontStyleStack Int32 )
            value.SpriteAnimationID                         = GetInt32(new IntPtr(p + 0x350)); // 024660943FB8 0x350 SpriteAnimationID           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CurrentFontAsset                          = GetObject<TMP_FontAsset>(new IntPtr(p + 0x358), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 024660943FD8 0x358 CurrentFontAsset            ( 00018667FCE0 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.CurrentSpriteAsset                        = GetObject<TMP_SpriteAsset>(new IntPtr(p + 0x360), ReversePrism.DataModels.TMP_SpriteAsset.FromPointer); // 024660943FF8 0x360 CurrentSpriteAsset          ( 0001866808F0 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer )
            value.CurrentMaterial                           = GetObject<Material>(new IntPtr(p + 0x368), ReversePrism.DataModels.Material.FromPointer); // 024660944018 0x368 CurrentMaterial             ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.CurrentMaterialIndex                      = GetInt32(new IntPtr(p + 0x370)); // 024660944038 0x370 CurrentMaterialIndex        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MeshExtents                               = (Extents)GetInt32(new IntPtr(p + 0x374)); // 024660944058 0x374 MeshExtents                 ( 000186535DE0 ModelEnumType Extents Extents Extents Int32 )
            value.TagNoParsing                              = GetBool(new IntPtr(p + 0x384)); // 024660944078 0x384 TagNoParsing                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsNonBreakingSpace                        = GetBool(new IntPtr(p + 0x385)); // 024660944098 0x385 IsNonBreakingSpace          ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
