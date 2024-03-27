using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Decoder                                  00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer
    // 018 M_encodedcert                            000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 M_from                                   0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 M_until                                  0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 030 Issuer                                   00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer
    // 038 M_issuername                             000186671910 ModelPrimitiveType string string string String
    // 040 M_keyalgo                                000186671910 ModelPrimitiveType string string string String
    // 048 M_keyalgoparams                          000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 Subject                                  00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer
    // 058 M_subject                                000186671910 ModelPrimitiveType string string string String
    // 060 M_publickey                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 068 Signature                                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 070 M_signaturealgo                          000186671910 ModelPrimitiveType string string string String
    // 078 M_signaturealgoparams                    000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 080 Certhash                                 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 088 Rsa                                      000186603C00 ModelClassType RSA RSA RSA Pointer
    // 090 Dsa                                      0001866736E0 ModelClassType DSA DSA DSA Pointer
    // 098 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A0 Serialnumber                             000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0A8 IssuerUniqueID                           000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0B0 SubjectUniqueID                          000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0B8 Extensions                               00018656AF80 ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer
    // 000 encoding_error                           string IL2CPP_TYPE_STRING
    public partial class X509Certificate
    {
        public ASN1?                                    Decoder                                 { get; set; }
        public List<sbyte>?                             M_encodedcert                           { get; set; }
        public DateTime                                 M_from                                  { get; set; }
        public DateTime                                 M_until                                 { get; set; }
        public ASN1?                                    Issuer                                  { get; set; }
        public string                                   M_issuername                            { get; set; }
        public string                                   M_keyalgo                               { get; set; }
        public List<sbyte>?                             M_keyalgoparams                         { get; set; }
        public ASN1?                                    Subject                                 { get; set; }
        public string                                   M_subject                               { get; set; }
        public List<sbyte>?                             M_publickey                             { get; set; }
        public List<sbyte>?                             Signature                               { get; set; }
        public string                                   M_signaturealgo                         { get; set; }
        public List<sbyte>?                             M_signaturealgoparams                   { get; set; }
        public List<sbyte>?                             Certhash                                { get; set; }
        public RSA?                                     Rsa                                     { get; set; }
        public DSA?                                     Dsa                                     { get; set; }
        public int                                      Version                                 { get; set; }
        public List<sbyte>?                             Serialnumber                            { get; set; }
        public List<sbyte>?                             IssuerUniqueID                          { get; set; }
        public List<sbyte>?                             SubjectUniqueID                         { get; set; }
        public X509ExtensionCollection?                 Extensions                              { get; set; }

        public static X509Certificate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Certificate();

            value.Decoder                                   = GetObject<ASN1>(new IntPtr(p + 0x010), ReversePrism.DataModels.ASN1.FromPointer); // 0270D79E4888 0x10 Decoder                     ( 00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer )
            value.M_encodedcert                             = GetSByteList(new IntPtr(p + 0x018)); // 0270D79E48A8 0x18 M_encodedcert               ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_from                                    = GetDateTime(new IntPtr(p + 0x020)); // 0270D79E48C8 0x20 M_from                      ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.M_until                                   = GetDateTime(new IntPtr(p + 0x028)); // 0270D79E48E8 0x28 M_until                     ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Issuer                                    = GetObject<ASN1>(new IntPtr(p + 0x030), ReversePrism.DataModels.ASN1.FromPointer); // 0270D79E4908 0x30 Issuer                      ( 00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer )
            value.M_issuername                              = GetString(new IntPtr(p + 0x038)); // 0270D79E4928 0x38 M_issuername                ( 000186671910 ModelPrimitiveType string string string String )
            value.M_keyalgo                                 = GetString(new IntPtr(p + 0x040)); // 0270D79E4948 0x40 M_keyalgo                   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_keyalgoparams                           = GetSByteList(new IntPtr(p + 0x048)); // 0270D79E4968 0x48 M_keyalgoparams             ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Subject                                   = GetObject<ASN1>(new IntPtr(p + 0x050), ReversePrism.DataModels.ASN1.FromPointer); // 0270D79E4988 0x50 Subject                     ( 00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer )
            value.M_subject                                 = GetString(new IntPtr(p + 0x058)); // 0270D79E49A8 0x58 M_subject                   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_publickey                               = GetSByteList(new IntPtr(p + 0x060)); // 0270D79E49C8 0x60 M_publickey                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Signature                                 = GetSByteList(new IntPtr(p + 0x068)); // 0270D79E49E8 0x68 Signature                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_signaturealgo                           = GetString(new IntPtr(p + 0x070)); // 0270D79E4A08 0x70 M_signaturealgo             ( 000186671910 ModelPrimitiveType string string string String )
            value.M_signaturealgoparams                     = GetSByteList(new IntPtr(p + 0x078)); // 0270D79E4A28 0x78 M_signaturealgoparams       ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Certhash                                  = GetSByteList(new IntPtr(p + 0x080)); // 0270D79E4A48 0x80 Certhash                    ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Rsa                                       = GetObject<RSA>(new IntPtr(p + 0x088), ReversePrism.DataModels.RSA.FromPointer); // 0270D79E4A68 0x88 Rsa                         ( 000186603C00 ModelClassType RSA RSA RSA Pointer )
            value.Dsa                                       = GetObject<DSA>(new IntPtr(p + 0x090), ReversePrism.DataModels.DSA.FromPointer); // 0270D79E4A88 0x90 Dsa                         ( 0001866736E0 ModelClassType DSA DSA DSA Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x098)); // 0270D79E4AA8 0x98 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Serialnumber                              = GetSByteList(new IntPtr(p + 0x0A0)); // 0270D79E4AC8 0xA0 Serialnumber                ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.IssuerUniqueID                            = GetSByteList(new IntPtr(p + 0x0A8)); // 0270D79E4AE8 0xA8 IssuerUniqueID              ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.SubjectUniqueID                           = GetSByteList(new IntPtr(p + 0x0B0)); // 0270D79E4B08 0xB0 SubjectUniqueID             ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Extensions                                = GetObject<X509ExtensionCollection>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.X509ExtensionCollection.FromPointer); // 0270D79E4B28 0xB8 Extensions                  ( 00018656AF80 ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer )

            return value;
        }
    }
}
