using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_Name                                   string IL2CPP_TYPE_STRING
    // 000 setupCullingParameters                   ProfilingSampler IL2CPP_TYPE_CLASS
    // 008 setup                                    ProfilingSampler IL2CPP_TYPE_CLASS
    public partial class Renderer : DataModel
    {

        public static Renderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Renderer() { Pointer= p0 };


            return value;
        }
    }
}
