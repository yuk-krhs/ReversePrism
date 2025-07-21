using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_DBufferNames                           string[] IL2CPP_TYPE_SZARRAY
    // 008 s_DBufferDepthName                       string IL2CPP_TYPE_STRING
    // 0E0 M_DrawSystem                             ModelClassType DecalDrawDBufferSystem DecalDrawDBufferSystem DecalDrawDBufferSystem Pointer
    // 0E8 M_Settings                               ModelClassType DBufferSettings DBufferSettings DBufferSettings Pointer
    // 0F0 M_DBufferClear                           ModelClassType Material Material Material Pointer
    // 0F8 M_FilteringSettings                      ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    // 110 M_ShaderTagIdList                        ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 118 M_ProfilingSampler                       ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 120 M_DBufferClearSampler                    ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 128 M_DecalLayers                            ModelPrimitiveType bool bool bool Bool
    // 130 M_DBufferDepth                           ModelClassType RTHandle RTHandle RTHandle Pointer
    // 138 DBufferColorHandles                      ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 140 DepthHandle                              ModelClassType RTHandle RTHandle RTHandle Pointer
    public partial class DBufferRenderPass : DataModel
    {
        public DecalDrawDBufferSystem?                  M_DrawSystem                            { get; set; }
        public DBufferSettings?                         M_Settings                              { get; set; }
        public Material?                                M_DBufferClear                          { get; set; }
        public FilteringSettings                        M_FilteringSettings                     { get; set; }
        public List<ShaderTagId>?                       M_ShaderTagIdList                       { get; set; }
        public ProfilingSampler?                        M_ProfilingSampler                      { get; set; }
        public ProfilingSampler?                        M_DBufferClearSampler                   { get; set; }
        public bool                                     M_DecalLayers                           { get; set; }
        public RTHandle?                                M_DBufferDepth                          { get; set; }
        public List<RTHandle>?                          DBufferColorHandles                     { get; set; }
        public RTHandle?                                DepthHandle                             { get; set; }

        public static DBufferRenderPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DBufferRenderPass() { Pointer= p0 };

            value.M_DrawSystem                              = GetObject<DecalDrawDBufferSystem>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.DecalDrawDBufferSystem.FromPointer); // 0xE0 M_DrawSystem                ( ModelClassType DecalDrawDBufferSystem DecalDrawDBufferSystem DecalDrawDBufferSystem Pointer )
            value.M_Settings                                = GetObject<DBufferSettings>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.DBufferSettings.FromPointer); // 0xE8 M_Settings                  ( ModelClassType DBufferSettings DBufferSettings DBufferSettings Pointer )
            value.M_DBufferClear                            = GetObject<Material>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Material.FromPointer); // 0xF0 M_DBufferClear              ( ModelClassType Material Material Material Pointer )
            value.M_FilteringSettings                       = (FilteringSettings)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 M_FilteringSettings         ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.M_ShaderTagIdList                         = GetEnumList<ShaderTagId>(new IntPtr(p + 0x110)); // 0x110 M_ShaderTagIdList           ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.M_ProfilingSampler                        = GetObject<ProfilingSampler>(new IntPtr(p + 0x118), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x118 M_ProfilingSampler          ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_DBufferClearSampler                     = GetObject<ProfilingSampler>(new IntPtr(p + 0x120), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x120 M_DBufferClearSampler       ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_DecalLayers                             = GetBool(new IntPtr(p + 0x128)); // 0x128 M_DecalLayers               ( ModelPrimitiveType bool bool bool Bool )
            value.M_DBufferDepth                            = GetObject<RTHandle>(new IntPtr(p + 0x130), ReversePrism.DataModels.RTHandle.FromPointer); // 0x130 M_DBufferDepth              ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.DBufferColorHandles                       = GetObjectList<RTHandle>(new IntPtr(p + 0x138), ReversePrism.DataModels.RTHandle.FromPointer); // 0x138 DBufferColorHandles         ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.DepthHandle                               = GetObject<RTHandle>(new IntPtr(p + 0x140), ReversePrism.DataModels.RTHandle.FromPointer); // 0x140 DepthHandle                 ( ModelClassType RTHandle RTHandle RTHandle Pointer )

            return value;
        }
    }
}
