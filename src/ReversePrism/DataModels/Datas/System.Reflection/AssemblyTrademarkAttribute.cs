using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Trademark                                000186672F10 ModelPrimitiveType string string string String
    public partial class AssemblyTrademarkAttribute
    {
        public string                                   Trademark                               { get; set; }

        public static AssemblyTrademarkAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyTrademarkAttribute();

            value.Trademark                                 = GetString(new IntPtr(p + 0x010)); // 0270D6CE8EB8 0x10 Trademark                   ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
