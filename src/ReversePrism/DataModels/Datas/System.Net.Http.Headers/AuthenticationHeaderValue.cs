using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parameter                                000186671910 ModelPrimitiveType string string string String
    // 018 Scheme                                   000186671910 ModelPrimitiveType string string string String
    public partial class AuthenticationHeaderValue : DataModel
    {
        public string                                   Parameter                               { get; set; }
        public string                                   Scheme                                  { get; set; }

        public static AuthenticationHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthenticationHeaderValue() { Pointer= p0 };

            value.Parameter                                 = GetString(new IntPtr(p + 0x010)); // 02466B76BDA8 0x10 Parameter                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Scheme                                    = GetString(new IntPtr(p + 0x018)); // 02466B76BDC8 0x18 Scheme                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
