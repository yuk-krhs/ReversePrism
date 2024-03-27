using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CursorPos                                0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 CharWidth                                000186666050 ModelPrimitiveType float float float Single
    public partial class UICharInfo
    {
        public Vector2                                  CursorPos                               { get; set; }
        public float                                    CharWidth                               { get; set; }

        public static UICharInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UICharInfo();

            value.CursorPos                                 = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 02700217FDF0 0x10 CursorPos                   ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.CharWidth                                 = GetSingle(new IntPtr(p + 0x018)); // 02700217FE10 0x18 CharWidth                   ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
