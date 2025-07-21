using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 PostProcessData                          ModelClassType PostProcessData PostProcessData PostProcessData Pointer
    // 048 Shaders                                  ModelClassType ShaderResources ShaderResources ShaderResources Pointer
    // 000 k_LatestAssetVersion                     int IL2CPP_TYPE_I4
    // 050 M_AssetVersion                           ModelPrimitiveType int int int Int32
    // 054 M_OpaqueLayerMask                        ModelEnumType LayerMask LayerMask LayerMask Int32
    // 058 M_TransparentLayerMask                   ModelEnumType LayerMask LayerMask LayerMask Int32
    // 060 M_DefaultStencilState                    ModelClassType StencilStateData StencilStateData StencilStateData Pointer
    // 068 M_ShadowTransparentReceive               ModelPrimitiveType bool bool bool Bool
    // 06C M_RenderingMode                          ModelEnumType RenderingMode RenderingMode RenderingMode Int32
    // 070 M_DepthPrimingMode                       ModelEnumType DepthPrimingMode DepthPrimingMode DepthPrimingMode Int32
    // 074 M_CopyDepthMode                          ModelEnumType CopyDepthMode CopyDepthMode CopyDepthMode Int32
    // 078 M_AccurateGbufferNormals                 ModelPrimitiveType bool bool bool Bool
    // 07C M_IntermediateTextureMode                ModelEnumType IntermediateTextureMode IntermediateTextureMode IntermediateTextureMode Int32
    public partial class UniversalRendererData : DataModel
    {
        public PostProcessData?                         PostProcessData                         { get; set; }
        public ShaderResources?                         Shaders                                 { get; set; }
        public int                                      M_AssetVersion                          { get; set; }
        public LayerMask                                M_OpaqueLayerMask                       { get; set; }
        public LayerMask                                M_TransparentLayerMask                  { get; set; }
        public StencilStateData?                        M_DefaultStencilState                   { get; set; }
        public bool                                     M_ShadowTransparentReceive              { get; set; }
        public RenderingMode                            M_RenderingMode                         { get; set; }
        public DepthPrimingMode                         M_DepthPrimingMode                      { get; set; }
        public CopyDepthMode                            M_CopyDepthMode                         { get; set; }
        public bool                                     M_AccurateGbufferNormals                { get; set; }
        public IntermediateTextureMode                  M_IntermediateTextureMode               { get; set; }

        public static UniversalRendererData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniversalRendererData() { Pointer= p0 };

            value.PostProcessData                           = GetObject<PostProcessData>(new IntPtr(p + 0x040), ReversePrism.DataModels.PostProcessData.FromPointer); // 0x40 PostProcessData             ( ModelClassType PostProcessData PostProcessData PostProcessData Pointer )
            value.Shaders                                   = GetObject<ShaderResources>(new IntPtr(p + 0x048), ReversePrism.DataModels.ShaderResources.FromPointer); // 0x48 Shaders                     ( ModelClassType ShaderResources ShaderResources ShaderResources Pointer )
            value.M_AssetVersion                            = GetInt32(new IntPtr(p + 0x050)); // 0x50 M_AssetVersion              ( ModelPrimitiveType int int int Int32 )
            value.M_OpaqueLayerMask                         = (LayerMask)GetInt32(new IntPtr(p + 0x054)); // 0x54 M_OpaqueLayerMask           ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_TransparentLayerMask                    = (LayerMask)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_TransparentLayerMask      ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_DefaultStencilState                     = GetObject<StencilStateData>(new IntPtr(p + 0x060), ReversePrism.DataModels.StencilStateData.FromPointer); // 0x60 M_DefaultStencilState       ( ModelClassType StencilStateData StencilStateData StencilStateData Pointer )
            value.M_ShadowTransparentReceive                = GetBool(new IntPtr(p + 0x068)); // 0x68 M_ShadowTransparentReceive  ( ModelPrimitiveType bool bool bool Bool )
            value.M_RenderingMode                           = (RenderingMode)GetInt32(new IntPtr(p + 0x06C)); // 0x6C M_RenderingMode             ( ModelEnumType RenderingMode RenderingMode RenderingMode Int32 )
            value.M_DepthPrimingMode                        = (DepthPrimingMode)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_DepthPrimingMode          ( ModelEnumType DepthPrimingMode DepthPrimingMode DepthPrimingMode Int32 )
            value.M_CopyDepthMode                           = (CopyDepthMode)GetInt32(new IntPtr(p + 0x074)); // 0x74 M_CopyDepthMode             ( ModelEnumType CopyDepthMode CopyDepthMode CopyDepthMode Int32 )
            value.M_AccurateGbufferNormals                  = GetBool(new IntPtr(p + 0x078)); // 0x78 M_AccurateGbufferNormals    ( ModelPrimitiveType bool bool bool Bool )
            value.M_IntermediateTextureMode                 = (IntermediateTextureMode)GetInt32(new IntPtr(p + 0x07C)); // 0x7C M_IntermediateTextureMode   ( ModelEnumType IntermediateTextureMode IntermediateTextureMode IntermediateTextureMode Int32 )

            return value;
        }
    }
}
