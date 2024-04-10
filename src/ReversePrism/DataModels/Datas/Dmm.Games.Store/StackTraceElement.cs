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
    public partial class StackTraceElement : DataModel
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
            var value   = new StackTraceElement() { Pointer= p0 };

            value.Class                                     = GetString(new IntPtr(p + 0x010)); // 02466B5336E0 0x10 Class                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.File                                      = GetString(new IntPtr(p + 0x018)); // 02466B533700 0x18 File                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Method                                    = GetString(new IntPtr(p + 0x020)); // 02466B533720 0x20 Method                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Line                                      = GetInt32(new IntPtr(p + 0x028)); // 02466B533740 0x28 Line                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
