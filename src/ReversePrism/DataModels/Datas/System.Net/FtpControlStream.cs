using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 DataSocket                               0001865214F0 ModelClassType Socket Socket Socket Pointer
    // 090 PassiveEndPoint                          0001865CD830 ModelClassType IPEndPoint IPEndPoint IPEndPoint Pointer
    // 098 TlsStream                                00018667E290 ModelClassType TlsStream TlsStream TlsStream Pointer
    // 0A0 BannerMessage                            000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 0A8 WelcomeMessage                           000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 0B0 ExitMessage                              000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 0B8 Credentials                              0001866B4810 ModelClassType WeakReference WeakReference WeakReference Pointer
    // 0C0 CurrentTypeSetting                       000186671910 ModelPrimitiveType string string string String
    // 0C8 ContentLength                            0001865F7700 ModelPrimitiveType long long long Int64
    // 0D0 LastModified                             0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 0D8 DataHandshakeStarted                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E0 LoginDirectory                           000186671910 ModelPrimitiveType string string string String
    // 0E8 EstablishedServerDirectory               000186671910 ModelPrimitiveType string string string String
    // 0F0 RequestedServerDirectory                 000186671910 ModelPrimitiveType string string string String
    // 0F8 ResponseUri                              0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 100 LoginState                               0001865CF350 ModelEnumType FtpLoginState FtpLoginState FtpLoginState Int32
    // 104 StatusCode                               0001865D0E10 ModelEnumType FtpStatusCode FtpStatusCode FtpStatusCode Int32
    // 108 StatusLine                               000186671BA0 ModelPrimitiveType string string string String
    // 000 s_acceptCallbackDelegate                 AsyncCallback IL2CPP_TYPE_CLASS
    // 008 s_connectCallbackDelegate                AsyncCallback IL2CPP_TYPE_CLASS
    // 010 S_SSLHandshakeCallback                   0001866EE8C0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    public partial class FtpControlStream
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
            var value   = new FtpControlStream();

            value.DataSocket                                = GetObject<Socket>(new IntPtr(p + 0x088), ReversePrism.DataModels.Socket.FromPointer); // 0270D7A101E0 0x88 DataSocket                  ( 0001865214F0 ModelClassType Socket Socket Socket Pointer )
            value.PassiveEndPoint                           = GetObject<IPEndPoint>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPEndPoint.FromPointer); // 0270D7A10200 0x90 PassiveEndPoint             ( 0001865CD830 ModelClassType IPEndPoint IPEndPoint IPEndPoint Pointer )
            value.TlsStream                                 = GetObject<TlsStream>(new IntPtr(p + 0x098), ReversePrism.DataModels.TlsStream.FromPointer); // 0270D7A10220 0x98 TlsStream                   ( 00018667E290 ModelClassType TlsStream TlsStream TlsStream Pointer )
            value.BannerMessage                             = GetObject<StringBuilder>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.StringBuilder.FromPointer); // 0270D7A10240 0xA0 BannerMessage               ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.WelcomeMessage                            = GetObject<StringBuilder>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.StringBuilder.FromPointer); // 0270D7A10260 0xA8 WelcomeMessage              ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.ExitMessage                               = GetObject<StringBuilder>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.StringBuilder.FromPointer); // 0270D7A10280 0xB0 ExitMessage                 ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.Credentials                               = GetObject<WeakReference>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.WeakReference.FromPointer); // 0270D7A102A0 0xB8 Credentials                 ( 0001866B4810 ModelClassType WeakReference WeakReference WeakReference Pointer )
            value.CurrentTypeSetting                        = GetString(new IntPtr(p + 0x0C0)); // 0270D7A102C0 0xC0 CurrentTypeSetting          ( 000186671910 ModelPrimitiveType string string string String )
            value.ContentLength                             = GetInt64(new IntPtr(p + 0x0C8)); // 0270D7A102E0 0xC8 ContentLength               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.LastModified                              = GetDateTime(new IntPtr(p + 0x0D0)); // 0270D7A10300 0xD0 LastModified                ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.DataHandshakeStarted                      = GetBool(new IntPtr(p + 0x0D8)); // 0270D7A10320 0xD8 DataHandshakeStarted        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LoginDirectory                            = GetString(new IntPtr(p + 0x0E0)); // 0270D7A10340 0xE0 LoginDirectory              ( 000186671910 ModelPrimitiveType string string string String )
            value.EstablishedServerDirectory                = GetString(new IntPtr(p + 0x0E8)); // 0270D7A10360 0xE8 EstablishedServerDirectory  ( 000186671910 ModelPrimitiveType string string string String )
            value.RequestedServerDirectory                  = GetString(new IntPtr(p + 0x0F0)); // 0270D7A10380 0xF0 RequestedServerDirectory    ( 000186671910 ModelPrimitiveType string string string String )
            value.ResponseUri                               = GetObject<Uri>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Uri.FromPointer); // 0270D7A103A0 0xF8 ResponseUri                 ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.LoginState                                = (FtpLoginState)GetInt32(new IntPtr(p + 0x100)); // 0270D7A103C0 0x100 LoginState                  ( 0001865CF350 ModelEnumType FtpLoginState FtpLoginState FtpLoginState Int32 )
            value.StatusCode                                = (FtpStatusCode)GetInt32(new IntPtr(p + 0x104)); // 0270D7A103E0 0x104 StatusCode                  ( 0001865D0E10 ModelEnumType FtpStatusCode FtpStatusCode FtpStatusCode Int32 )
            value.StatusLine                                = GetString(new IntPtr(p + 0x108)); // 0270D7A10400 0x108 StatusLine                  ( 000186671BA0 ModelPrimitiveType string string string String )
            value.S_SSLHandshakeCallback                    = GetObject<AsyncCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0270D7A10460 0x10 S_SSLHandshakeCallback      ( 0001866EE8C0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )

            return value;
        }
    }
}
