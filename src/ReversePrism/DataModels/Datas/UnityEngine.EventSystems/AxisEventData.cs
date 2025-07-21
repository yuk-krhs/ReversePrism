using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MoveVector                               ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 MoveDir                                  ModelEnumType MoveDirection MoveDirection MoveDirection Int32
    public partial class AxisEventData : DataModel
    {
        public Vector2                                  MoveVector                              { get; set; }
        public MoveDirection                            MoveDir                                 { get; set; }

        public static AxisEventData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AxisEventData() { Pointer= p0 };

            value.MoveVector                                = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0x20 MoveVector                  ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.MoveDir                                   = (MoveDirection)GetInt32(new IntPtr(p + 0x028)); // 0x28 MoveDir                     ( ModelEnumType MoveDirection MoveDirection MoveDirection Int32 )

            return value;
        }
    }
}
