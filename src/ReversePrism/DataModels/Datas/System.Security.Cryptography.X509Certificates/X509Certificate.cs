using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Impl                                     ModelClassType X509CertificateImpl X509CertificateImpl X509CertificateImpl Pointer
    // 018 LazyCertHash                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 LazySerialNumber                         ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 LazyIssuer                               ModelPrimitiveType string string string String
    // 030 LazySubject                              ModelPrimitiveType string string string String
    // 038 LazyKeyAlgorithm                         ModelPrimitiveType string string string String
    // 040 LazyKeyAlgorithmParameters               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 LazyPublicKey                            ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 LazyNotBefore                            ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 058 LazyNotAfter                             ModelPrimitiveType DateTime DateTime DateTime DateTime
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

            value.Impl                                      = GetObject<X509CertificateImpl>(new IntPtr(p + 0x010), ReversePrism.DataModels.X509CertificateImpl.FromPointer); // 0x10 Impl                        ( ModelClassType X509CertificateImpl X509CertificateImpl X509CertificateImpl Pointer )
            value.LazyCertHash                              = GetSByteList(new IntPtr(p + 0x018)); // 0x18 LazyCertHash                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LazySerialNumber                          = GetSByteList(new IntPtr(p + 0x020)); // 0x20 LazySerialNumber            ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LazyIssuer                                = GetString(new IntPtr(p + 0x028)); // 0x28 LazyIssuer                  ( ModelPrimitiveType string string string String )
            value.LazySubject                               = GetString(new IntPtr(p + 0x030)); // 0x30 LazySubject                 ( ModelPrimitiveType string string string String )
            value.LazyKeyAlgorithm                          = GetString(new IntPtr(p + 0x038)); // 0x38 LazyKeyAlgorithm            ( ModelPrimitiveType string string string String )
            value.LazyKeyAlgorithmParameters                = GetSByteList(new IntPtr(p + 0x040)); // 0x40 LazyKeyAlgorithmParameters  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LazyPublicKey                             = GetSByteList(new IntPtr(p + 0x048)); // 0x48 LazyPublicKey               ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LazyNotBefore                             = GetDateTime(new IntPtr(p + 0x050)); // 0x50 LazyNotBefore               ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.LazyNotAfter                              = GetDateTime(new IntPtr(p + 0x058)); // 0x58 LazyNotAfter                ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
