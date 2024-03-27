using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uri                                      000186671910 ModelPrimitiveType string string string String
    public partial class ErrorMessage
    {
        public string                                   Uri                                     { get; set; }

        public static ErrorMessage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorMessage();

            value.Uri                                       = GetString(new IntPtr(p + 0x010)); // 0270D6BE98D0 0x10 Uri                         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
