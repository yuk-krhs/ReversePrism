using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 m_NameLookup                             Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 038 m_GlyphIndexLookup                       Dictionary`2<uint, int> IL2CPP_TYPE_GENERICINST
    // 040 M_Version                                000186671910 ModelPrimitiveType string string string String
    // 048 M_FaceInfo                               0001865D05C0 ModelEnumType FaceInfo FaceInfo FaceInfo Int32
    // 0A8 SpriteSheet                              00018664D720 ModelClassType Texture Texture Texture Pointer
    // 0B0 M_SpriteCharacterTable                   000185D12AC8 ModelClassListType List`1<TMP_SpriteCharacter> List`1<TMP_SpriteCharacter> List<TMP_SpriteCharacter> Pointer
    // 0B8 m_SpriteCharacterLookup                  Dictionary`2<uint, TMP_SpriteCharacter> IL2CPP_TYPE_GENERICINST
    // 0C0 M_SpriteGlyphTable                       000185D12D38 ModelClassListType List`1<TMP_SpriteGlyph> List`1<TMP_SpriteGlyph> List<TMP_SpriteGlyph> Pointer
    // 0C8 m_SpriteGlyphLookup                      Dictionary`2<uint, TMP_SpriteGlyph> IL2CPP_TYPE_GENERICINST
    // 0D0 SpriteInfoList                           000185D12618 ModelClassListType List`1<TMP_Sprite> List`1<TMP_Sprite> List<TMP_Sprite> Pointer
    // 0D8 FallbackSpriteAssets                     000185D12898 ModelClassListType List`1<TMP_SpriteAsset> List`1<TMP_SpriteAsset> List<TMP_SpriteAsset> Pointer
    // 0E0 M_IsSpriteAssetLookupTablesDirty         000186595210 ModelPrimitiveType bool bool bool Bool
    // 000 k_searchedSpriteAssets                   HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class TMP_SpriteAsset
    {
        public string                                   M_Version                               { get; set; }
        public FaceInfo                                 M_FaceInfo                              { get; set; }
        public Texture?                                 SpriteSheet                             { get; set; }
        public List<TMP_SpriteCharacter>?               M_SpriteCharacterTable                  { get; set; }
        public List<TMP_SpriteGlyph>?                   M_SpriteGlyphTable                      { get; set; }
        public List<TMP_Sprite>?                        SpriteInfoList                          { get; set; }
        public List<TMP_SpriteAsset>?                   FallbackSpriteAssets                    { get; set; }
        public bool                                     M_IsSpriteAssetLookupTablesDirty        { get; set; }

        public static TMP_SpriteAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_SpriteAsset();

            value.M_Version                                 = GetString(new IntPtr(p + 0x040)); // 0270D0DAFD38 0x40 M_Version                   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_FaceInfo                                = (FaceInfo)GetInt32(new IntPtr(p + 0x048)); // 0270D0DAFD58 0x48 M_FaceInfo                  ( 0001865D05C0 ModelEnumType FaceInfo FaceInfo FaceInfo Int32 )
            value.SpriteSheet                               = GetObject<Texture>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Texture.FromPointer); // 0270D0DAFD78 0xA8 SpriteSheet                 ( 00018664D720 ModelClassType Texture Texture Texture Pointer )
            value.M_SpriteCharacterTable                    = GetObjectList<TMP_SpriteCharacter>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.TMP_SpriteCharacter.FromPointer); // 0270D0DAFD98 0xB0 M_SpriteCharacterTable      ( 000185D12AC8 ModelClassListType List`1<TMP_SpriteCharacter> List`1<TMP_SpriteCharacter> List<TMP_SpriteCharacter> Pointer )
            value.M_SpriteGlyphTable                        = GetObjectList<TMP_SpriteGlyph>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.TMP_SpriteGlyph.FromPointer); // 0270D0DAFDD8 0xC0 M_SpriteGlyphTable          ( 000185D12D38 ModelClassListType List`1<TMP_SpriteGlyph> List`1<TMP_SpriteGlyph> List<TMP_SpriteGlyph> Pointer )
            value.SpriteInfoList                            = GetObjectList<TMP_Sprite>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.TMP_Sprite.FromPointer); // 0270D0DAFE18 0xD0 SpriteInfoList              ( 000185D12618 ModelClassListType List`1<TMP_Sprite> List`1<TMP_Sprite> List<TMP_Sprite> Pointer )
            value.FallbackSpriteAssets                      = GetObjectList<TMP_SpriteAsset>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.TMP_SpriteAsset.FromPointer); // 0270D0DAFE38 0xD8 FallbackSpriteAssets        ( 000185D12898 ModelClassListType List`1<TMP_SpriteAsset> List`1<TMP_SpriteAsset> List<TMP_SpriteAsset> Pointer )
            value.M_IsSpriteAssetLookupTablesDirty          = GetBool(new IntPtr(p + 0x0E0)); // 0270D0DAFE58 0xE0 M_IsSpriteAssetLookupTablesDirty ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
