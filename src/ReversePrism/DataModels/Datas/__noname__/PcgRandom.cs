using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Increment                                ModelPrimitiveType ulong ulong ulong UInt64
    // 018 State                                    ModelPrimitiveType ulong ulong ulong UInt64
    public partial class PcgRandom : DataModel
    {
        public ulong                                    Increment                               { get; set; }
        public ulong                                    State                                   { get; set; }

        public static PcgRandom? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PcgRandom() { Pointer= p0 };

            value.Increment                                 = GetUInt64(new IntPtr(p + 0x010)); // 0x10 Increment                   ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.State                                     = GetUInt64(new IntPtr(p + 0x018)); // 0x18 State                       ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
