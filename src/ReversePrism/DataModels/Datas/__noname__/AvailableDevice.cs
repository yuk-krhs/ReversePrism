using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Description                              ModelEnumType InputDeviceDescription InputDeviceDescription InputDeviceDescription Int32
    // 048 DeviceId                                 ModelPrimitiveType int int int Int32
    // 04C IsNative                                 ModelPrimitiveType bool bool bool Bool
    // 04D IsRemoved                                ModelPrimitiveType bool bool bool Bool
    public partial class AvailableDevice : DataModel
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
            var value   = new AvailableDevice() { Pointer= p0 };

            value.Description                               = (InputDeviceDescription)GetInt32(new IntPtr(p + 0x010)); // 0x10 Description                 ( ModelEnumType InputDeviceDescription InputDeviceDescription InputDeviceDescription Int32 )
            value.DeviceId                                  = GetInt32(new IntPtr(p + 0x048)); // 0x48 DeviceId                    ( ModelPrimitiveType int int int Int32 )
            value.IsNative                                  = GetBool(new IntPtr(p + 0x04C)); // 0x4C IsNative                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsRemoved                                 = GetBool(new IntPtr(p + 0x04D)); // 0x4D IsRemoved                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
