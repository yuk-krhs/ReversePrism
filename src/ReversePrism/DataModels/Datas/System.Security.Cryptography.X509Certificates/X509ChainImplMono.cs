using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Location                                 ModelEnumType StoreLocation StoreLocation StoreLocation Int32
    // 018 Elements                                 ModelClassType X509ChainElementCollection X509ChainElementCollection X509ChainElementCollection Pointer
    // 020 Policy                                   ModelClassType X509ChainPolicy X509ChainPolicy X509ChainPolicy Pointer
    // 028 Status                                   ModelEnumListType X509ChainStatus[] X509ChainStatus[] List<X509ChainStatus> Pointer
    // 000 Empty                                    X509ChainStatus[] IL2CPP_TYPE_SZARRAY
    // 030 Max_path_length                          ModelPrimitiveType int int int Int32
    // 038 Working_issuer_name                      ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer
    // 040 Working_public_key                       ModelClassType AsymmetricAlgorithm AsymmetricAlgorithm AsymmetricAlgorithm Pointer
    // 048 Bce_restriction                          ModelClassType X509ChainElement X509ChainElement X509ChainElement Pointer
    // 050 Roots                                    ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer
    // 058 Cas                                      ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer
    // 060 Root_store                               ModelClassType X509Store X509Store X509Store Pointer
    // 068 Ca_store                                 ModelClassType X509Store X509Store X509Store Pointer
    // 070 User_root_store                          ModelClassType X509Store X509Store X509Store Pointer
    // 078 User_ca_store                            ModelClassType X509Store X509Store X509Store Pointer
    // 080 Collection                               ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer
    public partial class X509ChainImplMono : DataModel
    {
        public StoreLocation                            Location                                { get; set; }
        public X509ChainElementCollection?              Elements                                { get; set; }
        public X509ChainPolicy?                         Policy                                  { get; set; }
        public List<X509ChainStatus>?                   Status                                  { get; set; }
        public int                                      Max_path_length                         { get; set; }
        public X500DistinguishedName?                   Working_issuer_name                     { get; set; }
        public AsymmetricAlgorithm?                     Working_public_key                      { get; set; }
        public X509ChainElement?                        Bce_restriction                         { get; set; }
        public X509Certificate2Collection?              Roots                                   { get; set; }
        public X509Certificate2Collection?              Cas                                     { get; set; }
        public X509Store?                               Root_store                              { get; set; }
        public X509Store?                               Ca_store                                { get; set; }
        public X509Store?                               User_root_store                         { get; set; }
        public X509Store?                               User_ca_store                           { get; set; }
        public X509Certificate2Collection?              Collection                              { get; set; }

        public static X509ChainImplMono? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ChainImplMono() { Pointer= p0 };

            value.Location                                  = (StoreLocation)GetInt32(new IntPtr(p + 0x010)); // 0x10 Location                    ( ModelEnumType StoreLocation StoreLocation StoreLocation Int32 )
            value.Elements                                  = GetObject<X509ChainElementCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.X509ChainElementCollection.FromPointer); // 0x18 Elements                    ( ModelClassType X509ChainElementCollection X509ChainElementCollection X509ChainElementCollection Pointer )
            value.Policy                                    = GetObject<X509ChainPolicy>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509ChainPolicy.FromPointer); // 0x20 Policy                      ( ModelClassType X509ChainPolicy X509ChainPolicy X509ChainPolicy Pointer )
            value.Status                                    = GetEnumList<X509ChainStatus>(new IntPtr(p + 0x028)); // 0x28 Status                      ( ModelEnumListType X509ChainStatus[] X509ChainStatus[] List<X509ChainStatus> Pointer )
            value.Max_path_length                           = GetInt32(new IntPtr(p + 0x030)); // 0x30 Max_path_length             ( ModelPrimitiveType int int int Int32 )
            value.Working_issuer_name                       = GetObject<X500DistinguishedName>(new IntPtr(p + 0x038), ReversePrism.DataModels.X500DistinguishedName.FromPointer); // 0x38 Working_issuer_name         ( ModelClassType X500DistinguishedName X500DistinguishedName X500DistinguishedName Pointer )
            value.Working_public_key                        = GetObject<AsymmetricAlgorithm>(new IntPtr(p + 0x040), ReversePrism.DataModels.AsymmetricAlgorithm.FromPointer); // 0x40 Working_public_key          ( ModelClassType AsymmetricAlgorithm AsymmetricAlgorithm AsymmetricAlgorithm Pointer )
            value.Bce_restriction                           = GetObject<X509ChainElement>(new IntPtr(p + 0x048), ReversePrism.DataModels.X509ChainElement.FromPointer); // 0x48 Bce_restriction             ( ModelClassType X509ChainElement X509ChainElement X509ChainElement Pointer )
            value.Roots                                     = GetObject<X509Certificate2Collection>(new IntPtr(p + 0x050), ReversePrism.DataModels.X509Certificate2Collection.FromPointer); // 0x50 Roots                       ( ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer )
            value.Cas                                       = GetObject<X509Certificate2Collection>(new IntPtr(p + 0x058), ReversePrism.DataModels.X509Certificate2Collection.FromPointer); // 0x58 Cas                         ( ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer )
            value.Root_store                                = GetObject<X509Store>(new IntPtr(p + 0x060), ReversePrism.DataModels.X509Store.FromPointer); // 0x60 Root_store                  ( ModelClassType X509Store X509Store X509Store Pointer )
            value.Ca_store                                  = GetObject<X509Store>(new IntPtr(p + 0x068), ReversePrism.DataModels.X509Store.FromPointer); // 0x68 Ca_store                    ( ModelClassType X509Store X509Store X509Store Pointer )
            value.User_root_store                           = GetObject<X509Store>(new IntPtr(p + 0x070), ReversePrism.DataModels.X509Store.FromPointer); // 0x70 User_root_store             ( ModelClassType X509Store X509Store X509Store Pointer )
            value.User_ca_store                             = GetObject<X509Store>(new IntPtr(p + 0x078), ReversePrism.DataModels.X509Store.FromPointer); // 0x78 User_ca_store               ( ModelClassType X509Store X509Store X509Store Pointer )
            value.Collection                                = GetObject<X509Certificate2Collection>(new IntPtr(p + 0x080), ReversePrism.DataModels.X509Certificate2Collection.FromPointer); // 0x80 Collection                  ( ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer )

            return value;
        }
    }
}
