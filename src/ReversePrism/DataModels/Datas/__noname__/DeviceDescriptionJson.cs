using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Interface                                ModelPrimitiveType string string string String
    // 018 Type                                     ModelPrimitiveType string string string String
    // 020 Product                                  ModelPrimitiveType string string string String
    // 028 Serial                                   ModelPrimitiveType string string string String
    // 030 Version                                  ModelPrimitiveType string string string String
    // 038 Manufacturer                             ModelPrimitiveType string string string String
    // 040 Capabilities                             ModelPrimitiveType string string string String
    public partial class DeviceDescriptionJson : DataModel
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
            var value   = new DeviceDescriptionJson() { Pointer= p0 };

            value.Interface                                 = GetString(new IntPtr(p + 0x010)); // 0x10 Interface                   ( ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelPrimitiveType string string string String )
            value.Product                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Product                     ( ModelPrimitiveType string string string String )
            value.Serial                                    = GetString(new IntPtr(p + 0x028)); // 0x28 Serial                      ( ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x030)); // 0x30 Version                     ( ModelPrimitiveType string string string String )
            value.Manufacturer                              = GetString(new IntPtr(p + 0x038)); // 0x38 Manufacturer                ( ModelPrimitiveType string string string String )
            value.Capabilities                              = GetString(new IntPtr(p + 0x040)); // 0x40 Capabilities                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
