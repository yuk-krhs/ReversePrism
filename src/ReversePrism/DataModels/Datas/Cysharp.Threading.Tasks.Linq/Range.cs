using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 End                                      0001865F4260 ModelPrimitiveType int int int Int32
    public partial class Range
    {
        public int                                      Start                                   { get; set; }
        public int                                      End                                     { get; set; }

        public static Range? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Range();

            value.Start                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D84EB0E0 0x10 Start                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x014)); // 0270D84EB100 0x14 End                         ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
