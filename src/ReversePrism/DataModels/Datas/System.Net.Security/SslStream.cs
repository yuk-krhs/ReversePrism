using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Provider                                 ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer
    // 040 Settings                                 ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer
    // 048 ValidationCallback                       ModelClassType RemoteCertificateValidationCallback RemoteCertificateValidationCallback RemoteCertificateValidationCallback Pointer
    // 050 SelectionCallback                        ModelClassType LocalCertificateSelectionCallback LocalCertificateSelectionCallback LocalCertificateSelectionCallback Pointer
    // 058 Impl                                     ModelClassType MobileAuthenticatedStream MobileAuthenticatedStream MobileAuthenticatedStream Pointer
    // 060 ExplicitSettings                         ModelPrimitiveType bool bool bool Bool
    public partial class SslStream : DataModel
    {
        public MobileTlsProvider?                       Provider                                { get; set; }
        public MonoTlsSettings?                         Settings                                { get; set; }
        public RemoteCertificateValidationCallback?     ValidationCallback                      { get; set; }
        public LocalCertificateSelectionCallback?       SelectionCallback                       { get; set; }
        public MobileAuthenticatedStream?               Impl                                    { get; set; }
        public bool                                     ExplicitSettings                        { get; set; }

        public static SslStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SslStream() { Pointer= p0 };

            value.Provider                                  = GetObject<MobileTlsProvider>(new IntPtr(p + 0x038), ReversePrism.DataModels.MobileTlsProvider.FromPointer); // 0x38 Provider                    ( ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer )
            value.Settings                                  = GetObject<MonoTlsSettings>(new IntPtr(p + 0x040), ReversePrism.DataModels.MonoTlsSettings.FromPointer); // 0x40 Settings                    ( ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer )
            value.ValidationCallback                        = GetObject<RemoteCertificateValidationCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.RemoteCertificateValidationCallback.FromPointer); // 0x48 ValidationCallback          ( ModelClassType RemoteCertificateValidationCallback RemoteCertificateValidationCallback RemoteCertificateValidationCallback Pointer )
            value.SelectionCallback                         = GetObject<LocalCertificateSelectionCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.LocalCertificateSelectionCallback.FromPointer); // 0x50 SelectionCallback           ( ModelClassType LocalCertificateSelectionCallback LocalCertificateSelectionCallback LocalCertificateSelectionCallback Pointer )
            value.Impl                                      = GetObject<MobileAuthenticatedStream>(new IntPtr(p + 0x058), ReversePrism.DataModels.MobileAuthenticatedStream.FromPointer); // 0x58 Impl                        ( ModelClassType MobileAuthenticatedStream MobileAuthenticatedStream MobileAuthenticatedStream Pointer )
            value.ExplicitSettings                          = GetBool(new IntPtr(p + 0x060)); // 0x60 ExplicitSettings            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
