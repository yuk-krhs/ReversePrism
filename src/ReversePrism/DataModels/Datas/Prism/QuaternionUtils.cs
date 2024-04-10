using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_FloatMin                               float IL2CPP_TYPE_R4
    // 000 zero                                     Quaternion IL2CPP_TYPE_VALUETYPE
    public partial class QuaternionUtils : DataModel
    {

        public static QuaternionUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuaternionUtils() { Pointer= p0 };


            return value;
        }
    }
}
