using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Lit                                      ModelClassType Material Material Material Pointer
    // 018 ParticleLit                              ModelClassType Material Material Material Pointer
    // 020 TerrainLit                               ModelClassType Material Material Material Pointer
    // 028 Decal                                    ModelClassType Material Material Material Pointer
    public partial class MaterialResources : DataModel
    {
        public Material?                                Lit                                     { get; set; }
        public Material?                                ParticleLit                             { get; set; }
        public Material?                                TerrainLit                              { get; set; }
        public Material?                                Decal                                   { get; set; }

        public static MaterialResources? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaterialResources() { Pointer= p0 };

            value.Lit                                       = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0x10 Lit                         ( ModelClassType Material Material Material Pointer )
            value.ParticleLit                               = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0x18 ParticleLit                 ( ModelClassType Material Material Material Pointer )
            value.TerrainLit                                = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0x20 TerrainLit                  ( ModelClassType Material Material Material Pointer )
            value.Decal                                     = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 Decal                       ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
