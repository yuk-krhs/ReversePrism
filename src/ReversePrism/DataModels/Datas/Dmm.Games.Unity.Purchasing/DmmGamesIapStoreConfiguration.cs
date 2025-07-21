using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ApiToken                                 ModelPrimitiveType string string string String
    // 018 OpenId                                   ModelPrimitiveType string string string String
    // 020 AccessToken                              ModelPrimitiveType string string string String
    // 028 IsSandbox                                ModelPrimitiveType bool bool bool Bool
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

            value.ApiToken                                  = GetString(new IntPtr(p + 0x010)); // 0x10 ApiToken                    ( ModelPrimitiveType string string string String )
            value.OpenId                                    = GetString(new IntPtr(p + 0x018)); // 0x18 OpenId                      ( ModelPrimitiveType string string string String )
            value.AccessToken                               = GetString(new IntPtr(p + 0x020)); // 0x20 AccessToken                 ( ModelPrimitiveType string string string String )
            value.IsSandbox                                 = GetBool(new IntPtr(p + 0x028)); // 0x28 IsSandbox                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
