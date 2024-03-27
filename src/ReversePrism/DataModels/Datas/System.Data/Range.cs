using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Max                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 IsNotNull                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Range
    {
        public int                                      Min                                     { get; set; }
        public int                                      Max                                     { get; set; }
        public bool                                     IsNotNull                               { get; set; }

        public static Range? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Range();

            value.Min                                       = GetInt32(new IntPtr(p + 0x010)); // 0270D892EF70 0x10 Min                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Max                                       = GetInt32(new IntPtr(p + 0x014)); // 0270D892EF90 0x14 Max                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsNotNull                                 = GetBool(new IntPtr(p + 0x018)); // 0270D892EFB0 0x18 IsNotNull                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
