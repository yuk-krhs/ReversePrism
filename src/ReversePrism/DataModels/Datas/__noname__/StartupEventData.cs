using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  0001866722E0 ModelPrimitiveType string string string String
    // 018 Devices                                  000185CCA0B8 ModelEnumListType DeviceInfo[] DeviceInfo[] List<DeviceInfo> Pointer
    // 020 Unrecognized_devices                     000185CCA0B8 ModelEnumListType DeviceInfo[] DeviceInfo[] List<DeviceInfo> Pointer
    public partial class StartupEventData
    {
        public string                                   Version                                 { get; set; }
        public List<DeviceInfo>?                        Devices                                 { get; set; }
        public List<DeviceInfo>?                        Unrecognized_devices                    { get; set; }

        public static StartupEventData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartupEventData();

            value.Version                                   = GetString(new IntPtr(p + 0x010)); // 027003F49C60 0x10 Version                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Devices                                   = GetEnumList<DeviceInfo>(new IntPtr(p + 0x018)); // 027003F49C80 0x18 Devices                     ( 000185CCA0B8 ModelEnumListType DeviceInfo[] DeviceInfo[] List<DeviceInfo> Pointer )
            value.Unrecognized_devices                      = GetEnumList<DeviceInfo>(new IntPtr(p + 0x020)); // 027003F49CA0 0x20 Unrecognized_devices        ( 000185CCA0B8 ModelEnumListType DeviceInfo[] DeviceInfo[] List<DeviceInfo> Pointer )

            return value;
        }
    }
}
