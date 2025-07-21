using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 groupCounter                             long IL2CPP_TYPE_I8
    // 010 AllowAutoRedirect                        ModelPrimitiveType bool bool bool Bool
    // 014 AutomaticDecompression                   ModelEnumType DecompressionMethods DecompressionMethods DecompressionMethods Int32
    // 018 CookieContainer                          ModelClassType CookieContainer CookieContainer CookieContainer Pointer
    // 020 Credentials                              ModelClassType ICredentials ICredentials ICredentials Pointer
    // 028 MaxAutomaticRedirections                 ModelPrimitiveType int int int Int32
    // 030 MaxRequestContentBufferSize              ModelPrimitiveType long long long Int64
    // 038 PreAuthenticate                          ModelPrimitiveType bool bool bool Bool
    // 040 Proxy                                    ModelClassType IWebProxy IWebProxy IWebProxy Pointer
    // 048 UseCookies                               ModelPrimitiveType bool bool bool Bool
    // 049 UseProxy                                 ModelPrimitiveType bool bool bool Bool
    // 050 SslOptions                               ModelClassType SslClientAuthenticationOptions SslClientAuthenticationOptions SslClientAuthenticationOptions Pointer
    // 058 AllowPipelining                          ModelPrimitiveType bool bool bool Bool
    // 060 CachePolicy                              ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer
    // 068 AuthenticationLevel                      ModelEnumType AuthenticationLevel AuthenticationLevel AuthenticationLevel Int32
    // 070 ContinueTimeout                          ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 078 ImpersonationLevel                       ModelEnumType TokenImpersonationLevel TokenImpersonationLevel TokenImpersonationLevel Int32
    // 07C MaxResponseHeadersLength                 ModelPrimitiveType int int int Int32
    // 080 ReadWriteTimeout                         ModelPrimitiveType int int int Int32
    // 088 ServerCertificateValidationCallback      ModelClassType RemoteCertificateValidationCallback RemoteCertificateValidationCallback RemoteCertificateValidationCallback Pointer
    // 090 UnsafeAuthenticatedConnectionSharing     ModelPrimitiveType bool bool bool Bool
    // 091 SentRequest                              ModelPrimitiveType bool bool bool Bool
    // 098 ConnectionGroupName                      ModelPrimitiveType string string string String
    // 0A0 timeout                                  Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    // 0B0 Disposed                                 ModelPrimitiveType bool bool bool Bool
    public partial class MonoWebRequestHandler : DataModel
    {
        public bool                                     AllowAutoRedirect                       { get; set; }
        public DecompressionMethods                     AutomaticDecompression                  { get; set; }
        public CookieContainer?                         CookieContainer                         { get; set; }
        public ICredentials?                            Credentials                             { get; set; }
        public int                                      MaxAutomaticRedirections                { get; set; }
        public long                                     MaxRequestContentBufferSize             { get; set; }
        public bool                                     PreAuthenticate                         { get; set; }
        public IWebProxy?                               Proxy                                   { get; set; }
        public bool                                     UseCookies                              { get; set; }
        public bool                                     UseProxy                                { get; set; }
        public SslClientAuthenticationOptions?          SslOptions                              { get; set; }
        public bool                                     AllowPipelining                         { get; set; }
        public RequestCachePolicy?                      CachePolicy                             { get; set; }
        public AuthenticationLevel                      AuthenticationLevel                     { get; set; }
        public TimeSpan                                 ContinueTimeout                         { get; set; }
        public TokenImpersonationLevel                  ImpersonationLevel                      { get; set; }
        public int                                      MaxResponseHeadersLength                { get; set; }
        public int                                      ReadWriteTimeout                        { get; set; }
        public RemoteCertificateValidationCallback?     ServerCertificateValidationCallback     { get; set; }
        public bool                                     UnsafeAuthenticatedConnectionSharing    { get; set; }
        public bool                                     SentRequest                             { get; set; }
        public string                                   ConnectionGroupName                     { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static MonoWebRequestHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoWebRequestHandler() { Pointer= p0 };

            value.AllowAutoRedirect                         = GetBool(new IntPtr(p + 0x010)); // 0x10 AllowAutoRedirect           ( ModelPrimitiveType bool bool bool Bool )
            value.AutomaticDecompression                    = (DecompressionMethods)GetInt32(new IntPtr(p + 0x014)); // 0x14 AutomaticDecompression      ( ModelEnumType DecompressionMethods DecompressionMethods DecompressionMethods Int32 )
            value.CookieContainer                           = GetObject<CookieContainer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CookieContainer.FromPointer); // 0x18 CookieContainer             ( ModelClassType CookieContainer CookieContainer CookieContainer Pointer )
            value.Credentials                               = GetObject<ICredentials>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICredentials.FromPointer); // 0x20 Credentials                 ( ModelClassType ICredentials ICredentials ICredentials Pointer )
            value.MaxAutomaticRedirections                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 MaxAutomaticRedirections    ( ModelPrimitiveType int int int Int32 )
            value.MaxRequestContentBufferSize               = GetInt64(new IntPtr(p + 0x030)); // 0x30 MaxRequestContentBufferSize ( ModelPrimitiveType long long long Int64 )
            value.PreAuthenticate                           = GetBool(new IntPtr(p + 0x038)); // 0x38 PreAuthenticate             ( ModelPrimitiveType bool bool bool Bool )
            value.Proxy                                     = GetObject<IWebProxy>(new IntPtr(p + 0x040), ReversePrism.DataModels.IWebProxy.FromPointer); // 0x40 Proxy                       ( ModelClassType IWebProxy IWebProxy IWebProxy Pointer )
            value.UseCookies                                = GetBool(new IntPtr(p + 0x048)); // 0x48 UseCookies                  ( ModelPrimitiveType bool bool bool Bool )
            value.UseProxy                                  = GetBool(new IntPtr(p + 0x049)); // 0x49 UseProxy                    ( ModelPrimitiveType bool bool bool Bool )
            value.SslOptions                                = GetObject<SslClientAuthenticationOptions>(new IntPtr(p + 0x050), ReversePrism.DataModels.SslClientAuthenticationOptions.FromPointer); // 0x50 SslOptions                  ( ModelClassType SslClientAuthenticationOptions SslClientAuthenticationOptions SslClientAuthenticationOptions Pointer )
            value.AllowPipelining                           = GetBool(new IntPtr(p + 0x058)); // 0x58 AllowPipelining             ( ModelPrimitiveType bool bool bool Bool )
            value.CachePolicy                               = GetObject<RequestCachePolicy>(new IntPtr(p + 0x060), ReversePrism.DataModels.RequestCachePolicy.FromPointer); // 0x60 CachePolicy                 ( ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer )
            value.AuthenticationLevel                       = (AuthenticationLevel)GetInt32(new IntPtr(p + 0x068)); // 0x68 AuthenticationLevel         ( ModelEnumType AuthenticationLevel AuthenticationLevel AuthenticationLevel Int32 )
            value.ContinueTimeout                           = (TimeSpan)GetInt32(new IntPtr(p + 0x070)); // 0x70 ContinueTimeout             ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.ImpersonationLevel                        = (TokenImpersonationLevel)GetInt32(new IntPtr(p + 0x078)); // 0x78 ImpersonationLevel          ( ModelEnumType TokenImpersonationLevel TokenImpersonationLevel TokenImpersonationLevel Int32 )
            value.MaxResponseHeadersLength                  = GetInt32(new IntPtr(p + 0x07C)); // 0x7C MaxResponseHeadersLength    ( ModelPrimitiveType int int int Int32 )
            value.ReadWriteTimeout                          = GetInt32(new IntPtr(p + 0x080)); // 0x80 ReadWriteTimeout            ( ModelPrimitiveType int int int Int32 )
            value.ServerCertificateValidationCallback       = GetObject<RemoteCertificateValidationCallback>(new IntPtr(p + 0x088), ReversePrism.DataModels.RemoteCertificateValidationCallback.FromPointer); // 0x88 ServerCertificateValidationCallback ( ModelClassType RemoteCertificateValidationCallback RemoteCertificateValidationCallback RemoteCertificateValidationCallback Pointer )
            value.UnsafeAuthenticatedConnectionSharing      = GetBool(new IntPtr(p + 0x090)); // 0x90 UnsafeAuthenticatedConnectionSharing ( ModelPrimitiveType bool bool bool Bool )
            value.SentRequest                               = GetBool(new IntPtr(p + 0x091)); // 0x91 SentRequest                 ( ModelPrimitiveType bool bool bool Bool )
            value.ConnectionGroupName                       = GetString(new IntPtr(p + 0x098)); // 0x98 ConnectionGroupName         ( ModelPrimitiveType string string string String )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
