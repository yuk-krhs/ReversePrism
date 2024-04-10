using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 RequestUri                               0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 040 ActualUri                                0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 048 HostChanged                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 AllowAutoRedirect                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04A AllowBuffering                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 Certificates                             0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 058 ConnectionGroup                          000186671910 ModelPrimitiveType string string string String
    // 060 HaveContentLength                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 ContentLength                            0001865F7700 ModelPrimitiveType long long long Int64
    // 070 ContinueDelegate                         0001866DE360 ModelClassType HttpContinueDelegate HttpContinueDelegate HttpContinueDelegate Pointer
    // 078 CookieContainer                          00018661EC40 ModelClassType CookieContainer CookieContainer CookieContainer Pointer
    // 080 Credentials                              000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer
    // 088 HaveResponse                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 089 RequestSent                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 090 WebHeaders                               00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 098 KeepAlive                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09C MaxAutoRedirect                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A0 MediaType                                000186671910 ModelPrimitiveType string string string String
    // 0A8 Method                                   000186671910 ModelPrimitiveType string string string String
    // 0B0 InitialMethod                            000186671910 ModelPrimitiveType string string string String
    // 0B8 Pipelined                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B9 PreAuthenticate                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0BA UsedPreAuth                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C0 Version                                  0001866B0CC0 ModelClassType Version Version Version Pointer
    // 0C8 Force_version                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D0 ActualVersion                            0001866B0CC0 ModelClassType Version Version Version Pointer
    // 0D8 Proxy                                    00018669AB30 ModelClassType IWebProxy IWebProxy IWebProxy Pointer
    // 0E0 SendChunked                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E8 ServicePoint                             000186738E90 ModelClassType ServicePoint ServicePoint ServicePoint Pointer
    // 0F0 Timeout                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0F4 ContinueTimeout                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0F8 WriteStream                              00018654FDC0 ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer
    // 100 WebResponse                              0001866E6430 ModelClassType HttpWebResponse HttpWebResponse HttpWebResponse Pointer
    // 108 ResponseTask                             000186547C40 ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer
    // 110 CurrentOperation                         00018654C440 ModelClassType WebOperation WebOperation WebOperation Pointer
    // 118 Aborted                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 11C GotRequestStream                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 120 Redirects                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 124 ExpectContinue                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 125 GetResponseCalled                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 128 locker                                   <object> IL2CPP_TYPE_OBJECT
    // 130 Finished_reading                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 134 Auto_decomp                              0001866AE1C0 ModelEnumType DecompressionMethods DecompressionMethods DecompressionMethods Int32
    // 000 defaultMaxResponseHeadersLength          int IL2CPP_TYPE_I4
    // 004 defaultMaximumErrorResponseLength        int IL2CPP_TYPE_I4
    // 008 defaultCachePolicy                       RequestCachePolicy IL2CPP_TYPE_CLASS
    // 138 ReadWriteTimeout                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 140 TlsProvider                              000186637CF0 ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer
    // 148 TlsSettings                              000186616EE0 ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer
    // 150 CertValidationCallback                   000186732C20 ModelClassType ServerCertValidationCallback ServerCertValidationCallback ServerCertValidationCallback Pointer
    // 158 HostHasPort                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 160 HostUri                                  0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 168 Auth_state                               000186567240 ModelEnumType AuthorizationState AuthorizationState AuthorizationState Int32
    // 178 Proxy_auth_state                         000186567240 ModelEnumType AuthorizationState AuthorizationState AuthorizationState Int32
    // 188 ResendContentFactory                     Func`2<Stream, Task> IL2CPP_TYPE_GENERICINST
    // 190 ThrowOnError                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 191 Unsafe_auth_blah                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class HttpWebRequest : DataModel
    {
        public Uri?                                     RequestUri                              { get; set; }
        public Uri?                                     ActualUri                               { get; set; }
        public bool                                     HostChanged                             { get; set; }
        public bool                                     AllowAutoRedirect                       { get; set; }
        public bool                                     AllowBuffering                          { get; set; }
        public X509CertificateCollection?               Certificates                            { get; set; }
        public string                                   ConnectionGroup                         { get; set; }
        public bool                                     HaveContentLength                       { get; set; }
        public long                                     ContentLength                           { get; set; }
        public HttpContinueDelegate?                    ContinueDelegate                        { get; set; }
        public CookieContainer?                         CookieContainer                         { get; set; }
        public ICredentials?                            Credentials                             { get; set; }
        public bool                                     HaveResponse                            { get; set; }
        public bool                                     RequestSent                             { get; set; }
        public WebHeaderCollection?                     WebHeaders                              { get; set; }
        public bool                                     KeepAlive                               { get; set; }
        public int                                      MaxAutoRedirect                         { get; set; }
        public string                                   MediaType                               { get; set; }
        public string                                   Method                                  { get; set; }
        public string                                   InitialMethod                           { get; set; }
        public bool                                     Pipelined                               { get; set; }
        public bool                                     PreAuthenticate                         { get; set; }
        public bool                                     UsedPreAuth                             { get; set; }
        public Version?                                 Version                                 { get; set; }
        public bool                                     Force_version                           { get; set; }
        public Version?                                 ActualVersion                           { get; set; }
        public IWebProxy?                               Proxy                                   { get; set; }
        public bool                                     SendChunked                             { get; set; }
        public ServicePoint?                            ServicePoint                            { get; set; }
        public int                                      Timeout                                 { get; set; }
        public int                                      ContinueTimeout                         { get; set; }
        public WebRequestStream?                        WriteStream                             { get; set; }
        public HttpWebResponse?                         WebResponse                             { get; set; }
        public WebCompletionSource?                     ResponseTask                            { get; set; }
        public WebOperation?                            CurrentOperation                        { get; set; }
        public int                                      Aborted                                 { get; set; }
        public bool                                     GotRequestStream                        { get; set; }
        public int                                      Redirects                               { get; set; }
        public bool                                     ExpectContinue                          { get; set; }
        public bool                                     GetResponseCalled                       { get; set; }
        public bool                                     Finished_reading                        { get; set; }
        public DecompressionMethods                     Auto_decomp                             { get; set; }
        public int                                      ReadWriteTimeout                        { get; set; }
        public MobileTlsProvider?                       TlsProvider                             { get; set; }
        public MonoTlsSettings?                         TlsSettings                             { get; set; }
        public ServerCertValidationCallback?            CertValidationCallback                  { get; set; }
        public bool                                     HostHasPort                             { get; set; }
        public Uri?                                     HostUri                                 { get; set; }
        public AuthorizationState                       Auth_state                              { get; set; }
        public AuthorizationState                       Proxy_auth_state                        { get; set; }
        public bool                                     ThrowOnError                            { get; set; }
        public bool                                     Unsafe_auth_blah                        { get; set; }

        public static HttpWebRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpWebRequest() { Pointer= p0 };

            value.RequestUri                                = GetObject<Uri>(new IntPtr(p + 0x038), ReversePrism.DataModels.Uri.FromPointer); // 02466797CE58 0x38 RequestUri                  ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.ActualUri                                 = GetObject<Uri>(new IntPtr(p + 0x040), ReversePrism.DataModels.Uri.FromPointer); // 02466797CE78 0x40 ActualUri                   ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.HostChanged                               = GetBool(new IntPtr(p + 0x048)); // 02466797CE98 0x48 HostChanged                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AllowAutoRedirect                         = GetBool(new IntPtr(p + 0x049)); // 02466797CEB8 0x49 AllowAutoRedirect           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AllowBuffering                            = GetBool(new IntPtr(p + 0x04A)); // 02466797CED8 0x4A AllowBuffering              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Certificates                              = GetObject<X509CertificateCollection>(new IntPtr(p + 0x050), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 02466797CEF8 0x50 Certificates                ( 0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.ConnectionGroup                           = GetString(new IntPtr(p + 0x058)); // 02466797CF18 0x58 ConnectionGroup             ( 000186671910 ModelPrimitiveType string string string String )
            value.HaveContentLength                         = GetBool(new IntPtr(p + 0x060)); // 02466797CF38 0x60 HaveContentLength           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x068)); // 02466797CF58 0x68 ContentLength               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ContinueDelegate                          = GetObject<HttpContinueDelegate>(new IntPtr(p + 0x070), ReversePrism.DataModels.HttpContinueDelegate.FromPointer); // 02466797CF78 0x70 ContinueDelegate            ( 0001866DE360 ModelClassType HttpContinueDelegate HttpContinueDelegate HttpContinueDelegate Pointer )
            value.CookieContainer                           = GetObject<CookieContainer>(new IntPtr(p + 0x078), ReversePrism.DataModels.CookieContainer.FromPointer); // 02466797CF98 0x78 CookieContainer             ( 00018661EC40 ModelClassType CookieContainer CookieContainer CookieContainer Pointer )
            value.Credentials                               = GetObject<ICredentials>(new IntPtr(p + 0x080), ReversePrism.DataModels.ICredentials.FromPointer); // 02466797CFB8 0x80 Credentials                 ( 000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer )
            value.HaveResponse                              = GetBool(new IntPtr(p + 0x088)); // 02466797CFD8 0x88 HaveResponse                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RequestSent                               = GetBool(new IntPtr(p + 0x089)); // 02466797CFF8 0x89 RequestSent                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WebHeaders                                = GetObject<WebHeaderCollection>(new IntPtr(p + 0x090), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 02466797D018 0x90 WebHeaders                  ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.KeepAlive                                 = GetBool(new IntPtr(p + 0x098)); // 02466797D038 0x98 KeepAlive                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MaxAutoRedirect                           = GetInt32(new IntPtr(p + 0x09C)); // 02466797D058 0x9C MaxAutoRedirect             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MediaType                                 = GetString(new IntPtr(p + 0x0A0)); // 02466797D078 0xA0 MediaType                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Method                                    = GetString(new IntPtr(p + 0x0A8)); // 02466797D098 0xA8 Method                      ( 000186671910 ModelPrimitiveType string string string String )
            value.InitialMethod                             = GetString(new IntPtr(p + 0x0B0)); // 02466797D0B8 0xB0 InitialMethod               ( 000186671910 ModelPrimitiveType string string string String )
            value.Pipelined                                 = GetBool(new IntPtr(p + 0x0B8)); // 02466797D0D8 0xB8 Pipelined                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PreAuthenticate                           = GetBool(new IntPtr(p + 0x0B9)); // 02466797D0F8 0xB9 PreAuthenticate             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UsedPreAuth                               = GetBool(new IntPtr(p + 0x0BA)); // 02466797D118 0xBA UsedPreAuth                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Version.FromPointer); // 02466797D138 0xC0 Version                     ( 0001866B0CC0 ModelClassType Version Version Version Pointer )
            value.Force_version                             = GetBool(new IntPtr(p + 0x0C8)); // 02466797D158 0xC8 Force_version               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ActualVersion                             = GetObject<Version>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Version.FromPointer); // 02466797D178 0xD0 ActualVersion               ( 0001866B0CC0 ModelClassType Version Version Version Pointer )
            value.Proxy                                     = GetObject<IWebProxy>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IWebProxy.FromPointer); // 02466797D198 0xD8 Proxy                       ( 00018669AB30 ModelClassType IWebProxy IWebProxy IWebProxy Pointer )
            value.SendChunked                               = GetBool(new IntPtr(p + 0x0E0)); // 02466797D1B8 0xE0 SendChunked                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ServicePoint                              = GetObject<ServicePoint>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ServicePoint.FromPointer); // 02466797D1D8 0xE8 ServicePoint                ( 000186738E90 ModelClassType ServicePoint ServicePoint ServicePoint Pointer )
            value.Timeout                                   = GetInt32(new IntPtr(p + 0x0F0)); // 02466797D1F8 0xF0 Timeout                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ContinueTimeout                           = GetInt32(new IntPtr(p + 0x0F4)); // 02466797D218 0xF4 ContinueTimeout             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WriteStream                               = GetObject<WebRequestStream>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.WebRequestStream.FromPointer); // 02466797D238 0xF8 WriteStream                 ( 00018654FDC0 ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer )
            value.WebResponse                               = GetObject<HttpWebResponse>(new IntPtr(p + 0x100), ReversePrism.DataModels.HttpWebResponse.FromPointer); // 02466797D258 0x100 WebResponse                 ( 0001866E6430 ModelClassType HttpWebResponse HttpWebResponse HttpWebResponse Pointer )
            value.ResponseTask                              = GetObject<WebCompletionSource>(new IntPtr(p + 0x108), ReversePrism.DataModels.WebCompletionSource.FromPointer); // 02466797D278 0x108 ResponseTask                ( 000186547C40 ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer )
            value.CurrentOperation                          = GetObject<WebOperation>(new IntPtr(p + 0x110), ReversePrism.DataModels.WebOperation.FromPointer); // 02466797D298 0x110 CurrentOperation            ( 00018654C440 ModelClassType WebOperation WebOperation WebOperation Pointer )
            value.Aborted                                   = GetInt32(new IntPtr(p + 0x118)); // 02466797D2B8 0x118 Aborted                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GotRequestStream                          = GetBool(new IntPtr(p + 0x11C)); // 02466797D2D8 0x11C GotRequestStream            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Redirects                                 = GetInt32(new IntPtr(p + 0x120)); // 02466797D2F8 0x120 Redirects                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ExpectContinue                            = GetBool(new IntPtr(p + 0x124)); // 02466797D318 0x124 ExpectContinue              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GetResponseCalled                         = GetBool(new IntPtr(p + 0x125)); // 02466797D338 0x125 GetResponseCalled           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Finished_reading                          = GetBool(new IntPtr(p + 0x130)); // 02466797D378 0x130 Finished_reading            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Auto_decomp                               = (DecompressionMethods)GetInt32(new IntPtr(p + 0x134)); // 02466797D398 0x134 Auto_decomp                 ( 0001866AE1C0 ModelEnumType DecompressionMethods DecompressionMethods DecompressionMethods Int32 )
            value.ReadWriteTimeout                          = GetInt32(new IntPtr(p + 0x138)); // 02466797D418 0x138 ReadWriteTimeout            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TlsProvider                               = GetObject<MobileTlsProvider>(new IntPtr(p + 0x140), ReversePrism.DataModels.MobileTlsProvider.FromPointer); // 02466797D438 0x140 TlsProvider                 ( 000186637CF0 ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer )
            value.TlsSettings                               = GetObject<MonoTlsSettings>(new IntPtr(p + 0x148), ReversePrism.DataModels.MonoTlsSettings.FromPointer); // 02466797D458 0x148 TlsSettings                 ( 000186616EE0 ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer )
            value.CertValidationCallback                    = GetObject<ServerCertValidationCallback>(new IntPtr(p + 0x150), ReversePrism.DataModels.ServerCertValidationCallback.FromPointer); // 02466797D478 0x150 CertValidationCallback      ( 000186732C20 ModelClassType ServerCertValidationCallback ServerCertValidationCallback ServerCertValidationCallback Pointer )
            value.HostHasPort                               = GetBool(new IntPtr(p + 0x158)); // 02466797D498 0x158 HostHasPort                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HostUri                                   = GetObject<Uri>(new IntPtr(p + 0x160), ReversePrism.DataModels.Uri.FromPointer); // 02466797D4B8 0x160 HostUri                     ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.Auth_state                                = (AuthorizationState)GetInt32(new IntPtr(p + 0x168)); // 02466797D4D8 0x168 Auth_state                  ( 000186567240 ModelEnumType AuthorizationState AuthorizationState AuthorizationState Int32 )
            value.Proxy_auth_state                          = (AuthorizationState)GetInt32(new IntPtr(p + 0x178)); // 02466797D4F8 0x178 Proxy_auth_state            ( 000186567240 ModelEnumType AuthorizationState AuthorizationState AuthorizationState Int32 )
            value.ThrowOnError                              = GetBool(new IntPtr(p + 0x190)); // 02466797D538 0x190 ThrowOnError                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Unsafe_auth_blah                          = GetBool(new IntPtr(p + 0x191)); // 02466797D558 0x191 Unsafe_auth_blah            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
