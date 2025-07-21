using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     ModelEnumType BitField64 BitField64 BitField64 Int32
    public partial class BitField64DebugView : DataModel
    {
        public BitField64                               Data                                    { get; set; }

        public static BitField64DebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitField64DebugView() { Pointer= p0 };

            value.Data                                      = (BitField64)GetInt32(new IntPtr(p + 0x010)); // 0x10 Data                        ( ModelEnumType BitField64 BitField64 BitField64 Int32 )

            return value;
        }
    }
}
