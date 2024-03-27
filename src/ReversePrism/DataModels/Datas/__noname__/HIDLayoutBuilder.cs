using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayName                              0001866722E0 ModelPrimitiveType string string string String
    // 018 HidDescriptor                            0001866F2240 ModelEnumType HIDDeviceDescriptor HIDDeviceDescriptor HIDDeviceDescriptor Int32
    // 048 ParentLayout                             0001866722E0 ModelPrimitiveType string string string String
    // 050 DeviceType                               000186692F60 ModelClassType Type Type Type Pointer
    public partial class HIDLayoutBuilder
    {
        public string                                   DisplayName                             { get; set; }
        public HIDDeviceDescriptor                      HidDescriptor                           { get; set; }
        public string                                   ParentLayout                            { get; set; }
        public Type?                                    DeviceType                              { get; set; }

        public static HIDLayoutBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HIDLayoutBuilder();

            value.DisplayName                               = GetString(new IntPtr(p + 0x010)); // 0270001D1890 0x10 DisplayName                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.HidDescriptor                             = (HIDDeviceDescriptor)GetInt32(new IntPtr(p + 0x018)); // 0270001D18B0 0x18 HidDescriptor               ( 0001866F2240 ModelEnumType HIDDeviceDescriptor HIDDeviceDescriptor HIDDeviceDescriptor Int32 )
            value.ParentLayout                              = GetString(new IntPtr(p + 0x048)); // 0270001D18D0 0x48 ParentLayout                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DeviceType                                = GetObject<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 0270001D18F0 0x50 DeviceType                  ( 000186692F60 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
