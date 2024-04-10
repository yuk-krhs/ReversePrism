using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PointerId                                000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 014 Position                                 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 01C Delta                                    0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 024 Pressure                                 000186666050 ModelPrimitiveType float float float Single
    // 028 Radius                                   0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 Buttons                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 032 DisplayIndex                             000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class PointerState : DataModel
    {
        public uint                                     PointerId                               { get; set; }
        public Vector2                                  Position                                { get; set; }
        public Vector2                                  Delta                                   { get; set; }
        public float                                    Pressure                                { get; set; }
        public Vector2                                  Radius                                  { get; set; }
        public ushort                                   Buttons                                 { get; set; }
        public ushort                                   DisplayIndex                            { get; set; }

        public static PointerState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerState() { Pointer= p0 };

            value.PointerId                                 = GetUInt32(new IntPtr(p + 0x010)); // 0246678565E0 0x10 PointerId                   ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x014)); // 024667856600 0x14 Position                    ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Delta                                     = (Vector2)GetInt32(new IntPtr(p + 0x01C)); // 024667856620 0x1C Delta                       ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Pressure                                  = GetSingle(new IntPtr(p + 0x024)); // 024667856640 0x24 Pressure                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Radius                                    = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 024667856660 0x28 Radius                      ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Buttons                                   = GetUInt16(new IntPtr(p + 0x030)); // 024667856680 0x30 Buttons                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.DisplayIndex                              = GetUInt16(new IntPtr(p + 0x032)); // 0246678566A0 0x32 DisplayIndex                ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
