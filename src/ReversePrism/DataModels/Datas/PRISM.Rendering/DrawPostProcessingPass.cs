using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ProfileTag                               string IL2CPP_TYPE_STRING
    // 000 ProfileDrawAllSampler                    ProfileSampler IL2CPP_TYPE_CLASS
    // 010 PostProcessingContext                    00018676D710 ModelClassType PostProcessRenderContext PostProcessRenderContext PostProcessRenderContext Pointer
    // 018 RenderTargetIdentifiers                  000185CA0AC8 ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer
    public partial class DrawPostProcessingPass
    {
        public PostProcessRenderContext?                PostProcessingContext                   { get; set; }
        public List<RenderTargetIdentifier>?            RenderTargetIdentifiers                 { get; set; }

        public static DrawPostProcessingPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawPostProcessingPass();

            value.PostProcessingContext                     = GetObject<PostProcessRenderContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.PostProcessRenderContext.FromPointer); // 0270D0AC1640 0x10 PostProcessingContext       ( 00018676D710 ModelClassType PostProcessRenderContext PostProcessRenderContext PostProcessRenderContext Pointer )
            value.RenderTargetIdentifiers                   = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x018)); // 0270D0AC1660 0x18 RenderTargetIdentifiers     ( 000185CA0AC8 ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer )

            return value;
        }
    }
}
