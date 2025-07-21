using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OpenId                                   ModelPrimitiveType string string string String
    // 018 AccessToken                              ModelPrimitiveType string string string String
    public partial class UserKey : DataModel
    {
        public string                                   OpenId                                  { get; set; }
        public string                                   AccessToken                             { get; set; }

        public static UserKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserKey() { Pointer= p0 };

            value.OpenId                                    = GetString(new IntPtr(p + 0x010)); // 0x10 OpenId                      ( ModelPrimitiveType string string string String )
            value.AccessToken                               = GetString(new IntPtr(p + 0x018)); // 0x18 AccessToken                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
