using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  000186697450 ModelPrimitiveType ushort ushort ushort UInt16
    // 000 MaxValue                                 ushort IL2CPP_TYPE_U2
    // 000 MinValue                                 ushort IL2CPP_TYPE_U2
    public partial class UInt16
    {
        public ushort                                   M_value                                 { get; set; }

        public static UInt16? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UInt16();

            value.M_value                                   = GetUInt16(new IntPtr(p + 0x010)); // 0270035BB418 0x10 M_value                     ( 000186697450 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
