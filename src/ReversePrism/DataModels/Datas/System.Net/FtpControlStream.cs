using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 DataSocket                               ModelClassType Socket Socket Socket Pointer
    // 090 PassiveEndPoint                          ModelClassType IPEndPoint IPEndPoint IPEndPoint Pointer
    // 098 TlsStream                                ModelClassType TlsStream TlsStream TlsStream Pointer
    // 0A0 BannerMessage                            ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 0A8 WelcomeMessage                           ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 0B0 ExitMessage                              ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 0B8 Credentials                              ModelClassType WeakReference WeakReference WeakReference Pointer
    // 0C0 CurrentTypeSetting                       ModelPrimitiveType string string string String
    // 0C8 ContentLength                            ModelPrimitiveType long long long Int64
    // 0D0 LastModified                             ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 0D8 DataHandshakeStarted                     ModelPrimitiveType bool bool bool Bool
    // 0E0 LoginDirectory                           ModelPrimitiveType string string string String
    // 0E8 EstablishedServerDirectory               ModelPrimitiveType string string string String
    // 0F0 RequestedServerDirectory                 ModelPrimitiveType string string string String
    // 0F8 ResponseUri                              ModelClassType Uri Uri Uri Pointer
    // 100 LoginState                               ModelEnumType FtpLoginState FtpLoginState FtpLoginState Int32
    // 104 StatusCode                               ModelEnumType FtpStatusCode FtpStatusCode FtpStatusCode Int32
    // 108 StatusLine                               ModelPrimitiveType string string string String
    // 000 s_acceptCallbackDelegate                 AsyncCallback IL2CPP_TYPE_CLASS
    // 008 s_connectCallbackDelegate                AsyncCallback IL2CPP_TYPE_CLASS
    // 010 S_SSLHandshakeCallback                   ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    public partial class FtpControlStream : DataModel
    {
        public Socket?                                  DataSocket                              { get; set; }
        public IPEndPoint?                              PassiveEndPoint                         { get; set; }
        public TlsStream?                               TlsStream                               { get; set; }
        public StringBuilder?                           BannerMessage                           { get; set; }
        public StringBuilder?                           WelcomeMessage                          { get; set; }
        public StringBuilder?                           ExitMessage                             { get; set; }
        public WeakReference?                           Credentials                             { get; set; }
        public string                                   CurrentTypeSetting                      { get; set; }
        public long                                     ContentLength                           { get; set; }
        public DateTime                                 LastModified                            { get; set; }
        public bool                                     DataHandshakeStarted                    { get; set; }
        public string                                   LoginDirectory                          { get; set; }
        public string                                   EstablishedServerDirectory              { get; set; }
        public string                                   RequestedServerDirectory                { get; set; }
        public Uri?                                     ResponseUri                             { get; set; }
        public FtpLoginState                            LoginState                              { get; set; }
        public FtpStatusCode                            StatusCode                              { get; set; }
        public string                                   StatusLine                              { get; set; }
        public AsyncCallback?                           S_SSLHandshakeCallback                  { get; set; }

        public static FtpControlStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FtpControlStream() { Pointer= p0 };

            value.DataSocket                                = GetObject<Socket>(new IntPtr(p + 0x088), ReversePrism.DataModels.Socket.FromPointer); // 0x88 DataSocket                  ( ModelClassType Socket Socket Socket Pointer )
            value.PassiveEndPoint                           = GetObject<IPEndPoint>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPEndPoint.FromPointer); // 0x90 PassiveEndPoint             ( ModelClassType IPEndPoint IPEndPoint IPEndPoint Pointer )
            value.TlsStream                                 = GetObject<TlsStream>(new IntPtr(p + 0x098), ReversePrism.DataModels.TlsStream.FromPointer); // 0x98 TlsStream                   ( ModelClassType TlsStream TlsStream TlsStream Pointer )
            value.BannerMessage                             = GetObject<StringBuilder>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.StringBuilder.FromPointer); // 0xA0 BannerMessage               ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.WelcomeMessage                            = GetObject<StringBuilder>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.StringBuilder.FromPointer); // 0xA8 WelcomeMessage              ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.ExitMessage                               = GetObject<StringBuilder>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.StringBuilder.FromPointer); // 0xB0 ExitMessage                 ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.Credentials                               = GetObject<WeakReference>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.WeakReference.FromPointer); // 0xB8 Credentials                 ( ModelClassType WeakReference WeakReference WeakReference Pointer )
            value.CurrentTypeSetting                        = GetString(new IntPtr(p + 0x0C0)); // 0xC0 CurrentTypeSetting          ( ModelPrimitiveType string string string String )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x0C8)); // 0xC8 ContentLength               ( ModelPrimitiveType long long long Int64 )
            value.LastModified                              = GetDateTime(new IntPtr(p + 0x0D0)); // 0xD0 LastModified                ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.DataHandshakeStarted                      = GetBool(new IntPtr(p + 0x0D8)); // 0xD8 DataHandshakeStarted        ( ModelPrimitiveType bool bool bool Bool )
            value.LoginDirectory                            = GetString(new IntPtr(p + 0x0E0)); // 0xE0 LoginDirectory              ( ModelPrimitiveType string string string String )
            value.EstablishedServerDirectory                = GetString(new IntPtr(p + 0x0E8)); // 0xE8 EstablishedServerDirectory  ( ModelPrimitiveType string string string String )
            value.RequestedServerDirectory                  = GetString(new IntPtr(p + 0x0F0)); // 0xF0 RequestedServerDirectory    ( ModelPrimitiveType string string string String )
            value.ResponseUri                               = GetObject<Uri>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Uri.FromPointer); // 0xF8 ResponseUri                 ( ModelClassType Uri Uri Uri Pointer )
            value.LoginState                                = (FtpLoginState)GetInt32(new IntPtr(p + 0x100)); // 0x100 LoginState                  ( ModelEnumType FtpLoginState FtpLoginState FtpLoginState Int32 )
            value.StatusCode                                = (FtpStatusCode)GetInt32(new IntPtr(p + 0x104)); // 0x104 StatusCode                  ( ModelEnumType FtpStatusCode FtpStatusCode FtpStatusCode Int32 )
            value.StatusLine                                = GetString(new IntPtr(p + 0x108)); // 0x108 StatusLine                  ( ModelPrimitiveType string string string String )
            value.S_SSLHandshakeCallback                    = GetObject<AsyncCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0x10 S_SSLHandshakeCallback      ( ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )

            return value;
        }
    }
}
