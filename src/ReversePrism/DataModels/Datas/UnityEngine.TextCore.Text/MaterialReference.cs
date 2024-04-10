using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 FontAsset                                0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer
    // 020 SpriteAsset                              00018666CC70 ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer
    // 028 Material                                 00018660C4B0 ModelClassType Material Material Material Pointer
    // 030 IsDefaultMaterial                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 031 IsFallbackMaterial                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 038 FallbackMaterial                         00018660C4B0 ModelClassType Material Material Material Pointer
    // 040 Padding                                  000186666050 ModelPrimitiveType float float float Single
    // 044 ReferenceCount                           0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0245A68AC2F0 0x10 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FontAsset                                 = GetObject<FontAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.FontAsset.FromPointer); // 0245A68AC310 0x18 FontAsset                   ( 0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer )
            value.SpriteAsset                               = GetObject<SpriteAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteAsset.FromPointer); // 0245A68AC330 0x20 SpriteAsset                 ( 00018666CC70 ModelClassType SpriteAsset SpriteAsset SpriteAsset Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0245A68AC350 0x28 Material                    ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.IsDefaultMaterial                         = GetBool(new IntPtr(p + 0x030)); // 0245A68AC370 0x30 IsDefaultMaterial           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsFallbackMaterial                        = GetBool(new IntPtr(p + 0x031)); // 0245A68AC390 0x31 IsFallbackMaterial          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FallbackMaterial                          = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0245A68AC3B0 0x38 FallbackMaterial            ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.Padding                                   = GetSingle(new IntPtr(p + 0x040)); // 0245A68AC3D0 0x40 Padding                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.ReferenceCount                            = GetInt32(new IntPtr(p + 0x044)); // 0245A68AC3F0 0x44 ReferenceCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
