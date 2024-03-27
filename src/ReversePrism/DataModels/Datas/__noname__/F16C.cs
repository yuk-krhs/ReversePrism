using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BaseTable                                ushort[] IL2CPP_TYPE_SZARRAY
    // 008 ShiftTable                               sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class F16C
    {

        public static F16C? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new F16C();


            return value;
        }
    }
}
