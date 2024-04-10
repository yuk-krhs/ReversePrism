using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 m_NameLookup                             Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 040 m_GlyphIndexLookup                       Dictionary`2<uint, int> IL2CPP_TYPE_GENERICINST
    // 048 M_FaceInfo                               0001865D05C0 ModelEnumType FaceInfo FaceInfo FaceInfo Int32
    // 0A8 M_SpriteAtlasTexture                     00018664D240 ModelClassType Texture Texture Texture Pointer
    // 0B0 M_SpriteCharacterTable                   000185D0BCF8 ModelClassListType List`1<SpriteCharacter> List`1<SpriteCharacter> List<SpriteCharacter> Pointer
    // 0B8 m_SpriteCharacterLookup                  Dictionary`2<uint, SpriteCharacter> IL2CPP_TYPE_GENERICINST
    // 0C0 M_SpriteGlyphTable                       000185D0BF68 ModelClassListType List`1<SpriteGlyph> List`1<SpriteGlyph> List<SpriteGlyph> Pointer
    // 0C8 m_SpriteGlyphLookup                      Dictionary`2<uint, SpriteGlyph> IL2CPP_TYPE_GENERICINST
    // 0D0 FallbackSpriteAssets                     000185D0BA98 ModelClassListType List`1<SpriteAsset> List`1<SpriteAsset> List<SpriteAsset> Pointer
    // 0D8 M_IsSpriteAssetLookupTablesDirty         000186595210 ModelPrimitiveType bool bool bool Bool
    // 000 k_searchedSpriteAssets                   HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class SpriteAsset : DataModel
    {
        public FaceInfo                                 M_FaceInfo                              { get; set; }
        public Texture?                                 M_SpriteAtlasTexture                    { get; set; }
        public List<SpriteCharacter>?                   M_SpriteCharacterTable                  { get; set; }
        public List<SpriteGlyph>?                       M_SpriteGlyphTable                      { get; set; }
        public List<SpriteAsset>?                       FallbackSpriteAssets                    { get; set; }
        public bool                                     M_IsSpriteAssetLookupTablesDirty        { get; set; }

        public static SpriteAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteAsset() { Pointer= p0 };

            value.M_FaceInfo                                = (FaceInfo)GetInt32(new IntPtr(p + 0x048)); // 0245A68AD3B8 0x48 M_FaceInfo                  ( 0001865D05C0 ModelEnumType FaceInfo FaceInfo FaceInfo Int32 )
            value.M_SpriteAtlasTexture                      = GetObject<Texture>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Texture.FromPointer); // 0245A68AD3D8 0xA8 M_SpriteAtlasTexture        ( 00018664D240 ModelClassType Texture Texture Texture Pointer )
            value.M_SpriteCharacterTable                    = GetObjectList<SpriteCharacter>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SpriteCharacter.FromPointer); // 0245A68AD3F8 0xB0 M_SpriteCharacterTable      ( 000185D0BCF8 ModelClassListType List`1<SpriteCharacter> List`1<SpriteCharacter> List<SpriteCharacter> Pointer )
            value.M_SpriteGlyphTable                        = GetObjectList<SpriteGlyph>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.SpriteGlyph.FromPointer); // 0245A68AD438 0xC0 M_SpriteGlyphTable          ( 000185D0BF68 ModelClassListType List`1<SpriteGlyph> List`1<SpriteGlyph> List<SpriteGlyph> Pointer )
            value.FallbackSpriteAssets                      = GetObjectList<SpriteAsset>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SpriteAsset.FromPointer); // 0245A68AD478 0xD0 FallbackSpriteAssets        ( 000185D0BA98 ModelClassListType List`1<SpriteAsset> List`1<SpriteAsset> List<SpriteAsset> Pointer )
            value.M_IsSpriteAssetLookupTablesDirty          = GetBool(new IntPtr(p + 0x0D8)); // 0245A68AD498 0xD8 M_IsSpriteAssetLookupTablesDirty ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
