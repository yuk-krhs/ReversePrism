using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 owner                                    WeakReference`1<SslStream> IL2CPP_TYPE_GENERICINST
    // 018 Settings                                 000186617640 ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer
    // 020 Provider                                 000186638170 ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer
    // 028 CertValidationCallback                   000186733120 ModelClassType ServerCertValidationCallback ServerCertValidationCallback ServerCertValidationCallback Pointer
    // 030 CertSelectionCallback                    0001865A2760 ModelClassType LocalCertSelectionCallback LocalCertSelectionCallback LocalCertSelectionCallback Pointer
    // 038 TlsStream                                00018664DCE0 ModelClassType MonoTlsStream MonoTlsStream MonoTlsStream Pointer
    // 040 Request                                  0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer
    public partial class ChainValidationHelper
    {
        public MonoTlsSettings?                         Settings                                { get; set; }
        public MobileTlsProvider?                       Provider                                { get; set; }
        public ServerCertValidationCallback?            CertValidationCallback                  { get; set; }
        public LocalCertSelectionCallback?              CertSelectionCallback                   { get; set; }
        public MonoTlsStream?                           TlsStream                               { get; set; }
        public HttpWebRequest?                          Request                                 { get; set; }

        public static ChainValidationHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainValidationHelper();

            value.Settings                                  = GetObject<MonoTlsSettings>(new IntPtr(p + 0x018), ReversePrism.DataModels.MonoTlsSettings.FromPointer); // 0270D78F5108 0x18 Settings                    ( 000186617640 ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer )
            value.Provider                                  = GetObject<MobileTlsProvider>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileTlsProvider.FromPointer); // 0270D78F5128 0x20 Provider                    ( 000186638170 ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer )
            value.CertValidationCallback                    = GetObject<ServerCertValidationCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.ServerCertValidationCallback.FromPointer); // 0270D78F5148 0x28 CertValidationCallback      ( 000186733120 ModelClassType ServerCertValidationCallback ServerCertValidationCallback ServerCertValidationCallback Pointer )
            value.CertSelectionCallback                     = GetObject<LocalCertSelectionCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.LocalCertSelectionCallback.FromPointer); // 0270D78F5168 0x30 CertSelectionCallback       ( 0001865A2760 ModelClassType LocalCertSelectionCallback LocalCertSelectionCallback LocalCertSelectionCallback Pointer )
            value.TlsStream                                 = GetObject<MonoTlsStream>(new IntPtr(p + 0x038), ReversePrism.DataModels.MonoTlsStream.FromPointer); // 0270D78F5188 0x38 TlsStream                   ( 00018664DCE0 ModelClassType MonoTlsStream MonoTlsStream MonoTlsStream Pointer )
            value.Request                                   = GetObject<HttpWebRequest>(new IntPtr(p + 0x040), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 0270D78F51A8 0x40 Request                     ( 0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )

            return value;
        }
    }
}
