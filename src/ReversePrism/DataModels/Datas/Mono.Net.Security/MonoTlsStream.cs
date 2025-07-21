using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Provider                                 ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer
    // 018 NetworkStream                            ModelClassType NetworkStream NetworkStream NetworkStream Pointer
    // 020 Request                                  ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer
    // 028 Settings                                 ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer
    // 030 SslStream                                ModelClassType SslStream SslStream SslStream Pointer
    // 038 sslStreamLock                            <object> IL2CPP_TYPE_OBJECT
    // 040 Status                                   ModelEnumType WebExceptionStatus WebExceptionStatus WebExceptionStatus Int32
    // 044 CertificateValidationFailed              ModelPrimitiveType bool bool bool Bool
    public partial class MonoTlsStream : DataModel
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
            var value   = new MonoTlsStream() { Pointer= p0 };

            value.Provider                                  = GetObject<MobileTlsProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileTlsProvider.FromPointer); // 0x10 Provider                    ( ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer )
            value.NetworkStream                             = GetObject<NetworkStream>(new IntPtr(p + 0x018), ReversePrism.DataModels.NetworkStream.FromPointer); // 0x18 NetworkStream               ( ModelClassType NetworkStream NetworkStream NetworkStream Pointer )
            value.Request                                   = GetObject<HttpWebRequest>(new IntPtr(p + 0x020), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 0x20 Request                     ( ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.Settings                                  = GetObject<MonoTlsSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.MonoTlsSettings.FromPointer); // 0x28 Settings                    ( ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer )
            value.SslStream                                 = GetObject<SslStream>(new IntPtr(p + 0x030), ReversePrism.DataModels.SslStream.FromPointer); // 0x30 SslStream                   ( ModelClassType SslStream SslStream SslStream Pointer )
            value.Status                                    = (WebExceptionStatus)GetInt32(new IntPtr(p + 0x040)); // 0x40 Status                      ( ModelEnumType WebExceptionStatus WebExceptionStatus WebExceptionStatus Int32 )
            value.CertificateValidationFailed               = GetBool(new IntPtr(p + 0x044)); // 0x44 CertificateValidationFailed ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
