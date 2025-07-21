using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Interpreter                              ModelClassType Interpreter Interpreter Interpreter Pointer
    // 018 _tryStart                                Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 020 _handlerEnter                            Dictionary`2<int, string> IL2CPP_TYPE_GENERICINST
    // 028 _handlerExit                             Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 030 Indent                                   ModelPrimitiveType string string string String
    public partial class DebugViewPrinter : DataModel
    {
        public Interpreter?                             Interpreter                             { get; set; }
        public string                                   Indent                                  { get; set; }

        public static DebugViewPrinter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugViewPrinter() { Pointer= p0 };

            value.Interpreter                               = GetObject<Interpreter>(new IntPtr(p + 0x010), ReversePrism.DataModels.Interpreter.FromPointer); // 0x10 Interpreter                 ( ModelClassType Interpreter Interpreter Interpreter Pointer )
            value.Indent                                    = GetString(new IntPtr(p + 0x030)); // 0x30 Indent                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
