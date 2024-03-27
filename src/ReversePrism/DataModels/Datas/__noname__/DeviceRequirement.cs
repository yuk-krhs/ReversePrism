using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ControlPath                            000186671BA0 ModelPrimitiveType string string string String
    // 018 M_Flags                                  000186526CB0 ModelEnumType Flags Flags Flags Int32
    public partial class DeviceRequirement
    {
        public string                                   M_ControlPath                           { get; set; }
        public Flags                                    M_Flags                                 { get; set; }

        public static DeviceRequirement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeviceRequirement();

            value.M_ControlPath                             = GetString(new IntPtr(p + 0x010)); // 0270D7672240 0x10 M_ControlPath               ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Flags                                   = (Flags)GetInt32(new IntPtr(p + 0x018)); // 0270D7672260 0x18 M_Flags                     ( 000186526CB0 ModelEnumType Flags Flags Flags Int32 )

            return value;
        }
    }
}
