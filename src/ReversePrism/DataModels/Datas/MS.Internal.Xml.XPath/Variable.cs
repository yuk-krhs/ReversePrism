using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Localname                                000186671910 ModelPrimitiveType string string string String
    // 018 Prefix                                   000186671910 ModelPrimitiveType string string string String
    public partial class Variable
    {
        public string                                   Localname                               { get; set; }
        public string                                   Prefix                                  { get; set; }

        public static Variable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Variable();

            value.Localname                                 = GetString(new IntPtr(p + 0x010)); // 0270D761B230 0x10 Localname                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 0270D761B250 0x18 Prefix                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
