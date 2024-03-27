using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Type                                     int IL2CPP_TYPE_I4
    // 010 BaseEvent                                0001866FCF10 ModelEnumType InputEvent InputEvent InputEvent Int32
    public partial class DeviceRemoveEvent
    {
        public InputEvent                               BaseEvent                               { get; set; }

        public static DeviceRemoveEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeviceRemoveEvent();

            value.BaseEvent                                 = (InputEvent)GetInt32(new IntPtr(p + 0x010)); // 0270D77FFDE8 0x10 BaseEvent                   ( 0001866FCF10 ModelEnumType InputEvent InputEvent InputEvent Int32 )

            return value;
        }
    }
}
