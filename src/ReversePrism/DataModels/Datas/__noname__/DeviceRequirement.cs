using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ControlPath                            ModelPrimitiveType string string string String
    // 018 M_Flags                                  ModelEnumType Flags Flags Flags Int32
    public partial class DeviceRequirement : DataModel
    {
        public string                                   M_ControlPath                           { get; set; }
        public Flags                                    M_Flags                                 { get; set; }

        public static DeviceRequirement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeviceRequirement() { Pointer= p0 };

            value.M_ControlPath                             = GetString(new IntPtr(p + 0x010)); // 0x10 M_ControlPath               ( ModelPrimitiveType string string string String )
            value.M_Flags                                   = (Flags)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Flags                     ( ModelEnumType Flags Flags Flags Int32 )

            return value;
        }
    }
}
