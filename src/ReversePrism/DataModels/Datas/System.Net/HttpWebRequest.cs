using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 RequestUri                               ModelClassType Uri Uri Uri Pointer
    // 040 ActualUri                                ModelClassType Uri Uri Uri Pointer
    // 048 HostChanged                              ModelPrimitiveType bool bool bool Bool
    // 049 AllowAutoRedirect                        ModelPrimitiveType bool bool bool Bool
    // 04A AllowBuffering                           ModelPrimitiveType bool bool bool Bool
    // 050 Certificates                             ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 058 ConnectionGroup                          ModelPrimitiveType string string string String
    // 060 HaveContentLength                        ModelPrimitiveType bool bool bool Bool
    // 068 ContentLength                            ModelPrimitiveType long long long Int64
    // 070 ContinueDelegate                         ModelClassType HttpContinueDelegate HttpContinueDelegate HttpContinueDelegate Pointer
    // 078 CookieContainer                          ModelClassType CookieContainer CookieContainer CookieContainer Pointer
    // 080 Credentials                              ModelClassType ICredentials ICredentials ICredentials Pointer
    // 088 HaveResponse                             ModelPrimitiveType bool bool bool Bool
    // 089 RequestSent                              ModelPrimitiveType bool bool bool Bool
    // 090 WebHeaders                               ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 098 KeepAlive                                ModelPrimitiveType bool bool bool Bool
    // 09C MaxAutoRedirect                          ModelPrimitiveType int int int Int32
    // 0A0 MediaType                                ModelPrimitiveType string string string String
    // 0A8 Method                                   ModelPrimitiveType string string string String
    // 0B0 InitialMethod                            ModelPrimitiveType string string string String
    // 0B8 Pipelined                                ModelPrimitiveType bool bool bool Bool
    // 0B9 PreAuthenticate                          ModelPrimitiveType bool bool bool Bool
    // 0BA UsedPreAuth                              ModelPrimitiveType bool bool bool Bool
    // 0C0 Version                                  ModelClassType Version Version Version Pointer
    // 0C8 Force_version                            ModelPrimitiveType bool bool bool Bool
    // 0D0 ActualVersion                            ModelClassType Version Version Version Pointer
    // 0D8 Proxy                                    ModelClassType IWebProxy IWebProxy IWebProxy Pointer
    // 0E0 SendChunked                              ModelPrimitiveType bool bool bool Bool
    // 0E8 ServicePoint                             ModelClassType ServicePoint ServicePoint ServicePoint Pointer
    // 0F0 Timeout                                  ModelPrimitiveType int int int Int32
    // 0F4 ContinueTimeout                          ModelPrimitiveType int int int Int32
    // 0F8 WriteStream                              ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer
    // 100 WebResponse                              ModelClassType HttpWebResponse HttpWebResponse HttpWebResponse Pointer
    // 108 ResponseTask                             ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer
    // 110 CurrentOperation                         ModelClassType WebOperation WebOperation WebOperation Pointer
    // 118 Aborted                                  ModelPrimitiveType int int int Int32
    // 11C GotRequestStream                         ModelPrimitiveType bool bool bool Bool
    // 120 Redirects                                ModelPrimitiveType int int int Int32
    // 124 ExpectContinue                           ModelPrimitiveType bool bool bool Bool
    // 125 GetResponseCalled                        ModelPrimitiveType bool bool bool Bool
    // 128 locker                                   <object> IL2CPP_TYPE_OBJECT
    // 130 Finished_reading                         ModelPrimitiveType bool bool bool Bool
    // 134 Auto_decomp                              ModelEnumType DecompressionMethods DecompressionMethods DecompressionMethods Int32
    // 000 defaultMaxResponseHeadersLength          int IL2CPP_TYPE_I4
    // 004 defaultMaximumErrorResponseLength        int IL2CPP_TYPE_I4
    // 008 defaultCachePolicy                       RequestCachePolicy IL2CPP_TYPE_CLASS
    // 138 ReadWriteTimeout                         ModelPrimitiveType int int int Int32
    // 140 TlsProvider                              ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer
    // 148 TlsSettings                              ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer
    // 150 CertValidationCallback                   ModelClassType ServerCertValidationCallback ServerCertValidationCallback ServerCertValidationCallback Pointer
    // 158 HostHasPort                              ModelPrimitiveType bool bool bool Bool
    // 160 HostUri                                  ModelClassType Uri Uri Uri Pointer
    // 168 Auth_state                               ModelEnumType AuthorizationState AuthorizationState AuthorizationState Int32
    // 178 Proxy_auth_state                         ModelEnumType AuthorizationState AuthorizationState AuthorizationState Int32
    // 188 ResendContentFactory                     Func`2<Stream, Task> IL2CPP_TYPE_GENERICINST
    // 190 ThrowOnError                             ModelPrimitiveType bool bool bool Bool
    // 191 Unsafe_auth_blah                         ModelPrimitiveType bool bool bool Bool
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

            value.RequestUri                                = GetObject<Uri>(new IntPtr(p + 0x038), ReversePrism.DataModels.Uri.FromPointer); // 0x38 RequestUri                  ( ModelClassType Uri Uri Uri Pointer )
            value.ActualUri                                 = GetObject<Uri>(new IntPtr(p + 0x040), ReversePrism.DataModels.Uri.FromPointer); // 0x40 ActualUri                   ( ModelClassType Uri Uri Uri Pointer )
            value.HostChanged                               = GetBool(new IntPtr(p + 0x048)); // 0x48 HostChanged                 ( ModelPrimitiveType bool bool bool Bool )
            value.AllowAutoRedirect                         = GetBool(new IntPtr(p + 0x049)); // 0x49 AllowAutoRedirect           ( ModelPrimitiveType bool bool bool Bool )
            value.AllowBuffering                            = GetBool(new IntPtr(p + 0x04A)); // 0x4A AllowBuffering              ( ModelPrimitiveType bool bool bool Bool )
            value.Certificates                              = GetObject<X509CertificateCollection>(new IntPtr(p + 0x050), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0x50 Certificates                ( ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.ConnectionGroup                           = GetString(new IntPtr(p + 0x058)); // 0x58 ConnectionGroup             ( ModelPrimitiveType string string string String )
            value.HaveContentLength                         = GetBool(new IntPtr(p + 0x060)); // 0x60 HaveContentLength           ( ModelPrimitiveType bool bool bool Bool )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x068)); // 0x68 ContentLength               ( ModelPrimitiveType long long long Int64 )
            value.ContinueDelegate                          = GetObject<HttpContinueDelegate>(new IntPtr(p + 0x070), ReversePrism.DataModels.HttpContinueDelegate.FromPointer); // 0x70 ContinueDelegate            ( ModelClassType HttpContinueDelegate HttpContinueDelegate HttpContinueDelegate Pointer )
            value.CookieContainer                           = GetObject<CookieContainer>(new IntPtr(p + 0x078), ReversePrism.DataModels.CookieContainer.FromPointer); // 0x78 CookieContainer             ( ModelClassType CookieContainer CookieContainer CookieContainer Pointer )
            value.Credentials                               = GetObject<ICredentials>(new IntPtr(p + 0x080), ReversePrism.DataModels.ICredentials.FromPointer); // 0x80 Credentials                 ( ModelClassType ICredentials ICredentials ICredentials Pointer )
            value.HaveResponse                              = GetBool(new IntPtr(p + 0x088)); // 0x88 HaveResponse                ( ModelPrimitiveType bool bool bool Bool )
            value.RequestSent                               = GetBool(new IntPtr(p + 0x089)); // 0x89 RequestSent                 ( ModelPrimitiveType bool bool bool Bool )
            value.WebHeaders                                = GetObject<WebHeaderCollection>(new IntPtr(p + 0x090), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0x90 WebHeaders                  ( ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.KeepAlive                                 = GetBool(new IntPtr(p + 0x098)); // 0x98 KeepAlive                   ( ModelPrimitiveType bool bool bool Bool )
            value.MaxAutoRedirect                           = GetInt32(new IntPtr(p + 0x09C)); // 0x9C MaxAutoRedirect             ( ModelPrimitiveType int int int Int32 )
            value.MediaType                                 = GetString(new IntPtr(p + 0x0A0)); // 0xA0 MediaType                   ( ModelPrimitiveType string string string String )
            value.Method                                    = GetString(new IntPtr(p + 0x0A8)); // 0xA8 Method                      ( ModelPrimitiveType string string string String )
            value.InitialMethod                             = GetString(new IntPtr(p + 0x0B0)); // 0xB0 InitialMethod               ( ModelPrimitiveType string string string String )
            value.Pipelined                                 = GetBool(new IntPtr(p + 0x0B8)); // 0xB8 Pipelined                   ( ModelPrimitiveType bool bool bool Bool )
            value.PreAuthenticate                           = GetBool(new IntPtr(p + 0x0B9)); // 0xB9 PreAuthenticate             ( ModelPrimitiveType bool bool bool Bool )
            value.UsedPreAuth                               = GetBool(new IntPtr(p + 0x0BA)); // 0xBA UsedPreAuth                 ( ModelPrimitiveType bool bool bool Bool )
            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Version.FromPointer); // 0xC0 Version                     ( ModelClassType Version Version Version Pointer )
            value.Force_version                             = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 Force_version               ( ModelPrimitiveType bool bool bool Bool )
            value.ActualVersion                             = GetObject<Version>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Version.FromPointer); // 0xD0 ActualVersion               ( ModelClassType Version Version Version Pointer )
            value.Proxy                                     = GetObject<IWebProxy>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IWebProxy.FromPointer); // 0xD8 Proxy                       ( ModelClassType IWebProxy IWebProxy IWebProxy Pointer )
            value.SendChunked                               = GetBool(new IntPtr(p + 0x0E0)); // 0xE0 SendChunked                 ( ModelPrimitiveType bool bool bool Bool )
            value.ServicePoint                              = GetObject<ServicePoint>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ServicePoint.FromPointer); // 0xE8 ServicePoint                ( ModelClassType ServicePoint ServicePoint ServicePoint Pointer )
            value.Timeout                                   = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 Timeout                     ( ModelPrimitiveType int int int Int32 )
            value.ContinueTimeout                           = GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 ContinueTimeout             ( ModelPrimitiveType int int int Int32 )
            value.WriteStream                               = GetObject<WebRequestStream>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.WebRequestStream.FromPointer); // 0xF8 WriteStream                 ( ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer )
            value.WebResponse                               = GetObject<HttpWebResponse>(new IntPtr(p + 0x100), ReversePrism.DataModels.HttpWebResponse.FromPointer); // 0x100 WebResponse                 ( ModelClassType HttpWebResponse HttpWebResponse HttpWebResponse Pointer )
            value.ResponseTask                              = GetObject<WebCompletionSource>(new IntPtr(p + 0x108), ReversePrism.DataModels.WebCompletionSource.FromPointer); // 0x108 ResponseTask                ( ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer )
            value.CurrentOperation                          = GetObject<WebOperation>(new IntPtr(p + 0x110), ReversePrism.DataModels.WebOperation.FromPointer); // 0x110 CurrentOperation            ( ModelClassType WebOperation WebOperation WebOperation Pointer )
            value.Aborted                                   = GetInt32(new IntPtr(p + 0x118)); // 0x118 Aborted                     ( ModelPrimitiveType int int int Int32 )
            value.GotRequestStream                          = GetBool(new IntPtr(p + 0x11C)); // 0x11C GotRequestStream            ( ModelPrimitiveType bool bool bool Bool )
            value.Redirects                                 = GetInt32(new IntPtr(p + 0x120)); // 0x120 Redirects                   ( ModelPrimitiveType int int int Int32 )
            value.ExpectContinue                            = GetBool(new IntPtr(p + 0x124)); // 0x124 ExpectContinue              ( ModelPrimitiveType bool bool bool Bool )
            value.GetResponseCalled                         = GetBool(new IntPtr(p + 0x125)); // 0x125 GetResponseCalled           ( ModelPrimitiveType bool bool bool Bool )
            value.Finished_reading                          = GetBool(new IntPtr(p + 0x130)); // 0x130 Finished_reading            ( ModelPrimitiveType bool bool bool Bool )
            value.Auto_decomp                               = (DecompressionMethods)GetInt32(new IntPtr(p + 0x134)); // 0x134 Auto_decomp                 ( ModelEnumType DecompressionMethods DecompressionMethods DecompressionMethods Int32 )
            value.ReadWriteTimeout                          = GetInt32(new IntPtr(p + 0x138)); // 0x138 ReadWriteTimeout            ( ModelPrimitiveType int int int Int32 )
            value.TlsProvider                               = GetObject<MobileTlsProvider>(new IntPtr(p + 0x140), ReversePrism.DataModels.MobileTlsProvider.FromPointer); // 0x140 TlsProvider                 ( ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer )
            value.TlsSettings                               = GetObject<MonoTlsSettings>(new IntPtr(p + 0x148), ReversePrism.DataModels.MonoTlsSettings.FromPointer); // 0x148 TlsSettings                 ( ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer )
            value.CertValidationCallback                    = GetObject<ServerCertValidationCallback>(new IntPtr(p + 0x150), ReversePrism.DataModels.ServerCertValidationCallback.FromPointer); // 0x150 CertValidationCallback      ( ModelClassType ServerCertValidationCallback ServerCertValidationCallback ServerCertValidationCallback Pointer )
            value.HostHasPort                               = GetBool(new IntPtr(p + 0x158)); // 0x158 HostHasPort                 ( ModelPrimitiveType bool bool bool Bool )
            value.HostUri                                   = GetObject<Uri>(new IntPtr(p + 0x160), ReversePrism.DataModels.Uri.FromPointer); // 0x160 HostUri                     ( ModelClassType Uri Uri Uri Pointer )
            value.Auth_state                                = (AuthorizationState)GetInt32(new IntPtr(p + 0x168)); // 0x168 Auth_state                  ( ModelEnumType AuthorizationState AuthorizationState AuthorizationState Int32 )
            value.Proxy_auth_state                          = (AuthorizationState)GetInt32(new IntPtr(p + 0x178)); // 0x178 Proxy_auth_state            ( ModelEnumType AuthorizationState AuthorizationState AuthorizationState Int32 )
            value.ThrowOnError                              = GetBool(new IntPtr(p + 0x190)); // 0x190 ThrowOnError                ( ModelPrimitiveType bool bool bool Bool )
            value.Unsafe_auth_blah                          = GetBool(new IntPtr(p + 0x191)); // 0x191 Unsafe_auth_blah            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
