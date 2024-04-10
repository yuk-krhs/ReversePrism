using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 defaultInstance                          UserAgentStringProvider IL2CPP_TYPE_CLASS
    // 010 UserAgentString                          000186672F10 ModelPrimitiveType string string string String
    public partial class UserAgentStringProvider : DataModel
    {
        public string                                   UserAgentString                         { get; set; }

        public static UserAgentStringProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserAgentStringProvider() { Pointer= p0 };

            value.UserAgentString                           = GetString(new IntPtr(p + 0x010)); // 0245A40C5B30 0x10 UserAgentString             ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
