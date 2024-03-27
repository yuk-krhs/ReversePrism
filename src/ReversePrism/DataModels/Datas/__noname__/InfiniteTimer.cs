using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Cancelled                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class InfiniteTimer
    {
        public int                                      Cancelled                               { get; set; }

        public static InfiniteTimer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InfiniteTimer();

            value.Cancelled                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D7A31E68 0x18 Cancelled                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
