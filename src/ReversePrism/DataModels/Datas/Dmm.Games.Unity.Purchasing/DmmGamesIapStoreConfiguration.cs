using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ApiToken                                 0001866736C0 ModelPrimitiveType string string string String
    // 018 OpenId                                   0001866736C0 ModelPrimitiveType string string string String
    // 020 AccessToken                              0001866736C0 ModelPrimitiveType string string string String
    // 028 IsSandbox                                000186596AF0 ModelPrimitiveType bool bool bool Bool
    public partial class DmmGamesIapStoreConfiguration : DataModel
    {
        public string                                   ApiToken                                { get; set; }
        public string                                   OpenId                                  { get; set; }
        public string                                   AccessToken                             { get; set; }
        public bool                                     IsSandbox                               { get; set; }

        public static DmmGamesIapStoreConfiguration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesIapStoreConfiguration() { Pointer= p0 };

            value.ApiToken                                  = GetString(new IntPtr(p + 0x010)); // 02466302CFE0 0x10 ApiToken                    ( 0001866736C0 ModelPrimitiveType string string string String )
            value.OpenId                                    = GetString(new IntPtr(p + 0x018)); // 02466302D000 0x18 OpenId                      ( 0001866736C0 ModelPrimitiveType string string string String )
            value.AccessToken                               = GetString(new IntPtr(p + 0x020)); // 02466302D020 0x20 AccessToken                 ( 0001866736C0 ModelPrimitiveType string string string String )
            value.IsSandbox                                 = GetBool(new IntPtr(p + 0x028)); // 02466302D040 0x28 IsSandbox                   ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
