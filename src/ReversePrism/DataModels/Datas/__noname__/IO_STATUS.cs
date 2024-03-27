using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 010 Pointer                                  <int> IL2CPP_TYPE_I
    public partial class IO_STATUS
    {
        public uint                                     Status                                  { get; set; }

        public static IO_STATUS? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IO_STATUS();

            value.Status                                    = GetUInt32(new IntPtr(p + 0x010)); // 0270D692A630 0x10 Status                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
