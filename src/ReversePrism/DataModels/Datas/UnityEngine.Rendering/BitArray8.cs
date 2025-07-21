using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class BitArray8 : DataModel
    {
        public sbyte                                    Data                                    { get; set; }

        public static BitArray8? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitArray8() { Pointer= p0 };

            value.Data                                      = GetSByte(new IntPtr(p + 0x010)); // 0x10 Data                        ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
