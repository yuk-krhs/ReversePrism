using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RemoteCertificateValidationCallback      ModelClassType MonoRemoteCertificateValidationCallback MonoRemoteCertificateValidationCallback MonoRemoteCertificateValidationCallback Pointer
    // 018 ClientCertificateSelectionCallback       ModelClassType MonoLocalCertificateSelectionCallback MonoLocalCertificateSelectionCallback MonoLocalCertificateSelectionCallback Pointer
    // 020 CertificateValidationTime                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 TrustAnchors                             ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 038 <UserSettings>k__BackingField            <object> IL2CPP_TYPE_OBJECT
    // 040 CertificateSearchPaths                   ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 SendCloseNotify                          ModelPrimitiveType bool bool bool Bool
    // 050 ClientCertificateIssuers                 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 DisallowUnauthenticatedCertificateRequest ModelPrimitiveType bool bool bool Bool
    // 05C <EnabledProtocols>k__BackingField        Nullable`1<TlsProtocols> IL2CPP_TYPE_GENERICINST
    // 068 EnabledCiphers                           ModelEnumListType CipherSuiteCode[] CipherSuiteCode[] List<CipherSuiteCode> Pointer
    // 070 Cloned                                   ModelPrimitiveType bool bool bool Bool
    // 071 CheckCertName                            ModelPrimitiveType bool bool bool Bool
    // 072 CheckCertRevocationStatus                ModelPrimitiveType bool bool bool Bool
    // 073 useServicePointManagerCallback           Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 075 SkipSystemValidators                     ModelPrimitiveType bool bool bool Bool
    // 076 CallbackNeedsChain                       ModelPrimitiveType bool bool bool Bool
    // 078 CertificateValidator                     ModelClassType ICertificateValidator ICertificateValidator ICertificateValidator Pointer
    // 000 defaultSettings                          MonoTlsSettings IL2CPP_TYPE_CLASS
    public partial class MonoTlsSettings : DataModel
    {
        public MonoRemoteCertificateValidationCallback? RemoteCertificateValidationCallback     { get; set; }
        public MonoLocalCertificateSelectionCallback?   ClientCertificateSelectionCallback      { get; set; }
        public DateTime                                 CertificateValidationTime               { get; set; }
        public X509CertificateCollection?               TrustAnchors                            { get; set; }
        public List<string>?                            CertificateSearchPaths                  { get; set; }
        public bool                                     SendCloseNotify                         { get; set; }
        public List<string>?                            ClientCertificateIssuers                { get; set; }
        public bool                                     DisallowUnauthenticatedCertificateRequest { get; set; }
        public List<CipherSuiteCode>?                   EnabledCiphers                          { get; set; }
        public bool                                     Cloned                                  { get; set; }
        public bool                                     CheckCertName                           { get; set; }
        public bool                                     CheckCertRevocationStatus               { get; set; }
        public bool                                     SkipSystemValidators                    { get; set; }
        public bool                                     CallbackNeedsChain                      { get; set; }
        public ICertificateValidator?                   CertificateValidator                    { get; set; }

        public static MonoTlsSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoTlsSettings() { Pointer= p0 };

            value.RemoteCertificateValidationCallback       = GetObject<MonoRemoteCertificateValidationCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.MonoRemoteCertificateValidationCallback.FromPointer); // 0x10 RemoteCertificateValidationCallback ( ModelClassType MonoRemoteCertificateValidationCallback MonoRemoteCertificateValidationCallback MonoRemoteCertificateValidationCallback Pointer )
            value.ClientCertificateSelectionCallback        = GetObject<MonoLocalCertificateSelectionCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.MonoLocalCertificateSelectionCallback.FromPointer); // 0x18 ClientCertificateSelectionCallback ( ModelClassType MonoLocalCertificateSelectionCallback MonoLocalCertificateSelectionCallback MonoLocalCertificateSelectionCallback Pointer )
            value.CertificateValidationTime                 = GetDateTime(new IntPtr(p + 0x020)); // 0x20 CertificateValidationTime   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.TrustAnchors                              = GetObject<X509CertificateCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0x30 TrustAnchors                ( ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.CertificateSearchPaths                    = GetStringList(new IntPtr(p + 0x040)); // 0x40 CertificateSearchPaths      ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SendCloseNotify                           = GetBool(new IntPtr(p + 0x048)); // 0x48 SendCloseNotify             ( ModelPrimitiveType bool bool bool Bool )
            value.ClientCertificateIssuers                  = GetStringList(new IntPtr(p + 0x050)); // 0x50 ClientCertificateIssuers    ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.DisallowUnauthenticatedCertificateRequest = GetBool(new IntPtr(p + 0x058)); // 0x58 DisallowUnauthenticatedCertificateRequest ( ModelPrimitiveType bool bool bool Bool )
            value.EnabledCiphers                            = GetEnumList<CipherSuiteCode>(new IntPtr(p + 0x068)); // 0x68 EnabledCiphers              ( ModelEnumListType CipherSuiteCode[] CipherSuiteCode[] List<CipherSuiteCode> Pointer )
            value.Cloned                                    = GetBool(new IntPtr(p + 0x070)); // 0x70 Cloned                      ( ModelPrimitiveType bool bool bool Bool )
            value.CheckCertName                             = GetBool(new IntPtr(p + 0x071)); // 0x71 CheckCertName               ( ModelPrimitiveType bool bool bool Bool )
            value.CheckCertRevocationStatus                 = GetBool(new IntPtr(p + 0x072)); // 0x72 CheckCertRevocationStatus   ( ModelPrimitiveType bool bool bool Bool )
            value.SkipSystemValidators                      = GetBool(new IntPtr(p + 0x075)); // 0x75 SkipSystemValidators        ( ModelPrimitiveType bool bool bool Bool )
            value.CallbackNeedsChain                        = GetBool(new IntPtr(p + 0x076)); // 0x76 CallbackNeedsChain          ( ModelPrimitiveType bool bool bool Bool )
            value.CertificateValidator                      = GetObject<ICertificateValidator>(new IntPtr(p + 0x078), ReversePrism.DataModels.ICertificateValidator.FromPointer); // 0x78 CertificateValidator        ( ModelClassType ICertificateValidator ICertificateValidator ICertificateValidator Pointer )

            return value;
        }
    }
}
