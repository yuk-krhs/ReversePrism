using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 M_SourceFontFileGUID                     ModelPrimitiveType string string string String
    // 040 M_fontAssetCreationEditorSettings        ModelEnumType FontAssetCreationEditorSettings FontAssetCreationEditorSettings FontAssetCreationEditorSettings Int32
    // 098 M_SourceFontFile                         ModelClassType Font Font Font Pointer
    // 0A0 M_SourceFontFilePath                     ModelPrimitiveType string string string String
    // 0A8 M_AtlasPopulationMode                    ModelEnumType AtlasPopulationMode AtlasPopulationMode AtlasPopulationMode Int32
    // 0AC InternalDynamicOS                        ModelPrimitiveType bool bool bool Bool
    // 0B0 M_FaceInfo                               ModelEnumType FaceInfo FaceInfo FaceInfo Int32
    // 110 M_FamilyNameHashCode                     ModelPrimitiveType int int int Int32
    // 114 M_StyleNameHashCode                      ModelPrimitiveType int int int Int32
    // 118 M_GlyphTable                             ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 120 m_GlyphLookupDictionary                  Dictionary`2<uint, Glyph> IL2CPP_TYPE_GENERICINST
    // 128 M_CharacterTable                         ModelClassListType List`1<Character> List`1<Character> List<Character> Pointer
    // 130 m_CharacterLookupDictionary              Dictionary`2<uint, Character> IL2CPP_TYPE_GENERICINST
    // 138 M_AtlasTexture                           ModelClassType Texture2D Texture2D Texture2D Pointer
    // 140 M_AtlasTextures                          ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 148 M_AtlasTextureIndex                      ModelPrimitiveType int int int Int32
    // 14C M_IsMultiAtlasTexturesEnabled            ModelPrimitiveType bool bool bool Bool
    // 14D M_ClearDynamicDataOnBuild                ModelPrimitiveType bool bool bool Bool
    // 150 M_AtlasWidth                             ModelPrimitiveType int int int Int32
    // 154 M_AtlasHeight                            ModelPrimitiveType int int int Int32
    // 158 M_AtlasPadding                           ModelPrimitiveType int int int Int32
    // 15C M_AtlasRenderMode                        ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32
    // 160 M_UsedGlyphRects                         ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer
    // 168 M_FreeGlyphRects                         ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer
    // 170 M_FontFeatureTable                       ModelClassType FontFeatureTable FontFeatureTable FontFeatureTable Pointer
    // 178 M_FallbackFontAssetTable                 ModelClassListType List`1<FontAsset> List`1<FontAsset> List<FontAsset> Pointer
    // 180 M_FontWeightTable                        ModelEnumListType FontWeightPair[] FontWeightPair[] List<FontWeightPair> Pointer
    // 188 M_RegularStyleWeight                     ModelPrimitiveType float float float Single
    // 18C M_RegularStyleSpacing                    ModelPrimitiveType float float float Single
    // 190 M_BoldStyleWeight                        ModelPrimitiveType float float float Single
    // 194 M_BoldStyleSpacing                       ModelPrimitiveType float float float Single
    // 198 M_ItalicStyleSlant                       ModelPrimitiveType sbyte sbyte sbyte SByte
    // 199 M_TabMultiple                            ModelPrimitiveType sbyte sbyte sbyte SByte
    // 19A IsFontAssetLookupTablesDirty             ModelPrimitiveType bool bool bool Bool
    // 000 k_ReadFontAssetDefinitionMarker          ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 k_AddSynthesizedCharactersMarker         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 K_TryAddCharacterMarker                  ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 K_TryAddCharactersMarker                 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 K_UpdateGlyphAdjustmentRecordsMarker     ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 028 K_UpdateDiacriticalMarkAdjustmentRecordsMarker ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 030 K_ClearFontAssetDataMarker               ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 038 K_UpdateFontAssetDataMarker              ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 040 K_TryAddGlyphMarker                      ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 048 S_DefaultMaterialSuffix                  ModelPrimitiveType string string string String
    // 050 k_SearchedFontAssetLookup                HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 058 K_FontAssets_FontFeaturesUpdateQueue     ModelClassListType List`1<FontAsset> List`1<FontAsset> List<FontAsset> Pointer
    // 060 k_FontAssets_FontFeaturesUpdateQueueLookup HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 068 K_FontAssets_AtlasTexturesUpdateQueue    ModelClassListType List`1<Texture2D> List`1<Texture2D> List<Texture2D> Pointer
    // 070 k_FontAssets_AtlasTexturesUpdateQueueLookup HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 1A0 M_GlyphsToRender                         ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 1A8 M_GlyphsRendered                         ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 1B0 M_GlyphIndexList                         ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1B8 M_GlyphIndexListNewlyAdded               ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1C0 M_GlyphsToAdd                            ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1C8 m_GlyphsToAddLookup                      HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 1D0 M_CharactersToAdd                        ModelClassListType List`1<Character> List`1<Character> List<Character> Pointer
    // 1D8 m_CharactersToAddLookup                  HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 1E0 S_MissingCharacterList                   ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1E8 m_MissingUnicodesFromFontFile            HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 078 K_GlyphIndexArray                        ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class FontAsset : DataModel
    {
        public string                                   M_SourceFontFileGUID                    { get; set; }
        public FontAssetCreationEditorSettings          M_fontAssetCreationEditorSettings       { get; set; }
        public Font?                                    M_SourceFontFile                        { get; set; }
        public string                                   M_SourceFontFilePath                    { get; set; }
        public AtlasPopulationMode                      M_AtlasPopulationMode                   { get; set; }
        public bool                                     InternalDynamicOS                       { get; set; }
        public FaceInfo                                 M_FaceInfo                              { get; set; }
        public int                                      M_FamilyNameHashCode                    { get; set; }
        public int                                      M_StyleNameHashCode                     { get; set; }
        public List<Glyph>?                             M_GlyphTable                            { get; set; }
        public List<Character>?                         M_CharacterTable                        { get; set; }
        public Texture2D?                               M_AtlasTexture                          { get; set; }
        public List<Texture2D>?                         M_AtlasTextures                         { get; set; }
        public int                                      M_AtlasTextureIndex                     { get; set; }
        public bool                                     M_IsMultiAtlasTexturesEnabled           { get; set; }
        public bool                                     M_ClearDynamicDataOnBuild               { get; set; }
        public int                                      M_AtlasWidth                            { get; set; }
        public int                                      M_AtlasHeight                           { get; set; }
        public int                                      M_AtlasPadding                          { get; set; }
        public GlyphRenderMode                          M_AtlasRenderMode                       { get; set; }
        public List<GlyphRect>?                         M_UsedGlyphRects                        { get; set; }
        public List<GlyphRect>?                         M_FreeGlyphRects                        { get; set; }
        public FontFeatureTable?                        M_FontFeatureTable                      { get; set; }
        public List<FontAsset>?                         M_FallbackFontAssetTable                { get; set; }
        public List<FontWeightPair>?                    M_FontWeightTable                       { get; set; }
        public float                                    M_RegularStyleWeight                    { get; set; }
        public float                                    M_RegularStyleSpacing                   { get; set; }
        public float                                    M_BoldStyleWeight                       { get; set; }
        public float                                    M_BoldStyleSpacing                      { get; set; }
        public sbyte                                    M_ItalicStyleSlant                      { get; set; }
        public sbyte                                    M_TabMultiple                           { get; set; }
        public bool                                     IsFontAssetLookupTablesDirty            { get; set; }
        public ProfilerMarker                           K_TryAddCharacterMarker                 { get; set; }
        public ProfilerMarker                           K_TryAddCharactersMarker                { get; set; }
        public ProfilerMarker                           K_UpdateGlyphAdjustmentRecordsMarker    { get; set; }
        public ProfilerMarker                           K_UpdateDiacriticalMarkAdjustmentRecordsMarker { get; set; }
        public ProfilerMarker                           K_ClearFontAssetDataMarker              { get; set; }
        public ProfilerMarker                           K_UpdateFontAssetDataMarker             { get; set; }
        public ProfilerMarker                           K_TryAddGlyphMarker                     { get; set; }
        public string                                   S_DefaultMaterialSuffix                 { get; set; }
        public List<FontAsset>?                         K_FontAssets_FontFeaturesUpdateQueue    { get; set; }
        public List<Texture2D>?                         K_FontAssets_AtlasTexturesUpdateQueue   { get; set; }
        public List<Glyph>?                             M_GlyphsToRender                        { get; set; }
        public List<Glyph>?                             M_GlyphsRendered                        { get; set; }
        public List<uint>?                              M_GlyphIndexList                        { get; set; }
        public List<uint>?                              M_GlyphIndexListNewlyAdded              { get; set; }
        public List<uint>?                              M_GlyphsToAdd                           { get; set; }
        public List<Character>?                         M_CharactersToAdd                       { get; set; }
        public List<uint>?                              S_MissingCharacterList                  { get; set; }
        public List<uint>?                              K_GlyphIndexArray                       { get; set; }

        public static FontAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontAsset() { Pointer= p0 };

            value.M_SourceFontFileGUID                      = GetString(new IntPtr(p + 0x038)); // 0x38 M_SourceFontFileGUID        ( ModelPrimitiveType string string string String )
            value.M_fontAssetCreationEditorSettings         = (FontAssetCreationEditorSettings)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_fontAssetCreationEditorSettings ( ModelEnumType FontAssetCreationEditorSettings FontAssetCreationEditorSettings FontAssetCreationEditorSettings Int32 )
            value.M_SourceFontFile                          = GetObject<Font>(new IntPtr(p + 0x098), ReversePrism.DataModels.Font.FromPointer); // 0x98 M_SourceFontFile            ( ModelClassType Font Font Font Pointer )
            value.M_SourceFontFilePath                      = GetString(new IntPtr(p + 0x0A0)); // 0xA0 M_SourceFontFilePath        ( ModelPrimitiveType string string string String )
            value.M_AtlasPopulationMode                     = (AtlasPopulationMode)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 M_AtlasPopulationMode       ( ModelEnumType AtlasPopulationMode AtlasPopulationMode AtlasPopulationMode Int32 )
            value.InternalDynamicOS                         = GetBool(new IntPtr(p + 0x0AC)); // 0xAC InternalDynamicOS           ( ModelPrimitiveType bool bool bool Bool )
            value.M_FaceInfo                                = (FaceInfo)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 M_FaceInfo                  ( ModelEnumType FaceInfo FaceInfo FaceInfo Int32 )
            value.M_FamilyNameHashCode                      = GetInt32(new IntPtr(p + 0x110)); // 0x110 M_FamilyNameHashCode        ( ModelPrimitiveType int int int Int32 )
            value.M_StyleNameHashCode                       = GetInt32(new IntPtr(p + 0x114)); // 0x114 M_StyleNameHashCode         ( ModelPrimitiveType int int int Int32 )
            value.M_GlyphTable                              = GetObjectList<Glyph>(new IntPtr(p + 0x118), ReversePrism.DataModels.Glyph.FromPointer); // 0x118 M_GlyphTable                ( ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_CharacterTable                          = GetObjectList<Character>(new IntPtr(p + 0x128), ReversePrism.DataModels.Character.FromPointer); // 0x128 M_CharacterTable            ( ModelClassListType List`1<Character> List`1<Character> List<Character> Pointer )
            value.M_AtlasTexture                            = GetObject<Texture2D>(new IntPtr(p + 0x138), ReversePrism.DataModels.Texture2D.FromPointer); // 0x138 M_AtlasTexture              ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_AtlasTextures                           = GetObjectList<Texture2D>(new IntPtr(p + 0x140), ReversePrism.DataModels.Texture2D.FromPointer); // 0x140 M_AtlasTextures             ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.M_AtlasTextureIndex                       = GetInt32(new IntPtr(p + 0x148)); // 0x148 M_AtlasTextureIndex         ( ModelPrimitiveType int int int Int32 )
            value.M_IsMultiAtlasTexturesEnabled             = GetBool(new IntPtr(p + 0x14C)); // 0x14C M_IsMultiAtlasTexturesEnabled ( ModelPrimitiveType bool bool bool Bool )
            value.M_ClearDynamicDataOnBuild                 = GetBool(new IntPtr(p + 0x14D)); // 0x14D M_ClearDynamicDataOnBuild   ( ModelPrimitiveType bool bool bool Bool )
            value.M_AtlasWidth                              = GetInt32(new IntPtr(p + 0x150)); // 0x150 M_AtlasWidth                ( ModelPrimitiveType int int int Int32 )
            value.M_AtlasHeight                             = GetInt32(new IntPtr(p + 0x154)); // 0x154 M_AtlasHeight               ( ModelPrimitiveType int int int Int32 )
            value.M_AtlasPadding                            = GetInt32(new IntPtr(p + 0x158)); // 0x158 M_AtlasPadding              ( ModelPrimitiveType int int int Int32 )
            value.M_AtlasRenderMode                         = (GlyphRenderMode)GetInt32(new IntPtr(p + 0x15C)); // 0x15C M_AtlasRenderMode           ( ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32 )
            value.M_UsedGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x160)); // 0x160 M_UsedGlyphRects            ( ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer )
            value.M_FreeGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x168)); // 0x168 M_FreeGlyphRects            ( ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer )
            value.M_FontFeatureTable                        = GetObject<FontFeatureTable>(new IntPtr(p + 0x170), ReversePrism.DataModels.FontFeatureTable.FromPointer); // 0x170 M_FontFeatureTable          ( ModelClassType FontFeatureTable FontFeatureTable FontFeatureTable Pointer )
            value.M_FallbackFontAssetTable                  = GetObjectList<FontAsset>(new IntPtr(p + 0x178), ReversePrism.DataModels.FontAsset.FromPointer); // 0x178 M_FallbackFontAssetTable    ( ModelClassListType List`1<FontAsset> List`1<FontAsset> List<FontAsset> Pointer )
            value.M_FontWeightTable                         = GetEnumList<FontWeightPair>(new IntPtr(p + 0x180)); // 0x180 M_FontWeightTable           ( ModelEnumListType FontWeightPair[] FontWeightPair[] List<FontWeightPair> Pointer )
            value.M_RegularStyleWeight                      = GetSingle(new IntPtr(p + 0x188)); // 0x188 M_RegularStyleWeight        ( ModelPrimitiveType float float float Single )
            value.M_RegularStyleSpacing                     = GetSingle(new IntPtr(p + 0x18C)); // 0x18C M_RegularStyleSpacing       ( ModelPrimitiveType float float float Single )
            value.M_BoldStyleWeight                         = GetSingle(new IntPtr(p + 0x190)); // 0x190 M_BoldStyleWeight           ( ModelPrimitiveType float float float Single )
            value.M_BoldStyleSpacing                        = GetSingle(new IntPtr(p + 0x194)); // 0x194 M_BoldStyleSpacing          ( ModelPrimitiveType float float float Single )
            value.M_ItalicStyleSlant                        = GetSByte(new IntPtr(p + 0x198)); // 0x198 M_ItalicStyleSlant          ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_TabMultiple                             = GetSByte(new IntPtr(p + 0x199)); // 0x199 M_TabMultiple               ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.IsFontAssetLookupTablesDirty              = GetBool(new IntPtr(p + 0x19A)); // 0x19A IsFontAssetLookupTablesDirty ( ModelPrimitiveType bool bool bool Bool )
            value.K_TryAddCharacterMarker                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0x10 K_TryAddCharacterMarker     ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_TryAddCharactersMarker                  = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0x18 K_TryAddCharactersMarker    ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UpdateGlyphAdjustmentRecordsMarker      = (ProfilerMarker)GetInt32(new IntPtr(p + 0x020)); // 0x20 K_UpdateGlyphAdjustmentRecordsMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UpdateDiacriticalMarkAdjustmentRecordsMarker = (ProfilerMarker)GetInt32(new IntPtr(p + 0x028)); // 0x28 K_UpdateDiacriticalMarkAdjustmentRecordsMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ClearFontAssetDataMarker                = (ProfilerMarker)GetInt32(new IntPtr(p + 0x030)); // 0x30 K_ClearFontAssetDataMarker  ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UpdateFontAssetDataMarker               = (ProfilerMarker)GetInt32(new IntPtr(p + 0x038)); // 0x38 K_UpdateFontAssetDataMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_TryAddGlyphMarker                       = (ProfilerMarker)GetInt32(new IntPtr(p + 0x040)); // 0x40 K_TryAddGlyphMarker         ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_DefaultMaterialSuffix                   = GetString(new IntPtr(p + 0x048)); // 0x48 S_DefaultMaterialSuffix     ( ModelPrimitiveType string string string String )
            value.K_FontAssets_FontFeaturesUpdateQueue      = GetObjectList<FontAsset>(new IntPtr(p + 0x058), ReversePrism.DataModels.FontAsset.FromPointer); // 0x58 K_FontAssets_FontFeaturesUpdateQueue ( ModelClassListType List`1<FontAsset> List`1<FontAsset> List<FontAsset> Pointer )
            value.K_FontAssets_AtlasTexturesUpdateQueue     = GetObjectList<Texture2D>(new IntPtr(p + 0x068), ReversePrism.DataModels.Texture2D.FromPointer); // 0x68 K_FontAssets_AtlasTexturesUpdateQueue ( ModelClassListType List`1<Texture2D> List`1<Texture2D> List<Texture2D> Pointer )
            value.M_GlyphsToRender                          = GetObjectList<Glyph>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.Glyph.FromPointer); // 0x1A0 M_GlyphsToRender            ( ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_GlyphsRendered                          = GetObjectList<Glyph>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.Glyph.FromPointer); // 0x1A8 M_GlyphsRendered            ( ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_GlyphIndexList                          = GetUInt32List(new IntPtr(p + 0x1B0)); // 0x1B0 M_GlyphIndexList            ( ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_GlyphIndexListNewlyAdded                = GetUInt32List(new IntPtr(p + 0x1B8)); // 0x1B8 M_GlyphIndexListNewlyAdded  ( ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_GlyphsToAdd                             = GetUInt32List(new IntPtr(p + 0x1C0)); // 0x1C0 M_GlyphsToAdd               ( ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_CharactersToAdd                         = GetObjectList<Character>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.Character.FromPointer); // 0x1D0 M_CharactersToAdd           ( ModelClassListType List`1<Character> List`1<Character> List<Character> Pointer )
            value.S_MissingCharacterList                    = GetUInt32List(new IntPtr(p + 0x1E0)); // 0x1E0 S_MissingCharacterList      ( ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.K_GlyphIndexArray                         = GetUInt32List(new IntPtr(p + 0x078)); // 0x78 K_GlyphIndexArray           ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
