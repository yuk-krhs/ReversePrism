using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_LightPosID                             int IL2CPP_TYPE_I4
    // 004 k_SelfShadowingID                        int IL2CPP_TYPE_I4
    // 008 k_ShadowStencilGroupID                   int IL2CPP_TYPE_I4
    // 00C k_ShadowIntensityID                      int IL2CPP_TYPE_I4
    // 010 K_ShadowVolumeIntensityID                ModelPrimitiveType int int int Int32
    // 014 K_ShadowRadiusID                         ModelPrimitiveType int int int Int32
    // 018 K_ShadowColorMaskID                      ModelPrimitiveType int int int Int32
    // 01C K_ShadowModelMatrixID                    ModelPrimitiveType int int int Int32
    // 020 K_ShadowModelInvMatrixID                 ModelPrimitiveType int int int Int32
    // 024 K_ShadowModelScaleID                     ModelPrimitiveType int int int Int32
    // 028 M_ProfilingSamplerShadows                ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 030 M_ProfilingSamplerShadowsA               ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 038 M_ProfilingSamplerShadowsR               ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 040 M_ProfilingSamplerShadowsG               ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 048 M_ProfilingSamplerShadowsB               ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 050 M_RenderTargets                          ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 058 M_RenderTargetIds                        ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 M_LightInputTextures                     ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer
    // 068 K_ColorLookup                            ModelEnumListType Color[] Color[] List<Color> Pointer
    // 070 M_ProfilingSamplerShadowColorsLookup     ModelClassListType ProfilingSampler[] ProfilingSampler[] List<ProfilingSampler> Pointer
    // 078 MaxTextureCount                          ModelPrimitiveType uint uint uint UInt32
    public partial class ShadowRendering : DataModel
    {
        public int                                      K_ShadowVolumeIntensityID               { get; set; }
        public int                                      K_ShadowRadiusID                        { get; set; }
        public int                                      K_ShadowColorMaskID                     { get; set; }
        public int                                      K_ShadowModelMatrixID                   { get; set; }
        public int                                      K_ShadowModelInvMatrixID                { get; set; }
        public int                                      K_ShadowModelScaleID                    { get; set; }
        public ProfilingSampler?                        M_ProfilingSamplerShadows               { get; set; }
        public ProfilingSampler?                        M_ProfilingSamplerShadowsA              { get; set; }
        public ProfilingSampler?                        M_ProfilingSamplerShadowsR              { get; set; }
        public ProfilingSampler?                        M_ProfilingSamplerShadowsG              { get; set; }
        public ProfilingSampler?                        M_ProfilingSamplerShadowsB              { get; set; }
        public List<RTHandle>?                          M_RenderTargets                         { get; set; }
        public List<int>?                               M_RenderTargetIds                       { get; set; }
        public List<RenderTargetIdentifier>?            M_LightInputTextures                    { get; set; }
        public List<Color>?                             K_ColorLookup                           { get; set; }
        public List<ProfilingSampler>?                  M_ProfilingSamplerShadowColorsLookup    { get; set; }
        public uint                                     MaxTextureCount                         { get; set; }

        public static ShadowRendering? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShadowRendering() { Pointer= p0 };

            value.K_ShadowVolumeIntensityID                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 K_ShadowVolumeIntensityID   ( ModelPrimitiveType int int int Int32 )
            value.K_ShadowRadiusID                          = GetInt32(new IntPtr(p + 0x014)); // 0x14 K_ShadowRadiusID            ( ModelPrimitiveType int int int Int32 )
            value.K_ShadowColorMaskID                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 K_ShadowColorMaskID         ( ModelPrimitiveType int int int Int32 )
            value.K_ShadowModelMatrixID                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C K_ShadowModelMatrixID       ( ModelPrimitiveType int int int Int32 )
            value.K_ShadowModelInvMatrixID                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 K_ShadowModelInvMatrixID    ( ModelPrimitiveType int int int Int32 )
            value.K_ShadowModelScaleID                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 K_ShadowModelScaleID        ( ModelPrimitiveType int int int Int32 )
            value.M_ProfilingSamplerShadows                 = GetObject<ProfilingSampler>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x28 M_ProfilingSamplerShadows   ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingSamplerShadowsA                = GetObject<ProfilingSampler>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x30 M_ProfilingSamplerShadowsA  ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingSamplerShadowsR                = GetObject<ProfilingSampler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x38 M_ProfilingSamplerShadowsR  ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingSamplerShadowsG                = GetObject<ProfilingSampler>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x40 M_ProfilingSamplerShadowsG  ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingSamplerShadowsB                = GetObject<ProfilingSampler>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x48 M_ProfilingSamplerShadowsB  ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_RenderTargets                           = GetObjectList<RTHandle>(new IntPtr(p + 0x050), ReversePrism.DataModels.RTHandle.FromPointer); // 0x50 M_RenderTargets             ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.M_RenderTargetIds                         = GetInt32List(new IntPtr(p + 0x058)); // 0x58 M_RenderTargetIds           ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_LightInputTextures                      = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x060)); // 0x60 M_LightInputTextures        ( ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer )
            value.K_ColorLookup                             = GetEnumList<Color>(new IntPtr(p + 0x068)); // 0x68 K_ColorLookup               ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.M_ProfilingSamplerShadowColorsLookup      = GetObjectList<ProfilingSampler>(new IntPtr(p + 0x070), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x70 M_ProfilingSamplerShadowColorsLookup ( ModelClassListType ProfilingSampler[] ProfilingSampler[] List<ProfilingSampler> Pointer )
            value.MaxTextureCount                           = GetUInt32(new IntPtr(p + 0x078)); // 0x78 MaxTextureCount             ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
