using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Order                                    0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MemoryPackOrderAttribute : DataModel
    {
        public int                                      Order                                   { get; set; }

        public static MemoryPackOrderAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackOrderAttribute() { Pointer= p0 };

            value.Order                                     = GetInt32(new IntPtr(p + 0x010)); // 02466AF6EF58 0x10 Order                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
