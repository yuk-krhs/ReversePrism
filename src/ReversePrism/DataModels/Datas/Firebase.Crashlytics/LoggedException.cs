using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Name                                     ModelPrimitiveType string string string String
    // 098 CustomStackTrace                         ModelPrimitiveType string string string String
    // 0A0 <ParsedStackTrace>k__BackingField        Dictionary`2<string, string>[] IL2CPP_TYPE_SZARRAY
    public partial class LoggedException : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   CustomStackTrace                        { get; set; }

        public static LoggedException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoggedException() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x090)); // 0x90 Name                        ( ModelPrimitiveType string string string String )
            value.CustomStackTrace                          = GetString(new IntPtr(p + 0x098)); // 0x98 CustomStackTrace            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
