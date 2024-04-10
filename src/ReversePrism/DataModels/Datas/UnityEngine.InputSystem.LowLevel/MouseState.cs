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
    // 020 Scroll                                   0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 Buttons                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 02A DisplayIndex                             000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 02C ClickCount                               000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class MouseState : DataModel
    {
        public Vector2                                  Position                                { get; set; }
        public Vector2                                  Delta                                   { get; set; }
        public Vector2                                  Scroll                                  { get; set; }
        public ushort                                   Buttons                                 { get; set; }
        public ushort                                   DisplayIndex                            { get; set; }
        public ushort                                   ClickCount                              { get; set; }

        public static MouseState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MouseState() { Pointer= p0 };

            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0245A3F4BEE8 0x10 Position                    ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Delta                                     = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0245A3F4BF08 0x18 Delta                       ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Scroll                                    = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0245A3F4BF28 0x20 Scroll                      ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Buttons                                   = GetUInt16(new IntPtr(p + 0x028)); // 0245A3F4BF48 0x28 Buttons                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.DisplayIndex                              = GetUInt16(new IntPtr(p + 0x02A)); // 0245A3F4BF68 0x2A DisplayIndex                ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.ClickCount                                = GetUInt16(new IntPtr(p + 0x02C)); // 0245A3F4BF88 0x2C ClickCount                  ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
