using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 BaseCommand                              0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 LowFrequencyMotorSpeed                   000186666050 ModelPrimitiveType float float float Single
    // 01C HighFrequencyMotorSpeed                  000186666050 ModelPrimitiveType float float float Single
    public partial class DualMotorRumbleCommand : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public float                                    LowFrequencyMotorSpeed                  { get; set; }
        public float                                    HighFrequencyMotorSpeed                 { get; set; }

        public static DualMotorRumbleCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualMotorRumbleCommand() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 024667855868 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.LowFrequencyMotorSpeed                    = GetSingle(new IntPtr(p + 0x018)); // 024667855888 0x18 LowFrequencyMotorSpeed      ( 000186666050 ModelPrimitiveType float float float Single )
            value.HighFrequencyMotorSpeed                   = GetSingle(new IntPtr(p + 0x01C)); // 0246678558A8 0x1C HighFrequencyMotorSpeed     ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
