using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 textureLoaded                            Action`1<CustomRenderTexture> IL2CPP_TYPE_GENERICINST
    // 008 textureUnloaded                          Action`1<CustomRenderTexture> IL2CPP_TYPE_GENERICINST
    public partial class CustomRenderTextureManager
    {

        public static CustomRenderTextureManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomRenderTextureManager();


            return value;
        }
    }
}
