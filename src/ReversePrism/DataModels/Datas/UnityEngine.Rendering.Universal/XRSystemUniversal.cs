using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_projMatrix                             Matrix4x4[] IL2CPP_TYPE_SZARRAY
    public partial class XRSystemUniversal : DataModel
    {

        public static XRSystemUniversal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRSystemUniversal() { Pointer= p0 };


            return value;
        }
    }
}
