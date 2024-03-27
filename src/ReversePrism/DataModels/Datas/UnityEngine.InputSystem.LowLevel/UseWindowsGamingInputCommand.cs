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
    // 018 Enable                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class UseWindowsGamingInputCommand
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public sbyte                                    Enable                                  { get; set; }

        public static UseWindowsGamingInputCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UseWindowsGamingInputCommand();

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0270D77FD090 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.Enable                                    = GetSByte(new IntPtr(p + 0x018)); // 0270D77FD0B0 0x18 Enable                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
