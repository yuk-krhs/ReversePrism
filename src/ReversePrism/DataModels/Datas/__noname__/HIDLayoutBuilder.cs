using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayName                              ModelPrimitiveType string string string String
    // 018 HidDescriptor                            ModelEnumType HIDDeviceDescriptor HIDDeviceDescriptor HIDDeviceDescriptor Int32
    // 048 ParentLayout                             ModelPrimitiveType string string string String
    // 050 DeviceType                               ModelClassType Type Type Type Pointer
    public partial class HIDLayoutBuilder : DataModel
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
            var value   = new HIDLayoutBuilder() { Pointer= p0 };

            value.DisplayName                               = GetString(new IntPtr(p + 0x010)); // 0x10 DisplayName                 ( ModelPrimitiveType string string string String )
            value.HidDescriptor                             = (HIDDeviceDescriptor)GetInt32(new IntPtr(p + 0x018)); // 0x18 HidDescriptor               ( ModelEnumType HIDDeviceDescriptor HIDDeviceDescriptor HIDDeviceDescriptor Int32 )
            value.ParentLayout                              = GetString(new IntPtr(p + 0x048)); // 0x48 ParentLayout                ( ModelPrimitiveType string string string String )
            value.DeviceType                                = GetObject<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 0x50 DeviceType                  ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
