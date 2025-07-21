using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 RenderQueueType                          ModelEnumType RenderQueueType RenderQueueType RenderQueueType Int32
    // 0E4 M_FilteringSettings                      ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    // 100 M_CameraSettings                         ModelClassType CustomCameraSettings CustomCameraSettings CustomCameraSettings Pointer
    // 108 M_ProfilerTag                            ModelPrimitiveType string string string String
    // 110 M_ProfilingSampler                       ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 118 OverrideMaterial                         ModelClassType Material Material Material Pointer
    // 120 OverrideMaterialPassIndex                ModelPrimitiveType int int int Int32
    // 128 OverrideShader                           ModelClassType Shader Shader Shader Pointer
    // 130 OverrideShaderPassIndex                  ModelPrimitiveType int int int Int32
    // 138 M_ShaderTagIdList                        ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 140 M_RenderStateBlock                       ModelEnumType RenderStateBlock RenderStateBlock RenderStateBlock Int32
    public partial class RenderObjectsPass : DataModel
    {
        public RenderQueueType                          RenderQueueType                         { get; set; }
        public FilteringSettings                        M_FilteringSettings                     { get; set; }
        public CustomCameraSettings?                    M_CameraSettings                        { get; set; }
        public string                                   M_ProfilerTag                           { get; set; }
        public ProfilingSampler?                        M_ProfilingSampler                      { get; set; }
        public Material?                                OverrideMaterial                        { get; set; }
        public int                                      OverrideMaterialPassIndex               { get; set; }
        public Shader?                                  OverrideShader                          { get; set; }
        public int                                      OverrideShaderPassIndex                 { get; set; }
        public List<ShaderTagId>?                       M_ShaderTagIdList                       { get; set; }
        public RenderStateBlock                         M_RenderStateBlock                      { get; set; }

        public static RenderObjectsPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderObjectsPass() { Pointer= p0 };

            value.RenderQueueType                           = (RenderQueueType)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 RenderQueueType             ( ModelEnumType RenderQueueType RenderQueueType RenderQueueType Int32 )
            value.M_FilteringSettings                       = (FilteringSettings)GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 M_FilteringSettings         ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.M_CameraSettings                          = GetObject<CustomCameraSettings>(new IntPtr(p + 0x100), ReversePrism.DataModels.CustomCameraSettings.FromPointer); // 0x100 M_CameraSettings            ( ModelClassType CustomCameraSettings CustomCameraSettings CustomCameraSettings Pointer )
            value.M_ProfilerTag                             = GetString(new IntPtr(p + 0x108)); // 0x108 M_ProfilerTag               ( ModelPrimitiveType string string string String )
            value.M_ProfilingSampler                        = GetObject<ProfilingSampler>(new IntPtr(p + 0x110), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x110 M_ProfilingSampler          ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.OverrideMaterial                          = GetObject<Material>(new IntPtr(p + 0x118), ReversePrism.DataModels.Material.FromPointer); // 0x118 OverrideMaterial            ( ModelClassType Material Material Material Pointer )
            value.OverrideMaterialPassIndex                 = GetInt32(new IntPtr(p + 0x120)); // 0x120 OverrideMaterialPassIndex   ( ModelPrimitiveType int int int Int32 )
            value.OverrideShader                            = GetObject<Shader>(new IntPtr(p + 0x128), ReversePrism.DataModels.Shader.FromPointer); // 0x128 OverrideShader              ( ModelClassType Shader Shader Shader Pointer )
            value.OverrideShaderPassIndex                   = GetInt32(new IntPtr(p + 0x130)); // 0x130 OverrideShaderPassIndex     ( ModelPrimitiveType int int int Int32 )
            value.M_ShaderTagIdList                         = GetEnumList<ShaderTagId>(new IntPtr(p + 0x138)); // 0x138 M_ShaderTagIdList           ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.M_RenderStateBlock                        = (RenderStateBlock)GetInt32(new IntPtr(p + 0x140)); // 0x140 M_RenderStateBlock          ( ModelEnumType RenderStateBlock RenderStateBlock RenderStateBlock Int32 )

            return value;
        }
    }
}
