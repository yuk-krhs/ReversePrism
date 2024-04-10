using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    000186671910 ModelPrimitiveType string string string String
    public partial class CollationAttribute : DataModel
    {
        public string                                   Value                                   { get; set; }

        public static CollationAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollationAttribute() { Pointer= p0 };

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 0245A3DA33A0 0x10 Value                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
