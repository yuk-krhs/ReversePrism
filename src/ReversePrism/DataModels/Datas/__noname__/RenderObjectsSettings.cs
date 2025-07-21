using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PassTag                                  ModelPrimitiveType string string string String
    // 018 Event                                    ModelEnumType RenderPassEvent RenderPassEvent RenderPassEvent Int32
    // 020 FilterSettings                           ModelClassType FilterSettings FilterSettings FilterSettings Pointer
    // 028 OverrideMaterial                         ModelClassType Material Material Material Pointer
    // 030 OverrideMaterialPassIndex                ModelPrimitiveType int int int Int32
    // 038 OverrideShader                           ModelClassType Shader Shader Shader Pointer
    // 040 OverrideShaderPassIndex                  ModelPrimitiveType int int int Int32
    // 044 OverrideMode                             ModelEnumType OverrideMaterialMode OverrideMaterialMode OverrideMaterialMode Int32
    // 048 OverrideDepthState                       ModelPrimitiveType bool bool bool Bool
    // 04C DepthCompareFunction                     ModelEnumType CompareFunction CompareFunction CompareFunction Int32
    // 050 EnableWrite                              ModelPrimitiveType bool bool bool Bool
    // 058 StencilSettings                          ModelClassType StencilStateData StencilStateData StencilStateData Pointer
    // 060 CameraSettings                           ModelClassType CustomCameraSettings CustomCameraSettings CustomCameraSettings Pointer
    public partial class RenderObjectsSettings : DataModel
    {
        public string                                   PassTag                                 { get; set; }
        public RenderPassEvent                          Event                                   { get; set; }
        public FilterSettings?                          FilterSettings                          { get; set; }
        public Material?                                OverrideMaterial                        { get; set; }
        public int                                      OverrideMaterialPassIndex               { get; set; }
        public Shader?                                  OverrideShader                          { get; set; }
        public int                                      OverrideShaderPassIndex                 { get; set; }
        public OverrideMaterialMode                     OverrideMode                            { get; set; }
        public bool                                     OverrideDepthState                      { get; set; }
        public CompareFunction                          DepthCompareFunction                    { get; set; }
        public bool                                     EnableWrite                             { get; set; }
        public StencilStateData?                        StencilSettings                         { get; set; }
        public CustomCameraSettings?                    CameraSettings                          { get; set; }

        public static RenderObjectsSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderObjectsSettings() { Pointer= p0 };

            value.PassTag                                   = GetString(new IntPtr(p + 0x010)); // 0x10 PassTag                     ( ModelPrimitiveType string string string String )
            value.Event                                     = (RenderPassEvent)GetInt32(new IntPtr(p + 0x018)); // 0x18 Event                       ( ModelEnumType RenderPassEvent RenderPassEvent RenderPassEvent Int32 )
            value.FilterSettings                            = GetObject<FilterSettings>(new IntPtr(p + 0x020), ReversePrism.DataModels.FilterSettings.FromPointer); // 0x20 FilterSettings              ( ModelClassType FilterSettings FilterSettings FilterSettings Pointer )
            value.OverrideMaterial                          = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 OverrideMaterial            ( ModelClassType Material Material Material Pointer )
            value.OverrideMaterialPassIndex                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 OverrideMaterialPassIndex   ( ModelPrimitiveType int int int Int32 )
            value.OverrideShader                            = GetObject<Shader>(new IntPtr(p + 0x038), ReversePrism.DataModels.Shader.FromPointer); // 0x38 OverrideShader              ( ModelClassType Shader Shader Shader Pointer )
            value.OverrideShaderPassIndex                   = GetInt32(new IntPtr(p + 0x040)); // 0x40 OverrideShaderPassIndex     ( ModelPrimitiveType int int int Int32 )
            value.OverrideMode                              = (OverrideMaterialMode)GetInt32(new IntPtr(p + 0x044)); // 0x44 OverrideMode                ( ModelEnumType OverrideMaterialMode OverrideMaterialMode OverrideMaterialMode Int32 )
            value.OverrideDepthState                        = GetBool(new IntPtr(p + 0x048)); // 0x48 OverrideDepthState          ( ModelPrimitiveType bool bool bool Bool )
            value.DepthCompareFunction                      = (CompareFunction)GetInt32(new IntPtr(p + 0x04C)); // 0x4C DepthCompareFunction        ( ModelEnumType CompareFunction CompareFunction CompareFunction Int32 )
            value.EnableWrite                               = GetBool(new IntPtr(p + 0x050)); // 0x50 EnableWrite                 ( ModelPrimitiveType bool bool bool Bool )
            value.StencilSettings                           = GetObject<StencilStateData>(new IntPtr(p + 0x058), ReversePrism.DataModels.StencilStateData.FromPointer); // 0x58 StencilSettings             ( ModelClassType StencilStateData StencilStateData StencilStateData Pointer )
            value.CameraSettings                            = GetObject<CustomCameraSettings>(new IntPtr(p + 0x060), ReversePrism.DataModels.CustomCameraSettings.FromPointer); // 0x60 CameraSettings              ( ModelClassType CustomCameraSettings CustomCameraSettings CustomCameraSettings Pointer )

            return value;
        }
    }
}
