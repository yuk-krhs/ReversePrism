using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PositiveInvariantFormatLiterals          FormatLiterals IL2CPP_TYPE_VALUETYPE
    // 028 NegativeInvariantFormatLiterals          ModelEnumType FormatLiterals FormatLiterals FormatLiterals Int32
    public partial class TimeSpanFormat : DataModel
    {
        public FormatLiterals                           NegativeInvariantFormatLiterals         { get; set; }

        public static TimeSpanFormat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSpanFormat() { Pointer= p0 };

            value.NegativeInvariantFormatLiterals           = (FormatLiterals)GetInt32(new IntPtr(p + 0x028)); // 0x28 NegativeInvariantFormatLiterals ( ModelEnumType FormatLiterals FormatLiterals FormatLiterals Int32 )

            return value;
        }
    }
}
