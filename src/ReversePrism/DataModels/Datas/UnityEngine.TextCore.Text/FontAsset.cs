using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 M_SourceFontFileGUID                     000186671BA0 ModelPrimitiveType string string string String
    // 040 M_fontAssetCreationEditorSettings        0001865AD7F0 ModelEnumType FontAssetCreationEditorSettings FontAssetCreationEditorSettings FontAssetCreationEditorSettings Int32
    // 098 M_SourceFontFile                         0001865AD0A0 ModelClassType Font Font Font Pointer
    // 0A0 M_SourceFontFilePath                     000186671910 ModelPrimitiveType string string string String
    // 0A8 M_AtlasPopulationMode                    00018670D0D0 ModelEnumType AtlasPopulationMode AtlasPopulationMode AtlasPopulationMode Int32
    // 0AC InternalDynamicOS                        000186595210 ModelPrimitiveType bool bool bool Bool
    // 0B0 M_FaceInfo                               0001865D05C0 ModelEnumType FaceInfo FaceInfo FaceInfo Int32
    // 110 M_FamilyNameHashCode                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 114 M_StyleNameHashCode                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 118 M_GlyphTable                             000185CDEB28 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 120 m_GlyphLookupDictionary                  Dictionary`2<uint, Glyph> IL2CPP_TYPE_GENERICINST
    // 128 M_CharacterTable                         000185CD22A8 ModelClassListType List`1<Character> List`1<Character> List<Character> Pointer
    // 130 m_CharacterLookupDictionary              Dictionary`2<uint, Character> IL2CPP_TYPE_GENERICINST
    // 138 M_AtlasTexture                           000186685CB0 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 140 M_AtlasTextures                          000185CAB2C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 148 M_AtlasTextureIndex                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 14C M_IsMultiAtlasTexturesEnabled            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 14D M_ClearDynamicDataOnBuild                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 150 M_AtlasWidth                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 154 M_AtlasHeight                            0001865F2F90 ModelPrimitiveType int int int Int32
    // 158 M_AtlasPadding                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 15C M_AtlasRenderMode                        000186682B30 ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32
    // 160 M_UsedGlyphRects                         000185CDF008 ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer
    // 168 M_FreeGlyphRects                         000185CDF008 ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer
    // 170 M_FontFeatureTable                       0001865B0BC0 ModelClassType FontFeatureTable FontFeatureTable FontFeatureTable Pointer
    // 178 M_FallbackFontAssetTable                 000185CDC5D8 ModelClassListType List`1<FontAsset> List`1<FontAsset> List<FontAsset> Pointer
    // 180 M_FontWeightTable                        000185B7FD10 ModelEnumListType FontWeightPair[] FontWeightPair[] List<FontWeightPair> Pointer
    // 188 M_RegularStyleWeight                     000186665900 ModelPrimitiveType float float float Single
    // 18C M_RegularStyleSpacing                    000186665900 ModelPrimitiveType float float float Single
    // 190 M_BoldStyleWeight                        000186665900 ModelPrimitiveType float float float Single
    // 194 M_BoldStyleSpacing                       000186665900 ModelPrimitiveType float float float Single
    // 198 M_ItalicStyleSlant                       00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 199 M_TabMultiple                            00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 19A IsFontAssetLookupTablesDirty             000186595210 ModelPrimitiveType bool bool bool Bool
    // 000 k_ReadFontAssetDefinitionMarker          ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 k_AddSynthesizedCharactersMarker         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 K_TryAddCharacterMarker                  0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 K_TryAddCharactersMarker                 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 K_UpdateGlyphAdjustmentRecordsMarker     0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 028 K_UpdateDiacriticalMarkAdjustmentRecordsMarker 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 030 K_ClearFontAssetDataMarker               0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 038 K_UpdateFontAssetDataMarker              0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 040 K_TryAddGlyphMarker                      0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 048 S_DefaultMaterialSuffix                  000186672530 ModelPrimitiveType string string string String
    // 050 k_SearchedFontAssetLookup                HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 058 K_FontAssets_FontFeaturesUpdateQueue     000185CDC6A8 ModelClassListType List`1<FontAsset> List`1<FontAsset> List<FontAsset> Pointer
    // 060 k_FontAssets_FontFeaturesUpdateQueueLookup HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 068 K_FontAssets_AtlasTexturesUpdateQueue    000185D13E48 ModelClassListType List`1<Texture2D> List`1<Texture2D> List<Texture2D> Pointer
    // 070 k_FontAssets_AtlasTexturesUpdateQueueLookup HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 1A0 M_GlyphsToRender                         000185CDEAC8 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 1A8 M_GlyphsRendered                         000185CDEAC8 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer
    // 1B0 M_GlyphIndexList                         000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1B8 M_GlyphIndexListNewlyAdded               000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1C0 M_GlyphsToAdd                            000185D19258 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1C8 m_GlyphsToAddLookup                      HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 1D0 M_CharactersToAdd                        000185CD22A8 ModelClassListType List`1<Character> List`1<Character> List<Character> Pointer
    // 1D8 m_CharactersToAddLookup                  HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 1E0 S_MissingCharacterList                   000185D19258 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 1E8 m_MissingUnicodesFromFontFile            HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 078 K_GlyphIndexArray                        000185B83B30 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
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

            value.M_SourceFontFileGUID                      = GetString(new IntPtr(p + 0x038)); // 0245A68AA458 0x38 M_SourceFontFileGUID        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_fontAssetCreationEditorSettings         = (FontAssetCreationEditorSettings)GetInt32(new IntPtr(p + 0x040)); // 0245A68AA478 0x40 M_fontAssetCreationEditorSettings ( 0001865AD7F0 ModelEnumType FontAssetCreationEditorSettings FontAssetCreationEditorSettings FontAssetCreationEditorSettings Int32 )
            value.M_SourceFontFile                          = GetObject<Font>(new IntPtr(p + 0x098), ReversePrism.DataModels.Font.FromPointer); // 0245A68AA498 0x98 M_SourceFontFile            ( 0001865AD0A0 ModelClassType Font Font Font Pointer )
            value.M_SourceFontFilePath                      = GetString(new IntPtr(p + 0x0A0)); // 0245A68AA4B8 0xA0 M_SourceFontFilePath        ( 000186671910 ModelPrimitiveType string string string String )
            value.M_AtlasPopulationMode                     = (AtlasPopulationMode)GetInt32(new IntPtr(p + 0x0A8)); // 0245A68AA4D8 0xA8 M_AtlasPopulationMode       ( 00018670D0D0 ModelEnumType AtlasPopulationMode AtlasPopulationMode AtlasPopulationMode Int32 )
            value.InternalDynamicOS                         = GetBool(new IntPtr(p + 0x0AC)); // 0245A68AA4F8 0xAC InternalDynamicOS           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_FaceInfo                                = (FaceInfo)GetInt32(new IntPtr(p + 0x0B0)); // 0245A68AA518 0xB0 M_FaceInfo                  ( 0001865D05C0 ModelEnumType FaceInfo FaceInfo FaceInfo Int32 )
            value.M_FamilyNameHashCode                      = GetInt32(new IntPtr(p + 0x110)); // 0245A68AA538 0x110 M_FamilyNameHashCode        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_StyleNameHashCode                       = GetInt32(new IntPtr(p + 0x114)); // 0245A68AA558 0x114 M_StyleNameHashCode         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_GlyphTable                              = GetObjectList<Glyph>(new IntPtr(p + 0x118), ReversePrism.DataModels.Glyph.FromPointer); // 0245A68AA578 0x118 M_GlyphTable                ( 000185CDEB28 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_CharacterTable                          = GetObjectList<Character>(new IntPtr(p + 0x128), ReversePrism.DataModels.Character.FromPointer); // 0245A68AA5B8 0x128 M_CharacterTable            ( 000185CD22A8 ModelClassListType List`1<Character> List`1<Character> List<Character> Pointer )
            value.M_AtlasTexture                            = GetObject<Texture2D>(new IntPtr(p + 0x138), ReversePrism.DataModels.Texture2D.FromPointer); // 0245A68AA5F8 0x138 M_AtlasTexture              ( 000186685CB0 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_AtlasTextures                           = GetObjectList<Texture2D>(new IntPtr(p + 0x140), ReversePrism.DataModels.Texture2D.FromPointer); // 0245A68AA618 0x140 M_AtlasTextures             ( 000185CAB2C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.M_AtlasTextureIndex                       = GetInt32(new IntPtr(p + 0x148)); // 0245A68AA638 0x148 M_AtlasTextureIndex         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_IsMultiAtlasTexturesEnabled             = GetBool(new IntPtr(p + 0x14C)); // 0245A68AA658 0x14C M_IsMultiAtlasTexturesEnabled ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ClearDynamicDataOnBuild                 = GetBool(new IntPtr(p + 0x14D)); // 0245A68AA678 0x14D M_ClearDynamicDataOnBuild   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_AtlasWidth                              = GetInt32(new IntPtr(p + 0x150)); // 0245A68AA698 0x150 M_AtlasWidth                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_AtlasHeight                             = GetInt32(new IntPtr(p + 0x154)); // 0245A68AA6B8 0x154 M_AtlasHeight               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_AtlasPadding                            = GetInt32(new IntPtr(p + 0x158)); // 0245A68AA6D8 0x158 M_AtlasPadding              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_AtlasRenderMode                         = (GlyphRenderMode)GetInt32(new IntPtr(p + 0x15C)); // 0245A68AA6F8 0x15C M_AtlasRenderMode           ( 000186682B30 ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32 )
            value.M_UsedGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x160)); // 0245A68AA718 0x160 M_UsedGlyphRects            ( 000185CDF008 ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer )
            value.M_FreeGlyphRects                          = GetEnumList<GlyphRect>(new IntPtr(p + 0x168)); // 0245A68AA738 0x168 M_FreeGlyphRects            ( 000185CDF008 ModelEnumListType List`1<GlyphRect> List`1<GlyphRect> List<GlyphRect> Pointer )
            value.M_FontFeatureTable                        = GetObject<FontFeatureTable>(new IntPtr(p + 0x170), ReversePrism.DataModels.FontFeatureTable.FromPointer); // 0245A68AA758 0x170 M_FontFeatureTable          ( 0001865B0BC0 ModelClassType FontFeatureTable FontFeatureTable FontFeatureTable Pointer )
            value.M_FallbackFontAssetTable                  = GetObjectList<FontAsset>(new IntPtr(p + 0x178), ReversePrism.DataModels.FontAsset.FromPointer); // 0245A68AA778 0x178 M_FallbackFontAssetTable    ( 000185CDC5D8 ModelClassListType List`1<FontAsset> List`1<FontAsset> List<FontAsset> Pointer )
            value.M_FontWeightTable                         = GetEnumList<FontWeightPair>(new IntPtr(p + 0x180)); // 0245A68AA798 0x180 M_FontWeightTable           ( 000185B7FD10 ModelEnumListType FontWeightPair[] FontWeightPair[] List<FontWeightPair> Pointer )
            value.M_RegularStyleWeight                      = GetSingle(new IntPtr(p + 0x188)); // 0245A68AA7B8 0x188 M_RegularStyleWeight        ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_RegularStyleSpacing                     = GetSingle(new IntPtr(p + 0x18C)); // 0245A68AA7D8 0x18C M_RegularStyleSpacing       ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_BoldStyleWeight                         = GetSingle(new IntPtr(p + 0x190)); // 0245A68AA7F8 0x190 M_BoldStyleWeight           ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_BoldStyleSpacing                        = GetSingle(new IntPtr(p + 0x194)); // 0245A68AA818 0x194 M_BoldStyleSpacing          ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_ItalicStyleSlant                        = GetSByte(new IntPtr(p + 0x198)); // 0245A68AA838 0x198 M_ItalicStyleSlant          ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_TabMultiple                             = GetSByte(new IntPtr(p + 0x199)); // 0245A68AA858 0x199 M_TabMultiple               ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.IsFontAssetLookupTablesDirty              = GetBool(new IntPtr(p + 0x19A)); // 0245A68AA878 0x19A IsFontAssetLookupTablesDirty ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.K_TryAddCharacterMarker                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0245A68AA8D8 0x10 K_TryAddCharacterMarker     ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_TryAddCharactersMarker                  = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0245A68AA8F8 0x18 K_TryAddCharactersMarker    ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UpdateGlyphAdjustmentRecordsMarker      = (ProfilerMarker)GetInt32(new IntPtr(p + 0x020)); // 0245A68AA918 0x20 K_UpdateGlyphAdjustmentRecordsMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UpdateDiacriticalMarkAdjustmentRecordsMarker = (ProfilerMarker)GetInt32(new IntPtr(p + 0x028)); // 0245A68AA938 0x28 K_UpdateDiacriticalMarkAdjustmentRecordsMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ClearFontAssetDataMarker                = (ProfilerMarker)GetInt32(new IntPtr(p + 0x030)); // 0245A68AA958 0x30 K_ClearFontAssetDataMarker  ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UpdateFontAssetDataMarker               = (ProfilerMarker)GetInt32(new IntPtr(p + 0x038)); // 0245A68AA978 0x38 K_UpdateFontAssetDataMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_TryAddGlyphMarker                       = (ProfilerMarker)GetInt32(new IntPtr(p + 0x040)); // 0245A68AA998 0x40 K_TryAddGlyphMarker         ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_DefaultMaterialSuffix                   = GetString(new IntPtr(p + 0x048)); // 0245A68AA9B8 0x48 S_DefaultMaterialSuffix     ( 000186672530 ModelPrimitiveType string string string String )
            value.K_FontAssets_FontFeaturesUpdateQueue      = GetObjectList<FontAsset>(new IntPtr(p + 0x058), ReversePrism.DataModels.FontAsset.FromPointer); // 0245A68AA9F8 0x58 K_FontAssets_FontFeaturesUpdateQueue ( 000185CDC6A8 ModelClassListType List`1<FontAsset> List`1<FontAsset> List<FontAsset> Pointer )
            value.K_FontAssets_AtlasTexturesUpdateQueue     = GetObjectList<Texture2D>(new IntPtr(p + 0x068), ReversePrism.DataModels.Texture2D.FromPointer); // 0245A68AAA38 0x68 K_FontAssets_AtlasTexturesUpdateQueue ( 000185D13E48 ModelClassListType List`1<Texture2D> List`1<Texture2D> List<Texture2D> Pointer )
            value.M_GlyphsToRender                          = GetObjectList<Glyph>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.Glyph.FromPointer); // 0245A68AAA78 0x1A0 M_GlyphsToRender            ( 000185CDEAC8 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_GlyphsRendered                          = GetObjectList<Glyph>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.Glyph.FromPointer); // 0245A68AAA98 0x1A8 M_GlyphsRendered            ( 000185CDEAC8 ModelClassListType List`1<Glyph> List`1<Glyph> List<Glyph> Pointer )
            value.M_GlyphIndexList                          = GetUInt32List(new IntPtr(p + 0x1B0)); // 0245A68AAAB8 0x1B0 M_GlyphIndexList            ( 000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_GlyphIndexListNewlyAdded                = GetUInt32List(new IntPtr(p + 0x1B8)); // 0245A68AAAD8 0x1B8 M_GlyphIndexListNewlyAdded  ( 000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_GlyphsToAdd                             = GetUInt32List(new IntPtr(p + 0x1C0)); // 0245A68AAAF8 0x1C0 M_GlyphsToAdd               ( 000185D19258 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.M_CharactersToAdd                         = GetObjectList<Character>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.Character.FromPointer); // 0245A68AAB38 0x1D0 M_CharactersToAdd           ( 000185CD22A8 ModelClassListType List`1<Character> List`1<Character> List<Character> Pointer )
            value.S_MissingCharacterList                    = GetUInt32List(new IntPtr(p + 0x1E0)); // 0245A68AAB78 0x1E0 S_MissingCharacterList      ( 000185D19258 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.K_GlyphIndexArray                         = GetUInt32List(new IntPtr(p + 0x078)); // 0245A68AABB8 0x78 K_GlyphIndexArray           ( 000185B83B30 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
