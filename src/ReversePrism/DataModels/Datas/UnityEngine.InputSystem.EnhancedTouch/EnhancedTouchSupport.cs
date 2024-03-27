using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Enabled                                int IL2CPP_TYPE_I4
    // 004 s_UpdateMode                             UpdateMode IL2CPP_TYPE_VALUETYPE
    public partial class EnhancedTouchSupport
    {

        public static EnhancedTouchSupport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnhancedTouchSupport();


            return value;
        }
    }
}
