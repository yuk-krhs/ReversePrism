using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 DrawPassNames                            ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 0E8 BeforeCharacterPassProfileSampler        ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 0F0 AfterCharacterPassProfileSampler         ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 0F8 OpaqueCharacterPassProfileSampler        ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 100 Asset                                    ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer
    // 108 PrismRenderFrame                         ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer
    public partial class PrismOpaqueRenderPass : DataModel
    {
        public List<ShaderTagId>?                       DrawPassNames                           { get; set; }
        public ProfileSampler?                          BeforeCharacterPassProfileSampler       { get; set; }
        public ProfileSampler?                          AfterCharacterPassProfileSampler        { get; set; }
        public ProfileSampler?                          OpaqueCharacterPassProfileSampler       { get; set; }
        public PrismRenderPipelineAsset?                Asset                                   { get; set; }
        public PrismRenderFrame?                        PrismRenderFrame                        { get; set; }

        public static PrismOpaqueRenderPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismOpaqueRenderPass() { Pointer= p0 };

            value.DrawPassNames                             = GetEnumList<ShaderTagId>(new IntPtr(p + 0x0E0)); // 0xE0 DrawPassNames               ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.BeforeCharacterPassProfileSampler         = GetObject<ProfileSampler>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ProfileSampler.FromPointer); // 0xE8 BeforeCharacterPassProfileSampler ( ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )
            value.AfterCharacterPassProfileSampler          = GetObject<ProfileSampler>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.ProfileSampler.FromPointer); // 0xF0 AfterCharacterPassProfileSampler ( ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )
            value.OpaqueCharacterPassProfileSampler         = GetObject<ProfileSampler>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ProfileSampler.FromPointer); // 0xF8 OpaqueCharacterPassProfileSampler ( ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )
            value.Asset                                     = GetObject<PrismRenderPipelineAsset>(new IntPtr(p + 0x100), ReversePrism.DataModels.PrismRenderPipelineAsset.FromPointer); // 0x100 Asset                       ( ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer )
            value.PrismRenderFrame                          = GetObject<PrismRenderFrame>(new IntPtr(p + 0x108), ReversePrism.DataModels.PrismRenderFrame.FromPointer); // 0x108 PrismRenderFrame            ( ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer )

            return value;
        }
    }
}
