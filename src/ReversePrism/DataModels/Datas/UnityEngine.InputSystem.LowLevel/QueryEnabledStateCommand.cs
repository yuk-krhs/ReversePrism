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
    // 018 IsEnabled                                000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class QueryEnabledStateCommand : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public bool                                     IsEnabled                               { get; set; }

        public static QueryEnabledStateCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryEnabledStateCommand() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 024667853580 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.IsEnabled                                 = GetBool(new IntPtr(p + 0x018)); // 0246678535A0 0x18 IsEnabled                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
