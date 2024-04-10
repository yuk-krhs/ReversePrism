using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseMaterial                             00018660C4B0 ModelClassType Material Material Material Pointer
    // 018 StencilMaterial                          00018660C4B0 ModelClassType Material Material Material Pointer
    // 020 Count                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 StencilID                                0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class MaskingMaterial : DataModel
    {
        public Material?                                BaseMaterial                            { get; set; }
        public Material?                                StencilMaterial                         { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      StencilID                               { get; set; }

        public static MaskingMaterial? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaskingMaterial() { Pointer= p0 };

            value.BaseMaterial                              = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0245A4353B50 0x10 BaseMaterial                ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.StencilMaterial                           = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0245A4353B70 0x18 StencilMaterial             ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x020)); // 0245A4353B90 0x20 Count                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StencilID                                 = GetInt32(new IntPtr(p + 0x024)); // 0245A4353BB0 0x24 StencilID                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
