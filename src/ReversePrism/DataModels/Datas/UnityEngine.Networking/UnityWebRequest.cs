using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 018 M_DownloadHandler                        0001866F0740 ModelClassType DownloadHandler DownloadHandler DownloadHandler Pointer
    // 020 M_UploadHandler                          000186744060 ModelClassType UploadHandler UploadHandler UploadHandler Pointer
    // 028 M_CertificateHandler                     000186554AC0 ModelClassType CertificateHandler CertificateHandler CertificateHandler Pointer
    // 030 M_Uri                                    0001866A5130 ModelClassType Uri Uri Uri Pointer
    // 038 DisposeCertificateHandlerOnDispose       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 DisposeDownloadHandlerOnDispose          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03A DisposeUploadHandlerOnDispose            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UnityWebRequest : DataModel
    {
        public DownloadHandler?                         M_DownloadHandler                       { get; set; }
        public UploadHandler?                           M_UploadHandler                         { get; set; }
        public CertificateHandler?                      M_CertificateHandler                    { get; set; }
        public Uri?                                     M_Uri                                   { get; set; }
        public bool                                     DisposeCertificateHandlerOnDispose      { get; set; }
        public bool                                     DisposeDownloadHandlerOnDispose         { get; set; }
        public bool                                     DisposeUploadHandlerOnDispose           { get; set; }

        public static UnityWebRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityWebRequest() { Pointer= p0 };

            value.M_DownloadHandler                         = GetObject<DownloadHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.DownloadHandler.FromPointer); // 0245A4C564A8 0x18 M_DownloadHandler           ( 0001866F0740 ModelClassType DownloadHandler DownloadHandler DownloadHandler Pointer )
            value.M_UploadHandler                           = GetObject<UploadHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.UploadHandler.FromPointer); // 0245A4C564C8 0x20 M_UploadHandler             ( 000186744060 ModelClassType UploadHandler UploadHandler UploadHandler Pointer )
            value.M_CertificateHandler                      = GetObject<CertificateHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.CertificateHandler.FromPointer); // 0245A4C564E8 0x28 M_CertificateHandler        ( 000186554AC0 ModelClassType CertificateHandler CertificateHandler CertificateHandler Pointer )
            value.M_Uri                                     = GetObject<Uri>(new IntPtr(p + 0x030), ReversePrism.DataModels.Uri.FromPointer); // 0245A4C56508 0x30 M_Uri                       ( 0001866A5130 ModelClassType Uri Uri Uri Pointer )
            value.DisposeCertificateHandlerOnDispose        = GetBool(new IntPtr(p + 0x038)); // 0245A4C56528 0x38 DisposeCertificateHandlerOnDispose ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DisposeDownloadHandlerOnDispose           = GetBool(new IntPtr(p + 0x039)); // 0245A4C56548 0x39 DisposeDownloadHandlerOnDispose ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DisposeUploadHandlerOnDispose             = GetBool(new IntPtr(p + 0x03A)); // 0245A4C56568 0x3A DisposeUploadHandlerOnDispose ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
