using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 FontAsset                                00018667FCE0 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer
    // 020 SpriteAsset                              0001866808F0 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer
    // 028 Material                                 00018660C4B0 ModelClassType Material Material Material Pointer
    // 030 IsDefaultMaterial                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 031 IsFallbackMaterial                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 038 FallbackMaterial                         00018660C4B0 ModelClassType Material Material Material Pointer
    // 040 Padding                                  000186666050 ModelPrimitiveType float float float Single
    // 044 ReferenceCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class MaterialReference
    {
        public int                                      Index                                   { get; set; }
        public TMP_FontAsset?                           FontAsset                               { get; set; }
        public TMP_SpriteAsset?                         SpriteAsset                             { get; set; }
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
            var value   = new MaterialReference();

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D0955CE0 0x10 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FontAsset                                 = GetObject<TMP_FontAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0270D0955D00 0x18 FontAsset                   ( 00018667FCE0 ModelClassType TMP_FontAsset TMP_FontAsset TMP_FontAsset Pointer )
            value.SpriteAsset                               = GetObject<TMP_SpriteAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TMP_SpriteAsset.FromPointer); // 0270D0955D20 0x20 SpriteAsset                 ( 0001866808F0 ModelClassType TMP_SpriteAsset TMP_SpriteAsset TMP_SpriteAsset Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0270D0955D40 0x28 Material                    ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.IsDefaultMaterial                         = GetBool(new IntPtr(p + 0x030)); // 0270D0955D60 0x30 IsDefaultMaterial           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsFallbackMaterial                        = GetBool(new IntPtr(p + 0x031)); // 0270D0955D80 0x31 IsFallbackMaterial          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FallbackMaterial                          = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0270D0955DA0 0x38 FallbackMaterial            ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.Padding                                   = GetSingle(new IntPtr(p + 0x040)); // 0270D0955DC0 0x40 Padding                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.ReferenceCount                            = GetInt32(new IntPtr(p + 0x044)); // 0270D0955DE0 0x44 ReferenceCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
