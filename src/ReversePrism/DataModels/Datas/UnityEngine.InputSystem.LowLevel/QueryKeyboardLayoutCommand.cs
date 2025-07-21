using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxNameLength                           int IL2CPP_TYPE_I4
    // 010 BaseCommand                              ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 NameBuffer                               ModelEnumType <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer Int32
    public partial class QueryKeyboardLayoutCommand : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public <nameBuffer>e__FixedBuffer               NameBuffer                              { get; set; }

        public static QueryKeyboardLayoutCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryKeyboardLayoutCommand() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0x10 BaseCommand                 ( ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.NameBuffer                                = (<nameBuffer>e__FixedBuffer)GetInt32(new IntPtr(p + 0x018)); // 0x18 NameBuffer                  ( ModelEnumType <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer <nameBuffer>e__FixedBuffer Int32 )

            return value;
        }
    }
}
