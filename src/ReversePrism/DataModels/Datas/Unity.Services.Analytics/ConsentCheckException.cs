using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 Reason                                   000186605160 ModelEnumType ConsentCheckExceptionReason ConsentCheckExceptionReason ConsentCheckExceptionReason Int32
    public partial class ConsentCheckException : DataModel
    {
        public ConsentCheckExceptionReason              Reason                                  { get; set; }

        public static ConsentCheckException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConsentCheckException() { Pointer= p0 };

            value.Reason                                    = (ConsentCheckExceptionReason)GetInt32(new IntPtr(p + 0x098)); // 02466B83F8C0 0x98 Reason                      ( 000186605160 ModelEnumType ConsentCheckExceptionReason ConsentCheckExceptionReason ConsentCheckExceptionReason Int32 )

            return value;
        }
    }
}
