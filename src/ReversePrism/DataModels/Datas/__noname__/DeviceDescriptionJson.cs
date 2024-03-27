using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Interface                                0001866722E0 ModelPrimitiveType string string string String
    // 018 Type                                     0001866722E0 ModelPrimitiveType string string string String
    // 020 Product                                  0001866722E0 ModelPrimitiveType string string string String
    // 028 Serial                                   0001866722E0 ModelPrimitiveType string string string String
    // 030 Version                                  0001866722E0 ModelPrimitiveType string string string String
    // 038 Manufacturer                             0001866722E0 ModelPrimitiveType string string string String
    // 040 Capabilities                             0001866722E0 ModelPrimitiveType string string string String
    public partial class DeviceDescriptionJson
    {
        public string                                   Interface                               { get; set; }
        public string                                   Type                                    { get; set; }
        public string                                   Product                                 { get; set; }
        public string                                   Serial                                  { get; set; }
        public string                                   Version                                 { get; set; }
        public string                                   Manufacturer                            { get; set; }
        public string                                   Capabilities                            { get; set; }

        public static DeviceDescriptionJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeviceDescriptionJson();

            value.Interface                                 = GetString(new IntPtr(p + 0x010)); // 0270001CE7D8 0x10 Interface                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 0270001CE7F8 0x18 Type                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Product                                   = GetString(new IntPtr(p + 0x020)); // 0270001CE818 0x20 Product                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Serial                                    = GetString(new IntPtr(p + 0x028)); // 0270001CE838 0x28 Serial                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x030)); // 0270001CE858 0x30 Version                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Manufacturer                              = GetString(new IntPtr(p + 0x038)); // 0270001CE878 0x38 Manufacturer                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Capabilities                              = GetString(new IntPtr(p + 0x040)); // 0270001CE898 0x40 Capabilities                ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
