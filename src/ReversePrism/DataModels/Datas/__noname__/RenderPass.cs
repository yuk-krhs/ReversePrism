using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_Name                                   string IL2CPP_TYPE_STRING
    // 000 configure                                ProfilingSampler IL2CPP_TYPE_CLASS
    // 008 setRenderPassAttachments                 ProfilingSampler IL2CPP_TYPE_CLASS
    public partial class RenderPass : DataModel
    {

        public static RenderPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderPass() { Pointer= p0 };


            return value;
        }
    }
}
