using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   ThrottleFrame<<var>> IL2CPP_TYPE_GENERICINST
    // 000 currentid                                ulong IL2CPP_TYPE_U8
    public partial class ThrottleFrameTick
    {

        public static ThrottleFrameTick? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThrottleFrameTick();


            return value;
        }
    }
}
