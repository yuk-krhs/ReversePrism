using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_fontAsset                              ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 0E8 M_spriteAsset                            ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer
    // 0F0 M_material                               ModelClassType Material Material Material Pointer
    // 0F8 M_sharedMaterial                         ModelClassType Material Material Material Pointer
    // 100 M_fallbackMaterial                       ModelClassType Material Material Material Pointer
    // 108 M_fallbackSourceMaterial                 ModelClassType Material Material Material Pointer
    // 110 M_isDefaultMaterial                      ModelPrimitiveType bool bool bool Bool
    // 114 M_padding                                ModelPrimitiveType float float float Single
    // 118 M_mesh                                   ModelClassType Mesh Mesh Mesh Pointer
    // 120 M_TextComponent                          ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 128 M_isRegisteredForEvents                  ModelPrimitiveType bool bool bool Bool
    // 129 M_materialDirty                          ModelPrimitiveType bool bool bool Bool
    // 12C M_materialReferenceIndex                 ModelPrimitiveType int int int Int32
    // 130 M_RootCanvasTransform                    ModelClassType Transform Transform Transform Pointer
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

            value.M_fontAsset                               = GetObject<TMP_FontAsset>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0xE0 M_fontAsset                 ( ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.M_spriteAsset                             = GetObject<TMP_SpriteAsset>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.TMP_SpriteAsset.FromPointer); // 0xE8 M_spriteAsset               ( ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer )
            value.M_material                                = GetObject<Material>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Material.FromPointer); // 0xF0 M_material                  ( ModelClassType Material Material Material Pointer )
            value.M_sharedMaterial                          = GetObject<Material>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Material.FromPointer); // 0xF8 M_sharedMaterial            ( ModelClassType Material Material Material Pointer )
            value.M_fallbackMaterial                        = GetObject<Material>(new IntPtr(p + 0x100), ReversePrism.DataModels.Material.FromPointer); // 0x100 M_fallbackMaterial          ( ModelClassType Material Material Material Pointer )
            value.M_fallbackSourceMaterial                  = GetObject<Material>(new IntPtr(p + 0x108), ReversePrism.DataModels.Material.FromPointer); // 0x108 M_fallbackSourceMaterial    ( ModelClassType Material Material Material Pointer )
            value.M_isDefaultMaterial                       = GetBool(new IntPtr(p + 0x110)); // 0x110 M_isDefaultMaterial         ( ModelPrimitiveType bool bool bool Bool )
            value.M_padding                                 = GetSingle(new IntPtr(p + 0x114)); // 0x114 M_padding                   ( ModelPrimitiveType float float float Single )
            value.M_mesh                                    = GetObject<Mesh>(new IntPtr(p + 0x118), ReversePrism.DataModels.Mesh.FromPointer); // 0x118 M_mesh                      ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_TextComponent                           = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x120), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x120 M_TextComponent             ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.M_isRegisteredForEvents                   = GetBool(new IntPtr(p + 0x128)); // 0x128 M_isRegisteredForEvents     ( ModelPrimitiveType bool bool bool Bool )
            value.M_materialDirty                           = GetBool(new IntPtr(p + 0x129)); // 0x129 M_materialDirty             ( ModelPrimitiveType bool bool bool Bool )
            value.M_materialReferenceIndex                  = GetInt32(new IntPtr(p + 0x12C)); // 0x12C M_materialReferenceIndex    ( ModelPrimitiveType int int int Int32 )
            value.M_RootCanvasTransform                     = GetObject<Transform>(new IntPtr(p + 0x130), ReversePrism.DataModels.Transform.FromPointer); // 0x130 M_RootCanvasTransform       ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
