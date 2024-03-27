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
    public partial class AuthenticationHeaderValue
    {
        public string                                   Parameter                               { get; set; }
        public string                                   Scheme                                  { get; set; }

        public static AuthenticationHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthenticationHeaderValue();

            value.Parameter                                 = GetString(new IntPtr(p + 0x010)); // 0270DB6DF370 0x10 Parameter                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Scheme                                    = GetString(new IntPtr(p + 0x018)); // 0270DB6DF390 0x18 Scheme                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
