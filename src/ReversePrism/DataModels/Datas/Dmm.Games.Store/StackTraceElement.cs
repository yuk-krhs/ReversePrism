using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Class                                    ModelPrimitiveType string string string String
    // 018 File                                     ModelPrimitiveType string string string String
    // 020 Method                                   ModelPrimitiveType string string string String
    // 028 Line                                     ModelPrimitiveType int int int Int32
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

            value.Class                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Class                       ( ModelPrimitiveType string string string String )
            value.File                                      = GetString(new IntPtr(p + 0x018)); // 0x18 File                        ( ModelPrimitiveType string string string String )
            value.Method                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Method                      ( ModelPrimitiveType string string string String )
            value.Line                                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 Line                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
