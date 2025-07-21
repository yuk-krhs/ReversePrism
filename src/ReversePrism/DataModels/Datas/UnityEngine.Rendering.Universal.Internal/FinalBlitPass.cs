using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_Source                                 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0E8 M_BlitMaterial                           ModelClassType Material Material Material Pointer
    // 0F0 M_BlitHDRMaterial                        ModelClassType Material Material Material Pointer
    public partial class FinalBlitPass : DataModel
    {
        public RTHandle?                                M_Source                                { get; set; }
        public Material?                                M_BlitMaterial                          { get; set; }
        public Material?                                M_BlitHDRMaterial                       { get; set; }

        public static FinalBlitPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinalBlitPass() { Pointer= p0 };

            value.M_Source                                  = GetObject<RTHandle>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE0 M_Source                    ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_BlitMaterial                            = GetObject<Material>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Material.FromPointer); // 0xE8 M_BlitMaterial              ( ModelClassType Material Material Material Pointer )
            value.M_BlitHDRMaterial                         = GetObject<Material>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Material.FromPointer); // 0xF0 M_BlitHDRMaterial           ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
