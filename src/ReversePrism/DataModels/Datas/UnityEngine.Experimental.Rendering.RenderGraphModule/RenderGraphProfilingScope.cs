using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Disposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_Sampler                                0001865CD0D0 ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 020 M_RenderGraph                            000186651FC0 ModelClassType RenderGraph RenderGraph RenderGraph Pointer
    public partial class RenderGraphProfilingScope : DataModel
    {
        public bool                                     M_Disposed                              { get; set; }
        public ProfilingSampler?                        M_Sampler                               { get; set; }
        public RenderGraph?                             M_RenderGraph                           { get; set; }

        public static RenderGraphProfilingScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphProfilingScope() { Pointer= p0 };

            value.M_Disposed                                = GetBool(new IntPtr(p + 0x010)); // 024669107B78 0x10 M_Disposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Sampler                                 = GetObject<ProfilingSampler>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 024669107B98 0x18 M_Sampler                   ( 0001865CD0D0 ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_RenderGraph                             = GetObject<RenderGraph>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderGraph.FromPointer); // 024669107BB8 0x20 M_RenderGraph               ( 000186651FC0 ModelClassType RenderGraph RenderGraph RenderGraph Pointer )

            return value;
        }
    }
}
