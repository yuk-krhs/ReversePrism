using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_fontAsset                              ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 028 M_spriteAsset                            ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer
    // 030 M_material                               ModelClassType Material Material Material Pointer
    // 038 M_sharedMaterial                         ModelClassType Material Material Material Pointer
    // 040 M_fallbackMaterial                       ModelClassType Material Material Material Pointer
    // 048 M_fallbackSourceMaterial                 ModelClassType Material Material Material Pointer
    // 050 M_isDefaultMaterial                      ModelPrimitiveType bool bool bool Bool
    // 054 M_padding                                ModelPrimitiveType float float float Single
    // 058 M_renderer                               ModelClassType Renderer Renderer Renderer Pointer
    // 060 M_meshFilter                             ModelClassType MeshFilter MeshFilter MeshFilter Pointer
    // 068 M_mesh                                   ModelClassType Mesh Mesh Mesh Pointer
    // 070 M_TextComponent                          ModelClassType TextMeshPro TextMeshPro TextMeshPro Pointer
    // 078 M_isRegisteredForEvents                  ModelPrimitiveType bool bool bool Bool
    public partial class TMP_SubMesh : DataModel
    {
        public TMP_FontAsset?                           M_fontAsset                             { get; set; }
        public TMP_SpriteAsset?                         M_spriteAsset                           { get; set; }
        public Material?                                M_material                              { get; set; }
        public Material?                                M_sharedMaterial                        { get; set; }
        public Material?                                M_fallbackMaterial                      { get; set; }
        public Material?                                M_fallbackSourceMaterial                { get; set; }
        public bool                                     M_isDefaultMaterial                     { get; set; }
        public float                                    M_padding                               { get; set; }
        public Renderer?                                M_renderer                              { get; set; }
        public MeshFilter?                              M_meshFilter                            { get; set; }
        public Mesh?                                    M_mesh                                  { get; set; }
        public TextMeshPro?                             M_TextComponent                         { get; set; }
        public bool                                     M_isRegisteredForEvents                 { get; set; }

        public static TMP_SubMesh? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_SubMesh() { Pointer= p0 };

            value.M_fontAsset                               = GetObject<TMP_FontAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0x20 M_fontAsset                 ( ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.M_spriteAsset                             = GetObject<TMP_SpriteAsset>(new IntPtr(p + 0x028), ReversePrism.DataModels.TMP_SpriteAsset.FromPointer); // 0x28 M_spriteAsset               ( ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer )
            value.M_material                                = GetObject<Material>(new IntPtr(p + 0x030), ReversePrism.DataModels.Material.FromPointer); // 0x30 M_material                  ( ModelClassType Material Material Material Pointer )
            value.M_sharedMaterial                          = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0x38 M_sharedMaterial            ( ModelClassType Material Material Material Pointer )
            value.M_fallbackMaterial                        = GetObject<Material>(new IntPtr(p + 0x040), ReversePrism.DataModels.Material.FromPointer); // 0x40 M_fallbackMaterial          ( ModelClassType Material Material Material Pointer )
            value.M_fallbackSourceMaterial                  = GetObject<Material>(new IntPtr(p + 0x048), ReversePrism.DataModels.Material.FromPointer); // 0x48 M_fallbackSourceMaterial    ( ModelClassType Material Material Material Pointer )
            value.M_isDefaultMaterial                       = GetBool(new IntPtr(p + 0x050)); // 0x50 M_isDefaultMaterial         ( ModelPrimitiveType bool bool bool Bool )
            value.M_padding                                 = GetSingle(new IntPtr(p + 0x054)); // 0x54 M_padding                   ( ModelPrimitiveType float float float Single )
            value.M_renderer                                = GetObject<Renderer>(new IntPtr(p + 0x058), ReversePrism.DataModels.Renderer.FromPointer); // 0x58 M_renderer                  ( ModelClassType Renderer Renderer Renderer Pointer )
            value.M_meshFilter                              = GetObject<MeshFilter>(new IntPtr(p + 0x060), ReversePrism.DataModels.MeshFilter.FromPointer); // 0x60 M_meshFilter                ( ModelClassType MeshFilter MeshFilter MeshFilter Pointer )
            value.M_mesh                                    = GetObject<Mesh>(new IntPtr(p + 0x068), ReversePrism.DataModels.Mesh.FromPointer); // 0x68 M_mesh                      ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_TextComponent                           = GetObject<TextMeshPro>(new IntPtr(p + 0x070), ReversePrism.DataModels.TextMeshPro.FromPointer); // 0x70 M_TextComponent             ( ModelClassType TextMeshPro TextMeshPro TextMeshPro Pointer )
            value.M_isRegisteredForEvents                   = GetBool(new IntPtr(p + 0x078)); // 0x78 M_isRegisteredForEvents     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
