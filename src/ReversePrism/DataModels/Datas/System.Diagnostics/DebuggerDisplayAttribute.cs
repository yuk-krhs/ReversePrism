using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Value                                    ModelPrimitiveType string string string String
    // 020 Type                                     ModelPrimitiveType string string string String
    public partial class DebuggerDisplayAttribute : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Value                                   { get; set; }
        public string                                   Type                                    { get; set; }

        public static DebuggerDisplayAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebuggerDisplayAttribute() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Value                       ( ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Type                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
