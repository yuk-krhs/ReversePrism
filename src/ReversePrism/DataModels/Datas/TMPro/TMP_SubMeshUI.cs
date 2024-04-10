using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_fontAsset                              00018667F810 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 0E8 M_spriteAsset                            000186680410 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer
    // 0F0 M_material                               00018660BDD0 ModelClassType Material Material Material Pointer
    // 0F8 M_sharedMaterial                         00018660BDD0 ModelClassType Material Material Material Pointer
    // 100 M_fallbackMaterial                       00018660BDD0 ModelClassType Material Material Material Pointer
    // 108 M_fallbackSourceMaterial                 00018660BDD0 ModelClassType Material Material Material Pointer
    // 110 M_isDefaultMaterial                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 114 M_padding                                0001866656B0 ModelPrimitiveType float float float Single
    // 118 M_mesh                                   0001866104D0 ModelClassType Mesh Mesh Mesh Pointer
    // 120 M_TextComponent                          0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 128 M_isRegisteredForEvents                  0001865974C0 ModelPrimitiveType bool bool bool Bool
    // 129 M_materialDirty                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 12C M_materialReferenceIndex                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 130 M_RootCanvasTransform                    0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class TMP_SubMeshUI : DataModel
    {
        public TMP_FontAsset?                           M_fontAsset                             { get; set; }
        public TMP_SpriteAsset?                         M_spriteAsset                           { get; set; }
        public Material?                                M_material                              { get; set; }
        public Material?                                M_sharedMaterial                        { get; set; }
        public Material?                                M_fallbackMaterial                      { get; set; }
        public Material?                                M_fallbackSourceMaterial                { get; set; }
        public bool                                     M_isDefaultMaterial                     { get; set; }
        public float                                    M_padding                               { get; set; }
        public Mesh?                                    M_mesh                                  { get; set; }
        public TextMeshProUGUI?                         M_TextComponent                         { get; set; }
        public bool                                     M_isRegisteredForEvents                 { get; set; }
        public bool                                     M_materialDirty                         { get; set; }
        public int                                      M_materialReferenceIndex                { get; set; }
        public Transform?                               M_RootCanvasTransform                   { get; set; }

        public static TMP_SubMeshUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_SubMeshUI() { Pointer= p0 };

            value.M_fontAsset                               = GetObject<TMP_FontAsset>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 02466094F388 0xE0 M_fontAsset                 ( 00018667F810 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.M_spriteAsset                             = GetObject<TMP_SpriteAsset>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.TMP_SpriteAsset.FromPointer); // 02466094F3A8 0xE8 M_spriteAsset               ( 000186680410 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer )
            value.M_material                                = GetObject<Material>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Material.FromPointer); // 02466094F3C8 0xF0 M_material                  ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_sharedMaterial                          = GetObject<Material>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Material.FromPointer); // 02466094F3E8 0xF8 M_sharedMaterial            ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_fallbackMaterial                        = GetObject<Material>(new IntPtr(p + 0x100), ReversePrism.DataModels.Material.FromPointer); // 02466094F408 0x100 M_fallbackMaterial          ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_fallbackSourceMaterial                  = GetObject<Material>(new IntPtr(p + 0x108), ReversePrism.DataModels.Material.FromPointer); // 02466094F428 0x108 M_fallbackSourceMaterial    ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_isDefaultMaterial                       = GetBool(new IntPtr(p + 0x110)); // 02466094F448 0x110 M_isDefaultMaterial         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_padding                                 = GetSingle(new IntPtr(p + 0x114)); // 02466094F468 0x114 M_padding                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_mesh                                    = GetObject<Mesh>(new IntPtr(p + 0x118), ReversePrism.DataModels.Mesh.FromPointer); // 02466094F488 0x118 M_mesh                      ( 0001866104D0 ModelClassType Mesh Mesh Mesh Pointer )
            value.M_TextComponent                           = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x120), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 02466094F4A8 0x120 M_TextComponent             ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.M_isRegisteredForEvents                   = GetBool(new IntPtr(p + 0x128)); // 02466094F4C8 0x128 M_isRegisteredForEvents     ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )
            value.M_materialDirty                           = GetBool(new IntPtr(p + 0x129)); // 02466094F4E8 0x129 M_materialDirty             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_materialReferenceIndex                  = GetInt32(new IntPtr(p + 0x12C)); // 02466094F508 0x12C M_materialReferenceIndex    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_RootCanvasTransform                     = GetObject<Transform>(new IntPtr(p + 0x130), ReversePrism.DataModels.Transform.FromPointer); // 02466094F528 0x130 M_RootCanvasTransform       ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
