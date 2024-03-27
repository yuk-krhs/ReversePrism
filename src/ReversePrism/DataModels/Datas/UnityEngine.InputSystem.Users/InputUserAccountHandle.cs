using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ApiName                                000186671910 ModelPrimitiveType string string string String
    // 018 M_Handle                                 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class InputUserAccountHandle
    {
        public string                                   M_ApiName                               { get; set; }
        public ulong                                    M_Handle                                { get; set; }

        public static InputUserAccountHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputUserAccountHandle();

            value.M_ApiName                                 = GetString(new IntPtr(p + 0x010)); // 0270D7787770 0x10 M_ApiName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Handle                                  = GetUInt64(new IntPtr(p + 0x018)); // 0270D7787790 0x18 M_Handle                    ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
