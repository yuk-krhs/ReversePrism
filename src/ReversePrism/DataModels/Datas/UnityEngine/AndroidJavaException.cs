using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 MJavaStackTrace                          000186671910 ModelPrimitiveType string string string String
    public partial class AndroidJavaException
    {
        public string                                   MJavaStackTrace                         { get; set; }

        public static AndroidJavaException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AndroidJavaException();

            value.MJavaStackTrace                           = GetString(new IntPtr(p + 0x090)); // 0270069446B8 0x90 MJavaStackTrace             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
