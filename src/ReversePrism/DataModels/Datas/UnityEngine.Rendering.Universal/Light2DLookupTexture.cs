using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_PointLightLookupTexture                Texture2D IL2CPP_TYPE_CLASS
    public partial class Light2DLookupTexture : DataModel
    {

        public static Light2DLookupTexture? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Light2DLookupTexture() { Pointer= p0 };


            return value;
        }
    }
}
