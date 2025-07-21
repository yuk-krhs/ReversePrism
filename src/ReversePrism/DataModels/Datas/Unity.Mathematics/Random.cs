using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    ModelPrimitiveType uint uint uint UInt32
    public partial class Random : DataModel
    {
        public uint                                     State                                   { get; set; }

        public static Random? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Random() { Pointer= p0 };

            value.State                                     = GetUInt32(new IntPtr(p + 0x010)); // 0x10 State                       ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
