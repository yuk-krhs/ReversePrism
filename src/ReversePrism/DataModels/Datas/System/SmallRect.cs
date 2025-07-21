using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Left                                     ModelPrimitiveType short short short Int16
    // 012 Top                                      ModelPrimitiveType short short short Int16
    // 014 Right                                    ModelPrimitiveType short short short Int16
    // 016 Bottom                                   ModelPrimitiveType short short short Int16
    public partial class SmallRect : DataModel
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
            var value   = new SmallRect() { Pointer= p0 };

            value.Left                                      = GetInt16(new IntPtr(p + 0x010)); // 0x10 Left                        ( ModelPrimitiveType short short short Int16 )
            value.Top                                       = GetInt16(new IntPtr(p + 0x012)); // 0x12 Top                         ( ModelPrimitiveType short short short Int16 )
            value.Right                                     = GetInt16(new IntPtr(p + 0x014)); // 0x14 Right                       ( ModelPrimitiveType short short short Int16 )
            value.Bottom                                    = GetInt16(new IntPtr(p + 0x016)); // 0x16 Bottom                      ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
