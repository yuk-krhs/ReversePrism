using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DeviceId                               00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 M_Initialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class InputDevice
    {
        public ulong                                    M_DeviceId                              { get; set; }
        public bool                                     M_Initialized                           { get; set; }

        public static InputDevice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputDevice();

            value.M_DeviceId                                = GetUInt64(new IntPtr(p + 0x010)); // 0270020FD0B8 0x10 M_DeviceId                  ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_Initialized                             = GetBool(new IntPtr(p + 0x018)); // 0270020FD0D8 0x18 M_Initialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
