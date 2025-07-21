using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StorePath                                ModelPrimitiveType string string string String
    // 018 Certificates                             ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 020 Crls                                     ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 Crl                                      ModelPrimitiveType bool bool bool Bool
    // 029 NewFormat                                ModelPrimitiveType bool bool bool Bool
    public partial class X509Store : DataModel
    {
        public string                                   StorePath                               { get; set; }
        public X509CertificateCollection?               Certificates                            { get; set; }
        public ArrayList?                               Crls                                    { get; set; }
        public bool                                     Crl                                     { get; set; }
        public bool                                     NewFormat                               { get; set; }

        public static X509Store? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Store() { Pointer= p0 };

            value.StorePath                                 = GetString(new IntPtr(p + 0x010)); // 0x10 StorePath                   ( ModelPrimitiveType string string string String )
            value.Certificates                              = GetObject<X509CertificateCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0x18 Certificates                ( ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.Crls                                      = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 0x20 Crls                        ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Crl                                       = GetBool(new IntPtr(p + 0x028)); // 0x28 Crl                         ( ModelPrimitiveType bool bool bool Bool )
            value.NewFormat                                 = GetBool(new IntPtr(p + 0x029)); // 0x29 NewFormat                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
