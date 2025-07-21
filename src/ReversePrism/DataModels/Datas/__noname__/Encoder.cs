using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Bits                                     ModelPrimitiveType int int int Int32
    // 03C BitCount                                 ModelPrimitiveType int int int Int32
    public partial class Encoder : DataModel
    {
        public int                                      Bits                                    { get; set; }
        public int                                      BitCount                                { get; set; }

        public static Encoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Encoder() { Pointer= p0 };

            value.Bits                                      = GetInt32(new IntPtr(p + 0x038)); // 0x38 Bits                        ( ModelPrimitiveType int int int Int32 )
            value.BitCount                                  = GetInt32(new IntPtr(p + 0x03C)); // 0x3C BitCount                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
