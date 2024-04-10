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
    public partial class DeviceJson : DataModel
    {
        public string                                   DevicePath                              { get; set; }
        public bool                                     IsOptional                              { get; set; }
        public bool                                     IsOR                                    { get; set; }

        public static DeviceJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeviceJson() { Pointer= p0 };

            value.DevicePath                                = GetString(new IntPtr(p + 0x010)); // 024667712AA8 0x10 DevicePath                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsOptional                                = GetBool(new IntPtr(p + 0x018)); // 024667712AC8 0x18 IsOptional                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsOR                                      = GetBool(new IntPtr(p + 0x019)); // 024667712AE8 0x19 IsOR                        ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
