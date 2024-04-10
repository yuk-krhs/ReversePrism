using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 groupCounter                             long IL2CPP_TYPE_I8
    // 010 AllowAutoRedirect                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 AutomaticDecompression                   0001866AE1C0 ModelEnumType DecompressionMethods DecompressionMethods DecompressionMethods Int32
    // 018 CookieContainer                          00018661EC40 ModelClassType CookieContainer CookieContainer CookieContainer Pointer
    // 020 Credentials                              000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer
    // 028 MaxAutomaticRedirections                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 MaxRequestContentBufferSize              0001865F7700 ModelPrimitiveType long long long Int64
    // 038 PreAuthenticate                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 Proxy                                    00018669AB30 ModelClassType IWebProxy IWebProxy IWebProxy Pointer
    // 048 UseCookies                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 UseProxy                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 SslOptions                               00018655C0F0 ModelClassType SslClientAuthenticationOptions SslClientAuthenticationOptions SslClientAuthenticationOptions Pointer
    // 058 AllowPipelining                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 CachePolicy                              0001866657A0 ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer
    // 068 AuthenticationLevel                      000186722BD0 ModelEnumType AuthenticationLevel AuthenticationLevel AuthenticationLevel Int32
    // 070 ContinueTimeout                          00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 078 ImpersonationLevel                       000186688250 ModelEnumType TokenImpersonationLevel TokenImpersonationLevel TokenImpersonationLevel Int32
    // 07C MaxResponseHeadersLength                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 ReadWriteTimeout                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 ServerCertificateValidationCallback      000186649490 ModelClassType RemoteCertificateValidationCallback RemoteCertificateValidationCallback RemoteCertificateValidationCallback Pointer
    // 090 UnsafeAuthenticatedConnectionSharing     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 091 SentRequest                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 ConnectionGroupName                      000186671910 ModelPrimitiveType string string string String
    // 0A0 timeout                                  Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    // 0B0 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.AllowAutoRedirect                         = GetBool(new IntPtr(p + 0x010)); // 02466B8A9F18 0x10 AllowAutoRedirect           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AutomaticDecompression                    = (DecompressionMethods)GetInt32(new IntPtr(p + 0x014)); // 02466B8A9F38 0x14 AutomaticDecompression      ( 0001866AE1C0 ModelEnumType DecompressionMethods DecompressionMethods DecompressionMethods Int32 )
            value.CookieContainer                           = GetObject<CookieContainer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CookieContainer.FromPointer); // 02466B8A9F58 0x18 CookieContainer             ( 00018661EC40 ModelClassType CookieContainer CookieContainer CookieContainer Pointer )
            value.Credentials                               = GetObject<ICredentials>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICredentials.FromPointer); // 02466B8A9F78 0x20 Credentials                 ( 000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer )
            value.MaxAutomaticRedirections                  = GetInt32(new IntPtr(p + 0x028)); // 02466B8A9F98 0x28 MaxAutomaticRedirections    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxRequestContentBufferSize               = GetInt64(new IntPtr(p + 0x030)); // 02466B8A9FB8 0x30 MaxRequestContentBufferSize ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.PreAuthenticate                           = GetBool(new IntPtr(p + 0x038)); // 02466B8A9FD8 0x38 PreAuthenticate             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Proxy                                     = GetObject<IWebProxy>(new IntPtr(p + 0x040), ReversePrism.DataModels.IWebProxy.FromPointer); // 02466B8A9FF8 0x40 Proxy                       ( 00018669AB30 ModelClassType IWebProxy IWebProxy IWebProxy Pointer )
            value.UseCookies                                = GetBool(new IntPtr(p + 0x048)); // 02466B8AA018 0x48 UseCookies                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseProxy                                  = GetBool(new IntPtr(p + 0x049)); // 02466B8AA038 0x49 UseProxy                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SslOptions                                = GetObject<SslClientAuthenticationOptions>(new IntPtr(p + 0x050), ReversePrism.DataModels.SslClientAuthenticationOptions.FromPointer); // 02466B8AA058 0x50 SslOptions                  ( 00018655C0F0 ModelClassType SslClientAuthenticationOptions SslClientAuthenticationOptions SslClientAuthenticationOptions Pointer )
            value.AllowPipelining                           = GetBool(new IntPtr(p + 0x058)); // 02466B8AA078 0x58 AllowPipelining             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CachePolicy                               = GetObject<RequestCachePolicy>(new IntPtr(p + 0x060), ReversePrism.DataModels.RequestCachePolicy.FromPointer); // 02466B8AA098 0x60 CachePolicy                 ( 0001866657A0 ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer )
            value.AuthenticationLevel                       = (AuthenticationLevel)GetInt32(new IntPtr(p + 0x068)); // 02466B8AA0B8 0x68 AuthenticationLevel         ( 000186722BD0 ModelEnumType AuthenticationLevel AuthenticationLevel AuthenticationLevel Int32 )
            value.ContinueTimeout                           = (TimeSpan)GetInt32(new IntPtr(p + 0x070)); // 02466B8AA0D8 0x70 ContinueTimeout             ( 00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.ImpersonationLevel                        = (TokenImpersonationLevel)GetInt32(new IntPtr(p + 0x078)); // 02466B8AA0F8 0x78 ImpersonationLevel          ( 000186688250 ModelEnumType TokenImpersonationLevel TokenImpersonationLevel TokenImpersonationLevel Int32 )
            value.MaxResponseHeadersLength                  = GetInt32(new IntPtr(p + 0x07C)); // 02466B8AA118 0x7C MaxResponseHeadersLength    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReadWriteTimeout                          = GetInt32(new IntPtr(p + 0x080)); // 02466B8AA138 0x80 ReadWriteTimeout            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ServerCertificateValidationCallback       = GetObject<RemoteCertificateValidationCallback>(new IntPtr(p + 0x088), ReversePrism.DataModels.RemoteCertificateValidationCallback.FromPointer); // 02466B8AA158 0x88 ServerCertificateValidationCallback ( 000186649490 ModelClassType RemoteCertificateValidationCallback RemoteCertificateValidationCallback RemoteCertificateValidationCallback Pointer )
            value.UnsafeAuthenticatedConnectionSharing      = GetBool(new IntPtr(p + 0x090)); // 02466B8AA178 0x90 UnsafeAuthenticatedConnectionSharing ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SentRequest                               = GetBool(new IntPtr(p + 0x091)); // 02466B8AA198 0x91 SentRequest                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ConnectionGroupName                       = GetString(new IntPtr(p + 0x098)); // 02466B8AA1B8 0x98 ConnectionGroupName         ( 000186671910 ModelPrimitiveType string string string String )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x0B0)); // 02466B8AA1F8 0xB0 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
