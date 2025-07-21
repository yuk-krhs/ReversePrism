using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 018 M_DownloadHandler                        ModelClassType DownloadHandler DownloadHandler DownloadHandler Pointer
    // 020 M_UploadHandler                          ModelClassType UploadHandler UploadHandler UploadHandler Pointer
    // 028 M_CertificateHandler                     ModelClassType CertificateHandler CertificateHandler CertificateHandler Pointer
    // 030 M_Uri                                    ModelClassType Uri Uri Uri Pointer
    // 038 DisposeCertificateHandlerOnDispose       ModelPrimitiveType bool bool bool Bool
    // 039 DisposeDownloadHandlerOnDispose          ModelPrimitiveType bool bool bool Bool
    // 03A DisposeUploadHandlerOnDispose            ModelPrimitiveType bool bool bool Bool
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

            value.M_DownloadHandler                         = GetObject<DownloadHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.DownloadHandler.FromPointer); // 0x18 M_DownloadHandler           ( ModelClassType DownloadHandler DownloadHandler DownloadHandler Pointer )
            value.M_UploadHandler                           = GetObject<UploadHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.UploadHandler.FromPointer); // 0x20 M_UploadHandler             ( ModelClassType UploadHandler UploadHandler UploadHandler Pointer )
            value.M_CertificateHandler                      = GetObject<CertificateHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.CertificateHandler.FromPointer); // 0x28 M_CertificateHandler        ( ModelClassType CertificateHandler CertificateHandler CertificateHandler Pointer )
            value.M_Uri                                     = GetObject<Uri>(new IntPtr(p + 0x030), ReversePrism.DataModels.Uri.FromPointer); // 0x30 M_Uri                       ( ModelClassType Uri Uri Uri Pointer )
            value.DisposeCertificateHandlerOnDispose        = GetBool(new IntPtr(p + 0x038)); // 0x38 DisposeCertificateHandlerOnDispose ( ModelPrimitiveType bool bool bool Bool )
            value.DisposeDownloadHandlerOnDispose           = GetBool(new IntPtr(p + 0x039)); // 0x39 DisposeDownloadHandlerOnDispose ( ModelPrimitiveType bool bool bool Bool )
            value.DisposeUploadHandlerOnDispose             = GetBool(new IntPtr(p + 0x03A)); // 0x3A DisposeUploadHandlerOnDispose ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
