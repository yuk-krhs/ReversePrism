using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Fraction> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NumeratorFieldNumber                     int IL2CPP_TYPE_I4
    // 018 Numerator                                0001865F7700 ModelPrimitiveType long long long Int64
    // 000 DenominatorFieldNumber                   int IL2CPP_TYPE_I4
    // 020 Denominator                              0001865F7700 ModelPrimitiveType long long long Int64
    public partial class Fraction : DataModel
    {
        public long                                     Numerator                               { get; set; }
        public long                                     Denominator                             { get; set; }

        public static Fraction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Fraction() { Pointer= p0 };

            value.Numerator                                 = GetInt64(new IntPtr(p + 0x018)); // 02466A6FDC10 0x18 Numerator                   ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Denominator                               = GetInt64(new IntPtr(p + 0x020)); // 02466A6FDC50 0x20 Denominator                 ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
