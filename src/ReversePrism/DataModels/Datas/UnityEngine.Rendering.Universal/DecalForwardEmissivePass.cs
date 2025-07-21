using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_FilteringSettings                      ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    // 0F8 M_ProfilingSampler                       ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 100 M_ShaderTagIdList                        ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 108 M_DrawSystem                             ModelClassType DecalDrawFowardEmissiveSystem DecalDrawFowardEmissiveSystem DecalDrawFowardEmissiveSystem Pointer
    public partial class DecalForwardEmissivePass : DataModel
    {
        public FilteringSettings                        M_FilteringSettings                     { get; set; }
        public ProfilingSampler?                        M_ProfilingSampler                      { get; set; }
        public List<ShaderTagId>?                       M_ShaderTagIdList                       { get; set; }
        public DecalDrawFowardEmissiveSystem?           M_DrawSystem                            { get; set; }

        public static DecalForwardEmissivePass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalForwardEmissivePass() { Pointer= p0 };

            value.M_FilteringSettings                       = (FilteringSettings)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 M_FilteringSettings         ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.M_ProfilingSampler                        = GetObject<ProfilingSampler>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0xF8 M_ProfilingSampler          ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ShaderTagIdList                         = GetEnumList<ShaderTagId>(new IntPtr(p + 0x100)); // 0x100 M_ShaderTagIdList           ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.M_DrawSystem                              = GetObject<DecalDrawFowardEmissiveSystem>(new IntPtr(p + 0x108), ReversePrism.DataModels.DecalDrawFowardEmissiveSystem.FromPointer); // 0x108 M_DrawSystem                ( ModelClassType DecalDrawFowardEmissiveSystem DecalDrawFowardEmissiveSystem DecalDrawFowardEmissiveSystem Pointer )

            return value;
        }
    }
}
