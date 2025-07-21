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
    // 010 MachinePathExists                        ModelPrimitiveType bool bool bool Bool
    // 018 MachinePath                              ModelPrimitiveType string string string String
    // 010 Params                                   ModelClassType CspParameters CspParameters CspParameters Pointer
    // 018 Keyvalue                                 ModelPrimitiveType string string string String
    // 020 Filename                                 ModelPrimitiveType string string string String
    // 028 Container                                ModelPrimitiveType string string string String
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

            value.MachinePathExists                         = GetBool(new IntPtr(p + 0x010)); // 0x10 MachinePathExists           ( ModelPrimitiveType bool bool bool Bool )
            value.MachinePath                               = GetString(new IntPtr(p + 0x018)); // 0x18 MachinePath                 ( ModelPrimitiveType string string string String )
            value.Params                                    = GetObject<CspParameters>(new IntPtr(p + 0x010), ReversePrism.DataModels.CspParameters.FromPointer); // 0x10 Params                      ( ModelClassType CspParameters CspParameters CspParameters Pointer )
            value.Keyvalue                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Keyvalue                    ( ModelPrimitiveType string string string String )
            value.Filename                                  = GetString(new IntPtr(p + 0x020)); // 0x20 Filename                    ( ModelPrimitiveType string string string String )
            value.Container                                 = GetString(new IntPtr(p + 0x028)); // 0x28 Container                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
