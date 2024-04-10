using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 assetsCreateShaderMenuPriority           int IL2CPP_TYPE_I4
    // 000 assetsCreateRenderingMenuPriority        int IL2CPP_TYPE_I4
    // 000 editMenuPriority                         int IL2CPP_TYPE_I4
    // 000 gameObjectMenuPriority                   int IL2CPP_TYPE_I4
    // 000 srpLensFlareMenuPriority                 int IL2CPP_TYPE_I4
    public partial class Priorities : DataModel
    {

        public static Priorities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Priorities() { Pointer= p0 };


            return value;
        }
    }
}
