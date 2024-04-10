using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _userPath                                string IL2CPP_TYPE_STRING
    // 008 _localMachinePath                        string IL2CPP_TYPE_STRING
    // 010 NewUserPath                              000186672530 ModelPrimitiveType string string string String
    // 018 NewLocalMachinePath                      000186672530 ModelPrimitiveType string string string String
    // 020 UserStore                                000186570800 ModelClassType X509Stores X509Stores X509Stores Pointer
    // 028 MachineStore                             000186570800 ModelClassType X509Stores X509Stores X509Stores Pointer
    public partial class X509StoreManager : DataModel
    {
        public string                                   NewUserPath                             { get; set; }
        public string                                   NewLocalMachinePath                     { get; set; }
        public X509Stores?                              UserStore                               { get; set; }
        public X509Stores?                              MachineStore                            { get; set; }

        public static X509StoreManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509StoreManager() { Pointer= p0 };

            value.NewUserPath                               = GetString(new IntPtr(p + 0x010)); // 02466B40B0F0 0x10 NewUserPath                 ( 000186672530 ModelPrimitiveType string string string String )
            value.NewLocalMachinePath                       = GetString(new IntPtr(p + 0x018)); // 02466B40B110 0x18 NewLocalMachinePath         ( 000186672530 ModelPrimitiveType string string string String )
            value.UserStore                                 = GetObject<X509Stores>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509Stores.FromPointer); // 02466B40B130 0x20 UserStore                   ( 000186570800 ModelClassType X509Stores X509Stores X509Stores Pointer )
            value.MachineStore                              = GetObject<X509Stores>(new IntPtr(p + 0x028), ReversePrism.DataModels.X509Stores.FromPointer); // 02466B40B150 0x28 MachineStore                ( 000186570800 ModelClassType X509Stores X509Stores X509Stores Pointer )

            return value;
        }
    }
}
