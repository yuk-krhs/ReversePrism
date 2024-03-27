using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Class                                    0001866722E0 ModelPrimitiveType string string string String
    // 018 File                                     0001866722E0 ModelPrimitiveType string string string String
    // 020 Method                                   0001866722E0 ModelPrimitiveType string string string String
    // 028 Line                                     0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class StackTraceElement
    {
        public string                                   Class                                   { get; set; }
        public string                                   File                                    { get; set; }
        public string                                   Method                                  { get; set; }
        public int                                      Line                                    { get; set; }

        public static StackTraceElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackTraceElement();

            value.Class                                     = GetString(new IntPtr(p + 0x010)); // 0270DB49E780 0x10 Class                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.File                                      = GetString(new IntPtr(p + 0x018)); // 0270DB49E7A0 0x18 File                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Method                                    = GetString(new IntPtr(p + 0x020)); // 0270DB49E7C0 0x20 Method                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Line                                      = GetInt32(new IntPtr(p + 0x028)); // 0270DB49E7E0 0x28 Line                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
