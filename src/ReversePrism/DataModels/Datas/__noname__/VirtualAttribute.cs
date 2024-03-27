using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671BA0 ModelPrimitiveType string string string String
    // 018 Value                                    000186671BA0 ModelPrimitiveType string string string String
    public partial class VirtualAttribute
    {
        public string                                   Name                                    { get; set; }
        public string                                   Value                                   { get; set; }

        public static VirtualAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VirtualAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D7455650 0x10 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 0270D7455670 0x18 Value                       ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
