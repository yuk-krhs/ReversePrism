using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_RenderPass                             000186654C50 ModelClassType RenderGraphPass RenderGraphPass RenderGraphPass Pointer
    // 018 M_Resources                              000186655FC0 ModelClassType RenderGraphResourceRegistry RenderGraphResourceRegistry RenderGraphResourceRegistry Pointer
    // 020 M_RenderGraph                            000186651FC0 ModelClassType RenderGraph RenderGraph RenderGraph Pointer
    // 028 M_Disposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RenderGraphBuilder
    {
        public RenderGraphPass?                         M_RenderPass                            { get; set; }
        public RenderGraphResourceRegistry?             M_Resources                             { get; set; }
        public RenderGraph?                             M_RenderGraph                           { get; set; }
        public bool                                     M_Disposed                              { get; set; }

        public static RenderGraphBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphBuilder();

            value.M_RenderPass                              = GetObject<RenderGraphPass>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderGraphPass.FromPointer); // 0270D90B4900 0x10 M_RenderPass                ( 000186654C50 ModelClassType RenderGraphPass RenderGraphPass RenderGraphPass Pointer )
            value.M_Resources                               = GetObject<RenderGraphResourceRegistry>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderGraphResourceRegistry.FromPointer); // 0270D90B4920 0x18 M_Resources                 ( 000186655FC0 ModelClassType RenderGraphResourceRegistry RenderGraphResourceRegistry RenderGraphResourceRegistry Pointer )
            value.M_RenderGraph                             = GetObject<RenderGraph>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderGraph.FromPointer); // 0270D90B4940 0x20 M_RenderGraph               ( 000186651FC0 ModelClassType RenderGraph RenderGraph RenderGraph Pointer )
            value.M_Disposed                                = GetBool(new IntPtr(p + 0x028)); // 0270D90B4960 0x28 M_Disposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
