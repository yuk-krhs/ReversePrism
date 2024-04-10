using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Impl                                     000186565E40 ModelClassType X509CertificateImpl X509CertificateImpl X509CertificateImpl Pointer
    // 018 LazyCertHash                             000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 LazySerialNumber                         000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 LazyIssuer                               000186671910 ModelPrimitiveType string string string String
    // 030 LazySubject                              000186671910 ModelPrimitiveType string string string String
    // 038 LazyKeyAlgorithm                         000186671910 ModelPrimitiveType string string string String
    // 040 LazyKeyAlgorithmParameters               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 LazyPublicKey                            000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 LazyNotBefore                            0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 058 LazyNotAfter                             0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class X509Certificate : DataModel
    {
        public X509CertificateImpl?                     Impl                                    { get; set; }
        public List<sbyte>?                             LazyCertHash                            { get; set; }
        public List<sbyte>?                             LazySerialNumber                        { get; set; }
        public string                                   LazyIssuer                              { get; set; }
        public string                                   LazySubject                             { get; set; }
        public string                                   LazyKeyAlgorithm                        { get; set; }
        public List<sbyte>?                             LazyKeyAlgorithmParameters              { get; set; }
        public List<sbyte>?                             LazyPublicKey                           { get; set; }
        public DateTime                                 LazyNotBefore                           { get; set; }
        public DateTime                                 LazyNotAfter                            { get; set; }

        public static X509Certificate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Certificate() { Pointer= p0 };

            value.Impl                                      = GetObject<X509CertificateImpl>(new IntPtr(p + 0x010), ReversePrism.DataModels.X509CertificateImpl.FromPointer); // 0246669A6C50 0x10 Impl                        ( 000186565E40 ModelClassType X509CertificateImpl X509CertificateImpl X509CertificateImpl Pointer )
            value.LazyCertHash                              = GetSByteList(new IntPtr(p + 0x018)); // 0246669A6C70 0x18 LazyCertHash                ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LazySerialNumber                          = GetSByteList(new IntPtr(p + 0x020)); // 0246669A6C90 0x20 LazySerialNumber            ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LazyIssuer                                = GetString(new IntPtr(p + 0x028)); // 0246669A6CB0 0x28 LazyIssuer                  ( 000186671910 ModelPrimitiveType string string string String )
            value.LazySubject                               = GetString(new IntPtr(p + 0x030)); // 0246669A6CD0 0x30 LazySubject                 ( 000186671910 ModelPrimitiveType string string string String )
            value.LazyKeyAlgorithm                          = GetString(new IntPtr(p + 0x038)); // 0246669A6CF0 0x38 LazyKeyAlgorithm            ( 000186671910 ModelPrimitiveType string string string String )
            value.LazyKeyAlgorithmParameters                = GetSByteList(new IntPtr(p + 0x040)); // 0246669A6D10 0x40 LazyKeyAlgorithmParameters  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LazyPublicKey                             = GetSByteList(new IntPtr(p + 0x048)); // 0246669A6D30 0x48 LazyPublicKey               ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LazyNotBefore                             = GetDateTime(new IntPtr(p + 0x050)); // 0246669A6D50 0x50 LazyNotBefore               ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.LazyNotAfter                              = GetDateTime(new IntPtr(p + 0x058)); // 0246669A6D70 0x58 LazyNotAfter                ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
