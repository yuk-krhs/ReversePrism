using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data1                                    00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Data2                                    00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class BitArray128
    {
        public ulong                                    Data1                                   { get; set; }
        public ulong                                    Data2                                   { get; set; }

        public static BitArray128? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitArray128();

            value.Data1                                     = GetUInt64(new IntPtr(p + 0x010)); // 0270D929F0F0 0x10 Data1                       ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Data2                                     = GetUInt64(new IntPtr(p + 0x018)); // 0270D929F110 0x18 Data2                       ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
