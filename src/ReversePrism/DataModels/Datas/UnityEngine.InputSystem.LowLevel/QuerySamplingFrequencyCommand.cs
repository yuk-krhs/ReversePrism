using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 BaseCommand                              ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 Frequency                                ModelPrimitiveType float float float Single
    public partial class QuerySamplingFrequencyCommand : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public float                                    Frequency                               { get; set; }

        public static QuerySamplingFrequencyCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuerySamplingFrequencyCommand() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0x10 BaseCommand                 ( ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.Frequency                                 = GetSingle(new IntPtr(p + 0x018)); // 0x18 Frequency                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
