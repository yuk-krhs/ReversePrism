using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Headers                                  0001866E2A10 ModelClassType HttpRequestHeaders HttpRequestHeaders HttpRequestHeaders Pointer
    // 018 Method                                   0001866E0A40 ModelClassType HttpMethod HttpMethod HttpMethod Pointer
    // 020 Version                                  0001866B0CC0 ModelClassType Version Version Version Pointer
    // 028 Uri                                      0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 030 Is_used                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Content                                  0001866DD4E0 ModelClassType HttpContent HttpContent HttpContent Pointer
    public partial class HttpRequestMessage : DataModel
    {
        public HttpRequestHeaders?                      Headers                                 { get; set; }
        public HttpMethod?                              Method                                  { get; set; }
        public Version?                                 Version                                 { get; set; }
        public Uri?                                     Uri                                     { get; set; }
        public bool                                     Is_used                                 { get; set; }
        public bool                                     Disposed                                { get; set; }
        public HttpContent?                             Content                                 { get; set; }

        public static HttpRequestMessage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpRequestMessage() { Pointer= p0 };

            value.Headers                                   = GetObject<HttpRequestHeaders>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpRequestHeaders.FromPointer); // 02466B8A9520 0x10 Headers                     ( 0001866E2A10 ModelClassType HttpRequestHeaders HttpRequestHeaders HttpRequestHeaders Pointer )
            value.Method                                    = GetObject<HttpMethod>(new IntPtr(p + 0x018), ReversePrism.DataModels.HttpMethod.FromPointer); // 02466B8A9540 0x18 Method                      ( 0001866E0A40 ModelClassType HttpMethod HttpMethod HttpMethod Pointer )
            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x020), ReversePrism.DataModels.Version.FromPointer); // 02466B8A9560 0x20 Version                     ( 0001866B0CC0 ModelClassType Version Version Version Pointer )
            value.Uri                                       = GetObject<Uri>(new IntPtr(p + 0x028), ReversePrism.DataModels.Uri.FromPointer); // 02466B8A9580 0x28 Uri                         ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.Is_used                                   = GetBool(new IntPtr(p + 0x030)); // 02466B8A95A0 0x30 Is_used                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x031)); // 02466B8A95C0 0x31 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Content                                   = GetObject<HttpContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.HttpContent.FromPointer); // 02466B8A95E0 0x38 Content                     ( 0001866DD4E0 ModelClassType HttpContent HttpContent HttpContent Pointer )

            return value;
        }
    }
}
