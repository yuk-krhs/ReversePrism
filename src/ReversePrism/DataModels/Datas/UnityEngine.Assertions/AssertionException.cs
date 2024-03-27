using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 M_UserMessage                            000186671910 ModelPrimitiveType string string string String
    public partial class AssertionException
    {
        public string                                   M_UserMessage                           { get; set; }

        public static AssertionException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssertionException();

            value.M_UserMessage                             = GetString(new IntPtr(p + 0x090)); // 0270068D8A00 0x90 M_UserMessage               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
