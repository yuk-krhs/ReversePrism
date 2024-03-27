using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ButtonSouthShortDisplayName              string IL2CPP_TYPE_STRING
    // 000 ButtonNorthShortDisplayName              string IL2CPP_TYPE_STRING
    // 000 ButtonWestShortDisplayName               string IL2CPP_TYPE_STRING
    // 000 ButtonEastShortDisplayName               string IL2CPP_TYPE_STRING
    // 010 Buttons                                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 LeftStick                                0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 01C RightStick                               0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 024 LeftTrigger                              000186666050 ModelPrimitiveType float float float Single
    // 028 RightTrigger                             000186666050 ModelPrimitiveType float float float Single
    public partial class GamepadState
    {
        public uint                                     Buttons                                 { get; set; }
        public Vector2                                  LeftStick                               { get; set; }
        public Vector2                                  RightStick                              { get; set; }
        public float                                    LeftTrigger                             { get; set; }
        public float                                    RightTrigger                            { get; set; }

        public static GamepadState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GamepadState();

            value.Buttons                                   = GetUInt32(new IntPtr(p + 0x010)); // 0270D77FD560 0x10 Buttons                     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.LeftStick                                 = (Vector2)GetInt32(new IntPtr(p + 0x014)); // 0270D77FD580 0x14 LeftStick                   ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.RightStick                                = (Vector2)GetInt32(new IntPtr(p + 0x01C)); // 0270D77FD5A0 0x1C RightStick                  ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.LeftTrigger                               = GetSingle(new IntPtr(p + 0x024)); // 0270D77FD5C0 0x24 LeftTrigger                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.RightTrigger                              = GetSingle(new IntPtr(p + 0x028)); // 0270D77FD5E0 0x28 RightTrigger                ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
