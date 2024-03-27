using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 renderChains                             List`1<RenderChain> IL2CPP_TYPE_GENERICINST
    public partial class RenderChainStaticIndexAllocator
    {

        public static RenderChainStaticIndexAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderChainStaticIndexAllocator();


            return value;
        }
    }
}
