using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Decoder                                  ModelClassType ASN1 ASN1 ASN1 Pointer
    // 018 M_encodedcert                            ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 M_from                                   ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 M_until                                  ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 030 Issuer                                   ModelClassType ASN1 ASN1 ASN1 Pointer
    // 038 M_issuername                             ModelPrimitiveType string string string String
    // 040 M_keyalgo                                ModelPrimitiveType string string string String
    // 048 M_keyalgoparams                          ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 Subject                                  ModelClassType ASN1 ASN1 ASN1 Pointer
    // 058 M_subject                                ModelPrimitiveType string string string String
    // 060 M_publickey                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 068 Signature                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 070 M_signaturealgo                          ModelPrimitiveType string string string String
    // 078 M_signaturealgoparams                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 080 Certhash                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 088 Rsa                                      ModelClassType RSA RSA RSA Pointer
    // 090 Dsa                                      ModelClassType DSA DSA DSA Pointer
    // 098 Version                                  ModelPrimitiveType int int int Int32
    // 0A0 Serialnumber                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0A8 IssuerUniqueID                           ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0B0 SubjectUniqueID                          ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0B8 Extensions                               ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer
    // 000 encoding_error                           string IL2CPP_TYPE_STRING
    public partial class X509Certificate : DataModel
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
            var value   = new X509Certificate() { Pointer= p0 };

            value.Decoder                                   = GetObject<ASN1>(new IntPtr(p + 0x010), ReversePrism.DataModels.ASN1.FromPointer); // 0x10 Decoder                     ( ModelClassType ASN1 ASN1 ASN1 Pointer )
            value.M_encodedcert                             = GetSByteList(new IntPtr(p + 0x018)); // 0x18 M_encodedcert               ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_from                                    = GetDateTime(new IntPtr(p + 0x020)); // 0x20 M_from                      ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.M_until                                   = GetDateTime(new IntPtr(p + 0x028)); // 0x28 M_until                     ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Issuer                                    = GetObject<ASN1>(new IntPtr(p + 0x030), ReversePrism.DataModels.ASN1.FromPointer); // 0x30 Issuer                      ( ModelClassType ASN1 ASN1 ASN1 Pointer )
            value.M_issuername                              = GetString(new IntPtr(p + 0x038)); // 0x38 M_issuername                ( ModelPrimitiveType string string string String )
            value.M_keyalgo                                 = GetString(new IntPtr(p + 0x040)); // 0x40 M_keyalgo                   ( ModelPrimitiveType string string string String )
            value.M_keyalgoparams                           = GetSByteList(new IntPtr(p + 0x048)); // 0x48 M_keyalgoparams             ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Subject                                   = GetObject<ASN1>(new IntPtr(p + 0x050), ReversePrism.DataModels.ASN1.FromPointer); // 0x50 Subject                     ( ModelClassType ASN1 ASN1 ASN1 Pointer )
            value.M_subject                                 = GetString(new IntPtr(p + 0x058)); // 0x58 M_subject                   ( ModelPrimitiveType string string string String )
            value.M_publickey                               = GetSByteList(new IntPtr(p + 0x060)); // 0x60 M_publickey                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Signature                                 = GetSByteList(new IntPtr(p + 0x068)); // 0x68 Signature                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_signaturealgo                           = GetString(new IntPtr(p + 0x070)); // 0x70 M_signaturealgo             ( ModelPrimitiveType string string string String )
            value.M_signaturealgoparams                     = GetSByteList(new IntPtr(p + 0x078)); // 0x78 M_signaturealgoparams       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Certhash                                  = GetSByteList(new IntPtr(p + 0x080)); // 0x80 Certhash                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Rsa                                       = GetObject<RSA>(new IntPtr(p + 0x088), ReversePrism.DataModels.RSA.FromPointer); // 0x88 Rsa                         ( ModelClassType RSA RSA RSA Pointer )
            value.Dsa                                       = GetObject<DSA>(new IntPtr(p + 0x090), ReversePrism.DataModels.DSA.FromPointer); // 0x90 Dsa                         ( ModelClassType DSA DSA DSA Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x098)); // 0x98 Version                     ( ModelPrimitiveType int int int Int32 )
            value.Serialnumber                              = GetSByteList(new IntPtr(p + 0x0A0)); // 0xA0 Serialnumber                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.IssuerUniqueID                            = GetSByteList(new IntPtr(p + 0x0A8)); // 0xA8 IssuerUniqueID              ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.SubjectUniqueID                           = GetSByteList(new IntPtr(p + 0x0B0)); // 0xB0 SubjectUniqueID             ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Extensions                                = GetObject<X509ExtensionCollection>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.X509ExtensionCollection.FromPointer); // 0xB8 Extensions                  ( ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer )

            return value;
        }
    }
}
