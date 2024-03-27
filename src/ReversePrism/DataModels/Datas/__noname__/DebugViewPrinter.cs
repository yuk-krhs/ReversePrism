using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Interpreter                              000186721AE0 ModelClassType Interpreter Interpreter Interpreter Pointer
    // 018 _tryStart                                Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 020 _handlerEnter                            Dictionary`2<int, string> IL2CPP_TYPE_GENERICINST
    // 028 _handlerExit                             Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 030 Indent                                   000186671910 ModelPrimitiveType string string string String
    public partial class DebugViewPrinter
    {
        public Interpreter?                             Interpreter                             { get; set; }
        public string                                   Indent                                  { get; set; }

        public static DebugViewPrinter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugViewPrinter();

            value.Interpreter                               = GetObject<Interpreter>(new IntPtr(p + 0x010), ReversePrism.DataModels.Interpreter.FromPointer); // 0270DA00D440 0x10 Interpreter                 ( 000186721AE0 ModelClassType Interpreter Interpreter Interpreter Pointer )
            value.Indent                                    = GetString(new IntPtr(p + 0x030)); // 0270DA00D4C0 0x30 Indent                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
