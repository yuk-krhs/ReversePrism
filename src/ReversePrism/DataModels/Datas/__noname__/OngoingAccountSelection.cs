using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Device                                   0001866FB2E0 ModelClassType InputDevice InputDevice InputDevice Pointer
    // 018 UserId                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class OngoingAccountSelection
    {
        public InputDevice?                             Device                                  { get; set; }
        public uint                                     UserId                                  { get; set; }

        public static OngoingAccountSelection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OngoingAccountSelection();

            value.Device                                    = GetObject<InputDevice>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputDevice.FromPointer); // 0270D7724230 0x10 Device                      ( 0001866FB2E0 ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.UserId                                    = GetUInt32(new IntPtr(p + 0x018)); // 0270D7724250 0x18 UserId                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
