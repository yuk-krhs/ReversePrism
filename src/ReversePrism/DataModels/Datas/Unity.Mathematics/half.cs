using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 000 zero                                     half IL2CPP_TYPE_VALUETYPE
    public partial class half : DataModel
    {
        public ushort                                   Value                                   { get; set; }

        public static half? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new half() { Pointer= p0 };

            value.Value                                     = GetUInt16(new IntPtr(p + 0x010)); // 0245A15A5D28 0x10 Value                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
