using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Size                                     ModelEnumType Coord Coord Coord Int32
    // 014 CursorPosition                           ModelEnumType Coord Coord Coord Int32
    // 018 Attribute                                ModelPrimitiveType short short short Int16
    // 01A Window                                   ModelEnumType SmallRect SmallRect SmallRect Int32
    // 022 MaxWindowSize                            ModelEnumType Coord Coord Coord Int32
    public partial class ConsoleScreenBufferInfo : DataModel
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
            var value   = new ConsoleScreenBufferInfo() { Pointer= p0 };

            value.Size                                      = (Coord)GetInt32(new IntPtr(p + 0x010)); // 0x10 Size                        ( ModelEnumType Coord Coord Coord Int32 )
            value.CursorPosition                            = (Coord)GetInt32(new IntPtr(p + 0x014)); // 0x14 CursorPosition              ( ModelEnumType Coord Coord Coord Int32 )
            value.Attribute                                 = GetInt16(new IntPtr(p + 0x018)); // 0x18 Attribute                   ( ModelPrimitiveType short short short Int16 )
            value.Window                                    = (SmallRect)GetInt32(new IntPtr(p + 0x01A)); // 0x1A Window                      ( ModelEnumType SmallRect SmallRect SmallRect Int32 )
            value.MaxWindowSize                             = (Coord)GetInt32(new IntPtr(p + 0x022)); // 0x22 MaxWindowSize               ( ModelEnumType Coord Coord Coord Int32 )

            return value;
        }
    }
}
