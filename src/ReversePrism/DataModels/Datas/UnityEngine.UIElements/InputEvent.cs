using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 PreviousData                             000186671910 ModelPrimitiveType string string string String
    // 090 NewData                                  000186671910 ModelPrimitiveType string string string String
    public partial class InputEvent
    {
        public string                                   PreviousData                            { get; set; }
        public string                                   NewData                                 { get; set; }

        public static InputEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputEvent();

            value.PreviousData                              = GetString(new IntPtr(p + 0x088)); // 02700676E9C8 0x88 PreviousData                ( 000186671910 ModelPrimitiveType string string string String )
            value.NewData                                   = GetString(new IntPtr(p + 0x090)); // 02700676E9E8 0x90 NewData                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
