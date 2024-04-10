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
    public partial class InputEvent : DataModel
    {
        public string                                   PreviousData                            { get; set; }
        public string                                   NewData                                 { get; set; }

        public static InputEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputEvent() { Pointer= p0 };

            value.PreviousData                              = GetString(new IntPtr(p + 0x088)); // 0245A67309A8 0x88 PreviousData                ( 000186671910 ModelPrimitiveType string string string String )
            value.NewData                                   = GetString(new IntPtr(p + 0x090)); // 0245A67309C8 0x90 NewData                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
