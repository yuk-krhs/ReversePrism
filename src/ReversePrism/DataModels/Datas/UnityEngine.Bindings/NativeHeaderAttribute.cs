using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Header                                   000186671910 ModelPrimitiveType string string string String
    public partial class NativeHeaderAttribute
    {
        public string                                   Header                                  { get; set; }

        public static NativeHeaderAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeHeaderAttribute();

            value.Header                                    = GetString(new IntPtr(p + 0x010)); // 027006978C48 0x10 Header                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
