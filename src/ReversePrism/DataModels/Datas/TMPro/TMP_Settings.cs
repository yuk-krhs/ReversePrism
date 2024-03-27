using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               TMP_Settings IL2CPP_TYPE_CLASS
    // 018 M_enableWordWrapping                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 M_enableKerning                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01A M_enableExtraPadding                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01B M_enableTintAllSprites                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C M_enableParseEscapeCharacters            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01D M_EnableRaycastTarget                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01E M_GetFontFeaturesAtRuntime               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 M_missingGlyphCharacter                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 M_warningsDisabled                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 M_defaultFontAsset                       00018667F810 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 030 M_defaultFontAssetPath                   000186671910 ModelPrimitiveType string string string String
    // 038 M_defaultFontSize                        0001866656B0 ModelPrimitiveType float float float Single
    // 03C M_defaultAutoSizeMinRatio                0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_defaultAutoSizeMaxRatio                0001866656B0 ModelPrimitiveType float float float Single
    // 044 M_defaultTextMeshProTextContainerSize    0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 04C M_defaultTextMeshProUITextContainerSize  0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 054 M_autoSizeTextContainer                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 055 M_IsTextObjectScaleStatic                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 M_fallbackFontAssets                     000185D11BD8 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer
    // 060 M_matchMaterialPreset                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 M_defaultSpriteAsset                     000186680410 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer
    // 070 M_defaultSpriteAssetPath                 000186671910 ModelPrimitiveType string string string String
    // 078 M_enableEmojiSupport                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07C M_MissingCharacterSpriteUnicode          000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 080 M_defaultColorGradientPresetsPath        000186671910 ModelPrimitiveType string string string String
    // 088 M_defaultStyleSheet                      000186612CE0 ModelClassType TMP_StyleSheet TMP_StyleSheet TMP_StyleSheet Pointer
    // 090 M_StyleSheetsResourcePath                000186671910 ModelPrimitiveType string string string String
    // 098 M_leadingCharacters                      000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 0A0 M_followingCharacters                    000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 0A8 M_linebreakingRules                      0001865E71B0 ModelClassType LineBreakingTable LineBreakingTable LineBreakingTable Pointer
    // 0B0 M_UseModernHangulLineBreakingRules       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 008 <GetInstanceFunc>k__BackingField         Func`1<TMP_Settings> IL2CPP_TYPE_GENERICINST
    public partial class TMP_Settings
    {
        public bool                                     M_enableWordWrapping                    { get; set; }
        public bool                                     M_enableKerning                         { get; set; }
        public bool                                     M_enableExtraPadding                    { get; set; }
        public bool                                     M_enableTintAllSprites                  { get; set; }
        public bool                                     M_enableParseEscapeCharacters           { get; set; }
        public bool                                     M_EnableRaycastTarget                   { get; set; }
        public bool                                     M_GetFontFeaturesAtRuntime              { get; set; }
        public int                                      M_missingGlyphCharacter                 { get; set; }
        public bool                                     M_warningsDisabled                      { get; set; }
        public TMP_FontAsset?                           M_defaultFontAsset                      { get; set; }
        public string                                   M_defaultFontAssetPath                  { get; set; }
        public float                                    M_defaultFontSize                       { get; set; }
        public float                                    M_defaultAutoSizeMinRatio               { get; set; }
        public float                                    M_defaultAutoSizeMaxRatio               { get; set; }
        public Vector2                                  M_defaultTextMeshProTextContainerSize   { get; set; }
        public Vector2                                  M_defaultTextMeshProUITextContainerSize { get; set; }
        public bool                                     M_autoSizeTextContainer                 { get; set; }
        public bool                                     M_IsTextObjectScaleStatic               { get; set; }
        public List<TMP_FontAsset>?                     M_fallbackFontAssets                    { get; set; }
        public bool                                     M_matchMaterialPreset                   { get; set; }
        public TMP_SpriteAsset?                         M_defaultSpriteAsset                    { get; set; }
        public string                                   M_defaultSpriteAssetPath                { get; set; }
        public bool                                     M_enableEmojiSupport                    { get; set; }
        public uint                                     M_MissingCharacterSpriteUnicode         { get; set; }
        public string                                   M_defaultColorGradientPresetsPath       { get; set; }
        public TMP_StyleSheet?                          M_defaultStyleSheet                     { get; set; }
        public string                                   M_StyleSheetsResourcePath               { get; set; }
        public TextAsset?                               M_leadingCharacters                     { get; set; }
        public TextAsset?                               M_followingCharacters                   { get; set; }
        public LineBreakingTable?                       M_linebreakingRules                     { get; set; }
        public bool                                     M_UseModernHangulLineBreakingRules      { get; set; }

        public static TMP_Settings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_Settings();

            value.M_enableWordWrapping                      = GetBool(new IntPtr(p + 0x018)); // 027003E884B8 0x18 M_enableWordWrapping        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_enableKerning                           = GetBool(new IntPtr(p + 0x019)); // 027003E884D8 0x19 M_enableKerning             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_enableExtraPadding                      = GetBool(new IntPtr(p + 0x01A)); // 027003E884F8 0x1A M_enableExtraPadding        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_enableTintAllSprites                    = GetBool(new IntPtr(p + 0x01B)); // 027003E88518 0x1B M_enableTintAllSprites      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_enableParseEscapeCharacters             = GetBool(new IntPtr(p + 0x01C)); // 027003E88538 0x1C M_enableParseEscapeCharacters ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_EnableRaycastTarget                     = GetBool(new IntPtr(p + 0x01D)); // 027003E88558 0x1D M_EnableRaycastTarget       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_GetFontFeaturesAtRuntime                = GetBool(new IntPtr(p + 0x01E)); // 027003E88578 0x1E M_GetFontFeaturesAtRuntime  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_missingGlyphCharacter                   = GetInt32(new IntPtr(p + 0x020)); // 027003E88598 0x20 M_missingGlyphCharacter     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_warningsDisabled                        = GetBool(new IntPtr(p + 0x024)); // 027003E885B8 0x24 M_warningsDisabled          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_defaultFontAsset                        = GetObject<TMP_FontAsset>(new IntPtr(p + 0x028), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 027003E885D8 0x28 M_defaultFontAsset          ( 00018667F810 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.M_defaultFontAssetPath                    = GetString(new IntPtr(p + 0x030)); // 027003E885F8 0x30 M_defaultFontAssetPath      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_defaultFontSize                         = GetSingle(new IntPtr(p + 0x038)); // 027003E88618 0x38 M_defaultFontSize           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_defaultAutoSizeMinRatio                 = GetSingle(new IntPtr(p + 0x03C)); // 027003E88638 0x3C M_defaultAutoSizeMinRatio   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_defaultAutoSizeMaxRatio                 = GetSingle(new IntPtr(p + 0x040)); // 027003E88658 0x40 M_defaultAutoSizeMaxRatio   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_defaultTextMeshProTextContainerSize     = (Vector2)GetInt32(new IntPtr(p + 0x044)); // 027003E88678 0x44 M_defaultTextMeshProTextContainerSize ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_defaultTextMeshProUITextContainerSize   = (Vector2)GetInt32(new IntPtr(p + 0x04C)); // 027003E88698 0x4C M_defaultTextMeshProUITextContainerSize ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_autoSizeTextContainer                   = GetBool(new IntPtr(p + 0x054)); // 027003E886B8 0x54 M_autoSizeTextContainer     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsTextObjectScaleStatic                 = GetBool(new IntPtr(p + 0x055)); // 027003E886D8 0x55 M_IsTextObjectScaleStatic   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_fallbackFontAssets                      = GetObjectList<TMP_FontAsset>(new IntPtr(p + 0x058), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 027003E886F8 0x58 M_fallbackFontAssets        ( 000185D11BD8 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer )
            value.M_matchMaterialPreset                     = GetBool(new IntPtr(p + 0x060)); // 027003E88718 0x60 M_matchMaterialPreset       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_defaultSpriteAsset                      = GetObject<TMP_SpriteAsset>(new IntPtr(p + 0x068), ReversePrism.DataModels.TMP_SpriteAsset.FromPointer); // 027003E88738 0x68 M_defaultSpriteAsset        ( 000186680410 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer )
            value.M_defaultSpriteAssetPath                  = GetString(new IntPtr(p + 0x070)); // 027003E88758 0x70 M_defaultSpriteAssetPath    ( 000186671910 ModelPrimitiveType string string string String )
            value.M_enableEmojiSupport                      = GetBool(new IntPtr(p + 0x078)); // 027003E88778 0x78 M_enableEmojiSupport        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MissingCharacterSpriteUnicode           = GetUInt32(new IntPtr(p + 0x07C)); // 027003E88798 0x7C M_MissingCharacterSpriteUnicode ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_defaultColorGradientPresetsPath         = GetString(new IntPtr(p + 0x080)); // 027003E887B8 0x80 M_defaultColorGradientPresetsPath ( 000186671910 ModelPrimitiveType string string string String )
            value.M_defaultStyleSheet                       = GetObject<TMP_StyleSheet>(new IntPtr(p + 0x088), ReversePrism.DataModels.TMP_StyleSheet.FromPointer); // 027003E887D8 0x88 M_defaultStyleSheet         ( 000186612CE0 ModelClassType TMP_StyleSheet TMP_StyleSheet TMP_StyleSheet Pointer )
            value.M_StyleSheetsResourcePath                 = GetString(new IntPtr(p + 0x090)); // 027003E887F8 0x90 M_StyleSheetsResourcePath   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_leadingCharacters                       = GetObject<TextAsset>(new IntPtr(p + 0x098), ReversePrism.DataModels.TextAsset.FromPointer); // 027003E88818 0x98 M_leadingCharacters         ( 000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.M_followingCharacters                     = GetObject<TextAsset>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.TextAsset.FromPointer); // 027003E88838 0xA0 M_followingCharacters       ( 000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.M_linebreakingRules                       = GetObject<LineBreakingTable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.LineBreakingTable.FromPointer); // 027003E88858 0xA8 M_linebreakingRules         ( 0001865E71B0 ModelClassType LineBreakingTable LineBreakingTable LineBreakingTable Pointer )
            value.M_UseModernHangulLineBreakingRules        = GetBool(new IntPtr(p + 0x0B0)); // 027003E88878 0xB0 M_UseModernHangulLineBreakingRules ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
