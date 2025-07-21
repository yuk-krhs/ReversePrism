using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 Delta                                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 Scroll                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 Buttons                                  ModelPrimitiveType ushort ushort ushort UInt16
    // 02A DisplayIndex                             ModelPrimitiveType ushort ushort ushort UInt16
    // 02C ClickCount                               ModelPrimitiveType ushort ushort ushort UInt16
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

            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Delta                                     = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0x18 Delta                       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Scroll                                    = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0x20 Scroll                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Buttons                                   = GetUInt16(new IntPtr(p + 0x028)); // 0x28 Buttons                     ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.DisplayIndex                              = GetUInt16(new IntPtr(p + 0x02A)); // 0x2A DisplayIndex                ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.ClickCount                                = GetUInt16(new IntPtr(p + 0x02C)); // 0x2C ClickCount                  ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
