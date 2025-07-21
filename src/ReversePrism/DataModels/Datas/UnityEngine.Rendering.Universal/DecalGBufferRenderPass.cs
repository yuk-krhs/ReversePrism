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
    // 108 M_DrawSystem                             ModelClassType DecalDrawGBufferSystem DecalDrawGBufferSystem DecalDrawGBufferSystem Pointer
    // 110 M_Settings                               ModelClassType DecalScreenSpaceSettings DecalScreenSpaceSettings DecalScreenSpaceSettings Pointer
    // 118 M_DeferredLights                         ModelClassType DeferredLights DeferredLights DeferredLights Pointer
    // 120 M_GbufferAttachments                     ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 128 M_DecalLayers                            ModelPrimitiveType bool bool bool Bool
    public partial class DecalGBufferRenderPass : DataModel
    {
        public FilteringSettings                        M_FilteringSettings                     { get; set; }
        public ProfilingSampler?                        M_ProfilingSampler                      { get; set; }
        public List<ShaderTagId>?                       M_ShaderTagIdList                       { get; set; }
        public DecalDrawGBufferSystem?                  M_DrawSystem                            { get; set; }
        public DecalScreenSpaceSettings?                M_Settings                              { get; set; }
        public DeferredLights?                          M_DeferredLights                        { get; set; }
        public List<RTHandle>?                          M_GbufferAttachments                    { get; set; }
        public bool                                     M_DecalLayers                           { get; set; }

        public static DecalGBufferRenderPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalGBufferRenderPass() { Pointer= p0 };

            value.M_FilteringSettings                       = (FilteringSettings)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 M_FilteringSettings         ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.M_ProfilingSampler                        = GetObject<ProfilingSampler>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0xF8 M_ProfilingSampler          ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ShaderTagIdList                         = GetEnumList<ShaderTagId>(new IntPtr(p + 0x100)); // 0x100 M_ShaderTagIdList           ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.M_DrawSystem                              = GetObject<DecalDrawGBufferSystem>(new IntPtr(p + 0x108), ReversePrism.DataModels.DecalDrawGBufferSystem.FromPointer); // 0x108 M_DrawSystem                ( ModelClassType DecalDrawGBufferSystem DecalDrawGBufferSystem DecalDrawGBufferSystem Pointer )
            value.M_Settings                                = GetObject<DecalScreenSpaceSettings>(new IntPtr(p + 0x110), ReversePrism.DataModels.DecalScreenSpaceSettings.FromPointer); // 0x110 M_Settings                  ( ModelClassType DecalScreenSpaceSettings DecalScreenSpaceSettings DecalScreenSpaceSettings Pointer )
            value.M_DeferredLights                          = GetObject<DeferredLights>(new IntPtr(p + 0x118), ReversePrism.DataModels.DeferredLights.FromPointer); // 0x118 M_DeferredLights            ( ModelClassType DeferredLights DeferredLights DeferredLights Pointer )
            value.M_GbufferAttachments                      = GetObjectList<RTHandle>(new IntPtr(p + 0x120), ReversePrism.DataModels.RTHandle.FromPointer); // 0x120 M_GbufferAttachments        ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.M_DecalLayers                             = GetBool(new IntPtr(p + 0x128)); // 0x128 M_DecalLayers               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
