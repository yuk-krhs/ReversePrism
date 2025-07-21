using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reference                                ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer
    // 018 Hdr                                      ModelClassType Material Material Material Pointer
    // 020 Ldr                                      ModelClassType Material Material Material Pointer
    public partial class MaterialPresetItem : DataModel
    {
        public MeshRenderer?                            Reference                               { get; set; }
        public Material?                                Hdr                                     { get; set; }
        public Material?                                Ldr                                     { get; set; }

        public static MaterialPresetItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaterialPresetItem() { Pointer= p0 };

            value.Reference                                 = GetObject<MeshRenderer>(new IntPtr(p + 0x010), ReversePrism.DataModels.MeshRenderer.FromPointer); // 0x10 Reference                   ( ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer )
            value.Hdr                                       = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0x18 Hdr                         ( ModelClassType Material Material Material Pointer )
            value.Ldr                                       = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0x20 Ldr                         ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
