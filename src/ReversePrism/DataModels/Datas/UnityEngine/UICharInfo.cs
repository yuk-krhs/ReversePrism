using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CursorPos                                ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 CharWidth                                ModelPrimitiveType float float float Single
    public partial class UICharInfo : DataModel
    {
        public Vector2                                  CursorPos                               { get; set; }
        public float                                    CharWidth                               { get; set; }

        public static UICharInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UICharInfo() { Pointer= p0 };

            value.CursorPos                                 = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 CursorPos                   ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.CharWidth                                 = GetSingle(new IntPtr(p + 0x018)); // 0x18 CharWidth                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
