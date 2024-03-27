using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Password                                 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 KeyBags                                  00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 SecretBags                               00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 Certs                                    0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 030 KeyBagsChanged                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 SecretBagsChanged                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 CertsChanged                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 Iterations                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 SafeBags                                 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 040 Rng                                      00018660A680 ModelClassType RandomNumberGenerator RandomNumberGenerator RandomNumberGenerator Pointer
    // 000 password_max_length                      int IL2CPP_TYPE_I4
    public partial class PKCS12
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
            var value   = new PKCS12();

            value.Password                                  = GetSByteList(new IntPtr(p + 0x010)); // 0270DB37A4D8 0x10 Password                    ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.KeyBags                                   = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0270DB37A4F8 0x18 KeyBags                     ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.SecretBags                                = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 0270DB37A518 0x20 SecretBags                  ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Certs                                     = GetObject<X509CertificateCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0270DB37A538 0x28 Certs                       ( 0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.KeyBagsChanged                            = GetBool(new IntPtr(p + 0x030)); // 0270DB37A558 0x30 KeyBagsChanged              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SecretBagsChanged                         = GetBool(new IntPtr(p + 0x031)); // 0270DB37A578 0x31 SecretBagsChanged           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CertsChanged                              = GetBool(new IntPtr(p + 0x032)); // 0270DB37A598 0x32 CertsChanged                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Iterations                                = GetInt32(new IntPtr(p + 0x034)); // 0270DB37A5B8 0x34 Iterations                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SafeBags                                  = GetObject<ArrayList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ArrayList.FromPointer); // 0270DB37A5D8 0x38 SafeBags                    ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Rng                                       = GetObject<RandomNumberGenerator>(new IntPtr(p + 0x040), ReversePrism.DataModels.RandomNumberGenerator.FromPointer); // 0270DB37A5F8 0x40 Rng                         ( 00018660A680 ModelClassType RandomNumberGenerator RandomNumberGenerator RandomNumberGenerator Pointer )

            return value;
        }
    }
}
