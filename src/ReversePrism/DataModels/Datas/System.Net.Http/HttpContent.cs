using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buffer                                   0001865642D0 ModelClassType FixedMemoryStream FixedMemoryStream FixedMemoryStream Pointer
    // 018 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 Headers                                  0001866DDE60 ModelClassType HttpContentHeaders HttpContentHeaders HttpContentHeaders Pointer
    public partial class HttpContent
    {
        public FixedMemoryStream?                       Buffer                                  { get; set; }
        public bool                                     Disposed                                { get; set; }
        public HttpContentHeaders?                      Headers                                 { get; set; }

        public static HttpContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpContent();

            value.Buffer                                    = GetObject<FixedMemoryStream>(new IntPtr(p + 0x010), ReversePrism.DataModels.FixedMemoryStream.FromPointer); // 0270DB82B400 0x10 Buffer                      ( 0001865642D0 ModelClassType FixedMemoryStream FixedMemoryStream FixedMemoryStream Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x018)); // 0270DB82B420 0x18 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Headers                                   = GetObject<HttpContentHeaders>(new IntPtr(p + 0x020), ReversePrism.DataModels.HttpContentHeaders.FromPointer); // 0270DB82B440 0x20 Headers                     ( 0001866DDE60 ModelClassType HttpContentHeaders HttpContentHeaders HttpContentHeaders Pointer )

            return value;
        }
    }
}
