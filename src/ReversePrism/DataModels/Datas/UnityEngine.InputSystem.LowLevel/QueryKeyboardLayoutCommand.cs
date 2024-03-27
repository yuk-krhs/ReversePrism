using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxNameLength                           int IL2CPP_TYPE_I4
    // 010 BaseCommand                              0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 NameBuffer                               000186699A90 ModelEnumType <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer Int32
    public partial class QueryKeyboardLayoutCommand
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public <nameBuffer>e__FixedBuffer               NameBuffer                              { get; set; }

        public static QueryKeyboardLayoutCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryKeyboardLayoutCommand();

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0270D77FB7D0 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.NameBuffer                                = (<nameBuffer>e__FixedBuffer)GetInt32(new IntPtr(p + 0x018)); // 0270D77FB7F0 0x18 NameBuffer                  ( 000186699A90 ModelEnumType <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer Int32 )

            return value;
        }
    }
}
