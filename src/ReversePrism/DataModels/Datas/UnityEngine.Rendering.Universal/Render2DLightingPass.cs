using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_HDREmulationScaleID                    int IL2CPP_TYPE_I4
    // 004 k_InverseHDREmulationScaleID             int IL2CPP_TYPE_I4
    // 008 k_UseSceneLightingID                     int IL2CPP_TYPE_I4
    // 00C k_RendererColorID                        int IL2CPP_TYPE_I4
    // 010 K_ShapeLightTextureIDs                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 K_CombinedRenderingPassName              ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32
    // 01C K_NormalsRenderingPassName               ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32
    // 020 K_LegacyPassName                         ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32
    // 028 K_ShaderTags                             ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 030 M_ProfilingDrawLights                    ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 038 M_ProfilingDrawLightTextures             ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 040 M_ProfilingDrawRenderers                 ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 048 M_ProfilingDrawLayerBatch                ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 050 M_ProfilingSamplerUnlit                  ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 0E0 M_BlitMaterial                           ModelClassType Material Material Material Pointer
    // 0E8 M_SamplingMaterial                       ModelClassType Material Material Material Pointer
    // 0F0 M_Renderer2DData                         ModelClassType Renderer2DData Renderer2DData Renderer2DData Pointer
    // 0F8 M_NeedsDepth                             ModelPrimitiveType bool bool bool Bool
    // 0FA M_CameraSortingLayerBoundsIndex          ModelPrimitiveType short short short Int16
    public partial class Render2DLightingPass : DataModel
    {
        public List<int>?                               K_ShapeLightTextureIDs                  { get; set; }
        public ShaderTagId                              K_CombinedRenderingPassName             { get; set; }
        public ShaderTagId                              K_NormalsRenderingPassName              { get; set; }
        public ShaderTagId                              K_LegacyPassName                        { get; set; }
        public List<ShaderTagId>?                       K_ShaderTags                            { get; set; }
        public ProfilingSampler?                        M_ProfilingDrawLights                   { get; set; }
        public ProfilingSampler?                        M_ProfilingDrawLightTextures            { get; set; }
        public ProfilingSampler?                        M_ProfilingDrawRenderers                { get; set; }
        public ProfilingSampler?                        M_ProfilingDrawLayerBatch               { get; set; }
        public ProfilingSampler?                        M_ProfilingSamplerUnlit                 { get; set; }
        public Material?                                M_BlitMaterial                          { get; set; }
        public Material?                                M_SamplingMaterial                      { get; set; }
        public Renderer2DData?                          M_Renderer2DData                        { get; set; }
        public bool                                     M_NeedsDepth                            { get; set; }
        public short                                    M_CameraSortingLayerBoundsIndex         { get; set; }

        public static Render2DLightingPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Render2DLightingPass() { Pointer= p0 };

            value.K_ShapeLightTextureIDs                    = GetInt32List(new IntPtr(p + 0x010)); // 0x10 K_ShapeLightTextureIDs      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.K_CombinedRenderingPassName               = (ShaderTagId)GetInt32(new IntPtr(p + 0x018)); // 0x18 K_CombinedRenderingPassName ( ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32 )
            value.K_NormalsRenderingPassName                = (ShaderTagId)GetInt32(new IntPtr(p + 0x01C)); // 0x1C K_NormalsRenderingPassName  ( ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32 )
            value.K_LegacyPassName                          = (ShaderTagId)GetInt32(new IntPtr(p + 0x020)); // 0x20 K_LegacyPassName            ( ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32 )
            value.K_ShaderTags                              = GetEnumList<ShaderTagId>(new IntPtr(p + 0x028)); // 0x28 K_ShaderTags                ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.M_ProfilingDrawLights                     = GetObject<ProfilingSampler>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x30 M_ProfilingDrawLights       ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingDrawLightTextures              = GetObject<ProfilingSampler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x38 M_ProfilingDrawLightTextures ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingDrawRenderers                  = GetObject<ProfilingSampler>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x40 M_ProfilingDrawRenderers    ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingDrawLayerBatch                 = GetObject<ProfilingSampler>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x48 M_ProfilingDrawLayerBatch   ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingSamplerUnlit                   = GetObject<ProfilingSampler>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x50 M_ProfilingSamplerUnlit     ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_BlitMaterial                            = GetObject<Material>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Material.FromPointer); // 0xE0 M_BlitMaterial              ( ModelClassType Material Material Material Pointer )
            value.M_SamplingMaterial                        = GetObject<Material>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Material.FromPointer); // 0xE8 M_SamplingMaterial          ( ModelClassType Material Material Material Pointer )
            value.M_Renderer2DData                          = GetObject<Renderer2DData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Renderer2DData.FromPointer); // 0xF0 M_Renderer2DData            ( ModelClassType Renderer2DData Renderer2DData Renderer2DData Pointer )
            value.M_NeedsDepth                              = GetBool(new IntPtr(p + 0x0F8)); // 0xF8 M_NeedsDepth                ( ModelPrimitiveType bool bool bool Bool )
            value.M_CameraSortingLayerBoundsIndex           = GetInt16(new IntPtr(p + 0x0FA)); // 0xFA M_CameraSortingLayerBoundsIndex ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
