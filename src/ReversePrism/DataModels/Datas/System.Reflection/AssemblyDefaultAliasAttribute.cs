using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DefaultAlias                             000186672F10 ModelPrimitiveType string string string String
    public partial class AssemblyDefaultAliasAttribute
    {
        public string                                   DefaultAlias                            { get; set; }

        public static AssemblyDefaultAliasAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyDefaultAliasAttribute();

            value.DefaultAlias                              = GetString(new IntPtr(p + 0x010)); // 0270D6CE88D8 0x10 DefaultAlias                ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
