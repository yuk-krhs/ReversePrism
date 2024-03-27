using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     00018660A650 ModelEnumType ConsoleSpecialKey ConsoleSpecialKey ConsoleSpecialKey Int32
    // 014 Cancel                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ConsoleCancelEventArgs
    {
        public ConsoleSpecialKey                        Type                                    { get; set; }
        public bool                                     Cancel                                  { get; set; }

        public static ConsoleCancelEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConsoleCancelEventArgs();

            value.Type                                      = (ConsoleSpecialKey)GetInt32(new IntPtr(p + 0x010)); // 0270D6A32AC0 0x10 Type                        ( 00018660A650 ModelEnumType ConsoleSpecialKey ConsoleSpecialKey ConsoleSpecialKey Int32 )
            value.Cancel                                    = GetBool(new IntPtr(p + 0x014)); // 0270D6A32AE0 0x14 Cancel                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
