using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 Delta                                    0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 Tilt                                     0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 Pressure                                 000186666050 ModelPrimitiveType float float float Single
    // 02C Twist                                    000186666050 ModelPrimitiveType float float float Single
    // 030 Buttons                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 032 DisplayIndex                             000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class PenState
    {
        public Vector2                                  Position                                { get; set; }
        public Vector2                                  Delta                                   { get; set; }
        public Vector2                                  Tilt                                    { get; set; }
        public float                                    Pressure                                { get; set; }
        public float                                    Twist                                   { get; set; }
        public ushort                                   Buttons                                 { get; set; }
        public ushort                                   DisplayIndex                            { get; set; }

        public static PenState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PenState();

            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0270D77FE320 0x10 Position                    ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Delta                                     = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0270D77FE340 0x18 Delta                       ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Tilt                                      = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0270D77FE360 0x20 Tilt                        ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Pressure                                  = GetSingle(new IntPtr(p + 0x028)); // 0270D77FE380 0x28 Pressure                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Twist                                     = GetSingle(new IntPtr(p + 0x02C)); // 0270D77FE3A0 0x2C Twist                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Buttons                                   = GetUInt16(new IntPtr(p + 0x030)); // 0270D77FE3C0 0x30 Buttons                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.DisplayIndex                              = GetUInt16(new IntPtr(p + 0x032)); // 0270D77FE3E0 0x32 DisplayIndex                ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
