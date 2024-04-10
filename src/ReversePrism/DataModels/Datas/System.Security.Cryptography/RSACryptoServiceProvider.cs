using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_UseMachineKeyStore                     CspProviderFlags IL2CPP_TYPE_VALUETYPE
    // 020 Store                                    00018676F280 ModelClassType KeyPairPersistence KeyPairPersistence KeyPairPersistence Pointer
    // 028 PersistKey                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 Persisted                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02A PrivateKeyExportable                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02B M_disposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 Rsa                                      000186604820 ModelClassType RSAManaged RSAManaged RSAManaged Pointer
    public partial class RSACryptoServiceProvider : DataModel
    {
        public KeyPairPersistence?                      Store                                   { get; set; }
        public bool                                     PersistKey                              { get; set; }
        public bool                                     Persisted                               { get; set; }
        public bool                                     PrivateKeyExportable                    { get; set; }
        public bool                                     M_disposed                              { get; set; }
        public RSAManaged?                              Rsa                                     { get; set; }

        public static RSACryptoServiceProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RSACryptoServiceProvider() { Pointer= p0 };

            value.Store                                     = GetObject<KeyPairPersistence>(new IntPtr(p + 0x020), ReversePrism.DataModels.KeyPairPersistence.FromPointer); // 024661931928 0x20 Store                       ( 00018676F280 ModelClassType KeyPairPersistence KeyPairPersistence KeyPairPersistence Pointer )
            value.PersistKey                                = GetBool(new IntPtr(p + 0x028)); // 024661931948 0x28 PersistKey                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Persisted                                 = GetBool(new IntPtr(p + 0x029)); // 024661931968 0x29 Persisted                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PrivateKeyExportable                      = GetBool(new IntPtr(p + 0x02A)); // 024661931988 0x2A PrivateKeyExportable        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_disposed                                = GetBool(new IntPtr(p + 0x02B)); // 0246619319A8 0x2B M_disposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Rsa                                       = GetObject<RSAManaged>(new IntPtr(p + 0x030), ReversePrism.DataModels.RSAManaged.FromPointer); // 0246619319C8 0x30 Rsa                         ( 000186604820 ModelClassType RSAManaged RSAManaged RSAManaged Pointer )

            return value;
        }
    }
}
