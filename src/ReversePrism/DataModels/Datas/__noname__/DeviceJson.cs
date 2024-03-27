using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DevicePath                               0001866722E0 ModelPrimitiveType string string string String
    // 018 IsOptional                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 019 IsOR                                     000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class DeviceJson
    {
        public string                                   DevicePath                              { get; set; }
        public bool                                     IsOptional                              { get; set; }
        public bool                                     IsOR                                    { get; set; }

        public static DeviceJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeviceJson();

            value.DevicePath                                = GetString(new IntPtr(p + 0x010)); // 0270D76AAAA8 0x10 DevicePath                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsOptional                                = GetBool(new IntPtr(p + 0x018)); // 0270D76AAAC8 0x18 IsOptional                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsOR                                      = GetBool(new IntPtr(p + 0x019)); // 0270D76AAAE8 0x19 IsOR                        ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
