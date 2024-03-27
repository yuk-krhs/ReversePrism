using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMinExtrapolationTime                    double IL2CPP_TYPE_R8
    public partial class Extrapolation
    {

        public static Extrapolation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Extrapolation();


            return value;
        }
    }
}
