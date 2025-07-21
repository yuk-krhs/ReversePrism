using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Elements                                 ModelClassType X509ChainElementCollection X509ChainElementCollection X509ChainElementCollection Pointer
    // 018 NativeCertificateChain                   ModelEnumType unitytls_x509list_ref unitytls_x509list_ref unitytls_x509list_ref Int32
    // 020 Policy                                   ModelClassType X509ChainPolicy X509ChainPolicy X509ChainPolicy Pointer
    // 028 ChainStatusList                          ModelEnumListType List`1<X509ChainStatus> List`1<X509ChainStatus> List<X509ChainStatus> Pointer
    // 030 ReverseOrder                             ModelPrimitiveType bool bool bool Bool
    public partial class X509ChainImplUnityTls : DataModel
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
            var value   = new X509ChainImplUnityTls() { Pointer= p0 };

            value.Elements                                  = GetObject<X509ChainElementCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.X509ChainElementCollection.FromPointer); // 0x10 Elements                    ( ModelClassType X509ChainElementCollection X509ChainElementCollection X509ChainElementCollection Pointer )
            value.NativeCertificateChain                    = (unitytls_x509list_ref)GetInt32(new IntPtr(p + 0x018)); // 0x18 NativeCertificateChain      ( ModelEnumType unitytls_x509list_ref unitytls_x509list_ref unitytls_x509list_ref Int32 )
            value.Policy                                    = GetObject<X509ChainPolicy>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509ChainPolicy.FromPointer); // 0x20 Policy                      ( ModelClassType X509ChainPolicy X509ChainPolicy X509ChainPolicy Pointer )
            value.ChainStatusList                           = GetEnumList<X509ChainStatus>(new IntPtr(p + 0x028)); // 0x28 ChainStatusList             ( ModelEnumListType List`1<X509ChainStatus> List`1<X509ChainStatus> List<X509ChainStatus> Pointer )
            value.ReverseOrder                              = GetBool(new IntPtr(p + 0x030)); // 0x30 ReverseOrder                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
