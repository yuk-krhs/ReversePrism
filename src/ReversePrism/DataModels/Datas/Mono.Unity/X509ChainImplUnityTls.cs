using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Elements                                 000186567750 ModelClassType X509ChainElementCollection X509ChainElementCollection X509ChainElementCollection Pointer
    // 018 NativeCertificateChain                   0001866B0FA0 ModelEnumType unitytls_x509list_ref unitytls_x509list_ref unitytls_x509list_ref Int32
    // 020 Policy                                   000186568B50 ModelClassType X509ChainPolicy X509ChainPolicy X509ChainPolicy Pointer
    // 028 ChainStatusList                          000185D1D0D8 ModelEnumListType List`1<X509ChainStatus> List`1<X509ChainStatus> List<X509ChainStatus> Pointer
    // 030 ReverseOrder                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class X509ChainImplUnityTls
    {
        public X509ChainElementCollection?              Elements                                { get; set; }
        public unitytls_x509list_ref                    NativeCertificateChain                  { get; set; }
        public X509ChainPolicy?                         Policy                                  { get; set; }
        public List<X509ChainStatus>?                   ChainStatusList                         { get; set; }
        public bool                                     ReverseOrder                            { get; set; }

        public static X509ChainImplUnityTls? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ChainImplUnityTls();

            value.Elements                                  = GetObject<X509ChainElementCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.X509ChainElementCollection.FromPointer); // 0270D78F6850 0x10 Elements                    ( 000186567750 ModelClassType X509ChainElementCollection X509ChainElementCollection X509ChainElementCollection Pointer )
            value.NativeCertificateChain                    = (unitytls_x509list_ref)GetInt32(new IntPtr(p + 0x018)); // 0270D78F6870 0x18 NativeCertificateChain      ( 0001866B0FA0 ModelEnumType unitytls_x509list_ref unitytls_x509list_ref unitytls_x509list_ref Int32 )
            value.Policy                                    = GetObject<X509ChainPolicy>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509ChainPolicy.FromPointer); // 0270D78F6890 0x20 Policy                      ( 000186568B50 ModelClassType X509ChainPolicy X509ChainPolicy X509ChainPolicy Pointer )
            value.ChainStatusList                           = GetEnumList<X509ChainStatus>(new IntPtr(p + 0x028)); // 0270D78F68B0 0x28 ChainStatusList             ( 000185D1D0D8 ModelEnumListType List`1<X509ChainStatus> List`1<X509ChainStatus> List<X509ChainStatus> Pointer )
            value.ReverseOrder                              = GetBool(new IntPtr(p + 0x030)); // 0270D78F68D0 0x30 ReverseOrder                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
