using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Uri                                      ModelClassType Uri Uri Uri Pointer
    // 028 WebHeaders                               ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 030 CookieCollection                         ModelClassType CookieCollection CookieCollection CookieCollection Pointer
    // 038 Method                                   ModelPrimitiveType string string string String
    // 040 Version                                  ModelClassType Version Version Version Pointer
    // 048 StatusCode                               ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32
    // 050 StatusDescription                        ModelPrimitiveType string string string String
    // 058 ContentLength                            ModelPrimitiveType long long long Int64
    // 060 ContentType                              ModelPrimitiveType string string string String
    // 068 Cookie_container                         ModelClassType CookieContainer CookieContainer CookieContainer Pointer
    // 070 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 078 Stream                                   ModelClassType Stream Stream Stream Pointer
    public partial class HttpWebResponse : DataModel
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
            var value   = new HttpWebResponse() { Pointer= p0 };

            value.Uri                                       = GetObject<Uri>(new IntPtr(p + 0x020), ReversePrism.DataModels.Uri.FromPointer); // 0x20 Uri                         ( ModelClassType Uri Uri Uri Pointer )
            value.WebHeaders                                = GetObject<WebHeaderCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0x28 WebHeaders                  ( ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.CookieCollection                          = GetObject<CookieCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.CookieCollection.FromPointer); // 0x30 CookieCollection            ( ModelClassType CookieCollection CookieCollection CookieCollection Pointer )
            value.Method                                    = GetString(new IntPtr(p + 0x038)); // 0x38 Method                      ( ModelPrimitiveType string string string String )
            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x040), ReversePrism.DataModels.Version.FromPointer); // 0x40 Version                     ( ModelClassType Version Version Version Pointer )
            value.StatusCode                                = (HttpStatusCode)GetInt32(new IntPtr(p + 0x048)); // 0x48 StatusCode                  ( ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32 )
            value.StatusDescription                         = GetString(new IntPtr(p + 0x050)); // 0x50 StatusDescription           ( ModelPrimitiveType string string string String )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x058)); // 0x58 ContentLength               ( ModelPrimitiveType long long long Int64 )
            value.ContentType                               = GetString(new IntPtr(p + 0x060)); // 0x60 ContentType                 ( ModelPrimitiveType string string string String )
            value.Cookie_container                          = GetObject<CookieContainer>(new IntPtr(p + 0x068), ReversePrism.DataModels.CookieContainer.FromPointer); // 0x68 Cookie_container            ( ModelClassType CookieContainer CookieContainer CookieContainer Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x070)); // 0x70 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x078), ReversePrism.DataModels.Stream.FromPointer); // 0x78 Stream                      ( ModelClassType Stream Stream Stream Pointer )

            return value;
        }
    }
}
