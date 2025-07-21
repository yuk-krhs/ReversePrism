using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Path                                     ModelPrimitiveType string string string String
    // 018 Value                                    ModelPrimitiveType string string string String
    public partial class Capability : DataModel
    {
        public string                                   Path                                    { get; set; }
        public string                                   Value                                   { get; set; }

        public static Capability? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Capability() { Pointer= p0 };

            value.Path                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Path                        ( ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Value                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
