using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reserved                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class PlatformConfig
    {
        public sbyte                                    Reserved                                { get; set; }

        public static PlatformConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlatformConfig();

            value.Reserved                                  = GetSByte(new IntPtr(p + 0x010)); // 0270DAC2AC08 0x10 Reserved                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
