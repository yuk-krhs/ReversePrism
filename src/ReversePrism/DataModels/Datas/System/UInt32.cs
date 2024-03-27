using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  000186699A20 ModelPrimitiveType uint uint uint UInt32
    // 000 MaxValue                                 uint IL2CPP_TYPE_U4
    // 000 MinValue                                 uint IL2CPP_TYPE_U4
    public partial class UInt32
    {
        public uint                                     M_value                                 { get; set; }

        public static UInt32? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UInt32();

            value.M_value                                   = GetUInt32(new IntPtr(p + 0x010)); // 0270001DBD40 0x10 M_value                     ( 000186699A20 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
