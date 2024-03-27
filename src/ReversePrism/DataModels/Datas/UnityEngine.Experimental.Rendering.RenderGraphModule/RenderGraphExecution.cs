using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderGraph                              000186651FC0 ModelClassType RenderGraph RenderGraph RenderGraph Pointer
    public partial class RenderGraphExecution
    {
        public RenderGraph?                             RenderGraph                             { get; set; }

        public static RenderGraphExecution? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphExecution();

            value.RenderGraph                               = GetObject<RenderGraph>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderGraph.FromPointer); // 0270D9079590 0x10 RenderGraph                 ( 000186651FC0 ModelClassType RenderGraph RenderGraph RenderGraph Pointer )

            return value;
        }
    }
}
