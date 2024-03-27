using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buttons                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Stick                                    0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class JoystickState
    {
        public int                                      Buttons                                 { get; set; }
        public Vector2                                  Stick                                   { get; set; }

        public static JoystickState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JoystickState();

            value.Buttons                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D77FDC68 0x10 Buttons                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Stick                                     = (Vector2)GetInt32(new IntPtr(p + 0x014)); // 0270D77FDC88 0x14 Stick                       ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
