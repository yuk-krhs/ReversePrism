using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 match                                    char IL2CPP_TYPE_CHAR
    // 018 Replacement                              000186671BA0 ModelPrimitiveType string string string String
    public partial class Map
    {
        public string                                   Replacement                             { get; set; }

        public static Map? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Map();

            value.Replacement                               = GetString(new IntPtr(p + 0x018)); // 0270D75273E8 0x18 Replacement                 ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
