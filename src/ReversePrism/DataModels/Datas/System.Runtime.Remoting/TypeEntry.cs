using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Assembly_name                            000186671910 ModelPrimitiveType string string string String
    // 018 Type_name                                000186671910 ModelPrimitiveType string string string String
    public partial class TypeEntry
    {
        public string                                   Assembly_name                           { get; set; }
        public string                                   Type_name                               { get; set; }

        public static TypeEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeEntry();

            value.Assembly_name                             = GetString(new IntPtr(p + 0x010)); // 0270D6BB25A8 0x10 Assembly_name               ( 000186671910 ModelPrimitiveType string string string String )
            value.Type_name                                 = GetString(new IntPtr(p + 0x018)); // 0270D6BB25C8 0x18 Type_name                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
