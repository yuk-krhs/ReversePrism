using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_InterfaceName                          ModelPrimitiveType string string string String
    // 018 M_DeviceClass                            ModelPrimitiveType string string string String
    // 020 M_Manufacturer                           ModelPrimitiveType string string string String
    // 028 M_Product                                ModelPrimitiveType string string string String
    // 030 M_Serial                                 ModelPrimitiveType string string string String
    // 038 M_Version                                ModelPrimitiveType string string string String
    // 040 M_Capabilities                           ModelPrimitiveType string string string String
    public partial class InputDeviceDescription : DataModel
    {
        public string                                   M_InterfaceName                         { get; set; }
        public string                                   M_DeviceClass                           { get; set; }
        public string                                   M_Manufacturer                          { get; set; }
        public string                                   M_Product                               { get; set; }
        public string                                   M_Serial                                { get; set; }
        public string                                   M_Version                               { get; set; }
        public string                                   M_Capabilities                          { get; set; }

        public static InputDeviceDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputDeviceDescription() { Pointer= p0 };

            value.M_InterfaceName                           = GetString(new IntPtr(p + 0x010)); // 0x10 M_InterfaceName             ( ModelPrimitiveType string string string String )
            value.M_DeviceClass                             = GetString(new IntPtr(p + 0x018)); // 0x18 M_DeviceClass               ( ModelPrimitiveType string string string String )
            value.M_Manufacturer                            = GetString(new IntPtr(p + 0x020)); // 0x20 M_Manufacturer              ( ModelPrimitiveType string string string String )
            value.M_Product                                 = GetString(new IntPtr(p + 0x028)); // 0x28 M_Product                   ( ModelPrimitiveType string string string String )
            value.M_Serial                                  = GetString(new IntPtr(p + 0x030)); // 0x30 M_Serial                    ( ModelPrimitiveType string string string String )
            value.M_Version                                 = GetString(new IntPtr(p + 0x038)); // 0x38 M_Version                   ( ModelPrimitiveType string string string String )
            value.M_Capabilities                            = GetString(new IntPtr(p + 0x040)); // 0x40 M_Capabilities              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
