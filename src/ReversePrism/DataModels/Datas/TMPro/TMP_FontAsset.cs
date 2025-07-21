using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_Version                                ModelPrimitiveType string string string String
    // 038 M_SourceFontFileGUID                     ModelPrimitiveType string string string String
    // 040 M_SourceFontFile                         ModelClassType Font Font Font Pointer
    // 048 M_AtlasPopulationMode                    ModelEnumType AtlasPopulationMode AtlasPopulationMode AtlasPopulationMode Int32
    // 050 M_FaceInfo                               ModelEnumType FaceInfo FaceInfo FaceInfo Int32
    // 0B0 M_GlyphTable                             ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 0B8 m_GlyphLookupDictionary                  Dictionary`2<uint, Glyph> IL2CPP_TYPE_GENERICINST
    // 0C0 M_CharacterTable                         ModelClassListType List`1<TMP_Character> List`1<TMP_Character> List<TMP_Character> Pointer
    // 0C8 m_CharacterLookupDictionary              Dictionary`2<uint, TMP_Character> IL2CPP_TYPE_GENERICINST
    // 0D0 M_AtlasTexture                           ModelClassType Texture2D Texture2D Texture2D Pointer
    // 0D8 M_AtlasTextures                          ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 0E0 M_AtlasTextureIndex                      ModelPrimitiveType int int int Int32
    // 0E4 M_IsMultiAtlasTexturesEnabled            ModelPrimitiveType bool bool bool Bool
    // 0E5 M_ClearDynamicDataOnBuild                ModelPrimitiveType bool bool bool Bool
    // 0E8 M_UsedGlyphRects                         ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer
    // 0F0 M_FreeGlyphRects                         ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer
    // 0F8 M_fontInfo                               ModelClassType FaceInfo_Legacy FaceInfo_Legacy FaceInfo_Legacy Pointer
    // 100 Atlas                                    ModelClassType Texture2D Texture2D Texture2D Pointer
    // 108 M_AtlasWidth                             ModelPrimitiveType int int int Int32
    // 10C M_AtlasHeight                            ModelPrimitiveType int int int Int32
    // 110 M_AtlasPadding                           ModelPrimitiveType int int int Int32
    // 114 M_AtlasRenderMode                        ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32
    // 118 M_glyphInfoList                          ModelClassListType List`1<TMP_Glyph> List`1<TMP_Glyph> List<TMP_Glyph> Pointer
    // 120 M_KerningTable                           ModelClassType KerningTable KerningTable KerningTable Pointer
    // 128 M_FontFeatureTable                       ModelClassType TMP_FontFeatureTable TMP_FontFeatureTable TMP_FontFeatureTable Pointer
    // 130 FallbackFontAssets                       ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer
    // 138 M_FallbackFontAssetTable                 ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer
    // 140 M_CreationSettings                       ModelEnumType FontAssetCreationSettings FontAssetCreationSettings FontAssetCreationSettings Int32
    // 198 M_FontWeightTable                        ModelEnumListType TMP_FontWeightPair[] TMP_FontWeightPair[] List<TMP_FontWeightPair> Pointer
    // 1A0 FontWeights                              ModelEnumListType TMP_FontWeightPair[] TMP_FontWeightPair[] List<TMP_FontWeightPair> Pointer
    // 1A8 NormalStyle                              ModelPrimitiveType float float float Single
    // 1AC NormalSpacingOffset                      ModelPrimitiveType float float float Single
    // 1B0 BoldStyle                                ModelPrimitiveType float float float Single
    // 1B4 BoldSpacing                              ModelPrimitiveType float float float Single
    // 1B8 ItalicStyle                              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1B9 TabSize                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1BA IsFontAssetLookupTablesDirty             ModelPrimitiveType bool bool bool Bool
    // 000 k_ReadFontAssetDefinitionMarker          ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 k_AddSynthesizedCharactersMarker         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 K_TryAddCharacterMarker                  ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 K_TryAddCharactersMarker                 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 K_UpdateGlyphAdjustmentRecordsMarker     ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 028 K_ClearFontAssetDataMarker               ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 030 K_UpdateFontAssetDataMarker              ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 038 S_DefaultMaterialSuffix                  ModelPrimitiveType string string string String
    // 1C0 FallbackSearchQueryLookup                HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 040 k_SearchedFontAssetLookup                HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 048 K_FontAssets_FontFeaturesUpdateQueue     ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer
    // 050 k_FontAssets_FontFeaturesUpdateQueueLookup HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 058 K_FontAssets_AtlasTexturesUpdateQueue    ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer
    // 060 k_FontAssets_AtlasTexturesUpdateQueueLookup HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 1C8 M_GlyphsToRender                         ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 1D0 M_GlyphsRendered                         ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 1D8 M_GlyphIndexList                         ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1E0 M_GlyphIndexListNewlyAdded               ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1E8 M_GlyphsToAdd                            ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1F0 m_GlyphsToAddLookup                      HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 1F8 M_CharactersToAdd                        ModelClassListType List`1<TMP_Character> List`1<TMP_Character> List<TMP_Character> Pointer
    // 200 m_CharactersToAddLookup                  HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 208 S_MissingCharacterList                   ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 210 m_MissingUnicodesFromFontFile            HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 068 K_GlyphIndexArray                        ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class TMP_FontAsset : DataModel
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
            var value   = new TMP_FontAsset() { Pointer= p0 };

            value.M_Version                                 = GetString(new IntPtr(p + 0x030)); // 0x30 M_Version                   ( ModelPrimitiveType string string string String )
            value.M_SourceFontFileGUID                      = GetString(new IntPtr(p + 0x038)); // 0x38 M_SourceFontFileGUID        ( ModelPrimitiveType string string string String )
            value.M_SourceFontFile                          = GetObject<Font>(new IntPtr(p + 0x040), ReversePrism.DataModels.Font.FromPointer); // 0x40 M_SourceFontFile            ( ModelClassType Font Font Font Pointer )
            value.M_AtlasPopulationMode                     = (AtlasPopulationMode)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_AtlasPopulationMode       ( ModelEnumType AtlasPopulationMode AtlasPopulationMode AtlasPopulationMode Int32 )
            value.M_FaceInfo                                = (FaceInfo)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_FaceInfo                  ( ModelEnumType FaceInfo FaceInfo FaceInfo Int32 )
            value.M_GlyphTable                              = GetObjectList<Glyph>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Glyph.FromPointer); // 0xB0 M_GlyphTable                ( ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_CharacterTable                          = GetObjectList<TMP_Character>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.TMP_Character.FromPointer); // 0xC0 M_CharacterTable            ( ModelClassListType List`1<TMP_Character> List`1<TMP_Character> List<TMP_Character> Pointer )
            value.M_AtlasTexture                            = GetObject<Texture2D>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Texture2D.FromPointer); // 0xD0 M_AtlasTexture              ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_AtlasTextures                           = GetObjectList<Texture2D>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Texture2D.FromPointer); // 0xD8 M_AtlasTextures             ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.M_AtlasTextureIndex                       = GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 M_AtlasTextureIndex         ( ModelPrimitiveType int int int Int32 )
            value.M_IsMultiAtlasTexturesEnabled             = GetBool(new IntPtr(p + 0x0E4)); // 0xE4 M_IsMultiAtlasTexturesEnabled ( ModelPrimitiveType bool bool bool Bool )
            value.M_ClearDynamicDataOnBuild                 = GetBool(new IntPtr(p + 0x0E5)); // 0xE5 M_ClearDynamicDataOnBuild   ( ModelPrimitiveType bool bool bool Bool )
            value.M_UsedGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x0E8)); // 0xE8 M_UsedGlyphRects            ( ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer )
            value.M_FreeGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x0F0)); // 0xF0 M_FreeGlyphRects            ( ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer )
            value.M_fontInfo                                = GetObject<FaceInfo_Legacy>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.FaceInfo_Legacy.FromPointer); // 0xF8 M_fontInfo                  ( ModelClassType FaceInfo_Legacy FaceInfo_Legacy FaceInfo_Legacy Pointer )
            value.Atlas                                     = GetObject<Texture2D>(new IntPtr(p + 0x100), ReversePrism.DataModels.Texture2D.FromPointer); // 0x100 Atlas                       ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_AtlasWidth                              = GetInt32(new IntPtr(p + 0x108)); // 0x108 M_AtlasWidth                ( ModelPrimitiveType int int int Int32 )
            value.M_AtlasHeight                             = GetInt32(new IntPtr(p + 0x10C)); // 0x10C M_AtlasHeight               ( ModelPrimitiveType int int int Int32 )
            value.M_AtlasPadding                            = GetInt32(new IntPtr(p + 0x110)); // 0x110 M_AtlasPadding              ( ModelPrimitiveType int int int Int32 )
            value.M_AtlasRenderMode                         = (GlyphRenderMode)GetInt32(new IntPtr(p + 0x114)); // 0x114 M_AtlasRenderMode           ( ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32 )
            value.M_glyphInfoList                           = GetObjectList<TMP_Glyph>(new IntPtr(p + 0x118), ReversePrism.DataModels.TMP_Glyph.FromPointer); // 0x118 M_glyphInfoList             ( ModelClassListType List`1<TMP_Glyph> List`1<TMP_Glyph> List<TMP_Glyph> Pointer )
            value.M_KerningTable                            = GetObject<KerningTable>(new IntPtr(p + 0x120), ReversePrism.DataModels.KerningTable.FromPointer); // 0x120 M_KerningTable              ( ModelClassType KerningTable KerningTable KerningTable Pointer )
            value.M_FontFeatureTable                        = GetObject<TMP_FontFeatureTable>(new IntPtr(p + 0x128), ReversePrism.DataModels.TMP_FontFeatureTable.FromPointer); // 0x128 M_FontFeatureTable          ( ModelClassType TMP_FontFeatureTable TMP_FontFeatureTable TMP_FontFeatureTable Pointer )
            value.FallbackFontAssets                        = GetObjectList<TMP_FontAsset>(new IntPtr(p + 0x130), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0x130 FallbackFontAssets          ( ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer )
            value.M_FallbackFontAssetTable                  = GetObjectList<TMP_FontAsset>(new IntPtr(p + 0x138), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0x138 M_FallbackFontAssetTable    ( ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer )
            value.M_CreationSettings                        = (FontAssetCreationSettings)GetInt32(new IntPtr(p + 0x140)); // 0x140 M_CreationSettings          ( ModelEnumType FontAssetCreationSettings FontAssetCreationSettings FontAssetCreationSettings Int32 )
            value.M_FontWeightTable                         = GetEnumList<TMP_FontWeightPair>(new IntPtr(p + 0x198)); // 0x198 M_FontWeightTable           ( ModelEnumListType TMP_FontWeightPair[] TMP_FontWeightPair[] List<TMP_FontWeightPair> Pointer )
            value.FontWeights                               = GetEnumList<TMP_FontWeightPair>(new IntPtr(p + 0x1A0)); // 0x1A0 FontWeights                 ( ModelEnumListType TMP_FontWeightPair[] TMP_FontWeightPair[] List<TMP_FontWeightPair> Pointer )
            value.NormalStyle                               = GetSingle(new IntPtr(p + 0x1A8)); // 0x1A8 NormalStyle                 ( ModelPrimitiveType float float float Single )
            value.NormalSpacingOffset                       = GetSingle(new IntPtr(p + 0x1AC)); // 0x1AC NormalSpacingOffset         ( ModelPrimitiveType float float float Single )
            value.BoldStyle                                 = GetSingle(new IntPtr(p + 0x1B0)); // 0x1B0 BoldStyle                   ( ModelPrimitiveType float float float Single )
            value.BoldSpacing                               = GetSingle(new IntPtr(p + 0x1B4)); // 0x1B4 BoldSpacing                 ( ModelPrimitiveType float float float Single )
            value.ItalicStyle                               = GetSByte(new IntPtr(p + 0x1B8)); // 0x1B8 ItalicStyle                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.TabSize                                   = GetSByte(new IntPtr(p + 0x1B9)); // 0x1B9 TabSize                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.IsFontAssetLookupTablesDirty              = GetBool(new IntPtr(p + 0x1BA)); // 0x1BA IsFontAssetLookupTablesDirty ( ModelPrimitiveType bool bool bool Bool )
            value.K_TryAddCharacterMarker                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0x10 K_TryAddCharacterMarker     ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_TryAddCharactersMarker                  = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0x18 K_TryAddCharactersMarker    ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UpdateGlyphAdjustmentRecordsMarker      = (ProfilerMarker)GetInt32(new IntPtr(p + 0x020)); // 0x20 K_UpdateGlyphAdjustmentRecordsMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ClearFontAssetDataMarker                = (ProfilerMarker)GetInt32(new IntPtr(p + 0x028)); // 0x28 K_ClearFontAssetDataMarker  ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UpdateFontAssetDataMarker               = (ProfilerMarker)GetInt32(new IntPtr(p + 0x030)); // 0x30 K_UpdateFontAssetDataMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_DefaultMaterialSuffix                   = GetString(new IntPtr(p + 0x038)); // 0x38 S_DefaultMaterialSuffix     ( ModelPrimitiveType string string string String )
            value.K_FontAssets_FontFeaturesUpdateQueue      = GetObjectList<TMP_FontAsset>(new IntPtr(p + 0x048), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0x48 K_FontAssets_FontFeaturesUpdateQueue ( ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer )
            value.K_FontAssets_AtlasTexturesUpdateQueue     = GetObjectList<TMP_FontAsset>(new IntPtr(p + 0x058), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0x58 K_FontAssets_AtlasTexturesUpdateQueue ( ModelClassListType List`1<TMP_FontAsset> List`1<TMP_FontAsset> List<TMP_FontAsset> Pointer )
            value.M_GlyphsToRender                          = GetObjectList<Glyph>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.Glyph.FromPointer); // 0x1C8 M_GlyphsToRender            ( ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_GlyphsRendered                          = GetObjectList<Glyph>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.Glyph.FromPointer); // 0x1D0 M_GlyphsRendered            ( ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_GlyphIndexList                          = GetUInt32List(new IntPtr(p + 0x1D8)); // 0x1D8 M_GlyphIndexList            ( ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_GlyphIndexListNewlyAdded                = GetUInt32List(new IntPtr(p + 0x1E0)); // 0x1E0 M_GlyphIndexListNewlyAdded  ( ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_GlyphsToAdd                             = GetUInt32List(new IntPtr(p + 0x1E8)); // 0x1E8 M_GlyphsToAdd               ( ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_CharactersToAdd                         = GetObjectList<TMP_Character>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.TMP_Character.FromPointer); // 0x1F8 M_CharactersToAdd           ( ModelClassListType List`1<TMP_Character> List`1<TMP_Character> List<TMP_Character> Pointer )
            value.S_MissingCharacterList                    = GetUInt32List(new IntPtr(p + 0x208)); // 0x208 S_MissingCharacterList      ( ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.K_GlyphIndexArray                         = GetUInt32List(new IntPtr(p + 0x068)); // 0x68 K_GlyphIndexArray           ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
