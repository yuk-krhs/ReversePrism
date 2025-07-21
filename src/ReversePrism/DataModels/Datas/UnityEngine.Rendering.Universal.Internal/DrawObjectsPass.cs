using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_FilteringSettings                      ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    // 0F8 M_RenderStateBlock                       ModelEnumType RenderStateBlock RenderStateBlock RenderStateBlock Int32
    // 168 M_ShaderTagIdList                        ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 170 M_ProfilerTag                            ModelPrimitiveType string string string String
    // 178 M_ProfilingSampler                       ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 180 M_IsOpaque                               ModelPrimitiveType bool bool bool Bool
    // 181 M_ShouldTransparentsReceiveShadows       ModelPrimitiveType bool bool bool Bool
    // 188 M_PassData                               ModelClassType PassData PassData PassData Pointer
    // 190 M_UseDepthPriming                        ModelPrimitiveType bool bool bool Bool
    // 000 s_DrawObjectPassDataPropID               int IL2CPP_TYPE_I4
    public partial class DrawObjectsPass : DataModel
    {
        public FilteringSettings                        M_FilteringSettings                     { get; set; }
        public RenderStateBlock                         M_RenderStateBlock                      { get; set; }
        public List<ShaderTagId>?                       M_ShaderTagIdList                       { get; set; }
        public string                                   M_ProfilerTag                           { get; set; }
        public ProfilingSampler?                        M_ProfilingSampler                      { get; set; }
        public bool                                     M_IsOpaque                              { get; set; }
        public bool                                     M_ShouldTransparentsReceiveShadows      { get; set; }
        public PassData?                                M_PassData                              { get; set; }
        public bool                                     M_UseDepthPriming                       { get; set; }

        public static DrawObjectsPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawObjectsPass() { Pointer= p0 };

            value.M_FilteringSettings                       = (FilteringSettings)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 M_FilteringSettings         ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.M_RenderStateBlock                        = (RenderStateBlock)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 M_RenderStateBlock          ( ModelEnumType RenderStateBlock RenderStateBlock RenderStateBlock Int32 )
            value.M_ShaderTagIdList                         = GetEnumList<ShaderTagId>(new IntPtr(p + 0x168)); // 0x168 M_ShaderTagIdList           ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.M_ProfilerTag                             = GetString(new IntPtr(p + 0x170)); // 0x170 M_ProfilerTag               ( ModelPrimitiveType string string string String )
            value.M_ProfilingSampler                        = GetObject<ProfilingSampler>(new IntPtr(p + 0x178), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x178 M_ProfilingSampler          ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_IsOpaque                                = GetBool(new IntPtr(p + 0x180)); // 0x180 M_IsOpaque                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShouldTransparentsReceiveShadows        = GetBool(new IntPtr(p + 0x181)); // 0x181 M_ShouldTransparentsReceiveShadows ( ModelPrimitiveType bool bool bool Bool )
            value.M_PassData                                = GetObject<PassData>(new IntPtr(p + 0x188), ReversePrism.DataModels.PassData.FromPointer); // 0x188 M_PassData                  ( ModelClassType PassData PassData PassData Pointer )
            value.M_UseDepthPriming                         = GetBool(new IntPtr(p + 0x190)); // 0x190 M_UseDepthPriming           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
