using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Device                                   ModelClassType InputDevice InputDevice InputDevice Pointer
    // 018 UserId                                   ModelPrimitiveType uint uint uint UInt32
    public partial class OngoingAccountSelection : DataModel
    {
        public InputDevice?                             Device                                  { get; set; }
        public uint                                     UserId                                  { get; set; }

        public static OngoingAccountSelection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OngoingAccountSelection() { Pointer= p0 };

            value.Device                                    = GetObject<InputDevice>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputDevice.FromPointer); // 0x10 Device                      ( ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.UserId                                    = GetUInt32(new IntPtr(p + 0x018)); // 0x18 UserId                      ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
