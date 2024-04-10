using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Character                                0001865A8F00 ModelClassType Character Character Character Pointer
    // 018 FontAsset                                0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer
    // 020 Material                                 00018660C4B0 ModelClassType Material Material Material Pointer
    // 028 MaterialIndex                            0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class SpecialCharacter : DataModel
    {
        public Character?                               Character                               { get; set; }
        public FontAsset?                               FontAsset                               { get; set; }
        public Material?                                Material                                { get; set; }
        public int                                      MaterialIndex                           { get; set; }

        public static SpecialCharacter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialCharacter() { Pointer= p0 };

            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x010), ReversePrism.DataModels.Character.FromPointer); // 0245A68B3708 0x10 Character                   ( 0001865A8F00 ModelClassType Character Character Character Pointer )
            value.FontAsset                                 = GetObject<FontAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.FontAsset.FromPointer); // 0245A68B3728 0x18 FontAsset                   ( 0001865D4D50 ModelClassType FontAsset FontAsset FontAsset Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0245A68B3748 0x20 Material                    ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.MaterialIndex                             = GetInt32(new IntPtr(p + 0x028)); // 0245A68B3768 0x28 MaterialIndex               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
