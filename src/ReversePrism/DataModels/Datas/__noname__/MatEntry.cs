using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseMat                                  00018660C4B0 ModelClassType Material Material Material Pointer
    // 018 CustomMat                                00018660C4B0 ModelClassType Material Material Material Pointer
    // 020 Count                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 Texture                                  00018664D720 ModelClassType Texture Texture Texture Pointer
    // 030 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class MatEntry : DataModel
    {
        public Material?                                BaseMat                                 { get; set; }
        public Material?                                CustomMat                               { get; set; }
        public int                                      Count                                   { get; set; }
        public Texture?                                 Texture                                 { get; set; }
        public int                                      Id                                      { get; set; }

        public static MatEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MatEntry() { Pointer= p0 };

            value.BaseMat                                   = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 02466BDAE3B8 0x10 BaseMat                     ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.CustomMat                                 = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 02466BDAE3D8 0x18 CustomMat                   ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x020)); // 02466BDAE3F8 0x20 Count                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Texture                                   = GetObject<Texture>(new IntPtr(p + 0x028), ReversePrism.DataModels.Texture.FromPointer); // 02466BDAE418 0x28 Texture                     ( 00018664D720 ModelClassType Texture Texture Texture Pointer )
            value.Id                                        = GetInt32(new IntPtr(p + 0x030)); // 02466BDAE438 0x30 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
