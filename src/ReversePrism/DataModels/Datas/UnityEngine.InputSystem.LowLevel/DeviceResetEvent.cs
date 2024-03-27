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
    // 018 HardReset                                000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class DeviceResetEvent
    {
        public InputEvent                               BaseEvent                               { get; set; }
        public bool                                     HardReset                               { get; set; }

        public static DeviceResetEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeviceResetEvent();

            value.BaseEvent                                 = (InputEvent)GetInt32(new IntPtr(p + 0x010)); // 0270D77FFFB8 0x10 BaseEvent                   ( 0001866FCF10 ModelEnumType InputEvent InputEvent InputEvent Int32 )
            value.HardReset                                 = GetBool(new IntPtr(p + 0x018)); // 0270D77FFFD8 0x18 HardReset                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
