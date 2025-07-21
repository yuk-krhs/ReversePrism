using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Flag                                     ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class NullableContextAttribute : DataModel
    {
        public sbyte                                    Flag                                    { get; set; }

        public static NullableContextAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NullableContextAttribute() { Pointer= p0 };

            value.Flag                                      = GetSByte(new IntPtr(p + 0x010)); // 0x10 Flag                        ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
