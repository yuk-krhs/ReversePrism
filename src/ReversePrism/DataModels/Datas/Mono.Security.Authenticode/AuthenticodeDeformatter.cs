using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Filename                                 ModelPrimitiveType string string string String
    // 048 Rawdata                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 Hash                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 Coll                                     ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 060 SignedHash                               ModelClassType ASN1 ASN1 ASN1 Pointer
    // 068 Timestamp                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 070 SigningCertificate                       ModelClassType X509Certificate X509Certificate X509Certificate Pointer
    // 078 Reason                                   ModelPrimitiveType int int int Int32
    // 07C TrustedRoot                              ModelPrimitiveType bool bool bool Bool
    // 07D TrustedTimestampRoot                     ModelPrimitiveType bool bool bool Bool
    // 080 Entry                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 088 SignerChain                              ModelClassType X509Chain X509Chain X509Chain Pointer
    // 090 TimestampChain                           ModelClassType X509Chain X509Chain X509Chain Pointer
    public partial class AuthenticodeDeformatter : DataModel
    {
        public string                                   Filename                                { get; set; }
        public List<sbyte>?                             Rawdata                                 { get; set; }
        public List<sbyte>?                             Hash                                    { get; set; }
        public X509CertificateCollection?               Coll                                    { get; set; }
        public ASN1?                                    SignedHash                              { get; set; }
        public DateTime                                 Timestamp                               { get; set; }
        public X509Certificate?                         SigningCertificate                      { get; set; }
        public int                                      Reason                                  { get; set; }
        public bool                                     TrustedRoot                             { get; set; }
        public bool                                     TrustedTimestampRoot                    { get; set; }
        public List<sbyte>?                             Entry                                   { get; set; }
        public X509Chain?                               SignerChain                             { get; set; }
        public X509Chain?                               TimestampChain                          { get; set; }

        public static AuthenticodeDeformatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthenticodeDeformatter() { Pointer= p0 };

            value.Filename                                  = GetString(new IntPtr(p + 0x040)); // 0x40 Filename                    ( ModelPrimitiveType string string string String )
            value.Rawdata                                   = GetSByteList(new IntPtr(p + 0x048)); // 0x48 Rawdata                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Hash                                      = GetSByteList(new IntPtr(p + 0x050)); // 0x50 Hash                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Coll                                      = GetObject<X509CertificateCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0x58 Coll                        ( ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.SignedHash                                = GetObject<ASN1>(new IntPtr(p + 0x060), ReversePrism.DataModels.ASN1.FromPointer); // 0x60 SignedHash                  ( ModelClassType ASN1 ASN1 ASN1 Pointer )
            value.Timestamp                                 = GetDateTime(new IntPtr(p + 0x068)); // 0x68 Timestamp                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SigningCertificate                        = GetObject<X509Certificate>(new IntPtr(p + 0x070), ReversePrism.DataModels.X509Certificate.FromPointer); // 0x70 SigningCertificate          ( ModelClassType X509Certificate X509Certificate X509Certificate Pointer )
            value.Reason                                    = GetInt32(new IntPtr(p + 0x078)); // 0x78 Reason                      ( ModelPrimitiveType int int int Int32 )
            value.TrustedRoot                               = GetBool(new IntPtr(p + 0x07C)); // 0x7C TrustedRoot                 ( ModelPrimitiveType bool bool bool Bool )
            value.TrustedTimestampRoot                      = GetBool(new IntPtr(p + 0x07D)); // 0x7D TrustedTimestampRoot        ( ModelPrimitiveType bool bool bool Bool )
            value.Entry                                     = GetSByteList(new IntPtr(p + 0x080)); // 0x80 Entry                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.SignerChain                               = GetObject<X509Chain>(new IntPtr(p + 0x088), ReversePrism.DataModels.X509Chain.FromPointer); // 0x88 SignerChain                 ( ModelClassType X509Chain X509Chain X509Chain Pointer )
            value.TimestampChain                            = GetObject<X509Chain>(new IntPtr(p + 0x090), ReversePrism.DataModels.X509Chain.FromPointer); // 0x90 TimestampChain              ( ModelClassType X509Chain X509Chain X509Chain Pointer )

            return value;
        }
    }
}
