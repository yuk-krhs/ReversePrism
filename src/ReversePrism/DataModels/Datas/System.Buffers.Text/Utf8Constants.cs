using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_nullUtcOffset                          TimeSpan IL2CPP_TYPE_VALUETYPE
    public partial class Utf8Constants
    {

        public static Utf8Constants? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Utf8Constants();


            return value;
        }
    }
}
