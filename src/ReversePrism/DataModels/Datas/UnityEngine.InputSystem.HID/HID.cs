using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kHIDInterface                            string IL2CPP_TYPE_STRING
    // 000 kHIDNamespace                            string IL2CPP_TYPE_STRING
    // 170 M_HaveParsedHIDDescriptor                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 178 M_HIDDescriptor                          0001866F1FD0 ModelEnumType HIDDeviceDescriptor HIDDeviceDescriptor HIDDeviceDescriptor Int32
    public partial class HID : DataModel
    {
        public bool                                     M_HaveParsedHIDDescriptor               { get; set; }
        public HIDDeviceDescriptor                      M_HIDDescriptor                         { get; set; }

        public static HID? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HID() { Pointer= p0 };

            value.M_HaveParsedHIDDescriptor                 = GetBool(new IntPtr(p + 0x170)); // 0245A3496CF0 0x170 M_HaveParsedHIDDescriptor   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_HIDDescriptor                           = (HIDDeviceDescriptor)GetInt32(new IntPtr(p + 0x178)); // 0245A3496D10 0x178 M_HIDDescriptor             ( 0001866F1FD0 ModelEnumType HIDDeviceDescriptor HIDDeviceDescriptor HIDDeviceDescriptor Int32 )

            return value;
        }
    }
}
