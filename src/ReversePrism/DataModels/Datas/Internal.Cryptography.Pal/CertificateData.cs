using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RawData                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 SubjectPublicKeyInfo                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Version                                  ModelPrimitiveType int int int Int32
    // 028 SerialNumber                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 TbsSignature                             ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32
    // 040 Issuer                                   ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer
    // 048 NotBefore                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 NotAfter                                 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 058 Subject                                  ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer
    // 060 PublicKeyAlgorithm                       ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32
    // 070 PublicKey                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 078 IssuerUniqueId                           ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 080 SubjectUniqueId                          ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 088 Extensions                               ModelClassListType List`1<X509Extension> List`1<X509Extension> List<X509Extension> Pointer
    // 090 SignatureAlgorithm                       ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32
    // 0A0 SignatureValue                           ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class CertificateData : DataModel
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
            var value   = new CertificateData() { Pointer= p0 };

            value.RawData                                   = GetSByteList(new IntPtr(p + 0x010)); // 0x10 RawData                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.SubjectPublicKeyInfo                      = GetSByteList(new IntPtr(p + 0x018)); // 0x18 SubjectPublicKeyInfo        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 Version                     ( ModelPrimitiveType int int int Int32 )
            value.SerialNumber                              = GetSByteList(new IntPtr(p + 0x028)); // 0x28 SerialNumber                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TbsSignature                              = (AlgorithmIdentifier)GetInt32(new IntPtr(p + 0x030)); // 0x30 TbsSignature                ( ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32 )
            value.Issuer                                    = GetObject<X500DistinguishedName>(new IntPtr(p + 0x040), ReversePrism.DataModels.X500DistinguishedName.FromPointer); // 0x40 Issuer                      ( ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer )
            value.NotBefore                                 = GetDateTime(new IntPtr(p + 0x048)); // 0x48 NotBefore                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.NotAfter                                  = GetDateTime(new IntPtr(p + 0x050)); // 0x50 NotAfter                    ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Subject                                   = GetObject<X500DistinguishedName>(new IntPtr(p + 0x058), ReversePrism.DataModels.X500DistinguishedName.FromPointer); // 0x58 Subject                     ( ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer )
            value.PublicKeyAlgorithm                        = (AlgorithmIdentifier)GetInt32(new IntPtr(p + 0x060)); // 0x60 PublicKeyAlgorithm          ( ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32 )
            value.PublicKey                                 = GetSByteList(new IntPtr(p + 0x070)); // 0x70 PublicKey                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.IssuerUniqueId                            = GetSByteList(new IntPtr(p + 0x078)); // 0x78 IssuerUniqueId              ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.SubjectUniqueId                           = GetSByteList(new IntPtr(p + 0x080)); // 0x80 SubjectUniqueId             ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Extensions                                = GetObjectList<X509Extension>(new IntPtr(p + 0x088), ReversePrism.DataModels.X509Extension.FromPointer); // 0x88 Extensions                  ( ModelClassListType List`1<X509Extension> List`1<X509Extension> List<X509Extension> Pointer )
            value.SignatureAlgorithm                        = (AlgorithmIdentifier)GetInt32(new IntPtr(p + 0x090)); // 0x90 SignatureAlgorithm          ( ModelEnumType AlgorithmIdentifier AlgorithmIdentifier AlgorithmIdentifier Int32 )
            value.SignatureValue                            = GetSByteList(new IntPtr(p + 0x0A0)); // 0xA0 SignatureValue              ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
