using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BitField                                 ModelEnumType BitField32 BitField32 BitField32 Int32
    public partial class BitField32DebugView : DataModel
    {
        public BitField32                               BitField                                { get; set; }

        public static BitField32DebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitField32DebugView() { Pointer= p0 };

            value.BitField                                  = (BitField32)GetInt32(new IntPtr(p + 0x010)); // 0x10 BitField                    ( ModelEnumType BitField32 BitField32 BitField32 Int32 )

            return value;
        }
    }
}
