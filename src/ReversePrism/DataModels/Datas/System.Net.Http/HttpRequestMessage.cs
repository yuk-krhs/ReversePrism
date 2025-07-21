using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Headers                                  ModelClassType HttpRequestHeaders HttpRequestHeaders HttpRequestHeaders Pointer
    // 018 Method                                   ModelClassType HttpMethod HttpMethod HttpMethod Pointer
    // 020 Version                                  ModelClassType Version Version Version Pointer
    // 028 Uri                                      ModelClassType Uri Uri Uri Pointer
    // 030 Is_used                                  ModelPrimitiveType bool bool bool Bool
    // 031 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 038 Content                                  ModelClassType HttpContent HttpContent HttpContent Pointer
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

            value.Headers                                   = GetObject<HttpRequestHeaders>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpRequestHeaders.FromPointer); // 0x10 Headers                     ( ModelClassType HttpRequestHeaders HttpRequestHeaders HttpRequestHeaders Pointer )
            value.Method                                    = GetObject<HttpMethod>(new IntPtr(p + 0x018), ReversePrism.DataModels.HttpMethod.FromPointer); // 0x18 Method                      ( ModelClassType HttpMethod HttpMethod HttpMethod Pointer )
            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x020), ReversePrism.DataModels.Version.FromPointer); // 0x20 Version                     ( ModelClassType Version Version Version Pointer )
            value.Uri                                       = GetObject<Uri>(new IntPtr(p + 0x028), ReversePrism.DataModels.Uri.FromPointer); // 0x28 Uri                         ( ModelClassType Uri Uri Uri Pointer )
            value.Is_used                                   = GetBool(new IntPtr(p + 0x030)); // 0x30 Is_used                     ( ModelPrimitiveType bool bool bool Bool )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x031)); // 0x31 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.Content                                   = GetObject<HttpContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.HttpContent.FromPointer); // 0x38 Content                     ( ModelClassType HttpContent HttpContent HttpContent Pointer )

            return value;
        }
    }
}
