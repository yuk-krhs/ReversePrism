using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 doubleRoundLimit                         double IL2CPP_TYPE_R8
    // 008 roundPower10Double                       double[] IL2CPP_TYPE_SZARRAY
    public partial class Math
    {

        public static Math? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Math();


            return value;
        }
    }
}
