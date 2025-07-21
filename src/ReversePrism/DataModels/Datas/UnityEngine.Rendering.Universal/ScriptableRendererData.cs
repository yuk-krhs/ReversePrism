using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 IsInvalidated                            ModelPrimitiveType bool bool bool Bool
    // 020 DebugShaders                             ModelClassType DebugShaderResources DebugShaderResources DebugShaderResources Pointer
    // 028 M_RendererFeatures                       ModelClassListType List`1<ScriptableRendererFeature> List`1<ScriptableRendererFeature> List<ScriptableRendererFeature> Pointer
    // 030 M_RendererFeatureMap                     ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer
    // 038 M_UseNativeRenderPass                    ModelPrimitiveType bool bool bool Bool
    public partial class ScriptableRendererData : DataModel
    {
        public bool                                     IsInvalidated                           { get; set; }
        public DebugShaderResources?                    DebugShaders                            { get; set; }
        public List<ScriptableRendererFeature>?         M_RendererFeatures                      { get; set; }
        public List<long>?                              M_RendererFeatureMap                    { get; set; }
        public bool                                     M_UseNativeRenderPass                   { get; set; }

        public static ScriptableRendererData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScriptableRendererData() { Pointer= p0 };

            value.IsInvalidated                             = GetBool(new IntPtr(p + 0x018)); // 0x18 IsInvalidated               ( ModelPrimitiveType bool bool bool Bool )
            value.DebugShaders                              = GetObject<DebugShaderResources>(new IntPtr(p + 0x020), ReversePrism.DataModels.DebugShaderResources.FromPointer); // 0x20 DebugShaders                ( ModelClassType DebugShaderResources DebugShaderResources DebugShaderResources Pointer )
            value.M_RendererFeatures                        = GetObjectList<ScriptableRendererFeature>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScriptableRendererFeature.FromPointer); // 0x28 M_RendererFeatures          ( ModelClassListType List`1<ScriptableRendererFeature> List`1<ScriptableRendererFeature> List<ScriptableRendererFeature> Pointer )
            value.M_RendererFeatureMap                      = GetInt64List(new IntPtr(p + 0x030)); // 0x30 M_RendererFeatureMap        ( ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer )
            value.M_UseNativeRenderPass                     = GetBool(new IntPtr(p + 0x038)); // 0x38 M_UseNativeRenderPass       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
