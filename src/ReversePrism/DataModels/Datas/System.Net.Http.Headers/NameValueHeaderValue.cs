using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    000186671BA0 ModelPrimitiveType string string string String
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    public partial class NameValueHeaderValue
    {
        public string                                   Value                                   { get; set; }
        public string                                   Name                                    { get; set; }

        public static NameValueHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameValueHeaderValue();

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 0270DB8460A8 0x10 Value                       ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270DB8460C8 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
