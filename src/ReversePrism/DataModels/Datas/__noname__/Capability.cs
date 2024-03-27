using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Path                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Value                                    0001866722E0 ModelPrimitiveType string string string String
    public partial class Capability
    {
        public string                                   Path                                    { get; set; }
        public string                                   Value                                   { get; set; }

        public static Capability? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Capability();

            value.Path                                      = GetString(new IntPtr(p + 0x010)); // 0270033CA8B0 0x10 Path                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 0270033CA8D0 0x18 Value                       ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
