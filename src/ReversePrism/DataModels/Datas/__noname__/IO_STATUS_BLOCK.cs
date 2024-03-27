using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   0001865B0870 ModelEnumType IO_STATUS IO_STATUS IO_STATUS Int32
    // 018 Information                              <int> IL2CPP_TYPE_I
    public partial class IO_STATUS_BLOCK
    {
        public IO_STATUS                                Status                                  { get; set; }

        public static IO_STATUS_BLOCK? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IO_STATUS_BLOCK();

            value.Status                                    = (IO_STATUS)GetInt32(new IntPtr(p + 0x010)); // 0270D692A670 0x10 Status                      ( 0001865B0870 ModelEnumType IO_STATUS IO_STATUS IO_STATUS Int32 )

            return value;
        }
    }
}
