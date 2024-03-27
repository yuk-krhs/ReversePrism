using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FLOAT_MAX                                float IL2CPP_TYPE_R4
    // 000 FLOAT_MIN                                float IL2CPP_TYPE_R4
    // 000 INT_MAX                                  int IL2CPP_TYPE_I4
    // 000 INT_MIN                                  int IL2CPP_TYPE_I4
    // 000 FLOAT_UNSET                              float IL2CPP_TYPE_R4
    // 000 INT_UNSET                                int IL2CPP_TYPE_I4
    // 000 MAX_16BIT                                Vector2 IL2CPP_TYPE_VALUETYPE
    // 008 MIN_16BIT                                Vector2 IL2CPP_TYPE_VALUETYPE
    public partial class TMP_Math
    {

        public static TMP_Math? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_Math();


            return value;
        }
    }
}
