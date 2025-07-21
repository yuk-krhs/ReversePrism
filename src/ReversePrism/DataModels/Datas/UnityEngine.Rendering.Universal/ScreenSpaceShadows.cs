using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Shader                                 ModelClassType Shader Shader Shader Pointer
    // 028 M_Settings                               ModelClassType ScreenSpaceShadowsSettings ScreenSpaceShadowsSettings ScreenSpaceShadowsSettings Pointer
    // 030 M_Material                               ModelClassType Material Material Material Pointer
    // 038 M_SSShadowsPass                          ModelClassType ScreenSpaceShadowsPass ScreenSpaceShadowsPass ScreenSpaceShadowsPass Pointer
    // 040 M_SSShadowsPostPass                      ModelClassType ScreenSpaceShadowsPostPass ScreenSpaceShadowsPostPass ScreenSpaceShadowsPostPass Pointer
    // 000 k_ShaderName                             string IL2CPP_TYPE_STRING
    public partial class ScreenSpaceShadows : DataModel
    {
        public Shader?                                  M_Shader                                { get; set; }
        public ScreenSpaceShadowsSettings?              M_Settings                              { get; set; }
        public Material?                                M_Material                              { get; set; }
        public ScreenSpaceShadowsPass?                  M_SSShadowsPass                         { get; set; }
        public ScreenSpaceShadowsPostPass?              M_SSShadowsPostPass                     { get; set; }

        public static ScreenSpaceShadows? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenSpaceShadows() { Pointer= p0 };

            value.M_Shader                                  = GetObject<Shader>(new IntPtr(p + 0x020), ReversePrism.DataModels.Shader.FromPointer); // 0x20 M_Shader                    ( ModelClassType Shader Shader Shader Pointer )
            value.M_Settings                                = GetObject<ScreenSpaceShadowsSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScreenSpaceShadowsSettings.FromPointer); // 0x28 M_Settings                  ( ModelClassType ScreenSpaceShadowsSettings ScreenSpaceShadowsSettings ScreenSpaceShadowsSettings Pointer )
            value.M_Material                                = GetObject<Material>(new IntPtr(p + 0x030), ReversePrism.DataModels.Material.FromPointer); // 0x30 M_Material                  ( ModelClassType Material Material Material Pointer )
            value.M_SSShadowsPass                           = GetObject<ScreenSpaceShadowsPass>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScreenSpaceShadowsPass.FromPointer); // 0x38 M_SSShadowsPass             ( ModelClassType ScreenSpaceShadowsPass ScreenSpaceShadowsPass ScreenSpaceShadowsPass Pointer )
            value.M_SSShadowsPostPass                       = GetObject<ScreenSpaceShadowsPostPass>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScreenSpaceShadowsPostPass.FromPointer); // 0x40 M_SSShadowsPostPass         ( ModelClassType ScreenSpaceShadowsPostPass ScreenSpaceShadowsPostPass ScreenSpaceShadowsPostPass Pointer )

            return value;
        }
    }
}
