using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Headers                                  ModelClassType HttpResponseHeaders HttpResponseHeaders HttpResponseHeaders Pointer
    // 018 ReasonPhrase                             ModelPrimitiveType string string string String
    // 020 StatusCode                               ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32
    // 028 Version                                  ModelClassType Version Version Version Pointer
    // 030 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 038 Content                                  ModelClassType HttpContent HttpContent HttpContent Pointer
    // 040 RequestMessage                           ModelClassType HttpRequestMessage HttpRequestMessage HttpRequestMessage Pointer
    public partial class HttpResponseMessage : DataModel
    {
        public HttpResponseHeaders?                     Headers                                 { get; set; }
        public string                                   ReasonPhrase                            { get; set; }
        public HttpStatusCode                           StatusCode                              { get; set; }
        public Version?                                 Version                                 { get; set; }
        public bool                                     Disposed                                { get; set; }
        public HttpContent?                             Content                                 { get; set; }
        public HttpRequestMessage?                      RequestMessage                          { get; set; }

        public static HttpResponseMessage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpResponseMessage() { Pointer= p0 };

            value.Headers                                   = GetObject<HttpResponseHeaders>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpResponseHeaders.FromPointer); // 0x10 Headers                     ( ModelClassType HttpResponseHeaders HttpResponseHeaders HttpResponseHeaders Pointer )
            value.ReasonPhrase                              = GetString(new IntPtr(p + 0x018)); // 0x18 ReasonPhrase                ( ModelPrimitiveType string string string String )
            value.StatusCode                                = (HttpStatusCode)GetInt32(new IntPtr(p + 0x020)); // 0x20 StatusCode                  ( ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32 )
            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x028), ReversePrism.DataModels.Version.FromPointer); // 0x28 Version                     ( ModelClassType Version Version Version Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.Content                                   = GetObject<HttpContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.HttpContent.FromPointer); // 0x38 Content                     ( ModelClassType HttpContent HttpContent HttpContent Pointer )
            value.RequestMessage                            = GetObject<HttpRequestMessage>(new IntPtr(p + 0x040), ReversePrism.DataModels.HttpRequestMessage.FromPointer); // 0x40 RequestMessage              ( ModelClassType HttpRequestMessage HttpRequestMessage HttpRequestMessage Pointer )

            return value;
        }
    }
}
