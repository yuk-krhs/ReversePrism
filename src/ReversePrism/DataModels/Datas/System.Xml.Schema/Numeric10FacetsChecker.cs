using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 signs                                    char[] IL2CPP_TYPE_SZARRAY
    // 010 MaxValue                                 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32
    // 020 MinValue                                 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32
    public partial class Numeric10FacetsChecker
    {
        public Decimal                                  MaxValue                                { get; set; }
        public Decimal                                  MinValue                                { get; set; }

        public static Numeric10FacetsChecker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Numeric10FacetsChecker();

            value.MaxValue                                  = (Decimal)GetInt32(new IntPtr(p + 0x010)); // 0270D7528028 0x10 MaxValue                    ( 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32 )
            value.MinValue                                  = (Decimal)GetInt32(new IntPtr(p + 0x020)); // 0270D7528048 0x20 MinValue                    ( 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32 )

            return value;
        }
    }
}
