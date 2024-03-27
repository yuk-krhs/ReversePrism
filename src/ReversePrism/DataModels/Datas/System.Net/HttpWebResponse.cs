using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Uri                                      0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 028 WebHeaders                               00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 030 CookieCollection                         00018661E7C0 ModelClassType CookieCollection CookieCollection CookieCollection Pointer
    // 038 Method                                   000186671910 ModelPrimitiveType string string string String
    // 040 Version                                  0001866B0CC0 ModelClassType Version Version Version Pointer
    // 048 StatusCode                               0001866E4710 ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32
    // 050 StatusDescription                        000186671910 ModelPrimitiveType string string string String
    // 058 ContentLength                            0001865F7700 ModelPrimitiveType long long long Int64
    // 060 ContentType                              000186671910 ModelPrimitiveType string string string String
    // 068 Cookie_container                         00018661EC40 ModelClassType CookieContainer CookieContainer CookieContainer Pointer
    // 070 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 Stream                                   000186670270 ModelClassType Stream Stream Stream Pointer
    public partial class HttpWebResponse
    {
        public Uri?                                     Uri                                     { get; set; }
        public WebHeaderCollection?                     WebHeaders                              { get; set; }
        public CookieCollection?                        CookieCollection                        { get; set; }
        public string                                   Method                                  { get; set; }
        public Version?                                 Version                                 { get; set; }
        public HttpStatusCode                           StatusCode                              { get; set; }
        public string                                   StatusDescription                       { get; set; }
        public long                                     ContentLength                           { get; set; }
        public string                                   ContentType                             { get; set; }
        public CookieContainer?                         Cookie_container                        { get; set; }
        public bool                                     Disposed                                { get; set; }
        public Stream?                                  Stream                                  { get; set; }

        public static HttpWebResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpWebResponse();

            value.Uri                                       = GetObject<Uri>(new IntPtr(p + 0x020), ReversePrism.DataModels.Uri.FromPointer); // 0270D7A66D00 0x20 Uri                         ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.WebHeaders                                = GetObject<WebHeaderCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0270D7A66D20 0x28 WebHeaders                  ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.CookieCollection                          = GetObject<CookieCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.CookieCollection.FromPointer); // 0270D7A66D40 0x30 CookieCollection            ( 00018661E7C0 ModelClassType CookieCollection CookieCollection CookieCollection Pointer )
            value.Method                                    = GetString(new IntPtr(p + 0x038)); // 0270D7A66D60 0x38 Method                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x040), ReversePrism.DataModels.Version.FromPointer); // 0270D7A66D80 0x40 Version                     ( 0001866B0CC0 ModelClassType Version Version Version Pointer )
            value.StatusCode                                = (HttpStatusCode)GetInt32(new IntPtr(p + 0x048)); // 0270D7A66DA0 0x48 StatusCode                  ( 0001866E4710 ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32 )
            value.StatusDescription                         = GetString(new IntPtr(p + 0x050)); // 0270D7A66DC0 0x50 StatusDescription           ( 000186671910 ModelPrimitiveType string string string String )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x058)); // 0270D7A66DE0 0x58 ContentLength               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ContentType                               = GetString(new IntPtr(p + 0x060)); // 0270D7A66E00 0x60 ContentType                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Cookie_container                          = GetObject<CookieContainer>(new IntPtr(p + 0x068), ReversePrism.DataModels.CookieContainer.FromPointer); // 0270D7A66E20 0x68 Cookie_container            ( 00018661EC40 ModelClassType CookieContainer CookieContainer CookieContainer Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x070)); // 0270D7A66E40 0x70 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x078), ReversePrism.DataModels.Stream.FromPointer); // 0270D7A66E60 0x78 Stream                      ( 000186670270 ModelClassType Stream Stream Stream Pointer )

            return value;
        }
    }
}
