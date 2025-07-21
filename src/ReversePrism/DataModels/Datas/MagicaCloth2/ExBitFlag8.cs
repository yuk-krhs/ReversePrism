using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class ExBitFlag8 : DataModel
    {
        public sbyte                                    Value                                   { get; set; }

        public static ExBitFlag8? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExBitFlag8() { Pointer= p0 };

            value.Value                                     = GetSByte(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
