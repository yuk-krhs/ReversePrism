using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InformationalVersion                     000186672F10 ModelPrimitiveType string string string String
    public partial class AssemblyInformationalVersionAttribute
    {
        public string                                   InformationalVersion                    { get; set; }

        public static AssemblyInformationalVersionAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyInformationalVersionAttribute();

            value.InformationalVersion                      = GetString(new IntPtr(p + 0x010)); // 0270D6CE8AF8 0x10 InformationalVersion        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
