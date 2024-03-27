using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class VolatileBoolean
    {
        public bool                                     Value                                   { get; set; }

        public static VolatileBoolean? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VolatileBoolean();

            value.Value                                     = GetBool(new IntPtr(p + 0x010)); // 0270D6AF3EB8 0x10 Value                       ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
