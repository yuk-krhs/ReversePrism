using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PreviousWordBreak                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 TotalCharacterCount                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 VisibleCharacterCount                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C VisibleSpaceCount                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 VisibleSpriteCount                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 VisibleLinkCount                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 FirstCharacterIndex                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C FirstVisibleCharacterIndex               0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 LastCharacterIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 LastVisibleCharIndex                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 LineNumber                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C MaxCapHeight                             000186666050 ModelPrimitiveType float float float Single
    // 040 MaxAscender                              000186666050 ModelPrimitiveType float float float Single
    // 044 MaxDescender                             000186666050 ModelPrimitiveType float float float Single
    // 048 MaxLineAscender                          000186666050 ModelPrimitiveType float float float Single
    // 04C MaxLineDescender                         000186666050 ModelPrimitiveType float float float Single
    // 050 StartOfLineAscender                      000186666050 ModelPrimitiveType float float float Single
    // 054 XAdvance                                 000186666050 ModelPrimitiveType float float float Single
    // 058 PreferredWidth                           000186666050 ModelPrimitiveType float float float Single
    // 05C PreferredHeight                          000186666050 ModelPrimitiveType float float float Single
    // 060 PreviousLineScale                        000186666050 ModelPrimitiveType float float float Single
    // 064 PageAscender                             000186666050 ModelPrimitiveType float float float Single
    // 068 WordCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 06C FontStyle                                0001865B2E00 ModelEnumType FontStyles FontStyles FontStyles Int32
    // 070 FontScale                                000186666050 ModelPrimitiveType float float float Single
    // 074 FontScaleMultiplier                      000186666050 ModelPrimitiveType float float float Single
    // 078 ItalicAngle                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 07C CurrentFontSize                          000186666050 ModelPrimitiveType float float float Single
    // 080 BaselineOffset                           000186666050 ModelPrimitiveType float float float Single
    // 084 LineOffset                               000186666050 ModelPrimitiveType float float float Single
    // 088 TextInfo                                 00018663E700 ModelClassType TextInfo TextInfo TextInfo Pointer
    // 090 LineInfo                                 00018652F200 ModelEnumType LineInfo LineInfo LineInfo Int32
    // 0F0 VertexColor                              0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 0F4 UnderlineColor                           0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 0F8 StrikethroughColor                       0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 0FC HighlightColor                           0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 100 HighlightState                           0001866B7B60 ModelEnumType HighlightState HighlightState HighlightState Int32
    // 114 BasicStyleStack                          0001865B1CE0 ModelEnumType FontStyleStack FontStyleStack FontStyleStack Int32
    // 120 italicAngleStack                         TextProcessingStack`1<int> IL2CPP_TYPE_GENERICINST
    // 140 colorStack                               TextProcessingStack`1<Color32> IL2CPP_TYPE_GENERICINST
    // 160 underlineColorStack                      TextProcessingStack`1<Color32> IL2CPP_TYPE_GENERICINST
    // 180 strikethroughColorStack                  TextProcessingStack`1<Color32> IL2CPP_TYPE_GENERICINST
    // 1A0 highlightColorStack                      TextProcessingStack`1<Color32> IL2CPP_TYPE_GENERICINST
    // 1C0 highlightStateStack                      TextProcessingStack`1<HighlightState> IL2CPP_TYPE_GENERICINST
    // 1F0 colorGradientStack                       TextProcessingStack`1<TextColorGradient> IL2CPP_TYPE_GENERICINST
    // 218 sizeStack                                TextProcessingStack`1<float> IL2CPP_TYPE_GENERICINST
    // 238 indentStack                              TextProcessingStack`1<float> IL2CPP_TYPE_GENERICINST
    // 258 fontWeightStack                          TextProcessingStack`1<TextFontWeight> IL2CPP_TYPE_GENERICINST
    // 278 styleStack                               TextProcessingStack`1<int> IL2CPP_TYPE_GENERICINST
    // 298 baselineStack                            TextProcessingStack`1<float> IL2CPP_TYPE_GENERICINST
    // 2B8 actionStack                              TextProcessingStack`1<int> IL2CPP_TYPE_GENERICINST
    // 2D8 materialReferenceStack                   TextProcessingStack`1<MaterialReference> IL2CPP_TYPE_GENERICINST
    // 330 lineJustificationStack                   TextProcessingStack`1<TextAlignment> IL2CPP_TYPE_GENERICINST
    // 350 LastBaseGlyphIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 354 SpriteAnimationId                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 358 CurrentFontAsset                         0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer
    // 360 CurrentSpriteAsset                       00018666CC70 ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer
    // 368 CurrentMaterial                          00018660C4B0 ModelClassType Material Material Material Pointer
    // 370 CurrentMaterialIndex                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 374 MeshExtents                              0001865367D0 ModelEnumType Extents Extents Extents Int32
    // 384 TagNoParsing                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 385 IsNonBreakingSpace                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 386 IsDrivenLineSpacing                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 388 FxScale                                  0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 394 FxRotation                               00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class WordWrapState
    {
        public int                                      PreviousWordBreak                       { get; set; }
        public int                                      TotalCharacterCount                     { get; set; }
        public int                                      VisibleCharacterCount                   { get; set; }
        public int                                      VisibleSpaceCount                       { get; set; }
        public int                                      VisibleSpriteCount                      { get; set; }
        public int                                      VisibleLinkCount                        { get; set; }
        public int                                      FirstCharacterIndex                     { get; set; }
        public int                                      FirstVisibleCharacterIndex              { get; set; }
        public int                                      LastCharacterIndex                      { get; set; }
        public int                                      LastVisibleCharIndex                    { get; set; }
        public int                                      LineNumber                              { get; set; }
        public float                                    MaxCapHeight                            { get; set; }
        public float                                    MaxAscender                             { get; set; }
        public float                                    MaxDescender                            { get; set; }
        public float                                    MaxLineAscender                         { get; set; }
        public float                                    MaxLineDescender                        { get; set; }
        public float                                    StartOfLineAscender                     { get; set; }
        public float                                    XAdvance                                { get; set; }
        public float                                    PreferredWidth                          { get; set; }
        public float                                    PreferredHeight                         { get; set; }
        public float                                    PreviousLineScale                       { get; set; }
        public float                                    PageAscender                            { get; set; }
        public int                                      WordCount                               { get; set; }
        public FontStyles                               FontStyle                               { get; set; }
        public float                                    FontScale                               { get; set; }
        public float                                    FontScaleMultiplier                     { get; set; }
        public int                                      ItalicAngle                             { get; set; }
        public float                                    CurrentFontSize                         { get; set; }
        public float                                    BaselineOffset                          { get; set; }
        public float                                    LineOffset                              { get; set; }
        public TextInfo?                                TextInfo                                { get; set; }
        public LineInfo                                 LineInfo                                { get; set; }
        public Color32                                  VertexColor                             { get; set; }
        public Color32                                  UnderlineColor                          { get; set; }
        public Color32                                  StrikethroughColor                      { get; set; }
        public Color32                                  HighlightColor                          { get; set; }
        public HighlightState                           HighlightState                          { get; set; }
        public FontStyleStack                           BasicStyleStack                         { get; set; }
        public int                                      LastBaseGlyphIndex                      { get; set; }
        public int                                      SpriteAnimationId                       { get; set; }
        public FontAsset?                               CurrentFontAsset                        { get; set; }
        public SpriteAsset?                             CurrentSpriteAsset                      { get; set; }
        public Material?                                CurrentMaterial                         { get; set; }
        public int                                      CurrentMaterialIndex                    { get; set; }
        public Extents                                  MeshExtents                             { get; set; }
        public bool                                     TagNoParsing                            { get; set; }
        public bool                                     IsNonBreakingSpace                      { get; set; }
        public bool                                     IsDrivenLineSpacing                     { get; set; }
        public Vector3                                  FxScale                                 { get; set; }
        public Quaternion                               FxRotation                              { get; set; }

        public static WordWrapState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WordWrapState();

            value.PreviousWordBreak                         = GetInt32(new IntPtr(p + 0x010)); // 0270068EFF30 0x10 PreviousWordBreak           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TotalCharacterCount                       = GetInt32(new IntPtr(p + 0x014)); // 0270068EFF50 0x14 TotalCharacterCount         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VisibleCharacterCount                     = GetInt32(new IntPtr(p + 0x018)); // 0270068EFF70 0x18 VisibleCharacterCount       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VisibleSpaceCount                         = GetInt32(new IntPtr(p + 0x01C)); // 0270068EFF90 0x1C VisibleSpaceCount           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VisibleSpriteCount                        = GetInt32(new IntPtr(p + 0x020)); // 0270068EFFB0 0x20 VisibleSpriteCount          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VisibleLinkCount                          = GetInt32(new IntPtr(p + 0x024)); // 0270068EFFD0 0x24 VisibleLinkCount            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FirstCharacterIndex                       = GetInt32(new IntPtr(p + 0x028)); // 0270068EFFF0 0x28 FirstCharacterIndex         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FirstVisibleCharacterIndex                = GetInt32(new IntPtr(p + 0x02C)); // 0270068F0010 0x2C FirstVisibleCharacterIndex  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastCharacterIndex                        = GetInt32(new IntPtr(p + 0x030)); // 0270068F0030 0x30 LastCharacterIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastVisibleCharIndex                      = GetInt32(new IntPtr(p + 0x034)); // 0270068F0050 0x34 LastVisibleCharIndex        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x038)); // 0270068F0070 0x38 LineNumber                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxCapHeight                              = GetSingle(new IntPtr(p + 0x03C)); // 0270068F0090 0x3C MaxCapHeight                ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxAscender                               = GetSingle(new IntPtr(p + 0x040)); // 0270068F00B0 0x40 MaxAscender                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxDescender                              = GetSingle(new IntPtr(p + 0x044)); // 0270068F00D0 0x44 MaxDescender                ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxLineAscender                           = GetSingle(new IntPtr(p + 0x048)); // 0270068F00F0 0x48 MaxLineAscender             ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxLineDescender                          = GetSingle(new IntPtr(p + 0x04C)); // 0270068F0110 0x4C MaxLineDescender            ( 000186666050 ModelPrimitiveType float float float Single )
            value.StartOfLineAscender                       = GetSingle(new IntPtr(p + 0x050)); // 0270068F0130 0x50 StartOfLineAscender         ( 000186666050 ModelPrimitiveType float float float Single )
            value.XAdvance                                  = GetSingle(new IntPtr(p + 0x054)); // 0270068F0150 0x54 XAdvance                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.PreferredWidth                            = GetSingle(new IntPtr(p + 0x058)); // 0270068F0170 0x58 PreferredWidth              ( 000186666050 ModelPrimitiveType float float float Single )
            value.PreferredHeight                           = GetSingle(new IntPtr(p + 0x05C)); // 0270068F0190 0x5C PreferredHeight             ( 000186666050 ModelPrimitiveType float float float Single )
            value.PreviousLineScale                         = GetSingle(new IntPtr(p + 0x060)); // 0270068F01B0 0x60 PreviousLineScale           ( 000186666050 ModelPrimitiveType float float float Single )
            value.PageAscender                              = GetSingle(new IntPtr(p + 0x064)); // 0270068F01D0 0x64 PageAscender                ( 000186666050 ModelPrimitiveType float float float Single )
            value.WordCount                                 = GetInt32(new IntPtr(p + 0x068)); // 0270068F01F0 0x68 WordCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FontStyle                                 = (FontStyles)GetInt32(new IntPtr(p + 0x06C)); // 0270068F0210 0x6C FontStyle                   ( 0001865B2E00 ModelEnumType FontStyles FontStyles FontStyles Int32 )
            value.FontScale                                 = GetSingle(new IntPtr(p + 0x070)); // 0270068F0230 0x70 FontScale                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.FontScaleMultiplier                       = GetSingle(new IntPtr(p + 0x074)); // 0270068F0250 0x74 FontScaleMultiplier         ( 000186666050 ModelPrimitiveType float float float Single )
            value.ItalicAngle                               = GetInt32(new IntPtr(p + 0x078)); // 0270068F0270 0x78 ItalicAngle                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CurrentFontSize                           = GetSingle(new IntPtr(p + 0x07C)); // 0270068F0290 0x7C CurrentFontSize             ( 000186666050 ModelPrimitiveType float float float Single )
            value.BaselineOffset                            = GetSingle(new IntPtr(p + 0x080)); // 0270068F02B0 0x80 BaselineOffset              ( 000186666050 ModelPrimitiveType float float float Single )
            value.LineOffset                                = GetSingle(new IntPtr(p + 0x084)); // 0270068F02D0 0x84 LineOffset                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.TextInfo                                  = GetObject<TextInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.TextInfo.FromPointer); // 0270068F02F0 0x88 TextInfo                    ( 00018663E700 ModelClassType TextInfo TextInfo TextInfo Pointer )
            value.LineInfo                                  = (LineInfo)GetInt32(new IntPtr(p + 0x090)); // 0270068F0310 0x90 LineInfo                    ( 00018652F200 ModelEnumType LineInfo LineInfo LineInfo Int32 )
            value.VertexColor                               = (Color32)GetInt32(new IntPtr(p + 0x0F0)); // 0270068F0330 0xF0 VertexColor                 ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.UnderlineColor                            = (Color32)GetInt32(new IntPtr(p + 0x0F4)); // 0270068F0350 0xF4 UnderlineColor              ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.StrikethroughColor                        = (Color32)GetInt32(new IntPtr(p + 0x0F8)); // 0270068F0370 0xF8 StrikethroughColor          ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.HighlightColor                            = (Color32)GetInt32(new IntPtr(p + 0x0FC)); // 0270068F0390 0xFC HighlightColor              ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.HighlightState                            = (HighlightState)GetInt32(new IntPtr(p + 0x100)); // 0270068F03B0 0x100 HighlightState              ( 0001866B7B60 ModelEnumType HighlightState HighlightState HighlightState Int32 )
            value.BasicStyleStack                           = (FontStyleStack)GetInt32(new IntPtr(p + 0x114)); // 0270068F03D0 0x114 BasicStyleStack             ( 0001865B1CE0 ModelEnumType FontStyleStack FontStyleStack FontStyleStack Int32 )
            value.LastBaseGlyphIndex                        = GetInt32(new IntPtr(p + 0x350)); // 0270068F05D0 0x350 LastBaseGlyphIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SpriteAnimationId                         = GetInt32(new IntPtr(p + 0x354)); // 0270068F05F0 0x354 SpriteAnimationId           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CurrentFontAsset                          = GetObject<FontAsset>(new IntPtr(p + 0x358), ReversePrism.DataModels.FontAsset.FromPointer); // 0270068F0610 0x358 CurrentFontAsset            ( 0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer )
            value.CurrentSpriteAsset                        = GetObject<SpriteAsset>(new IntPtr(p + 0x360), ReversePrism.DataModels.SpriteAsset.FromPointer); // 0270068F0630 0x360 CurrentSpriteAsset          ( 00018666CC70 ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer )
            value.CurrentMaterial                           = GetObject<Material>(new IntPtr(p + 0x368), ReversePrism.DataModels.Material.FromPointer); // 0270068F0650 0x368 CurrentMaterial             ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.CurrentMaterialIndex                      = GetInt32(new IntPtr(p + 0x370)); // 0270068F0670 0x370 CurrentMaterialIndex        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MeshExtents                               = (Extents)GetInt32(new IntPtr(p + 0x374)); // 0270068F0690 0x374 MeshExtents                 ( 0001865367D0 ModelEnumType Extents Extents Extents Int32 )
            value.TagNoParsing                              = GetBool(new IntPtr(p + 0x384)); // 0270068F06B0 0x384 TagNoParsing                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsNonBreakingSpace                        = GetBool(new IntPtr(p + 0x385)); // 0270068F06D0 0x385 IsNonBreakingSpace          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsDrivenLineSpacing                       = GetBool(new IntPtr(p + 0x386)); // 0270068F06F0 0x386 IsDrivenLineSpacing         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FxScale                                   = (Vector3)GetInt32(new IntPtr(p + 0x388)); // 0270068F0710 0x388 FxScale                     ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.FxRotation                                = (Quaternion)GetInt32(new IntPtr(p + 0x394)); // 0270068F0730 0x394 FxRotation                  ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
