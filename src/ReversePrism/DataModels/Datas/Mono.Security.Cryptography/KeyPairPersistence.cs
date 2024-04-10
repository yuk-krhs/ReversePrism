using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _userPathExists                          bool IL2CPP_TYPE_BOOLEAN
    // 008 _userPath                                string IL2CPP_TYPE_STRING
    // 010 MachinePathExists                        000186595C30 ModelPrimitiveType bool bool bool Bool
    // 018 MachinePath                              000186672530 ModelPrimitiveType string string string String
    // 010 Params                                   000186660E70 ModelClassType CspParameters CspParameters CspParameters Pointer
    // 018 Keyvalue                                 000186671910 ModelPrimitiveType string string string String
    // 020 Filename                                 000186671910 ModelPrimitiveType string string string String
    // 028 Container                                000186671910 ModelPrimitiveType string string string String
    // 020 lockobj                                  <object> IL2CPP_TYPE_OBJECT
    public partial class KeyPairPersistence : DataModel
    {
        public bool                                     MachinePathExists                       { get; set; }
        public string                                   MachinePath                             { get; set; }
        public CspParameters?                           Params                                  { get; set; }
        public string                                   Keyvalue                                { get; set; }
        public string                                   Filename                                { get; set; }
        public string                                   Container                               { get; set; }

        public static KeyPairPersistence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyPairPersistence() { Pointer= p0 };

            value.MachinePathExists                         = GetBool(new IntPtr(p + 0x010)); // 0246669ACBD8 0x10 MachinePathExists           ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.MachinePath                               = GetString(new IntPtr(p + 0x018)); // 0246669ACBF8 0x18 MachinePath                 ( 000186672530 ModelPrimitiveType string string string String )
            value.Params                                    = GetObject<CspParameters>(new IntPtr(p + 0x010), ReversePrism.DataModels.CspParameters.FromPointer); // 0246669ACC18 0x10 Params                      ( 000186660E70 ModelClassType CspParameters CspParameters CspParameters Pointer )
            value.Keyvalue                                  = GetString(new IntPtr(p + 0x018)); // 0246669ACC38 0x18 Keyvalue                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Filename                                  = GetString(new IntPtr(p + 0x020)); // 0246669ACC58 0x20 Filename                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Container                                 = GetString(new IntPtr(p + 0x028)); // 0246669ACC78 0x28 Container                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
