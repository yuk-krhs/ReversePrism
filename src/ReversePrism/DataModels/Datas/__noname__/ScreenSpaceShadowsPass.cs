using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_ProfilerTag                            string IL2CPP_TYPE_STRING
    // 008 m_ProfilingSampler                       ProfilingSampler IL2CPP_TYPE_CLASS
    // 0E0 M_Material                               ModelClassType Material Material Material Pointer
    // 0E8 M_CurrentSettings                        ModelClassType ScreenSpaceShadowsSettings ScreenSpaceShadowsSettings ScreenSpaceShadowsSettings Pointer
    // 0F0 M_RenderTarget                           ModelClassType RTHandle RTHandle RTHandle Pointer
    public partial class ScreenSpaceShadowsPass : DataModel
    {
        public Material?                                M_Material                              { get; set; }
        public ScreenSpaceShadowsSettings?              M_CurrentSettings                       { get; set; }
        public RTHandle?                                M_RenderTarget                          { get; set; }

        public static ScreenSpaceShadowsPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenSpaceShadowsPass() { Pointer= p0 };

            value.M_Material                                = GetObject<Material>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Material.FromPointer); // 0xE0 M_Material                  ( ModelClassType Material Material Material Pointer )
            value.M_CurrentSettings                         = GetObject<ScreenSpaceShadowsSettings>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ScreenSpaceShadowsSettings.FromPointer); // 0xE8 M_CurrentSettings           ( ModelClassType ScreenSpaceShadowsSettings ScreenSpaceShadowsSettings ScreenSpaceShadowsSettings Pointer )
            value.M_RenderTarget                            = GetObject<RTHandle>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.RTHandle.FromPointer); // 0xF0 M_RenderTarget              ( ModelClassType RTHandle RTHandle RTHandle Pointer )

            return value;
        }
    }
}
