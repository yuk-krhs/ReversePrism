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
    // 018 WarpPositionInPlayerDisplaySpace         0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class WarpMousePositionCommand
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public Vector2                                  WarpPositionInPlayerDisplaySpace        { get; set; }

        public static WarpMousePositionCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WarpMousePositionCommand();

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0270D77FD2C8 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.WarpPositionInPlayerDisplaySpace          = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0270D77FD2E8 0x18 WarpPositionInPlayerDisplaySpace ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
