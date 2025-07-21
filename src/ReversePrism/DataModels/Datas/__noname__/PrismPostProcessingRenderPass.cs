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
    // 0E0 PostProcessingContext                    ModelClassType PostProcessRenderContext PostProcessRenderContext PostProcessRenderContext Pointer
    // 0E8 Asset                                    ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer
    // 0F0 PrismRenderFrame                         ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer
    public partial class PrismPostProcessingRenderPass : DataModel
    {
        public PostProcessRenderContext?                PostProcessingContext                   { get; set; }
        public PrismRenderPipelineAsset?                Asset                                   { get; set; }
        public PrismRenderFrame?                        PrismRenderFrame                        { get; set; }

        public static PrismPostProcessingRenderPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismPostProcessingRenderPass() { Pointer= p0 };

            value.PostProcessingContext                     = GetObject<PostProcessRenderContext>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.PostProcessRenderContext.FromPointer); // 0xE0 PostProcessingContext       ( ModelClassType PostProcessRenderContext PostProcessRenderContext PostProcessRenderContext Pointer )
            value.Asset                                     = GetObject<PrismRenderPipelineAsset>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.PrismRenderPipelineAsset.FromPointer); // 0xE8 Asset                       ( ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer )
            value.PrismRenderFrame                          = GetObject<PrismRenderFrame>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.PrismRenderFrame.FromPointer); // 0xF0 PrismRenderFrame            ( ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer )

            return value;
        }
    }
}
