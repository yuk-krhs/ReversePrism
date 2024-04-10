using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dbl                                      0001865C2E50 ModelPrimitiveType double double double Double
    // 010 Uu                                       00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class DoubleUlong : DataModel
    {
        public double                                   Dbl                                     { get; set; }
        public ulong                                    Uu                                      { get; set; }

        public static DoubleUlong? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DoubleUlong() { Pointer= p0 };

            value.Dbl                                       = GetDouble(new IntPtr(p + 0x010)); // 02466BC22490 0x10 Dbl                         ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Uu                                        = GetUInt64(new IntPtr(p + 0x010)); // 02466BC224B0 0x10 Uu                          ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
