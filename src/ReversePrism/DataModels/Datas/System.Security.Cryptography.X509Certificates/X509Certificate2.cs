using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 LazyRawData                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 068 LazySignatureAlgorithm                   0001866D8390 ModelClassType Oid Oid Oid Pointer
    // 070 LazyVersion                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 LazySubjectName                          000186562570 ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer
    // 080 LazyIssuerName                           000186562570 ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer
    // 088 LazyPublicKey                            0001865D9130 ModelClassType PublicKey PublicKey PublicKey Pointer
    // 090 LazyPrivateKey                           0001866EA670 ModelClassType AsymmetricAlgorithm AsymmetricAlgorithm AsymmetricAlgorithm Pointer
    // 098 LazyExtensions                           00018656B4A0 ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer
    public partial class X509Certificate2
    {
        public List<sbyte>?                             LazyRawData                             { get; set; }
        public Oid?                                     LazySignatureAlgorithm                  { get; set; }
        public int                                      LazyVersion                             { get; set; }
        public X500DistinguishedName?                   LazySubjectName                         { get; set; }
        public X500DistinguishedName?                   LazyIssuerName                          { get; set; }
        public PublicKey?                               LazyPublicKey                           { get; set; }
        public AsymmetricAlgorithm?                     LazyPrivateKey                          { get; set; }
        public X509ExtensionCollection?                 LazyExtensions                          { get; set; }

        public static X509Certificate2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Certificate2();

            value.LazyRawData                               = GetSByteList(new IntPtr(p + 0x060)); // 0270D78EDBC0 0x60 LazyRawData                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LazySignatureAlgorithm                    = GetObject<Oid>(new IntPtr(p + 0x068), ReversePrism.DataModels.Oid.FromPointer); // 0270D78EDBE0 0x68 LazySignatureAlgorithm      ( 0001866D8390 ModelClassType Oid Oid Oid Pointer )
            value.LazyVersion                               = GetInt32(new IntPtr(p + 0x070)); // 0270D78EDC00 0x70 LazyVersion                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LazySubjectName                           = GetObject<X500DistinguishedName>(new IntPtr(p + 0x078), ReversePrism.DataModels.X500DistinguishedName.FromPointer); // 0270D78EDC20 0x78 LazySubjectName             ( 000186562570 ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer )
            value.LazyIssuerName                            = GetObject<X500DistinguishedName>(new IntPtr(p + 0x080), ReversePrism.DataModels.X500DistinguishedName.FromPointer); // 0270D78EDC40 0x80 LazyIssuerName              ( 000186562570 ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer )
            value.LazyPublicKey                             = GetObject<PublicKey>(new IntPtr(p + 0x088), ReversePrism.DataModels.PublicKey.FromPointer); // 0270D78EDC60 0x88 LazyPublicKey               ( 0001865D9130 ModelClassType PublicKey PublicKey PublicKey Pointer )
            value.LazyPrivateKey                            = GetObject<AsymmetricAlgorithm>(new IntPtr(p + 0x090), ReversePrism.DataModels.AsymmetricAlgorithm.FromPointer); // 0270D78EDC80 0x90 LazyPrivateKey              ( 0001866EA670 ModelClassType AsymmetricAlgorithm AsymmetricAlgorithm AsymmetricAlgorithm Pointer )
            value.LazyExtensions                            = GetObject<X509ExtensionCollection>(new IntPtr(p + 0x098), ReversePrism.DataModels.X509ExtensionCollection.FromPointer); // 0270D78EDCA0 0x98 LazyExtensions              ( 00018656B4A0 ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer )

            return value;
        }
    }
}
