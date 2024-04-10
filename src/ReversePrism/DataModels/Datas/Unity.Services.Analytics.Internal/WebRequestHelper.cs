using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 K_ClientIdHeaderValue                    000186672F10 ModelPrimitiveType string string string String
    public partial class WebRequestHelper : DataModel
    {
        public string                                   K_ClientIdHeaderValue                   { get; set; }

        public static WebRequestHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebRequestHelper() { Pointer= p0 };

            value.K_ClientIdHeaderValue                     = GetString(new IntPtr(p + 0x010)); // 0245A6683B08 0x10 K_ClientIdHeaderValue       ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
