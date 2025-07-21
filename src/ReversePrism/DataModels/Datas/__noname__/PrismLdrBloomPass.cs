using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ProfileTag                               string IL2CPP_TYPE_STRING
    // 000 ProfileSampler                           ProfileSampler IL2CPP_TYPE_CLASS
    // 0E0 DrawPassNames                            ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 0E8 Asset                                    ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer
    // 0F0 PrismRenderFrame                         ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer
    // 0F8 RenderedEffectBufferIDs                  ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class PrismLdrBloomPass : DataModel
    {
        public List<ShaderTagId>?                       DrawPassNames                           { get; set; }
        public PrismRenderPipelineAsset?                Asset                                   { get; set; }
        public PrismRenderFrame?                        PrismRenderFrame                        { get; set; }
        public List<int>?                               RenderedEffectBufferIDs                 { get; set; }

        public static PrismLdrBloomPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismLdrBloomPass() { Pointer= p0 };

            value.DrawPassNames                             = GetEnumList<ShaderTagId>(new IntPtr(p + 0x0E0)); // 0xE0 DrawPassNames               ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.Asset                                     = GetObject<PrismRenderPipelineAsset>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.PrismRenderPipelineAsset.FromPointer); // 0xE8 Asset                       ( ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer )
            value.PrismRenderFrame                          = GetObject<PrismRenderFrame>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.PrismRenderFrame.FromPointer); // 0xF0 PrismRenderFrame            ( ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer )
            value.RenderedEffectBufferIDs                   = GetInt32List(new IntPtr(p + 0x0F8)); // 0xF8 RenderedEffectBufferIDs     ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
