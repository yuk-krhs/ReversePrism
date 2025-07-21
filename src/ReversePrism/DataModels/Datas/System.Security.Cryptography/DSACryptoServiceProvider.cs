using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Store                                    ModelClassType KeyPairPersistence KeyPairPersistence KeyPairPersistence Pointer
    // 028 PersistKey                               ModelPrimitiveType bool bool bool Bool
    // 029 Persisted                                ModelPrimitiveType bool bool bool Bool
    // 02A PrivateKeyExportable                     ModelPrimitiveType bool bool bool Bool
    // 02B M_disposed                               ModelPrimitiveType bool bool bool Bool
    // 030 Dsa                                      ModelClassType DSAManaged DSAManaged DSAManaged Pointer
    // 000 useMachineKeyStore                       bool IL2CPP_TYPE_BOOLEAN
    public partial class DSACryptoServiceProvider : DataModel
    {
        public KeyPairPersistence?                      Store                                   { get; set; }
        public bool                                     PersistKey                              { get; set; }
        public bool                                     Persisted                               { get; set; }
        public bool                                     PrivateKeyExportable                    { get; set; }
        public bool                                     M_disposed                              { get; set; }
        public DSAManaged?                              Dsa                                     { get; set; }

        public static DSACryptoServiceProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DSACryptoServiceProvider() { Pointer= p0 };

            value.Store                                     = GetObject<KeyPairPersistence>(new IntPtr(p + 0x020), ReversePrism.DataModels.KeyPairPersistence.FromPointer); // 0x20 Store                       ( ModelClassType KeyPairPersistence KeyPairPersistence KeyPairPersistence Pointer )
            value.PersistKey                                = GetBool(new IntPtr(p + 0x028)); // 0x28 PersistKey                  ( ModelPrimitiveType bool bool bool Bool )
            value.Persisted                                 = GetBool(new IntPtr(p + 0x029)); // 0x29 Persisted                   ( ModelPrimitiveType bool bool bool Bool )
            value.PrivateKeyExportable                      = GetBool(new IntPtr(p + 0x02A)); // 0x2A PrivateKeyExportable        ( ModelPrimitiveType bool bool bool Bool )
            value.M_disposed                                = GetBool(new IntPtr(p + 0x02B)); // 0x2B M_disposed                  ( ModelPrimitiveType bool bool bool Bool )
            value.Dsa                                       = GetObject<DSAManaged>(new IntPtr(p + 0x030), ReversePrism.DataModels.DSAManaged.FromPointer); // 0x30 Dsa                         ( ModelClassType DSAManaged DSAManaged DSAManaged Pointer )

            return value;
        }
    }
}
