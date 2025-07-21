using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buttons                                  ModelPrimitiveType int int int Int32
    // 014 Stick                                    ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class JoystickState : DataModel
    {
        public int                                      Buttons                                 { get; set; }
        public Vector2                                  Stick                                   { get; set; }

        public static JoystickState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JoystickState() { Pointer= p0 };

            value.Buttons                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 Buttons                     ( ModelPrimitiveType int int int Int32 )
            value.Stick                                     = (Vector2)GetInt32(new IntPtr(p + 0x014)); // 0x14 Stick                       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
