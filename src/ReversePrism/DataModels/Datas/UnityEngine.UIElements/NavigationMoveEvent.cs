using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Direction                                00018650AC90 ModelEnumType Direction Direction Direction Int32
    // 094 Move                                     0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class NavigationMoveEvent : DataModel
    {
        public Direction                                Direction                               { get; set; }
        public Vector2                                  Move                                    { get; set; }

        public static NavigationMoveEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NavigationMoveEvent() { Pointer= p0 };

            value.Direction                                 = (Direction)GetInt32(new IntPtr(p + 0x090)); // 0245A6765DE0 0x90 Direction                   ( 00018650AC90 ModelEnumType Direction Direction Direction Int32 )
            value.Move                                      = (Vector2)GetInt32(new IntPtr(p + 0x094)); // 0245A6765E00 0x94 Move                        ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
