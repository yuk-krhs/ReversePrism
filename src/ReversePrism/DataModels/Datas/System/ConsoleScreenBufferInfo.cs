using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Size                                     0001866208A0 ModelEnumType Coord Coord Coord Int32
    // 014 CursorPosition                           0001866208A0 ModelEnumType Coord Coord Coord Int32
    // 018 Attribute                                0001865F1520 ModelPrimitiveType short short short Int16
    // 01A Window                                   00018651F800 ModelEnumType SmallRect SmallRect SmallRect Int32
    // 022 MaxWindowSize                            0001866208A0 ModelEnumType Coord Coord Coord Int32
    public partial class ConsoleScreenBufferInfo
    {
        public Coord                                    Size                                    { get; set; }
        public Coord                                    CursorPosition                          { get; set; }
        public short                                    Attribute                               { get; set; }
        public SmallRect                                Window                                  { get; set; }
        public Coord                                    MaxWindowSize                           { get; set; }

        public static ConsoleScreenBufferInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConsoleScreenBufferInfo();

            value.Size                                      = (Coord)GetInt32(new IntPtr(p + 0x010)); // 0270D6AC0278 0x10 Size                        ( 0001866208A0 ModelEnumType Coord Coord Coord Int32 )
            value.CursorPosition                            = (Coord)GetInt32(new IntPtr(p + 0x014)); // 0270D6AC0298 0x14 CursorPosition              ( 0001866208A0 ModelEnumType Coord Coord Coord Int32 )
            value.Attribute                                 = GetInt16(new IntPtr(p + 0x018)); // 0270D6AC02B8 0x18 Attribute                   ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.Window                                    = (SmallRect)GetInt32(new IntPtr(p + 0x01A)); // 0270D6AC02D8 0x1A Window                      ( 00018651F800 ModelEnumType SmallRect SmallRect SmallRect Int32 )
            value.MaxWindowSize                             = (Coord)GetInt32(new IntPtr(p + 0x022)); // 0270D6AC02F8 0x22 MaxWindowSize               ( 0001866208A0 ModelEnumType Coord Coord Coord Int32 )

            return value;
        }
    }
}
