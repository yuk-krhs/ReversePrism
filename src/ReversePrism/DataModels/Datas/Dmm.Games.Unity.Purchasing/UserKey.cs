using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OpenId                                   000186671910 ModelPrimitiveType string string string String
    // 018 AccessToken                              000186671910 ModelPrimitiveType string string string String
    public partial class UserKey
    {
        public string                                   OpenId                                  { get; set; }
        public string                                   AccessToken                             { get; set; }

        public static UserKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserKey();

            value.OpenId                                    = GetString(new IntPtr(p + 0x010)); // 027004BB5F08 0x10 OpenId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.AccessToken                               = GetString(new IntPtr(p + 0x018)); // 027004BB5F28 0x18 AccessToken                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
