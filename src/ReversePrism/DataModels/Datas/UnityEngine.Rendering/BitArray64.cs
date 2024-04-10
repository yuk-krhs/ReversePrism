using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class BitArray64 : DataModel
    {
        public ulong                                    Data                                    { get; set; }

        public static BitArray64? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitArray64() { Pointer= p0 };

            value.Data                                      = GetUInt64(new IntPtr(p + 0x010)); // 024669309250 0x10 Data                        ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
