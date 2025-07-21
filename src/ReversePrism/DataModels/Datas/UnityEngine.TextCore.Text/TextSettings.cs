using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Version                                ModelPrimitiveType string string string String
    // 020 M_DefaultFontAsset                       ModelClassType FontAsset FontAsset FontAsset Pointer
    // 028 M_DefaultFontAssetPath                   ModelPrimitiveType string string string String
    // 030 M_FallbackFontAssets                     ModelClassListType List`1<FontAsset> List`1<FontAsset> List<FontAsset> Pointer
    // 038 M_MatchMaterialPreset                    ModelPrimitiveType bool bool bool Bool
    // 03C M_MissingCharacterUnicode                ModelPrimitiveType int int int Int32
    // 040 M_ClearDynamicDataOnBuild                ModelPrimitiveType bool bool bool Bool
    // 048 M_DefaultSpriteAsset                     ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer
    // 050 M_DefaultSpriteAssetPath                 ModelPrimitiveType string string string String
    // 058 M_FallbackSpriteAssets                   ModelClassListType List`1<SpriteAsset> List`1<SpriteAsset> List<SpriteAsset> Pointer
    // 060 M_MissingSpriteCharacterUnicode          ModelPrimitiveType uint uint uint UInt32
    // 068 M_DefaultStyleSheet                      ModelClassType TextStyleSheet TextStyleSheet TextStyleSheet Pointer
    // 070 M_StyleSheetsResourcePath                ModelPrimitiveType string string string String
    // 078 M_DefaultColorGradientPresetsPath        ModelPrimitiveType string string string String
    // 080 M_UnicodeLineBreakingRules               ModelClassType UnicodeLineBreakingRules UnicodeLineBreakingRules UnicodeLineBreakingRules Pointer
    // 088 M_UseModernHangulLineBreakingRules       ModelPrimitiveType bool bool bool Bool
    // 089 M_DisplayWarnings                        ModelPrimitiveType bool bool bool Bool
    // 090 m_FontLookup                             Dictionary`2<int, FontAsset> IL2CPP_TYPE_GENERICINST
    // 098 M_FontReferences                         ModelEnumListType List`1<FontReferenceMap> List`1<FontReferenceMap> List<FontReferenceMap> Pointer
    public partial class TextSettings : DataModel
    {
        public string                                   M_Version                               { get; set; }
        public FontAsset?                               M_DefaultFontAsset                      { get; set; }
        public string                                   M_DefaultFontAssetPath                  { get; set; }
        public List<FontAsset>?                         M_FallbackFontAssets                    { get; set; }
        public bool                                     M_MatchMaterialPreset                   { get; set; }
        public int                                      M_MissingCharacterUnicode               { get; set; }
        public bool                                     M_ClearDynamicDataOnBuild               { get; set; }
        public SpriteAsset?                             M_DefaultSpriteAsset                    { get; set; }
        public string                                   M_DefaultSpriteAssetPath                { get; set; }
        public List<SpriteAsset>?                       M_FallbackSpriteAssets                  { get; set; }
        public uint                                     M_MissingSpriteCharacterUnicode         { get; set; }
        public TextStyleSheet?                          M_DefaultStyleSheet                     { get; set; }
        public string                                   M_StyleSheetsResourcePath               { get; set; }
        public string                                   M_DefaultColorGradientPresetsPath       { get; set; }
        public UnicodeLineBreakingRules?                M_UnicodeLineBreakingRules              { get; set; }
        public bool                                     M_UseModernHangulLineBreakingRules      { get; set; }
        public bool                                     M_DisplayWarnings                       { get; set; }
        public List<FontReferenceMap>?                  M_FontReferences                        { get; set; }

        public static TextSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextSettings() { Pointer= p0 };

            value.M_Version                                 = GetString(new IntPtr(p + 0x018)); // 0x18 M_Version                   ( ModelPrimitiveType string string string String )
            value.M_DefaultFontAsset                        = GetObject<FontAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.FontAsset.FromPointer); // 0x20 M_DefaultFontAsset          ( ModelClassType FontAsset FontAsset FontAsset Pointer )
            value.M_DefaultFontAssetPath                    = GetString(new IntPtr(p + 0x028)); // 0x28 M_DefaultFontAssetPath      ( ModelPrimitiveType string string string String )
            value.M_FallbackFontAssets                      = GetObjectList<FontAsset>(new IntPtr(p + 0x030), ReversePrism.DataModels.FontAsset.FromPointer); // 0x30 M_FallbackFontAssets        ( ModelClassListType List`1<FontAsset> List`1<FontAsset> List<FontAsset> Pointer )
            value.M_MatchMaterialPreset                     = GetBool(new IntPtr(p + 0x038)); // 0x38 M_MatchMaterialPreset       ( ModelPrimitiveType bool bool bool Bool )
            value.M_MissingCharacterUnicode                 = GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_MissingCharacterUnicode   ( ModelPrimitiveType int int int Int32 )
            value.M_ClearDynamicDataOnBuild                 = GetBool(new IntPtr(p + 0x040)); // 0x40 M_ClearDynamicDataOnBuild   ( ModelPrimitiveType bool bool bool Bool )
            value.M_DefaultSpriteAsset                      = GetObject<SpriteAsset>(new IntPtr(p + 0x048), ReversePrism.DataModels.SpriteAsset.FromPointer); // 0x48 M_DefaultSpriteAsset        ( ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer )
            value.M_DefaultSpriteAssetPath                  = GetString(new IntPtr(p + 0x050)); // 0x50 M_DefaultSpriteAssetPath    ( ModelPrimitiveType string string string String )
            value.M_FallbackSpriteAssets                    = GetObjectList<SpriteAsset>(new IntPtr(p + 0x058), ReversePrism.DataModels.SpriteAsset.FromPointer); // 0x58 M_FallbackSpriteAssets      ( ModelClassListType List`1<SpriteAsset> List`1<SpriteAsset> List<SpriteAsset> Pointer )
            value.M_MissingSpriteCharacterUnicode           = GetUInt32(new IntPtr(p + 0x060)); // 0x60 M_MissingSpriteCharacterUnicode ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_DefaultStyleSheet                       = GetObject<TextStyleSheet>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextStyleSheet.FromPointer); // 0x68 M_DefaultStyleSheet         ( ModelClassType TextStyleSheet TextStyleSheet TextStyleSheet Pointer )
            value.M_StyleSheetsResourcePath                 = GetString(new IntPtr(p + 0x070)); // 0x70 M_StyleSheetsResourcePath   ( ModelPrimitiveType string string string String )
            value.M_DefaultColorGradientPresetsPath         = GetString(new IntPtr(p + 0x078)); // 0x78 M_DefaultColorGradientPresetsPath ( ModelPrimitiveType string string string String )
            value.M_UnicodeLineBreakingRules                = GetObject<UnicodeLineBreakingRules>(new IntPtr(p + 0x080), ReversePrism.DataModels.UnicodeLineBreakingRules.FromPointer); // 0x80 M_UnicodeLineBreakingRules  ( ModelClassType UnicodeLineBreakingRules UnicodeLineBreakingRules UnicodeLineBreakingRules Pointer )
            value.M_UseModernHangulLineBreakingRules        = GetBool(new IntPtr(p + 0x088)); // 0x88 M_UseModernHangulLineBreakingRules ( ModelPrimitiveType bool bool bool Bool )
            value.M_DisplayWarnings                         = GetBool(new IntPtr(p + 0x089)); // 0x89 M_DisplayWarnings           ( ModelPrimitiveType bool bool bool Bool )
            value.M_FontReferences                          = GetEnumList<FontReferenceMap>(new IntPtr(p + 0x098)); // 0x98 M_FontReferences            ( ModelEnumListType List`1<FontReferenceMap> List`1<FontReferenceMap> List<FontReferenceMap> Pointer )

            return value;
        }
    }
}
