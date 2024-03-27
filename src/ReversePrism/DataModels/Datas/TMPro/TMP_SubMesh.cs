using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_fontAsset                              00018667F810 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 028 M_spriteAsset                            000186680410 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer
    // 030 M_material                               00018660BDD0 ModelClassType Material Material Material Pointer
    // 038 M_sharedMaterial                         00018660BDD0 ModelClassType Material Material Material Pointer
    // 040 M_fallbackMaterial                       00018660BDD0 ModelClassType Material Material Material Pointer
    // 048 M_fallbackSourceMaterial                 00018660BDD0 ModelClassType Material Material Material Pointer
    // 050 M_isDefaultMaterial                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 M_padding                                0001866656B0 ModelPrimitiveType float float float Single
    // 058 M_renderer                               00018665F150 ModelClassType Renderer Renderer Renderer Pointer
    // 060 M_meshFilter                             000186601410 ModelClassType MeshFilter MeshFilter MeshFilter Pointer
    // 068 M_mesh                                   0001866104D0 ModelClassType Mesh Mesh Mesh Pointer
    // 070 M_TextComponent                          000186640430 ModelClassType TextMeshPro TextMeshPro TextMeshPro Pointer
    // 078 M_isRegisteredForEvents                  0001865974C0 ModelPrimitiveType bool bool bool Bool
    public partial class TMP_SubMesh
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
            var value   = new TMP_SubMesh();

            value.M_fontAsset                               = GetObject<TMP_FontAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0270DA60C718 0x20 M_fontAsset                 ( 00018667F810 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.M_spriteAsset                             = GetObject<TMP_SpriteAsset>(new IntPtr(p + 0x028), ReversePrism.DataModels.TMP_SpriteAsset.FromPointer); // 0270DA60C738 0x28 M_spriteAsset               ( 000186680410 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer )
            value.M_material                                = GetObject<Material>(new IntPtr(p + 0x030), ReversePrism.DataModels.Material.FromPointer); // 0270DA60C758 0x30 M_material                  ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_sharedMaterial                          = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0270DA60C778 0x38 M_sharedMaterial            ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_fallbackMaterial                        = GetObject<Material>(new IntPtr(p + 0x040), ReversePrism.DataModels.Material.FromPointer); // 0270DA60C798 0x40 M_fallbackMaterial          ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_fallbackSourceMaterial                  = GetObject<Material>(new IntPtr(p + 0x048), ReversePrism.DataModels.Material.FromPointer); // 0270DA60C7B8 0x48 M_fallbackSourceMaterial    ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_isDefaultMaterial                       = GetBool(new IntPtr(p + 0x050)); // 0270DA60C7D8 0x50 M_isDefaultMaterial         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_padding                                 = GetSingle(new IntPtr(p + 0x054)); // 0270DA60C7F8 0x54 M_padding                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_renderer                                = GetObject<Renderer>(new IntPtr(p + 0x058), ReversePrism.DataModels.Renderer.FromPointer); // 0270DA60C818 0x58 M_renderer                  ( 00018665F150 ModelClassType Renderer Renderer Renderer Pointer )
            value.M_meshFilter                              = GetObject<MeshFilter>(new IntPtr(p + 0x060), ReversePrism.DataModels.MeshFilter.FromPointer); // 0270DA60C838 0x60 M_meshFilter                ( 000186601410 ModelClassType MeshFilter MeshFilter MeshFilter Pointer )
            value.M_mesh                                    = GetObject<Mesh>(new IntPtr(p + 0x068), ReversePrism.DataModels.Mesh.FromPointer); // 0270DA60C858 0x68 M_mesh                      ( 0001866104D0 ModelClassType Mesh Mesh Mesh Pointer )
            value.M_TextComponent                           = GetObject<TextMeshPro>(new IntPtr(p + 0x070), ReversePrism.DataModels.TextMeshPro.FromPointer); // 0270DA60C878 0x70 M_TextComponent             ( 000186640430 ModelClassType TextMeshPro TextMeshPro TextMeshPro Pointer )
            value.M_isRegisteredForEvents                   = GetBool(new IntPtr(p + 0x078)); // 0270DA60C898 0x78 M_isRegisteredForEvents     ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
