using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_callingConvention                      000186533B30 ModelEnumType CallingConvention CallingConvention CallingConvention Int32
    public partial class UnmanagedFunctionPointerAttribute
    {
        public CallingConvention                        M_callingConvention                     { get; set; }

        public static UnmanagedFunctionPointerAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnmanagedFunctionPointerAttribute();

            value.M_callingConvention                       = (CallingConvention)GetInt32(new IntPtr(p + 0x010)); // 0270D6C82280 0x10 M_callingConvention         ( 000186533B30 ModelEnumType CallingConvention CallingConvention CallingConvention Int32 )

            return value;
        }
    }
}
