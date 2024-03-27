using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 hdrColorSpace                            int IL2CPP_TYPE_I4
    // 004 hdrEncoding                              int IL2CPP_TYPE_I4
    public partial class ShaderPropertyId
    {

        public static ShaderPropertyId? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderPropertyId();


            return value;
        }
    }
}
