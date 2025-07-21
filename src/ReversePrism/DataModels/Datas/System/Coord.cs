using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelPrimitiveType short short short Int16
    // 012 Y                                        ModelPrimitiveType short short short Int16
    public partial class Coord : DataModel
    {
        public short                                    X                                       { get; set; }
        public short                                    Y                                       { get; set; }

        public static Coord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Coord() { Pointer= p0 };

            value.X                                         = GetInt16(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType short short short Int16 )
            value.Y                                         = GetInt16(new IntPtr(p + 0x012)); // 0x12 Y                           ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
