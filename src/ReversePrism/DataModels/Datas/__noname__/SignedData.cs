using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 HashAlgorithm                            000186671910 ModelPrimitiveType string string string String
    // 020 ContentInfo                              00018655A0C0 ModelClassType ContentInfo ContentInfo ContentInfo Pointer
    // 028 Certs                                    0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 030 Crls                                     00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 038 SignerInfo                               00018655AAE0 ModelClassType SignerInfo SignerInfo SignerInfo Pointer
    // 040 Mda                                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SignedData : DataModel
    {
        public sbyte                                    Version                                 { get; set; }
        public string                                   HashAlgorithm                           { get; set; }
        public ContentInfo?                             ContentInfo                             { get; set; }
        public X509CertificateCollection?               Certs                                   { get; set; }
        public ArrayList?                               Crls                                    { get; set; }
        public SignerInfo?                              SignerInfo                              { get; set; }
        public bool                                     Mda                                     { get; set; }

        public static SignedData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SignedData() { Pointer= p0 };

            value.Version                                   = GetSByte(new IntPtr(p + 0x010)); // 02466B406CD0 0x10 Version                     ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.HashAlgorithm                             = GetString(new IntPtr(p + 0x018)); // 02466B406CF0 0x18 HashAlgorithm               ( 000186671910 ModelPrimitiveType string string string String )
            value.ContentInfo                               = GetObject<ContentInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.ContentInfo.FromPointer); // 02466B406D10 0x20 ContentInfo                 ( 00018655A0C0 ModelClassType ContentInfo ContentInfo ContentInfo Pointer )
            value.Certs                                     = GetObject<X509CertificateCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 02466B406D30 0x28 Certs                       ( 0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.Crls                                      = GetObject<ArrayList>(new IntPtr(p + 0x030), ReversePrism.DataModels.ArrayList.FromPointer); // 02466B406D50 0x30 Crls                        ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.SignerInfo                                = GetObject<SignerInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.SignerInfo.FromPointer); // 02466B406D70 0x38 SignerInfo                  ( 00018655AAE0 ModelClassType SignerInfo SignerInfo SignerInfo Pointer )
            value.Mda                                       = GetBool(new IntPtr(p + 0x040)); // 02466B406D90 0x40 Mda                         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
