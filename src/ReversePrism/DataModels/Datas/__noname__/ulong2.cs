using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Y                                        00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class ulong2
    {
        public ulong                                    X                                       { get; set; }
        public ulong                                    Y                                       { get; set; }

        public static ulong2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ulong2();

            value.X                                         = GetUInt64(new IntPtr(p + 0x010)); // 0270D9C65070 0x10 X                           ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Y                                         = GetUInt64(new IntPtr(p + 0x018)); // 0270D9C65090 0x18 Y                           ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
