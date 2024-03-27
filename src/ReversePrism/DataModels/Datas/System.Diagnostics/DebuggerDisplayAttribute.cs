using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Value                                    000186671910 ModelPrimitiveType string string string String
    // 020 Type                                     000186671910 ModelPrimitiveType string string string String
    public partial class DebuggerDisplayAttribute
    {
        public string                                   Name                                    { get; set; }
        public string                                   Value                                   { get; set; }
        public string                                   Type                                    { get; set; }

        public static DebuggerDisplayAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebuggerDisplayAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270066A8138 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 0270066A8158 0x18 Value                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x020)); // 0270066A8178 0x20 Type                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
