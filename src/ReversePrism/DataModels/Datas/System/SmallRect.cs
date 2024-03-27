using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Left                                     0001865F1520 ModelPrimitiveType short short short Int16
    // 012 Top                                      0001865F1520 ModelPrimitiveType short short short Int16
    // 014 Right                                    0001865F1520 ModelPrimitiveType short short short Int16
    // 016 Bottom                                   0001865F1520 ModelPrimitiveType short short short Int16
    public partial class SmallRect
    {
        public short                                    Left                                    { get; set; }
        public short                                    Top                                     { get; set; }
        public short                                    Right                                   { get; set; }
        public short                                    Bottom                                  { get; set; }

        public static SmallRect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SmallRect();

            value.Left                                      = GetInt16(new IntPtr(p + 0x010)); // 0270D6AC01F8 0x10 Left                        ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.Top                                       = GetInt16(new IntPtr(p + 0x012)); // 0270D6AC0218 0x12 Top                         ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.Right                                     = GetInt16(new IntPtr(p + 0x014)); // 0270D6AC0238 0x14 Right                       ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.Bottom                                    = GetInt16(new IntPtr(p + 0x016)); // 0270D6AC0258 0x16 Bottom                      ( 0001865F1520 ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
