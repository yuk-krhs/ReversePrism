using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Provider                                 000186638170 ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer
    // 018 NetworkStream                            00018669CF40 ModelClassType NetworkStream NetworkStream NetworkStream Pointer
    // 020 Request                                  0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer
    // 028 Settings                                 000186617640 ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer
    // 030 SslStream                                00018655DF50 ModelClassType SslStream SslStream SslStream Pointer
    // 038 sslStreamLock                            <object> IL2CPP_TYPE_OBJECT
    // 040 Status                                   00018654AAC0 ModelEnumType WebExceptionStatus WebExceptionStatus WebExceptionStatus Int32
    // 044 CertificateValidationFailed              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MonoTlsStream
    {
        public MobileTlsProvider?                       Provider                                { get; set; }
        public NetworkStream?                           NetworkStream                           { get; set; }
        public HttpWebRequest?                          Request                                 { get; set; }
        public MonoTlsSettings?                         Settings                                { get; set; }
        public SslStream?                               SslStream                               { get; set; }
        public WebExceptionStatus                       Status                                  { get; set; }
        public bool                                     CertificateValidationFailed             { get; set; }

        public static MonoTlsStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoTlsStream();

            value.Provider                                  = GetObject<MobileTlsProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileTlsProvider.FromPointer); // 0270D7914CC8 0x10 Provider                    ( 000186638170 ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer )
            value.NetworkStream                             = GetObject<NetworkStream>(new IntPtr(p + 0x018), ReversePrism.DataModels.NetworkStream.FromPointer); // 0270D7914CE8 0x18 NetworkStream               ( 00018669CF40 ModelClassType NetworkStream NetworkStream NetworkStream Pointer )
            value.Request                                   = GetObject<HttpWebRequest>(new IntPtr(p + 0x020), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 0270D7914D08 0x20 Request                     ( 0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.Settings                                  = GetObject<MonoTlsSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.MonoTlsSettings.FromPointer); // 0270D7914D28 0x28 Settings                    ( 000186617640 ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer )
            value.SslStream                                 = GetObject<SslStream>(new IntPtr(p + 0x030), ReversePrism.DataModels.SslStream.FromPointer); // 0270D7914D48 0x30 SslStream                   ( 00018655DF50 ModelClassType SslStream SslStream SslStream Pointer )
            value.Status                                    = (WebExceptionStatus)GetInt32(new IntPtr(p + 0x040)); // 0270D7914D88 0x40 Status                      ( 00018654AAC0 ModelEnumType WebExceptionStatus WebExceptionStatus WebExceptionStatus Int32 )
            value.CertificateValidationFailed               = GetBool(new IntPtr(p + 0x044)); // 0270D7914DA8 0x44 CertificateValidationFailed ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
