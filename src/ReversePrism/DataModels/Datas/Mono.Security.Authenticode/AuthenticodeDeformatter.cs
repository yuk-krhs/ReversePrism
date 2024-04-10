using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Filename                                 000186671910 ModelPrimitiveType string string string String
    // 048 Rawdata                                  000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 Hash                                     000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 Coll                                     0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 060 SignedHash                               00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer
    // 068 Timestamp                                0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 070 SigningCertificate                       0001865639C0 ModelClassType X509Certificate X509Certificate X509Certificate Pointer
    // 078 Reason                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C TrustedRoot                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07D TrustedTimestampRoot                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 Entry                                    000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 088 SignerChain                              000186566D90 ModelClassType X509Chain X509Chain X509Chain Pointer
    // 090 TimestampChain                           000186566D90 ModelClassType X509Chain X509Chain X509Chain Pointer
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

            value.Filename                                  = GetString(new IntPtr(p + 0x040)); // 02466B439B80 0x40 Filename                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Rawdata                                   = GetSByteList(new IntPtr(p + 0x048)); // 02466B439BA0 0x48 Rawdata                     ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Hash                                      = GetSByteList(new IntPtr(p + 0x050)); // 02466B439BC0 0x50 Hash                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Coll                                      = GetObject<X509CertificateCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 02466B439BE0 0x58 Coll                        ( 0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.SignedHash                                = GetObject<ASN1>(new IntPtr(p + 0x060), ReversePrism.DataModels.ASN1.FromPointer); // 02466B439C00 0x60 SignedHash                  ( 00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer )
            value.Timestamp                                 = GetDateTime(new IntPtr(p + 0x068)); // 02466B439C20 0x68 Timestamp                   ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SigningCertificate                        = GetObject<X509Certificate>(new IntPtr(p + 0x070), ReversePrism.DataModels.X509Certificate.FromPointer); // 02466B439C40 0x70 SigningCertificate          ( 0001865639C0 ModelClassType X509Certificate X509Certificate X509Certificate Pointer )
            value.Reason                                    = GetInt32(new IntPtr(p + 0x078)); // 02466B439C60 0x78 Reason                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TrustedRoot                               = GetBool(new IntPtr(p + 0x07C)); // 02466B439C80 0x7C TrustedRoot                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TrustedTimestampRoot                      = GetBool(new IntPtr(p + 0x07D)); // 02466B439CA0 0x7D TrustedTimestampRoot        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Entry                                     = GetSByteList(new IntPtr(p + 0x080)); // 02466B439CC0 0x80 Entry                       ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.SignerChain                               = GetObject<X509Chain>(new IntPtr(p + 0x088), ReversePrism.DataModels.X509Chain.FromPointer); // 02466B439CE0 0x88 SignerChain                 ( 000186566D90 ModelClassType X509Chain X509Chain X509Chain Pointer )
            value.TimestampChain                            = GetObject<X509Chain>(new IntPtr(p + 0x090), ReversePrism.DataModels.X509Chain.FromPointer); // 02466B439D00 0x90 TimestampChain              ( 000186566D90 ModelClassType X509Chain X509Chain X509Chain Pointer )

            return value;
        }
    }
}
