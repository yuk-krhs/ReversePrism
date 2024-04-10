using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_InterfaceName                          000186671910 ModelPrimitiveType string string string String
    // 018 M_DeviceClass                            000186671910 ModelPrimitiveType string string string String
    // 020 M_Manufacturer                           000186671910 ModelPrimitiveType string string string String
    // 028 M_Product                                000186671910 ModelPrimitiveType string string string String
    // 030 M_Serial                                 000186671910 ModelPrimitiveType string string string String
    // 038 M_Version                                000186671910 ModelPrimitiveType string string string String
    // 040 M_Capabilities                           000186671910 ModelPrimitiveType string string string String
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

            value.M_InterfaceName                           = GetString(new IntPtr(p + 0x010)); // 0245A2E363B8 0x10 M_InterfaceName             ( 000186671910 ModelPrimitiveType string string string String )
            value.M_DeviceClass                             = GetString(new IntPtr(p + 0x018)); // 0245A2E363D8 0x18 M_DeviceClass               ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Manufacturer                            = GetString(new IntPtr(p + 0x020)); // 0245A2E363F8 0x20 M_Manufacturer              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Product                                 = GetString(new IntPtr(p + 0x028)); // 0245A2E36418 0x28 M_Product                   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Serial                                  = GetString(new IntPtr(p + 0x030)); // 0245A2E36438 0x30 M_Serial                    ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Version                                 = GetString(new IntPtr(p + 0x038)); // 0245A2E36458 0x38 M_Version                   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Capabilities                            = GetString(new IntPtr(p + 0x040)); // 0245A2E36478 0x40 M_Capabilities              ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
