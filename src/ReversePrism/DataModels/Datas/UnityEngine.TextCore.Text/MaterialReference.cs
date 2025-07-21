using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    ModelPrimitiveType int int int Int32
    // 018 FontAsset                                ModelClassType FontAsset FontAsset FontAsset Pointer
    // 020 SpriteAsset                              ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer
    // 028 Material                                 ModelClassType Material Material Material Pointer
    // 030 IsDefaultMaterial                        ModelPrimitiveType bool bool bool Bool
    // 031 IsFallbackMaterial                       ModelPrimitiveType bool bool bool Bool
    // 038 FallbackMaterial                         ModelClassType Material Material Material Pointer
    // 040 Padding                                  ModelPrimitiveType float float float Single
    // 044 ReferenceCount                           ModelPrimitiveType int int int Int32
    public partial class MaterialReference : DataModel
    {
        public int                                      Index                                   { get; set; }
        public FontAsset?                               FontAsset                               { get; set; }
        public SpriteAsset?                             SpriteAsset                             { get; set; }
        public Material?                                Material                                { get; set; }
        public bool                                     IsDefaultMaterial                       { get; set; }
        public bool                                     IsFallbackMaterial                      { get; set; }
        public Material?                                FallbackMaterial                        { get; set; }
        public float                                    Padding                                 { get; set; }
        public int                                      ReferenceCount                          { get; set; }

        public static MaterialReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaterialReference() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Index                       ( ModelPrimitiveType int int int Int32 )
            value.FontAsset                                 = GetObject<FontAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.FontAsset.FromPointer); // 0x18 FontAsset                   ( ModelClassType FontAsset FontAsset FontAsset Pointer )
            value.SpriteAsset                               = GetObject<SpriteAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteAsset.FromPointer); // 0x20 SpriteAsset                 ( ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 Material                    ( ModelClassType Material Material Material Pointer )
            value.IsDefaultMaterial                         = GetBool(new IntPtr(p + 0x030)); // 0x30 IsDefaultMaterial           ( ModelPrimitiveType bool bool bool Bool )
            value.IsFallbackMaterial                        = GetBool(new IntPtr(p + 0x031)); // 0x31 IsFallbackMaterial          ( ModelPrimitiveType bool bool bool Bool )
            value.FallbackMaterial                          = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0x38 FallbackMaterial            ( ModelClassType Material Material Material Pointer )
            value.Padding                                   = GetSingle(new IntPtr(p + 0x040)); // 0x40 Padding                     ( ModelPrimitiveType float float float Single )
            value.ReferenceCount                            = GetInt32(new IntPtr(p + 0x044)); // 0x44 ReferenceCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
