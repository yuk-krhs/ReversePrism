using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PeerIdentityPropertyName                 000186671910 ModelPrimitiveType string string string String
    // 018 properties                               Dictionary`2<string, List`1<AuthProperty>> IL2CPP_TYPE_GENERICINST
    public partial class AuthContext : DataModel
    {
        public string                                   PeerIdentityPropertyName                { get; set; }

        public static AuthContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthContext() { Pointer= p0 };

            value.PeerIdentityPropertyName                  = GetString(new IntPtr(p + 0x010)); // 0246693B4758 0x10 PeerIdentityPropertyName    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
