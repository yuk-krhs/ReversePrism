using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NoPrecision                              sbyte IL2CPP_TYPE_U1
    // 000 MaxPrecision                             sbyte IL2CPP_TYPE_U1
    // 010 Format                                   00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Precision                                00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 000 FormatStringLength                       int IL2CPP_TYPE_I4
    public partial class StandardFormat
    {
        public sbyte                                    Format                                  { get; set; }
        public sbyte                                    Precision                               { get; set; }

        public static StandardFormat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StandardFormat();

            value.Format                                    = GetSByte(new IntPtr(p + 0x010)); // 027003CA1038 0x10 Format                      ( 00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Precision                                 = GetSByte(new IntPtr(p + 0x011)); // 027003CA1058 0x11 Precision                   ( 00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
