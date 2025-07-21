using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Is3DRendering>k__BackingField           bool IL2CPP_TYPE_BOOLEAN
    // 008 OnBeforeRendering3D                      RenderCallback IL2CPP_TYPE_CLASS
    public partial class PrismRenderManager : DataModel
    {

        public static PrismRenderManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismRenderManager() { Pointer= p0 };


            return value;
        }
    }
}
