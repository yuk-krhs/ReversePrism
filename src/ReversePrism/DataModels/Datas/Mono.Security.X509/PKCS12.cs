using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Password                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 KeyBags                                  ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 SecretBags                               ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 Certs                                    ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 030 KeyBagsChanged                           ModelPrimitiveType bool bool bool Bool
    // 031 SecretBagsChanged                        ModelPrimitiveType bool bool bool Bool
    // 032 CertsChanged                             ModelPrimitiveType bool bool bool Bool
    // 034 Iterations                               ModelPrimitiveType int int int Int32
    // 038 SafeBags                                 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 040 Rng                                      ModelClassType RandomNumberGenerator RandomNumberGenerator RandomNumberGenerator Pointer
    // 000 password_max_length                      int IL2CPP_TYPE_I4
    public partial class PKCS12 : DataModel
    {
        public List<sbyte>?                             Password                                { get; set; }
        public ArrayList?                               KeyBags                                 { get; set; }
        public ArrayList?                               SecretBags                              { get; set; }
        public X509CertificateCollection?               Certs                                   { get; set; }
        public bool                                     KeyBagsChanged                          { get; set; }
        public bool                                     SecretBagsChanged                       { get; set; }
        public bool                                     CertsChanged                            { get; set; }
        public int                                      Iterations                              { get; set; }
        public ArrayList?                               SafeBags                                { get; set; }
        public RandomNumberGenerator?                   Rng                                     { get; set; }

        public static PKCS12? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PKCS12() { Pointer= p0 };

            value.Password                                  = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Password                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.KeyBags                                   = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0x18 KeyBags                     ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.SecretBags                                = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 0x20 SecretBags                  ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Certs                                     = GetObject<X509CertificateCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0x28 Certs                       ( ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.KeyBagsChanged                            = GetBool(new IntPtr(p + 0x030)); // 0x30 KeyBagsChanged              ( ModelPrimitiveType bool bool bool Bool )
            value.SecretBagsChanged                         = GetBool(new IntPtr(p + 0x031)); // 0x31 SecretBagsChanged           ( ModelPrimitiveType bool bool bool Bool )
            value.CertsChanged                              = GetBool(new IntPtr(p + 0x032)); // 0x32 CertsChanged                ( ModelPrimitiveType bool bool bool Bool )
            value.Iterations                                = GetInt32(new IntPtr(p + 0x034)); // 0x34 Iterations                  ( ModelPrimitiveType int int int Int32 )
            value.SafeBags                                  = GetObject<ArrayList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ArrayList.FromPointer); // 0x38 SafeBags                    ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Rng                                       = GetObject<RandomNumberGenerator>(new IntPtr(p + 0x040), ReversePrism.DataModels.RandomNumberGenerator.FromPointer); // 0x40 Rng                         ( ModelClassType RandomNumberGenerator RandomNumberGenerator RandomNumberGenerator Pointer )

            return value;
        }
    }
}
