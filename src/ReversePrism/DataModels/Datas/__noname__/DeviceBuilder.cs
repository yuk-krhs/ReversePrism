using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Device                                   0001866FAE50 ModelClassType InputDevice InputDevice InputDevice Pointer
    public partial class DeviceBuilder
    {
        public InputDevice?                             Device                                  { get; set; }

        public static DeviceBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeviceBuilder();

            value.Device                                    = GetObject<InputDevice>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputDevice.FromPointer); // 0270D76C87E8 0x10 Device                      ( 0001866FAE50 ModelClassType InputDevice InputDevice InputDevice Pointer )

            return value;
        }
    }
}
