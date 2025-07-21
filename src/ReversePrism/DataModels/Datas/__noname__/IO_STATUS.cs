using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelPrimitiveType uint uint uint UInt32
    // 010 Pointer                                  <int> IL2CPP_TYPE_I
    public partial class IO_STATUS : DataModel
    {
        public uint                                     Status                                  { get; set; }

        public static IO_STATUS? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IO_STATUS() { Pointer= p0 };

            value.Status                                    = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Status                      ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
