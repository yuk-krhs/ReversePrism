using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ProfileTag                               string IL2CPP_TYPE_STRING
    // 000 ProfileSampler                           ProfilingSampler IL2CPP_TYPE_CLASS
    // 0E0 Asset                                    ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer
    // 0E8 PrismRenderFrame                         ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer
    public partial class PrismReleaseTemporaryPass : DataModel
    {
        public PrismRenderPipelineAsset?                Asset                                   { get; set; }
        public PrismRenderFrame?                        PrismRenderFrame                        { get; set; }

        public static PrismReleaseTemporaryPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismReleaseTemporaryPass() { Pointer= p0 };

            value.Asset                                     = GetObject<PrismRenderPipelineAsset>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.PrismRenderPipelineAsset.FromPointer); // 0xE0 Asset                       ( ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer )
            value.PrismRenderFrame                          = GetObject<PrismRenderFrame>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.PrismRenderFrame.FromPointer); // 0xE8 PrismRenderFrame            ( ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer )

            return value;
        }
    }
}
