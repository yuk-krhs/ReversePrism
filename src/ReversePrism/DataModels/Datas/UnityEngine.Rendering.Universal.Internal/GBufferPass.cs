using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_CameraNormalsTextureID                 int IL2CPP_TYPE_I4
    // 004 s_ShaderTagLit                           ShaderTagId IL2CPP_TYPE_VALUETYPE
    // 008 s_ShaderTagSimpleLit                     ShaderTagId IL2CPP_TYPE_VALUETYPE
    // 00C s_ShaderTagUnlit                         ShaderTagId IL2CPP_TYPE_VALUETYPE
    // 010 S_ShaderTagComplexLit                    ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32
    // 014 S_ShaderTagUniversalGBuffer              ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32
    // 018 S_ShaderTagUniversalMaterialType         ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32
    // 0E0 M_ProfilingSampler                       ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 0E8 M_DeferredLights                         ModelClassType DeferredLights DeferredLights DeferredLights Pointer
    // 020 S_ShaderTagValues                        ModelEnumListType ShaderTagId[] ShaderTagId[] List<ShaderTagId> Pointer
    // 028 S_RenderStateBlocks                      ModelEnumListType RenderStateBlock[] RenderStateBlock[] List<RenderStateBlock> Pointer
    // 0F0 M_FilteringSettings                      ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    // 108 M_RenderStateBlock                       ModelEnumType RenderStateBlock RenderStateBlock RenderStateBlock Int32
    // 178 M_PassData                               ModelClassType PassData PassData PassData Pointer
    public partial class GBufferPass : DataModel
    {
        public ShaderTagId                              S_ShaderTagComplexLit                   { get; set; }
        public ShaderTagId                              S_ShaderTagUniversalGBuffer             { get; set; }
        public ShaderTagId                              S_ShaderTagUniversalMaterialType        { get; set; }
        public ProfilingSampler?                        M_ProfilingSampler                      { get; set; }
        public DeferredLights?                          M_DeferredLights                        { get; set; }
        public List<ShaderTagId>?                       S_ShaderTagValues                       { get; set; }
        public List<RenderStateBlock>?                  S_RenderStateBlocks                     { get; set; }
        public FilteringSettings                        M_FilteringSettings                     { get; set; }
        public RenderStateBlock                         M_RenderStateBlock                      { get; set; }
        public PassData?                                M_PassData                              { get; set; }

        public static GBufferPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GBufferPass() { Pointer= p0 };

            value.S_ShaderTagComplexLit                     = (ShaderTagId)GetInt32(new IntPtr(p + 0x010)); // 0x10 S_ShaderTagComplexLit       ( ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32 )
            value.S_ShaderTagUniversalGBuffer               = (ShaderTagId)GetInt32(new IntPtr(p + 0x014)); // 0x14 S_ShaderTagUniversalGBuffer ( ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32 )
            value.S_ShaderTagUniversalMaterialType          = (ShaderTagId)GetInt32(new IntPtr(p + 0x018)); // 0x18 S_ShaderTagUniversalMaterialType ( ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32 )
            value.M_ProfilingSampler                        = GetObject<ProfilingSampler>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0xE0 M_ProfilingSampler          ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_DeferredLights                          = GetObject<DeferredLights>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.DeferredLights.FromPointer); // 0xE8 M_DeferredLights            ( ModelClassType DeferredLights DeferredLights DeferredLights Pointer )
            value.S_ShaderTagValues                         = GetEnumList<ShaderTagId>(new IntPtr(p + 0x020)); // 0x20 S_ShaderTagValues           ( ModelEnumListType ShaderTagId[] ShaderTagId[] List<ShaderTagId> Pointer )
            value.S_RenderStateBlocks                       = GetEnumList<RenderStateBlock>(new IntPtr(p + 0x028)); // 0x28 S_RenderStateBlocks         ( ModelEnumListType RenderStateBlock[] RenderStateBlock[] List<RenderStateBlock> Pointer )
            value.M_FilteringSettings                       = (FilteringSettings)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 M_FilteringSettings         ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.M_RenderStateBlock                        = (RenderStateBlock)GetInt32(new IntPtr(p + 0x108)); // 0x108 M_RenderStateBlock          ( ModelEnumType RenderStateBlock RenderStateBlock RenderStateBlock Int32 )
            value.M_PassData                                = GetObject<PassData>(new IntPtr(p + 0x178), ReversePrism.DataModels.PassData.FromPointer); // 0x178 M_PassData                  ( ModelClassType PassData PassData PassData Pointer )

            return value;
        }
    }
}
