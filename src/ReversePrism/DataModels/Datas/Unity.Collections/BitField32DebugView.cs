using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BitField                                 000186761770 ModelEnumType BitField32 BitField32 BitField32 Int32
    public partial class BitField32DebugView
    {
        public BitField32                               BitField                                { get; set; }

        public static BitField32DebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitField32DebugView();

            value.BitField                                  = (BitField32)GetInt32(new IntPtr(p + 0x010)); // 0270D988AC50 0x10 BitField                    ( 000186761770 ModelEnumType BitField32 BitField32 BitField32 Int32 )

            return value;
        }
    }
}
