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
    // 0E8 FilteringSettings                        ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    // 100 Asset                                    ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer
    // 108 PrismRenderFrame                         ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer
    public partial class PrismDepthOnlyRenderPass : DataModel
    {
        public List<ShaderTagId>?                       DrawPassNames                           { get; set; }
        public FilteringSettings                        FilteringSettings                       { get; set; }
        public PrismRenderPipelineAsset?                Asset                                   { get; set; }
        public PrismRenderFrame?                        PrismRenderFrame                        { get; set; }

        public static PrismDepthOnlyRenderPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismDepthOnlyRenderPass() { Pointer= p0 };

            value.DrawPassNames                             = GetEnumList<ShaderTagId>(new IntPtr(p + 0x0E0)); // 0xE0 DrawPassNames               ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.FilteringSettings                         = (FilteringSettings)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 FilteringSettings           ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.Asset                                     = GetObject<PrismRenderPipelineAsset>(new IntPtr(p + 0x100), ReversePrism.DataModels.PrismRenderPipelineAsset.FromPointer); // 0x100 Asset                       ( ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer )
            value.PrismRenderFrame                          = GetObject<PrismRenderFrame>(new IntPtr(p + 0x108), ReversePrism.DataModels.PrismRenderFrame.FromPointer); // 0x108 PrismRenderFrame            ( ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer )

            return value;
        }
    }
}
