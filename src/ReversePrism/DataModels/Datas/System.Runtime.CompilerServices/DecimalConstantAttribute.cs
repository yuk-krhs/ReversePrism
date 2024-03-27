using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dec                                      0001865C0970 ModelEnumType Decimal Decimal Decimal Int32
    public partial class DecimalConstantAttribute
    {
        public Decimal                                  Dec                                     { get; set; }

        public static DecimalConstantAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecimalConstantAttribute();

            value.Dec                                       = (Decimal)GetInt32(new IntPtr(p + 0x010)); // 0270D6CA6CB8 0x10 Dec                         ( 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32 )

            return value;
        }
    }
}
