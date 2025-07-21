using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 K_AssetVersion                           ModelPrimitiveType int int int Int32
    // 000 cachedInstance                           UniversalRenderPipelineGlobalSettings IL2CPP_TYPE_CLASS
    // 008 defaultAssetName                         string IL2CPP_TYPE_STRING
    // 020 M_RenderingLayerNames                    ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 M_PrefixedRenderingLayerNames            ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 M_ValidRenderingLayers                   ModelPrimitiveType uint uint uint UInt32
    // 038 LightLayerName0                          ModelPrimitiveType string string string String
    // 040 LightLayerName1                          ModelPrimitiveType string string string String
    // 048 LightLayerName2                          ModelPrimitiveType string string string String
    // 050 LightLayerName3                          ModelPrimitiveType string string string String
    // 058 LightLayerName4                          ModelPrimitiveType string string string String
    // 060 LightLayerName5                          ModelPrimitiveType string string string String
    // 068 LightLayerName6                          ModelPrimitiveType string string string String
    // 070 LightLayerName7                          ModelPrimitiveType string string string String
    // 078 M_StripDebugVariants                     ModelPrimitiveType bool bool bool Bool
    // 079 M_StripUnusedPostProcessingVariants      ModelPrimitiveType bool bool bool Bool
    // 07A M_StripUnusedVariants                    ModelPrimitiveType bool bool bool Bool
    // 07B M_StripUnusedLODCrossFadeVariants        ModelPrimitiveType bool bool bool Bool
    // 07C M_StripScreenCoordOverrideVariants       ModelPrimitiveType bool bool bool Bool
    // 07D SupportRuntimeDebugDisplay               ModelPrimitiveType bool bool bool Bool
    // 080 M_ShaderVariantLogLevel                  ModelEnumType ShaderVariantLogLevel ShaderVariantLogLevel ShaderVariantLogLevel Int32
    // 084 M_ExportShaderVariants                   ModelPrimitiveType bool bool bool Bool
    public partial class UniversalRenderPipelineGlobalSettings : DataModel
    {
        public int                                      K_AssetVersion                          { get; set; }
        public List<string>?                            M_RenderingLayerNames                   { get; set; }
        public List<string>?                            M_PrefixedRenderingLayerNames           { get; set; }
        public uint                                     M_ValidRenderingLayers                  { get; set; }
        public string                                   LightLayerName0                         { get; set; }
        public string                                   LightLayerName1                         { get; set; }
        public string                                   LightLayerName2                         { get; set; }
        public string                                   LightLayerName3                         { get; set; }
        public string                                   LightLayerName4                         { get; set; }
        public string                                   LightLayerName5                         { get; set; }
        public string                                   LightLayerName6                         { get; set; }
        public string                                   LightLayerName7                         { get; set; }
        public bool                                     M_StripDebugVariants                    { get; set; }
        public bool                                     M_StripUnusedPostProcessingVariants     { get; set; }
        public bool                                     M_StripUnusedVariants                   { get; set; }
        public bool                                     M_StripUnusedLODCrossFadeVariants       { get; set; }
        public bool                                     M_StripScreenCoordOverrideVariants      { get; set; }
        public bool                                     SupportRuntimeDebugDisplay              { get; set; }
        public ShaderVariantLogLevel                    M_ShaderVariantLogLevel                 { get; set; }
        public bool                                     M_ExportShaderVariants                  { get; set; }

        public static UniversalRenderPipelineGlobalSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniversalRenderPipelineGlobalSettings() { Pointer= p0 };

            value.K_AssetVersion                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 K_AssetVersion              ( ModelPrimitiveType int int int Int32 )
            value.M_RenderingLayerNames                     = GetStringList(new IntPtr(p + 0x020)); // 0x20 M_RenderingLayerNames       ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_PrefixedRenderingLayerNames             = GetStringList(new IntPtr(p + 0x028)); // 0x28 M_PrefixedRenderingLayerNames ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_ValidRenderingLayers                    = GetUInt32(new IntPtr(p + 0x030)); // 0x30 M_ValidRenderingLayers      ( ModelPrimitiveType uint uint uint UInt32 )
            value.LightLayerName0                           = GetString(new IntPtr(p + 0x038)); // 0x38 LightLayerName0             ( ModelPrimitiveType string string string String )
            value.LightLayerName1                           = GetString(new IntPtr(p + 0x040)); // 0x40 LightLayerName1             ( ModelPrimitiveType string string string String )
            value.LightLayerName2                           = GetString(new IntPtr(p + 0x048)); // 0x48 LightLayerName2             ( ModelPrimitiveType string string string String )
            value.LightLayerName3                           = GetString(new IntPtr(p + 0x050)); // 0x50 LightLayerName3             ( ModelPrimitiveType string string string String )
            value.LightLayerName4                           = GetString(new IntPtr(p + 0x058)); // 0x58 LightLayerName4             ( ModelPrimitiveType string string string String )
            value.LightLayerName5                           = GetString(new IntPtr(p + 0x060)); // 0x60 LightLayerName5             ( ModelPrimitiveType string string string String )
            value.LightLayerName6                           = GetString(new IntPtr(p + 0x068)); // 0x68 LightLayerName6             ( ModelPrimitiveType string string string String )
            value.LightLayerName7                           = GetString(new IntPtr(p + 0x070)); // 0x70 LightLayerName7             ( ModelPrimitiveType string string string String )
            value.M_StripDebugVariants                      = GetBool(new IntPtr(p + 0x078)); // 0x78 M_StripDebugVariants        ( ModelPrimitiveType bool bool bool Bool )
            value.M_StripUnusedPostProcessingVariants       = GetBool(new IntPtr(p + 0x079)); // 0x79 M_StripUnusedPostProcessingVariants ( ModelPrimitiveType bool bool bool Bool )
            value.M_StripUnusedVariants                     = GetBool(new IntPtr(p + 0x07A)); // 0x7A M_StripUnusedVariants       ( ModelPrimitiveType bool bool bool Bool )
            value.M_StripUnusedLODCrossFadeVariants         = GetBool(new IntPtr(p + 0x07B)); // 0x7B M_StripUnusedLODCrossFadeVariants ( ModelPrimitiveType bool bool bool Bool )
            value.M_StripScreenCoordOverrideVariants        = GetBool(new IntPtr(p + 0x07C)); // 0x7C M_StripScreenCoordOverrideVariants ( ModelPrimitiveType bool bool bool Bool )
            value.SupportRuntimeDebugDisplay                = GetBool(new IntPtr(p + 0x07D)); // 0x7D SupportRuntimeDebugDisplay  ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShaderVariantLogLevel                   = (ShaderVariantLogLevel)GetInt32(new IntPtr(p + 0x080)); // 0x80 M_ShaderVariantLogLevel     ( ModelEnumType ShaderVariantLogLevel ShaderVariantLogLevel ShaderVariantLogLevel Int32 )
            value.M_ExportShaderVariants                    = GetBool(new IntPtr(p + 0x084)); // 0x84 M_ExportShaderVariants      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
