using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Description                              0001865ED710 ModelEnumType InputDeviceDescription InputDeviceDescription InputDeviceDescription Int32
    // 048 DeviceId                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 04C IsNative                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 04D IsRemoved                                000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class AvailableDevice
    {
        public InputDeviceDescription                   Description                             { get; set; }
        public int                                      DeviceId                                { get; set; }
        public bool                                     IsNative                                { get; set; }
        public bool                                     IsRemoved                               { get; set; }

        public static AvailableDevice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AvailableDevice();

            value.Description                               = (InputDeviceDescription)GetInt32(new IntPtr(p + 0x010)); // 0270001E7830 0x10 Description                 ( 0001865ED710 ModelEnumType InputDeviceDescription InputDeviceDescription InputDeviceDescription Int32 )
            value.DeviceId                                  = GetInt32(new IntPtr(p + 0x048)); // 0270001E7850 0x48 DeviceId                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsNative                                  = GetBool(new IntPtr(p + 0x04C)); // 0270001E7870 0x4C IsNative                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsRemoved                                 = GetBool(new IntPtr(p + 0x04D)); // 0270001E7890 0x4D IsRemoved                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
