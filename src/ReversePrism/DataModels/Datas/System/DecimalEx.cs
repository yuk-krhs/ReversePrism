using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ScaleShift                               int IL2CPP_TYPE_I4
    public partial class DecimalEx
    {

        public static DecimalEx? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecimalEx();


            return value;
        }
    }
}
