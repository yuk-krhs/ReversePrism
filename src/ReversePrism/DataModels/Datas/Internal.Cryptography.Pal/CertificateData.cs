using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RawData                                  000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 SubjectPublicKeyInfo                     000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Version                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 SerialNumber                             000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 TbsSignature                             000186733490 ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32
    // 040 Issuer                                   000186562810 ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer
    // 048 NotBefore                                0001865B9320 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 NotAfter                                 0001865B9320 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 058 Subject                                  000186562810 ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer
    // 060 PublicKeyAlgorithm                       000186733490 ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32
    // 070 PublicKey                                000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 078 IssuerUniqueId                           000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 080 SubjectUniqueId                          000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 088 Extensions                               000185D1D308 ModelClassListType List`1<X509Extension> List`1<X509Extension> List<X509Extension> Pointer
    // 090 SignatureAlgorithm                       000186733490 ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32
    // 0A0 SignatureValue                           000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class CertificateData
    {
        public List<sbyte>?                             RawData                                 { get; set; }
        public List<sbyte>?                             SubjectPublicKeyInfo                    { get; set; }
        public int                                      Version                                 { get; set; }
        public List<sbyte>?                             SerialNumber                            { get; set; }
        public AlgorithmIdentifier                      TbsSignature                            { get; set; }
        public X500DistinguishedName?                   Issuer                                  { get; set; }
        public DateTime                                 NotBefore                               { get; set; }
        public DateTime                                 NotAfter                                { get; set; }
        public X500DistinguishedName?                   Subject                                 { get; set; }
        public AlgorithmIdentifier                      PublicKeyAlgorithm                      { get; set; }
        public List<sbyte>?                             PublicKey                               { get; set; }
        public List<sbyte>?                             IssuerUniqueId                          { get; set; }
        public List<sbyte>?                             SubjectUniqueId                         { get; set; }
        public List<X509Extension>?                     Extensions                              { get; set; }
        public AlgorithmIdentifier                      SignatureAlgorithm                      { get; set; }
        public List<sbyte>?                             SignatureValue                          { get; set; }

        public static CertificateData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CertificateData();

            value.RawData                                   = GetSByteList(new IntPtr(p + 0x010)); // 0270D793FDB8 0x10 RawData                     ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.SubjectPublicKeyInfo                      = GetSByteList(new IntPtr(p + 0x018)); // 0270D793FDD8 0x18 SubjectPublicKeyInfo        ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D793FDF8 0x20 Version                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.SerialNumber                              = GetSByteList(new IntPtr(p + 0x028)); // 0270D793FE18 0x28 SerialNumber                ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TbsSignature                              = (AlgorithmIdentifier)GetInt32(new IntPtr(p + 0x030)); // 0270D793FE38 0x30 TbsSignature                ( 000186733490 ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32 )
            value.Issuer                                    = GetObject<X500DistinguishedName>(new IntPtr(p + 0x040), ReversePrism.DataModels.X500DistinguishedName.FromPointer); // 0270D793FE58 0x40 Issuer                      ( 000186562810 ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer )
            value.NotBefore                                 = GetDateTime(new IntPtr(p + 0x048)); // 0270D793FE78 0x48 NotBefore                   ( 0001865B9320 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.NotAfter                                  = GetDateTime(new IntPtr(p + 0x050)); // 0270D793FE98 0x50 NotAfter                    ( 0001865B9320 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Subject                                   = GetObject<X500DistinguishedName>(new IntPtr(p + 0x058), ReversePrism.DataModels.X500DistinguishedName.FromPointer); // 0270D793FEB8 0x58 Subject                     ( 000186562810 ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer )
            value.PublicKeyAlgorithm                        = (AlgorithmIdentifier)GetInt32(new IntPtr(p + 0x060)); // 0270D793FED8 0x60 PublicKeyAlgorithm          ( 000186733490 ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32 )
            value.PublicKey                                 = GetSByteList(new IntPtr(p + 0x070)); // 0270D793FEF8 0x70 PublicKey                   ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.IssuerUniqueId                            = GetSByteList(new IntPtr(p + 0x078)); // 0270D793FF18 0x78 IssuerUniqueId              ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.SubjectUniqueId                           = GetSByteList(new IntPtr(p + 0x080)); // 0270D793FF38 0x80 SubjectUniqueId             ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Extensions                                = GetObjectList<X509Extension>(new IntPtr(p + 0x088), ReversePrism.DataModels.X509Extension.FromPointer); // 0270D793FF58 0x88 Extensions                  ( 000185D1D308 ModelClassListType List`1<X509Extension> List`1<X509Extension> List<X509Extension> Pointer )
            value.SignatureAlgorithm                        = (AlgorithmIdentifier)GetInt32(new IntPtr(p + 0x090)); // 0270D793FF78 0x90 SignatureAlgorithm          ( 000186733490 ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32 )
            value.SignatureValue                            = GetSByteList(new IntPtr(p + 0x0A0)); // 0270D793FF98 0xA0 SignatureValue              ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
