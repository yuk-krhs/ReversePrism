using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  ModelPrimitiveType ulong ulong ulong UInt64
    // 000 MaxValue                                 ulong IL2CPP_TYPE_U8
    // 000 MinValue                                 ulong IL2CPP_TYPE_U8
    public partial class UInt64 : DataModel
    {
        public ulong                                    M_value                                 { get; set; }

        public static UInt64? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UInt64() { Pointer= p0 };

            value.M_value                                   = GetUInt64(new IntPtr(p + 0x010)); // 0x10 M_value                     ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
