using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_Version                                000186671910 ModelPrimitiveType string string string String
    // 038 M_SourceFontFileGUID                     000186671BA0 ModelPrimitiveType string string string String
    // 040 M_SourceFontFile                         0001865AD0A0 ModelClassType Font Font Font Pointer
    // 048 M_AtlasPopulationMode                    00018670C6E0 ModelEnumType AtlasPopulationMode AtlasPopulationMode AtlasPopulationMode Int32
    // 050 M_FaceInfo                               0001865D05C0 ModelEnumType FaceInfo FaceInfo FaceInfo Int32
    // 0B0 M_GlyphTable                             000185CDEB28 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 0B8 m_GlyphLookupDictionary                  Dictionary`2<uint, Glyph> IL2CPP_TYPE_GENERICINST
    // 0C0 M_CharacterTable                         000185D117B8 ModelClassListType List`1<TMP_Character> List`1<TMP_Character> List<TMP_Character> Pointer
    // 0C8 m_CharacterLookupDictionary              Dictionary`2<uint, TMP_Character> IL2CPP_TYPE_GENERICINST
    // 0D0 M_AtlasTexture                           000186685CB0 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 0D8 M_AtlasTextures                          000185CAB2C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 0E0 M_AtlasTextureIndex                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 0E4 M_IsMultiAtlasTexturesEnabled            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E5 M_ClearDynamicDataOnBuild                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E8 M_UsedGlyphRects                         000185CDF008 ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer
    // 0F0 M_FreeGlyphRects                         000185CDF008 ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer
    // 0F8 M_fontInfo                               00018654EEB0 ModelClassType FaceInfo_Legacy FaceInfo_Legacy FaceInfo_Legacy Pointer
    // 100 Atlas                                    000186685F20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 108 M_AtlasWidth                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 10C M_AtlasHeight                            0001865F2F90 ModelPrimitiveType int int int Int32
    // 110 M_AtlasPadding                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 114 M_AtlasRenderMode                        000186682B30 ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32
    // 118 M_glyphInfoList                          000185D11F28 ModelClassListType List`1<TMP_Glyph> List`1<TMP_Glyph> List<TMP_Glyph> Pointer
    // 120 M_KerningTable                           00018676C400 ModelClassType KerningTable KerningTable KerningTable Pointer
    // 128 M_FontFeatureTable                       00018660BED0 ModelClassType TMP_FontFeatureTable TMP_FontFeatureTable TMP_FontFeatureTable Pointer
    // 130 FallbackFontAssets                       000185D11BD8 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer
    // 138 M_FallbackFontAssetTable                 000185D11C48 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer
    // 140 M_CreationSettings                       0001865ADCE0 ModelEnumType FontAssetCreationSettings FontAssetCreationSettings FontAssetCreationSettings Int32
    // 198 M_FontWeightTable                        000185CA9008 ModelEnumListType TMP_FontWeightPair[] TMP_FontWeightPair[] List<TMP_FontWeightPair> Pointer
    // 1A0 FontWeights                              000185CA9008 ModelEnumListType TMP_FontWeightPair[] TMP_FontWeightPair[] List<TMP_FontWeightPair> Pointer
    // 1A8 NormalStyle                              000186666050 ModelPrimitiveType float float float Single
    // 1AC NormalSpacingOffset                      000186666050 ModelPrimitiveType float float float Single
    // 1B0 BoldStyle                                000186666050 ModelPrimitiveType float float float Single
    // 1B4 BoldSpacing                              000186666050 ModelPrimitiveType float float float Single
    // 1B8 ItalicStyle                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1B9 TabSize                                  00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1BA IsFontAssetLookupTablesDirty             000186595210 ModelPrimitiveType bool bool bool Bool
    // 000 k_ReadFontAssetDefinitionMarker          ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 k_AddSynthesizedCharactersMarker         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 K_TryAddCharacterMarker                  0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 K_TryAddCharactersMarker                 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 K_UpdateGlyphAdjustmentRecordsMarker     0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 028 K_ClearFontAssetDataMarker               0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 030 K_UpdateFontAssetDataMarker              0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 038 S_DefaultMaterialSuffix                  000186672530 ModelPrimitiveType string string string String
    // 1C0 FallbackSearchQueryLookup                HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 040 k_SearchedFontAssetLookup                HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 048 K_FontAssets_FontFeaturesUpdateQueue     000185D11CE8 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer
    // 050 k_FontAssets_FontFeaturesUpdateQueueLookup HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 058 K_FontAssets_AtlasTexturesUpdateQueue    000185D11CE8 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer
    // 060 k_FontAssets_AtlasTexturesUpdateQueueLookup HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 1C8 M_GlyphsToRender                         000185CDEAC8 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 1D0 M_GlyphsRendered                         000185CDEAC8 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 1D8 M_GlyphIndexList                         000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1E0 M_GlyphIndexListNewlyAdded               000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1E8 M_GlyphsToAdd                            000185D19258 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1F0 m_GlyphsToAddLookup                      HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 1F8 M_CharactersToAdd                        000185D117B8 ModelClassListType List`1<TMP_Character> List`1<TMP_Character> List<TMP_Character> Pointer
    // 200 m_CharactersToAddLookup                  HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 208 S_MissingCharacterList                   000185D19258 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 210 m_MissingUnicodesFromFontFile            HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 068 K_GlyphIndexArray                        000185B83B30 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class TMP_FontAsset
    {
        public string                                   M_Version                               { get; set; }
        public string                                   M_SourceFontFileGUID                    { get; set; }
        public Font?                                    M_SourceFontFile                        { get; set; }
        public AtlasPopulationMode                      M_AtlasPopulationMode                   { get; set; }
        public FaceInfo                                 M_FaceInfo                              { get; set; }
        public List<Glyph>?                             M_GlyphTable                            { get; set; }
        public List<TMP_Character>?                     M_CharacterTable                        { get; set; }
        public Texture2D?                               M_AtlasTexture                          { get; set; }
        public List<Texture2D>?                         M_AtlasTextures                         { get; set; }
        public int                                      M_AtlasTextureIndex                     { get; set; }
        public bool                                     M_IsMultiAtlasTexturesEnabled           { get; set; }
        public bool                                     M_ClearDynamicDataOnBuild               { get; set; }
        public List<GlyphRect>?                         M_UsedGlyphRects                        { get; set; }
        public List<GlyphRect>?                         M_FreeGlyphRects                        { get; set; }
        public FaceInfo_Legacy?                         M_fontInfo                              { get; set; }
        public Texture2D?                               Atlas                                   { get; set; }
        public int                                      M_AtlasWidth                            { get; set; }
        public int                                      M_AtlasHeight                           { get; set; }
        public int                                      M_AtlasPadding                          { get; set; }
        public GlyphRenderMode                          M_AtlasRenderMode                       { get; set; }
        public List<TMP_Glyph>?                         M_glyphInfoList                         { get; set; }
        public KerningTable?                            M_KerningTable                          { get; set; }
        public TMP_FontFeatureTable?                    M_FontFeatureTable                      { get; set; }
        public List<TMP_FontAsset>?                     FallbackFontAssets                      { get; set; }
        public List<TMP_FontAsset>?                     M_FallbackFontAssetTable                { get; set; }
        public FontAssetCreationSettings                M_CreationSettings                      { get; set; }
        public List<TMP_FontWeightPair>?                M_FontWeightTable                       { get; set; }
        public List<TMP_FontWeightPair>?                FontWeights                             { get; set; }
        public float                                    NormalStyle                             { get; set; }
        public float                                    NormalSpacingOffset                     { get; set; }
        public float                                    BoldStyle                               { get; set; }
        public float                                    BoldSpacing                             { get; set; }
        public sbyte                                    ItalicStyle                             { get; set; }
        public sbyte                                    TabSize                                 { get; set; }
        public bool                                     IsFontAssetLookupTablesDirty            { get; set; }
        public ProfilerMarker                           K_TryAddCharacterMarker                 { get; set; }
        public ProfilerMarker                           K_TryAddCharactersMarker                { get; set; }
        public ProfilerMarker                           K_UpdateGlyphAdjustmentRecordsMarker    { get; set; }
        public ProfilerMarker                           K_ClearFontAssetDataMarker              { get; set; }
        public ProfilerMarker                           K_UpdateFontAssetDataMarker             { get; set; }
        public string                                   S_DefaultMaterialSuffix                 { get; set; }
        public List<TMP_FontAsset>?                     K_FontAssets_FontFeaturesUpdateQueue    { get; set; }
        public List<TMP_FontAsset>?                     K_FontAssets_AtlasTexturesUpdateQueue   { get; set; }
        public List<Glyph>?                             M_GlyphsToRender                        { get; set; }
        public List<Glyph>?                             M_GlyphsRendered                        { get; set; }
        public List<uint>?                              M_GlyphIndexList                        { get; set; }
        public List<uint>?                              M_GlyphIndexListNewlyAdded              { get; set; }
        public List<uint>?                              M_GlyphsToAdd                           { get; set; }
        public List<TMP_Character>?                     M_CharactersToAdd                       { get; set; }
        public List<uint>?                              S_MissingCharacterList                  { get; set; }
        public List<uint>?                              K_GlyphIndexArray                       { get; set; }

        public static TMP_FontAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_FontAsset();

            value.M_Version                                 = GetString(new IntPtr(p + 0x030)); // 0270D098E5D8 0x30 M_Version                   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_SourceFontFileGUID                      = GetString(new IntPtr(p + 0x038)); // 0270D098E5F8 0x38 M_SourceFontFileGUID        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_SourceFontFile                          = GetObject<Font>(new IntPtr(p + 0x040), ReversePrism.DataModels.Font.FromPointer); // 0270D098E618 0x40 M_SourceFontFile            ( 0001865AD0A0 ModelClassType Font Font Font Pointer )
            value.M_AtlasPopulationMode                     = (AtlasPopulationMode)GetInt32(new IntPtr(p + 0x048)); // 0270D098E638 0x48 M_AtlasPopulationMode       ( 00018670C6E0 ModelEnumType AtlasPopulationMode AtlasPopulationMode AtlasPopulationMode Int32 )
            value.M_FaceInfo                                = (FaceInfo)GetInt32(new IntPtr(p + 0x050)); // 0270D098E658 0x50 M_FaceInfo                  ( 0001865D05C0 ModelEnumType FaceInfo FaceInfo FaceInfo Int32 )
            value.M_GlyphTable                              = GetObjectList<Glyph>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Glyph.FromPointer); // 0270D098E678 0xB0 M_GlyphTable                ( 000185CDEB28 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_CharacterTable                          = GetObjectList<TMP_Character>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.TMP_Character.FromPointer); // 0270D098E6B8 0xC0 M_CharacterTable            ( 000185D117B8 ModelClassListType List`1<TMP_Character> List`1<TMP_Character> List<TMP_Character> Pointer )
            value.M_AtlasTexture                            = GetObject<Texture2D>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Texture2D.FromPointer); // 0270D098E6F8 0xD0 M_AtlasTexture              ( 000186685CB0 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_AtlasTextures                           = GetObjectList<Texture2D>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Texture2D.FromPointer); // 0270D098E718 0xD8 M_AtlasTextures             ( 000185CAB2C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.M_AtlasTextureIndex                       = GetInt32(new IntPtr(p + 0x0E0)); // 0270D098E738 0xE0 M_AtlasTextureIndex         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_IsMultiAtlasTexturesEnabled             = GetBool(new IntPtr(p + 0x0E4)); // 0270D098E758 0xE4 M_IsMultiAtlasTexturesEnabled ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ClearDynamicDataOnBuild                 = GetBool(new IntPtr(p + 0x0E5)); // 0270D098E778 0xE5 M_ClearDynamicDataOnBuild   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_UsedGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x0E8)); // 0270D098E798 0xE8 M_UsedGlyphRects            ( 000185CDF008 ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer )
            value.M_FreeGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x0F0)); // 0270D098E7B8 0xF0 M_FreeGlyphRects            ( 000185CDF008 ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer )
            value.M_fontInfo                                = GetObject<FaceInfo_Legacy>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.FaceInfo_Legacy.FromPointer); // 0270D098E7D8 0xF8 M_fontInfo                  ( 00018654EEB0 ModelClassType FaceInfo_Legacy FaceInfo_Legacy FaceInfo_Legacy Pointer )
            value.Atlas                                     = GetObject<Texture2D>(new IntPtr(p + 0x100), ReversePrism.DataModels.Texture2D.FromPointer); // 0270D098E7F8 0x100 Atlas                       ( 000186685F20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_AtlasWidth                              = GetInt32(new IntPtr(p + 0x108)); // 0270D098E818 0x108 M_AtlasWidth                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_AtlasHeight                             = GetInt32(new IntPtr(p + 0x10C)); // 0270D098E838 0x10C M_AtlasHeight               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_AtlasPadding                            = GetInt32(new IntPtr(p + 0x110)); // 0270D098E858 0x110 M_AtlasPadding              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_AtlasRenderMode                         = (GlyphRenderMode)GetInt32(new IntPtr(p + 0x114)); // 0270D098E878 0x114 M_AtlasRenderMode           ( 000186682B30 ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32 )
            value.M_glyphInfoList                           = GetObjectList<TMP_Glyph>(new IntPtr(p + 0x118), ReversePrism.DataModels.TMP_Glyph.FromPointer); // 0270D098E898 0x118 M_glyphInfoList             ( 000185D11F28 ModelClassListType List`1<TMP_Glyph> List`1<TMP_Glyph> List<TMP_Glyph> Pointer )
            value.M_KerningTable                            = GetObject<KerningTable>(new IntPtr(p + 0x120), ReversePrism.DataModels.KerningTable.FromPointer); // 0270D098E8B8 0x120 M_KerningTable              ( 00018676C400 ModelClassType KerningTable KerningTable KerningTable Pointer )
            value.M_FontFeatureTable                        = GetObject<TMP_FontFeatureTable>(new IntPtr(p + 0x128), ReversePrism.DataModels.TMP_FontFeatureTable.FromPointer); // 0270D098E8D8 0x128 M_FontFeatureTable          ( 00018660BED0 ModelClassType TMP_FontFeatureTable TMP_FontFeatureTable TMP_FontFeatureTable Pointer )
            value.FallbackFontAssets                        = GetObjectList<TMP_FontAsset>(new IntPtr(p + 0x130), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0270D098E8F8 0x130 FallbackFontAssets          ( 000185D11BD8 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer )
            value.M_FallbackFontAssetTable                  = GetObjectList<TMP_FontAsset>(new IntPtr(p + 0x138), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0270D098E918 0x138 M_FallbackFontAssetTable    ( 000185D11C48 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer )
            value.M_CreationSettings                        = (FontAssetCreationSettings)GetInt32(new IntPtr(p + 0x140)); // 0270D098E938 0x140 M_CreationSettings          ( 0001865ADCE0 ModelEnumType FontAssetCreationSettings FontAssetCreationSettings FontAssetCreationSettings Int32 )
            value.M_FontWeightTable                         = GetEnumList<TMP_FontWeightPair>(new IntPtr(p + 0x198)); // 0270D098E958 0x198 M_FontWeightTable           ( 000185CA9008 ModelEnumListType TMP_FontWeightPair[] TMP_FontWeightPair[] List<TMP_FontWeightPair> Pointer )
            value.FontWeights                               = GetEnumList<TMP_FontWeightPair>(new IntPtr(p + 0x1A0)); // 0270D098E978 0x1A0 FontWeights                 ( 000185CA9008 ModelEnumListType TMP_FontWeightPair[] TMP_FontWeightPair[] List<TMP_FontWeightPair> Pointer )
            value.NormalStyle                               = GetSingle(new IntPtr(p + 0x1A8)); // 0270D098E998 0x1A8 NormalStyle                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.NormalSpacingOffset                       = GetSingle(new IntPtr(p + 0x1AC)); // 0270D098E9B8 0x1AC NormalSpacingOffset         ( 000186666050 ModelPrimitiveType float float float Single )
            value.BoldStyle                                 = GetSingle(new IntPtr(p + 0x1B0)); // 0270D098E9D8 0x1B0 BoldStyle                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.BoldSpacing                               = GetSingle(new IntPtr(p + 0x1B4)); // 0270D098E9F8 0x1B4 BoldSpacing                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.ItalicStyle                               = GetSByte(new IntPtr(p + 0x1B8)); // 0270D098EA18 0x1B8 ItalicStyle                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.TabSize                                   = GetSByte(new IntPtr(p + 0x1B9)); // 0270D098EA38 0x1B9 TabSize                     ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.IsFontAssetLookupTablesDirty              = GetBool(new IntPtr(p + 0x1BA)); // 0270D098EA58 0x1BA IsFontAssetLookupTablesDirty ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.K_TryAddCharacterMarker                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0270D098EAB8 0x10 K_TryAddCharacterMarker     ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_TryAddCharactersMarker                  = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0270D098EAD8 0x18 K_TryAddCharactersMarker    ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UpdateGlyphAdjustmentRecordsMarker      = (ProfilerMarker)GetInt32(new IntPtr(p + 0x020)); // 0270D098EAF8 0x20 K_UpdateGlyphAdjustmentRecordsMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ClearFontAssetDataMarker                = (ProfilerMarker)GetInt32(new IntPtr(p + 0x028)); // 0270D098EB18 0x28 K_ClearFontAssetDataMarker  ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UpdateFontAssetDataMarker               = (ProfilerMarker)GetInt32(new IntPtr(p + 0x030)); // 0270D098EB38 0x30 K_UpdateFontAssetDataMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_DefaultMaterialSuffix                   = GetString(new IntPtr(p + 0x038)); // 0270D098EB58 0x38 S_DefaultMaterialSuffix     ( 000186672530 ModelPrimitiveType string string string String )
            value.K_FontAssets_FontFeaturesUpdateQueue      = GetObjectList<TMP_FontAsset>(new IntPtr(p + 0x048), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0270D098EBB8 0x48 K_FontAssets_FontFeaturesUpdateQueue ( 000185D11CE8 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer )
            value.K_FontAssets_AtlasTexturesUpdateQueue     = GetObjectList<TMP_FontAsset>(new IntPtr(p + 0x058), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0270D098EBF8 0x58 K_FontAssets_AtlasTexturesUpdateQueue ( 000185D11CE8 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer )
            value.M_GlyphsToRender                          = GetObjectList<Glyph>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.Glyph.FromPointer); // 0270D098EC38 0x1C8 M_GlyphsToRender            ( 000185CDEAC8 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_GlyphsRendered                          = GetObjectList<Glyph>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.Glyph.FromPointer); // 0270D098EC58 0x1D0 M_GlyphsRendered            ( 000185CDEAC8 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_GlyphIndexList                          = GetUInt32List(new IntPtr(p + 0x1D8)); // 0270D098EC78 0x1D8 M_GlyphIndexList            ( 000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_GlyphIndexListNewlyAdded                = GetUInt32List(new IntPtr(p + 0x1E0)); // 0270D098EC98 0x1E0 M_GlyphIndexListNewlyAdded  ( 000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_GlyphsToAdd                             = GetUInt32List(new IntPtr(p + 0x1E8)); // 0270D098ECB8 0x1E8 M_GlyphsToAdd               ( 000185D19258 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_CharactersToAdd                         = GetObjectList<TMP_Character>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.TMP_Character.FromPointer); // 0270D098ECF8 0x1F8 M_CharactersToAdd           ( 000185D117B8 ModelClassListType List`1<TMP_Character> List`1<TMP_Character> List<TMP_Character> Pointer )
            value.S_MissingCharacterList                    = GetUInt32List(new IntPtr(p + 0x208)); // 0270D098ED38 0x208 S_MissingCharacterList      ( 000185D19258 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.K_GlyphIndexArray                         = GetUInt32List(new IntPtr(p + 0x068)); // 0270D098ED78 0x68 K_GlyphIndexArray           ( 000185B83B30 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
