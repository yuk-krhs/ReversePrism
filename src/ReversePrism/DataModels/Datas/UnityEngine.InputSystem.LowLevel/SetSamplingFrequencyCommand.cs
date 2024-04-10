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
    // 018 Frequency                                000186666050 ModelPrimitiveType float float float Single
    public partial class SetSamplingFrequencyCommand : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public float                                    Frequency                               { get; set; }

        public static SetSamplingFrequencyCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetSamplingFrequencyCommand() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 024667854E58 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.Frequency                                 = GetSingle(new IntPtr(p + 0x018)); // 024667854E78 0x18 Frequency                   ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
