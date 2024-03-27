using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TagTypeBits                              int IL2CPP_TYPE_I4
    // 000 TagTypeMask                              uint IL2CPP_TYPE_U4
    public partial class WireFormat
    {

        public static WireFormat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WireFormat();


            return value;
        }
    }
}
