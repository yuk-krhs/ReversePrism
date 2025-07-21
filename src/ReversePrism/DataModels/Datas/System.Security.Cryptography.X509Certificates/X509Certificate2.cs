using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 LazyRawData                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 068 LazySignatureAlgorithm                   ModelClassType Oid Oid Oid Pointer
    // 070 LazyVersion                              ModelPrimitiveType int int int Int32
    // 078 LazySubjectName                          ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer
    // 080 LazyIssuerName                           ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer
    // 088 LazyPublicKey                            ModelClassType PublicKey PublicKey PublicKey Pointer
    // 090 LazyPrivateKey                           ModelClassType AsymmetricAlgorithm AsymmetricAlgorithm AsymmetricAlgorithm Pointer
    // 098 LazyExtensions                           ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer
    public partial class X509Certificate2 : DataModel
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
            var value   = new X509Certificate2() { Pointer= p0 };

            value.LazyRawData                               = GetSByteList(new IntPtr(p + 0x060)); // 0x60 LazyRawData                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LazySignatureAlgorithm                    = GetObject<Oid>(new IntPtr(p + 0x068), ReversePrism.DataModels.Oid.FromPointer); // 0x68 LazySignatureAlgorithm      ( ModelClassType Oid Oid Oid Pointer )
            value.LazyVersion                               = GetInt32(new IntPtr(p + 0x070)); // 0x70 LazyVersion                 ( ModelPrimitiveType int int int Int32 )
            value.LazySubjectName                           = GetObject<X500DistinguishedName>(new IntPtr(p + 0x078), ReversePrism.DataModels.X500DistinguishedName.FromPointer); // 0x78 LazySubjectName             ( ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer )
            value.LazyIssuerName                            = GetObject<X500DistinguishedName>(new IntPtr(p + 0x080), ReversePrism.DataModels.X500DistinguishedName.FromPointer); // 0x80 LazyIssuerName              ( ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer )
            value.LazyPublicKey                             = GetObject<PublicKey>(new IntPtr(p + 0x088), ReversePrism.DataModels.PublicKey.FromPointer); // 0x88 LazyPublicKey               ( ModelClassType PublicKey PublicKey PublicKey Pointer )
            value.LazyPrivateKey                            = GetObject<AsymmetricAlgorithm>(new IntPtr(p + 0x090), ReversePrism.DataModels.AsymmetricAlgorithm.FromPointer); // 0x90 LazyPrivateKey              ( ModelClassType AsymmetricAlgorithm AsymmetricAlgorithm AsymmetricAlgorithm Pointer )
            value.LazyExtensions                            = GetObject<X509ExtensionCollection>(new IntPtr(p + 0x098), ReversePrism.DataModels.X509ExtensionCollection.FromPointer); // 0x98 LazyExtensions              ( ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer )

            return value;
        }
    }
}
