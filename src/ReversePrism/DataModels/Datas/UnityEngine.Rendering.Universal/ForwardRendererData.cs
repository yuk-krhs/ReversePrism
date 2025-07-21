using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_ErrorMessage                           string IL2CPP_TYPE_STRING
    // 040 Shaders                                  ModelClassType ShaderResources ShaderResources ShaderResources Pointer
    // 048 PostProcessData                          ModelClassType PostProcessData PostProcessData PostProcessData Pointer
    // 050 M_OpaqueLayerMask                        ModelEnumType LayerMask LayerMask LayerMask Int32
    // 054 M_TransparentLayerMask                   ModelEnumType LayerMask LayerMask LayerMask Int32
    // 058 M_DefaultStencilState                    ModelClassType StencilStateData StencilStateData StencilStateData Pointer
    // 060 M_ShadowTransparentReceive               ModelPrimitiveType bool bool bool Bool
    // 064 M_RenderingMode                          ModelEnumType RenderingMode RenderingMode RenderingMode Int32
    // 068 M_DepthPrimingMode                       ModelEnumType DepthPrimingMode DepthPrimingMode DepthPrimingMode Int32
    // 06C M_AccurateGbufferNormals                 ModelPrimitiveType bool bool bool Bool
    // 06D M_ClusteredRendering                     ModelPrimitiveType bool bool bool Bool
    // 070 M_TileSize                               ModelEnumType TileSize TileSize TileSize Int32
    public partial class ForwardRendererData : DataModel
    {
        public ShaderResources?                         Shaders                                 { get; set; }
        public PostProcessData?                         PostProcessData                         { get; set; }
        public LayerMask                                M_OpaqueLayerMask                       { get; set; }
        public LayerMask                                M_TransparentLayerMask                  { get; set; }
        public StencilStateData?                        M_DefaultStencilState                   { get; set; }
        public bool                                     M_ShadowTransparentReceive              { get; set; }
        public RenderingMode                            M_RenderingMode                         { get; set; }
        public DepthPrimingMode                         M_DepthPrimingMode                      { get; set; }
        public bool                                     M_AccurateGbufferNormals                { get; set; }
        public bool                                     M_ClusteredRendering                    { get; set; }
        public TileSize                                 M_TileSize                              { get; set; }

        public static ForwardRendererData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ForwardRendererData() { Pointer= p0 };

            value.Shaders                                   = GetObject<ShaderResources>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShaderResources.FromPointer); // 0x40 Shaders                     ( ModelClassType ShaderResources ShaderResources ShaderResources Pointer )
            value.PostProcessData                           = GetObject<PostProcessData>(new IntPtr(p + 0x048), ReversePrism.DataModels.PostProcessData.FromPointer); // 0x48 PostProcessData             ( ModelClassType PostProcessData PostProcessData PostProcessData Pointer )
            value.M_OpaqueLayerMask                         = (LayerMask)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_OpaqueLayerMask           ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_TransparentLayerMask                    = (LayerMask)GetInt32(new IntPtr(p + 0x054)); // 0x54 M_TransparentLayerMask      ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_DefaultStencilState                     = GetObject<StencilStateData>(new IntPtr(p + 0x058), ReversePrism.DataModels.StencilStateData.FromPointer); // 0x58 M_DefaultStencilState       ( ModelClassType StencilStateData StencilStateData StencilStateData Pointer )
            value.M_ShadowTransparentReceive                = GetBool(new IntPtr(p + 0x060)); // 0x60 M_ShadowTransparentReceive  ( ModelPrimitiveType bool bool bool Bool )
            value.M_RenderingMode                           = (RenderingMode)GetInt32(new IntPtr(p + 0x064)); // 0x64 M_RenderingMode             ( ModelEnumType RenderingMode RenderingMode RenderingMode Int32 )
            value.M_DepthPrimingMode                        = (DepthPrimingMode)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_DepthPrimingMode          ( ModelEnumType DepthPrimingMode DepthPrimingMode DepthPrimingMode Int32 )
            value.M_AccurateGbufferNormals                  = GetBool(new IntPtr(p + 0x06C)); // 0x6C M_AccurateGbufferNormals    ( ModelPrimitiveType bool bool bool Bool )
            value.M_ClusteredRendering                      = GetBool(new IntPtr(p + 0x06D)); // 0x6D M_ClusteredRendering        ( ModelPrimitiveType bool bool bool Bool )
            value.M_TileSize                                = (TileSize)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_TileSize                  ( ModelEnumType TileSize TileSize TileSize Int32 )

            return value;
        }
    }
}
