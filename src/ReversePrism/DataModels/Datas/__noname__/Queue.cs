using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DurationMilliseconds                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class Queue
    {
        public int                                      M_DurationMilliseconds                  { get; set; }

        public static Queue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Queue();

            value.M_DurationMilliseconds                    = GetInt32(new IntPtr(p + 0x010)); // 0270D7A147C8 0x10 M_DurationMilliseconds      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
