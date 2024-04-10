using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 From                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 014 To                                       0001865F4260 ModelPrimitiveType int int int Int32
    public partial class Range : DataModel
    {
        public int                                      From                                    { get; set; }
        public int                                      To                                      { get; set; }

        public static Range? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Range() { Pointer= p0 };

            value.From                                      = GetInt32(new IntPtr(p + 0x010)); // 02466BE22028 0x10 From                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.To                                        = GetInt32(new IntPtr(p + 0x014)); // 02466BE22048 0x14 To                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
