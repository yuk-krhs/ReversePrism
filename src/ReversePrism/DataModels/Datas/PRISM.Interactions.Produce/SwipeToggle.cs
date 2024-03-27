using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MinSwipeDistance                         0001866656B0 ModelPrimitiveType float float float Single
    // 024 StartTouchPosition                       0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 02C EndTouchPosition                         0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 038 onSwipeSubject                           Subject`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class SwipeToggle
    {
        public float                                    MinSwipeDistance                        { get; set; }
        public Vector2                                  StartTouchPosition                      { get; set; }
        public Vector2                                  EndTouchPosition                        { get; set; }

        public static SwipeToggle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwipeToggle();

            value.MinSwipeDistance                          = GetSingle(new IntPtr(p + 0x020)); // 0270DA1485F0 0x20 MinSwipeDistance            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.StartTouchPosition                        = (Vector2)GetInt32(new IntPtr(p + 0x024)); // 0270DA148610 0x24 StartTouchPosition          ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.EndTouchPosition                          = (Vector2)GetInt32(new IntPtr(p + 0x02C)); // 0270DA148630 0x2C EndTouchPosition            ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
