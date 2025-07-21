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
    // 010 Buttons                                  ModelPrimitiveType uint uint uint UInt32
    // 014 LeftStick                                ModelEnumType Vector2 Vector2 Vector2 Int32
    // 01C RightStick                               ModelEnumType Vector2 Vector2 Vector2 Int32
    // 024 LeftTrigger                              ModelPrimitiveType float float float Single
    // 028 RightTrigger                             ModelPrimitiveType float float float Single
    public partial class GamepadState : DataModel
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
            var value   = new GamepadState() { Pointer= p0 };

            value.Buttons                                   = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Buttons                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.LeftStick                                 = (Vector2)GetInt32(new IntPtr(p + 0x014)); // 0x14 LeftStick                   ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.RightStick                                = (Vector2)GetInt32(new IntPtr(p + 0x01C)); // 0x1C RightStick                  ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.LeftTrigger                               = GetSingle(new IntPtr(p + 0x024)); // 0x24 LeftTrigger                 ( ModelPrimitiveType float float float Single )
            value.RightTrigger                              = GetSingle(new IntPtr(p + 0x028)); // 0x28 RightTrigger                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
